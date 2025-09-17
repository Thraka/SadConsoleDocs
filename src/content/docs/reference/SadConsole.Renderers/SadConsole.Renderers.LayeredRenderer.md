---
title: LayeredRenderer Class
slug: reference/sadconsole.renderers.layeredrenderer
sidebar:
  label: LayeredRenderer
---
## Definition

Draws a [LayeredSurface](../sadconsole.components.layeredsurface/) object by adding a [LayeredSurfaceRenderStep](../sadconsole.renderers.layeredsurfacerenderstep/) to the [Steps](../sadconsole.renderers.screensurfacerenderer/#steps/) collection. Skips drawing the normal surface.

```csharp title="C#"
public sealed class LayeredRenderer : ScreenSurfaceRenderer, IRenderer, IDisposable, IRendererMonoGame
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenSurfaceRenderer](../sadconsole.renderers.screensurfacerenderer/)

Implements [IRenderer](../sadconsole.renderers.irenderer/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IRendererMonoGame](../sadconsole.renderers.irenderermonogame/)

## Constructors

### LayeredRenderer()

```csharp title="C#"
public LayeredRenderer()
```


## Methods

### AddDefaultSteps()

Adds the render steps this renderer uses.

```csharp title="C#"
protected override void AddDefaultSteps()
```