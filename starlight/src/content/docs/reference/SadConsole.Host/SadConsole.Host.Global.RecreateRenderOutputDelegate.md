---
title: Global.RecreateRenderOutputDelegate Delegate
slug: reference/sadconsole.host.global.recreaterenderoutputdelegate
sidebar:
  label: Global.RecreateRenderOutputDelegate
---
## Definition

Regenerates the [RenderOutput](../sadconsole.host.global/#renderoutput/) if the desired size doesn't match the current size.

```csharp title="C#"
public delegate void Global.RecreateRenderOutputDelegate(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the render output.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the render output.


## Constructors

### RecreateRenderOutputDelegate(object, nint)

```csharp title="C#"
public RecreateRenderOutputDelegate(object @object, nint method)
```

#### Parameters

`object` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

`method` [nint](https://learn.microsoft.com/dotnet/api/system.intptr/)  


## Methods

### Invoke(int, int)

```csharp title="C#"
public virtual void Invoke(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### BeginInvoke(int, int, AsyncCallback, object)

```csharp title="C#"
public virtual IAsyncResult BeginInvoke(int width, int height, AsyncCallback callback, object @object)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`callback` [AsyncCallback](https://learn.microsoft.com/dotnet/api/system.asynccallback/)  

`object` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

#### Returns

[IAsyncResult](https://learn.microsoft.com/dotnet/api/system.iasyncresult/)

### EndInvoke(IAsyncResult)

```csharp title="C#"
public virtual void EndInvoke(IAsyncResult result)
```

#### Parameters

`result` [IAsyncResult](https://learn.microsoft.com/dotnet/api/system.iasyncresult/)