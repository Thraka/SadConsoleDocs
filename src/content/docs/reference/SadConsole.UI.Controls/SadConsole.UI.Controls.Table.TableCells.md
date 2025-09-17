---
title: Table.TableCells Class
slug: reference/sadconsole.ui.controls.table.tablecells
sidebar:
  label: Table.TableCells
---
## Definition

A collection class that contains all the cells of the [Table](../sadconsole.ui.controls.table/) and methods to modify them.

```csharp title="C#"
public sealed class Table.TableCells : IEnumerable<Table.Cell>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IEnumerable\<Table.Cell\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Properties

### this[int, int]

Gets or creates a new cell on the specified row and column

```csharp title="C#"
public Table.Cell this[int row, int col] { get; }
```

### MaxRow

The maximum row in the table.

```csharp title="C#"
public int MaxRow { get; }
```

### MaxColumn

The maximum column in the table.

```csharp title="C#"
public int MaxColumn { get; }
```

### HeaderRow

True if row 0 should be the header of the table, and remain at the top when vertical scrolling.

```csharp title="C#"
public bool HeaderRow { get; set; }
```

### Count

The amount of cells currently in the table.

```csharp title="C#"
public int Count { get; }
```

## Methods

### Row(int, bool)

Sets the visibility of the entire row

```csharp title="C#"
public void Row(int row, bool visible)
```

#### Parameters

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`visible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### Column(int, bool)

Sets the visibility of the entire column

```csharp title="C#"
public void Column(int column, bool visible)
```

#### Parameters

`column` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`visible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### Column(int)

Get the layout for the given column

```csharp title="C#"
public Table.TableCells.Layout Column(int column)
```

#### Parameters

`column` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[Table.TableCells.Layout](../sadconsole.ui.controls.table/)

### Row(int)

Get the layout for the given row

```csharp title="C#"
public Table.TableCells.Layout Row(int row)
```

#### Parameters

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[Table.TableCells.Layout](../sadconsole.ui.controls.table/)

### GetCell(int, int)

Gets the cell at the given row and col

```csharp title="C#"
public Table.Cell GetCell(int row, int col)
```

#### Parameters

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[Table.Cell](../sadconsole.ui.controls.table/)

### Select(int, int)

Sets the specified cell as the selected cell if it exists.

```csharp title="C#"
public void Select(int row, int column)
```

#### Parameters

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`column` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### Deselect()

Deselects the current selected cell.

```csharp title="C#"
public void Deselect()
```


### Remove(int, int)

Removes a cell from the table.

```csharp title="C#"
public void Remove(int row, int column)
```

#### Parameters

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`column` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### Clear(bool)

Resets all the cells data

```csharp title="C#"
public void Clear(bool clearLayoutOptions = true)
```

#### Parameters

`clearLayoutOptions` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### ClearContent(bool)

Removes all rows and columns except the header if applicable

```csharp title="C#"
public void ClearContent(bool clearLayoutOptionsForContent = true)
```

#### Parameters

`clearLayoutOptionsForContent` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### GetEnumerator()

```csharp title="C#"
public IEnumerator<Table.Cell> GetEnumerator()
```

#### Returns

[IEnumerator\<Table.Cell\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)