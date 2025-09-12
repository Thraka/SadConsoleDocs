// Tool: md2mdx.cs
// Purpose: Convert DocFX Markdown files into MDX pages for Starlight.
// Hardcoded paths (relative to this folder):
//   Input:  ../docfx/root  (scans recursively for *.md)
//   Output: ../starlight/src/content/docs  (mirrors directory structure, .md -> .mdx)
// Outputs created:
//   ./unresolved-xrefs.json   # list of detected xref:UID occurrences for later resolution
// If you need a NuGet package in-file, use the script package header format, e.g.:
//   #:package YamlDotNet@12.0.2
// Run:
//   dotnet build md2mdx.cs
//   dotnet run md2mdx.cs

using System.Text.RegularExpressions;
using System.Text;

// md2mdx.cs
// Hardcoded source and destination relative to this tooling folder
var srcRoot = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "docfx", "root"));
var dstRoot = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "starlight", "src", "content", "docs"));

if (!Directory.Exists(srcRoot))
{
    Console.WriteLine($"Source docfx root not found: {srcRoot}");
    return;
}

Directory.CreateDirectory(dstRoot);

var mdFiles = Directory.GetFiles(srcRoot, "*.md", SearchOption.AllDirectories);
var unresolved = new List<Dictionary<string,string>>();

foreach (var md in mdFiles)
{
    var rel = Path.GetRelativePath(srcRoot, md).Replace('\\', '/');
    Console.WriteLine($"Processing: {rel} ({md})");

    // Special-case: root index.md -> site index page in starlight
    bool isRootIndex = string.Equals(rel, "index.md", StringComparison.OrdinalIgnoreCase);
    string dstPath;
    if (isRootIndex)
    {
        dstPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "starlight", "src", "pages", "index.mdx"));
    }
    else
    {
        dstPath = Path.Combine(dstRoot, rel).Replace(".md", ".mdx");
    }
    Directory.CreateDirectory(Path.GetDirectoryName(dstPath)!);

    var content = await File.ReadAllTextAsync(md);

    string front = string.Empty;
    string body = content;
    if (content.StartsWith("---"))
    {
        var second = content.IndexOf("---", 3);
        if (second > 2)
        {
            second += 3;
            front = content[..second].Trim();
            body = content[second..].Trim();
        }
    }

    string? title = ExtractTitleFromFrontmatter(front) ?? ExtractFirstH1(body) ?? Path.GetFileNameWithoutExtension(md);
    string? description = ExtractDescriptionFromFrontmatter(front) ?? ExtractFirstParagraph(body) ?? string.Empty;

    string EscapeYaml(string? s) => s == null ? string.Empty : s.Replace("\r\n", " ").Replace("\n", " ").Replace("\\", "\\\\").Replace("\"", "\\\"").Trim();

    var sb = new StringBuilder();
    sb.AppendLine($"title: \"{EscapeYaml(title)}\"");
    if (!string.IsNullOrEmpty(description)) sb.AppendLine($"description: \"{EscapeYaml(description)}\"");

    if (isRootIndex)
    {
        // Lightweight index enhancements: hero blurb and featured top-level docs
        var hero = ExtractFirstParagraph(body) ?? string.Empty;
        sb.AppendLine($"hero: \"{EscapeYaml(hero)}\"");

        var topFiles = Directory.GetFiles(srcRoot, "*.md", SearchOption.TopDirectoryOnly)
            .Select(f => Path.GetFileNameWithoutExtension(f))
            .Where(n => !n.Equals("index", StringComparison.OrdinalIgnoreCase))
            .Select(n => n.ToLowerInvariant().Replace(' ', '-'))
            .ToArray();
        if (topFiles.Length > 0)
            sb.AppendLine($"featured: [{string.Join(", ", topFiles.Select(s => $"\"{s}\""))}]");

        // add explicit layout for site index pages
        sb.AppendLine("layout: ../layouts/Index.astro");
    }

    // if this is the site index, mark template as 'index' so it can be treated differently by Starlight
    sb.AppendLine(isRootIndex ? "template: index" : "template: doc");
    var frontYaml = sb.ToString();

    var updatedBody = Regex.Replace(body, @"\(([^)]+?)\.md(#.*?)?\)", m =>
    {
        var pathPart = m.Groups[1].Value;
        var anchorPart = m.Groups[2].Success ? m.Groups[2].Value : string.Empty;
        return $"({pathPart}.mdx{anchorPart})";
    }, RegexOptions.IgnoreCase);

    try
    {
        foreach (Match m in Regex.Matches(updatedBody, @"xref:([^\s\]\)]+)", RegexOptions.IgnoreCase))
        {
            unresolved.Add(new Dictionary<string,string> { ["source"] = rel, ["xref"] = m.Groups[1].Value });
        }

        var newContent = "---\n" + frontYaml + "---\n\n" + updatedBody;
        await File.WriteAllTextAsync(dstPath, newContent);
        string shortDst;
        try { shortDst = Path.GetRelativePath(dstRoot, dstPath); } catch { shortDst = dstPath; }
        Console.WriteLine($"Converted: {rel} -> {shortDst}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error converting {rel}: {ex.GetType().Name}: {ex.Message}");
        // continue with next file
    }
}

var unresolvedOut = Path.Combine(Directory.GetCurrentDirectory(), "unresolved-xrefs.json");
try
{
    await File.WriteAllTextAsync(unresolvedOut, System.Text.Json.JsonSerializer.Serialize(unresolved, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
    Console.WriteLine($"Unresolved xrefs written to {unresolvedOut}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error serializing unresolved xrefs: {ex.GetType().Name}: {ex.Message}");
    // fallback: write a simple raw text file listing the entries
    try
    {
        var rawOut = Path.Combine(Directory.GetCurrentDirectory(), "unresolved-xrefs-raw.txt");
        var lines = unresolved.Select(d => $"{d.GetValueOrDefault("source")} -> {d.GetValueOrDefault("xref")}\n");
        await File.WriteAllTextAsync(rawOut, string.Join(string.Empty, lines));
        Console.WriteLine($"Wrote fallback unresolved xrefs to {rawOut}");
    }
    catch (Exception ex2)
    {
        Console.WriteLine($"Failed to write fallback unresolved xrefs: {ex2.GetType().Name}: {ex2.Message}");
    }
}

string? ExtractTitleFromFrontmatter(string front)
{
    if (string.IsNullOrWhiteSpace(front)) return null;
    var m = Regex.Match(front, @"^title\s*:\s*(.+)$", RegexOptions.Multiline);
    if (m.Success) return m.Groups[1].Value.Trim(' ', '"');
    return null;
}

string? ExtractDescriptionFromFrontmatter(string front)
{
    if (string.IsNullOrWhiteSpace(front)) return null;
    var m = Regex.Match(front, @"^description\s*:\s*(.+)$", RegexOptions.Multiline);
    if (m.Success) return m.Groups[1].Value.Trim(' ', '"');
    return null;
}

string? ExtractFirstH1(string body)
{
    var m = Regex.Match(body, @"^#\s+(.+)$", RegexOptions.Multiline);
    if (m.Success) return m.Groups[1].Value.Trim();
    return null;
}

string? ExtractFirstParagraph(string body)
{
    var lines = body.Split('\n');
    var para = new List<string>();
    foreach (var line in lines)
    {
        if (string.IsNullOrWhiteSpace(line))
        {
            if (para.Count > 0) break;
            else continue;
        }
        if (line.TrimStart().StartsWith("#")) break;
        para.Add(line);
    }
    if (para.Count == 0) return null;
    return string.Join(' ', para).Trim();
}
