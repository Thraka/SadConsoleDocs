---
title: TableExtensions Class
slug: reference/sadconsole.ui.controls.tableextensions
sidebar:
  label: TableExtensions
---
## Definition

Extensions used for the [Table](../sadconsole.ui.controls.table/)

```csharp title="C#"
public static class TableExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### Range(TableCells, int, int, int, int)

Returns a range of cells that fits the given parameter values.

```csharp title="C#"
public static IEnumerable<Table.Cell> Range(this Table.TableCells cells, int startRow, int startCol, int endRow, int endCol)
```

#### Parameters

`cells` [Table.TableCells](../sadconsole.ui.controls.table/)  

`startRow` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`startCol` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`endRow` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`endCol` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[IEnumerable\<Table.Cell\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)

### ForEach(IEnumerable<Cell>, Action<Cell>)

Executes an action on each cell.

```csharp title="C#"
public static void ForEach(this IEnumerable<Table.Cell> range, Action<Table.Cell> action)
```

#### Parameters

`range` [IEnumerable\<Table.Cell\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  

`action` [Action\<Table.Cell\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  


### SetLayout(Cell, Color?, Color?, Options?)

Sets the layout for the cell.

```csharp title="C#"
public static void SetLayout(this Table.Cell cell, Color? foreground = null, Color? background = null, Table.Cell.Options? settings = null)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  

`foreground` System.NullableSadRogue.Primitives.Color  

`background` System.NullableSadRogue.Primitives.Color  

`settings` [Table.Cell.Options](../sadconsole.ui.controls.table/)  


### Resize(Cell, int?, int?)

Resizes the entire column and row to the specified sizes. If no sizes are specified for both row and column, the cell will be reset to the default size.

```csharp title="C#"
public static void Resize(this Table.Cell cell, int? rowSize = null, int? columnSize = null)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  

`rowSize` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  

`columnSize` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  


### Select(Cell)

Sets the cell as the selected cell.

```csharp title="C#"
public static void Select(this Table.Cell cell)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  


### Deselect(Cell)

Incase this cell is the selected cell, it will unselect it.

```csharp title="C#"
public static void Deselect(this Table.Cell cell)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  


### Column(TableCells, params int[])

Get the layout for the given columns.

```csharp title="C#"
public static Table.TableCells.Layout.RangeEnumerable Column(this Table.TableCells cells, params int[] columns)
```

#### Parameters

`cells` [Table.TableCells](../sadconsole.ui.controls.table/)  

`columns` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[Table.TableCells.Layout.RangeEnumerable](../sadconsole.ui.controls.table/)

### Row(TableCells, params int[])

Get the layout for the given rows.

```csharp title="C#"
public static Table.TableCells.Layout.RangeEnumerable Row(this Table.TableCells cells, params int[] rows)
```

#### Parameters

`cells` [Table.TableCells](../sadconsole.ui.controls.table/)  

`rows` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[Table.TableCells.Layout.RangeEnumerable](../sadconsole.ui.controls.table/)

### Remove(Cell)

Removes the cell from its table.

```csharp title="C#"
public static void Remove(this Table.Cell cell)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)