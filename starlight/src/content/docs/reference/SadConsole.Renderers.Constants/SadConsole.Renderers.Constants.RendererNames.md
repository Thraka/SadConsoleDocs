---
title: RendererNames Class
slug: reference/sadconsole.renderers.constants.renderernames
sidebar:
  label: RendererNames
---
## Definition

Renderer names used by hosts and types.

```csharp title="C#"
public static class RendererNames
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### Default

The default renderer for a screen surface.

```csharp title="C#"
public const string Default = "default"
```

### ScreenSurface

The renderer for a [ScreenSurface](../sadconsole.renderers.constants.renderernames/#screensurface/).

```csharp title="C#"
public const string ScreenSurface = "screensurface"
```

### OptimizedScreenSurface

The renderer for a [ScreenSurface](../sadconsole.renderers.constants.renderernames/#screensurface/) that doesn't use any steps, it directly renders the surface to a cached texture.

```csharp title="C#"
public const string OptimizedScreenSurface = "optimizedscreensurface"
```

### LayeredScreenSurface

The renderer for a [LayeredScreenSurface](../sadconsole.renderers.constants.renderernames/#layeredscreensurface/).

```csharp title="C#"
public const string LayeredScreenSurface = "layeredscreensurface"
```

### Window

The renderer for a [Window](../sadconsole.ui.window/).

```csharp title="C#"
public const string Window = "window"
```

### None

An absent renderer.

```csharp title="C#"
public const string None = "none"
```