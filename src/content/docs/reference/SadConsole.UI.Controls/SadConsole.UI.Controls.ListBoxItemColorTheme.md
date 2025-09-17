---
title: ListBoxItemColorTheme Class
slug: reference/sadconsole.ui.controls.listboxitemcolortheme
sidebar:
  label: ListBoxItemColorTheme
---
## Definition

A theme for a [ListBox](../sadconsole.ui.controls.listbox/) that displays a `SadRogue.Primitives.Color` object.

```csharp title="C#"
[DataContract]
public class ListBoxItemColorTheme : ListBoxItemTheme
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ThemeStates](../sadconsole.ui.themestates/) → [ListBoxItemTheme](../sadconsole.ui.controls.listboxitemtheme/)

## Constructors

### ListBoxItemColorTheme()

```csharp title="C#"
public ListBoxItemColorTheme()
```


## Properties

### UseSingleCharacterForBox

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, colored boxes used when drawing the color for (Color, string) tuple will use two characters; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> and only one character is used.

```csharp title="C#"
public bool UseSingleCharacterForBox { get; set; }
```

## Methods

### Draw(ControlBase, Rectangle, object, ControlStates)

Draws the `item` in the specified `area` of the listbox.

```csharp title="C#"
public override void Draw(ControlBase control, Rectangle area, object item, ControlStates itemState)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control containing a surface to draw on.

`area` SadRogue.Primitives.Rectangle  
The area to draw the item.

`item` [object](https://learn.microsoft.com/dotnet/api/system.object/)  
The item object.

`itemState` [ControlStates](../sadconsole.ui.controls.controlstates/)  
The state of the item.


### Clone()

Creates a copy of this theme.

```csharp title="C#"
public override ListBoxItemTheme Clone()
```

#### Returns

[ListBoxItemTheme](../sadconsole.ui.controls.listboxitemtheme/)  
A new theme object.