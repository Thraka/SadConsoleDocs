---
name: DocFX to Astro Starlight Migration
description: 'Follow these rules when migrating old DocFX markdown (.md) content into Astro Starlight MDX (.mdx) content. Covers front matter, components, links, voice, and structural changes.'
---

# DocFX to Astro Starlight migration instructions

Use these rules when converting DocFX `.md` files into Astro Starlight `.mdx` files.

## File and extension

- Change the file extension from `.md` to `.mdx`.
- Place the new file in the appropriate path under `src/content/docs/`.

## Front matter

- Remove the `ms.date` property.
- Remove any other DocFX-specific metadata properties.
- Rewrite the `title` to be descriptive and branded. Wrap the value in single quotes if it contains a colon.
  - Example: `title: Get Started Part 1 - Drawing` becomes `title: 'Create a SadConsole game: Part 1 - Drawing'`
- Keep the `description` field, but rewrite it to match the active voice and tone rules from the writing style guide.

## Remove the H1 heading

- Delete the `# Heading` line that appears right after the front matter. Starlight auto-generates the page title from the `title` front matter field.

## Imports

- Add import statements for any Starlight components used in the file. Place them immediately after the front matter closing `---`, before any content.
- Combine imports from the same module into a single statement.

```mdx
import { Aside, Steps } from '@astrojs/starlight/components';
```

- Only import components that are actually used in the file.

## DocFX alerts to Aside components

Convert all DocFX blockquote alerts to Starlight `<Aside>` components. Remove the blockquote `>` prefix from every line.

| DocFX syntax     | Aside type   |
|------------------|--------------|
| `> [!NOTE]`      | `note`       |
| `> [!TIP]`       | `tip`        |
| `> [!IMPORTANT]` | `tip`        |
| `> [!WARNING]`   | `caution`    |
| `> [!CAUTION]`   | `danger`     |

### Before (DocFX)

```markdown
> [!WARNING]
> Because of the added complexity, I don't recommend creating a MonoGame project.
```

### After (Starlight)

```mdx
<Aside type="caution">
Because of the added complexity, avoid creating a MonoGame project.
</Aside>
```

**Rules:**

- Add a blank line before and after each `<Aside>` block.
- The content inside the `<Aside>` must NOT be prefixed with `>`.
- Rewrite the content inside the aside to match the active voice and tone rules.

## XREF links to API docs

- Convert all XREF links to regular links that point to the new API reference pages under `/`.

## Ordered lists that represent steps

Wrap ordered lists that represent sequential steps the reader must follow in the `<Steps>` component. Use `01.` numbering for every item inside `<Steps>`.

### Before (DocFX)

```markdown
01. Do this first.
01. Then do this.
01. Finally do this.
```

### After (Starlight)

```mdx
<Steps>
01. Do this first.
01. Then do this.
01. Finally do this.
</Steps>
```

**Rules:**

- Only wrap lists that are truly sequential steps. Don't wrap simple ordered enumerations or lists of conditions, instead convert them to bullet lists.
- Non-step ordered lists (for example, a list of conditions that must be met) should be converted to unordered bullet lists instead.

### Example: conditions list

**Before (DocFX, numbered conditions):**

```markdown
01. The console must be focused.
01. The cursor must be enabled.
```

**After (Starlight, bullet list):**

```markdown
- The console must be focused.
- The cursor must be enabled.
```

## Links

### Internal article links

Convert all relative DocFX `.md` links to Starlight slug-based links. The slug is derived from the file's path relative to `src/content/docs/`, without the file extension.

**Before:**

```markdown
[CLI templates](../../getting-started-cli.md)
```

**After:**

```mdx
[CLI templates](/getting-started/cli/)
```

**Rules:**

- Remove the `.md` extension.
- Replace the relative path with an absolute slug path rooted at `/`.
- Ensure the slug matches the actual file location under `src/content/docs/`.
- Use trailing slashes on slug paths.

### XREF Links

Convert all XREF links to regular links that point to the new API reference pages published under the `/reference` slug.

New links follow this pattern:`/reference/{namespaces.type}#{member}`. The actual files are in the repo in this pattern: `/src/content/docs/reference/{Namespace}/{Namespace}.{Type}.md`

Example:

**XREF version:**

```markdown
For more information, see <xref:SadConsole.CellSurfaceEditor.Print(SadConsole.ISurface,System.Int32,System.Int32,SadConsole.ColoredString)>.
```
**New MDX version using publishing slug:**

```mdx
For more information, see [Print(ISurface, int, int, ColoredString)](/reference/sadconsole.cellsurfaceeditor#printisurface-int-int-coloredstring).
```

**Actual source file in repo:**

`/src/content/docs/reference/SadConsole/SadConsole.CellSurfaceEditor.md`

## Image paths

- Image paths typically remain the same relative format. Verify they still resolve correctly from the new file location.
- If images are in a shared location, adjust the path accordingly.

## Complete migration checklist

When migrating a file, verify each of these items:

- [ ] File extension changed to `.mdx`
- [ ] `ms.date` and DocFX metadata removed from front matter
- [ ] Title rewritten in descriptive, branded style
- [ ] H1 heading removed (Starlight generates it)
- [ ] Required component imports added after front matter
- [ ] All `> [!ALERT]` blocks converted to `<Aside>` components
- [ ] Sequential step lists wrapped in `<Steps>` component
- [ ] Non-step numbered lists converted to bullet lists
- [ ] All internal links converted to slug-based paths
- [ ] Next/previous links converted or commented out if target doesn't exist
- [ ] Image paths verified
- [ ] All "we/our/let's" rewritten to "you/your" or imperative mood
- [ ] "may" replaced with "might" or "can"
- [ ] Gerunds removed from headings
- [ ] Passive voice rewritten to active voice
- [ ] Typos and code errors fixed
- [ ] Oxford commas applied in all lists
- [ ] No consecutive headings without content between them
