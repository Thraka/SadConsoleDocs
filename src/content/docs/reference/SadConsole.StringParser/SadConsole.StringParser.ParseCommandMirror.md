---
title: ParseCommandMirror Class
slug: reference/sadconsole.stringparser.parsecommandmirror
sidebar:
  label: ParseCommandMirror
editUrl: false
description: Sets the mirror of a glyph.
---
## Definition

Sets the mirror of a glyph.

```csharp title="C#"
public sealed class ParseCommandMirror : ParseCommandBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/)

## Constructors

### ParseCommandMirror(string)

Creates a new instance of this command.

```csharp title="C#"
public ParseCommandMirror(string parameters)
```

#### Parameters

`parameters` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to parse for parameters.


### ParseCommandMirror()

Creates a new instance of this command.

```csharp title="C#"
public ParseCommandMirror()
```


## Fields

### Mirror

The mirror mode.

```csharp title="C#"
public Mirror Mirror
```

## Methods

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