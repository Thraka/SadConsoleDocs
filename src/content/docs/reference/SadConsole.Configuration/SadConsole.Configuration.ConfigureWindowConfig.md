---
title: ConfigureWindowConfig Class
slug: reference/sadconsole.configuration.configurewindowconfig
sidebar:
  label: ConfigureWindowConfig
editUrl: false
description: Holds the config state for the window.
---
## Definition

Holds the config state for the window.

```csharp title="C#"
public sealed class ConfigureWindowConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### ConfigureWindowConfig()

```csharp title="C#"
public ConfigureWindowConfig()
```


## Properties

### WindowWidthInPixels

The desired width of the game window in pixels.

```csharp title="C#"
public int WindowWidthInPixels { get; set; }
```

### WindowHeightInPixels

The desired height of the game window in pixels.

```csharp title="C#"
public int WindowHeightInPixels { get; set; }
```

### GameResolutionWidthInPixels

The rendering width of the game.

```csharp title="C#"
public int GameResolutionWidthInPixels { get; set; }
```

### GameResolutionHeightInPixels

The rendering height of the game.

```csharp title="C#"
public int GameResolutionHeightInPixels { get; set; }
```

### CellsX

The amount of cells that fit in the window along the x-axis.

```csharp title="C#"
public int CellsX { get; set; }
```

### CellsY

The amount of cells that fit in the window along the y-axis.

```csharp title="C#"
public int CellsY { get; set; }
```

### Fullscreen

When true, tells the game host to run in fullscreen mode.

```csharp title="C#"
public bool Fullscreen { get; set; }
```

### BorderlessWindowedFullscreen

When true, fullscreen mode uses a borderless window.

```csharp title="C#"
public bool BorderlessWindowedFullscreen { get; set; }
```

## Methods

### SetWindowSizeInPixels(int, int)

Sets the desired resolution of the SadConsole window in pixels. The output surface and initial cell counts are calculated based on the current font, and set to a value that allows the most cells to appear on screen.

```csharp title="C#"
public void SetWindowSizeInPixels(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the window.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the window.


### SetWindowSizeInCells(int, int, bool)

Sets the desired resolution of the SadConsole window in cells using the default font.

```csharp title="C#"
public void SetWindowSizeInCells(int width, int height, bool zoom)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How wide the window is in font cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How tall the window is in font cells.

`zoom` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, creates a larger window to automatically zoom the contents.

#### Remarks

The `width` and `height` values are used to generate the game window based on how large the font is. For example, if the font is 10x8, and you request window size of 20x20, a window is created with a width of 10 * 20 and a height of 8 * 20 in pixels, which is 200x160.  When `zoom` is set to true, the window will try to get as big as possible while keeping the SadConsole output crisp.

### GetDeviceScreenSize(out int, out int)

Gets the size of the device screen in pixels.

```csharp title="C#"
public void GetDeviceScreenSize(out int width, out int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### IsWindowSizeValid()

Validates that the window fits on the display.

```csharp title="C#"
public bool IsWindowSizeValid()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the [WindowWidthInPixels](../sadconsole.configuration.configurewindowconfig/#windowwidthinpixels) and [WindowHeightInPixels](../sadconsole.configuration.configurewindowconfig/#windowheightinpixels) are less than or equal to the screen size; otherwise, false.