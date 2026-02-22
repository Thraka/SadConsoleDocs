---
title: TheDrawFont Class
slug: reference/sadconsole.readers.thedrawfont
sidebar:
  label: TheDrawFont
editUrl: false
description: Represents a TheDraw ascii font. http://www.roysac.com/thedrawfonts-tdf.html
---
## Definition

Represents a TheDraw ascii font. http://www.roysac.com/thedrawfonts-tdf.html

```csharp title="C#"
public class TheDrawFont
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### TheDrawFont()

```csharp title="C#"
public TheDrawFont()
```


## Properties

### Title

The title of the font.

```csharp title="C#"
public string Title { get; set; }
```

### Type

The type of font.

```csharp title="C#"
public TheDrawFont.FontType Type { get; set; }
```

### LetterSpacing

The empty characters between letters when drawing.

```csharp title="C#"
public int LetterSpacing { get; set; }
```

### CharactersSupported

An array indexed by character code, indicating if a glyph character is supported by the font. Characters 33 to 126 are supported, starting at index 0.

```csharp title="C#"
public bool[] CharactersSupported { get; set; }
```

## Methods

### IsCharacterSupported(int)

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the specified character glyph is supported by this font; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsCharacterSupported(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A boolean value indicating whether or not the specified glyph is supported.

### GetCharacter(int)

Gets a character from this font by character code.

```csharp title="C#"
public TheDrawFont.Character GetCharacter(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The character to get.

#### Returns

[TheDrawFont.Character](../sadconsole.readers.thedrawfont/)  
The specified character.
#### Exceptions

[InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception/)  
The character glyph index is valid but isn't included in this font.

[IndexOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.indexoutofrangeexception/)  
The character glyph index isn't in range. It must be between 33 and 126.


### GetSurface(int)

Generates a surface from the specified glyph using a white foreground and black background for the individual glyphs of the character.

```csharp title="C#"
public CellSurface? GetSurface(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.

#### Returns

[CellSurface](../sadconsole.cellsurface/)  
A surface of just the glyph. Width and height of the surface is based on the TheDraw's font.

### GetSurface(int, Color, Color)

Generates a surface from the specified glyph using the specified foreground and background for the individual glyphs of the character.

```csharp title="C#"
public CellSurface? GetSurface(int glyph, Color alternateForeground, Color alternateBackground)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.

`alternateForeground` SadRogue.Primitives.Color  
Foreground color used to draw the glyph.

`alternateBackground` SadRogue.Primitives.Color  
Background color used to draw the glyph.

#### Returns

[CellSurface](../sadconsole.cellsurface/)  
A surface of just the glyph. Width and height of the surface is based on the TheDraw's font.

### ReadFonts(string)

Returns a collection of fonts from a TheDraw font file.

```csharp title="C#"
public static IEnumerable<TheDrawFont> ReadFonts(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to read.

#### Returns

[IEnumerable\<TheDrawFont\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
A collection of TheDraw fonts.