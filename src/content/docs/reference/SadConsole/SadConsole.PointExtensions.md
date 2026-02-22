---
title: PointExtensions Class
slug: reference/sadconsole.pointextensions
sidebar:
  label: PointExtensions
editUrl: false
description: Extensions for the `SadRogue.Primitives.Point` type.
---
## Definition

Extensions for the ``SadRogue.Primitives.Point`` type.

```csharp title="C#"
public static class PointExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### SurfaceLocationToPixel(Point, int, int)

Translates a surface cell position to where it appears on the screen in pixels.

```csharp title="C#"
public static Point SurfaceLocationToPixel(this Point point, int cellWidth, int cellHeight)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The current cell position.

`cellWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of a cell in pixels.

`cellHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of a cell in pixels.

#### Returns

SadRogue.Primitives.Point  
The pixel position of the top-left of the cell.

### SurfaceLocationToPixel(Point, Point)

Translates a surface cell position to where it appears on the screen in pixels.

```csharp title="C#"
public static Point SurfaceLocationToPixel(this Point point, Point fontSize)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The current cell position.

`fontSize` SadRogue.Primitives.Point  
The font to use in calculating the position.

#### Returns

SadRogue.Primitives.Point  
The pixel position of the top-left of the cell.

### PixelLocationToSurface(Point, int, int)

Translates a pixel to where it appears on a surface cell.

```csharp title="C#"
public static Point PixelLocationToSurface(this Point point, int cellWidth, int cellHeight)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The current world position.

`cellWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of a cell in pixels.

`cellHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of a cell in pixels.

#### Returns

SadRogue.Primitives.Point  
The cell position on the screen.

### PixelLocationToSurface(Point, Point)

Translates a pixel to where it appears on a surface cell.

```csharp title="C#"
public static Point PixelLocationToSurface(this Point point, Point fontSize)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The current world position.

`fontSize` SadRogue.Primitives.Point  
The font to use in calculating the position.

#### Returns

SadRogue.Primitives.Point  
The cell position on the screen.

### TranslateFont(Point, Point, Point)

Translates the coordinates of a cell from the source font size to a target font size.

```csharp title="C#"
public static Point TranslateFont(this Point point, Point sourceFontSize, Point targetFontSize)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The position of the cell in the `sourceFontSize`.

`sourceFontSize` SadRogue.Primitives.Point  
The source font translating from.

`targetFontSize` SadRogue.Primitives.Point  
The target font translating to.

#### Returns

SadRogue.Primitives.Point  
The position of the cell in the `targetFontSize`.

### GetValidDirections(Point, Rectangle)

Gets a list of indexed boolean values to indicate if the direction from the `position` falls in the `area`.

```csharp title="C#"
public static bool[] GetValidDirections(this Point position, Rectangle area)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position to test from.

`area` SadRogue.Primitives.Rectangle  
The area to test.

#### Returns

[bool[]](https://learn.microsoft.com/dotnet/api/system.boolean/)  
An array of bool values indicating if the direction is valid or not; indexed by a ``SadRogue.Primitives.Direction.Types`` enumeration. Index 0 in the array represents the `position`.

### GetDirectionPoints(Point)

Gets an indexed array of direction positions based on the `position`.

```csharp title="C#"
public static Point[] GetDirectionPoints(this Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The source position.

#### Returns

SadRogue.Primitives.Point[]  
An array of positions indexed by a ``SadRogue.Primitives.Direction.Types`` enumeration. Index 0 in the array represents the `position`.

### GetDirectionIndexes(Point, Rectangle, int)

Gets an array of indexes of a surface based on a position and then a relative ``SadRogue.Primitives.Direction.Type`` direction enumeration..

```csharp title="C#"
public static int[] GetDirectionIndexes(this Point position, Rectangle area, int width)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position center.

`area` SadRogue.Primitives.Rectangle  
The area containing the position.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width to use in converting each index to a point.

#### Returns

[int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
Returns the an array of values indidcating the index in the area surface of each direction where -1 represents a position outside the bounds of the area. Indexed by a ``SadRogue.Primitives.Direction.Types`` enumeration.