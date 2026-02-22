---
title: ImGuiList<T> Class
slug: reference/sadconsole.imguisystem.imguilist-1
sidebar:
  label: ImGuiList<T>
editUrl: false
description: Wraps a collection of objects for ImGui controls, like list boxes.
---
## Definition

Wraps a collection of objects for ImGui controls, like list boxes.

```csharp title="C#"
public class ImGuiList<T> where T : class
```

### Type Parameters

`T`  
The type of object wrapped.

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ImGuiList(params T[])

Creates a new list, wrapping the provided items.

```csharp title="C#"
public ImGuiList(params T[] items)
```

#### Parameters

`items` T[]  
The items to wrap.


### ImGuiList(IEnumerable\<T>)

Creates a new list, wrapping the provided items.

```csharp title="C#"
public ImGuiList(IEnumerable<T> items)
```

#### Parameters

`items` [IEnumerable\<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The items to wrap.


### ImGuiList(int, params T[])

Creates a new list, wrapping the provided items, and sets which item is selected.

```csharp title="C#"
public ImGuiList(int selectedIndex, params T[] items)
```

#### Parameters

`selectedIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The 0-based index of the item to select.

`items` T[]  
The items to wrap.


### ImGuiList(int, IEnumerable\<T>)

Creates a new list, wrapping the provided items, and sets which item is selected.

```csharp title="C#"
public ImGuiList(int selectedIndex, IEnumerable<T> items)
```

#### Parameters

`selectedIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The 0-based index of the item to select.

`items` [IEnumerable\<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The items to wrap.


## Fields

### SelectedItemIndex

The selected index. Controlled by ImGui objects.

```csharp title="C#"
public int SelectedItemIndex
```

## Properties

### Names

Each item's title.

```csharp title="C#"
public string[] Names { get; }
```
#### Remarks

Refreshed when this property is accessed.

### Objects

The objects wrapped by this list.

```csharp title="C#"
public ObservableCollection<T> Objects { get; }
```

### Count

The number of items this list is wrapping.

```csharp title="C#"
public int Count { get; }
```

### SelectedItem

The selected item or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

```csharp title="C#"
public T? SelectedItem { get; set; }
```

## Methods

### IsItemSelected()

Indicates that an item is selected.

```csharp title="C#"
public bool IsItemSelected()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Checks if [SelectedItemIndex](../sadconsole.imguisystem.imguilist-1/#selecteditemindex) doesn't equal -1.