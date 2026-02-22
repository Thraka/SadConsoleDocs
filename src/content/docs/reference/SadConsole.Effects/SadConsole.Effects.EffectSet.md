---
title: EffectSet Class
slug: reference/sadconsole.effects.effectset
sidebar:
  label: EffectSet
editUrl: false
description: Chains one effect after another.
---
## Definition

Chains one effect after another.

```csharp title="C#"
[DataContract]
public class EffectSet : CellEffectBase, ICellEffect, IEnumerable<ICellEffect>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [CellEffectBase](../sadconsole.effects.celleffectbase/)

Implements [ICellEffect](../sadconsole.effects.icelleffect/), [IEnumerable\<ICellEffect\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### EffectSet()

```csharp title="C#"
public EffectSet()
```


## Properties

### Effects

The list of effects to process.

```csharp title="C#"
[DataMember]
public LinkedList<ICellEffect> Effects { get; }
```

### Repeat

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, instead of ending when finished, it will repeat. Otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public bool Repeat { get; set; }
```

### DelayBetweenEffects

An artificial delay between each effect.

```csharp title="C#"
[DataMember]
public TimeSpan DelayBetweenEffects { get; set; }
```

## Methods

### ApplyToCell(ColoredGlyphBase, ColoredGlyphBase)

Applies the state of the effect to a cell.

```csharp title="C#"
public override bool ApplyToCell(ColoredGlyphBase cell, ColoredGlyphBase originalState)
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
public override void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Time since the last call to this effect.


### Restart()

Restarts the cell effect but does not reset it.

```csharp title="C#"
public override void Restart()
```


### Clone()

Returns a duplicate of this effect.

```csharp title="C#"
public override ICellEffect Clone()
```

#### Returns

[ICellEffect](../sadconsole.effects.icelleffect/)  
A new copy of this effect.

### ToString()

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)

### GetEnumerator()

Gets an enumerator of all the effects.

```csharp title="C#"
public IEnumerator<ICellEffect> GetEnumerator()
```

#### Returns

[IEnumerator\<ICellEffect\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)  
The enumerator.

### Add(ICellEffect)

Adds an effect to the end of the [Effects](../sadconsole.effects.effectset/#effects) collection.

```csharp title="C#"
public void Add(ICellEffect effect)
```

#### Parameters

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The effect to add.