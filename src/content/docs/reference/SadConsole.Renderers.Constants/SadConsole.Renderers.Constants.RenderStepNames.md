---
title: RenderStepNames Class
slug: reference/sadconsole.renderers.constants.renderstepnames
sidebar:
  label: RenderStepNames
editUrl: false
description: Renderer names used by hosts and types.
---
## Definition

Renderer names used by hosts and types.

```csharp title="C#"
public static class RenderStepNames
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### Surface

The render step for a [IScreenSurface](../sadconsole.iscreensurface/).

```csharp title="C#"
public const string Surface = "surface"
```

### SurfaceDirtyCells

The render step for a [IScreenSurface](../sadconsole.iscreensurface/) where individual cells are only rendered if they're dirty.

```csharp title="C#"
public const string SurfaceDirtyCells = "surface_dirtycells"
```

### SurfaceLayered

The render step for a [IScreenSurface](../sadconsole.iscreensurface/) where multiple layers are exposed through a property.

```csharp title="C#"
public const string SurfaceLayered = "surface_layered"
```

### ControlHost

The render step for a [ControlHost](../sadconsole.ui.controlhost/).

```csharp title="C#"
public const string ControlHost = "controlhost"
```

### Window

The render step for a [Window](../sadconsole.ui.window/).

```csharp title="C#"
public const string Window = "windowmodal"
```

### Cursor

The render step for a [Cursor](../sadconsole.components.cursor/).

```csharp title="C#"
public const string Cursor = "cursor"
```

### EntityManager

The render step for a [EntityManager](../sadconsole.entities.entitymanager/).

```csharp title="C#"
public const string EntityManager = "entitymanager"
```

### Output

The render to draw the output texture of an [IRenderer](../sadconsole.renderers.irenderer/).

```csharp title="C#"
public const string Output = "output"
```

### Tint

The render to draw the tint texture of an [IScreenSurface](../sadconsole.iscreensurface/).

```csharp title="C#"
public const string Tint = "tint"
```