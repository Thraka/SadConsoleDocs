---
title: CellSurface Class
slug: reference/sadconsole.cellsurface
sidebar:
  label: CellSurface
---
## Definition

An array of [ColoredGlyphBase](../sadconsole.coloredglyphbase/) objects used to represent a 2D surface.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class CellSurface : ICellSurface, IGridView<ColoredGlyphBase>, IEnumerable<ColoredGlyphBase>, IEnumerable, ISurface, ICellSurfaceResize, ICellSurfaceSettable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [ICellSurface](../sadconsole.icellsurface/), [IGridView\<ColoredGlyphBase\>](../sadconsole.coloredglyphbase/), [IEnumerable\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/), [ISurface](../sadconsole.isurface/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/), [ICellSurfaceSettable](../sadconsole.icellsurfacesettable/)

## Constructors

### CellSurface(int, int)

Creates a new surface with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public CellSurface(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface in cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface in cells.


### CellSurface(int, int, ColoredGlyphBase[])

Creates a new surface with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public CellSurface(int width, int height, ColoredGlyphBase[] initialCells)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface in cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface in cells.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The cells to seed the surface with. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, creates the cell array for you.


### CellSurface(int, int, int, int)

Creates a new surface with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public CellSurface(int viewWidth, int viewHeight, int totalWidth, int totalHeight)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible width of the surface in cells.

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible height of the surface in cells.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the surface in cells.

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the surface in cells.


### CellSurface(int, int, int, int, ColoredGlyphBase[]?)

Creates a new surface with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public CellSurface(int viewWidth, int viewHeight, int totalWidth, int totalHeight, ColoredGlyphBase[]? initialCells)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface in cells.

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface in cells.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the surface in cells.

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the surface in cells.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The cells to seed the surface with. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, creates the cell array for you.


### CellSurface(IGridView<ColoredGlyphBase>, int, int)

Creates a new surface from a grid view with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public CellSurface(IGridView<ColoredGlyphBase> surface, int visibleWidth = 0, int visibleHeight = 0)
```

#### Parameters

`surface` [IGridView\<ColoredGlyphBase\>](../sadconsole.coloredglyphbase/)  
The surface to use as the source of cells.

`visibleWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Optional view width. If <code>0</code>, the view width matches the width of the surface.

`visibleHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Optional view height. If <code>0</code>, the view width matches the height of the surface.


## Fields

### _viewArea

The width and height of the surface along with the viewable area.

```csharp title="C#"
[DataMember(Name = "AreaBounds")]
protected BoundedRectangle _viewArea
```

## Properties

### TimesShiftedDown

A variable that tracks how many times this editor shifted the surface down.

```csharp title="C#"
[DataMember]
public int TimesShiftedDown { get; set; }
```

### TimesShiftedRight

A variable that tracks how many times this editor shifted the surface right.

```csharp title="C#"
[DataMember]
public int TimesShiftedRight { get; set; }
```

### TimesShiftedLeft

A variable that tracks how many times this editor shifted the surface left.

```csharp title="C#"
[DataMember]
public int TimesShiftedLeft { get; set; }
```

### TimesShiftedUp

A variable that tracks how many times this editor shifted the surface up.

```csharp title="C#"
[DataMember]
public int TimesShiftedUp { get; set; }
```

### UsePrintProcessor

When true, the [Parser](../sadconsole.coloredstring/#parser/) is used to generate a [ColoredString](../sadconsole.coloredstring/) before printing.

```csharp title="C#"
[DataMember]
public bool UsePrintProcessor { get; set; }
```

### Surface

Returns this object.

```csharp title="C#"
[IgnoreDataMember]
public ICellSurface Surface { get; }
```

### Effects

Processes the effects added to cells with `CellSurfaceEditor.SetEffect*`.

```csharp title="C#"
[IgnoreDataMember]
public EffectsManager Effects { get; protected set; }
```

### IsDirty

Indicates the surface has changed and needs to be rendered.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### DefaultForeground

The default foreground for glyphs on this surface.

```csharp title="C#"
[DataMember]
public Color DefaultForeground { get; set; }
```

### DefaultBackground

The default background for glyphs on this surface.

```csharp title="C#"
[DataMember]
public Color DefaultBackground { get; set; }
```

### DefaultGlyph

The default glyph used in clearing and erasing.

```csharp title="C#"
[DataMember]
public int DefaultGlyph { get; set; }
```

### View

The visible portion of the surface.

```csharp title="C#"
public Rectangle View { get; set; }
```

### ViewWidth

Gets or sets the visible width of the surface in cells.

```csharp title="C#"
public int ViewWidth { get; set; }
```

### ViewHeight

Gets or sets the visible height of the surface in cells.

```csharp title="C#"
public int ViewHeight { get; set; }
```

### Area

Returns a rectangle that represents the entire size of the surface.

```csharp title="C#"
public Rectangle Area { get; }
```

### Width

The total width of the surface.

```csharp title="C#"
public int Width { get; }
```

### Height

The total height of the surface.

```csharp title="C#"
public int Height { get; }
```

### IsScrollable

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the [View](../sadconsole.icellsurface/#view/) width or height is different from [Area](../sadconsole.icellsurface/#area/); otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsScrollable { get; }
```

### ViewPosition

The position of the view within the buffer.

```csharp title="C#"
public Point ViewPosition { get; set; }
```

### Cells

```csharp title="C#"
[DataMember]
public ColoredGlyphBase[] Cells { get; protected set; }
```

### Count

The count of glyphs this surface contains.

```csharp title="C#"
public int Count { get; }
```

### this[int, int]

```csharp title="C#"
public ColoredGlyphBase this[int x, int y] { get; protected set; }
```

### this[int]

```csharp title="C#"
public ColoredGlyphBase this[int index] { get; protected set; }
```

### this[Point]

```csharp title="C#"
public ColoredGlyphBase this[Point position] { get; protected set; }
```

### this[Range]

Given a position, returns the "value" associated with that location.

```csharp title="C#"
public Span<ColoredGlyphBase> this[Range range] { get; }
```

## Methods

### Resize(int, int, bool)

Resizes the surface and view to the specified width and height. This can destroy the original backing array.

```csharp title="C#"
public void Resize(int viewWidth, int viewHeight, bool clear)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`clear` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates each cell should be reset to the default values.


### Resize(int, int, int, int, bool)

Resizes the surface to the specified width and height. This can destroy the original backing array.

```csharp title="C#"
public void Resize(int viewWidth, int viewHeight, int totalWidth, int totalHeight, bool clear)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable width of the surface.

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable height of the surface.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum width of the surface.

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum height of the surface.

`clear` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates each cell should be reset to the default values.


### SetSurface(ICellSurface, Rectangle)

Remaps the cells of this surface to a view of the `surface`.

```csharp title="C#"
public void SetSurface(ICellSurface surface, Rectangle view = default)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The target surface to map cells from.

`view` SadRogue.Primitives.Rectangle  
A view rectangle of the target surface.


### SetSurface(ColoredGlyphBase[], int, int, int, int)

Changes the cells of the surface to the provided array.

```csharp title="C#"
public void SetSurface(ColoredGlyphBase[] cells, int width, int height, int bufferWidth, int bufferHeight)
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


### SetIsDirtySafe()

Sets [IsDirty](../sadconsole.cellsurface/#isdirty/) to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> without triggering [OnIsDirtyChanged()](../sadconsole.cellsurface/#onisdirtychanged/).

```csharp title="C#"
protected void SetIsDirtySafe()
```


### OnIsDirtyChanged()

Called when the [IsDirty](../sadconsole.cellsurface/#isdirty/) property changes.

```csharp title="C#"
protected virtual void OnIsDirtyChanged()
```


### OnCellsReset()

Called when the [Cells](../sadconsole.cellsurface/#cells/) property is reset.

```csharp title="C#"
protected virtual void OnCellsReset()
```


### GetEnumerator()

Gets an enumerator for [Cells](../sadconsole.cellsurface/#cells/).

```csharp title="C#"
public IEnumerator<ColoredGlyphBase> GetEnumerator()
```

#### Returns

[IEnumerator\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)  
An enumerator for [Cells](../sadconsole.cellsurface/#cells/).

## Events

### IsDirtyChanged

An event that is raised when [IsDirty](../sadconsole.icellsurface/#isdirty/) changes.

```csharp title="C#"
public event EventHandler? IsDirtyChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)