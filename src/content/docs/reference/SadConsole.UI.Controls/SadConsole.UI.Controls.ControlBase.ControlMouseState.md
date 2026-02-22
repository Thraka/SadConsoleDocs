---
title: ControlBase.ControlMouseState Class
slug: reference/sadconsole.ui.controls.controlbase.controlmousestate
sidebar:
  label: ControlBase.ControlMouseState
editUrl: false
description: Mouse state based on a specific control.
---
## Definition

Mouse state based on a specific control.

```csharp title="C#"
public class ControlBase.ControlMouseState
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ControlMouseState(ControlBase, Point, MouseScreenObjectState)

Creates an instance of the mouse control state class.

```csharp title="C#"
public ControlMouseState(ControlBase control, Point mousePosition, MouseScreenObjectState originalMouseState)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control.

`mousePosition` SadRogue.Primitives.Point  
The position of the mouse relative to the control.

`originalMouseState` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The original mouse state sent to the control.


### ControlMouseState(ControlBase, MouseScreenObjectState)

Creates an instance of the mouse control state class and infers the [MousePosition](../sadconsole.ui.controls.controlbase.controlmousestate/#mouseposition) from the control and state.

```csharp title="C#"
public ControlMouseState(ControlBase control, MouseScreenObjectState originalMouseState)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control.

`originalMouseState` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The original mouse state sent to the control.


## Properties

### Control

The control this mouse state is associated with.

```csharp title="C#"
public ControlBase Control { get; set; }
```

### MousePosition

The relative position of the mouse to the control.

```csharp title="C#"
public Point MousePosition { get; set; }
```

### OriginalMouseState

The original mouse state used to generate the event.

```csharp title="C#"
public MouseScreenObjectState OriginalMouseState { get; set; }
```

### IsMouseOver

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the mouse is over the [Control](../sadconsole.ui.controls.controlbase.controlmousestate/#control); othwerise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsMouseOver { get; set; }
```