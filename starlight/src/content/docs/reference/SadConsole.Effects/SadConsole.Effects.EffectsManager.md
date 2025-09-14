---
title: EffectsManager Class
slug: reference/sadconsole.effects.effectsmanager
sidebar:
  label: EffectsManager
---
## Definition

Effects manager for a text surface.

```csharp title="C#"
public class EffectsManager
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### EffectsManager(ICellSurface)

Creates a new effects manager associated with a text surface.

```csharp title="C#"
public EffectsManager(ICellSurface surface)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  
Text surface to manage.


## Fields

### _effects

A dictionary of effect data keyed by the effect.

```csharp title="C#"
protected Dictionary<ICellEffect, EffectsManager.ColoredGlyphEffectData> _effects
```

### _effectCells

A dictionary of effect data keyed by the cell index.

```csharp title="C#"
protected Dictionary<ColoredGlyphBase, EffectsManager.ColoredGlyphEffectData> _effectCells
```

### _backingSurface

The surface hosting this effects manager.

```csharp title="C#"
protected ICellSurface _backingSurface
```

## Properties

### Count

Gets the number of effects.

```csharp title="C#"
public int Count { get; }
```

## Methods

### SetEffect(ColoredGlyphBase, ICellEffect?)

Associates a cell effect with a cell.

```csharp title="C#"
public void SetEffect(ColoredGlyphBase cell, ICellEffect? effect)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
Cell to set the effect for.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The effect to associate with the cell.


### SetEffect(IEnumerable<ColoredGlyphBase>, ICellEffect?)

Changes the effect of the `cells` provided.

```csharp title="C#"
public void SetEffect(IEnumerable<ColoredGlyphBase> cells, ICellEffect? effect)
```

#### Parameters

`cells` [IEnumerable\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
A list of cell indicies to change the effect on.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The effect to associate with the cell.


### GetEffect(ColoredGlyphBase)

Gets the effect of the specified cell.

```csharp title="C#"
public ICellEffect? GetEffect(ColoredGlyphBase cell)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  

#### Returns

[ICellEffect](../sadconsole.effects.icelleffect/)  
The effect.

### GetEffects()

Gets a collection of effects associated with the manager.

```csharp title="C#"
public IEnumerable<ICellEffect>? GetEffects()
```

#### Returns

[IEnumerable\<ICellEffect\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
Null if there aren't any effects.

### DropInvalidCells()

Checks all the cells in this manager and removes any that are no longer in the parent surface.

```csharp title="C#"
public void DropInvalidCells()
```


### Remove(ICellEffect)

Removes an effect and associated cells from the manager.

```csharp title="C#"
public void Remove(ICellEffect effect)
```

#### Parameters

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
Effect to remove.


### RemoveAll()

Removes all effects and associated cells.

```csharp title="C#"
public void RemoveAll()
```


### GetKnownEffect(ICellEffect, out ColoredGlyphEffectData)

Gets effect data from the dictionary if it exists.

```csharp title="C#"
protected bool GetKnownEffect(ICellEffect effect, out EffectsManager.ColoredGlyphEffectData effectData)
```

#### Parameters

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The effect to get.

`effectData` [EffectsManager.ColoredGlyphEffectData](../sadconsole.effects.effectsmanager/)  
The effect data ssociated with the effect.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the effect exists; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### ClearCellEffect(ColoredGlyphBase)

Clears the effect for the cell specified by index.

```csharp title="C#"
protected void ClearCellEffect(ColoredGlyphBase cell)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The cell index.


### UpdateEffects(TimeSpan)

Updates all known effects and applies them to their associated cells.

```csharp title="C#"
public void UpdateEffects(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time elapased since the last update.