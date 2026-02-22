---
title: GameTexture Class
slug: reference/sadconsole.host.gametexture
sidebar:
  label: GameTexture
editUrl: false
description: Creates a `Microsoft.Xna.Framework.Graphics.Texture2D`. Generally you request this from the `SadConsole.GameHost.GetTexture(System.String)` method.
---
## Definition

Creates a ``Microsoft.Xna.Framework.Graphics.Texture2D``. Generally you request this from the [GetTexture(string)](https://learn.microsoft.com/dotnet/api/system.string/) method.

```csharp title="C#"
public class GameTexture : ITexture, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [ITexture](../sadconsole.itexture/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### GameTexture(string)

Loads a ``Microsoft.Xna.Framework.Graphics.Texture2D`` from a file path.

```csharp title="C#"
public GameTexture(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### GameTexture(Stream)

Loads a ``Microsoft.Xna.Framework.Graphics.Texture2D`` from a stream.

```csharp title="C#"
public GameTexture(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream/)  
The stream containing the texture data.


### GameTexture(int, int)

Creates a new game texture with the specified width and height.

```csharp title="C#"
public GameTexture(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the texture in pixels.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the texture in pixels.


### GameTexture(int, int, Color[])

Creates a new game texture with the specified width, height, and pixels.

```csharp title="C#"
public GameTexture(int width, int height, Color[] pixels)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the texture in pixels.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the texture in pixels.

`pixels` SadRogue.Primitives.Color[]  
The pixels to create the texture from. The array must be `width` * `height`.


### GameTexture(Texture2D, bool)

Wraps an existing texture.

```csharp title="C#"
public GameTexture(Texture2D texture, bool handleDispose = false)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  
The texture being wrapped by this object.

`handleDispose` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, disposing this object will dispose the texture.


## Properties

### Texture

```csharp title="C#"
public Texture2D Texture { get; }
```

### ResourcePath

The file path to the texture.

```csharp title="C#"
public string ResourcePath { get; }
```

### Height

The height of the texture.

```csharp title="C#"
public int Height { get; }
```

### Width

The width of the texture.

```csharp title="C#"
public int Width { get; }
```

### Size

Size of the texture. Generally, the count of pixels.

```csharp title="C#"
public int Size { get; }
```

## Methods

### Dispose()

Disposes the underlaying texture object and releases reference to it.

```csharp title="C#"
public void Dispose()
```


### GetPixels()

Gets an array of colors. Row-major ordered.

```csharp title="C#"
public Color[] GetPixels()
```

#### Returns

SadRogue.Primitives.Color[]  
The pixels. Row-major ordered.

### GetPixelsMonoColor()

Gets an array of ``Microsoft.Xna.Framework.Color`` pixels.

```csharp title="C#"
public Color[] GetPixelsMonoColor()
```

#### Returns

Microsoft.Xna.Framework.Color[]  
An array of pixels. Row-major ordered.

### SetPixels(Color[])

Sets colors in the texture from an array of pixels. Row-major ordered.

```csharp title="C#"
public void SetPixels(Color[] pixels)
```

#### Parameters

`pixels` SadRogue.Primitives.Color[]  
The individual pixel colors to set. Row-major ordered.


### SetPixels(ReadOnlySpan\<Color>)

Sets colors in the texture from a span of pixels. Row-major ordered.

```csharp title="C#"
public void SetPixels(ReadOnlySpan<Color> pixels)
```

#### Parameters

`pixels` [ReadOnlySpan\<Color\>](https://learn.microsoft.com/dotnet/api/system.readonlyspan-1/)  
The individual pixel colors to set. Row-major ordered.


### SetPixels(Color[])

Replaces texture colors with the array of ``Microsoft.Xna.Framework.Color`` pixels.

```csharp title="C#"
public void SetPixels(Color[] pixels)
```

#### Parameters

`pixels` Microsoft.Xna.Framework.Color[]  
Array of ``Microsoft.Xna.Framework.Color`` pixels.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  


### SetPixel(Point, Color)

Sets a specific pixel in the texture to a color by x,y coordinate.

```csharp title="C#"
public void SetPixel(Point position, Color color)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position of the pixel to set.

`color` SadRogue.Primitives.Color  
The color to set.


### SetPixel(Point, Color)

Sets a single pixel in the texture to the specified ``Microsoft.Xna.Framework.Color`` at the given position.

```csharp title="C#"
public void SetPixel(Point position, Color color)
```

#### Parameters

`position` SadRogue.Primitives.Point  
Position of the pixel in the texture.

`color` Microsoft.Xna.Framework.Color  
Color of the pixel.


### SetPixel(int, Color)

Sets a specific pixel in the texture to a color by index. Row-major ordered.

```csharp title="C#"
public void SetPixel(int index, Color color)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`color` SadRogue.Primitives.Color  


### SetPixel(int, Color)

Sets a single pixel in the texture to the specified ``Microsoft.Xna.Framework.Color`` at the given index.

```csharp title="C#"
public void SetPixel(int index, Color color)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Index of the pixel.

`color` Microsoft.Xna.Framework.Color  
``Microsoft.Xna.Framework.Color`` of the pixel.


### GetPixel(Point)

Gets a pixel in the texture by x,y coordinate.

```csharp title="C#"
public Color GetPixel(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The x,y coordinate of the pixel.

#### Returns

SadRogue.Primitives.Color  
The color of the pixel.

### GetPixelMonoColor(Point)

Gets the ``Microsoft.Xna.Framework.Color`` at the given position in the texture.

```csharp title="C#"
public Color GetPixelMonoColor(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
Position in the texture.

#### Returns

Microsoft.Xna.Framework.Color  
``Microsoft.Xna.Framework.Color`` of the pixel.

### GetPixel(int)

Gets a pixel in the texture by index. Row-major ordered.

```csharp title="C#"
public Color GetPixel(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the pixel.

#### Returns

SadRogue.Primitives.Color  
The color of the pixel.

### GetPixelMonoColor(int)

Gets the ``Microsoft.Xna.Framework.Color`` at the given index in the texture.

```csharp title="C#"
public Color GetPixelMonoColor(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Index of the pixel in the texture.

#### Returns

Microsoft.Xna.Framework.Color  
``Microsoft.Xna.Framework.Color`` of the pixel.

### ToSurface(TextureConvertMode, int, int, TextureConvertBackgroundStyle, TextureConvertForegroundStyle, Color[], ICellSurface)

Converts the texture into a cell surface based on the specified mode.

```csharp title="C#"
public ICellSurface ToSurface(TextureConvertMode mode, int surfaceWidth, int surfaceHeight, TextureConvertBackgroundStyle backgroundStyle = TextureConvertBackgroundStyle.Pixel, TextureConvertForegroundStyle foregroundStyle = TextureConvertForegroundStyle.Block, Color[] cachedColorArray = null, ICellSurface cachedSurface = null)
```

#### Parameters

`mode` [TextureConvertMode](../sadconsole.textureconvertmode/)  
The mode used when converting the texture to a surface.

`surfaceWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many cells wide the returned surface is.

`surfaceHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many cells high the returned surface is.

`backgroundStyle` [TextureConvertBackgroundStyle](../sadconsole.textureconvertbackgroundstyle/)  
The style to use when `mode` is [Background](../sadconsole.textureconvertmode/#background).

`foregroundStyle` [TextureConvertForegroundStyle](../sadconsole.textureconvertforegroundstyle/)  
The style to use when `mode` is [Foreground](../sadconsole.textureconvertmode/#foreground).

`cachedColorArray` SadRogue.Primitives.Color[]  
When provided, this array is used for color data. It must match the texture's expected [GetPixels()](../sadconsole.itexture/#getpixels) bounds. Used with `cachedColorArray`.

`cachedSurface` [ICellSurface](../sadconsole.icellsurface/)  
The cell surface to use instead of creating a new one. Used with `cachedColorArray`.

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
A new surface.