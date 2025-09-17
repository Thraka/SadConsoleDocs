---
title: ButtonBox Class
slug: reference/sadconsole.ui.controls.buttonbox
sidebar:
  label: ButtonBox
---
## Definition

A button control that is drawn using lines around it.

```csharp title="C#"
[DataContract]
public class ButtonBox : ButtonBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/)

## Constructors

### ButtonBox(int, int)

Creates an instance of the button control with the specified width and height.

```csharp title="C#"
public ButtonBox(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control (default is 1).


## Properties

### UseExtended

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the lines of the theme should use the extended SadConsole font characters if available.

```csharp title="C#"
[DataMember]
public bool UseExtended { get; set; }
```

## Methods

### RefreshThemeStateColors(Colors)

Updates the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/) by calling [RefreshTheme(Colors)](../sadconsole.ui.themestates/#/) with the provided colors. Override this method to adjust how colors are used by the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/).

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