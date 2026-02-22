---
title: Italic Class
slug: reference/sadconsole.stringparser.bbcode.italic
sidebar:
  label: Italic
editUrl: false
---
## Definition

```csharp title="C#"
public class Italic : BBCodeCommandBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/) → [BBCodeCommandBase](../sadconsole.stringparser.bbcode.bbcodecommandbase/)

## Constructors

### Italic()

```csharp title="C#"
public Italic()
```


## Fields

### GlyphOffset

The offset applied to the glyph to get the italicized variant.

```csharp title="C#"
public static int GlyphOffset
```

## Methods

### SetBBCode(string, string?, Dictionary\<string, string>?)

Provides the information about the tag that triggered this command.

```csharp title="C#"
public override void SetBBCode(string tag, string? value, Dictionary<string, string>? parameters)
```

#### Parameters

`tag` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The BBCode tag condition that triggered the command.

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Optional value provided by the BBCode.

`parameters` [Dictionary\<string, string\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2/)  
Optional parameters provided by the BBCode.


### Build(ref ColoredGlyphAndEffect, ColoredGlyphAndEffect[], int, ICellSurface?, ref int, ReadOnlySpan\<char>, ParseCommandStacks)

Builds a glyph.

```csharp title="C#"
public override void Build(ref ColoredGlyphAndEffect glyphState, ColoredGlyphAndEffect[] glyphString, int surfaceIndex, ICellSurface? surface, ref int stringIndex, ReadOnlySpan<char> processedString, ParseCommandStacks commandStack)
```

#### Parameters

`glyphState` [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/)  
The current glyph being built.

`glyphString` [ColoredGlyphAndEffect[]](../sadconsole.coloredglyphandeffect/)  
The current string of glyphs that has been processed until now.

`surfaceIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Where on the surface this glyph will appear.

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface associated with the glyph.

`stringIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Where in the original string this glyph is from.

`processedString` [ReadOnlySpan\<char\>](https://learn.microsoft.com/dotnet/api/system.readonlyspan-1/)  
The entire string being processed.

`commandStack` [ParseCommandStacks](../sadconsole.stringparser.parsecommandstacks/)  
The state of commands.