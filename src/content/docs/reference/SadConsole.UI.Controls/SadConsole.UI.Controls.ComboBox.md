---
title: ComboBox Class
slug: reference/sadconsole.ui.controls.combobox
sidebar:
  label: ComboBox
editUrl: false
description: Represents a button that can be toggled on/off within a group of other buttons.
---
## Definition

Represents a button that can be toggled on/off within a group of other buttons.

```csharp title="C#"
[DataContract]
public class ComboBox : CheckBox
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/) → [ToggleButtonBase](../sadconsole.ui.controls.togglebuttonbase/) → [CheckBox](../sadconsole.ui.controls.checkbox/)

## Constructors

### ComboBox(int, int, int, object[])

Creates a new instance of the combobox control.

```csharp title="C#"
public ComboBox(int width, int dropdownWidth, int dropdownHeight, object[] items)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the control.

`dropdownWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the dropdown container.

`dropdownHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the dropdown container.

`items` [object[]](https://learn.microsoft.com/dotnet/api/system.object/)  
The items to seed the dropdown with.


## Fields

### DropdownContainer

Surface that contains the listbox

```csharp title="C#"
protected readonly ScreenSurface DropdownContainer
```

### ListBox

Listbox used to control the items

```csharp title="C#"
protected readonly ListBox ListBox
```

## Properties

### SelectedIndex

Gets or sets the index of the selected item.

```csharp title="C#"
public int SelectedIndex { get; set; }
```

### SelectedItem

Gets or sets the selected item.

```csharp title="C#"
public object? SelectedItem { get; set; }
```

### PopupInnerAligned

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, uses the [PopupHorizontal](../sadconsole.ui.controls.combobox/#popuphorizontal) value from the interior of the control. When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, it's used from the outside of the control.

```csharp title="C#"
[DataMember]
public bool PopupInnerAligned { get; set; }
```

### PopupHorizontal

Sets the horizontal orientation of the of the dropdown popup.

```csharp title="C#"
[DataMember]
public HorizontalAlignment PopupHorizontal { get; set; }
```

### PopupVertical

Sets the vertical orientation of the of the dropdown popup.

```csharp title="C#"
[DataMember]
public VerticalAlignment PopupVertical { get; set; }
```

### CollapsedButtonGlyph

The glyph to use on the control when it's collapsed.

```csharp title="C#"
[DataMember]
public int CollapsedButtonGlyph { get; set; }
```

### ExpandedButtonGlyph

The glyph to use on the control when it's expanded.

```csharp title="C#"
[DataMember]
public int ExpandedButtonGlyph { get; set; }
```

## Methods

### ResizeDropDown(int?, int?)

Resizes the dropdown container to the given width/height

```csharp title="C#"
public void ResizeDropDown(int? width = null, int? height = null)
```

#### Parameters

`width` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the dropdown

`height` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the dropdown


### SetItems(params object[])

Sets the items in the dropdown listbox.

```csharp title="C#"
public void SetItems(params object[] items)
```

#### Parameters

`items` [object[]](https://learn.microsoft.com/dotnet/api/system.object/)  
The items to set.


### GetItems()

Gets an array of items from the dropdown listbox.

```csharp title="C#"
public object[] GetItems()
```

#### Returns

[object[]](https://learn.microsoft.com/dotnet/api/system.object/)

### RepositionOffScreenContainer()

Checks if the dropdown container is off-screen, and pushes it back in.

```csharp title="C#"
protected void RepositionOffScreenContainer()
```


### OnIsSelected()

When [IsSelected](../sadconsole.ui.controls.togglebuttonbase/#isselected) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, displays the popup container. When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, hides the popup container.

```csharp title="C#"
protected override void OnIsSelected()
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


## Events

### SelectedItemChanged

An event that triggers when the [SelectedItem](../sadconsole.ui.controls.combobox/#selecteditem) property changes.

```csharp title="C#"
public event EventHandler<ListBox.SelectedItemEventArgs>? SelectedItemChanged
```

#### Event Type

[EventHandler\<ListBox.SelectedItemEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)