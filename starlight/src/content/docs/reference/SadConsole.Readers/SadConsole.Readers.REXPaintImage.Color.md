---
title: REXPaintImage.Color Struct
slug: reference/sadconsole.readers.rexpaintimage.color
sidebar:
  label: REXPaintImage.Color
---
## Definition

A RexPaint color.

```csharp title="C#"
public struct REXPaintImage.Color
```


## Constructors

### Color(byte, byte, byte)

Creates a new RexPaint color with the specified RGB channels.

```csharp title="C#"
public Color(byte r, byte g, byte b)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte/)  
The red channel of the color.

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte/)  
The green channel of the color.

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte/)  
The blue channel of the color.


## Fields

### R

The red channel of the color.

```csharp title="C#"
public byte R
```

### G

The green channel of the color.

```csharp title="C#"
public byte G
```

### B

The blue channel of the color.

```csharp title="C#"
public byte B
```

## Properties

### Transparent

Returns the transparent color used by RexPaint: rgb(255, 0, 255).

```csharp title="C#"
public static REXPaintImage.Color Transparent { get; }
```