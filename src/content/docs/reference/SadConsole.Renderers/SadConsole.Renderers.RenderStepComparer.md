---
title: RenderStepComparer Class
slug: reference/sadconsole.renderers.renderstepcomparer
sidebar:
  label: RenderStepComparer
editUrl: false
description: Compares `SadConsole.Renderers.IRenderStep` with the `SadConsole.Renderers.IRenderStep.SortOrder` property.
---
## Definition

Compares [IRenderStep](../sadconsole.renderers.irenderstep/) with the [SortOrder](../sadconsole.renderers.irenderstep/#sortorder) property.

```csharp title="C#"
public class RenderStepComparer : IComparer<IRenderStep>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComparer\<IRenderStep\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer-1/)

## Constructors

### RenderStepComparer()

```csharp title="C#"
public RenderStepComparer()
```


## Properties

### Instance

Shared instance of the [RenderStepComparer](../sadconsole.renderers.renderstepcomparer/).

```csharp title="C#"
public static RenderStepComparer Instance { get; }
```

## Methods

### Compare(IRenderStep?, IRenderStep?)

```csharp title="C#"
public int Compare(IRenderStep? x, IRenderStep? y)
```

#### Parameters

`x` [IRenderStep](../sadconsole.renderers.irenderstep/)  

`y` [IRenderStep](../sadconsole.renderers.irenderstep/)  

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)