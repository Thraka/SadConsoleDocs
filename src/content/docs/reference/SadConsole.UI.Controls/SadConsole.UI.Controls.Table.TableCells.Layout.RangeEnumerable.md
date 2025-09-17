---
title: Table.TableCells.Layout.RangeEnumerable Class
slug: reference/sadconsole.ui.controls.table.tablecells.layout.rangeenumerable
sidebar:
  label: Table.TableCells.Layout.RangeEnumerable
---
## Definition

An enumerable range that contains the layouts of all the rows and columns defined by the size of the range method within [Cells](../sadconsole.ui.controls.table/#cells/)

```csharp title="C#"
public class Table.TableCells.Layout.RangeEnumerable : IEnumerable<Table.TableCells.Layout>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IEnumerable\<Table.TableCells.Layout\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Methods

### SetLayout(int?, Color?, Color?, Options?)

Sets the layout of all the columns and rows for the given params

```csharp title="C#"
public void SetLayout(int? size = null, Color? foreground = null, Color? background = null, Table.Cell.Options? settings = null)
```

#### Parameters

`size` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  

`foreground` System.NullableSadRogue.Primitives.Color  

`background` System.NullableSadRogue.Primitives.Color  

`settings` [Table.Cell.Options](../sadconsole.ui.controls.table/)  


### GetEnumerator()

```csharp title="C#"
public IEnumerator<Table.TableCells.Layout> GetEnumerator()
```

#### Returns

[IEnumerator\<Table.TableCells.Layout\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)