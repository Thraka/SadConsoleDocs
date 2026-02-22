---
title: ColorPicker Class
slug: reference/sadconsole.ui.controls.colorpicker
sidebar:
  label: ColorPicker
editUrl: false
description: Displays a rectangle gradient area between `SadRogue.Primitives.Color.Black` and a target color, and `SadRogue.Primitives.Color.White` and a target color.
---
## Definition

Displays a rectangle gradient area between ``SadRogue.Primitives.Color.Black`` and a target color, and ``SadRogue.Primitives.Color.White`` and a target color.

```csharp title="C#"
public class ColorPicker : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### ColorPicker(int, int, Color)

Creates a new panel with the specified width, height, and master color.

```csharp title="C#"
public ColorPicker(int width, int height, Color color)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`color` SadRogue.Primitives.Color  


## Properties

### SelectedColor

The color selected by the user. A shade of [MasterColor](../sadconsole.ui.controls.colorpicker/#mastercolor).

```csharp title="C#"
public Color SelectedColor { get; }
```

### MasterColor

The main color being shown that all gradients are generated from.

```csharp title="C#"
public Color MasterColor { get; set; }
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

### SelectedColorChanged

Raised when [SelectedColor](../sadconsole.ui.controls.colorpicker/#selectedcolor) changes value.

```csharp title="C#"
public event EventHandler? SelectedColorChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)