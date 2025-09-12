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

## Notes on YAML parsing

- Initially there was an idea to use `YamlDotNet` to parse YAML robustly. I removed the dependency to keep the scripts self-contained and avoid project file complications for single-file tools.

- If you want robust YAML parsing for toc or API extraction, reintroduce YamlDotNet by adding a script package header:

  `#:package YamlDotNet@12.0.2`

  Place that as the first line of the script file, then add the appropriate `using` directives and parsing logic.

## Plan for the next chat (quick checklist)

- Decide API strategy:

  - Option A (recommended): full DocFX API YAML → MDX conversion (integrated, searchable).

  - Option B: build DocFX HTML and serve under `/api` (fast, less integrated).

- If Option A, choose whether I should:

  1. Write the C# converter that converts each API YAML → MDX (using `tooling/uid-slug.json` to produce slugs and to rewrite `xref:` links), or
  2. Add a plugin that the Starlight community provides (you may find one).

## Suggested next tasks

1. Run `dotnet run tooling/md2mdx.cs` to convert conceptual content and review generated `starlight/src/content/docs` pages and `tooling/unresolved-xrefs.json`.

2. Run `dotnet run tooling/toc2sidebar.cs` and paste `tooling/sidebar.json` into `starlight/astro.config.mjs` (or paste and adjust ordering/labels).

3. Copy static assets: `dotnet run tooling/copyassets.cs`.

4. Pick an API approach and either point me at a plugin or ask me to implement YAML→MDX conversion. If you want me to implement conversion, I will:

   - Use `tooling/uid-slug.json` as the source for mapping UIDs → slugs.

   - Convert API YAML to MDX pages under `starlight/src/content/docs/reference/`.

   - Re-run link normalization to replace `xref:UID` with the final slugs.

## CI / Deployment notes

- Build command for Starlight: from `starlight/` run `npm ci && npm run build` (adjust to your package scripts).

- For CI: run conversion tools first (if needed), then build the Starlight site and deploy output to your static host.

## Rollback and branching

- Use Git to manage changes:

  - `git log` to find commit id
  - `git checkout -- <file>` to restore individual files
  - `git revert <commit>` or `git reset` to rollback changes if needed

## Questions to answer later

- Do you want automatic MDX component enrichment (admonitions, callouts, API member tables), or keep first pass minimal content for manual enhancement?

- Do you want me to add direct support for monikers/versioned builds in the tooling now, or wait until we finalize the API approach?

## If you want me to proceed now

Choose one:

- Convert all conceptual content (md → mdx) and open a PR with the results.
- Implement the full API YAML → MDX converter (I can scaffold and run on a subset first).

