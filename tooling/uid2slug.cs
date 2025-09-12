// Tool: uid2slug.cs
// Purpose: Produce a UID -> suggested-slug JSON map from DocFX API YAML files.
// Hardcoded paths (relative to this folder):
//   Input:  ../docfx/root/api   (scans top-level *.yml files)
//   Output: ./uid-slug.json  (recommended for later API conversion tools/plugins)
// Example package header format (if reintroducing a NuGet dependency):
//   #:package YamlDotNet@12.0.2
// Run:
//   dotnet build uid2slug.cs
//   dotnet run uid2slug.cs

using System.Text.RegularExpressions;
using System.Text.Json;

// uid2slug.cs
// Hardcoded paths (relative to this tooling folder)
var apiDir = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "docfx", "root", "api"));
var outPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "uid-slug.json"));

if (!Directory.Exists(apiDir))
{
    Console.WriteLine($"API dir not found: {apiDir}");
    return;
}

var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
var files = Directory.GetFiles(apiDir, "*.yml", SearchOption.TopDirectoryOnly);

foreach (var f in files)
{
    var content = await File.ReadAllTextAsync(f);
    foreach (Match m in Regex.Matches(content, @"^\s*uid\s*:\s*(.+)$", RegexOptions.Multiline))
    {
        var uid = m.Groups[1].Value.Trim();
        var slug = UidToSuggestedSlug(uid);
        if (!map.ContainsKey(uid)) map[uid] = slug;
    }
}

Directory.CreateDirectory(Path.GetDirectoryName(outPath)!);
await File.WriteAllTextAsync(outPath, JsonSerializer.Serialize(map, new JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine($"UID->slug map written to {outPath} ({map.Count} entries)");

string UidToSuggestedSlug(string uid)
{
    var cleaned = uid;
    cleaned = Regex.Replace(cleaned, "`\\d+", string.Empty);
    cleaned = cleaned.Replace('.', '/');
    cleaned = cleaned.ToLowerInvariant();
    return cleaned;
}
