---
title: SelectionButton Class
slug: reference/sadconsole.ui.controls.selectionbutton
sidebar:
  label: SelectionButton
editUrl: false
description: Provides a button-like control that changes focus to a designated previous or next selection button when the arrow keys are pushed.
---
## Definition

Provides a button-like control that changes focus to a designated previous or next selection button when the arrow keys are pushed.

```csharp title="C#"
[DataContract]
public class SelectionButton : Button
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [ButtonBase](../sadconsole.ui.controls.buttonbase/) → [Button](../sadconsole.ui.controls.button/)

## Constructors

### SelectionButton(int, int)

Creates a new Selection Button with a specific width and height.

```csharp title="C#"
public SelectionButton(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the selection button.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the selection button.


## Properties

### PreviousSelection

The selection button to focus when the UP key is pressed or the SelectPrevious() method is called.

```csharp title="C#"
public SelectionButton? PreviousSelection { get; set; }
```

### NextSelection

The selection button to focus when the DOWN key is pressed or the SelectNext() method is called.

```csharp title="C#"
public SelectionButton? NextSelection { get; set; }
```

## Methods

### SetNextSelection(ref SelectionButton, bool)

Sets the next selection button and optionally sets the previous of the referenced selection to this button.

```csharp title="C#"
public SelectionButton SetNextSelection(ref SelectionButton nextSelection, bool setPreviousOnNext = true)
```

#### Parameters

`nextSelection` [SelectionButton](../sadconsole.ui.controls.selectionbutton/)  
The selection button to be used as next.

`setPreviousOnNext` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Sets the PreviousSelection property on the `nextSelection` instance to current selection button. Defaults to true.

#### Returns

[SelectionButton](../sadconsole.ui.controls.selectionbutton/)  
The button that was passed to the `nextSelection` parameter.

### ProcessKeyboard(Keyboard)

Focuses the previous or next selection button depending on if the UP or DOWN arrow keys were pressed.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard info)
```

#### Parameters

`info` [Keyboard](../sadconsole.input.keyboard/)  
The keyboard state.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### SelectPrevious()

Selects the previous selection button.

```csharp title="C#"
public SelectionButton? SelectPrevious()
```

#### Returns

[SelectionButton](../sadconsole.ui.controls.selectionbutton/)  
Returns the previous selection button.

### SelectNext()

Selects the next selection button.

```csharp title="C#"
public SelectionButton? SelectNext()
```

#### Returns

[SelectionButton](../sadconsole.ui.controls.selectionbutton/)  
Returns the next selection button.