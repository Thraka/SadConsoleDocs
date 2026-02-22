---
title: SurfaceViewer Class
slug: reference/sadconsole.ui.controls.surfaceviewer
sidebar:
  label: SurfaceViewer
editUrl: false
description: Draws a `SadConsole.ICellSurface` within an area. Optionally supports scroll bars.
---
## Definition

Draws a [ICellSurface](../sadconsole.icellsurface/) within an area. Optionally supports scroll bars.

```csharp title="C#"
[DataContract]
public class SurfaceViewer : CompositeControl, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [CompositeControl](../sadconsole.ui.controls.compositecontrol/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### SurfaceViewer(int, int, ICellSurface?)

Creates a new drawing surface control with the specified width and height.

```csharp title="C#"
public SurfaceViewer(int width, int height, ICellSurface? surface = null)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control.

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface to view.


## Fields

### HorizontalScroller

The horizontal scroll bar. This shouldn't be changed.

```csharp title="C#"
public ScrollBar HorizontalScroller
```

### VerticalScroller

The vertical scroll bar. This shouldn't be changed.

```csharp title="C#"
public ScrollBar VerticalScroller
```

## Properties

### ScrollBarMode

Sets the visual behavior of the scroll bars for the control.

```csharp title="C#"
[DataMember]
public SurfaceViewer.ScrollBarModes ScrollBarMode { get; set; }
```

## Methods

### ResetSurface()

Resets the control's surface to a 1x1 surface transparent surface.

```csharp title="C#"
public void ResetSurface()
```


### OnSurfaceChanged(ICellSurface, ICellSurface)

Handles and dehandles the [IsDirtyChanged](../sadconsole.icellsurface/#isdirtychanged) event for the backing surface.

```csharp title="C#"
protected override void OnSurfaceChanged(ICellSurface oldSurface, ICellSurface newSurface)
```

#### Parameters

`oldSurface` [ICellSurface](../sadconsole.icellsurface/)  
The previous surface instance.

`newSurface` [ICellSurface](../sadconsole.icellsurface/)  
The new surface instance.


### UpdateAndRedraw(TimeSpan)

Updates each control hosted by this control.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The game frame time delta.