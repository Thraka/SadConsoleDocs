---
title: IFont Interface
slug: reference/sadconsole.ifont
sidebar:
  label: IFont
editUrl: false
description: Represents a font used by the rendering engine.
---
## Definition

Represents a font used by the rendering engine.

```csharp title="C#"
public interface IFont : IDisposable
```


## Properties

### Name

The name of the font used when it is registered with the [Fonts](../sadconsole.gamehost/#fonts) collection.

```csharp title="C#"
string Name { get; }
```

### GlyphHeight

The height of each glyph in pixels.

```csharp title="C#"
int GlyphHeight { get; }
```

### GlyphWidth

The width of each glyph in pixels.

```csharp title="C#"
int GlyphWidth { get; }
```

### GlyphPadding

The amount of pixels between glyphs.

```csharp title="C#"
int GlyphPadding { get; set; }
```

### TotalGlyphs

Gets how many glyphs this font has.

```csharp title="C#"
int TotalGlyphs { get; }
```

### SolidGlyphIndex

Which glyph index is considered completely solid white. Used for shading.

```csharp title="C#"
int SolidGlyphIndex { get; set; }
```

### SolidGlyphRectangle

The rectangle to draw the solid glyph used for shading.

```csharp title="C#"
Rectangle SolidGlyphRectangle { get; }
```

### UnsupportedGlyphIndex

The glyph index to use when an unsupported glyph is used during rendering.

```csharp title="C#"
int UnsupportedGlyphIndex { get; set; }
```

### UnsupportedGlyphRectangle

The rectangle to draw when a glyph that isn't supported is used by a surface.

```csharp title="C#"
Rectangle UnsupportedGlyphRectangle { get; }
```

### IsSadExtended

True when the font supports SadConsole extended decorators; otherwise false.

```csharp title="C#"
bool IsSadExtended { get; set; }
```

### Image

The texture used by the font.

```csharp title="C#"
ITexture Image { get; set; }
```

### GlyphRectangles

A dictionary that stores the source rectangles of the font by glyph id.

```csharp title="C#"
Dictionary<int, Rectangle> GlyphRectangles { get; }
```

### GlyphDefinitions

A collection of named glyph definitions.

```csharp title="C#"
Dictionary<string, GlyphDefinition> GlyphDefinitions { get; }
```

## Methods

### GetGlyphSourceRectangle(int)

Gets the registered rendering rectangle for a glyph.

```csharp title="C#"
Rectangle GetGlyphSourceRectangle(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the glyph to get.

#### Returns

SadRogue.Primitives.Rectangle  
The rectangle for the glyph.

### GenerateGlyphSourceRectangle(int)

Generates a rectangle for the specified glyph. For the actual font rectangle, use [GetGlyphSourceRectangle(int)](../sadconsole.ifont/#getglyphsourcerectangleint).

```csharp title="C#"
Rectangle GenerateGlyphSourceRectangle(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph.

#### Returns

SadRogue.Primitives.Rectangle  
A rectangle based on where the font thinks the rectangle should be.

### GetFontSize(Sizes)

Gets the pixel size of a font based on a [IFont.Sizes](../sadconsole.ifont.sizes/).

```csharp title="C#"
Point GetFontSize(IFont.Sizes size)
```

#### Parameters

`size` [IFont.Sizes](../sadconsole.ifont/)  
The desired size.

#### Returns

SadRogue.Primitives.Point  
The width and height of a font cell.

### GetDecorator(string, Color)

Gets a [CellDecorator](../sadconsole.celldecorator/) by the [GlyphDefinition](../sadconsole.glyphdefinition/) defined by the font file.

```csharp title="C#"
CellDecorator GetDecorator(string name, Color color)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the decorator to get.

`color` SadRogue.Primitives.Color  
The color to apply to the decorator.

#### Returns

[CellDecorator](../sadconsole.celldecorator/)  
The decorator instance.
#### Remarks

If the decorator does not exist, [Empty](../sadconsole.celldecorator/#empty) is returned.

### HasGlyphDefinition(string)

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the glyph has been defined by name.

```csharp title="C#"
bool HasGlyphDefinition(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the glyph

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the glyph name exists, otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### GetGlyphDefinition(string)

Gets a [GlyphDefinition](../sadconsole.glyphdefinition/) by name that is defined by the font file.

```csharp title="C#"
GlyphDefinition GetGlyphDefinition(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the glyph definition.

#### Returns

[GlyphDefinition](../sadconsole.glyphdefinition/)  
The glyph definition.
#### Remarks

If the glyph definition doesn't exist, return s[Empty](../sadconsole.glyphdefinition/#empty).