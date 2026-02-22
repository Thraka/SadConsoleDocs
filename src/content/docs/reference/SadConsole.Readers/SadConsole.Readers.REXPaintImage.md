---
title: REXPaintImage Class
slug: reference/sadconsole.readers.rexpaintimage
sidebar:
  label: REXPaintImage
editUrl: false
description: A RexPaint image.
---
## Definition

A RexPaint image.

```csharp title="C#"
public class REXPaintImage
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### REXPaintImage(int, int)

Creates a new RexPaint image.

```csharp title="C#"
public REXPaintImage(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the image.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the image.


## Properties

### Version

The version of RexPaint that created this image.

```csharp title="C#"
public int Version { get; }
```

### Width

The width of the image.

```csharp title="C#"
public int Width { get; }
```

### Height

The height of the image.

```csharp title="C#"
public int Height { get; }
```

### LayerCount

The total number of layers for this image.

```csharp title="C#"
public int LayerCount { get; }
```

### Layers

A read-only collection of layers.

```csharp title="C#"
public ReadOnlyCollection<REXPaintImage.Layer> Layers { get; }
```

## Methods

### Create()

Creates a new layer for the image adding it to the end of the layer stack.

```csharp title="C#"
public REXPaintImage.Layer Create()
```

#### Returns

[REXPaintImage.Layer](../sadconsole.readers.rexpaintimage/)  
A new layer.

### Create(int)

Creates a new layer for the image and inserts it at the specified position (0-based).

```csharp title="C#"
public REXPaintImage.Layer Create(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The position to create the new layer at.

#### Returns

[REXPaintImage.Layer](../sadconsole.readers.rexpaintimage/)  
A new layer.

### Add(Layer)

Adds an existing layer (must be the same width/height) to the image.

```csharp title="C#"
public void Add(REXPaintImage.Layer layer)
```

#### Parameters

`layer` [REXPaintImage.Layer](../sadconsole.readers.rexpaintimage/)  
The layer to add.


### Add(Layer, int)

Adds an existing layer (must be the same width/height) to the image and inserts it at the specified position (0-based).

```csharp title="C#"
public void Add(REXPaintImage.Layer layer, int index)
```

#### Parameters

`layer` [REXPaintImage.Layer](../sadconsole.readers.rexpaintimage/)  
The layer to add.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The position to add the layer.


### Remove(Layer)

Removes the specified layer.

```csharp title="C#"
public void Remove(REXPaintImage.Layer layer)
```

#### Parameters

`layer` [REXPaintImage.Layer](../sadconsole.readers.rexpaintimage/)  
The layer.


### ToCellSurface()

Converts each layer in this REXPaint image to [CellSurface](../sadconsole.cellsurface/).

```csharp title="C#"
public ICellSurface[] ToCellSurface()
```

#### Returns

[ICellSurface[]](../sadconsole.icellsurface/)  
An array of each converted layer.

### Load(Stream)

Loads a .xp RexPaint image from a GZip compressed stream.

```csharp title="C#"
public static REXPaintImage Load(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream/)  
The GZip stream to load.

#### Returns

[REXPaintImage](../sadconsole.readers.rexpaintimage/)  
The RexPaint image.