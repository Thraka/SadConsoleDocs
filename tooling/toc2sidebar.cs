// Tool: toc2sidebar.cs
// Purpose: Convert DocFX toc.yml into a Starlight-compatible sidebar JSON fragment.
// Hardcoded paths (relative to this folder):
//   Input:  ../docfx/root/toc.yml
//   Output: ./sidebar.json
// If you need a NuGet package in-file, use the script package header format, e.g.:
//   #:package YamlDotNet@12.0.2
// Run locally:
//   dotnet build toc2sidebar.cs    # compile-only (no output means success)
//   dotnet run toc2sidebar.cs      # execute

using System.Text.Json;

// Simple YAML-like toc parser (line-oriented, indentation-based)
var tocPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "docfx", "root", "toc.yml"));
var outPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "sidebar.json"));

if (!File.Exists(tocPath))
{
    Console.WriteLine($"toc.yml not found at {tocPath}");
    return;
}

var lines = await File.ReadAllLinesAsync(tocPath);

int LeadingSpaces(string s) => s.TakeWhile(char.IsWhiteSpace).Count();
string Trimmed(string s) => s.Trim();

var roots = new List<Node>();
var stack = new List<Node>();

for (int i = 0; i < lines.Length; i++)
{
    var raw = lines[i];
    if (string.IsNullOrWhiteSpace(raw)) continue;
    var indent = LeadingSpaces(raw);
    var t = Trimmed(raw);
    if (t.StartsWith("- "))
    {
        var after = t.Substring(2).Trim();
        var node = new Node { Indent = indent };
        if (after.StartsWith("name:", StringComparison.OrdinalIgnoreCase))
        {
            node.Name = after.Substring("name:".Length).Trim();
        }
        else if (after.StartsWith("href:", StringComparison.OrdinalIgnoreCase))
        {
            node.Href = after.Substring("href:".Length).Trim();
        }
        // attach to parent by indentation
        while (stack.Count > 0 && stack[^1].Indent >= indent) stack.RemoveAt(stack.Count - 1);
        if (stack.Count == 0) roots.Add(node); else stack[^1].Items.Add(node);
        stack.Add(node);
        continue;
    }

    // property lines like 'name: Foo' or 'href: path'
    if (t.StartsWith("name:", StringComparison.OrdinalIgnoreCase) || t.StartsWith("href:", StringComparison.OrdinalIgnoreCase))
    {
        var pep = t.Split(new[] { ':' }, 2);
        if (pep.Length == 2)
        {
            var key = pep[0].Trim();
            var val = pep[1].Trim();
            // assign to last node at shallower indent
            var target = stack.LastOrDefault();
            if (target != null)
            {
                if (key.Equals("name", StringComparison.OrdinalIgnoreCase)) target.Name = val;
                else if (key.Equals("href", StringComparison.OrdinalIgnoreCase)) target.Href = val;
            }
        }
    }
}

object ConvertNode(Node n)
{
    string? slug = null;
    if (!string.IsNullOrEmpty(n.Href)) slug = ConvertHrefToSlug(n.Href);

    if (n.Items != null && n.Items.Count > 0)
    {
        var children = n.Items.Select(ConvertNode).ToList();
        if (slug != null) return new { label = n.Name ?? string.Empty, slug, items = children };
        else return new { label = n.Name ?? string.Empty, items = children };
    }

    if (slug != null) return new { label = n.Name ?? string.Empty, slug };
    return new { label = n.Name ?? string.Empty };
}

string ConvertHrefToSlug(string href)
{
    var idx = href.IndexOf('#');
    if (idx >= 0) href = href.Substring(0, idx);

    href = href.Trim();
    href = href.Replace('\\', '/');

    if (href.EndsWith(".md", StringComparison.OrdinalIgnoreCase) || href.EndsWith(".mdx", StringComparison.OrdinalIgnoreCase)) href = href[..^3];
    if (href.EndsWith("/index", StringComparison.OrdinalIgnoreCase)) href = href.Substring(0, href.Length - "/index".Length);
    if (href.StartsWith("/")) href = href.Substring(1);
    if (href.EndsWith('/')) href = href.TrimEnd('/');
    return href.ToLowerInvariant();
}

var nodes = roots.Select(ConvertNode).ToList();
var json = JsonSerializer.Serialize(nodes, new JsonSerializerOptions { WriteIndented = true });
Directory.CreateDirectory(Path.GetDirectoryName(outPath)!);
await File.WriteAllTextAsync(outPath, json);
Console.WriteLine($"Sidebar JSON written to {outPath}");

class Node { public string? Name; public string? Href; public List<Node> Items = new(); public int Indent; }
