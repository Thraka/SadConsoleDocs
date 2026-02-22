---
title: TextBox Class
slug: reference/sadconsole.ui.controls.textbox
sidebar:
  label: TextBox
editUrl: false
description: InputBox control that allows text input.
---
## Definition

InputBox control that allows text input.

```csharp title="C#"
[DataContract]
public class TextBox : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### TextBox(int)

Creates a new instance of the input box.

```csharp title="C#"
public TextBox(int width)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the input box.


## Fields

### _cachedBuilder

String builder used while processing text in the [ProcessKeyboard(Keyboard)](../sadconsole.ui.controls.textbox/#processkeyboardkeyboard) method.

```csharp title="C#"
protected StringBuilder? _cachedBuilder
```

### _caretPos

The location of the caret.

```csharp title="C#"
protected int _caretPos
```

### _text

The text value of the input box.

```csharp title="C#"
[DataMember(Name = "Text")]
protected string _text
```

## Properties

### Mask

Mask input with a certain character.

```csharp title="C#"
public char? Mask { get; set; }
```

### LeftDrawOffset

When editing the text box, this allows the text to scroll to the right so you can see what you are typing.

```csharp title="C#"
public int LeftDrawOffset { get; protected set; }
```

### DisableMouse

Disables mouse input.

```csharp title="C#"
[DataMember(Name = "DisableMouseInput")]
public bool DisableMouse { get; set; }
```

### DisableKeyboard

Disables the keyboard which turns off keyboard input and hides the cursor.

```csharp title="C#"
[DataMember(Name = "DisableKeyboardInput")]
public bool DisableKeyboard { get; set; }
```

### MaxLength

How big the text can be. Setting this to 0 will make it unlimited.

```csharp title="C#"
[DataMember]
public int MaxLength { get; set; }
```

### Validator

When set, validates the [Text](../sadconsole.ui.controls.textbox/#text) property after [TextChangedPreview](../sadconsole.ui.controls.textbox/#textchangedpreview) has allowed the result.

```csharp title="C#"
public StringValidation.Validator? Validator { get; set; }
```

### CaretPosition

Gets or sets the position of the caret in the current text.

```csharp title="C#"
public int CaretPosition { get; set; }
```

### Text

Gets or sets the text of the input box.

```csharp title="C#"
public string Text { get; set; }
```

### CaretEffect

The style to use for the carrot.

```csharp title="C#"
[DataMember]
public ICellEffect CaretEffect { get; set; }
```

### UseDifferentTextAreaWidth

Enables displaying the text area at a different width than the width of the control.

```csharp title="C#"
public bool UseDifferentTextAreaWidth { get; set; }
```

### TextAreaWidth

The width to display the text area at when [UseDifferentTextAreaWidth](../sadconsole.ui.controls.textbox/#usedifferenttextareawidth) is true.

```csharp title="C#"
public int TextAreaWidth { get; set; }
```

## Methods

### Resize(int, int)

Resizes the control if the [CanResize](../sadconsole.ui.controls.controlbase/#canresize) property is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public override void Resize(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired height of the control.


### ValidateCursorPosition(string)

Correctly positions the cursor within the text.

```csharp title="C#"
protected void ValidateCursorPosition(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### CheckKeyPressCancel(AsciiKey)

Raises the [KeyPressed](../sadconsole.ui.controls.textbox/#keypressed) event and returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the keypress was cancelled.

```csharp title="C#"
protected bool CheckKeyPressCancel(AsciiKey key)
```

#### Parameters

`key` [AsciiKey](../sadconsole.input.asciikey/)  
The key to use with the event.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate that the keypress should be considered cancelled.

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

### OnUnfocused()

Called when the control loses focus.

```csharp title="C#"
protected override void OnUnfocused()
```


### OnFocused()

Called when the control is focused.

```csharp title="C#"
protected override void OnFocused()
```


### OnLeftMouseClicked(ControlMouseState)

Focuses the control and enters typing mode.

```csharp title="C#"
protected override void OnLeftMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The mouse state.


### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.


## Events

### TextChanged

Raised when the text has changed and the preview has accepted it.

```csharp title="C#"
public event EventHandler? TextChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### TextChangedPreview

Raised before the text has changed and allows the change to be cancelled.

```csharp title="C#"
public event EventHandler<ValueChangedCancelableEventArgs<string>>? TextChangedPreview
```

#### Event Type

[EventHandler\<ValueChangedCancelableEventArgs\<string\>\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### KeyPressed

Raised when a key is pressed on the textbox.

```csharp title="C#"
public event EventHandler<KeyPressEventArgs>? KeyPressed
```

#### Event Type

[EventHandler\<KeyPressEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### TextValidated

Raised when the [Validator](../sadconsole.ui.controls.textbox/#validator) validates the [Text](../sadconsole.ui.controls.textbox/#text) property.

```csharp title="C#"
public event EventHandler<StringValidation.Result>? TextValidated
```

#### Event Type

[EventHandler\<StringValidation.Result\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)