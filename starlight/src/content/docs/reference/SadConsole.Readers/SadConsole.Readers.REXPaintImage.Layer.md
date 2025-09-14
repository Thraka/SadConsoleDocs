---
title: REXPaintImage.Layer Class
slug: reference/sadconsole.readers.rexpaintimage.layer
sidebar:
  label: REXPaintImage.Layer
---
## Definition

A layer of a RexPaint image.

```csharp title="C#"
public class REXPaintImage.Layer
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### Layer(int, int)

Creates a new layer with the specified width and height.

```csharp title="C#"
public Layer(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the layer.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the layer.


## Properties

### Width

The width of the layer.

```csharp title="C#"
public int Width { get; }
```

### Height

The height of the layer.

```csharp title="C#"
public int Height { get; }
```

### Cells

Represents all cells of the layer.

```csharp title="C#"
public ReadOnlyCollection<REXPaintImage.Cell> Cells { get; }
```

### this[int, int]

Gets a cell by coordinates.

```csharp title="C#"
public REXPaintImage.Cell this[int x, int y] { get; set; }
```

### this[int]

Gets a cell by index.

```csharp title="C#"
public REXPaintImage.Cell this[int index] { get; set; }
```