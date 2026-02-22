---
title: SadConsole.Renderers
slug: reference/sadconsole.renderers
sidebar:
  order: 0
editUrl: false
---
## Classes

| | |
| --- | --- |
| [ControlHostRenderStep](../sadconsole.renderers.controlhostrenderstep/) | Draws a [ControlHost](../sadconsole.ui.controlhost/). |
| [CursorRenderStep](../sadconsole.renderers.cursorrenderstep/) | Renders a cursor. |
| [EntityRenderStep](../sadconsole.renderers.entityrenderstep/) | Draws the entities of a [EntityManager](../sadconsole.entities.entitymanager/). |
| [LayeredRenderer](../sadconsole.renderers.layeredrenderer/) | Draws a [LayeredSurface](../sadconsole.components.layeredsurface/) object by adding a [LayeredSurfaceRenderStep](../sadconsole.renderers.layeredsurfacerenderstep/) to the [Steps](../sadconsole.renderers.screensurfacerenderer/#steps) collection. Skips drawing the normal surface. |
| [LayeredSurfaceRenderStep](../sadconsole.renderers.layeredsurfacerenderstep/) | Draws a [IScreenSurface](../sadconsole.iscreensurface/) object. |
| [OptimizedScreenSurfaceRenderer](../sadconsole.renderers.optimizedscreensurfacerenderer/) | Draws a [IScreenSurface](../sadconsole.iscreensurface/) with tint. Doesn't allow render steps. |
| [OutputSurfaceRenderStep](../sadconsole.renderers.outputsurfacerenderstep/) | A render step that draws the [_backingTexture](../sadconsole.renderers.screensurfacerenderer/#backingtexture) texture. |
| [RenderStepComparer](../sadconsole.renderers.renderstepcomparer/) | Compares [IRenderStep](../sadconsole.renderers.irenderstep/) with the [SortOrder](../sadconsole.renderers.irenderstep/#sortorder) property. |
| [ScreenSurfaceRenderer](../sadconsole.renderers.screensurfacerenderer/) | Draws a [IScreenSurface](../sadconsole.iscreensurface/). |
| [SurfaceDirtyCellsRenderStep](../sadconsole.renderers.surfacedirtycellsrenderstep/) | Draws a [IScreenSurface](../sadconsole.iscreensurface/) object. |
| [SurfaceRenderStep](../sadconsole.renderers.surfacerenderstep/) | Draws a [IScreenSurface](../sadconsole.iscreensurface/) object. |
| [TintSurfaceRenderStep](../sadconsole.renderers.tintsurfacerenderstep/) | Renders a tint on top of where the output texture is drawn. |
| [WindowRenderStep](../sadconsole.renderers.windowrenderstep/) | Renders the dimmed background screen when a window is modal. |
| [WindowRenderer](../sadconsole.renderers.windowrenderer/) | Draws a [Window](../sadconsole.ui.window/) object by adding a [WindowRenderStep](../sadconsole.renderers.windowrenderstep/) to the [Steps](../sadconsole.renderers.screensurfacerenderer/#steps) collection. |
## Interfaces

| | |
| --- | --- |
| [ILayeredData](../sadconsole.renderers.ilayereddata/) | Provides the methods and properties used by the LayeredSurface renderer. |
| [IRenderStep](../sadconsole.renderers.irenderstep/) | A rendering step processed by an [IRenderer](../sadconsole.renderers.irenderer/). |
| [IRenderStepTexture](../sadconsole.renderers.irendersteptexture/) | Indicates the render step has an associated texture. |
| [IRenderer](../sadconsole.renderers.irenderer/) | Draws a surface. |
| [IRendererMonoGame](../sadconsole.renderers.irenderermonogame/) | MonoGame-specific renderer settings. |
| [IWindowData](../sadconsole.renderers.iwindowdata/) | Provides the methods and properties used by the Window renderer. |