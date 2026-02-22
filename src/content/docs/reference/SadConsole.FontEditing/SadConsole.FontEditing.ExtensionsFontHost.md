---
title: ExtensionsFontHost Class
slug: reference/sadconsole.fontediting.extensionsfonthost
sidebar:
  label: ExtensionsFontHost
editUrl: false
description: Extension methods to handle editing `SadConsole.SadFont` objects.
---
## Definition

Extension methods to handle editing [SadFont](../sadconsole.sadfont/) objects.

```csharp title="C#"
public static class ExtensionsFontHost
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### Edit_EnableEditing(IFont)

Converts the font's backing texture into a render target, if it isn't one.

```csharp title="C#"
public static void Edit_EnableEditing(this IFont font)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.


### Edit_DisableEditing(IFont)

Converts the font's backing texture from a render target to a normal texture.

```csharp title="C#"
public static void Edit_DisableEditing(this IFont font)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.


### Edit_AddRows(SadFont, int)

Adds the specified number of rows to the font. Creates a new backing texture object that is a render target. Is hardware accelerated.

```csharp title="C#"
public static void Edit_AddRows(this SadFont font, int count)
```

#### Parameters

`font` [SadFont](../sadconsole.sadfont/)  
The font being edited.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of rows.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
Thrown when the number is zero or less.


### Edit_CopyGlyph_GPU(IFont, IFont, int, int)

Copies a glyph from one font index to another. Is hardware accelerated.

```csharp title="C#"
public static void Edit_CopyGlyph_GPU(this IFont font, IFont source, int glyphIndexFrom, int glyphIndexTo)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.

`source` [IFont](../sadconsole.ifont/)  
The font that contains the source texture.

`glyphIndexFrom` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The source glyph index.

`glyphIndexTo` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The target glyph index.


### Edit_CopyGlyph_GPU(IFont, IFont, int, int, Color)

Copies a glyph from one font index to another. Is hardware accelerated.

```csharp title="C#"
public static void Edit_CopyGlyph_GPU(this IFont font, IFont source, int glyphIndexFrom, int glyphIndexTo, Color blendColor)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.

`source` [IFont](../sadconsole.ifont/)  
The font that contains the source texture.

`glyphIndexFrom` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The source glyph index.

`glyphIndexTo` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The target glyph index.

`blendColor` Microsoft.Xna.Framework.Color  
Color to apply while copying the glyph.


### Edit_CopyGlyph_GPU(IFont, IFont, Rectangle, Rectangle)

Copies a glyph from one font index to another.  Is hardware accelerated.

```csharp title="C#"
public static void Edit_CopyGlyph_GPU(this IFont font, IFont source, Rectangle glyphRectangleFrom, Rectangle glyphRectangleTo)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.

`source` [IFont](../sadconsole.ifont/)  
The font that contains the source texture.

`glyphRectangleFrom` Microsoft.Xna.Framework.Rectangle  
The source glyph rectangle.

`glyphRectangleTo` Microsoft.Xna.Framework.Rectangle  
The target glyph rectangle.


### Edit_CopyGlyph_GPU(IFont, IFont, Rectangle, Rectangle, Color)

Copies a glyph from one font index to another. Is hardware accelerated.

```csharp title="C#"
public static void Edit_CopyGlyph_GPU(this IFont font, IFont source, Rectangle glyphRectangleFrom, Rectangle glyphRectangleTo, Color blendColor)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.

`source` [IFont](../sadconsole.ifont/)  
The font that contains the source texture.

`glyphRectangleFrom` Microsoft.Xna.Framework.Rectangle  
The source glyph rectangle.

`glyphRectangleTo` Microsoft.Xna.Framework.Rectangle  
The target glyph rectangle.

`blendColor` Microsoft.Xna.Framework.Color  
Color to apply while copying the glyph.


### Edit_EraseGlyph_CPU(IFont, int, bool, ref Color[])

Erases a glyph in the font by index.

```csharp title="C#"
public static void Edit_EraseGlyph_CPU(this IFont font, int glyphIndex, bool doSetPixels, ref Color[] cachedFontTexturePixels)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.

`glyphIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index to erase.

`doSetPixels` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, pushes the updated pixel buffer, `cachedFontTexturePixels`, to the font texture.

`cachedFontTexturePixels` SadRogue.Primitives.Color[]  
A cached array of all the font's texture pixels.


### Edit_SetGlyph_CPU(IFont, int, Color[], bool, ref Color[])

Sets the pixels of a font glyph by index.

```csharp title="C#"
public static void Edit_SetGlyph_CPU(this IFont font, int glyphIndex, Color[] pixels, bool doSetPixels, ref Color[] cachedFontTexturePixels)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.

`glyphIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the glyph to update.

`pixels` SadRogue.Primitives.Color[]  
The pixels to set on the glyph.

`doSetPixels` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, pushes the updated pixel buffer, `cachedFontTexturePixels`, to the font texture.

`cachedFontTexturePixels` SadRogue.Primitives.Color[]  
A cached array of all the font's texture pixels.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
The `pixels` count doesn't match the size of a font glyph.


### Edit_GetGlyph_CPU(IFont, int, ref Color[])

Returns a glyph's pixels packaged into a ``SadRogue.Primitives.Color`` array.

```csharp title="C#"
public static Color[] Edit_GetGlyph_CPU(this IFont font, int glyphIndex, ref Color[] cachedFontTexturePixels)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font being edited.

`glyphIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the glyph to get.

`cachedFontTexturePixels` SadRogue.Primitives.Color[]  
A cached array of all the font's texture pixels.

#### Returns

SadRogue.Primitives.Color[]  
The pixels of the glyph.
#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)