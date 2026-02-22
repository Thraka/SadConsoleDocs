---
title: SurfaceRenderStep Class
slug: reference/sadconsole.renderers.surfacerenderstep
sidebar:
  label: SurfaceRenderStep
editUrl: false
description: Draws a `SadConsole.IScreenSurface` object.
---
## Definition

Draws a [IScreenSurface](../sadconsole.iscreensurface/) object.

```csharp title="C#"
public class SurfaceRenderStep : IRenderStep, IDisposable, IRenderStepTexture
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IRenderStep](../sadconsole.renderers.irenderstep/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IRenderStepTexture](../sadconsole.renderers.irendersteptexture/)

## Constructors

### SurfaceRenderStep()

```csharp title="C#"
public SurfaceRenderStep()
```


## Properties

### BackingTexture

The cached texture of the drawn surface.

```csharp title="C#"
public RenderTarget2D? BackingTexture { get; }
```

### CachedTexture

The texture created by the render step.

```csharp title="C#"
public ITexture? CachedTexture { get; }
```

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

### ComposeTint

The color applied when the sprite batch draws this surface on the renderer.

```csharp title="C#"
public Color ComposeTint { get; set; }
```

## Methods

### SetData(object)

Sets an alternative [IScreenSurface](../sadconsole.iscreensurface/) to render. If null, the surface associated with the parent renderer is drawn.

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

Called to redraw the render step if needed.

```csharp title="C#"
public bool Refresh(IRenderer renderer, IScreenSurface screenObject, bool backingTextureChanged, bool isForced)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  
The renderer the render step is using.

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface associated with the renderer. This may be null.

`backingTextureChanged` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate the [Output](../sadconsole.renderers.irenderer/#output) changed; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

`isForced` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when refresh is being forced; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the step is going to draw something new and is requesting a [Composing(IRenderer, IScreenSurface)](../sadconsole.renderers.irenderstep/#composingirenderer-iscreensurface) step; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### Composing(IRenderer, IScreenSurface)

Called when the renderer needs to redraw the [Output](../sadconsole.renderers.irenderer/#output) texture.

```csharp title="C#"
public void Composing(IRenderer renderer, IScreenSurface screenObject)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  
The renderer the render step is using.

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface associated with the renderer. This may be null.


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


### Dispose(bool)

Disposes the object.

```csharp title="C#"
protected void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate this method was called from [Dispose()](../sadconsole.renderers.surfacerenderstep/#dispose).


### Dispose()

```csharp title="C#"
public void Dispose()
```


### ~SurfaceRenderStep()

Finalizes the object for collection.

```csharp title="C#"
protected ~SurfaceRenderStep()
```