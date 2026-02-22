---
title: MonoGame_TextureExtensions Class
slug: reference/microsoft.xna.framework.graphics.monogame_textureextensions
sidebar:
  label: MonoGame_TextureExtensions
editUrl: false
description: Extensions for the `Microsoft.Xna.Framework.Graphics.Texture2D` type.
---
## Definition

Extensions for the ``Microsoft.Xna.Framework.Graphics.Texture2D`` type.

```csharp title="C#"
public static class MonoGame_TextureExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToSurface(Texture2D, IFont, Point, bool)

Converts a texture's pixels to a [ICellSurface](../sadconsole.icellsurface/).

```csharp title="C#"
public static ICellSurface ToSurface(this Texture2D image, IFont font, Point fontSize, bool blockMode = false)
```

#### Parameters

`image` Microsoft.Xna.Framework.Graphics.Texture2D  
The texture to process.

`font` [IFont](../sadconsole.ifont/)  
The font used with the cell surface.

`fontSize` SadRogue.Primitives.Point  
The size of the font.

`blockMode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate the result should use block characters instead of text characters.

#### Returns

[ICellSurface](../sadconsole.icellsurface/)

### ToSurface(Texture2D, ICellSurface, Color[], IFont, Point, bool)

Converts a texture's pixels to the specified [ICellSurface](../sadconsole.icellsurface/).

```csharp title="C#"
public static void ToSurface(this Texture2D image, ICellSurface surface, Color[] cachedColorArray, IFont font, Point fontSize, bool blockMode = false)
```

#### Parameters

`image` Microsoft.Xna.Framework.Graphics.Texture2D  
The texture to process.

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface to draw on.

`cachedColorArray` Microsoft.Xna.Framework.Color[]  
A buffer holding the color information from the texture.

`font` [IFont](../sadconsole.ifont/)  
The font used with the cell surface.

`fontSize` SadRogue.Primitives.Point  
The size of the font.

`blockMode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate the result should use block characters instead of text characters.


### Save(Texture2D, string)

Saves a texture to a png file.

```csharp title="C#"
public static void Save(this Texture2D target, string path)
```

#### Parameters

`target` Microsoft.Xna.Framework.Graphics.Texture2D  
The texture.

`path` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The path to a png file.