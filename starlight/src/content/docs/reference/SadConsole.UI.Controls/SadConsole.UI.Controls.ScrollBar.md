---
title: ScrollBar Class
slug: reference/sadconsole.ui.controls.scrollbar
sidebar:
  label: ScrollBar
---
## Definition

Represents a scrollbar control.

```csharp title="C#"
[DataContract]
public class ScrollBar : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### ScrollBar(Orientation, int)

Creates a new Slider control

```csharp title="C#"
public ScrollBar(Orientation orientation, int size)
```

#### Parameters

`orientation` [Orientation](../sadconsole.orientation/)  
Sets the control to either horizontal or vertical.

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height or width of the control, based on the <code class="paramref">orientation</code>, with a thickness of 1.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
Size of the control must be 2 or more


### ScrollBar(Orientation, int, int)

Creates a new Slider control with the specified width and height.

```csharp title="C#"
public ScrollBar(Orientation orientation, int width, int height)
```

#### Parameters

`orientation` [Orientation](../sadconsole.orientation/)  
Sets the control to either horizontal or vertical.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the control.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  
With a horizontal Slider, width must be 2 or more. With a vertical Slider, height must be 2 or more.


## Properties

### Orientation

Indicates if the slider is horizontal or vertical.

```csharp title="C#"
[DataMember]
public Orientation Orientation { get; }
```

### IsGripped

When true, indicates that the mouse is gripping the slider to scroll.

```csharp title="C#"
public bool IsGripped { get; }
```

### MaximumValue

Gets or sets the maximum value for the scrollbar.

```csharp title="C#"
[DataMember]
public int MaximumValue { get; set; }
```

### ArrowStep

Gets or sets the amount of values to add or subtract to the [Value](../sadconsole.ui.controls.scrollbar/#value/) when the up or down arrows are used.

```csharp title="C#"
[DataMember]
public int ArrowStep { get; set; }
```

### MouseWheelStep

Gets or sets the amount of values to add or subtract to the [Value](../sadconsole.ui.controls.scrollbar/#value/) when the up or down arrows are used.

```csharp title="C#"
[DataMember]
public int MouseWheelStep { get; set; }
```

### Value

Gets or sets the value of the slider between the minimum and maximum values.

```csharp title="C#"
[DataMember]
public int Value { get; set; }
```

### ArrowsMoveGrip

When true, the arrow buttons simply move the grip instead of using the [ArrowStep](../sadconsole.ui.controls.scrollbar/#arrowstep/) value to adjust the value.

```csharp title="C#"
[DataMember]
public bool ArrowsMoveGrip { get; set; }
```

### MouseWheelMovesGrip

When true, the mouse wheelsimply moves the grip instead of using the [MouseWheelStep](../sadconsole.ui.controls.scrollbar/#mousewheelstep/) value to adjust the value.

```csharp title="C#"
[DataMember]
public bool MouseWheelMovesGrip { get; set; }
```

### Style

The style applied to drawing the control.

```csharp title="C#"
[DataMember]
public ScrollBar.ThemeStyle Style { get; set; }
```

## Methods

### OnValueChanged()

Invokes the [ValueChanged](../sadconsole.ui.controls.scrollbar/#valuechanged/) event.

```csharp title="C#"
protected void OnValueChanged()
```


### CalculateGripSize()

Sets the bar and grip sizes of the control.

```csharp title="C#"
protected void CalculateGripSize()
```


### SetGripToValue()

Moves the grip position based on the [Value](../sadconsole.ui.controls.scrollbar/#value/) property.

```csharp title="C#"
protected void SetGripToValue()
```


### OnResized()

Resizes the control and recalculates the grip size.

```csharp title="C#"
protected override void OnResized()
```


### SetValue(int, bool)

Sets the value of the control without using the [Value](../sadconsole.ui.controls.scrollbar/#value/) property. Optionally calls [SetGripToValue()](../sadconsole.ui.controls.scrollbar/#setgriptovalue/).

```csharp title="C#"
protected void SetValue(int value, bool setGrip = true)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The value to set.

`setGrip` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Moves the grip when true.


### IncreaseValue(int)

Increases the value by the specified amount.

```csharp title="C#"
public void IncreaseValue(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The value to add to <xref href="SadConsole.UI.Controls.ScrollBar.Value" data-throw-if-not-resolved="false"></xref>.


### DecreaseValue(int)

Decreases the value by the specified amount.

```csharp title="C#"
public void DecreaseValue(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The value to subract from <xref href="SadConsole.UI.Controls.ScrollBar.Value" data-throw-if-not-resolved="false"></xref>.


### IncreaseGripByOne()

Increases the grip position by one and sets the value.

```csharp title="C#"
public void IncreaseGripByOne()
```


### DecreaseGripByOne()

Decreases the grip position by one and sets the value.

```csharp title="C#"
public void DecreaseGripByOne()
```


### ProcessMouseWheel(MouseScreenObjectState)

Processes the mouse wheel values regardless of if the mouse is over the scrollbar or not.

```csharp title="C#"
public bool ProcessMouseWheel(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The mouse state.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True if the mouse wheel was processed.

### ProcessMouse(MouseScreenObjectState)

Checks if the mouse is the control and calls the appropriate mouse methods.

```csharp title="C#"
public override bool ProcessMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Mouse information.

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

### ValueChanged

Raised when the [Value](../sadconsole.ui.controls.scrollbar/#value/) property changes.

```csharp title="C#"
public event EventHandler? ValueChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)