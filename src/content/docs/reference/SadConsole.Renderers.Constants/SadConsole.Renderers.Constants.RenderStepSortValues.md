---
title: RenderStepSortValues Class
slug: reference/sadconsole.renderers.constants.renderstepsortvalues
sidebar:
  label: RenderStepSortValues
editUrl: false
description: Renderer names used by hosts and types.
---
## Definition

Renderer names used by hosts and types.

```csharp title="C#"
public static class RenderStepSortValues
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### Surface

The render step for a [IScreenSurface](../sadconsole.iscreensurface/).

```csharp title="C#"
public const uint Surface = 50
```

### ControlHost

The render step for a [ControlHost](../sadconsole.ui.controlhost/).

```csharp title="C#"
public const uint ControlHost = 80
```

### Window

The render step for a [Window](../sadconsole.ui.window/).

```csharp title="C#"
public const uint Window = 10
```

### Cursor

The render step for a [Cursor](../sadconsole.components.cursor/).

```csharp title="C#"
public const uint Cursor = 70
```

### EntityRenderer

The render step for a [EntityManager](../sadconsole.entities.entitymanager/).

```csharp title="C#"
public const uint EntityRenderer = 60
```

### Output

The render to draw the output texture of an [IRenderer](../sadconsole.renderers.irenderer/).

```csharp title="C#"
public const uint Output = 50
```

### Tint

The render to draw the tint texture of an [IScreenSurface](../sadconsole.iscreensurface/).

```csharp title="C#"
public const uint Tint = 90
```