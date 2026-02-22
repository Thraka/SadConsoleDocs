---
title: TheDrawFont.Character Struct
slug: reference/sadconsole.readers.thedrawfont.character
sidebar:
  label: TheDrawFont.Character
editUrl: false
description: A character defined by the font.
---
## Definition

A character defined by the font.

```csharp title="C#"
public struct TheDrawFont.Character
```


## Fields

### GlyphIndex

The glyph this character represents.

```csharp title="C#"
public int GlyphIndex
```

### Width

How wide the font character.

```csharp title="C#"
public int Width
```

### Rows

Each row of the font character.

```csharp title="C#"
public TheDrawFont.CharacterRow[] Rows
```