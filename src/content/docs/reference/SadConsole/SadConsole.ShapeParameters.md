---
title: ShapeParameters Class
slug: reference/sadconsole.shapeparameters
sidebar:
  label: ShapeParameters
---
## Definition

Defines the parameters for generating a shape with a border and fill glyphs.

```csharp title="C#"
public class ShapeParameters
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ShapeParameters(bool, ColoredGlyphBase?, bool, bool, bool, bool, bool, ColoredGlyphBase?, bool, bool, bool, bool, int[]?, ColoredGlyphBase[]?)

A set of parameters that defines how a shape should be drawn.

```csharp title="C#"
public ShapeParameters(bool hasBorder, ColoredGlyphBase? borderGlyph, bool ignoreBorderForeground, bool ignoreBorderBackground, bool ignoreBorderGlyph, bool ignoreBorderMirror, bool hasFill, ColoredGlyphBase? fillGlyph, bool ignoreFillForeground, bool ignoreFillBackground, bool ignoreFillGlyph, bool ignoreFillMirror, int[]? boxBorderStyle, ColoredGlyphBase[]? boxBorderStyleGlyphs)
```

#### Parameters

`hasBorder` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, indicates the shape has a border.

`borderGlyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
When not null, uses a single glyph to draw the border.

`ignoreBorderForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the border foreground color.

`ignoreBorderBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the border background color.

`ignoreBorderGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the border glyph.

`ignoreBorderMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the border mirror.

`hasFill` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, indicates this shape is filled.

`fillGlyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
When not null, this is the appearance of the fill.

`ignoreFillForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the fill foreground color.

`ignoreFillBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the fill background color.

`ignoreFillGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the fill glyph.

`ignoreFillMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the fill mirror.

`boxBorderStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
When not null, the connected lines used for the border.

`boxBorderStyleGlyphs` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
When not null, the appearances used for each part of the connected line.


## Properties

### HasBorder

When true, to indicate the shape contains a border.

```csharp title="C#"
public bool HasBorder { get; set; }
```

### HasFill

When true, indicates this shape is filled.

```csharp title="C#"
public bool HasFill { get; set; }
```

### IgnoreFillForeground

When true, ignores the fill foreground color.

```csharp title="C#"
public bool IgnoreFillForeground { get; set; }
```

### IgnoreFillBackground

When true, ignores the fill background color.

```csharp title="C#"
public bool IgnoreFillBackground { get; set; }
```

### IgnoreFillGlyph

When true, ignores the fill glyph.

```csharp title="C#"
public bool IgnoreFillGlyph { get; set; }
```

### IgnoreFillMirror

When true, ignores the fill mirror.

```csharp title="C#"
public bool IgnoreFillMirror { get; set; }
```

### IgnoreBorderForeground

When true, ignores the border foreground color.

```csharp title="C#"
public bool IgnoreBorderForeground { get; set; }
```

### IgnoreBorderBackground

When true, ignores the border background color.

```csharp title="C#"
public bool IgnoreBorderBackground { get; set; }
```

### IgnoreBorderGlyph

When true, ignores the border glyph.

```csharp title="C#"
public bool IgnoreBorderGlyph { get; set; }
```

### IgnoreBorderMirror

When true, ignores the border mirror.

```csharp title="C#"
public bool IgnoreBorderMirror { get; set; }
```

### FillGlyph

The fill appearance.

```csharp title="C#"
public ColoredGlyphBase? FillGlyph { get; set; }
```

### BoxBorderStyle

The connected lines used for the border.

```csharp title="C#"
public int[]? BoxBorderStyle { get; set; }
```

### BoxBorderStyleGlyphs

The appearances used for each part of the connected line.

```csharp title="C#"
public ColoredGlyphBase[]? BoxBorderStyleGlyphs { get; set; }
```

### BorderGlyph

A single glyph used for drawing the border.

```csharp title="C#"
public ColoredGlyphBase? BorderGlyph { get; set; }
```

## Methods

### CreateBorder(ColoredGlyphBase, bool, bool, bool, bool)

Creates a shape parameters object that describes a border.

```csharp title="C#"
public static ShapeParameters CreateBorder(ColoredGlyphBase borderStyle, bool ignoreForeground = false, bool ignoreBackground = false, bool ignoreGlyph = false, bool ignoreMirror = false)
```

#### Parameters

`borderStyle` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance of the border.

`ignoreForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">borderStyle</code> value.

`ignoreBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">borderStyle</code> value.

`ignoreGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the glyph of the <code class="paramref">borderStyle</code> value.

`ignoreMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">borderStyle</code> value.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.

### CreateFilled(ColoredGlyphBase?, ColoredGlyphBase, bool, bool, bool, bool, bool, bool, bool, bool)

Creates a shape parameters object that describes a filled object with an optional border.

```csharp title="C#"
public static ShapeParameters CreateFilled(ColoredGlyphBase? borderStyle, ColoredGlyphBase fillStyle, bool ignoreBorderForeground = false, bool ignoreBorderBackground = false, bool ignoreBorderGlyph = false, bool ignoreBorderMirror = false, bool ignoreFillForeground = false, bool ignoreFillBackground = false, bool ignoreFillGlyph = false, bool ignoreFillMirror = false)
```

#### Parameters

`borderStyle` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
When not null, creates a border with this appearance.

`fillStyle` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The fill appearance.

`ignoreBorderForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">borderStyle</code> value.

`ignoreBorderBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">borderStyle</code> value.

`ignoreBorderGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the glyph of the <code class="paramref">borderStyle</code> value.

`ignoreBorderMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">borderStyle</code> value.

`ignoreFillForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">fillStyle</code> value.

`ignoreFillBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">fillStyle</code> value.

`ignoreFillGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the glyph of the <code class="paramref">fillStyle</code> value.

`ignoreFillMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">fillStyle</code> value.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.

### CreateStyledBox(int[], ColoredGlyphBase, bool, bool, bool)

Creates a shape parameters object that describes a border using a connected line glyph set.

```csharp title="C#"
public static ShapeParameters CreateStyledBox(int[] borderStyle, ColoredGlyphBase borderColors, bool ignoreBorderForeground = false, bool ignoreBorderBackground = false, bool ignoreBorderMirror = false)
```

#### Parameters

`borderStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
The connected line glyphs that make up the border.

`borderColors` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance colors of the border.

`ignoreBorderForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">borderColors</code> value.

`ignoreBorderBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">borderColors</code> value.

`ignoreBorderMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">borderColors</code> value.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.

### CreateStyledBoxFilled(int[], ColoredGlyphBase, ColoredGlyphBase, bool, bool, bool, bool, bool, bool, bool)

Creates a shape parameters object that describes a filled box using a connected line line glyph set for the border.

```csharp title="C#"
public static ShapeParameters CreateStyledBoxFilled(int[] borderStyle, ColoredGlyphBase borderColors, ColoredGlyphBase fillStyle, bool ignoreBorderForeground = false, bool ignoreBorderBackground = false, bool ignoreBorderMirror = false, bool ignoreFillForeground = false, bool ignoreFillBackground = false, bool ignoreFillGlyph = false, bool ignoreFillMirror = false)
```

#### Parameters

`borderStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
The connected line glyphs that make up the border.

`borderColors` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance colors of the border.

`fillStyle` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance colors of the fill.

`ignoreBorderForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">borderColors</code> value.

`ignoreBorderBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">borderColors</code> value.

`ignoreBorderMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">borderColors</code> value.

`ignoreFillForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">fillStyle</code> value.

`ignoreFillBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">fillStyle</code> value.

`ignoreFillGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the glyph of the <code class="paramref">fillStyle</code> value.

`ignoreFillMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">fillStyle</code> value.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.

### CreateStyledBoxExplicit(ColoredGlyphBase[], bool, bool, bool)

Creates a shape parameters object that describes an unfilled box using a connected line line glyph set for the border.

```csharp title="C#"
public static ShapeParameters CreateStyledBoxExplicit(ColoredGlyphBase[] borderGlyphs, bool ignoreBorderForeground = false, bool ignoreBorderBackground = false, bool ignoreBorderMirror = true)
```

#### Parameters

`borderGlyphs` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The appearances used for each part of a connected line, specifically the glyph.

`ignoreBorderForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">borderGlyphs</code> value.

`ignoreBorderBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">borderGlyphs</code> value.

`ignoreBorderMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">borderGlyphs</code> value.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.

### CreateStyledBoxExplicitFilled(ColoredGlyphBase[], ColoredGlyphBase, bool, bool, bool, bool, bool, bool, bool, bool)

Creates a shape parameters object that describes a filled box using a connected line line glyph set for the border.

```csharp title="C#"
public static ShapeParameters CreateStyledBoxExplicitFilled(ColoredGlyphBase[] borderGlyphs, ColoredGlyphBase fillStyle, bool ignoreBorderForeground = false, bool ignoreBorderBackground = false, bool ignoreBorderGlyph = false, bool ignoreBorderMirror = true, bool ignoreFillForeground = false, bool ignoreFillBackground = false, bool ignoreFillGlyph = false, bool ignoreFillMirror = false)
```

#### Parameters

`borderGlyphs` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The appearances used for each part of a connected line, specifically the glyph.

`fillStyle` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance colors of the fill.

`ignoreBorderForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">borderGlyphs</code> value.

`ignoreBorderBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">borderGlyphs</code> value.

`ignoreBorderGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the glyph of the <code class="paramref">borderGlyphs</code> value.

`ignoreBorderMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">borderGlyphs</code> value.

`ignoreFillForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the foreground of the <code class="paramref">fillStyle</code> value.

`ignoreFillBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the background of the <code class="paramref">fillStyle</code> value.

`ignoreFillGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the glyph of the <code class="paramref">fillStyle</code> value.

`ignoreFillMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, ignores the mirror of the <code class="paramref">fillStyle</code> value.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.

### CreateStyledBoxThin(Color)

Creates a box using the [ConnectedLineThin](../sadconsole.icellsurface/#connectedlinethin/) connected line style.

```csharp title="C#"
public static ShapeParameters CreateStyledBoxThin(Color foreground)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The foreground color of the box.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.

### CreateStyledBoxThick(Color)

Creates a box using the [ConnectedLineThick](../sadconsole.icellsurface/#connectedlinethick/) connected line style.

```csharp title="C#"
public static ShapeParameters CreateStyledBoxThick(Color foreground)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The foreground color of the box.

#### Returns

[ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters.