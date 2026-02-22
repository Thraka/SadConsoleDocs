---
title: WindowRenderStep Class
slug: reference/sadconsole.renderers.windowrenderstep
sidebar:
  label: WindowRenderStep
editUrl: false
description: Renders the dimmed background screen when a window is modal.
---
## Definition

Renders the dimmed background screen when a window is modal.

```csharp title="C#"
public class WindowRenderStep : IRenderStep, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IRenderStep](../sadconsole.renderers.irenderstep/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### WindowRenderStep()

```csharp title="C#"
public WindowRenderStep()
```


## Properties

### Name

The name of the render step.

```csharp title="C#"
public string Name { get; }
```

### SortOrder

Indicates priority related to other steps. Lowest runs first.

```csharp title="C#"
public uint SortOrder { get; set; }
```

## Methods

### SetData(object)

Not used.

```csharp title="C#"
public void SetData(object data)
```

#### Parameters

`data` [object](https://learn.microsoft.com/dotnet/api/system.object/)  


### Reset()

Called when the step should reset any state or texture information.

```csharp title="C#"
public void Reset()
```


### Refresh(IRenderer, IScreenSurface, bool, bool)

Does nothing.

```csharp title="C#"
public bool Refresh(IRenderer renderer, IScreenSurface screenObject, bool backingTextureChanged, bool isForced)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  

`backingTextureChanged` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`isForced` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Composing(IRenderer, IScreenSurface)

Does nothing.

```csharp title="C#"
public void Composing(IRenderer renderer, IScreenSurface screenObject)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  


### Render(IRenderer, IScreenSurface)

Called when building draw calls for the render pipeline.

```csharp title="C#"
public void Render(IRenderer renderer, IScreenSurface screenObject)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  
The renderer the render step is using.

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface associated with the renderer. This may be null.


### Dispose()

Does nothing.

```csharp title="C#"
public void Dispose()
```