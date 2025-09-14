---
title: Table Class
slug: reference/sadconsole.ui.controls.table
sidebar:
  label: Table
---
## Definition

A scrollable table control.

```csharp title="C#"
public class Table : CompositeControl, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [CompositeControl](../sadconsole.ui.controls.compositecontrol/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### Table(int, int)

Creates a new table with the default SadConsole colors, and cell size of (1 width, 1 height)

```csharp title="C#"
public Table(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### Table(int, int, int, int)

Creates a new table with custom cell width and cell height params; Uses the default SadConsole colors

```csharp title="C#"
public Table(int width, int height, int cellWidth, int cellHeight = 1)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`cellWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`cellHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### Table(int, int, int, Color, Color, int)

Creates a new table with extra params to set the base default values of the table

```csharp title="C#"
public Table(int width, int height, int cellWidth, Color defaultForeground, Color defaultBackground, int cellHeight = 1)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`cellWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`defaultForeground` SadRogue.Primitives.Color  

`defaultBackground` SadRogue.Primitives.Color  

`cellHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


## Properties

### Cells

The cells collection used to modify the table cells

```csharp title="C#"
public Table.TableCells Cells { get; }
```

### DefaultForeground

The default foreground color used for the table foreground and newly created cells

```csharp title="C#"
public Color DefaultForeground { get; set; }
```

### DefaultBackground

The default background color used for the table background and newly created cells

```csharp title="C#"
public Color DefaultBackground { get; set; }
```

### DefaultCellSize

The default size a cell gets when it is newly created

```csharp title="C#"
public Point DefaultCellSize { get; set; }
```

### DefaultHoverMode

The default visual hovering mode when hovering over cells

```csharp title="C#"
public Table.TableCells.Layout.Mode DefaultHoverMode { get; set; }
```

### DefaultSelectionMode

The default visual selection mode when selecting a cell

```csharp title="C#"
public Table.TableCells.Layout.Mode DefaultSelectionMode { get; set; }
```

### UseMouse

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, this object will use the mouse; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool UseMouse { get; set; }
```

### CurrentMouseCell

Returns the cell the mouse is over, if [UseMouse](../sadconsole.ui.controls.table/#usemouse/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public Table.Cell? CurrentMouseCell { get; }
```

### SelectedCell

Returns the current selected cell

```csharp title="C#"
public Table.Cell? SelectedCell { get; }
```

### DrawFakeCells

By default, only cells that have been modified in anyway will be rendered on the table control. Turn this off, if the whole table should draw as many cells as it fits with their default layout.

```csharp title="C#"
public bool DrawFakeCells { get; set; }
```

### VerticalScrollBar

The vertical scrollbar, use the SetupScrollBar method with Vertical orientation to initialize it.

```csharp title="C#"
public ScrollBar? VerticalScrollBar { get; }
```

### HorizontalScrollBar

The horizontal scrollbar, use the SetupScrollBar method with Horizontal orientation to initialize it.

```csharp title="C#"
public ScrollBar? HorizontalScrollBar { get; }
```

### IsVerticalScrollBarVisible

Returns true if the vertical scroll bar is currently visible.

```csharp title="C#"
public bool IsVerticalScrollBarVisible { get; }
```

### IsHorizontalScrollBarVisible

Returns true if the horizontal scroll bar is currently visible.

```csharp title="C#"
public bool IsHorizontalScrollBarVisible { get; }
```

### VerticalScrollBarMaximum

The updated maximum value, incase the scrollbar object's maximum value is not yet updated by the theme.

```csharp title="C#"
public int VerticalScrollBarMaximum { get; }
```

### HorizontalScrollBarMaximum

The updated maximum value, incase the scrollbar object's maximum value is not yet updated by the theme.

```csharp title="C#"
public int HorizontalScrollBarMaximum { get; }
```

### AutoScrollOnCellSelection

By default the table will automatically scroll to the selected cell if possible.

```csharp title="C#"
public bool AutoScrollOnCellSelection { get; set; }
```

## Methods

### SetupScrollBar(Orientation, int, Point)

Configures the associated [VerticalScrollBar](../sadconsole.ui.controls.table/#verticalscrollbar/).

```csharp title="C#"
public void SetupScrollBar(Orientation orientation, int size, Point position)
```

#### Parameters

`orientation` [Orientation](../sadconsole.orientation/)  
The orientation of the scrollbar.

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`position` SadRogue.Primitives.Point  
The position of the scrollbar.


### ScrollToSelectedItem()

Scrolls the list to the item currently selected.

```csharp title="C#"
public void ScrollToSelectedItem()
```


### OnMouseIn(ControlMouseState)

Called as the mouse moves around the control area. Raises the MouseMove event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnMouseIn(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnLeftMouseClicked(ControlMouseState)

Called when the left mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnLeftMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnRightMouseClicked(ControlMouseState)

Called when the right mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnRightMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data.


### OnMouseExit(ControlMouseState)

Called when the mouse exits the area of the control. Raises the MouseExit event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnMouseExit(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### UpdateAndRedraw(TimeSpan)

Updates each control hosted by this control.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The game frame time delta.


### GetOldRowAndColumnValues(List<((int x, int y), (int row, int col))>?, Point, ref int, ref int)

```csharp title="C#"
protected void GetOldRowAndColumnValues(List<((int x, int y), (int row, int col))>? fakeCells, Point cellPosition, ref int oldRow, ref int oldCol)
```

#### Parameters

`fakeCells` [List\<((int x, int y), (int row, int col))\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  

`cellPosition` SadRogue.Primitives.Point  

`oldRow` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`oldCol` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### SetScrollBarVisibility(int, int)

```csharp title="C#"
protected void SetScrollBarVisibility(int maxRowsHeight, int maxColumnsWidth)
```

#### Parameters

`maxRowsHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`maxColumnsWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### GetCustomStateAppearance(Cell)

```csharp title="C#"
protected ColoredGlyphBase? GetCustomStateAppearance(Table.Cell cell)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)

### AdjustControlSurface(Cell, ColoredGlyphBase?, bool)

```csharp title="C#"
protected void AdjustControlSurface(Table.Cell cell, ColoredGlyphBase? customStateAppearance, bool adjustVisibility)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  

`customStateAppearance` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  

`adjustVisibility` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### HideVisualCell(int, int, Point)

```csharp title="C#"
protected void HideVisualCell(int column, int row, Point position)
```

#### Parameters

`column` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`row` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`position` SadRogue.Primitives.Point  


### PrintText(Cell)

```csharp title="C#"
protected void PrintText(Table.Cell cell)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  


### GetTotalCellSize(Cell, int, int, out int, out int)

```csharp title="C#"
protected static void GetTotalCellSize(Table.Cell cell, int width, int height, out int totalWidth, out int totalHeight)
```

#### Parameters

`cell` [Table.Cell](../sadconsole.ui.controls.table/)  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### GetHorizontalAlignment(HorizontalAlign, int, char[])

```csharp title="C#"
protected static int GetHorizontalAlignment(Table.Cell.Options.HorizontalAlign hAlign, int totalWidth, char[] textArr)
```

#### Parameters

`hAlign` [Table.Cell.Options.HorizontalAlign](../sadconsole.ui.controls.table/)  

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`textArr` [char[]](https://learn.microsoft.com/dotnet/api/system.char/)  

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

## Events

### OnCellEnter

Fires an event when a cell is entered by the mouse.

```csharp title="C#"
public event EventHandler<Table.CellEventArgs>? OnCellEnter
```

#### Event Type

[EventHandler\<Table.CellEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### OnCellExit

Fires an event when a cell is exited by the mouse.

```csharp title="C#"
public event EventHandler<Table.CellEventArgs>? OnCellExit
```

#### Event Type

[EventHandler\<Table.CellEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### SelectedCellChanged

Fires an event when the selected cell has changed.

```csharp title="C#"
public event EventHandler<Table.CellChangedEventArgs>? SelectedCellChanged
```

#### Event Type

[EventHandler\<Table.CellChangedEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### OnCellLeftClick

Fires an event when a cell is left clicked.

```csharp title="C#"
public event EventHandler<Table.CellEventArgs>? OnCellLeftClick
```

#### Event Type

[EventHandler\<Table.CellEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### OnCellRightClick

Fires an event when a cell is right clicked.

```csharp title="C#"
public event EventHandler<Table.CellEventArgs>? OnCellRightClick
```

#### Event Type

[EventHandler\<Table.CellEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### OnCellDoubleClick

Fires an event when a cell is double clicked.

```csharp title="C#"
public event EventHandler<Table.CellEventArgs>? OnCellDoubleClick
```

#### Event Type

[EventHandler\<Table.CellEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### OnDrawFakeCell

Called when a fake cells is being drawn, you can use this to modify the cell layout.

```csharp title="C#"
public event EventHandler<Table.CellEventArgs>? OnDrawFakeCell
```

#### Event Type

[EventHandler\<Table.CellEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)