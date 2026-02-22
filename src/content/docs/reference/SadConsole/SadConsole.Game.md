---
title: Game Class
slug: reference/sadconsole.game
sidebar:
  label: Game
editUrl: false
description: The MonoGame implementation of the SadConsole Game Host.
---
## Definition

The MonoGame implementation of the SadConsole Game Host.

```csharp title="C#"
public sealed class Game : GameHost, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [GameHost](../sadconsole.gamehost/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Properties

### UseTitleContainer

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, forces the [OpenStream(string, FileMode, FileAccess)](../sadconsole.game/#openstreamstring-filemode-fileaccess) method to use <pre>`TitleContainer`</pre> when creating a stream to read a file.

```csharp title="C#"
public bool UseTitleContainer { get; set; }
```

### MonoGameInstance

The ``Microsoft.Xna.Framework.Game`` instance.

```csharp title="C#"
public Game MonoGameInstance { get; set; }
```

### Instance

Strongly typed version of ``SadConsole.GameHost.Instance``.

```csharp title="C#"
public static Game Instance { get; set; }
```

## Methods

### Create()

Creates a new game with an 80x25 console that uses the default SadConsole IBM font.

```csharp title="C#"
public static void Create()
```


### Create(int, int)

Creates a new game with an initialization callback and a console set to the specific cell count that uses the default SadConsole IBM font.

```csharp title="C#"
public static void Create(int cellCountX, int cellCountY)
```

#### Parameters

`cellCountX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the screen, in cells.

`cellCountY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the screen, in cells.


### Create(int, int, EventHandler\<GameHost>)

Creates a new game with an initialization callback and a console set to the specific cell count that uses the specified font.

```csharp title="C#"
public static void Create(int cellCountX, int cellCountY, EventHandler<GameHost> gameStarted)
```

#### Parameters

`cellCountX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the screen, in cells.

`cellCountY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the screen, in cells.

`gameStarted` [EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)  
An event handler to be invoked when the game starts.


### Create(int, int, string, EventHandler\<GameHost>)

Creates a new game with the specific screen size, and an initialization callback. Loads the specified font as the default.

```csharp title="C#"
public static void Create(int cellCountX, int cellCountY, string font, EventHandler<GameHost> gameStarted)
```

#### Parameters

`cellCountX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the screen, in cells.

`cellCountY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the screen, in cells.

`font` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The font file to load.

`gameStarted` [EventHandler\<GameHost\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)  
An event handler to be invoked when the game starts.


### Create(Builder)

Creates a new game and assigns it to the [MonoGameInstance](../sadconsole.game/#monogameinstance) property.

```csharp title="C#"
public static void Create(Builder configuration)
```

#### Parameters

`configuration` [Builder](../sadconsole.configuration.builder/)  
The settings used in creating the game.


### Tick()

```csharp title="C#"
public void Tick()
```


### Run()

Runs the game.

```csharp title="C#"
public override void Run()
```


### GetTexture(string)

Gets a texture from the implemented host.

```csharp title="C#"
public override ITexture GetTexture(string resourcePath)
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
public override ITexture GetTexture(Stream textureStream)
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
public override ITexture CreateTexture(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the texture in pixels.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the texture in pixels.

#### Returns

[ITexture](../sadconsole.itexture/)  
The texture from the game host.

### GetKeyboardState()

Gets the state of the keyboard from the implemented host.

```csharp title="C#"
public override IKeyboardState GetKeyboardState()
```

#### Returns

[IKeyboardState](../sadconsole.input.ikeyboardstate/)  
The state of the keyboard.

### GetMouseState()

Gets the state of the mouse from the implemented host.

```csharp title="C#"
public override IMouseState GetMouseState()
```

#### Returns

[IMouseState](../sadconsole.input.imousestate/)  
The state of the mouse.

### GetDeviceScreenSize(out int, out int)

Gets the size of the current device's screen in pixels.

```csharp title="C#"
public override void GetDeviceScreenSize(out int width, out int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the screen.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the screen.


### OpenStream(string, FileMode, FileAccess)

Opens a read-only stream with MonoGame.

```csharp title="C#"
public override Stream OpenStream(string file, FileMode mode = FileMode.Open, FileAccess access = FileAccess.Read)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to open.

`mode` [FileMode](https://learn.microsoft.com/dotnet/api/system.io.filemode/)  
Unused by monogame.

`access` [FileAccess](https://learn.microsoft.com/dotnet/api/system.io.fileaccess/)  
Unused by monogame.

#### Returns

[Stream](https://learn.microsoft.com/dotnet/api/system.io.stream/)  
The stream.

### ToggleFullScreen()

Toggles between windowed and full screen rendering for SadConsole.

```csharp title="C#"
public void ToggleFullScreen()
```


### ResizeWindow(int, int, bool)

Resizes the window to the specified dimensions.

```csharp title="C#"
public override void ResizeWindow(int width, int height, bool resizeOutputSurface = false)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the window in pixels.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the window in pixels.

`resizeOutputSurface` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> resizes the screen output surface along with the window. Defaults to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>