---
title: Playscii.Frame Struct
slug: reference/sadconsole.readers.playscii.frame
sidebar:
  label: Playscii.Frame
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
Width of the <xref href="SadConsole.ScreenSurface" data-throw-if-not-resolved="false"></xref>.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the <xref href="SadConsole.ScreenSurface" data-throw-if-not-resolved="false"></xref>.

`font` [IFont](../sadconsole.ifont/)  
<xref href="SadConsole.IFont" data-throw-if-not-resolved="false"></xref> to be used when creating the <xref href="SadConsole.ScreenSurface" data-throw-if-not-resolved="false"></xref>.

`colors` SadRogue.Primitives.Palette  
<xref href="SadRogue.Primitives.Palette" data-throw-if-not-resolved="false"></xref> of colors converted from the <xref href="SadConsole.Readers.Playscii" data-throw-if-not-resolved="false"></xref> format.

#### Returns

[ScreenSurface](../sadconsole.screensurface/)  
[ScreenSurface](../sadconsole.screensurface/) containing the image from the first animation frame.