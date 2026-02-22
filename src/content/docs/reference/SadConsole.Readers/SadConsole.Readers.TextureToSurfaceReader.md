---
title: TextureToSurfaceReader Class
slug: reference/sadconsole.readers.texturetosurfacereader
sidebar:
  label: TextureToSurfaceReader
editUrl: false
description: Reads a texture to a cached surface. Used for animation.
---
## Definition

Reads a texture to a cached surface. Used for animation.

```csharp title="C#"
public class TextureToSurfaceReader
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### TextureToSurfaceReader(int, int, IFont, Point)

Creates a new instance of the class.

```csharp title="C#"
public TextureToSurfaceReader(int pixelWidth, int pixelHeight, IFont font, Point fontSize)
```

#### Parameters

`pixelWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width the source texture.

`pixelHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the source texture.

`font` [IFont](../sadconsole.ifont/)  
Font used for rendering.

`fontSize` SadRogue.Primitives.Point  
Size of the font.


## Properties

### UseBlockMode

Renders the cells as blocks instead of characters.

```csharp title="C#"
public bool UseBlockMode { get; set; }
```

## Methods

### GetSurface(Texture2D)

Returns a surface with the specified image rendered to it as characters.

```csharp title="C#"
public Console GetSurface(Texture2D image)
```

#### Parameters

`image` Microsoft.Xna.Framework.Graphics.Texture2D  
The image to render.

#### Returns

[Console](../sadconsole.console/)  
The surface.