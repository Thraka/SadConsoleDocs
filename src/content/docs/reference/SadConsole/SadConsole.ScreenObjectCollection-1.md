---
title: ScreenObjectCollection<TScreenObject> Class
slug: reference/sadconsole.screenobjectcollection-1
sidebar:
  label: ScreenObjectCollection<TScreenObject>
editUrl: false
description: Manages the parent and children relationship for `SadConsole.IScreenObject`.
---
## Definition

Manages the parent and children relationship for [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public class ScreenObjectCollection<TScreenObject> : IReadOnlyList<TScreenObject>, IReadOnlyCollection<TScreenObject>, IEnumerable<TScreenObject>, IEnumerable where TScreenObject : class, IScreenObject
```

### Type Parameters

`TScreenObject`  


Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IReadOnlyList\<TScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1/), [IReadOnlyCollection\<TScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1/), [IEnumerable\<TScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### ScreenObjectCollection(IScreenObject)

Creates a new object collection and parents it to the `owner` object.

```csharp title="C#"
public ScreenObjectCollection(IScreenObject owner)
```

#### Parameters

`owner` [IScreenObject](../sadconsole.iscreenobject/)  
The owning object of this collection.


## Fields

### _objects

Internal list of objects.

```csharp title="C#"
protected List<TScreenObject> _objects
```

### _owningObject

The parent object.

```csharp title="C#"
protected IScreenObject _owningObject
```

## Properties

### Count

Returns the total number of objects in this collection.

```csharp title="C#"
public int Count { get; }
```

### IsLocked

When true, the collection cannot be modified.

```csharp title="C#"
public bool IsLocked { get; set; }
```

### this[int]

Gets or sets a child object for this collection.

```csharp title="C#"
public TScreenObject this[int index] { get; set; }
```

## Methods

### Clear()

Removes all consoles.

```csharp title="C#"
public void Clear()
```


### Contains(TScreenObject)

Returns true if this console list contains the specified `obj`.

```csharp title="C#"
public bool Contains(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The console to search for.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### IsTop(TScreenObject)

When true, indicates that the `obj` is at the top of the collection stack.

```csharp title="C#"
public bool IsTop(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The obj object to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the object is on the top.

### IsBottom(TScreenObject)

When true, indicates that the `obj` is at the bottom of the collection stack.

```csharp title="C#"
public bool IsBottom(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The obj object to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the object is on the bottom.

### Add(TScreenObject)

Adds a new child object to this collection.

```csharp title="C#"
public void Add(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The child object.

#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when the [IsLocked](../sadconsole.screenobjectcollection-1/#islocked) property is set to true.


### Insert(int, TScreenObject)

Inserts a child object at the specified `index`.

```csharp title="C#"
public void Insert(int index, TScreenObject obj)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The 0-based index to insert the object at.

`obj` TScreenObject  
The child object.

#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when the [IsLocked](../sadconsole.screenobjectcollection-1/#islocked) property is set to true.


### Remove(TScreenObject)

Removes a new child object from this collection.

```csharp title="C#"
public void Remove(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The child object.

#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when the [IsLocked](../sadconsole.screenobjectcollection-1/#islocked) property is set to true.


### Sort(IComparer\<IScreenObject>)

Sorts the collection based on [SortOrder](../sadconsole.iscreenobject/#sortorder).

```csharp title="C#"
public void Sort(IComparer<IScreenObject> comparer)
```

#### Parameters

`comparer` [IComparer\<IScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer-1/)  
The comparer to use

#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when the [IsLocked](../sadconsole.screenobjectcollection-1/#islocked) property is set to true.


### ToArray()

Copies the collections item to an array.

```csharp title="C#"
public TScreenObject[] ToArray()
```

#### Returns

TScreenObject[]  
A new array consisting of all of the objects in this collection.

### MoveToTop(TScreenObject)

Moves the specified `obj`  to the top of the collection.

```csharp title="C#"
public void MoveToTop(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The child object.


### MoveToBottom(TScreenObject)

Moves the specified `obj`  to the bottom of the collection.

```csharp title="C#"
public void MoveToBottom(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The child object.


### IndexOf(TScreenObject)

Gets the 0-based index of the `obj`.

```csharp title="C#"
public int IndexOf(TScreenObject obj)
```

#### Parameters

`obj` TScreenObject  
The child object.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

### GetEnumerator()

```csharp title="C#"
public IEnumerator<TScreenObject> GetEnumerator()
```

#### Returns

[IEnumerator\<TScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)

## Events

### CollectionChanged

Raised when the items in this collection are added, removed, or repositioned.

```csharp title="C#"
public event EventHandler? CollectionChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)