---
title: Blinker Class
slug: reference/sadconsole.effects.blinker
sidebar:
  label: Blinker
---
## Definition

Blinks the foreground and background colors of a cell with the specified colors.

```csharp title="C#"
[DataContract]
public class Blinker : CellEffectBase, ICellEffect
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [CellEffectBase](../sadconsole.effects.celleffectbase/)

Implements [ICellEffect](../sadconsole.effects.icelleffect/)

## Constructors

### Blinker()

Creates a new instance of the blink effect.

```csharp title="C#"
public Blinker()
```


## Properties

### BlinkSpeed

How long it takes to transition from blinking in and out.

```csharp title="C#"
[DataMember]
public TimeSpan BlinkSpeed { get; set; }
```

### BlinkOutForegroundColor

The color the foreground blinks to.

```csharp title="C#"
[DataMember]
public Color BlinkOutForegroundColor { get; set; }
```

### BlinkOutBackgroundColor

The color the background blinks to.

```csharp title="C#"
[DataMember]
public Color BlinkOutBackgroundColor { get; set; }
```

### SwapColorsFromCell

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, ignores the [BlinkOutBackgroundColor](../sadconsole.effects.blinker/#blinkoutbackgroundcolor/) and [BlinkOutForegroundColor](../sadconsole.effects.blinker/#blinkoutforegroundcolor/) colors and instead swaps the glyph's foreground and background colors.

```csharp title="C#"
[DataMember]
public bool SwapColorsFromCell { get; set; }
```

### BlinkCount

How many times to blink. The value of -1 represents forever.

```csharp title="C#"
[DataMember]
public int BlinkCount { get; set; }
```

### Duration

The total duraction this effect will run for, before being flagged as finished. [MaxValue](https://learn.microsoft.com/dotnet/api/system.timespan.maxvalue/) represents forever.

```csharp title="C#"
[DataMember]
public TimeSpan Duration { get; set; }
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