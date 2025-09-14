---
title: ColoredGlyphState Struct
slug: reference/sadconsole.coloredglyphstate
sidebar:
  label: ColoredGlyphState
---
## Definition

A [ColoredGlyphBase](../sadconsole.coloredglyphbase/) with state information.

```csharp title="C#"
public readonly struct ColoredGlyphState
```


## Constructors

### ColoredGlyphState(ColoredGlyphBase)

Creates a new state from a cell.

```csharp title="C#"
public ColoredGlyphState(ColoredGlyphBase cell)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The colored glyph this state is a copy of.


### ColoredGlyphState(CellDecorator[], Color, Color, int, Mirror, bool)

Creates a new state.

```csharp title="C#"
[JsonConstructor]
public ColoredGlyphState(CellDecorator[] decorators, Color foreground, Color background, int glyph, Mirror mirror, bool isVisible)
```

#### Parameters

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
Decorators for the cell.

`foreground` SadRogue.Primitives.Color  
Foreground color.

`background` SadRogue.Primitives.Color  
Background color.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror effect.

`isVisible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
The visibility of the glyph.


## Properties

### Decorators

A copy of the [Decorators](../sadconsole.coloredglyphbase/#decorators/) property.

```csharp title="C#"
public CellDecorator[] Decorators { get; }
```

### Foreground

A copy of the [Foreground](../sadconsole.coloredglyphbase/#foreground/) property.

```csharp title="C#"
public Color Foreground { get; }
```

### Background

A copy of the [Background](../sadconsole.coloredglyphbase/#background/) property.

```csharp title="C#"
public Color Background { get; }
```

### Glyph

A copy of the [Glyph](../sadconsole.coloredglyphbase/#glyph/) property.

```csharp title="C#"
public int Glyph { get; }
```

### Mirror

A copy of the [Mirror](../sadconsole.coloredglyphbase/#mirror/) property.

```csharp title="C#"
public Mirror Mirror { get; }
```

### IsVisible

A copy of the [IsVisible](../sadconsole.coloredglyphbase/#isvisible/) property.

```csharp title="C#"
public bool IsVisible { get; }
```

## Methods

### RestoreState(ref ColoredGlyphBase)

Restores this state to the specified cell.

```csharp title="C#"
public void RestoreState(ref ColoredGlyphBase cell)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)