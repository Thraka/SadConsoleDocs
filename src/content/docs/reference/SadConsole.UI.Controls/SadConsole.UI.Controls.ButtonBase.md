---
title: ButtonBase Class
slug: reference/sadconsole.ui.controls.buttonbase
sidebar:
  label: ButtonBase
editUrl: false
description: Base class for creating a button type control.
---
## Definition

Base class for creating a button type control.

```csharp title="C#"
[DataContract]
public abstract class ButtonBase : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### ButtonBase(int, int)

Creates a new button control.

```csharp title="C#"
protected ButtonBase(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the button.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the button.


### ButtonBase()

Creates a new button control with [AutoSize](../sadconsole.ui.controls.buttonbase/#autosize) set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
protected ButtonBase()
```


## Fields

### _textAlignment

The alignment of the ``SadConsole.UI.Controls.ButtonBase._text``.

```csharp title="C#"
protected HorizontalAlignment _textAlignment
```

## Properties

### Text

The text displayed on the control.

```csharp title="C#"
[DataMember]
public string Text { get; set; }
```

### AutoSize

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, automatically resizes the surface to fit the [Text](../sadconsole.ui.controls.buttonbase/#text).

```csharp title="C#"
[DataMember]
public bool AutoSize { get; set; }
```

### TextAlignment

The alignment of the text, left, center, or right.

```csharp title="C#"
[DataMember]
public HorizontalAlignment TextAlignment { get; set; }
```

## Methods

### OnClick()

Raises the [Click](../sadconsole.ui.controls.buttonbase/#click) event.

```csharp title="C#"
protected virtual void OnClick()
```


### InvokeClick(bool)

Simulates a mouse click on the button. Optionally, focuses the button prior to simulating the click.

```csharp title="C#"
public void InvokeClick(bool focus = false)
```

#### Parameters

`focus` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, focuses the button before clicking.


### ProcessKeyboard(Keyboard)

Detects if the SPACE or ENTER keys are pressed and calls the [Click](../sadconsole.ui.controls.buttonbase/#click) method.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard info)
```

#### Parameters

`info` [Keyboard](../sadconsole.input.keyboard/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### OnMouseIn(ControlMouseState)

Called as the mouse moves around the control area. Raises the MouseMove event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnMouseIn(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnLeftMouseClicked(ControlMouseState)

Called when the left mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnLeftMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnMouseExit(ControlMouseState)

Called when the mouse exits the area of the control. Raises the MouseExit event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnMouseExit(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


## Events

### Click

Raised when the button is clicked.

```csharp title="C#"
public event EventHandler? Click
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)