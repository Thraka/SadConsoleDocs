---
title: REXPaintImage.Cell Struct
slug: reference/sadconsole.readers.rexpaintimage.cell
sidebar:
  label: REXPaintImage.Cell
---
## Definition

A RexPaint layer cell.

```csharp title="C#"
public struct REXPaintImage.Cell
```


## Constructors

### Cell(int, Color, Color)

Creates a new REXPaint cell.

```csharp title="C#"
public Cell(int character, REXPaintImage.Color foreground, REXPaintImage.Color background)
```

#### Parameters

`character` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph.

`foreground` [REXPaintImage.Color](../sadconsole.readers.rexpaintimage/)  
The foreground color.

`background` [REXPaintImage.Color](../sadconsole.readers.rexpaintimage/)  
The background color.


## Fields

### Character

The character for the cell.

```csharp title="C#"
public int Character
```

### Foreground

The foreground color of the cell.

```csharp title="C#"
public REXPaintImage.Color Foreground
```

### Background

The background color of the cell.

```csharp title="C#"
public REXPaintImage.Color Background
```

## Methods

### IsTransparent()

Returns true when the current color is considered transparent.

```csharp title="C#"
public bool IsTransparent()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when transparent.