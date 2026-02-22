---
title: ColorBar Class
slug: reference/sadconsole.ui.controls.colorbar
sidebar:
  label: ColorBar
editUrl: false
description: A color bar control.
---
## Definition

A color bar control.

```csharp title="C#"
public class ColorBar : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### ColorBar(int)

Creates a new color bar with the specified width.

```csharp title="C#"
public ColorBar(int width)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the bar.


## Fields

### _positions

Internal use by theme.

```csharp title="C#"
public int _positions
```

### _colorSteps

Internal use by theme.

```csharp title="C#"
public Color[] _colorSteps
```

## Properties

### StartingColor

Gets or sets the color on the left-side of the bar.

```csharp title="C#"
public Color StartingColor { get; set; }
```

### EndingColor

Gets or sets the color on the right-side of the bar.

```csharp title="C#"
public Color EndingColor { get; set; }
```

### SelectedColor

The selected color.

```csharp title="C#"
public Color SelectedColor { get; set; }
```

### SelectedPosition

The position on the bar currently selected.

```csharp title="C#"
public int SelectedPosition { get; }
```

## Methods

### OnMouseIn(ControlMouseState)

Called as the mouse moves around the control area. Raises the MouseMove event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnMouseIn(ControlBase.ControlMouseState info)
```

#### Parameters

`info` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  


### ProcessMouse(MouseScreenObjectState)

Checks if the mouse is the control and calls the appropriate mouse methods.

```csharp title="C#"
public override bool ProcessMouse(MouseScreenObjectState info)
```

#### Parameters

`info` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the control is enabled, set to use the mouse and the mouse is over it, otherwise false.

### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.


## Events

### ColorChanged

Raised when the [SelectedColor](../sadconsole.ui.controls.colorbar/#selectedcolor) value changes.

```csharp title="C#"
public event EventHandler? ColorChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)