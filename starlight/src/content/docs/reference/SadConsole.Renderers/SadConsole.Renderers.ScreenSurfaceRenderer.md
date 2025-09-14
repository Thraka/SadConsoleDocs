---
title: ScreenSurfaceRenderer Class
slug: reference/sadconsole.renderers.screensurfacerenderer
sidebar:
  label: ScreenSurfaceRenderer
---
## Definition

Draws a [IScreenSurface](../sadconsole.iscreensurface/).

```csharp title="C#"
public class ScreenSurfaceRenderer : IRenderer, IDisposable, IRendererMonoGame
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IRenderer](../sadconsole.renderers.irenderer/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IRendererMonoGame](../sadconsole.renderers.irenderermonogame/)
## Remarks

This renderer caches the entire drawing of the surface's cells, including the tint of the object.

## Constructors

### ScreenSurfaceRenderer()

Creates a new instance of this renderer with the default steps.

```csharp title="C#"
public ScreenSurfaceRenderer()
```


## Fields

### _renderTexture

The final texture steps are drawing on.

```csharp title="C#"
protected GameTexture _renderTexture
```

### _backingTexture

Quick access to backing texture.

```csharp title="C#"
public RenderTarget2D _backingTexture
```

### _finalDrawColor

Color used with drawing the texture to the screen. Let's a surface become transparent.

```csharp title="C#"
public Color _finalDrawColor
```

### disposedValue

Detects redundant calls.

```csharp title="C#"
protected bool disposedValue
```

## Properties

### Name

The name used to create the renderer from the host.

```csharp title="C#"
public string Name { get; set; }
```

### Output

The cached texture of the drawn surface.

```csharp title="C#"
public ITexture Output { get; }
```

### MonoGameBlendState

The blend state used by this renderer.

```csharp title="C#"
public BlendState MonoGameBlendState { get; set; }
```

### BackingTextureUsageMode

Used when creating the [_backingTexture](../sadconsole.renderers.screensurfacerenderer/#backingtexture/) variable.

```csharp title="C#"
public RenderTargetUsage BackingTextureUsageMode { get; set; }
```

### Opacity

A 0 to 255 value representing how transparent the surface is when it's drawn to the screen. 255 represents full visibility.

```csharp title="C#"
public byte Opacity { get; set; }
```

### IsForced

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the renderer is being forced to be redrawn this frame; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsForced { get; set; }
```

### Steps

The render steps for the renderer.

```csharp title="C#"
public List<IRenderStep> Steps { get; set; }
```

### CachedRenderRects

Cached set of rectangles used in rendering each cell.

```csharp title="C#"
public Rectangle[] CachedRenderRects { get; protected set; }
```

## Methods

### Refresh(IScreenSurface, bool)

Refreshes a cached drawing state.

```csharp title="C#"
public virtual void Refresh(IScreenSurface screen, bool force = false)
```

#### Parameters

`screen` [IScreenSurface](../sadconsole.iscreensurface/)  

`force` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the refresh should happen even if a surface isn't dirty.


### Render(IScreenSurface)

Creates a drawcall in the drawing pipeline.

```csharp title="C#"
public virtual void Render(IScreenSurface screen)
```

#### Parameters

`screen` [IScreenSurface](../sadconsole.iscreensurface/)  


### AddDefaultSteps()

Adds the render steps this renderer uses.

```csharp title="C#"
protected virtual void AddDefaultSteps()
```


### Dispose(bool)

Release the backing texture and the render texture target.

```csharp title="C#"
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates that the managed resources should be cleaned up.


### ~ScreenSurfaceRenderer()

Disposes the object.

```csharp title="C#"
protected ~ScreenSurfaceRenderer()
```


### Dispose()

```csharp title="C#"
public void Dispose()
```


## Events

### BackingTextureRecreated

Raised when the [_backingTexture](../sadconsole.renderers.screensurfacerenderer/#backingtexture/) is recreated.

```csharp title="C#"
public event EventHandler BackingTextureRecreated
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)