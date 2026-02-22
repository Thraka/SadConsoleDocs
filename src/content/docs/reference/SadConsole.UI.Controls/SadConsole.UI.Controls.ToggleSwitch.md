---
title: ToggleSwitch Class
slug: reference/sadconsole.ui.controls.toggleswitch
sidebar:
  label: ToggleSwitch
editUrl: false
description: Represents a button that can be toggled on/off within a group of other buttons.
---
## Definition

Represents a button that can be toggled on/off within a group of other buttons.

```csharp title="C#"
[DataContract]
public class ToggleSwitch : ToggleButtonBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/) → [ToggleButtonBase](../sadconsole.ui.controls.togglebuttonbase/)

## Constructors

### ToggleSwitch(int, int)

Creates a new checkbox control with the specified width and height.

```csharp title="C#"
public ToggleSwitch(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the control.


## Properties

### OnGlyph

The on glyph of the switch.

```csharp title="C#"
[DataMember]
public int OnGlyph { get; set; }
```

### BackgroundGlyph

The background glyph of the switch.

```csharp title="C#"
[DataMember]
public int BackgroundGlyph { get; set; }
```

### OnGlyphColor

The color of the [OnGlyph](../sadconsole.ui.controls.toggleswitch/#onglyph) when the control is [IsSelected](../sadconsole.ui.controls.togglebuttonbase/#isselected) is true.

```csharp title="C#"
[DataMember]
public Color OnGlyphColor { get; set; }
```

### OffGlyphColor

The color of the [OnGlyph](../sadconsole.ui.controls.toggleswitch/#onglyph) when the control is [IsSelected](../sadconsole.ui.controls.togglebuttonbase/#isselected) is false.

```csharp title="C#"
[DataMember]
public Color OffGlyphColor { get; set; }
```

### SwitchThemeState

The theme state used for the switch.

```csharp title="C#"
public ThemeStates SwitchThemeState { get; protected set; }
```

### SwitchOrientation

The orientation of the toggle switch relative to the text.

```csharp title="C#"
public HorizontalAlignment SwitchOrientation { get; set; }
```
#### Remarks

Valid values are [Left](../sadconsole.horizontalalignment/#left) and [Right](../sadconsole.horizontalalignment/#right).

## Methods

### OnClick()

Perfroms a click on the base button and also toggles the [IsSelected](../sadconsole.ui.controls.togglebuttonbase/#isselected) property.

```csharp title="C#"
protected override void OnClick()
```


### RefreshThemeStateColors(Colors)

Updates the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate) by calling [RefreshTheme(Colors)](../sadconsole.ui.themestates/#refreshthemecolors) with the provided colors. Override this method to adjust how colors are used by the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate).

```csharp title="C#"
protected override void RefreshThemeStateColors(Colors colors)
```

#### Parameters

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply to the theme state.


### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.