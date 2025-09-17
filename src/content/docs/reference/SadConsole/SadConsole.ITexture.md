---
title: ITexture Interface
slug: reference/sadconsole.itexture
sidebar:
  label: ITexture
---
## Definition

Represents a texture provided by a game host.

```csharp title="C#"
public interface ITexture : IDisposable
```


## Properties

### ResourcePath

The file path to the texture.

```csharp title="C#"
string ResourcePath { get; }
```

### Height

The height of the texture.

```csharp title="C#"
int Height { get; }
```

### Width

The width of the texture.

```csharp title="C#"
int Width { get; }
```

### Size

Size of the texture. Generally, the count of pixels.

```csharp title="C#"
int Size { get; }
```

## Methods

### GetPixels()

Gets an array of colors.

```csharp title="C#"
Color[] GetPixels()
```

#### Returns

SadRogue.Primitives.Color[]

### SetPixels(Color[])

Sets colors in the texture.

```csharp title="C#"
void SetPixels(Color[] colors)
```

#### Parameters

`colors` SadRogue.Primitives.Color[]  
The individual pixel colors to set.


### SetPixels(ReadOnlySpan<Color>)

Sets colors in the texture.

```csharp title="C#"
void SetPixels(ReadOnlySpan<Color> colors)
```

#### Parameters

`colors` [ReadOnlySpan\<Color\>](https://learn.microsoft.com/dotnet/api/system.readonlyspan-1/)  
The individual pixel colors to set.


### SetPixel(Point, Color)

Sets a specific pixel in the texture to a color by x,y coordinate.

```csharp title="C#"
void SetPixel(Point position, Color color)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position of the pixel to set.

`color` SadRogue.Primitives.Color  
The color to set.


### SetPixel(int, Color)

Sets a specific pixel in the texture to a color by index. Row-major ordered.

```csharp title="C#"
void SetPixel(int index, Color color)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`color` SadRogue.Primitives.Color  


### GetPixel(Point)

Gets a pixel in the texture by x,y coordinate.

```csharp title="C#"
Color GetPixel(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The x,y coordinate of the pixel.

#### Returns

SadRogue.Primitives.Color  
The color of the pixel.

### GetPixel(int)

Gets a pixel in the texture by index.

```csharp title="C#"
Color GetPixel(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the pixel.

#### Returns

SadRogue.Primitives.Color  
The color of the pixel.

### ToSurface(TextureConvertMode, int, int, TextureConvertBackgroundStyle, TextureConvertForegroundStyle, Color[]?, ICellSurface?)

Converts the texture into a cell surface based on the specified mode.

```csharp title="C#"
ICellSurface ToSurface(TextureConvertMode mode, int surfaceWidth, int surfaceHeight, TextureConvertBackgroundStyle backgroundStyle = TextureConvertBackgroundStyle.Pixel, TextureConvertForegroundStyle foregroundStyle = TextureConvertForegroundStyle.Block, Color[]? cachedColorArray = null, ICellSurface? cachedSurface = null)
```

#### Parameters

`mode` [TextureConvertMode](../sadconsole.textureconvertmode/)  
The mode used when converting the texture to a surface.

`surfaceWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many cells wide the returned surface is.

`surfaceHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many cells high the returned surface is.

`backgroundStyle` [TextureConvertBackgroundStyle](../sadconsole.textureconvertbackgroundstyle/)  
The style to use when <code class="paramref">mode</code> is <xref href="SadConsole.TextureConvertMode.Background" data-throw-if-not-resolved="false"></xref>.

`foregroundStyle` [TextureConvertForegroundStyle](../sadconsole.textureconvertforegroundstyle/)  
The style to use when <code class="paramref">mode</code> is <xref href="SadConsole.TextureConvertMode.Foreground" data-throw-if-not-resolved="false"></xref>.

`cachedColorArray` SadRogue.Primitives.Color[]  
When provided, this array is used for color data. It must match the texture's expected <xref href="SadConsole.ITexture.GetPixels" data-throw-if-not-resolved="false"></xref> bounds. Used with <code class="paramref">cachedColorArray</code>.

`cachedSurface` [ICellSurface](../sadconsole.icellsurface/)  
The cell surface to use instead of creating a new one. Used with <code class="paramref">cachedColorArray</code>.

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
A new surface.