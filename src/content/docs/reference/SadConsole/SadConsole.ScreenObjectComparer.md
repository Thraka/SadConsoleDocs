---
title: ScreenObjectComparer Class
slug: reference/sadconsole.screenobjectcomparer
sidebar:
  label: ScreenObjectComparer
editUrl: false
description: Compares `SadConsole.IScreenObject` with the `SadConsole.IScreenObject.SortOrder` property.
---
## Definition

Compares [IScreenObject](../sadconsole.iscreenobject/) with the [SortOrder](../sadconsole.iscreenobject/#sortorder) property.

```csharp title="C#"
public class ScreenObjectComparer : IComparer<IScreenObject>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComparer\<IScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer-1/)

## Constructors

### ScreenObjectComparer()

```csharp title="C#"
public ScreenObjectComparer()
```


## Properties

### Instance

Shared instance of the [ScreenObjectComparer](../sadconsole.screenobjectcomparer/).

```csharp title="C#"
public static ScreenObjectComparer Instance { get; }
```

## Methods

### Compare(IScreenObject?, IScreenObject?)

```csharp title="C#"
public int Compare(IScreenObject? x, IScreenObject? y)
```

#### Parameters

`x` [IScreenObject](../sadconsole.iscreenobject/)  

`y` [IScreenObject](../sadconsole.iscreenobject/)  

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)