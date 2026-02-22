---
title: Settings.Rendering Class
slug: reference/sadconsole.settings.rendering
sidebar:
  label: Settings.Rendering
editUrl: false
description: Rendering options generally set by a game host.
---
## Definition

Rendering options generally set by a game host.

```csharp title="C#"
public static class Settings.Rendering
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### RenderWidth

The width of the area to render on the game window.

```csharp title="C#"
public static int RenderWidth { get; set; }
```

### RenderHeight

The height of the area to render on the game window.

```csharp title="C#"
public static int RenderHeight { get; set; }
```

### RenderRect

Where on the screen the engine will be rendered.

```csharp title="C#"
public static Rectangle RenderRect { get; set; }
```

### RenderScale

If the [RenderRect](../sadconsole.settings.rendering/#renderrect) is stretched, this is the ratio difference between unstretched.

```csharp title="C#"
public static (float X, float Y) RenderScale { get; set; }
```