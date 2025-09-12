DocFX → Starlight tooling (single-file .NET 10 tools)

This folder contains single-file C# tools you can run with .NET 10's file-based program support.

Run any tool with:

  dotnet run Program.cs -- <command> <args>

Commands implemented (in Program.cs):

- toc2sidebar <toc.yml path> <out json path>
  - Reads a DocFX `toc.yml` and emits a JSON fragment representing sidebar entries compatible with Starlight's `astro.config.mjs` sidebar structure.

- md2mdx <src-docfx-root> <dst-starlight-content-root>
  - Scans `src-docfx-root` for `.md` files recursively, normalizes/creates frontmatter (title, description, template: doc), converts internal `.md` links to `.mdx`, and writes files to `dst-starlight-content-root` preserving directory structure.
  - Emits `tooling/unresolved-xrefs.json` containing any detected `xref:UID` occurrences for later resolution.

- uid2slug <docfx-api-dir> <out json path>
  - Scans `docfx-api-dir` for `*.yml` API files and writes a UID->suggested-slug JSON map to `out json path`.
  - Slug formula is basic: uid (Namespace.Type.Member) -> `namespace/type/member` (lowercased, generics cleaned).

- copyassets <docfx-images-dir> <starlight-public-images-dir>
  - Copies static assets preserving relative paths.

Examples (PowerShell):

  cd e:\Fun\SadConsoleDocs\tooling
  dotnet run Program.cs -- toc2sidebar "..\docfx\root\toc.yml" "output\sidebar.json"
  dotnet run Program.cs -- md2mdx "..\docfx\root" "..\starlight\src\content\docs"
  dotnet run Program.cs -- uid2slug "..\docfx\root\api" "output\uid-slug.json"
  dotnet run Program.cs -- copyassets "..\docfx\root\images" "..\starlight\public\images"

Notes:
- These tools are intentionally conservative: they aim to automate repetitive work and produce artifacts (sidebar JSON, mdx files, uid map) that you can review and tweak before finalizing.
- Later, when you pick a DocFX->Starlight API plugin/converter, use `tooling/uid-slug.json` and `tooling/unresolved-xrefs.json` to help resolve API cross-references.
