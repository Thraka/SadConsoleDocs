---
title: Button3d Class
slug: reference/sadconsole.ui.controls.button3d
sidebar:
  label: Button3d
editUrl: false
description: A button control that is drawn with a shadow.
---
## Definition

A button control that is drawn with a shadow.

```csharp title="C#"
[DataContract]
public class Button3d : ButtonBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/)

## Constructors

### Button3d(int, int)

Creates an instance of the button control with the specified width and height.

```csharp title="C#"
public Button3d(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control (default is 1).


## Methods

### CreateControlSurface()

Generates the surface to be used by this control. This method is called internally to assign the [Surface](../sadconsole.ui.controls.controlbase/#surface) property a value.

```csharp title="C#"
protected override ICellSurface CreateControlSurface()
```

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
A surface that should be assigned to the [Surface](../sadconsole.ui.controls.controlbase/#surface) property.

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