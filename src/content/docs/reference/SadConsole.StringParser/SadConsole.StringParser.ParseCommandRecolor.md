---
title: ParseCommandRecolor Class
slug: reference/sadconsole.stringparser.parsecommandrecolor
sidebar:
  label: ParseCommandRecolor
editUrl: false
description: Recolors a glyph.
---
## Definition

Recolors a glyph.

```csharp title="C#"
public sealed class ParseCommandRecolor : ParseCommandBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/)

## Constructors

### ParseCommandRecolor(string)

Creates a new instance of this command.

```csharp title="C#"
public ParseCommandRecolor(string parameters)
```

#### Parameters

`parameters` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to parse for parameters.


### ParseCommandRecolor()

Creates a new instance of this command.

```csharp title="C#"
public ParseCommandRecolor()
```


## Fields

### Default

Use the default foreground and background based on the [CommandType](../sadconsole.stringparser.parsecommandbase/#commandtype).

```csharp title="C#"
public bool Default
```

### KeepRed

Keeps the red channel of the existing color of the glyphs this command is applied to.

```csharp title="C#"
public bool KeepRed
```

### KeepGreen

Keeps the green channel of the existing color of the glyphs this command is applied to.

```csharp title="C#"
public bool KeepGreen
```

### KeepBlue

Keeps the blue channel of the existing color of the glyphs this command is applied to.

```csharp title="C#"
public bool KeepBlue
```

### KeepAlpha

Keeps the alpha channel of the existing color of the glyphs this command is applied to.

```csharp title="C#"
public bool KeepAlpha
```

## Properties

### R

The current red value

```csharp title="C#"
public byte R { get; set; }
```

### G

The current green value

```csharp title="C#"
public byte G { get; set; }
```

### B

The current blue value

```csharp title="C#"
public byte B { get; set; }
```

### A

The current alpha value

```csharp title="C#"
public byte A { get; set; }
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