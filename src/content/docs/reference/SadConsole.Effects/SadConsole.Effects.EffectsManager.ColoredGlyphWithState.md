---
title: EffectsManager.ColoredGlyphWithState Class
slug: reference/sadconsole.effects.effectsmanager.coloredglyphwithstate
sidebar:
  label: EffectsManager.ColoredGlyphWithState
editUrl: false
description: A glyph with its original state.
---
## Definition

A glyph with its original state.

```csharp title="C#"
protected class EffectsManager.ColoredGlyphWithState
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ColoredGlyphWithState(ColoredGlyphBase)

Creates a new instance of this class with the specified cell and index.

```csharp title="C#"
public ColoredGlyphWithState(ColoredGlyphBase cell)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The cell to generate a state from.


## Fields

### Cell

The cell.

```csharp title="C#"
public ColoredGlyphBase Cell
```

### State

The original state of the cell.

```csharp title="C#"
public ColoredGlyphBase State
```