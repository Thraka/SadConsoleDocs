---
title: Playscii Class
slug: reference/sadconsole.readers.playscii
sidebar:
  label: Playscii
editUrl: false
description: Playscii converter. Check this excellent ascii editor out at http://vectorpoem.com/playscii/
---
## Definition

Playscii converter. Check this excellent ascii editor out at http://vectorpoem.com/playscii/

```csharp title="C#"
public class Playscii
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### Playscii()

```csharp title="C#"
public Playscii()
```


## Fields

### charset

Name of the font file.

```csharp title="C#"
public string charset
```

### frames

Hold all the animation frames.

```csharp title="C#"
public Playscii.Frame[] frames
```

### height

Surface height.

```csharp title="C#"
public int height
```

### palette

Name of the palette file.

```csharp title="C#"
public string palette
```

### width

Surface width.

```csharp title="C#"
public int width
```

## Methods

### ToScreenSurface(string, IFont, string, string)

Converts a [Playscii](../sadconsole.readers.playscii/) file to a SadConsole [ScreenSurface](../sadconsole.screensurface/).

```csharp title="C#"
public static ScreenSurface ToScreenSurface(string fileName, IFont font, string paletteFileName = "", string zipArchiveName = "")
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Name and path of the [Playscii](../sadconsole.readers.playscii/) file (give only file name if `zipArchiveName` is used).

`font` [IFont](../sadconsole.ifont/)  
[IFont](../sadconsole.ifont/) to be used when converting the [Playscii](../sadconsole.readers.playscii/) file.

`paletteFileName` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Path to an alternative palette file rather than the one specified in the playscii records.

`zipArchiveName` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
If specified, the playscii file will be read from this zip archive.

#### Returns

[ScreenSurface](../sadconsole.screensurface/)  
[ScreenSurface](../sadconsole.screensurface/) containing the first frame from the [Playscii](../sadconsole.readers.playscii/) file.
#### Remarks

SadConsole does not support all the Playscii features at the moment, so the conversion will not be perfect.<br /> Do not use tile rotation and set Z-Depth to 0 on all Playscii layers.<br /> Transparent glyph foreground is fine, but it will not cut through the [ColoredGlyphBase](../sadconsole.coloredglyphbase/) background like it does in Playscii.