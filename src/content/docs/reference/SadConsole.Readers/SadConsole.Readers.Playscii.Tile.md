---
title: Playscii.Tile Struct
slug: reference/sadconsole.readers.playscii.tile
sidebar:
  label: Playscii.Tile
editUrl: false
description: Json tile in the `SadConsole.Readers.Playscii` file.
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
[IFont](../sadconsole.ifont/) to be used when creating the [ScreenSurface](../sadconsole.screensurface/).

`colors` SadRogue.Primitives.Palette  
``SadRogue.Primitives.Palette`` of colors converted from the [Playscii](../sadconsole.readers.playscii/) format.

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
[ColoredGlyphBase](../sadconsole.coloredglyphbase/) equivalent of the [Playscii](../sadconsole.readers.playscii/) tile.