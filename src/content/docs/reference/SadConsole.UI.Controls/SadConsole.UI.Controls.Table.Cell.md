---
title: Table.Cell Class
slug: reference/sadconsole.ui.controls.table.cell
sidebar:
  label: Table.Cell
editUrl: false
description: A basic cell used in the Table control
---
## Definition

A basic cell used in the Table control

```csharp title="C#"
public sealed class Table.Cell : IEquatable<Table.Cell>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IEquatable\<Table.Cell\>](https://learn.microsoft.com/dotnet/api/system.iequatable-1/)

## Properties

### Row

The row this cell is part of

```csharp title="C#"
public int Row { get; }
```

### Column

The column this cell is part of

```csharp title="C#"
public int Column { get; }
```

### Height

The height of the row this cell is part of

```csharp title="C#"
public int Height { get; }
```

### Width

The width of the column this cell is part of

```csharp title="C#"
public int Width { get; }
```

### Foreground

The foreground color used by the cell

```csharp title="C#"
public Color Foreground { get; set; }
```

### Background

The background color used by the cell

```csharp title="C#"
public Color Background { get; set; }
```

### StringValue

The text shown within the cell, empty string when no value.

```csharp title="C#"
public string StringValue { get; }
```

### Value

The value of the cell, .ToString() method is shown as the text result within the cell.

```csharp title="C#"
public object? Value { get; set; }
```

### IsVisible

Set to false if the cell should not be rendered within the table (default IsVisible sadconsole behaviour), If an entire row or column IsVislbe is set to false in the layout, it will skip this row/column entirely (differs from default behaviour)

```csharp title="C#"
public bool IsVisible { get; set; }
```

### Settings

The setting options used by the cell to define its layout

```csharp title="C#"
public Table.Cell.Options Settings { get; }
```

## Methods

### InternalCreate(int, int, Table, object, bool)

Internal use only. This is used by the table and the theme to create new cell instances.

```csharp title="C#"
public static Table.Cell InternalCreate(int row, int col, Table table, object value, bool addToTableIfModified = true)
```

#### Parameters

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`table` [Table](../sadconsole.ui.controls.table/)  

`value` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

`addToTableIfModified` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

#### Returns

[Table.Cell](../sadconsole.ui.controls.table/)

### Equals(Cell?)

```csharp title="C#"
public bool Equals(Table.Cell? cell)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Equals(object?)

```csharp title="C#"
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### GetHashCode()

```csharp title="C#"
public override int GetHashCode()
```

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

### CopyAppearanceFrom(Cell)

Copies the appearance of the cell passed to this method, onto the this cell.

```csharp title="C#"
public void CopyAppearanceFrom(Table.Cell cell)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)