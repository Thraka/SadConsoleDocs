---
title: GlyphDefinition Struct
slug: reference/sadconsole.glyphdefinition
sidebar:
  label: GlyphDefinition
editUrl: false
description: Represents a decorator (glyph and mirror) defined by a font.
---
## Definition

Represents a decorator (glyph and mirror) defined by a font.

```csharp title="C#"
public readonly struct GlyphDefinition
```


## Constructors

### GlyphDefinition(int, Mirror)

Creates a new cell decorator instance.

```csharp title="C#"
public GlyphDefinition(int glyph, Mirror mirror)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`mirror` [Mirror](../sadconsole.mirror/)  


## Properties

### Empty

Gets a glyph definition that has -1 for the glyph.

```csharp title="C#"
public static GlyphDefinition Empty { get; }
```

### Glyph

The glyph of the decorator.

```csharp title="C#"
public int Glyph { get; init; }
```

### Mirror

The mirror effect of the decorator.

```csharp title="C#"
public Mirror Mirror { get; init; }
```

## Methods

### CreateCellDecorator(Color)

Creates a [CellDecorator](../sadconsole.celldecorator/) from this definition.

```csharp title="C#"
public CellDecorator CreateCellDecorator(Color foreground)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The color of the decorator.

#### Returns

[CellDecorator](../sadconsole.celldecorator/)  
A new decorator instance.

### CreateCell(Color, Color)

Creates a [ColoredGlyphBase](../sadconsole.coloredglyphbase/) from this definition.

```csharp title="C#"
public ColoredGlyphBase CreateCell(Color foreground, Color background)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The foreground color of the cell.

`background` SadRogue.Primitives.Color  
The background color of the cell.

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
A new cell instance.