---
title: Global Class
slug: reference/sadconsole.host.global
sidebar:
  label: Global
editUrl: false
description: Global variables used by the MonoGame host.
---
## Definition

Global variables used by the MonoGame host.

```csharp title="C#"
public static class Global
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### BlockSadConsoleInput

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, prevents the keyboard and mouse logic from running.

```csharp title="C#"
public static bool BlockSadConsoleInput { get; set; }
```

### GraphicsDevice

The graphics device created by MonoGame.

```csharp title="C#"
public static GraphicsDevice GraphicsDevice { get; set; }
```

### SharedSpriteBatch

A sprite batch used by all of SadConsole to render objects.

```csharp title="C#"
public static SpriteBatch SharedSpriteBatch { get; set; }
```

### RenderOutput

The output texture. After each screen in SadConsole is drawn, they're then drawn on this output texture to compose the final scene.

```csharp title="C#"
public static RenderTarget2D RenderOutput { get; set; }
```

### UpdateLoopGameTime

Reference to the game timer used in the MonoGame update loop.

```csharp title="C#"
public static GameTime UpdateLoopGameTime { get; }
```

### RenderLoopGameTime

Reference to the game timer used in the MonoGame render loop.

```csharp title="C#"
public static GameTime RenderLoopGameTime { get; }
```

### RecreateRenderOutput

Regenerates the [RenderOutput](../sadconsole.host.global/#renderoutput) if the desired size doesn't match the current size.

```csharp title="C#"
public static Global.RecreateRenderOutputDelegate RecreateRenderOutput { get; set; }
```

### ResizeGraphicsDeviceManager

Resizes the [GraphicsDeviceManager](../sadconsole.host.global/#graphicsdevicemanager) by the specified font size.

```csharp title="C#"
public static Global.ResizeGraphicsDeviceManagerDelegate ResizeGraphicsDeviceManager { get; set; }
```

### ResetRendering

Resets the [RenderOutput](../sadconsole.host.global/#renderoutput) target and determines the appropriate [RenderRect](../sadconsole.settings.rendering/#renderrect) and ``SadConsole.Settings.Rendering.RenderScale`` based on the window or fullscreen state.

```csharp title="C#"
public static Action ResetRendering { get; set; }
```

### SadConsoleComponent

The game component to control SadConsole updates, input, and rendering.

```csharp title="C#"
public static SadConsoleGameComponent SadConsoleComponent { get; set; }
```

### GraphicsDeviceManager

The graphics device manager created by MonoGame.

```csharp title="C#"
public static GraphicsDeviceManager GraphicsDeviceManager { get; set; }
```

## Methods

### ResetGraphicsDevice()

Sets the [GraphicsDevice](../sadconsole.host.global/#graphicsdevice) render target to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, targeting the app window.

```csharp title="C#"
public static void ResetGraphicsDevice()
```


### ResizeGraphicsDeviceManagerHandler(Point, int, int, int, int)

Resizes the [GraphicsDeviceManager](../sadconsole.host.global/#graphicsdevicemanager) by the specified font size.

```csharp title="C#"
public static void ResizeGraphicsDeviceManagerHandler(Point fontSize, int width, int height, int additionalWidth, int additionalHeight)
```

#### Parameters

`fontSize` Microsoft.Xna.Framework.Point  
The size of the font to base the final values on.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of glyphs along the X-axis.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of glyphs along the Y-axis.

`additionalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Additional pixel width to add to the resize.

`additionalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Additional pixel height to add to the resize.


### RecreateRenderOutputHandler(int, int)

Regenerates the [RenderOutput](../sadconsole.host.global/#renderoutput) if the desired size doesn't match the current size.

```csharp title="C#"
public static void RecreateRenderOutputHandler(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the render output.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the render output.


### ResetRenderingHandler()

Resets the [RenderOutput](../sadconsole.host.global/#renderoutput) target and determines the appropriate [RenderRect](../sadconsole.settings.rendering/#renderrect) and ``SadConsole.Settings.Rendering.RenderScale`` based on the window or fullscreen state.

```csharp title="C#"
public static void ResetRenderingHandler()
```