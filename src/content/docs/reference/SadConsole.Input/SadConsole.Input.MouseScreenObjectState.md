---
title: MouseScreenObjectState Struct
slug: reference/sadconsole.input.mousescreenobjectstate
sidebar:
  label: MouseScreenObjectState
---
## Definition

The state of the mouse.

```csharp title="C#"
public struct MouseScreenObjectState
```


## Constructors

### MouseScreenObjectState(IScreenObject?, Mouse)

Calculates a new [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/) based on an [IScreenObject](../sadconsole.iscreenobject/) and [Mouse](../sadconsole.input.mouse/) state.

```csharp title="C#"
public MouseScreenObjectState(IScreenObject? screenObject, Mouse mouseData)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The screen object to process with the mouse state.

`mouseData` [Mouse](../sadconsole.input.mouse/)  
The current mouse state.


## Properties

### ScreenObject

The screen object used to create the mouse state.

```csharp title="C#"
public readonly IScreenObject? ScreenObject { get; }
```

### Mouse

The mouse data.

```csharp title="C#"
public readonly Mouse Mouse { get; }
```

### Cell

The cell the mouse is over, from [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public ColoredGlyphBase? Cell { readonly get; init; }
```

### CellPosition

The position of the [Cell](../sadconsole.input.mousescreenobjectstate/#cell/).

```csharp title="C#"
public Point CellPosition { readonly get; init; }
```

### SurfaceCellPosition

The position of the mouse on the [IScreenObject](../sadconsole.iscreenobject/), based on the [WorldCellPosition](../sadconsole.input.mousescreenobjectstate/#worldcellposition/) and the position of the [ScreenObject](../sadconsole.input.mousescreenobjectstate/#screenobject/).

```csharp title="C#"
public Point SurfaceCellPosition { readonly get; init; }
```

### WorldCellPosition

A cell-based location of the mouse based on the screen, not the screen object.

```csharp title="C#"
public Point WorldCellPosition { readonly get; init; }
```

### SurfacePixelPosition

The mouse position in pixels on the screen object.

```csharp title="C#"
public Point SurfacePixelPosition { readonly get; init; }
```

### IsOnScreenObject

Indicates that the mouse is within the bounds of [ScreenObject](../sadconsole.input.mousescreenobjectstate/#screenobject/).

```csharp title="C#"
public bool IsOnScreenObject { readonly get; init; }
```