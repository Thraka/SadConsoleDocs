---
title: WindowRenderer Class
slug: reference/sadconsole.renderers.windowrenderer
sidebar:
  label: WindowRenderer
editUrl: false
description: Draws a `SadConsole.UI.Window` object by adding a `SadConsole.Renderers.WindowRenderStep` to the `SadConsole.Renderers.ScreenSurfaceRenderer.Steps` collection.
---
## Definition

Draws a [Window](../sadconsole.ui.window/) object by adding a [WindowRenderStep](../sadconsole.renderers.windowrenderstep/) to the [Steps](../sadconsole.renderers.screensurfacerenderer/#steps) collection.

```csharp title="C#"
public sealed class WindowRenderer : ScreenSurfaceRenderer, IRenderer, IDisposable, IRendererMonoGame
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenSurfaceRenderer](../sadconsole.renderers.screensurfacerenderer/)

Implements [IRenderer](../sadconsole.renderers.irenderer/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IRendererMonoGame](../sadconsole.renderers.irenderermonogame/)

## Constructors

### WindowRenderer()

```csharp title="C#"
public WindowRenderer()
```


## Methods

### AddDefaultSteps()

Adds the render steps this renderer uses.

```csharp title="C#"
protected override void AddDefaultSteps()
```