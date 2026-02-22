---
title: SadFont Class
slug: reference/sadconsole.sadfont
sidebar:
  label: SadFont
editUrl: false
description: Represents a graphical font used by SadConsole.
---
## Definition

Represents a graphical font used by SadConsole.

```csharp title="C#"
[DataContract]
public sealed class SadFont : IFont, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IFont](../sadconsole.ifont/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### SadFont(int, int, int, int, int, int, ITexture, string, Dictionary\<int, Rectangle>?)

Creates a new font with the specified settings.

```csharp title="C#"
public SadFont(int glyphWidth, int glyphHeight, int glyphPadding, int rows, int columns, int solidGlyphIndex, ITexture image, string name, Dictionary<int, Rectangle>? glyphRectangles = null)
```

#### Parameters

`glyphWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The pixel width of each glyph.

`glyphHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The pixel height of each glyph.

`glyphPadding` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The pixel padding between each glyph.

`rows` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Number of glyph rows in the `image`.

`columns` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Number of glyph columns in the `image`.

`solidGlyphIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the glyph that is a solid white box.

`image` [ITexture](../sadconsole.itexture/)  
The [ITexture](../sadconsole.itexture/) of the font.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A font identifier used for serialization of resources using this font.

`glyphRectangles` [Dictionary\<int, Rectangle\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2/)  
Glyph mapping dictionary.


## Properties

### SolidGlyphIndex

Which glyph index is considered completely solid white. Used for shading.

```csharp title="C#"
[DataMember]
public int SolidGlyphIndex { get; set; }
```

### SolidGlyphRectangle

The rectangle associated with the [SolidGlyphIndex](../sadconsole.sadfont/#solidglyphindex).

```csharp title="C#"
public Rectangle SolidGlyphRectangle { get; }
```

### Columns

```csharp title="C#"
[DataMember]
public int Columns { get; set; }
```

### Rows

```csharp title="C#"
[DataMember]
public int Rows { get; set; }
```

### TotalGlyphs

Gets the total glyphs in this font, which represents the last index. Calculated from [Columns](../sadconsole.sadfont/#columns) times [Rows](../sadconsole.sadfont/#rows).

```csharp title="C#"
public int TotalGlyphs { get; }
```

### Name

The name of the font used when it is registered with the [Fonts](../sadconsole.gamehost/#fonts) collection.

```csharp title="C#"
[DataMember]
public string Name { get; set; }
```

### FilePath

The name of the image file as defined in the .font file.

```csharp title="C#"
[DataMember]
public string FilePath { get; set; }
```

### GlyphHeight

The height of each glyph in pixels.

```csharp title="C#"
[DataMember]
public int GlyphHeight { get; set; }
```

### GlyphWidth

The width of each glyph in pixels.

```csharp title="C#"
[DataMember]
public int GlyphWidth { get; set; }
```

### GlyphPadding

The amount of pixels between glyphs.

```csharp title="C#"
[DataMember]
public int GlyphPadding { get; set; }
```

### UnsupportedGlyphIndex

The glyph index to use when an unsupported glyph is used during rendering.

```csharp title="C#"
[DataMember]
public int UnsupportedGlyphIndex { get; set; }
```

### UnsupportedGlyphRectangle

The rectangle associated with the [UnsupportedGlyphIndex](../sadconsole.sadfont/#unsupportedglyphindex).

```csharp title="C#"
public Rectangle UnsupportedGlyphRectangle { get; }
```

### GlyphRectangles

A dictionary that stores the source rectangles of the font by glyph id.

```csharp title="C#"
public Dictionary<int, Rectangle> GlyphRectangles { get; set; }
```

### IsSadExtended

True when the font supports SadConsole extended decorators; otherwise false.

```csharp title="C#"
[DataMember]
public bool IsSadExtended { get; set; }
```

### Image

The texture used by the font.

```csharp title="C#"
public ITexture Image { get; set; }
```

### GlyphDefinitions

A collection of named glyph definitions.

```csharp title="C#"
[DataMember]
public Dictionary<string, GlyphDefinition> GlyphDefinitions { get; set; }
```

## Methods

### GetGlyphSourceRectangle(int)

Gets the rendering rectangle for a glyph.

```csharp title="C#"
public Rectangle GetGlyphSourceRectangle(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the glyph to get.

#### Returns

SadRogue.Primitives.Rectangle  
The rectangle for the glyph if it exists, otherwise returns [UnsupportedGlyphRectangle](../sadconsole.sadfont/#unsupportedglyphrectangle).

### GenerateGlyphSourceRectangle(int)

Generates a rectangle for the specified glyph based on the glyph index, [Rows](../sadconsole.sadfont/#rows), [Columns](../sadconsole.sadfont/#columns), and [GlyphPadding](../sadconsole.sadfont/#glyphpadding) values. For the actual font rectangle, use [GetGlyphSourceRectangle(int)](../sadconsole.sadfont/#getglyphsourcerectangleint).

```csharp title="C#"
public Rectangle GenerateGlyphSourceRectangle(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph.

#### Returns

SadRogue.Primitives.Rectangle  
A rectangle based on where the font thinks the rectangle should be.

### GetDecorator(string, Color)

Gets a [CellDecorator](../sadconsole.celldecorator/) by the [GlyphDefinition](../sadconsole.glyphdefinition/) defined by the font file.

```csharp title="C#"
public CellDecorator GetDecorator(string name, Color color)
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

### GetGlyphDefinition(string)

A safe way to get a [GlyphDefinition](../sadconsole.glyphdefinition/) by name that is defined by the font file.

```csharp title="C#"
public GlyphDefinition GetGlyphDefinition(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the glyph definition.

#### Returns

[GlyphDefinition](../sadconsole.glyphdefinition/)  
The glyph definition.
#### Remarks

If the glyph definition doesn't exist, return s[Empty](../sadconsole.glyphdefinition/#empty).

### HasGlyphDefinition(string)

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the glyph has been defined by name.

```csharp title="C#"
public bool HasGlyphDefinition(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the glyph

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the glyph name exists, otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### GetFontSize(Sizes)

Gets the pixel size of a font based on a [IFont.Sizes](../sadconsole.ifont.sizes/).

```csharp title="C#"
public Point GetFontSize(IFont.Sizes size)
```

#### Parameters

`size` [IFont.Sizes](../sadconsole.ifont/)  
The desired size.

#### Returns

SadRogue.Primitives.Point  
The width and height of a font cell.

### ConfigureRects()

Builds the [GlyphRectangles](../sadconsole.sadfont/#glyphrectangles) array based on the current font settings, if the [GlyphRectangles](../sadconsole.sadfont/#glyphrectangles) dictionary is empty.

```csharp title="C#"
public void ConfigureRects()
```


### ForceConfigureRects()

Builds the [GlyphRectangles](../sadconsole.sadfont/#glyphrectangles) array based on the current font settings.

```csharp title="C#"
public void ForceConfigureRects()
```


### Clone(string)

Clones this font.

```csharp title="C#"
public SadFont Clone(string newName)
```

#### Parameters

`newName` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to apply when creating the cloned font.

#### Returns

[SadFont](../sadconsole.sadfont/)  
Returns the cloned font.

### Dispose()

Disposes the [Image](../sadconsole.sadfont/#image) property.

```csharp title="C#"
public void Dispose()
```