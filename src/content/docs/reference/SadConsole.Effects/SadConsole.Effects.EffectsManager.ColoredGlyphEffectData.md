---
title: EffectsManager.ColoredGlyphEffectData Class
slug: reference/sadconsole.effects.effectsmanager.coloredglypheffectdata
sidebar:
  label: EffectsManager.ColoredGlyphEffectData
---
## Definition

Represents a mapping of a single effect and associated cells.

```csharp title="C#"
protected class EffectsManager.ColoredGlyphEffectData
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ColoredGlyphEffectData(ICellEffect)

Creates a new instance of the cell-effect mapping.

```csharp title="C#"
public ColoredGlyphEffectData(ICellEffect effect)
```

#### Parameters

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The effect.


## Fields

### Effect

The effect.

```csharp title="C#"
public ICellEffect Effect
```

### CellsStates

The cells affected by the effect.

```csharp title="C#"
public List<EffectsManager.ColoredGlyphWithState> CellsStates
```

## Methods

### RemoveCell(ColoredGlyphBase, bool)

Removes a cell by index from the effect data.

```csharp title="C#"
public void RemoveCell(ColoredGlyphBase cell, bool restoreState)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The cell.

`restoreState` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> the cell will have its original state restored; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.


### ContainsCell(ColoredGlyphBase)

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the cell index is already associated with the effect; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool ContainsCell(ColoredGlyphBase cell)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The cell to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate the cell is associated with the effect; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.