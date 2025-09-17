---
title: ParseCommandDecorator Class
slug: reference/sadconsole.stringparser.parsecommanddecorator
sidebar:
  label: ParseCommandDecorator
---
## Definition

Sets the mirror of a glyph.

```csharp title="C#"
public sealed class ParseCommandDecorator : ParseCommandBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/)

## Constructors

### ParseCommandDecorator(string, bool)

Creates a new instance of this command.

```csharp title="C#"
public ParseCommandDecorator(string parameters, bool replace)
```

#### Parameters

`parameters` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to parse for parameters.

`replace` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, replaces the decorators on the glyph, otherwise it adds them.


## Properties

### Decorator

The decorator created by the command settings.

```csharp title="C#"
public CellDecorator Decorator { get; set; }
```

### Glyph

The glyph of the decorator.

```csharp title="C#"
public int Glyph { get; set; }
```

### Color

The color of the decorator.

```csharp title="C#"
public Color Color { get; set; }
```

### Mirror

The mirror to apply to the decorator.

```csharp title="C#"
public Mirror Mirror { get; set; }
```

### Replace

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, replaces the decorators on the glyph, otherwise it adds them.

```csharp title="C#"
public bool Replace { get; set; }
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