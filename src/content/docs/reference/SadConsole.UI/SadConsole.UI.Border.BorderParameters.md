---
title: Border.BorderParameters Struct
slug: reference/sadconsole.ui.border.borderparameters
sidebar:
  label: Border.BorderParameters
---
## Definition

The settings to use when creating a [Border](../sadconsole.ui.border/).

```csharp title="C#"
public struct Border.BorderParameters
```


## Constructors

### BorderParameters(bool, ShapeParameters?, string?, HorizontalAlignment, Color, Color, bool, bool, bool, int, Color, Color)

Creates a new instance of this class which contains the settings for drawing a border surface around an existing surface.

```csharp title="C#"
public BorderParameters(bool drawBorder, ShapeParameters? borderBox, string? title, HorizontalAlignment titleAlignment, Color titleForeground, Color titleBackground, bool drawShadedArea, bool useDefaultShadedGlyphs, bool useDefaultShadedColors, int shadedGlyph, Color shadedGlyphForeground, Color shadedGlyphBackground)
```

#### Parameters

`drawBorder` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the <code class="paramref">borderBox</code> should be used to draw a border.

`borderBox` [ShapeParameters](../sadconsole.shapeparameters/)  
The box drawn around the surface.

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The title to display on the border.

`titleAlignment` [HorizontalAlignment](../sadconsole.horizontalalignment/)  
The alignment of the <code class="paramref">title</code>.

`titleForeground` SadRogue.Primitives.Color  
The foreground color of the <code class="paramref">title</code>.

`titleBackground` SadRogue.Primitives.Color  
The background color of the <code class="paramref">title</code>.

`drawShadedArea` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the 3d shaded area of the border should be drawn.

`useDefaultShadedGlyphs` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the  other shaded properties should be ignored and the default shaded glyphs should be used.

`useDefaultShadedColors` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the other shaded properties should be ignored and the default shaded glyphs should be used.

`shadedGlyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to use in the shaded area.

`shadedGlyphForeground` SadRogue.Primitives.Color  
The forground of the <code class="paramref">shadedGlyph</code>.

`shadedGlyphBackground` SadRogue.Primitives.Color  
The background of the <code class="paramref">shadedGlyph</code>.


## Properties

### DrawBorder

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the [BorderBox](../sadconsole.ui.border.borderparameters/#borderbox/) should be used to draw a border.

```csharp title="C#"
public bool DrawBorder { readonly get; set; }
```

### BorderBox

The border box creation parameters.

```csharp title="C#"
public ShapeParameters? BorderBox { readonly get; set; }
```

### Title

The title to display on the border.

```csharp title="C#"
public string? Title { readonly get; set; }
```

### TitleForeground

The foreground color of the title.

```csharp title="C#"
public Color TitleForeground { readonly get; set; }
```

### TitleBackground

The background color of the title.

```csharp title="C#"
public Color TitleBackground { readonly get; set; }
```

### TitleAlignment

The alignment of the [Title](../sadconsole.ui.border.borderparameters/#title/).

```csharp title="C#"
public HorizontalAlignment TitleAlignment { readonly get; set; }
```

### DrawShadedArea

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the 3d shaded area of the border should be drawn.

```csharp title="C#"
public bool DrawShadedArea { readonly get; set; }
```

### UseDefaultShadedGlyphs

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the  other shaded properties should be ignored and the default shaded glyphs should be used.

```csharp title="C#"
public bool UseDefaultShadedGlyphs { readonly get; set; }
```

### UseDefaultShadedColors

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the other shaded properties should be ignored and the default shaded glyphs should be used.

```csharp title="C#"
public bool UseDefaultShadedColors { readonly get; set; }
```

### ShadedGlyph

The glyph to use in the shaded area.

```csharp title="C#"
public int ShadedGlyph { readonly get; set; }
```

### ShadedGlyphForeground

The forground of the [ShadedGlyph](../sadconsole.ui.border.borderparameters/#shadedglyph/).

```csharp title="C#"
public Color ShadedGlyphForeground { readonly get; set; }
```

### ShadedGlyphBackground

The background of the [ShadedGlyph](../sadconsole.ui.border.borderparameters/#shadedglyph/).

```csharp title="C#"
public Color ShadedGlyphBackground { readonly get; set; }
```

## Methods

### GetDefault()

Creates an instance of BorderParameters with the thin line as a border, no title and no shadow.

```csharp title="C#"
public static Border.BorderParameters GetDefault()
```

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)

### AddTitle(string)

Sets the Title parameter with the given text.

```csharp title="C#"
public Border.BorderParameters AddTitle(string title)
```

#### Parameters

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Title text.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### AddTitle(string, Color, Color, HorizontalAlignment)

Sets the Title parameter with the given text and changes title colors.

```csharp title="C#"
public Border.BorderParameters AddTitle(string title, Color foregroundColor, Color backgroundColor, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center)
```

#### Parameters

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Title text.

`foregroundColor` SadRogue.Primitives.Color  
Title foreground <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

`backgroundColor` SadRogue.Primitives.Color  
Title background <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

`horizontalAlignment` [HorizontalAlignment](../sadconsole.horizontalalignment/)  
Title text <xref href="SadConsole.HorizontalAlignment" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### AddShadow()

Sets the DrawShadedArea to true.

```csharp title="C#"
public Border.BorderParameters AddShadow()
```

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### AddShadow(int)

Sets the DrawShadedArea to true and modifies shadow glyph.

```csharp title="C#"
public Border.BorderParameters AddShadow(int shadedGlyph)
```

#### Parameters

`shadedGlyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Glyph number to use as a shadow.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### AddShadow(Color, Color)

Sets the DrawShadedArea to true and modifies default shadow colors.

```csharp title="C#"
public Border.BorderParameters AddShadow(Color foregroundColor, Color backgroundColor)
```

#### Parameters

`foregroundColor` SadRogue.Primitives.Color  
ShadedGlyph new foreground <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

`backgroundColor` SadRogue.Primitives.Color  
ShadedGlyph new background <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### AddShadow(int, Color, Color)

Sets the DrawShadedArea to true and modifies default shadow glyph and colors.

```csharp title="C#"
public Border.BorderParameters AddShadow(int shadedGlyph, Color foregroundColor, Color backgroundColor)
```

#### Parameters

`shadedGlyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Glyph number to use as a shadow.

`foregroundColor` SadRogue.Primitives.Color  
ShadedGlyph new foreground <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

`backgroundColor` SadRogue.Primitives.Color  
ShadedGlyph new background <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderStyle(ShapeParameters)

Set the BorderBox parameter to the new value.

```csharp title="C#"
public Border.BorderParameters ChangeBorderStyle(ShapeParameters borderStyle)
```

#### Parameters

`borderStyle` [ShapeParameters](../sadconsole.shapeparameters/)  
New <xref href="SadConsole.ShapeParameters" data-throw-if-not-resolved="false"></xref> to use for the border style.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderGlyph(int[])

Changes the array of glyphs to be used as the border line.

```csharp title="C#"
public Border.BorderParameters ChangeBorderGlyph(int[] borderStyle)
```

#### Parameters

`borderStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
Array of glyphs to be used as the border line.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderGlyph(int[], Color, Color)

Changes the array of glyphs to be used as the border line and their colors.

```csharp title="C#"
public Border.BorderParameters ChangeBorderGlyph(int[] borderStyle, Color foregroundColor, Color backgroundColor)
```

#### Parameters

`borderStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
Array of glyphs to be used as the border line.

`foregroundColor` SadRogue.Primitives.Color  
Border line foreground <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

`backgroundColor` SadRogue.Primitives.Color  
Border line background <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderGlyph(int)

Fills the array of glyphs to be used as the border line with the given glyph.

```csharp title="C#"
public Border.BorderParameters ChangeBorderGlyph(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to be used the border line.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderGlyph(int, Color, Color)

Fills the array of glyphs to be used as the border line with the given glyph and changes the border colors.

```csharp title="C#"
public Border.BorderParameters ChangeBorderGlyph(int glyph, Color foregroundColor, Color backgroundColor)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to be used the border line.

`foregroundColor` SadRogue.Primitives.Color  
Border line foreground <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

`backgroundColor` SadRogue.Primitives.Color  
Border line background <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderGlyph(ColoredGlyphBase)

Fills the array of glyphs to be used as the border line with the given [ColoredGlyphBase](../sadconsole.coloredglyphbase/).

```csharp title="C#"
public Border.BorderParameters ChangeBorderGlyph(ColoredGlyphBase glyph)
```

#### Parameters

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The <xref href="SadConsole.ColoredGlyphBase" data-throw-if-not-resolved="false"></xref> to be used the border line.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderColors(Color, Color)

Changes border color parameters.

```csharp title="C#"
public Border.BorderParameters ChangeBorderColors(Color foregroundColor, Color backgroundColor)
```

#### Parameters

`foregroundColor` SadRogue.Primitives.Color  
Border line foreground <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

`backgroundColor` SadRogue.Primitives.Color  
Border line background <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderForegroundColor(Color)

Changes border foreground color.

```csharp title="C#"
public Border.BorderParameters ChangeBorderForegroundColor(Color foregroundColor)
```

#### Parameters

`foregroundColor` SadRogue.Primitives.Color  
Border line foreground <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).

### ChangeBorderBackgroundColor(Color)

Changes border background color.

```csharp title="C#"
public Border.BorderParameters ChangeBorderBackgroundColor(Color backgroundColor)
```

#### Parameters

`backgroundColor` SadRogue.Primitives.Color  
Border line background <xref href="SadRogue.Primitives.Color" data-throw-if-not-resolved="false"></xref>.

#### Returns

[Border.BorderParameters](../sadconsole.ui.border/)  
The modified instance of [Border.BorderParameters](../sadconsole.ui.border/).