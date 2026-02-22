---
title: Delay Class
slug: reference/sadconsole.effects.delay
sidebar:
  label: Delay
editUrl: false
description: An effect that doesn't do anything except run the `SadConsole.Effects.CellEffectBase.StartDelay` timer. Usually used with the `SadConsole.Effects.EffectSet` effect.
---
## Definition

An effect that doesn't do anything except run the [StartDelay](../sadconsole.effects.celleffectbase/#startdelay) timer. Usually used with the [EffectSet](../sadconsole.effects.effectset/) effect.

```csharp title="C#"
[DataContract]
public class Delay : CellEffectBase, ICellEffect
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [CellEffectBase](../sadconsole.effects.celleffectbase/)

Implements [ICellEffect](../sadconsole.effects.icelleffect/)

## Constructors

### Delay()

```csharp title="C#"
public Delay()
```


## Methods

### Update(TimeSpan)

Updates the state of the effect.

```csharp title="C#"
public override void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Time since the last call to this effect.


### ApplyToCell(ColoredGlyphBase, ColoredGlyphBase)

Applies the state of the effect to a cell.

```csharp title="C#"
public override bool ApplyToCell(ColoredGlyphBase cell, ColoredGlyphBase state)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The surface cell using this effect.

`state` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this method modified the `cell`; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

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