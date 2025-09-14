---
title: NumberBox Class
slug: reference/sadconsole.ui.controls.numberbox
sidebar:
  label: NumberBox
---
## Definition

InputBox control that allows text input.

```csharp title="C#"
[DataContract]
public class NumberBox : TextBox
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [TextBox](../sadconsole.ui.controls.textbox/)

## Constructors

### NumberBox(int)

Creates a new instance of the input box.

```csharp title="C#"
public NumberBox(int width)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the input box.


## Fields

### _allowDecimalPoint

Indicates that the input box (when numeric) will accept decimal points.

```csharp title="C#"
[DataMember(Name = "AllowDecimalPoint")]
protected bool _allowDecimalPoint
```

## Properties

### AllowDecimal

Gets or sets whether or not this input box should restrict numeric input should allow a decimal point.

```csharp title="C#"
public bool AllowDecimal { get; set; }
```

### NumberMaximum

The maximum number that can be set for this text box.

```csharp title="C#"
[DataMember]
public long NumberMaximum { get; set; }
```
## Remarks

Set both [NumberMaximum](../sadconsole.ui.controls.numberbox/#numbermaximum/) and [NumberMinimum](../sadconsole.ui.controls.numberbox/#numberminimum/) to 0 to disable number bounds checking.

### NumberMinimum

The minimum number that can be set for this text box.

```csharp title="C#"
[DataMember]
public long NumberMinimum { get; set; }
```
## Remarks

Set both [NumberMaximum](../sadconsole.ui.controls.numberbox/#numbermaximum/) and [NumberMinimum](../sadconsole.ui.controls.numberbox/#numberminimum/) to 0 to disable number bounds checking.

### DefaultValue

The default value to use when the current value is invalid and [AllowDecimal](../sadconsole.ui.controls.numberbox/#allowdecimal/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public long DefaultValue { get; set; }
```

### DefaultDecimalValue

The default value to use when the current value is invalid and [AllowDecimal](../sadconsole.ui.controls.numberbox/#allowdecimal/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
[DataMember]
public double DefaultDecimalValue { get; set; }
```

### ShowUpDownButtons

When true, displays up and down buttons at the end of the box.

```csharp title="C#"
[DataMember]
public bool ShowUpDownButtons { get; set; }
```

### UpButtonStep

Sets the up button's value step.

```csharp title="C#"
[DataMember]
public long UpButtonStep { get; set; }
```

### DownButtonStep

Sets the down button's value step.

```csharp title="C#"
[DataMember]
public long DownButtonStep { get; set; }
```

### UpButtonStepDecimal

Sets the up button's value step when [AllowDecimal](../sadconsole.ui.controls.numberbox/#allowdecimal/) is on.

```csharp title="C#"
[DataMember]
public double UpButtonStepDecimal { get; set; }
```

### DownButtonStepDecimal

Sets the down button's value step when [AllowDecimal](../sadconsole.ui.controls.numberbox/#allowdecimal/) is on.

```csharp title="C#"
[DataMember]
public double DownButtonStepDecimal { get; set; }
```

### IsEditingNumberInvalid

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the number is either out of bounds of the [NumberMinimum](../sadconsole.ui.controls.numberbox/#numberminimum/) and [NumberMaximum](../sadconsole.ui.controls.numberbox/#numbermaximum/) range, or it can't be property parsed. Otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>

```csharp title="C#"
public bool IsEditingNumberInvalid { get; }
```
## Remarks

Used by the theme system.

### State_IsMouseOverUpButton

Used by the mouse logic.

```csharp title="C#"
public bool State_IsMouseOverUpButton { get; set; }
```

### State_IsMouseOverDownButton

Used by the mouse logic.

```csharp title="C#"
public bool State_IsMouseOverDownButton { get; set; }
```

### NumberBoxInvalidNumberForeground

The color to use with a [NumberBox](../sadconsole.ui.controls.numberbox/) control when [IsEditingNumberInvalid](../sadconsole.ui.controls.numberbox/#iseditingnumberinvalid/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
[DataMember]
public Color? NumberBoxInvalidNumberForeground { get; set; }
```

### UpButtonGlyph

The glyph for the up button.

```csharp title="C#"
[DataMember]
public int UpButtonGlyph { get; set; }
```

### DownButtonGlyph

The glyph for the down button.

```csharp title="C#"
[DataMember]
public int DownButtonGlyph { get; set; }
```

## Methods

### IncreaseNumber(long)

Increases the number stored in the [Text](../sadconsole.ui.controls.textbox/#text/) property by the specified amount.

```csharp title="C#"
public void IncreaseNumber(long amount)
```

#### Parameters

`amount` [long](https://learn.microsoft.com/dotnet/api/system.int64/)  
The amount.


### IncreaseNumber(double)

Increases the number stored in the [Text](../sadconsole.ui.controls.textbox/#text/) property by the specified amount.

```csharp title="C#"
public void IncreaseNumber(double amount)
```

#### Parameters

`amount` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The amount.

#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when this method is used and the [AllowDecimal](../sadconsole.ui.controls.numberbox/#allowdecimal/) property is set to false.


### DecreaseNumber(long)

Decreases the number stored in the [Text](../sadconsole.ui.controls.textbox/#text/) property by the specified amount.

```csharp title="C#"
public void DecreaseNumber(long amount)
```

#### Parameters

`amount` [long](https://learn.microsoft.com/dotnet/api/system.int64/)  
The amount.


### DecreaseNumber(double)

Decreases the number stored in the [Text](../sadconsole.ui.controls.textbox/#text/) property by the specified amount.

```csharp title="C#"
public void DecreaseNumber(double amount)
```

#### Parameters

`amount` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The amount.

#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when this method is used and the [AllowDecimal](../sadconsole.ui.controls.numberbox/#allowdecimal/) property is set to false.


### OnFocused()

Called when the control is focused.

```csharp title="C#"
protected override void OnFocused()
```


### OnUnfocused()

Called when the control loses focus.

```csharp title="C#"
protected override void OnUnfocused()
```


### TextAsLong()

Returns the [Text](../sadconsole.ui.controls.textbox/#text/) property as parsed by `System.Int64.TryParse(System.String%2cSystem.Globalization.NumberStyles%2cSystem.IFormatProvider%2cSystem.Int64%40)` with the current culture.

```csharp title="C#"
public long TextAsLong()
```

#### Returns

[long](https://learn.microsoft.com/dotnet/api/system.int64/)  
The parsed text value.

### TextAsDouble()

Returns the [Text](../sadconsole.ui.controls.textbox/#text/) property as parsed by `System.Double.TryParse(System.String%2cSystem.Globalization.NumberStyles%2cSystem.IFormatProvider%2cSystem.Double%40)` with the current culture.

```csharp title="C#"
public double TextAsDouble()
```

#### Returns

[double](https://learn.microsoft.com/dotnet/api/system.double/)  
The parsed text value.

### ProcessKeyboard(Keyboard)

Called when the control should process keyboard information.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard info)
```

#### Parameters

`info` [Keyboard](../sadconsole.input.keyboard/)  
The keyboard information.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True if the keyboard was handled by this control.

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

### OnResized()

Called when `SadConsole.UI.Controls.ControlBase.Resize(System.Int32%2cSystem.Int32)` was called.

```csharp title="C#"
protected override void OnResized()
```


### GetCultureDecimalSeperator()

Gets the current culture's decimal separator.

```csharp title="C#"
protected char GetCultureDecimalSeperator()
```

#### Returns

[char](https://learn.microsoft.com/dotnet/api/system.char/)  
The current culture.

### GetCulture()

Returns the current culture.

```csharp title="C#"
protected CultureInfo GetCulture()
```

#### Returns

[CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo/)  
The current culture.

### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.