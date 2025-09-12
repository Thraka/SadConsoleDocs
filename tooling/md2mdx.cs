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
var unresolved = new List<object>();

foreach (var md in mdFiles)
{
    var rel = Path.GetRelativePath(srcRoot, md).Replace('\\', '/');
    var dstPath = Path.Combine(dstRoot, rel).Replace(".md", ".mdx");
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

    string EscapeYaml(string? s) => s?.Replace("\\", "\\\\").Replace("\"", "\\\"") ?? string.Empty;

    var sb = new StringBuilder();
    sb.AppendLine($"title: \"{EscapeYaml(title)}\"");
    if (!string.IsNullOrEmpty(description)) sb.AppendLine($"description: \"{EscapeYaml(description)}\"");
    sb.AppendLine("template: doc");
    var frontYaml = sb.ToString();

    var updatedBody = Regex.Replace(body, @"\(([^)]+?)\.md(#.*?)?\)", m =>
    {
        var pathPart = m.Groups[1].Value;
        var anchorPart = m.Groups[2].Success ? m.Groups[2].Value : string.Empty;
        return $"({pathPart}.mdx{anchorPart})";
    }, RegexOptions.IgnoreCase);

    foreach (Match m in Regex.Matches(updatedBody, @"xref:([^\s\]\)]+)", RegexOptions.IgnoreCase))
    {
        unresolved.Add(new { source = rel, xref = m.Groups[1].Value });
    }

    var newContent = "---\n" + frontYaml + "---\n\n" + updatedBody;
    await File.WriteAllTextAsync(dstPath, newContent);
    Console.WriteLine($"Converted: {rel} -> {Path.GetRelativePath(dstRoot, dstPath)}");
}

var unresolvedOut = Path.Combine(Directory.GetCurrentDirectory(), "unresolved-xrefs.json");
await File.WriteAllTextAsync(unresolvedOut, System.Text.Json.JsonSerializer.Serialize(unresolved, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine($"Unresolved xrefs written to {unresolvedOut}");

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
