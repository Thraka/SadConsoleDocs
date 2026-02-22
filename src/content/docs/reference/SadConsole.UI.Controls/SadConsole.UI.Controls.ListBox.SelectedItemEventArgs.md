---
title: ListBox.SelectedItemEventArgs Class
slug: reference/sadconsole.ui.controls.listbox.selecteditemeventargs
sidebar:
  label: ListBox.SelectedItemEventArgs
editUrl: false
description: The event args used when the selected item changes.
---
## Definition

The event args used when the selected item changes.

```csharp title="C#"
public class ListBox.SelectedItemEventArgs : EventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/)

## Constructors

### SelectedItemEventArgs(object?)

Creates a new instance of this type with the specified item.

```csharp title="C#"
public SelectedItemEventArgs(object? item)
```

#### Parameters

`item` [object](https://learn.microsoft.com/dotnet/api/system.object/)  
The selected item from the list.


## Fields

### Item

The item selected.

```csharp title="C#"
public readonly object? Item
```