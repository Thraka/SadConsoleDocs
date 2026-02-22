---
title: Global.ResizeGraphicsDeviceManagerDelegate Delegate
slug: reference/sadconsole.host.global.resizegraphicsdevicemanagerdelegate
sidebar:
  label: Global.ResizeGraphicsDeviceManagerDelegate
editUrl: false
description: Resizes the `SadConsole.Host.Global.GraphicsDeviceManager` by the specified font size.
---
## Definition

Resizes the [GraphicsDeviceManager](../sadconsole.host.global/#graphicsdevicemanager) by the specified font size.

```csharp title="C#"
public delegate void Global.ResizeGraphicsDeviceManagerDelegate(Point fontSize, int width, int height, int additionalWidth, int additionalHeight)
```

#### Parameters

`fontSize` Microsoft.Xna.Framework.Point  
The size of the font to base the final values on.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of glyphs along the X-axis.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of glyphs along the Y-axis.

`additionalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Additional pixel width to add to the resize.

`additionalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Additional pixel height to add to the resize.


## Constructors

### ResizeGraphicsDeviceManagerDelegate(object, nint)

```csharp title="C#"
public ResizeGraphicsDeviceManagerDelegate(object @object, nint method)
```

#### Parameters

`object` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

`method` [nint](https://learn.microsoft.com/dotnet/api/system.intptr/)  


## Methods

### Invoke(Point, int, int, int, int)

```csharp title="C#"
public virtual void Invoke(Point fontSize, int width, int height, int additionalWidth, int additionalHeight)
```

#### Parameters

`fontSize` Microsoft.Xna.Framework.Point  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`additionalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`additionalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### BeginInvoke(Point, int, int, int, int, AsyncCallback, object)

```csharp title="C#"
public virtual IAsyncResult BeginInvoke(Point fontSize, int width, int height, int additionalWidth, int additionalHeight, AsyncCallback callback, object @object)
```

#### Parameters

`fontSize` Microsoft.Xna.Framework.Point  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`additionalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`additionalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

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