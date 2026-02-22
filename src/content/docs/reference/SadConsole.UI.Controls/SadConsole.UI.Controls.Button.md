---
title: Button Class
slug: reference/sadconsole.ui.controls.button
sidebar:
  label: Button
editUrl: false
description: Simple button control with a height of 1.
---
## Definition

Simple button control with a height of 1.

```csharp title="C#"
[DataContract]
public class Button : ButtonBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/)

## Constructors

### Button(int, int)

Creates an instance of the button control with the specified width and height.

```csharp title="C#"
public Button(int width, int height = 1)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control (default is 1).


### Button(string)

Creates an auto sizing button with the specified text.

```csharp title="C#"
public Button(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to display on the button.


## Properties

### ShowEnds

When true, renders the "end" glyphs on the button.

```csharp title="C#"
[DataMember]
public bool ShowEnds { get; set; }
```

### LeftEndGlyph

The theme state used with the left end of the button.Defaults to '&lt;'.

```csharp title="C#"
[DataMember]
public int LeftEndGlyph { get; set; }
```

### RightEndGlyph

The theme state used with the right end of the button. Defaults to '&gt;'.

```csharp title="C#"
[DataMember]
public int RightEndGlyph { get; set; }
```

### EndsThemeState

The theme state used with the left end of the button.

```csharp title="C#"
public ThemeStates EndsThemeState { get; protected set; }
```

## Methods

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


### CreateControlSurface()

Resizes the control surface based on [AutoSize](../sadconsole.ui.controls.buttonbase/#autosize) or the [Width](../sadconsole.ui.controls.controlbase/#width) and [Height](../sadconsole.ui.controls.controlbase/#height) properties.

```csharp title="C#"
protected override ICellSurface CreateControlSurface()
```

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
The control's surface.