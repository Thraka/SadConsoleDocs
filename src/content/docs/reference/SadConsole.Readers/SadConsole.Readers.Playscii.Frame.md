---
title: Playscii.Frame Struct
slug: reference/sadconsole.readers.playscii.frame
sidebar:
  label: Playscii.Frame
editUrl: false
description: Json frame object in the `SadConsole.Readers.Playscii` file.
---
## Definition

Json frame object in the [Playscii](../sadconsole.readers.playscii/) file.

```csharp title="C#"
public struct Playscii.Frame
```


## Fields

### delay

Duration for this frame.

```csharp title="C#"
public float delay
```

### layers

[Playscii](../sadconsole.readers.playscii/) frame layers that will be converted to [ScreenSurface](../sadconsole.screensurface/).

```csharp title="C#"
public Playscii.Layer[] layers
```

## Methods

### ToScreenSurface(int, int, IFont, Palette)

Converts the [Playscii](../sadconsole.readers.playscii/) frame to SadConsole [ScreenSurface](../sadconsole.screensurface/).

```csharp title="C#"
public ScreenSurface ToScreenSurface(int width, int height, IFont font, Palette colors)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the [ScreenSurface](../sadconsole.screensurface/).

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the [ScreenSurface](../sadconsole.screensurface/).

`font` [IFont](../sadconsole.ifont/)  
[IFont](../sadconsole.ifont/) to be used when creating the [ScreenSurface](../sadconsole.screensurface/).

`colors` SadRogue.Primitives.Palette  
``SadRogue.Primitives.Palette`` of colors converted from the [Playscii](../sadconsole.readers.playscii/) format.

#### Returns

[ScreenSurface](../sadconsole.screensurface/)  
[ScreenSurface](../sadconsole.screensurface/) containing the image from the first animation frame.