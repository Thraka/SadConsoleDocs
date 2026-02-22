---
title: ICellEffect Interface
slug: reference/sadconsole.effects.icelleffect
sidebar:
  label: ICellEffect
editUrl: false
description: The interface describing a cell effect
---
## Definition

The interface describing a cell effect

```csharp title="C#"
public interface ICellEffect
```


## Properties

### IsFinished

True when the effect is finished.

```csharp title="C#"
bool IsFinished { get; }
```

### CloneOnAdd

Flags this effect to be cloned when assigned to a cell instead of reused.

```csharp title="C#"
bool CloneOnAdd { get; set; }
```

### StartDelay

A delay applied to the effect only when it first runs or is restarted.

```csharp title="C#"
TimeSpan StartDelay { get; set; }
```

### RemoveOnFinished

When true, the effect should be disassociated with cells when it has finished processing.

```csharp title="C#"
bool RemoveOnFinished { get; set; }
```

### RestoreCellOnRemoved

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the [EffectsManager](../sadconsole.effects.effectsmanager/) should restore the cell to its original state.

```csharp title="C#"
bool RestoreCellOnRemoved { get; set; }
```

### RunEffectOnApply

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the [EffectsManager](../sadconsole.effects.effectsmanager/) should run one update frame on this effect when it's first added to the manager.

```csharp title="C#"
bool RunEffectOnApply { get; set; }
```

## Methods

### ApplyToCell(ColoredGlyphBase, ColoredGlyphBase)

Applies the state of the effect to a cell.

```csharp title="C#"
bool ApplyToCell(ColoredGlyphBase cell, ColoredGlyphBase originalState)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The surface cell using this effect.

`originalState` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The state of the cell prior to the effect being applied.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this method modified the `cell`; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### Update(TimeSpan)

Updates the state of the effect.

```csharp title="C#"
void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Time since the last call to this effect.


### Restart()

Restarts the cell effect.

```csharp title="C#"
void Restart()
```


### Clone()

Returns a duplicate of this effect.

```csharp title="C#"
ICellEffect Clone()
```

#### Returns

[ICellEffect](../sadconsole.effects.icelleffect/)  
A new copy of this effect.