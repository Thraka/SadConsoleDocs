---
title: ToggleButtonBase Class
slug: reference/sadconsole.ui.controls.togglebuttonbase
sidebar:
  label: ToggleButtonBase
---
## Definition

Base class for toggle button controls, such as [CheckBox](../sadconsole.ui.controls.checkbox/) and [RadioButton](../sadconsole.ui.controls.radiobutton/).

```csharp title="C#"
[DataContract]
public abstract class ToggleButtonBase : ButtonBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/)

## Constructors

### ToggleButtonBase(int, int)

Creates an instance of the button control with the specified width and height.

```csharp title="C#"
protected ToggleButtonBase(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control (default is 1).


### ToggleButtonBase()

Creates an automatically sized button.

```csharp title="C#"
protected ToggleButtonBase()
```


## Properties

### IsSelected

Gets or sets the selected state of the radio button.

```csharp title="C#"
public bool IsSelected { get; set; }
```
## Remarks

Radio buttons within the same group will set their IsSelected property to the opposite of this radio button when you set this property.

## Methods

### OnIsSelected()

Raises the [IsSelectedChanged](../sadconsole.ui.controls.togglebuttonbase/#isselectedchanged/) event.

```csharp title="C#"
protected virtual void OnIsSelected()
```


## Events

### IsSelectedChanged

Raised when the selected state of the radio button is changed.

```csharp title="C#"
public event EventHandler? IsSelectedChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)