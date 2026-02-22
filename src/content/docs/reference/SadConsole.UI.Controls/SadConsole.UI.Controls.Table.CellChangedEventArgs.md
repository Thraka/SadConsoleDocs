---
title: Table.CellChangedEventArgs Class
slug: reference/sadconsole.ui.controls.table.cellchangedeventargs
sidebar:
  label: Table.CellChangedEventArgs
editUrl: false
description: Cell args for a table event
---
## Definition

Cell args for a table event

```csharp title="C#"
public sealed class Table.CellChangedEventArgs : Table.CellEventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/) → [Table.CellEventArgs](../sadconsole.ui.controls.table/)

## Fields

### PreviousCell

The original cell before the event was triggered

```csharp title="C#"
public readonly Table.Cell? PreviousCell
```