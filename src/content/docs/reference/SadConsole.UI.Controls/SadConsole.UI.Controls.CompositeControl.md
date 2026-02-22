---
title: CompositeControl Class
slug: reference/sadconsole.ui.controls.compositecontrol
sidebar:
  label: CompositeControl
editUrl: false
description: Base class for controls that host and render other controls.
---
## Definition

Base class for controls that host and render other controls.

```csharp title="C#"
public abstract class CompositeControl : ControlBase, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### CompositeControl(int, int)

Creates a new control with the specified width and height.

```csharp title="C#"
public CompositeControl(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control in cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control in cells.


## Fields

### MouseLastHandledByChild

```csharp title="C#"
protected bool MouseLastHandledByChild
```

### Controls

The controls this composite control is hosting. Use [AddControl(ControlBase)](../sadconsole.ui.controls.compositecontrol/#addcontrolcontrolbase) and [RemoveControl(ControlBase)](../sadconsole.ui.controls.compositecontrol/#removecontrolcontrolbase) to manage the collection.

```csharp title="C#"
protected List<ControlBase> Controls
```

### NamedControls

The controls added which contain a [Name](../sadconsole.ui.controls.controlbase/#name) value.

```csharp title="C#"
protected Dictionary<string, ControlBase> NamedControls
```

## Properties

### Count

```csharp title="C#"
public int Count { get; }
```

### this[int]

```csharp title="C#"
protected ControlBase this[int index] { get; }
```

## Methods

### CreateChildControls()

Create each control and add it to [Controls](../sadconsole.ui.controls.compositecontrol/#controls).

```csharp title="C#"
protected virtual void CreateChildControls()
```


### ProcessMouse(MouseScreenObjectState)

Processes the mouse on each control hosted by this control.

```csharp title="C#"
public override bool ProcessMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The mouse state based on the parent screen object.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when a control processes the mouse; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### OnMouseExit(ControlMouseState)

Called when the mouse exits the area of the control. Raises the MouseExit event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnMouseExit(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### AddControl(ControlBase)

Adds a child control to this control.

```csharp title="C#"
protected void AddControl(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to add.


### RemoveControl(ControlBase)

Removes a child control from this control.

```csharp title="C#"
protected void RemoveControl(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to remove.


### UpdateAndRedraw(TimeSpan)

Updates each control hosted by this control.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The game frame time delta.