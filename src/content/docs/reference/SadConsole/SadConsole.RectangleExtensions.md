---
title: RectangleExtensions Class
slug: reference/sadconsole.rectangleextensions
sidebar:
  label: RectangleExtensions
---
## Definition

Extensions for the `SadRogue.Primitives.Rectangle` type.

```csharp title="C#"
public static class RectangleExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToPixels(Rectangle, Point)

Converts a rectangle from cells to pixels.

```csharp title="C#"
public static Rectangle ToPixels(this Rectangle rect, Point fontSize)
```

#### Parameters

`rect` SadRogue.Primitives.Rectangle  
The rectangle to work with.

`fontSize` SadRogue.Primitives.Point  
The font size used for translation.

#### Returns

SadRogue.Primitives.Rectangle  
A new rectangle in pixels.

### ToPixels(Rectangle, int, int)

Converts a rectangle from cells to pixels.

```csharp title="C#"
public static Rectangle ToPixels(this Rectangle rect, int cellWidth, int cellHeight)
```

#### Parameters

`rect` SadRogue.Primitives.Rectangle  
The rectangle to work with.

`cellWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of a cell used in converting.

`cellHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of a cell used in converting.

#### Returns

SadRogue.Primitives.Rectangle  
A new rectangle in pixels.

### ToConsole(Rectangle, Point)

Converts a rectangle from pixels to cells.

```csharp title="C#"
public static Rectangle ToConsole(this Rectangle rect, Point fontSize)
```

#### Parameters

`rect` SadRogue.Primitives.Rectangle  
The rectangle to work with.

`fontSize` SadRogue.Primitives.Point  
The font size used for translation.

#### Returns

SadRogue.Primitives.Rectangle  
A new rectangle in cell coordinates.

### ToConsole(Rectangle, int, int)

Converts a rectangle from pixels to cells.

```csharp title="C#"
public static Rectangle ToConsole(this Rectangle rect, int cellWidth, int cellHeight)
```

#### Parameters

`rect` SadRogue.Primitives.Rectangle  
The rectangle to work with.

`cellWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of a cell used in converting.

`cellHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of a cell used in converting.

#### Returns

SadRogue.Primitives.Rectangle  
A new rectangle in cell coordinates.