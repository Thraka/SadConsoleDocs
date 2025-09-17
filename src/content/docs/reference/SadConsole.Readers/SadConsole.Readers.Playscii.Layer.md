---
title: Playscii.Layer Struct
slug: reference/sadconsole.readers.playscii.layer
sidebar:
  label: Playscii.Layer
---
## Definition

Json layer in the [Playscii](../sadconsole.readers.playscii/) file.

```csharp title="C#"
public struct Playscii.Layer
```


## Fields

### name

Layer name.

```csharp title="C#"
public string name
```

### tiles

[Playscii](../sadconsole.readers.playscii/) tiles that will be converted to [ColoredGlyphBase](../sadconsole.coloredglyphbase/).

```csharp title="C#"
public Playscii.Tile[] tiles
```

### visible

Visibility of this layer.

```csharp title="C#"
public bool visible
```

## Methods

### ToSurface(ScreenSurface, Palette)

Converts the [Playscii](../sadconsole.readers.playscii/) layer to a SadConsole [ScreenSurface](../sadconsole.screensurface/).

```csharp title="C#"
public ScreenSurface ToSurface(ScreenSurface parent, Palette colors)
```

#### Parameters

`parent` [ScreenSurface](../sadconsole.screensurface/)  
<xref href="SadConsole.ScreenSurface" data-throw-if-not-resolved="false"></xref> that represents Playscii frame holding this layer.

`colors` SadRogue.Primitives.Palette  
<xref href="SadRogue.Primitives.Palette" data-throw-if-not-resolved="false"></xref> of colors converted from the <xref href="SadConsole.Readers.Playscii" data-throw-if-not-resolved="false"></xref> format.

#### Returns

[ScreenSurface](../sadconsole.screensurface/)  
[ScreenSurface](../sadconsole.screensurface/) containg the given [Playscii](../sadconsole.readers.playscii/) layer.