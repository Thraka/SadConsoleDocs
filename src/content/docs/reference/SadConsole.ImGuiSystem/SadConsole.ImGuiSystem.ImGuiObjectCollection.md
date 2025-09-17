---
title: ImGuiObjectCollection Class
slug: reference/sadconsole.imguisystem.imguiobjectcollection
sidebar:
  label: ImGuiObjectCollection
---
## Definition

A collection of [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/) objects that can be added to a ImGui renderer.

```csharp title="C#"
public class ImGuiObjectCollection : ImGuiObjectBase, IList<ImGuiObjectBase>, ICollection<ImGuiObjectBase>, IEnumerable<ImGuiObjectBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)

Implements [IList\<ImGuiObjectBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ImGuiObjectBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ImGuiObjectBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### ImGuiObjectCollection()

Creates a new instance of this object.

```csharp title="C#"
public ImGuiObjectCollection()
```


## Properties

### this[int]

```csharp title="C#"
public ImGuiObjectBase this[int index] { get; set; }
```

### Count

```csharp title="C#"
public int Count { get; }
```

### IsReadOnly

```csharp title="C#"
public bool IsReadOnly { get; }
```

## Methods

### BuildUI(ImGuiRenderer)

Draws the objects contained in this collection if [IsVisible](../sadconsole.imguisystem.imguiobjectbase/#isvisible/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public override void BuildUI(ImGuiRenderer renderer)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  
The ImGui renderer.


### Add(ImGuiObjectBase)

```csharp title="C#"
public void Add(ImGuiObjectBase item)
```

#### Parameters

`item` [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)  


### Clear()

```csharp title="C#"
public void Clear()
```


### Contains(ImGuiObjectBase)

```csharp title="C#"
public bool Contains(ImGuiObjectBase item)
```

#### Parameters

`item` [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### CopyTo(ImGuiObjectBase[], int)

```csharp title="C#"
public void CopyTo(ImGuiObjectBase[] array, int arrayIndex)
```

#### Parameters

`array` [ImGuiObjectBase[]](../sadconsole.imguisystem.imguiobjectbase/)  

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### GetEnumerator()

```csharp title="C#"
public IEnumerator<ImGuiObjectBase> GetEnumerator()
```

#### Returns

[IEnumerator\<ImGuiObjectBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)

### IndexOf(ImGuiObjectBase)

```csharp title="C#"
public int IndexOf(ImGuiObjectBase item)
```

#### Parameters

`item` [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)  

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

### Insert(int, ImGuiObjectBase)

```csharp title="C#"
public void Insert(int index, ImGuiObjectBase item)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`item` [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)  


### Remove(ImGuiObjectBase)

```csharp title="C#"
public bool Remove(ImGuiObjectBase item)
```

#### Parameters

`item` [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### RemoveAt(int)

```csharp title="C#"
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)