---
title: ParseCommandBase Class
slug: reference/sadconsole.stringparser.parsecommandbase
sidebar:
  label: ParseCommandBase
---
## Definition

Base class for a string processor behavior.

```csharp title="C#"
public abstract class ParseCommandBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ParseCommandBase()

```csharp title="C#"
protected ParseCommandBase()
```


## Fields

### CommandType

Type of command.

```csharp title="C#"
public CommandTypes CommandType
```

## Methods

### Build(ref ColoredGlyphAndEffect, ColoredGlyphAndEffect[], int, ICellSurface?, ref int, ReadOnlySpan<char>, ParseCommandStacks)

Builds a glyph.

```csharp title="C#"
public abstract void Build(ref ColoredGlyphAndEffect glyphState, ColoredGlyphAndEffect[] glyphString, int surfaceIndex, ICellSurface? surface, ref int stringIndex, ReadOnlySpan<char> processedString, ParseCommandStacks commandStack)
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


### Removed()

Called when the command is removed from its stack.

```csharp title="C#"
public virtual void Removed()
```