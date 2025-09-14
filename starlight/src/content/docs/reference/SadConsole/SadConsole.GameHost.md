---
title: GameHost Class
slug: reference/sadconsole.gamehost
sidebar:
  label: GameHost
---
## Definition

Represents the SadConsole game engine.

```csharp title="C#"
public abstract class GameHost : IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)
## Remarks

When a new host is created, the host should do the following: - Run `LoadDefaultFonts`. - Run `SetRenderer` for `window`, `controls`, `layered`, and `default` renderers. - Run `LoadMappedColors`. - Configure the `Screen` to a new console with `ScreenCellsX` and `ScreenCellsY`. - Prior to running the game, run `SplashScreens.SplashScreenManager.CheckRun()`.

## Constructors

### GameHost()

```csharp title="C#"
protected GameHost()
```


## Fields

### _renderers

Holds all of the [IRenderer](../sadconsole.renderers.irenderer/) types.

```csharp title="C#"
protected Dictionary<string, Type> _renderers
```

### _rendererSteps

Holds all of the [IRenderStep](../sadconsole.renderers.irenderstep/) types.

```csharp title="C#"
protected Dictionary<string, Type> _rendererSteps
```

### _gameStartedAt

The date and time the game was started.

```csharp title="C#"
protected DateTime _gameStartedAt
```

## Properties

### _splashScreens

The splash screens to show on game startup.

```csharp title="C#"
protected Queue<IScreenSurface>? _splashScreens { get; set; }
```

### Instance

Instance of the game host.

```csharp title="C#"
public static GameHost Instance { get; protected set; }
```

### SerializerPathHint

Contains the path to a file being serialized or deserialized.

```csharp title="C#"
public static string SerializerPathHint { get; }
```

### DrawCalls

Draw calls registered for the next drawing frame.

```csharp title="C#"
public Queue<IDrawCall> DrawCalls { get; }
```

### ScreenCellsX

How many cells fit in the render area width used by SadConsole.

```csharp title="C#"
public int ScreenCellsX { get; }
```

### ScreenCellsY

How many cells fit in the render area width used by SadConsole.

```csharp title="C#"
public int ScreenCellsY { get; }
```

### FrameNumber

A frame number counter, incremented every game frame.

```csharp title="C#"
public int FrameNumber { get; set; }
```

### Fonts

Collection of fonts. Used mainly by the deserialization system.

```csharp title="C#"
public Dictionary<string, IFont> Fonts { get; }
```

### EmbeddedFont

The font automatically loaded by SadConsole. Standard IBM style font.

```csharp title="C#"
public SadFont EmbeddedFont { get; }
```

### EmbeddedFontExtended

The font automatically loaded by SadConsole. Standard IBM style font. Extended with extra SadConsole characters.

```csharp title="C#"
public SadFont EmbeddedFontExtended { get; }
```

### DefaultFont

The default font for any type that does not provide a font.

```csharp title="C#"
public IFont DefaultFont { get; set; }
```

### DefaultFontSize

The default font size to use with the [DefaultFont](../sadconsole.gamehost/#defaultfont/).

```csharp title="C#"
public IFont.Sizes DefaultFontSize { get; set; }
```

### Keyboard

Global keyboard object used by SadConsole during the update frame.

```csharp title="C#"
public Keyboard Keyboard { get; }
```

### Mouse

Global mouse object used by SadConsole during the update frame.

```csharp title="C#"
public Mouse Mouse { get; }
```

### UpdateFrameDelta

The elapsed time between now and the last update call.

```csharp title="C#"
public TimeSpan UpdateFrameDelta { get; set; }
```

### DrawFrameDelta

The elapsed time between now and the last draw call.

```csharp title="C#"
public TimeSpan DrawFrameDelta { get; set; }
```

### GameRunningTotalTime

The total time the game has been running.

```csharp title="C#"
public TimeSpan GameRunningTotalTime { get; }
```

### StartingConsole

The console created by the game and automatically assigned to [Screen](../sadconsole.gamehost/#screen/).

```csharp title="C#"
public Console? StartingConsole { get; protected set; }
```

### Screen

The active screen processed by the game.

```csharp title="C#"
public IScreenObject? Screen { get; set; }
```

### RootComponents

Update components that run before the [Screen](../sadconsole.gamehost/#screen/) is processed.

```csharp title="C#"
public List<RootComponent> RootComponents { get; set; }
```

### FocusedScreenObjects

The stack of focused consoles used by the mouse and keyboard.

```csharp title="C#"
public FocusedScreenObjectStack FocusedScreenObjects { get; set; }
```

### Random

A global random number generator.

```csharp title="C#"
public Random Random { get; set; }
```

## Methods

### OnGameStarted()

Raises the [Started](../sadconsole.gamehost/#started/) event.

```csharp title="C#"
protected virtual void OnGameStarted()
```


### OnGameEnding()

Raises the [Ending](../sadconsole.gamehost/#ending/) event.

```csharp title="C#"
protected virtual void OnGameEnding()
```


### OnFrameRender()

Raises the [FrameRender](../sadconsole.gamehost/#framerender/) event.

```csharp title="C#"
protected virtual void OnFrameRender()
```


### OnFrameUpdate()

Raises the [FrameUpdate](../sadconsole.gamehost/#frameupdate/) event.

```csharp title="C#"
protected virtual void OnFrameUpdate()
```


### Run()

Runs the game.

```csharp title="C#"
public abstract void Run()
```


### GetTexture(string)

Gets a texture from the implemented host.

```csharp title="C#"
public abstract ITexture GetTexture(string resourcePath)
```

#### Parameters

`resourcePath` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The path to the texture to load.

#### Returns

[ITexture](../sadconsole.itexture/)  
The texture from the game host.

### GetTexture(Stream)

Gets a texture from the implemented host.

```csharp title="C#"
public abstract ITexture GetTexture(Stream textureStream)
```

#### Parameters

`textureStream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream/)  
A stream containing the texture.

#### Returns

[ITexture](../sadconsole.itexture/)  
The texture from the game host.

### CreateTexture(int, int)

Creates a texture.

```csharp title="C#"
public abstract ITexture CreateTexture(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the texture in pixels.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the texture in pixels.

#### Returns

[ITexture](../sadconsole.itexture/)  
The texture from the game host.

### GetRenderer(string)

Creates and returns an [IRenderer](../sadconsole.renderers.irenderer/) by name.

```csharp title="C#"
public virtual IRenderer? GetRenderer(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the renderer.

#### Returns

[IRenderer](../sadconsole.renderers.irenderer/)  
A new renderer.

### SetRenderer(string, Type)

Sets the default [IRenderer](../sadconsole.renderers.irenderer/) for a type.

```csharp title="C#"
public void SetRenderer(string name, Type rendererType)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to register the renderer as.

`rendererType` [Type](https://learn.microsoft.com/dotnet/api/system.type/)  
The renderer type.


### SetRendererStep(string, Type)

Sets the default [IRenderStep](../sadconsole.renderers.irenderstep/) for a type.

```csharp title="C#"
public void SetRendererStep(string name, Type rendererStepType)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to register the render step as.

`rendererStepType` [Type](https://learn.microsoft.com/dotnet/api/system.type/)  
The render step type.


### GetRendererStep(string)

Creates and returns a [IRenderStep](../sadconsole.renderers.irenderstep/) by name.

```csharp title="C#"
public virtual IRenderStep GetRendererStep(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the renderer.

#### Returns

[IRenderStep](../sadconsole.renderers.irenderstep/)  
A new renderer.

### GetKeyboardState()

Gets the state of the keyboard from the implemented host.

```csharp title="C#"
public abstract IKeyboardState GetKeyboardState()
```

#### Returns

[IKeyboardState](../sadconsole.input.ikeyboardstate/)  
The state of the keyboard.

### GetMouseState()

Gets the state of the mouse from the implemented host.

```csharp title="C#"
public abstract IMouseState GetMouseState()
```

#### Returns

[IMouseState](../sadconsole.input.imousestate/)  
The state of the mouse.

### GetDeviceScreenSize(out int, out int)

Gets the size of the current device's screen in pixels.

```csharp title="C#"
public abstract void GetDeviceScreenSize(out int width, out int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the screen.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the screen.


### SetSplashScreens(params IScreenSurface[])

The splash screens the game should sequentially show on startup.

```csharp title="C#"
public void SetSplashScreens(params IScreenSurface[] surfaces)
```

#### Parameters

`surfaces` [IScreenSurface[]](../sadconsole.iscreensurface/)  
The splash screens to show.


### LoadFont(string)

Loads a font from a file and adds it to the [Fonts](../sadconsole.gamehost/#fonts/) collection.

```csharp title="C#"
public IFont LoadFont(string font)
```

#### Parameters

`font` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The font file to load.

#### Returns

[IFont](../sadconsole.ifont/)  
A master font that you can generate a usable font from.

### DestroyDefaultStartingConsole()

Destroys the [StartingConsole](../sadconsole.gamehost/#startingconsole/) instance.

```csharp title="C#"
public void DestroyDefaultStartingConsole()
```

#### Remarks

Prior to calling this method, you must set [Screen](../sadconsole.gamehost/#screen/) to an object other than [StartingConsole](../sadconsole.gamehost/#startingconsole/).

### OpenStream(string, FileMode, FileAccess)

Opens a file stream with the specified mode and access.

```csharp title="C#"
public virtual Stream OpenStream(string file, FileMode mode = FileMode.Open, FileAccess access = FileAccess.Read)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to open.

`mode` [FileMode](https://learn.microsoft.com/dotnet/api/system.io.filemode/)  
The mode for opening. Defaults to <xref href="System.IO.FileMode.Open" data-throw-if-not-resolved="false"></xref>.

`access` [FileAccess](https://learn.microsoft.com/dotnet/api/system.io.fileaccess/)  
The type of access for the stream. Defaults to <xref href="System.IO.FileAccess.Read" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Stream](https://learn.microsoft.com/dotnet/api/system.io.stream/)  
The stream object.

### FileExists(string)

Checks if a file exists.

```csharp title="C#"
public virtual bool FileExists(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the file exists; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### FileDelete(string)

Deletes a file.

```csharp title="C#"
public virtual bool FileDelete(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to delete.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the file was deleted; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### LoadDefaultFonts(string?)

Loads the embedded `IBM.font` files. Sets the [DefaultFont](../sadconsole.gamehost/#defaultfont/) property.

```csharp title="C#"
protected void LoadDefaultFonts(string? defaultFont)
```

#### Parameters

`defaultFont` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
An optional font to load and set as the default.

#### Remarks

If `defaultFont` is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, the [EmbeddedFont](../sadconsole.gamehost/#embeddedfont/) or [EmbeddedFontExtended](../sadconsole.gamehost/#embeddedfontextended/) font is set based on the value of [UseDefaultExtendedFont](../sadconsole.settings/#usedefaultextendedfont/).

### LoadMappedColors()

Uses reflection to examine the `SadRogue.Primitives.Color` type and add any predefined colors into [ColorMappings](../sadrogue.primitives.colorextensions2/#colormappings/).

```csharp title="C#"
protected static void LoadMappedColors()
```


### ResizeWindow(int, int, bool)

Resizes the window to the specified dimensions.

```csharp title="C#"
public abstract void ResizeWindow(int width, int height, bool resizeOutputSurface = false)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the window in pixels.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the window in pixels.

`resizeOutputSurface` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> resizes the screen output surface along with the window. Defaults to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>


### ResizeWindow(int, int, Point, bool)

Resizes the window to the specified cell count along the X-axis and Y-axis.

```csharp title="C#"
public void ResizeWindow(int cellsX, int cellsY, Point cellSize, bool resizeOutputSurface = false)
```

#### Parameters

`cellsX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to fit horizontally.

`cellsY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to fit vertically.

`cellSize` SadRogue.Primitives.Point  
The size of the cells in pixels.

`resizeOutputSurface` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> resizes the screen output surface along with the window. Defaults to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>


### SaveGlobalState()

Saves the global state, mainly the [FocusedScreenObjects](../sadconsole.gamehost/#focusedscreenobjects/) and [Screen](../sadconsole.gamehost/#screen/) objects.

```csharp title="C#"
public void SaveGlobalState()
```


### RestoreGlobalState()

Restores the global state that was saved with [SaveGlobalState()](../sadconsole.gamehost/#saveglobalstate/).

```csharp title="C#"
public void RestoreGlobalState()
```


### Dispose(bool)

```csharp title="C#"
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### ~GameHost()

Disposes this object.

```csharp title="C#"
protected ~GameHost()
```


### Dispose()

Disposes this object.

```csharp title="C#"
public void Dispose()
```


## Events

### FrameRender

Raised when the game draws a frame to the screen.

```csharp title="C#"
public event EventHandler<GameHost>? FrameRender
```

#### Event Type

[EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### FrameUpdate

Raised when the game updates prior to drawing a frame.

```csharp title="C#"
public event EventHandler<GameHost>? FrameUpdate
```

#### Event Type

[EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### Started

A callback to run before the [Run()](../sadconsole.gamehost/#run/) method is called;

```csharp title="C#"
public event EventHandler<GameHost>? Started
```

#### Event Type

[EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### Ending

A callback to run after the [Run()](../sadconsole.gamehost/#run/) method is called;

```csharp title="C#"
public event EventHandler<GameHost>? Ending
```

#### Event Type

[EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)