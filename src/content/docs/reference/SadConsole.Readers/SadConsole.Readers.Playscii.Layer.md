---
title: Playscii.Layer Struct
slug: reference/sadconsole.readers.playscii.layer
sidebar:
  label: Playscii.Layer
editUrl: false
description: Json layer in the `SadConsole.Readers.Playscii` file.
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
[ScreenSurface](../sadconsole.screensurface/) that represents Playscii frame holding this layer.

`colors` SadRogue.Primitives.Palette  
``SadRogue.Primitives.Palette`` of colors converted from the [Playscii](../sadconsole.readers.playscii/) format.

#### Returns

[ScreenSurface](../sadconsole.screensurface/)  
[ScreenSurface](../sadconsole.screensurface/) containg the given [Playscii](../sadconsole.readers.playscii/) layer.