---
title: Table.TableCells.Layout Class
slug: reference/sadconsole.ui.controls.table.tablecells.layout
sidebar:
  label: Table.TableCells.Layout
editUrl: false
description: Defines the layout for a row or a column defined in `SadConsole.UI.Controls.Table.Cells`
---
## Definition

Defines the layout for a row or a column defined in [Cells](../sadconsole.ui.controls.table/#cells)

```csharp title="C#"
public class Table.TableCells.Layout
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### Size

The size of the row or column

```csharp title="C#"
public int Size { get; set; }
```

### Foreground

The foreground color used by the row or column

```csharp title="C#"
public Color? Foreground { get; set; }
```

### Background

The background color used by the row or column

```csharp title="C#"
public Color? Background { get; set; }
```

### Settings

The setting options used by the row or column

```csharp title="C#"
public Table.Cell.Options Settings { get; set; }
```

## Methods

### Remove()

Removes this entire layout from the table.

```csharp title="C#"
public void Remove()
```


### SetLayout(int?, Color?, Color?, Options?)

Set a default layout to be used for each new cell

```csharp title="C#"
public void SetLayout(int? size = null, Color? foreground = null, Color? background = null, Table.Cell.Options? settings = null)
```

#### Parameters

`size` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  

`foreground` System.NullableSadRogue.Primitives.Color  

`background` System.NullableSadRogue.Primitives.Color  

`settings` [Table.Cell.Options](../sadconsole.ui.controls.table/)