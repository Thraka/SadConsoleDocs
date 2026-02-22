---
title: Settings Class
slug: reference/sadconsole.host.settings
sidebar:
  label: Settings
editUrl: false
description: A settings class usually used when creating the host object.
---
## Definition

A settings class usually used when creating the host object.

```csharp title="C#"
public static class Settings
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### UseHardwareFullScreen

Tells MonoGame to use a full screen resolution change instead of soft (quick) full screen. Must be set before the game is created.

```csharp title="C#"
public static bool UseHardwareFullScreen { get; set; }
```

### MonoGameSurfaceBlendState

The blend state used with [IRenderer](../sadconsole.renderers.irenderer/) on surfaces.

```csharp title="C#"
public static BlendState MonoGameSurfaceBlendState { get; set; }
```

### MonoGameScreenBlendState

The blend state used when drawing surfaces to the screen.

```csharp title="C#"
public static BlendState MonoGameScreenBlendState { get; set; }
```

### GraphicsProfile

The MonoGame graphics profile to target.

```csharp title="C#"
public static GraphicsProfile GraphicsProfile { get; set; }
```