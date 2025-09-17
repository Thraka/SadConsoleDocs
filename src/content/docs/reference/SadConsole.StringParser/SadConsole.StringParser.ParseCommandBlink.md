---
title: ParseCommandBlink Class
slug: reference/sadconsole.stringparser.parsecommandblink
sidebar:
  label: ParseCommandBlink
---
## Definition

Blinks characters.

```csharp title="C#"
public sealed class ParseCommandBlink : ParseCommandBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/)

## Constructors

### ParseCommandBlink(string, ColoredGlyphBase[], ParseCommandStacks, ICellSurface?)

Creates a new instance of this command.

```csharp title="C#"
public ParseCommandBlink(string parameters, ColoredGlyphBase[] glyphString, ParseCommandStacks commandStack, ICellSurface? surface)
```

#### Parameters

`parameters` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to parse for parameters.

`glyphString` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The string that has been processed so far.

`commandStack` [ParseCommandStacks](../sadconsole.stringparser.parsecommandstacks/)  
The current commands for the string.

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface hosting the string.


## Fields

### Speed

The speed of the blink.

```csharp title="C#"
public TimeSpan Speed
```

## Methods

### Build(ref ColoredGlyphAndEffect, ColoredGlyphAndEffect[], int, ICellSurface?, ref int, ReadOnlySpan<char>, ParseCommandStacks)

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