---
title: Table.Cell.Options Class
slug: reference/sadconsole.ui.controls.table.cell.options
sidebar:
  label: Table.Cell.Options
---
## Definition

A collection of settings that are used by [Table.Cell](../sadconsole.ui.controls.table/)

```csharp title="C#"
public class Table.Cell.Options : IEquatable<Table.Cell.Options>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IEquatable\<Table.Cell.Options\>](https://learn.microsoft.com/dotnet/api/system.iequatable-1/)

## Constructors

### Options(Table)

Creates new options based on the default values of the table

```csharp title="C#"
public Options(Table table)
```

#### Parameters

`table` [Table](../sadconsole.ui.controls.table/)  


## Properties

### HorizontalAlignment

The horizontal text alignment setting; Default: left

```csharp title="C#"
public Table.Cell.Options.HorizontalAlign HorizontalAlignment { get; set; }
```

### VerticalAlignment

The vertical text alignment setting; Default: left

```csharp title="C#"
public Table.Cell.Options.VerticalAlign VerticalAlignment { get; set; }
```

### UseFakeLayout

Defines if the cell should also trigger the fake layout event if the option is enabled on the table; Default: false

```csharp title="C#"
public bool UseFakeLayout { get; set; }
```

### MaxCharactersPerLine

The maximum characters this cell can show per line; Default: cell width

```csharp title="C#"
public int? MaxCharactersPerLine { get; set; }
```

### Interactable

Defines if the cell can interact with mouse events; Default: true

```csharp title="C#"
public bool Interactable { get; set; }
```

### Selectable

Defines if the cell can be selected by the mouse; Default: true

```csharp title="C#"
public bool Selectable { get; set; }
```

### SelectionMode

Defines the selection visual mode when the cell is selected; Default: single

```csharp title="C#"
public Table.TableCells.Layout.Mode SelectionMode { get; set; }
```

### HoverMode

Defines the hover visual mode when the cell is hovered over by the mouse; Default: single

```csharp title="C#"
public Table.TableCells.Layout.Mode HoverMode { get; set; }
```

## Methods

### Equals(Options?)

```csharp title="C#"
public bool Equals(Table.Cell.Options? other)
```

#### Parameters

`other` [Table.Cell.Options](../sadconsole.ui.controls.table/)  

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