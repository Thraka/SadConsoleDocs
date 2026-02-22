---
title: TabItem Class
slug: reference/sadconsole.ui.controls.tabitem
sidebar:
  label: TabItem
editUrl: false
description: Contains the header and content of a tab for the `SadConsole.UI.Controls.TabControl`.
---
## Definition

Contains the header and content of a tab for the [TabControl](../sadconsole.ui.controls.tabcontrol/).

```csharp title="C#"
public class TabItem
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### TabItem(string, Panel)

Creates a new tab item with the specified header as a colored string, and sets the content for the tab.

```csharp title="C#"
public TabItem(string header, Panel content)
```

#### Parameters

`header` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The header to display on this tab item.

`content` [Panel](../sadconsole.ui.controls.panel/)  
The panel content to display for this tab.

#### Exceptions

[ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception/)  
Thrown when the `header` value is an empty string.


## Properties

### Header

Display text of the header. Also functions as the access key

```csharp title="C#"
public string Header { get; set; }
```

### ThemeHeaderStates

Temporary variable holding the theme state of the tab item header.

```csharp title="C#"
public ThemeStates ThemeHeaderStates { get; set; }
```

### ThemeHeaderArea

Temporary variable holding where on the tab control the header is drawn.

```csharp title="C#"
public Rectangle ThemeHeaderArea { get; set; }
```

### ThemeHeaderMouseArea

Temporary variable holding where on the tab control the mouse is tracked for this header.

```csharp title="C#"
public Rectangle ThemeHeaderMouseArea { get; set; }
```

### Content

The content of this tab item.

```csharp title="C#"
public Panel Content { get; set; }
```

### TabSize

The size in cells to allocate for displaying the header. <pre>`-1`</pre> indicates that the tab should be automatically sized to fit the size of the [Header](../sadconsole.ui.controls.tabitem/#header).

```csharp title="C#"
public int TabSize { get; set; }
```

### AutomaticPadding

Padding to add around the [Header](../sadconsole.ui.controls.tabitem/#header) text when [TabSize](../sadconsole.ui.controls.tabitem/#tabsize) is unset (-1).

```csharp title="C#"
public int AutomaticPadding { get; set; }
```

### TextAlignment

If [TabSize](../sadconsole.ui.controls.tabitem/#tabsize) is any value other than <pre>`-1`</pre>, the [Header](../sadconsole.ui.controls.tabitem/#header) is aligned according to this property.

```csharp title="C#"
public HorizontalAlignment TextAlignment { get; set; }
```