# Migration PLAN — DocFX → Starlight

## Goal

- Migrate the DocFX site at `docfx/root` into the Starlight/Astro site at `starlight/`.
- Prioritize conceptual content (articles, guides, tutorials). Prepare for API reference migration later (approach A: convert API YAML to MDX).

## What I added (tooling)

- `tooling/md2mdx.cs` — converts `.md` files from `docfx/root` → `.mdx` under `starlight/src/content/docs`. Produces `tooling/unresolved-xrefs.json` with detected `xref:` entries.

- `tooling/toc2sidebar.cs` — parses `docfx/root/toc.yml` (simple, indentation-based) and emits `tooling/sidebar.json` for easy paste into `starlight/astro.config.mjs`.

- `tooling/uid2slug.cs` — scans `docfx/root/api/*.yml` and writes `tooling/uid-slug.json` (UID → suggested-slug map).

- `tooling/copyassets.cs` — copies `docfx/root/images` → `starlight/public/images` preserving structure.

- `tooling/README.md` — how to run the tools.

## How to run the tools (from repo root)

All tools live in `tooling/` and are single-file C# scripts. From the repo root:

- `dotnet build tooling/md2mdx.cs`    — compile-only (no output = success)
- `dotnet run tooling/md2mdx.cs`      — execute
- `dotnet run tooling/toc2sidebar.cs`
- `dotnet run tooling/uid2slug.cs`
- `dotnet run tooling/copyassets.cs`

## Hardcoded paths

- docfx content root: `docfx/root`
- starlight content target: `starlight/src/content/docs`
- docfx API YAML: `docfx/root/api`
- docfx images: `docfx/root/images`
- starlight public images: `starlight/public/images`

## Key outputs to review

- `tooling/sidebar.json` — sidebar fragment to paste into `starlight/astro.config.mjs`.

- `tooling/unresolved-xrefs.json` — list of mdx files and xref UIDs found; use `tooling/uid-slug.json` to resolve these later.

- `tooling/uid-slug.json` — mapping of DocFX UIDs → suggested slugs for the API pages.

- Converted `.mdx` files under `starlight/src/content/docs/`.

## Decisions made

- Convert conceptual content (articles, guides, tutorials) to MDX and integrate into Starlight (`starlight/src/content/docs`).

- Postpone full API YAML → MDX conversion for now. Instead, produce supporting artifacts (`tooling/uid-slug.json` and `tooling/unresolved-xrefs.json`) so a plugin or converter can be applied later without rework.

- Use single-file .NET tools (in `tooling/`) to perform conversions and asset copying.

## Suggested next tasks

1. Run `dotnet run tooling/md2mdx.cs` to convert conceptual content and review generated `starlight/src/content/docs` pages and `tooling/unresolved-xrefs.json`.

2. Run `dotnet run tooling/toc2sidebar.cs` and paste `tooling/sidebar.json` into `starlight/astro.config.mjs` (or paste and adjust ordering/labels).

3. Copy static assets: `dotnet run tooling/copyassets.cs`.

4. API conversion is postponed for now. I will produce `tooling/uid-slug.json` and `tooling/unresolved-xrefs.json` to make later plugin-based conversion straightforward. When you are ready to convert the API reference, tell me and I will proceed with a converter or integrate the plugin you prefer.

## CI / Deployment notes

- Build command for Starlight: from `starlight/` run `npm ci && npm run build` (adjust to your package scripts).

- For CI: run conversion tools first (if needed), then build the Starlight site and deploy output to your static host.

## Questions to answer later

- Do you want automatic MDX component enrichment (admonitions, callouts, API member tables), or keep first pass minimal content for manual enhancement?

- Do you want me to add direct support for monikers/versioned builds in the tooling now, or wait until we finalize the API approach?

