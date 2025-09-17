---
title: FontExtensions Class
slug: reference/sadconsole.fontextensions
sidebar:
  label: FontExtensions
---
## Definition

Extensions for [IFont](../sadconsole.ifont/).

```csharp title="C#"
public static class FontExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### GetRenderRect(IFont, int, int, Point)

Returns a rectangle that is positioned and sized based on the font and the cell position specified.

```csharp title="C#"
public static Rectangle GetRenderRect(this IFont font, int x, int y, Point fontSize)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
Unused.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x-axis of the cell position.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y-axis of the cell position.

`fontSize` SadRogue.Primitives.Point  
The size of the output cell.

#### Returns

SadRogue.Primitives.Rectangle  
A rectangle to representing a specific cell.

### GetWorldPosition(IFont, Point, Point)

Gets the pixel position of a cell position based on the font size.

```csharp title="C#"
public static Point GetWorldPosition(this IFont font, Point position, Point fontSize)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
Unused.

`position` SadRogue.Primitives.Point  
The cell position to convert.

`fontSize` SadRogue.Primitives.Point  
The size of the font used to calculate the pixel position.

#### Returns

SadRogue.Primitives.Point  
A new pixel-positioned point.

### GetGlyphRatio(IFont, Point)

Returns the ratio in size difference between the font's glyph width and height.

```csharp title="C#"
public static (float X, float Y) GetGlyphRatio(this IFont font, Point fontSize)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
Unused.

`fontSize` SadRogue.Primitives.Point  
The glyph size of the font used.

#### Returns

[(float X, float Y)](https://learn.microsoft.com/dotnet/api/system.single/)  
A tuple with the names (X, Y) where X is the difference of width to height and Y is the difference of height to width.