---
title: Extensions Class
slug: reference/sadconsole.configuration.extensions
sidebar:
  label: Extensions
editUrl: false
description: Extensions to the `SadConsole.Configuration.Builder` type.
---
## Definition

Extensions to the [Builder](../sadconsole.configuration.builder/) type.

```csharp title="C#"
public static class Extensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### OnStart(Builder, EventHandler\<GameHost>)

Sets an event handler for the [Started](../sadconsole.gamehost/#started) event.

```csharp title="C#"
public static Builder OnStart(this Builder configBuilder, EventHandler<GameHost> instance_Started)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`instance_Started` [EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)  
The event handler

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### OnEnd(Builder, EventHandler\<GameHost>)

Sets an event handler for the [Ending](../sadconsole.gamehost/#ending) event.

```csharp title="C#"
public static Builder OnEnd(this Builder configBuilder, EventHandler<GameHost> instance_Ending)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`instance_Ending` [EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)  
The event handler

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### AddFrameUpdateEvent(Builder, EventHandler\<GameHost>)

Sets an event handler for the [FrameUpdate](../sadconsole.gamehost/#frameupdate) event.

```csharp title="C#"
public static Builder AddFrameUpdateEvent(this Builder configBuilder, EventHandler<GameHost> instance_FrameUpdate)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`instance_FrameUpdate` [EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)  
The event handler

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### AddFrameRenderEvent(Builder, EventHandler\<GameHost>)

Sets an event handler for the [FrameRender](../sadconsole.gamehost/#framerender) event.

```csharp title="C#"
public static Builder AddFrameRenderEvent(this Builder configBuilder, EventHandler<GameHost> instance_FrameRender)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`instance_FrameRender` [EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)  
The event handler

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### ConfigureWindow(Builder, Action\<ConfigureWindowConfig, BuilderBase, GameHost>)

Configures the game window.

```csharp title="C#"
public static Builder ConfigureWindow(this Builder configBuilder, Action<ConfigureWindowConfig, BuilderBase, GameHost> loader)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`loader` [Action\<ConfigureWindowConfig, BuilderBase, GameHost\>](https://learn.microsoft.com/dotnet/api/system.action-3/)  
The method to invoke when this is run.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### SetScreenSize(Builder, int, int)

:::caution[Obsolete]
Use SetWindowSizeInCells instead.
:::
Sets the initial screen size of the window, in cells.

```csharp title="C#"
[Obsolete("Use SetWindowSizeInCells instead.")]
public static Builder SetScreenSize(this Builder configBuilder, int width, int height)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The cell count along the x-axis.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The cell count along the y-axis.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### SetWindowSizeInCells(Builder, int, int, bool)

Sets the desired resolution of the SadConsole window in cells using the default font.

```csharp title="C#"
public static Builder SetWindowSizeInCells(this Builder configBuilder, int width, int height, bool zoom = false)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How wide the window is in font cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How tall the window is in font cells.

`zoom` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, creates a larger window to automatically zoom the contents.

#### Returns

[Builder](../sadconsole.configuration.builder/)
#### Remarks

The `width` and `height` values are used to generate the game window based on how large the font is. For example, if the font is 10x8, and you request window size of 20x20, a window is created with a width of 10 * 20 and a height of 8 * 20 in pixels, which is 200x160.  When `zoom` is set to true, the window will try to get as big as possible while keeping the SadConsole output crisp.

### SetWindowSizeInPixels(Builder, int, int)

Sets the desired resolution of the SadConsole window in pixels. The output surface and initial cell counts are calculated based on the current font, and set to a value that allows the most cells to appear on screen.

```csharp title="C#"
public static Builder SetWindowSizeInPixels(this Builder configBuilder, int width, int height)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the window.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the window.

#### Returns

[Builder](../sadconsole.configuration.builder/)

### UseDefaultConsole(Builder)

Sets the [StartingConsole](../sadconsole.gamehost/#startingconsole) and [Screen](../sadconsole.gamehost/#screen) properties to new console when the game starts.

```csharp title="C#"
public static Builder UseDefaultConsole(this Builder configBuilder)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### ConfigureFonts(Builder, Action\<FontConfig, GameHost>)

Configures which default font to use during game startup, as well as which other fonts to load for the game.

```csharp title="C#"
public static Builder ConfigureFonts(this Builder configBuilder, Action<FontConfig, GameHost> fontLoader)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`fontLoader` [Action\<FontConfig, GameHost\>](https://learn.microsoft.com/dotnet/api/system.action-2/)  
A method that provides access to the [FontConfig](../sadconsole.configuration.fontconfig/) object that loads fonts.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### ConfigureFonts(Builder, string, string[]?)

Configures SadConsole to use the specified font file as the default font.

```csharp title="C#"
public static Builder ConfigureFonts(this Builder configBuilder, string customDefaultFont, string[]? extraFonts = null)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`customDefaultFont` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Creates the font config for SadConsole using this font file as the default.

`extraFonts` [string[]](https://learn.microsoft.com/dotnet/api/system.string/)  
Extra fonts to load into SadConsole.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### ConfigureFonts(Builder, bool)

Configures SadConsole to use the built in default fonts.

```csharp title="C#"
public static Builder ConfigureFonts(this Builder configBuilder, bool useExtendedDefault = false)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`useExtendedDefault` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, SadConsole sets the default font to [EmbeddedFontExtended](../sadconsole.gamehost/#embeddedfontextended); otherwise [EmbeddedFont](../sadconsole.gamehost/#embeddedfont) is used.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### FixOldFontName(Builder)

Adds the embedded fonts to the font dictionary with the old incorrect name.

```csharp title="C#"
public static Builder FixOldFontName(this Builder configBuilder)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### SetDefaultFontSize(Builder, Sizes)

Sets the default font size for the game. The default is [One](../sadconsole.ifont.sizes/#one).

```csharp title="C#"
public static Builder SetDefaultFontSize(this Builder configBuilder, IFont.Sizes size)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`size` [IFont.Sizes](../sadconsole.ifont/)  
The size of the default font.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### SetSplashScreen\<TSplashScreen>(Builder)

Sets the startup splash screen to the specified object.

```csharp title="C#"
public static Builder SetSplashScreen<TSplashScreen>(this Builder configBuilder) where TSplashScreen : IScreenSurface, new()
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### SetSplashScreen(Builder, Func\<GameHost, ScreenSurface[]>)

Sets the startup splash screens to the array returned by the `creator` delegate.

```csharp title="C#"
public static Builder SetSplashScreen(this Builder configBuilder, Func<GameHost, ScreenSurface[]> creator)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`creator` [Func\<GameHost, ScreenSurface[]\>](https://learn.microsoft.com/dotnet/api/system.func-2/)  
A delegate that returns an array of surface objects.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### SetStartingScreen\<TRootObject>(Builder)

Sets the [Screen](../sadconsole.gamehost/#screen) property to the specified type.

```csharp title="C#"
public static Builder SetStartingScreen<TRootObject>(this Builder configBuilder) where TRootObject : IScreenObject, new()
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### SetStartingScreen(Builder, Func\<GameHost, IScreenObject>)

Sets the [Screen](../sadconsole.gamehost/#screen) property to the return value of the `creator` parameter.

```csharp title="C#"
public static Builder SetStartingScreen(this Builder configBuilder, Func<GameHost, IScreenObject> creator)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`creator` [Func\<GameHost, IScreenObject\>](https://learn.microsoft.com/dotnet/api/system.func-2/)  
A method that returns an object as the starting screen.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### IsStartingScreenFocused(Builder, bool)

Either focuses or unfocuses the starting screen.

```csharp title="C#"
public static Builder IsStartingScreenFocused(this Builder configBuilder, bool value)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates whether or not [Screen](../sadconsole.gamehost/#screen) is focused.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.