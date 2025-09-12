// Tool: copyassets.cs
// Purpose: Copy static assets from DocFX into Starlight public folder preserving paths.
// Hardcoded paths (relative to this folder):
//   Input:  ../docfx/root/images
//   Output: ../starlight/public/images
// Run:
//   dotnet build copyassets.cs
//   dotnet run copyassets.cs

using System.IO;

var src = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "docfx", "root", "images"));
var dst = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "starlight", "public", "images"));

if (!Directory.Exists(src))
{
    Console.WriteLine($"Source images dir not found: {src}");
    return;
}

Directory.CreateDirectory(dst);

foreach (var file in Directory.GetFiles(src, "*.*", SearchOption.AllDirectories))
{
    var rel = Path.GetRelativePath(src, file);
    var destFile = Path.Combine(dst, rel);
    Directory.CreateDirectory(Path.GetDirectoryName(destFile)!);
    File.Copy(file, destFile, overwrite: true);
    Console.WriteLine($"Copied {rel}");
}

Console.WriteLine("Assets copy complete.");
