---
title: Fade Class
slug: reference/sadconsole.effects.fade
sidebar:
  label: Fade
editUrl: false
description: Fades both the background and foreground to separate colors.
---
## Definition

Fades both the background and foreground to separate colors.

```csharp title="C#"
[DataContract]
public class Fade : CellEffectBase, ICellEffect
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [CellEffectBase](../sadconsole.effects.celleffectbase/)

Implements [ICellEffect](../sadconsole.effects.icelleffect/)

## Constructors

### Fade()

Creates a new instance of the effect.

```csharp title="C#"
public Fade()
```


## Fields

### _calculatedValue

A value used in lerping the fade.

```csharp title="C#"
protected double _calculatedValue
```

### _goingDown

Indicates the fade is currently in reverse.

```csharp title="C#"
protected bool _goingDown
```

## Properties

### DestinationBackground

Gets or sets the color gradient used to fade for the cell background.

```csharp title="C#"
[DataMember]
public Gradient DestinationBackground { get; set; }
```

### DestinationForeground

Gets or sets the color gradient used to fade for the cell background.

```csharp title="C#"
[DataMember]
public Gradient DestinationForeground { get; set; }
```

### FadeDuration

Gets or sets how long the fade takes to complete in seconds.

```csharp title="C#"
[DataMember]
public TimeSpan FadeDuration { get; set; }
```

### Repeat

Gets or sets a value to indicate that the fade effect should repeat.

```csharp title="C#"
[DataMember]
public bool Repeat { get; set; }
```

### UseCellForeground

Gets or sets a value to indicate that the color gradient used with the [DestinationForeground](../sadconsole.effects.fade/#destinationforeground) should replace its first color stop with the cell's foreground color.

```csharp title="C#"
[DataMember]
public bool UseCellForeground { get; set; }
```

### UseCellBackground

Gets or sets a value to indicate that the color gradient used with the [DestinationBackground](../sadconsole.effects.fade/#destinationbackground) should replace its first color stop with the cell's background color.

```csharp title="C#"
[DataMember]
public bool UseCellBackground { get; set; }
```

### FadeForeground

Gets or sets a value to indicate that the fade effect should use the foreground color on the cell's foreground.

```csharp title="C#"
[DataMember]
public bool FadeForeground { get; set; }
```

### FadeBackground

Gets or sets a value to indicate that the fade effect should use the background color on the cell's background.

```csharp title="C#"
[DataMember]
public bool FadeBackground { get; set; }
```

### AutoReverse

Gets or sets a value to indicate that the fade effect should automatically reverse itself when it finishes going up the color spectrum. By setting this to true, and setting the [Repeat](../sadconsole.effects.fade/#repeat) property to true, you can create a pulse effect.

```csharp title="C#"
[DataMember]
public bool AutoReverse { get; set; }
```

### UseCellDestinationReverse

When [UseCellForeground](../sadconsole.effects.fade/#usecellforeground) or [UseCellBackground](../sadconsole.effects.fade/#usecellbackground) is set, and this is true, the last color in the fade will be set to the cell instead of the first.

```csharp title="C#"
[DataMember]
public bool UseCellDestinationReverse { get; set; }
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

Restarts the cell effect.

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