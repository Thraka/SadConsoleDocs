---
title: IRendererMonoGame Interface
slug: reference/sadconsole.renderers.irenderermonogame
sidebar:
  label: IRendererMonoGame
---
## Definition

MonoGame-specific renderer settings.

```csharp title="C#"
public interface IRendererMonoGame
```


## Properties

### MonoGameBlendState

The blend state used by this renderer.

```csharp title="C#"
BlendState MonoGameBlendState { get; set; }
```

### CachedRenderRects

Cached set of rectangles used in rendering each cell.

```csharp title="C#"
Rectangle[] CachedRenderRects { get; }
```