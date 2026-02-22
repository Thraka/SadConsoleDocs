---
title: HueBar Class
slug: reference/sadconsole.ui.controls.huebar
sidebar:
  label: HueBar
editUrl: false
description: Displays the color hues on a bar.
---
## Definition

Displays the color hues on a bar.

```csharp title="C#"
public class HueBar : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### HueBar(int)

Creates a new hue bar control.

```csharp title="C#"
public HueBar(int width)
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

## Properties

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

Raised when the [SelectedColor](../sadconsole.ui.controls.huebar/#selectedcolor) value changes.

```csharp title="C#"
public event EventHandler? ColorChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)