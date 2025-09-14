---
title: CellSurfaceEditor Class
slug: reference/sadconsole.cellsurfaceeditor
sidebar:
  label: CellSurfaceEditor
---
## Definition

Methods to interact with a [ICellSurface](../sadconsole.icellsurface/).

```csharp title="C#"
public static class CellSurfaceEditor
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### SetPixels(ISurface, Color[])

Sets each background of a cell to the array of colors. `pixels` must be the same length as the amount of cells in the surface.

```csharp title="C#"
public static void SetPixels(this ISurface obj, Color[] pixels)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`pixels` SadRogue.Primitives.Color[]  
The colors to place.


### SetPixels(ISurface, Rectangle, Color[])

Sets each background of a cell to the array of colors.

```csharp title="C#"
public static void SetPixels(this ISurface obj, Rectangle area, Color[] pixels)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`area` SadRogue.Primitives.Rectangle  
An area to fill with pixels.

`pixels` SadRogue.Primitives.Color[]  
Colors for each cell of the obj.Surface.


### IsValidCell(ISurface, int, int)

Tests if a cell is valid based on its x,y position.

```csharp title="C#"
public static bool IsValidCell(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate of the cell to test.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate of the cell to test.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A true value indicating the cell by x,y does exist in this cell obj.Surface.

### IsValidCell(ISurface, Point)

Tests if a cell is valid based on its x,y position.

```csharp title="C#"
public static bool IsValidCell(this ISurface obj, Point coordinate)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`coordinate` SadRogue.Primitives.Point  
The coordinate of the cell to test.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A true value indicating the cell by x,y does exist in this cell obj.Surface.

### IsValidCell(ISurface, int, int, out int)

Tests if a cell is valid based on its x,y position.

```csharp title="C#"
public static bool IsValidCell(this ISurface obj, int x, int y, out int index)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate of the cell to test.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate of the cell to test.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
If the cell is valid, the index of the cell when found.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A true value indicating the cell by x,y does exist in this cell obj.Surface.

### IsValidCell(ISurface, Point, out int)

Tests if a cell is valid based on its x,y position.

```csharp title="C#"
public static bool IsValidCell(this ISurface obj, Point coordinate, out int index)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`coordinate` SadRogue.Primitives.Point  
The coordinate of the cell to test.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
If the cell is valid, the index of the cell when found.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A true value indicating the cell by x,y does exist in this cell obj.Surface.

### IsValidCell(ISurface, int)

Tests if a cell is valid based on its index.

```csharp title="C#"
public static bool IsValidCell(this ISurface obj, int index)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index to test.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A true value indicating the cell index is in this cell obj.Surface.

### SetGlyph(ISurface, int, int, GlyphDefinition)

Changes the glyph and mirror of the specified cell.

```csharp title="C#"
public static void SetGlyph(this ISurface obj, int x, int y, GlyphDefinition definition)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`definition` [GlyphDefinition](../sadconsole.glyphdefinition/)  
The glyph and mirror of the cell.


### SetGlyph(ISurface, int, int, int)

Changes the glyph of a specified cell to a new value.

```csharp title="C#"
public static void SetGlyph(this ISurface obj, int x, int y, int glyph)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired glyph of the cell.


### SetGlyph(ISurface, int, int, int, Color)

Changes the glyph and foreground of a cell.

```csharp title="C#"
public static void SetGlyph(this ISurface obj, int x, int y, int glyph, Color foreground)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired glyph.

`foreground` SadRogue.Primitives.Color  
The desired foreground.


### SetGlyph(ISurface, int, int, int, Color, Color)

Changes the glyph, foreground, and background of a cell.

```csharp title="C#"
public static void SetGlyph(this ISurface obj, int x, int y, int glyph, Color foreground, Color background)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired glyph.

`foreground` SadRogue.Primitives.Color  
The desired foreground.

`background` SadRogue.Primitives.Color  
The desired background.


### SetGlyph(ISurface, int, int, int, Color, Color, Mirror)

Changes the glyph, foreground, background, and mirror of a cell.

```csharp title="C#"
public static void SetGlyph(this ISurface obj, int x, int y, int glyph, Color foreground, Color background, Mirror mirror)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired glyph.

`foreground` SadRogue.Primitives.Color  
The desired foreground.

`background` SadRogue.Primitives.Color  
The desired background.

`mirror` [Mirror](../sadconsole.mirror/)  
Sets how the glyph will be mirrored.


### SetGlyph(ISurface, int, int, int, Color, Color, Mirror, IEnumerable<CellDecorator>)

Changes the glyph, foreground, background, and mirror of a cell.

```csharp title="C#"
public static void SetGlyph(this ISurface obj, int x, int y, int glyph, Color foreground, Color background, Mirror mirror, IEnumerable<CellDecorator> decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired glyph.

`foreground` SadRogue.Primitives.Color  
The desired foreground.

`background` SadRogue.Primitives.Color  
The desired background.

`mirror` [Mirror](../sadconsole.mirror/)  
Sets how the glyph will be mirrored.

`decorators` [IEnumerable\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
Decorators to set on the cell. Will clear existing decorators first.


### GetGlyph(ISurface, int, int)

Gets the glyph of a specified cell.

```csharp title="C#"
public static int GetGlyph(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.

### SetForeground(ISurface, int, int, Color)

Changes the foreground of a specified cell to a new color.

```csharp title="C#"
public static void SetForeground(this ISurface obj, int x, int y, Color color)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`color` SadRogue.Primitives.Color  
The desired color of the cell.


### GetForeground(ISurface, int, int)

Gets the foreground of a specified cell.

```csharp title="C#"
public static Color GetForeground(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

#### Returns

SadRogue.Primitives.Color  
The color.

### SetBackground(ISurface, int, int, Color)

Changes the background of a cell to the specified color.

```csharp title="C#"
public static void SetBackground(this ISurface obj, int x, int y, Color color)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`color` SadRogue.Primitives.Color  
The desired color of the cell.


### GetBackground(ISurface, int, int)

Gets the background of a specified cell.

```csharp title="C#"
public static Color GetBackground(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

#### Returns

SadRogue.Primitives.Color  
The color.

### SetEffect(ISurface, int, int, ICellEffect?)

Changes the effect of a cell to the specified effect.

```csharp title="C#"
public static void SetEffect(this ISurface obj, int x, int y, ICellEffect? effect)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The desired effect.


### SetEffect(ISurface, int, ICellEffect?)

Changes the effect of a cell to the specified effect.

```csharp title="C#"
public static void SetEffect(this ISurface obj, int index, ICellEffect? effect)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Index of the cell.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The desired effect.


### SetEffect(ISurface, IEnumerable<Point>, ICellEffect?)

Changes the effect of a list of cells to the specified effect.

```csharp title="C#"
public static void SetEffect(this ISurface obj, IEnumerable<Point> cells, ICellEffect? effect)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`cells` [IEnumerable\<Point\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The cells for the effect.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The desired effect.


### SetEffect(ISurface, IEnumerable<int>, ICellEffect?)

Changes the effect of a list of cells to the specified effect.

```csharp title="C#"
public static void SetEffect(this ISurface obj, IEnumerable<int> cells, ICellEffect? effect)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`cells` [IEnumerable\<int\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The cells for the effect.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The desired effect.


### SetEffect(ISurface, ColoredGlyphBase, ICellEffect?)

Changes the effect of a cell to the specified effect.

```csharp title="C#"
public static void SetEffect(this ISurface obj, ColoredGlyphBase cell, ICellEffect? effect)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The cells for the effect.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The desired effect.


### SetEffect(ISurface, IEnumerable<ColoredGlyphBase>, ICellEffect?)

Changes the effect of a cell to the specified effect.

```csharp title="C#"
public static void SetEffect(this ISurface obj, IEnumerable<ColoredGlyphBase> cells, ICellEffect? effect)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`cells` [IEnumerable\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The cells for the effect.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The desired effect.


### GetEffect(ISurface, int, int)

Gets the effect of the specified cell.

```csharp title="C#"
public static ICellEffect? GetEffect(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

#### Returns

[ICellEffect](../sadconsole.effects.icelleffect/)  
The effect.

### GetEffect(ISurface, int)

Gets the effect of the specified cell.

```csharp title="C#"
public static ICellEffect? GetEffect(this ISurface obj, int index)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell.

#### Returns

[ICellEffect](../sadconsole.effects.icelleffect/)  
The effect.

### SetCellAppearance(ISurface, int, int, ColoredGlyphBase)

Changes the appearance of the cell to that of the provided colored glyph object.

```csharp title="C#"
public static void SetCellAppearance(this ISurface obj, int x, int y, ColoredGlyphBase appearance)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`appearance` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The desired appearance of the cell. A null value cannot be passed.


### SetCellAppearance(ISurface, int, int, GlyphDefinition)

Changes the appearance of the cell to that of the provided colored glyph object.

```csharp title="C#"
public static void SetCellAppearance(this ISurface obj, int x, int y, GlyphDefinition definition)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`definition` [GlyphDefinition](../sadconsole.glyphdefinition/)  
The glyph and mirror of the cell.


### GetCellAppearance(ISurface, int, int)

Gets the appearance of a cell.

```csharp title="C#"
public static ColoredGlyphBase GetCellAppearance(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance.

### GetCells(ISurface, Rectangle)

Gets an enumerable of cells over a specific area.

```csharp title="C#"
public static IEnumerable<ColoredGlyphBase> GetCells(this ISurface obj, Rectangle area)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`area` SadRogue.Primitives.Rectangle  
The area to get cells from.

#### Returns

[IEnumerable\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
A new array with references to each cell in the area.

### GetSubSurface(ISurface, Rectangle)

Returns a new surface with reference to each cell inside of the `view`.

```csharp title="C#"
public static ICellSurface GetSubSurface(this ISurface obj, Rectangle view)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`view` SadRogue.Primitives.Rectangle  
An area of the surface to create a view of.

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
A new surface

### GetSubSurface(ISurface)

Returns a new surface using the cells from the current surface.

```csharp title="C#"
public static ICellSurface GetSubSurface(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface.

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
A new surface instance.

### GetMirror(ISurface, int, int)

Gets the mirror of a specified cell.

```csharp title="C#"
public static Mirror GetMirror(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

#### Returns

[Mirror](../sadconsole.mirror/)  
The [Mirror](../sadconsole.mirror/) of the cell.

### SetMirror(ISurface, int, int, Mirror)

Sets the mirror of a specified cell.

```csharp title="C#"
public static void SetMirror(this ISurface obj, int x, int y, Mirror mirror)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror of the cell.


### SetDecorator(ISurface, int, int, int, params CellDecorator[]?)

Sets the decorator of one or more cells.

```csharp title="C#"
public static void SetDecorator(this ISurface obj, int x, int y, int count, params CellDecorator[]? decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate of the cell.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the x,y coordinate (inclusive).

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators. Use <pre><code class="lang-csharp">null</code></pre> to clear.


### SetDecorator(ISurface, Point, params CellDecorator[]?)

Sets the decorators of a cell.

```csharp title="C#"
public static void SetDecorator(this ISurface obj, Point position, params CellDecorator[]? decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`position` SadRogue.Primitives.Point  
The coordinate of the cell.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators. Use <pre><code class="lang-csharp">null</code></pre> to clear.


### SetDecorator(ISurface, int, int, params CellDecorator[]?)

Sets the decorator of one or more cells.

```csharp title="C#"
public static void SetDecorator(this ISurface obj, int index, int count, params CellDecorator[]? decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell to start applying.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the index (inclusive).

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators. Use <pre><code class="lang-csharp">null</code></pre> to clear.


### SetDecorator(ISurface, int, params CellDecorator[]?)

Sets the decorators of a single cell.

```csharp title="C#"
public static void SetDecorator(this ISurface obj, int index, params CellDecorator[]? decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell to start applying.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators. Use <pre><code class="lang-csharp">null</code></pre> to clear.


### AddDecorator(ISurface, int, int, int, params CellDecorator[])

Appends the decorators to one or more cells

```csharp title="C#"
public static void AddDecorator(this ISurface obj, int x, int y, int count, params CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate of the cell.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the x,y coordinate (inclusive).

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### AddDecorator(ISurface, Point, params CellDecorator[])

Appends the decorators to one or more cells

```csharp title="C#"
public static void AddDecorator(this ISurface obj, Point position, params CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`position` SadRogue.Primitives.Point  
The x,y coordinate of the cell.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### AddDecorator(ISurface, int, int, params CellDecorator[])

Appends the decorators to one or more cells

```csharp title="C#"
public static void AddDecorator(this ISurface obj, int index, int count, params CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell to start applying.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the index (inclusive).

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### AddDecorator(ISurface, int, params CellDecorator[]?)

Appends the decorators to one or more cells

```csharp title="C#"
public static void AddDecorator(this ISurface obj, int index, params CellDecorator[]? decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell to start applying.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### RemoveDecorator(ISurface, int, int, int, params CellDecorator[])

Removes the decorators from one or more cells.

```csharp title="C#"
public static void RemoveDecorator(this ISurface obj, int x, int y, int count, params CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate of the cell.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the x,y coordinate (inclusive).

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### RemoveDecorator(ISurface, Point, params CellDecorator[])

Removes the decorators from a cell.

```csharp title="C#"
public static void RemoveDecorator(this ISurface obj, Point position, params CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`position` SadRogue.Primitives.Point  
The x,y coordinate of the cell.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### RemoveDecorator(ISurface, int, int, params CellDecorator[])

Removes the decorators from one or more cells.

```csharp title="C#"
public static void RemoveDecorator(this ISurface obj, int index, int count, params CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell to start applying.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the index (inclusive).

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### RemoveDecorator(ISurface, int, params CellDecorator[])

Removes the decorators from a cell.

```csharp title="C#"
public static void RemoveDecorator(this ISurface obj, int index, params CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell to start applying.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### ClearDecorators(ISurface, int, int, int)

Clears the decorators of the specified cells.

```csharp title="C#"
public static void ClearDecorators(this ISurface obj, int x, int y, int count)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate of the cell.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the x,y coordinate (inclusive).


### ClearDecorators(ISurface, int, int)

Clears the decorators of the specified cells

```csharp title="C#"
public static void ClearDecorators(this ISurface obj, int index, int count)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the cell to start applying.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of cells to use from the index (inclusive).


### Print(ISurface, int, int, string)

Draws the string on the console at the specified location, wrapping if needed.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, string text)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to display.


### Print(ISurface, int, int, string, Color)

Draws the string on the console at the specified location and color, wrapping if needed.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, string text, Color foreground)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to display.

`foreground` SadRogue.Primitives.Color  
Sets the foreground of all characters in the text.


### Print(ISurface, int, int, string, Color, Color)

Draws the string on the console at the specified location with the specified foreground and background color, wrapping if needed.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, string text, Color foreground, Color background)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to display.

`foreground` SadRogue.Primitives.Color  
Sets the foreground of all characters in the text.

`background` SadRogue.Primitives.Color  
Sets the background of all characters in the text.


### Print(ISurface, int, int, string, Color, Color, Mirror)

Draws the string on the console at the specified location with the specified settings.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, string text, Color foreground, Color background, Mirror mirror)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to display.

`foreground` SadRogue.Primitives.Color  
Sets the foreground of all characters in the text.

`background` SadRogue.Primitives.Color  
Sets the background of all characters in the text.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror to set on all characters in the text.


### Print(ISurface, int, int, string, Color, Color, Mirror, CellDecorator[])

Draws the string on the console at the specified location with the specified settings.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, string text, Color foreground, Color background, Mirror mirror, CellDecorator[] decorators)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to display.

`foreground` SadRogue.Primitives.Color  
Sets the foreground of all characters in the text.

`background` SadRogue.Primitives.Color  
Sets the background of all characters in the text.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror to set on all characters in the text.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
An array of cell decorators to use on each glyph. A <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> value will clear the decorators.


### Print(ISurface, int, int, string, Mirror)

Draws the string on the console at the specified location with the specified settings.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, string text, Mirror mirror)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to display.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror to set on all characters in the text.


### Print(ISurface, int, int, string, ColoredGlyphBase, ICellEffect?)

Draws the string on the console at the specified location, wrapping if needed.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, string text, ColoredGlyphBase appearance, ICellEffect? effect = null)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to display.

`appearance` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance of the cell

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
An optional effect to apply to the printed obj.Surface.


### Print(ISurface, int, int, ColoredString)

Draws the string on the console at the specified location, wrapping if needed.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, ColoredString text)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`text` [ColoredString](../sadconsole.coloredstring/)  
The string to display.


### Print(ISurface, int, int, ColoredGlyphBase[])

Draws the string on the console at the specified location, wrapping if needed.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, ColoredGlyphBase[] glyphs)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`glyphs` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
An array of glyphs to print at the specified position.


### Print(ISurface, int, int, IEnumerable<ColoredGlyphBase>)

Draws the string on the console at the specified location, wrapping if needed.

```csharp title="C#"
public static void Print(this ISurface obj, int x, int y, IEnumerable<ColoredGlyphBase> glyphs)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X location of the text.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y location of the text.

`glyphs` [IEnumerable\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
An enumeration of glyphs to print at the specified position.


### GetString(ISurface, int, int, int)

Builds a string from the text surface from the specified coordinates.

```csharp title="C#"
public static string GetString(this ISurface obj, int x, int y, int length)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x position of the surface to start at.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y position of the surface to start at.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many characters to fill the string with.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A string built from the text surface data.

### GetString(ISurface, int, int)

Builds a string from the cells.

```csharp title="C#"
public static string GetString(this ISurface obj, int index, int length)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Where to start getting characters from.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many characters to fill the string with.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A string built from the text surface data.

### GetStringColored(ISurface, int, int, int)

Builds a string from the text surface from the specified coordinates.

```csharp title="C#"
public static ColoredString GetStringColored(this ISurface obj, int x, int y, int length)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x position of the surface to start at.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y position of the surface to start at.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many characters to fill the string with.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A string built from the text surface data.

### GetStringColored(ISurface, int, int)

Builds a string from the text surface.

```csharp title="C#"
public static ColoredString GetStringColored(this ISurface obj, int index, int length)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Where to start getting characters from.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many characters to fill the string with.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A string built from the text surface data.

### ClearShiftValues(ISurface)

Resets the shifted amounts to 0, as if the surface has never shifted.

```csharp title="C#"
public static void ClearShiftValues(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.


### ShiftRow(ISurface, int, int, bool)

Shifts the entire row by the specified amount.

```csharp title="C#"
public static void ShiftRow(this ISurface obj, int row, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The row to shift.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.


### ShiftRow(ISurface, int, int, int, int, bool)

Shifts the specified row from an X position, by the specified amount.

```csharp title="C#"
public static void ShiftRow(this ISurface obj, int row, int startingX, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The row to shift.

`startingX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting column to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingX</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
One of the parameters is outside of the surface width.


### ShiftRowRight(ISurface, int, int, int, int, bool)

Shifts the specified row from an X position, by the specified amount, to the right.

```csharp title="C#"
public static void ShiftRowRight(this ISurface obj, int row, int startingX, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The row to shift.

`startingX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting column to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingX</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
One of the parameters is outside of the surface width.


### ShiftRowLeft(ISurface, int, int, int, int, bool)

Shifts the specified row from an X position, by the specified amount, to the left.

```csharp title="C#"
public static void ShiftRowLeft(this ISurface obj, int row, int startingX, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The row to shift.

`startingX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting column to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingX</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
One of the parameters is outside of the surface width.


### ShiftRowRightUnchecked(ISurface, int, int, int, int, bool)

Internal use. Doesn't do any checks on valid values. Shifts the specified row from an X position, by the specified amount, to the right.

```csharp title="C#"
public static void ShiftRowRightUnchecked(this ISurface obj, int row, int startingX, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The row to shift.

`startingX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting column to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingX</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.


### ShiftRowLeftUnchecked(ISurface, int, int, int, int, bool)

Internal use. Doesn't do any checks on valid values. Shifts the specified row from an X position, by the specified amount, to the left.

```csharp title="C#"
public static void ShiftRowLeftUnchecked(this ISurface obj, int row, int startingX, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The row to shift.

`startingX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting column to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingX</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.


### ShiftColumn(ISurface, int, int, bool)

Shifts the entire column by the specified amount.

```csharp title="C#"
public static void ShiftColumn(this ISurface obj, int col, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The column to shift.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.


### ShiftColumn(ISurface, int, int, int, int, bool)

Shifts the specified row from an X position, by the specified amount.

```csharp title="C#"
public static void ShiftColumn(this ISurface obj, int col, int startingY, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The column to shift.

`startingY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting row to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingY</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
One of the parameters is outside of the surface height.


### ShiftColumnDown(ISurface, int, int, int, int, bool)

Shifts the specified row from n Y position, by the specified amount, down.

```csharp title="C#"
public static void ShiftColumnDown(this ISurface obj, int col, int startingY, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The column to shift.

`startingY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting row to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingY</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
One of the parameters is outside of the surface height.


### ShiftColumnUp(ISurface, int, int, int, int, bool)

Shifts the specified row from n Y position, by the specified amount, up.

```csharp title="C#"
public static void ShiftColumnUp(this ISurface obj, int col, int startingY, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The column to shift.

`startingY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting row to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingY</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
One of the parameters is outside of the surface height.


### ShiftColumnDownUnchecked(ISurface, int, int, int, int, bool)

Internal use. Doesn't do any checks on valid values. Shifts the specified row from a Y position, by the specified amount, down.

```csharp title="C#"
public static void ShiftColumnDownUnchecked(this ISurface obj, int col, int startingY, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The column to shift.

`startingY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting column to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingY</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.


### ShiftColumnUpUnchecked(ISurface, int, int, int, int, bool)

Internal use. Doesn't do any checks on valid values. Shifts the specified row from a Y position, by the specified amount, up.

```csharp title="C#"
public static void ShiftColumnUpUnchecked(this ISurface obj, int col, int startingY, int count, int amount, bool wrap)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`col` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The column to shift.

`startingY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting column to shift from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of cells to shift starting from <code class="paramref">startingY</code>.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount to shift by. A negative value shifts left and a positive value shifts right.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, wraps the glyph data from one side to another, otherwise clears the glyphs left behind.


### ShiftUp(ISurface)

Scrolls all the console data up by one.

```csharp title="C#"
public static void ShiftUp(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.


### ShiftUp(ISurface, int, bool)

Scrolls all the console data up by the specified amount of rows.

```csharp title="C#"
public static void ShiftUp(this ISurface obj, int amount, bool wrap = false)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many rows to shift.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When false, a blank line appears at the bottom. When true, the top line appears at the bottom.


### ShiftDown(ISurface)

Scrolls all the console data down by one.

```csharp title="C#"
public static void ShiftDown(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.


### ShiftDown(ISurface, int, bool)

Scrolls all the console data down by the specified amount of rows.

```csharp title="C#"
public static void ShiftDown(this ISurface obj, int amount, bool wrap = false)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many rows to shift.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When false, a blank line appears at the top. When true, the bottom line appears at the top.


### ShiftRight(ISurface)

Scrolls all the console data right by one.

```csharp title="C#"
public static void ShiftRight(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.


### ShiftRight(ISurface, int, bool)

Scrolls all the console data right by the specified amount.

```csharp title="C#"
public static void ShiftRight(this ISurface obj, int amount, bool wrap = false)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How much to scroll.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When false, a blank line appears at the left. When true, the right line appears at the left.


### ShiftLeft(ISurface)

Scrolls all the console data left by one.

```csharp title="C#"
public static void ShiftLeft(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.


### ShiftLeft(ISurface, int, bool)

Scrolls all the console data left by the specified amount.

```csharp title="C#"
public static void ShiftLeft(this ISurface obj, int amount, bool wrap = false)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How much to scroll.

`wrap` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When false, a blank line appears at the right. When true, the left line appears at the right.


### Erase(ISurface, int, int, int)

Starting at the specified coordinate, clears the glyph, mirror, and decorators, for the specified count of obj.Surface. Doesn't clear the effect, foreground, or background.

```csharp title="C#"
public static ColoredGlyphBase[] Erase(this ISurface obj, int x, int y, int count)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x position.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y position.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of glyphs to erase.

#### Returns

[ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The cells processed by this method.
#### Remarks

Cells altered by this method has the [Glyph](../sadconsole.coloredglyphbase/#glyph/) set to [DefaultGlyph](../sadconsole.icellsurface/#defaultglyph/), the [Decorators](../sadconsole.coloredglyphbase/#decorators/) array reset, and the [Mirror](../sadconsole.coloredglyphbase/#mirror/) set to [None](../sadconsole.mirror/#none/).

### Erase(ISurface, int, int)

Clears the glyph, mirror, and decorators, for the specified cell. Doesn't clear the effect.

```csharp title="C#"
public static void Erase(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x position.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y position.

#### Remarks

The cell altered by this method has the [Glyph](../sadconsole.coloredglyphbase/#glyph/) set to [DefaultGlyph](../sadconsole.icellsurface/#defaultglyph/), the [Decorators](../sadconsole.coloredglyphbase/#decorators/) array reset, and the [Mirror](../sadconsole.coloredglyphbase/#mirror/) set to [None](../sadconsole.mirror/#none/).

### Erase(ISurface)

Erases all cells which clears the glyph, mirror, and decorators. Doesn't clear the effect.

```csharp title="C#"
public static void Erase(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

#### Remarks

All cells have [Glyph](../sadconsole.coloredglyphbase/#glyph/) set to [DefaultGlyph](../sadconsole.icellsurface/#defaultglyph/), the [Decorators](../sadconsole.coloredglyphbase/#decorators/) array reset, and the [Mirror](../sadconsole.coloredglyphbase/#mirror/) set to [None](../sadconsole.mirror/#none/).

### Clear(ISurface)

Clears the console data. Characters are reset to 0, the foreground and background are set to default, and mirror set to none. Clears cell decorators.

```csharp title="C#"
public static void Clear(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.


### Clear(ISurface, int, int)

Clears a cell. Character is reset to 0, the foreground and background is set to default, and mirror is set to none. Clears cell decorators.

```csharp title="C#"
public static void Clear(this ISurface obj, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x location of the cell.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y location of the cell.


### Clear(ISurface, int, int, int)

Clears a segment of cells, starting from the left, extending to the right, and wrapping if needed. Character is reset to 0, the foreground and background is set to default, and mirror is set to none. Clears cell decorators.

```csharp title="C#"
public static void Clear(this ISurface obj, int x, int y, int length)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x position of the left end of the segment.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y position of the segment.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The length of the segment. If it extends beyond the line, it will wrap to the next line. If it extends beyond the console, then it automatically ends at the last valid cell.

#### Remarks

This works similarly to printing a string of whitespace

### Clear(ISurface, Rectangle)

Clears an area of obj.Surface. Each cell is reset to its default state. Then, Glyph, foreground, and background, are reset to the surface's default values.

```csharp title="C#"
public static void Clear(this ISurface obj, Rectangle area)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`area` SadRogue.Primitives.Rectangle  
The area to clear.


### Clear(ISurface, IEnumerable<Point>)

Clears an area of obj.Surface. Each cell is reset to its default state. Then, Glyph, foreground, and background, are reset to the surface's default values.

```csharp title="C#"
public static void Clear(this ISurface obj, IEnumerable<Point> cellPositions)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`cellPositions` [IEnumerable\<Point\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The cells to clear.


### Fill(ISurface, ColoredGlyphBase)

Fills the console. Clears cell decorators and effects.

```csharp title="C#"
public static ColoredGlyphBase[] Fill(this ISurface obj, ColoredGlyphBase iconAppearance)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`iconAppearance` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance that is copied to every cell.

#### Returns

[ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The array of all cells in this console, starting from the top left corner.

### Fill(ISurface, Color?, Color?, int?, Mirror?)

Fills the console. Clears cell decorators and effects.

```csharp title="C#"
public static ColoredGlyphBase[] Fill(this ISurface obj, Color? foreground = null, Color? background = null, int? glyph = null, Mirror? mirror = null)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`foreground` System.NullableSadRogue.Primitives.Color  
Foreground to apply. If null, skips.

`background` System.NullableSadRogue.Primitives.Color  
Foreground to apply. If null, skips.

`glyph` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  
Glyph to apply. If null, skips.

`mirror` [Mirror?](../sadconsole.mirror/)  
Mirror to apply. If null, skips.

#### Returns

[ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The array of all cells in this console, starting from the top left corner.

### Fill(ISurface, int, int, int, Color?, Color?, int?, Mirror?)

Fills a segment of cells, starting from the left, extending to the right, and wrapping if needed. Clears cell decorators.

```csharp title="C#"
public static ColoredGlyphBase[] Fill(this ISurface obj, int x, int y, int length, Color? foreground = null, Color? background = null, int? glyph = null, Mirror? mirror = null)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x position of the left end of the segment.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y position of the segment.

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The length of the segment. If it extends beyond the line, it will wrap to the next line. If it extends beyond the console, then it automatically ends at the last valid cell.

`foreground` System.NullableSadRogue.Primitives.Color  
Foreground to apply. If null, skips.

`background` System.NullableSadRogue.Primitives.Color  
Background to apply. If null, skips.

`glyph` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  
Glyph to apply. If null, skips.

`mirror` [Mirror?](../sadconsole.mirror/)  
Mirror to apply. If null, skips.

#### Returns

[ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
An array containing the affected cells, starting from the top left corner. If x or y are out of bounds, nothing happens and an empty array is returned

### Fill(ISurface, Rectangle, Color?, Color?, int?, Mirror?)

Fills the specified area. Clears cell decorators.

```csharp title="C#"
public static ColoredGlyphBase[] Fill(this ISurface obj, Rectangle area, Color? foreground = null, Color? background = null, int? glyph = null, Mirror? mirror = null)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`area` SadRogue.Primitives.Rectangle  
The area to fill.

`foreground` System.NullableSadRogue.Primitives.Color  
Foreground to apply. If null, skips.

`background` System.NullableSadRogue.Primitives.Color  
Background to apply. If null, skips.

`glyph` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  
Glyph to apply. If null, skips.

`mirror` [Mirror?](../sadconsole.mirror/)  
Mirror to apply. If null, skips.

#### Returns

[ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
An array containing the affected cells, starting from the top left corner. If the area is out of bounds, nothing happens and an empty array is returned.

### DrawLine(ISurface, Point, Point, int?, Color?, Color?, Mirror?)

Draws a line from `start` to `end`.

```csharp title="C#"
public static IEnumerable<ColoredGlyphBase> DrawLine(this ISurface obj, Point start, Point end, int? glyph, Color? foreground = null, Color? background = null, Mirror? mirror = null)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`start` SadRogue.Primitives.Point  
Starting point of the line.

`end` SadRogue.Primitives.Point  
Ending point of the line.

`glyph` [int?](https://learn.microsoft.com/dotnet/api/system.int32/)  
Glyph to set. If null, skipped.

`foreground` System.NullableSadRogue.Primitives.Color  
Foreground to set. If null, skipped.

`background` System.NullableSadRogue.Primitives.Color  
Background to set. If null, skipped.

`mirror` [Mirror?](../sadconsole.mirror/)  
Mirror to set. If null, skipped.

#### Returns

[IEnumerable\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
A list of cells the line touched; ordered from first to last.
#### Remarks

To simply return the list of cells that would be drawn to, use <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> for `glyph`, `foreground`, `background`, and `mirror`.

### DrawBox(ISurface, Rectangle, ShapeParameters)

Draws a box.

```csharp title="C#"
public static void DrawBox(this ISurface obj, Rectangle area, ShapeParameters parameters)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`area` SadRogue.Primitives.Rectangle  
The area of the box.

`parameters` [ShapeParameters](../sadconsole.shapeparameters/)  
Provides the options for drawing a border and filling the box.


### DrawCircle(ISurface, Rectangle, ShapeParameters)

Draws an ellipse.

```csharp title="C#"
public static void DrawCircle(this ISurface obj, Rectangle area, ShapeParameters parameters)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`area` SadRogue.Primitives.Rectangle  
The area the ellipse

`parameters` [ShapeParameters](../sadconsole.shapeparameters/)  
Provides the options for drawing a border and filling the circle.


### ConnectLines(ISurface)

Connects all lines in a surface for both [ConnectedLineThin](../sadconsole.icellsurface/#connectedlinethin/) and [ConnectedLineThick](../sadconsole.icellsurface/#connectedlinethick/) styles.

```csharp title="C#"
public static void ConnectLines(this ISurface obj)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.


### ConnectLines(ISurface, int[])

Connects all lines in this based on the `lineStyle` style provided.

```csharp title="C#"
public static void ConnectLines(this ISurface obj, int[] lineStyle)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`lineStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
The array of line styles indexed by <xref href="SadConsole.ICellSurface.ConnectedLineIndex" data-throw-if-not-resolved="false"></xref>.


### ConnectLines(ISurface, int[], Rectangle)

Connects all lines in this based on the `lineStyle` style provided.

```csharp title="C#"
public static void ConnectLines(this ISurface obj, int[] lineStyle, Rectangle area)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`lineStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
The array of line styles indexed by <xref href="SadConsole.ICellSurface.ConnectedLineIndex" data-throw-if-not-resolved="false"></xref>.

`area` SadRogue.Primitives.Rectangle  
The area to process.


### Copy(ISurface, ICellSurface)

Copies the contents of the cell surface to the destination.

```csharp title="C#"
public static void Copy(this ISurface obj, ICellSurface destination)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`destination` [ICellSurface](../sadconsole.icellsurface/)  
The destination obj.Surface.

#### Remarks

If the sizes to not match, it will always start at 0,0 and work with what it can and move on to the next row when either surface runs out of columns being processed

### Copy(ISurface, ICellSurface, int, int)

Copies the contents of the cell surface to the destination at the specified x,y.

```csharp title="C#"
public static void Copy(this ISurface obj, ICellSurface destination, int x, int y)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`destination` [ICellSurface](../sadconsole.icellsurface/)  
The destination obj.Surface.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate of the destination.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate of the destination.


### Copy(ISurface, Rectangle, ICellSurface, int, int)

Copies an area of this cell surface to the destination surface.

```csharp title="C#"
public static void Copy(this ISurface obj, Rectangle area, ICellSurface destination, int destinationX, int destinationY)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`area` SadRogue.Primitives.Rectangle  
The area to copy.

`destination` [ICellSurface](../sadconsole.icellsurface/)  
The destination obj.Surface.

`destinationX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate to copy to.

`destinationY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate to copy to.


### Copy(ISurface, int, int, int, int, ICellSurface, int, int)

Copies the contents of this cell surface at the specified x,y coordinates to the destination, only with the specified obj.Surface.BufferWidth and obj.Surface.BufferHeight, and copies it to the specified `destinationX` and `destinationY` position.

```csharp title="C#"
public static void Copy(this ISurface obj, int x, int y, int width, int height, ICellSurface destination, int destinationX, int destinationY)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate to start from.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate to start from.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The BufferWidth to copy from.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The BufferHeight to copy from.

`destination` [ICellSurface](../sadconsole.icellsurface/)  
The destination obj.Surface.

`destinationX` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x coordinate to copy to.

`destinationY` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The y coordinate to copy to.


### FillWithRandomGarbage(ISurface, IFont)

Fills a console with random colors and glyphs.

```csharp title="C#"
public static void FillWithRandomGarbage(this ISurface obj, IFont associatedFont)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`associatedFont` [IFont](../sadconsole.ifont/)  
The font used in assigning glyphs randomly.


### FillWithRandomGarbage(ISurface, int)

Fills a console with random colors and glyphs.

```csharp title="C#"
public static void FillWithRandomGarbage(this ISurface obj, int maxGlyphValue)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`maxGlyphValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum glyph value to use on the obj.Surface.


### FillWithRandomGarbage(ISurface, int, Rectangle)

Fills a console with random colors and glyphs.

```csharp title="C#"
public static void FillWithRandomGarbage(this ISurface obj, int maxGlyphValue, Rectangle area)
```

#### Parameters

`obj` [ISurface](../sadconsole.isurface/)  
The surface being edited.

`maxGlyphValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum glyph value to use on the obj.Surface.

`area` SadRogue.Primitives.Rectangle  
The area to fill with random garbage.


### PrintTheDraw(ICellSurface, int, string, TheDrawFont, HorizontalAlignment, int)

Prints text using [TheDrawFont](../sadconsole.readers.thedrawfont/) and horizontal alignment specified. Calculates x coordinate. Truncates string to fit it in one line.

```csharp title="C#"
public static void PrintTheDraw(this ICellSurface cellSurface, int y, string text, TheDrawFont drawFont, HorizontalAlignment alignment, int padding = 0)
```

#### Parameters

`cellSurface` [ICellSurface](../sadconsole.icellsurface/)  
Class implementing <xref href="SadConsole.ICellSurface" data-throw-if-not-resolved="false"></xref>.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y coordinate of the obj.Surface.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Text to print.

`drawFont` [TheDrawFont](../sadconsole.readers.thedrawfont/)  
Instance of the <xref href="SadConsole.Readers.TheDrawFont" data-throw-if-not-resolved="false"></xref> to use.

`alignment` [HorizontalAlignment](../sadconsole.horizontalalignment/)  
<xref href="SadConsole.HorizontalAlignment" data-throw-if-not-resolved="false"></xref> to use.

`padding` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Amount of regular font characters used as horizontal padding on both sides of the output.


### PrintTheDraw(ICellSurface, int, int, string, TheDrawFont)

Prints text using [TheDrawFont](../sadconsole.readers.thedrawfont/).

```csharp title="C#"
public static void PrintTheDraw(this ICellSurface cellSurface, int x, int y, string text, TheDrawFont drawFont)
```

#### Parameters

`cellSurface` [ICellSurface](../sadconsole.icellsurface/)  
Class implementing <xref href="SadConsole.ICellSurface" data-throw-if-not-resolved="false"></xref>.

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
X coordinate of the obj.Surface.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Y coordinate of the obj.Surface.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Text to print.

`drawFont` [TheDrawFont](../sadconsole.readers.thedrawfont/)  
Instance of the <xref href="SadConsole.Readers.TheDrawFont" data-throw-if-not-resolved="false"></xref> to use.