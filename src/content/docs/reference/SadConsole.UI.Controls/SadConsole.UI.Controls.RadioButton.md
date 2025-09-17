---
title: RadioButton Class
slug: reference/sadconsole.ui.controls.radiobutton
sidebar:
  label: RadioButton
---
## Definition

Represents a button that can be toggled on/off within a group of other buttons.

```csharp title="C#"
[DataContract]
public class RadioButton : ToggleButtonBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/) → [ToggleButtonBase](../sadconsole.ui.controls.togglebuttonbase/)

## Constructors

### RadioButton(int, int)

Creates a new radio button control with the specified width and height.

```csharp title="C#"
public RadioButton(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control.


### RadioButton(string)

Creates an auto sizing radio button control with the specified text.

```csharp title="C#"
public RadioButton(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


## Properties

### GroupName

The group of the radio button. All radio buttons with the same group name will work together to keep one radio button selected at a time.

```csharp title="C#"
public string GroupName { get; set; }
```

### LeftBracketGlyph

The glyph for the left-side bracket of the icon.

```csharp title="C#"
[DataMember]
public int LeftBracketGlyph { get; set; }
```

### RightBracketGlyph

The glyph for the right-side bracket of the icon.

```csharp title="C#"
[DataMember]
public int RightBracketGlyph { get; set; }
```

### CheckedIconGlyph

The glyph of the icon when checked.

```csharp title="C#"
[DataMember]
public int CheckedIconGlyph { get; set; }
```

### UncheckedIconGlyph

The glyph of the icon when unchecked.

```csharp title="C#"
[DataMember]
public int UncheckedIconGlyph { get; set; }
```

### CheckedIconColor

An optional color of the [CheckedIconGlyph](../sadconsole.ui.controls.radiobutton/#checkediconglyph/).

```csharp title="C#"
[DataMember]
public Color? CheckedIconColor { get; set; }
```

### UncheckedIconColor

An optional color of the [UncheckedIconGlyph](../sadconsole.ui.controls.radiobutton/#uncheckediconglyph/).

```csharp title="C#"
[DataMember]
public Color? UncheckedIconColor { get; set; }
```

### BracketsThemeState

The theme state used with the brackets.

```csharp title="C#"
public ThemeStates BracketsThemeState { get; protected set; }
```

### IconThemeState

The theme state used with the icon of the

```csharp title="C#"
public ThemeStates IconThemeState { get; protected set; }
```

## Methods

### OnClick()

Performs a click on the base button and also toggles the [IsSelected](../sadconsole.ui.controls.togglebuttonbase/#isselected/) property.

```csharp title="C#"
protected override void OnClick()
```


### OnIsSelected()

Raises the [IsSelectedChanged](../sadconsole.ui.controls.togglebuttonbase/#isselectedchanged/) event and when [IsSelected](../sadconsole.ui.controls.togglebuttonbase/#isselected/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, deselects any other [RadioButton](../sadconsole.ui.controls.radiobutton/) with the same [GroupName](../sadconsole.ui.controls.radiobutton/#groupname/).

```csharp title="C#"
protected override void OnIsSelected()
```


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


### CreateControlSurface()

Resizes the control surface based on [AutoSize](../sadconsole.ui.controls.buttonbase/#autosize/) or the [Width](../sadconsole.ui.controls.controlbase/#width/) and [Height](../sadconsole.ui.controls.controlbase/#height/) properties.

```csharp title="C#"
protected override ICellSurface CreateControlSurface()
```

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
The control's surface.