---
name: Markdown Writing Style
applyTo: '**/*.md, **/*.mdx'
description: 'Follow these comprehensive writing style guidelines when creating or editing Markdown documentation. Apply active voice, conversational tone, Oxford commas, and specific formatting rules to ensure consistency and readability across all documentation.'
---

# Markdown Writing Style Instructions

When writing or editing Markdown documentation, follow these style guidelines:

**ALWAYS** read this entire fill.

## Voice and Tone Requirements

ALWAYS write using:
- Active voice with second person ("you")
- Conversational tone with contractions
- Present tense for instructions and descriptions
- Imperative mood for instructions (write "Call the method" NOT "You should call the method")
- "might" for possibility (NOT "may")
- "can" for permissible actions (NOT "may")

NEVER use:
- "we" or "our" when referring to documentation authors or product teams
- Jargon or overly complex technical language
- Weak phrases like "you can" or "there is/are/were" unless they add value

ALWAYS:
- Write like you speak using everyday words
- Create a friendly, informal tone
- Start statements with verbs when possible

## Structure and Format Rules

### Headings and Content
- Use sentence case headings (capitalize only first word and proper nouns)
- Never use gerunds in titles
- Never place consecutive headings without content between them
- Lead with the most important information first
- Front-load keywords for scanning

### Lists and Punctuation
- **CRITICAL: Use Oxford comma in ALL lists (item1, item2, and item3) - NO EXCEPTIONS**
- **MANDATORY: Number ordered lists using "01." for every item (NOT 1., 2., 3.) - ALWAYS USE "01."**
- **REQUIRED: Use bullets for unordered lists - NEVER use numbers for unordered content**
- **ESSENTIAL: Write complete sentences in lists with proper punctuation**
- Skip end punctuation on titles, headings, and UI elements (3 words or fewer)

### Spacing and Layout
- Add blank lines around Markdown elements (but don't add extra if they exist)
- Use only one space after periods, question marks, and colons
- Use no spaces around dashes (word—word)
- Break up long sentences for clarity

### Prohibited Terms
- Never write "etc." or "and so on" - provide complete lists or use "for example"
- Use "for example" instead of "e.g."
- Use "that is" instead of "i.e."

## Formatting Conventions

Apply these formatting rules:
- **Bold text** for UI elements
- _Italic style_ for file names, folders, custom types.
- Raw URLs in angle brackets
- Links to other articles must use the MDX style which is a markdown link with a slug as the URL, which is from the `/src/content/docs/` folder (e.g. `[Getting Started](/getting-started/cli)`)

## Starlight and Astro Formatting

- Ordered steps use the `Steps` component with `01.` for every item.
  Example:
  ```mdx
  <Steps>
  01. Do this first.
  01. Then do this.
  </Steps>
  ```

- Use the `Aside` component for tips, cautions, and important notes.
  Example:
  ```mdx
  <Aside type="tip">
  This is a helpful tip.
  </Aside>
  ```

### Import statements for components:

Imports should generally be placed at the top of the file, after the YAML front matter, and before any content.

- Steps component: `import { Steps } from '@astrojs/starlight/components';`
- Aside component: `import { Aside } from '@astrojs/starlight/components';`

## Word Choice Requirements

### Verb Selection
- Choose simple verbs without modifiers
- Avoid weak verbs: "be," "have," "make," "do"
- Use precise verbs (write "tell" NOT "inform")

### Conciseness Rules
- Use one word instead of multiple when possible (write "to" NOT "in order to")
- Choose words with one clear meaning (write "because" NOT "since" for causation)
- Omit unnecessary adverbs unless critical to meaning
- Use one term consistently for each concept

### Contraction Guidelines
- Use common contractions: "it's," "you're," "that's," "don't"
- Avoid ambiguous contractions: "there'd," "it'll," "they'd"
- Never form contractions from noun + verb (avoid "Microsoft's developing")

## Code Snippets

- Investigate the code snippet to make sure it's talked about correctly.
- Some snippets may be inline instead of referenced and imported.

  An `import` statement brings in the snippet as raw text, assigning it a variable, and the `<Code>` component uses that variable to format it as a code block. The `mark` property highlights specific lines in the snippet. You can read the import file to read the code being imported and ensure it's being described correctly in the documentation.

   ```mdx
   import snippet from 'snippets/how-to-use-imgui/csharp/Program.cs?raw';

   <Code code={snippet} lang="csharp" mark={{ range: "10-12" }} />
  ```
