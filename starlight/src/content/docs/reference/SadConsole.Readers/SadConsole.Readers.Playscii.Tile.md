---
title: Playscii.Tile Struct
slug: reference/sadconsole.readers.playscii.tile
sidebar:
  label: Playscii.Tile
---
## Definition

Json tile in the [Playscii](../sadconsole.readers.playscii/) file.

```csharp title="C#"
public struct Playscii.Tile
```


## Fields

### bg

Tile background color.

```csharp title="C#"
public int bg
```

### glyph

Tile character index.

```csharp title="C#"
[JsonProperty("char")]
public int glyph
```

### fg

Tile foreground color.

```csharp title="C#"
public int fg
```

### xform

Tile rotation and mirror.

```csharp title="C#"
public byte xform
```

## Methods

### ToColoredGlyph(IFont, Palette)

Converts the [Playscii](../sadconsole.readers.playscii/) tile to a SadConsole [ColoredGlyphBase](../sadconsole.coloredglyphbase/).

```csharp title="C#"
public ColoredGlyphBase ToColoredGlyph(IFont font, Palette colors)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
<xref href="SadConsole.IFont" data-throw-if-not-resolved="false"></xref> to be used when creating the <xref href="SadConsole.ScreenSurface" data-throw-if-not-resolved="false"></xref>.

`colors` SadRogue.Primitives.Palette  
<xref href="SadRogue.Primitives.Palette" data-throw-if-not-resolved="false"></xref> of colors converted from the <xref href="SadConsole.Readers.Playscii" data-throw-if-not-resolved="false"></xref> format.

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
[ColoredGlyphBase](../sadconsole.coloredglyphbase/) equivalent of the [Playscii](../sadconsole.readers.playscii/) tile.