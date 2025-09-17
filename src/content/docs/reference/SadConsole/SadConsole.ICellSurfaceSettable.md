---
title: ICellSurfaceSettable Interface
slug: reference/sadconsole.icellsurfacesettable
sidebar:
  label: ICellSurfaceSettable
---
## Definition

Adds a method to change the backing cells of a surface.

```csharp title="C#"
public interface ICellSurfaceSettable
```


## Methods

### SetSurface(ICellSurface, Rectangle)

Remaps the cells of this surface to a view of the `surface`.

```csharp title="C#"
void SetSurface(ICellSurface surface, Rectangle view = default)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The target surface to map cells from.

`view` SadRogue.Primitives.Rectangle  
A view rectangle of the target surface.


### SetSurface(ColoredGlyphBase[], int, int, int, int)

Changes the cells of the surface to the provided array.

```csharp title="C#"
void SetSurface(ColoredGlyphBase[] cells, int width, int height, int bufferWidth, int bufferHeight)
```

#### Parameters

`cells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The cells to replace in this surface.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable width of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable height of the surface.

`bufferWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum width of the surface.

`bufferHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum height of the surface.