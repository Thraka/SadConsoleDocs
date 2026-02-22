---
title: ListBoxItemTheme Class
slug: reference/sadconsole.ui.controls.listboxitemtheme
sidebar:
  label: ListBoxItemTheme
editUrl: false
description: A generic theme for a `SadConsole.UI.Controls.ListBox` item.
---
## Definition

A generic theme for a [ListBox](../sadconsole.ui.controls.listbox/) item.

```csharp title="C#"
public class ListBoxItemTheme : ThemeStates
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ThemeStates](../sadconsole.ui.themestates/)

## Constructors

### ListBoxItemTheme()

```csharp title="C#"
public ListBoxItemTheme()
```


## Properties

### UseColoredStringBackground

Gets or sets a value to allow printing the background of a colored string. When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, the control state background is used.

```csharp title="C#"
public bool UseColoredStringBackground { get; set; }
```

## Methods

### RefreshTheme(Colors)

Reloads the theme values based on the colors provided.

```csharp title="C#"
public override void RefreshTheme(Colors themeColors)
```

#### Parameters

`themeColors` [Colors](../sadconsole.ui.colors/)  


### Draw(ControlBase, Rectangle, object, ControlStates)

Draws the `item` in the specified `area` of the listbox.

```csharp title="C#"
public virtual void Draw(ControlBase control, Rectangle area, object item, ControlStates itemState)
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
public virtual ListBoxItemTheme Clone()
```

#### Returns

[ListBoxItemTheme](../sadconsole.ui.controls.listboxitemtheme/)  
A new theme object.