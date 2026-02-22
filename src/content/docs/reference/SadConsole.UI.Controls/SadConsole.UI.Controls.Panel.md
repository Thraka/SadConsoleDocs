---
title: Panel Class
slug: reference/sadconsole.ui.controls.panel
sidebar:
  label: Panel
editUrl: false
description: A control container that processes the mouse on each child. `SadConsole.UI.Controls.ControlBase.TabStop` defaults to false.
---
## Definition

A control container that processes the mouse on each child. [TabStop](../sadconsole.ui.controls.controlbase/#tabstop) defaults to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataContract]
public class Panel : CompositeControl, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [CompositeControl](../sadconsole.ui.controls.compositecontrol/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### Panel(int, int)

Creates a new drawing surface control with the specified width and height.

```csharp title="C#"
public Panel(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control.


## Properties

### this[int]

Gets or sets a control in the collection of controls.

```csharp title="C#"
public ControlBase this[int index] { get; set; }
```

### this[string]

```csharp title="C#"
public ControlBase this[string name] { get; }
```

### UseNormalStateOnly

When true, only uses [Normal](../sadconsole.ui.themestates/#normal) for drawing.

```csharp title="C#"
[DataMember]
public bool UseNormalStateOnly { get; set; }
```

### SkipDrawing

When true, ignores all states and doesn't draw anything.

```csharp title="C#"
[DataMember]
public bool SkipDrawing { get; set; }
```

### DrawBorder

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the theme should draw along the inner bounds of the panel.

```csharp title="C#"
[DataMember]
public bool DrawBorder { get; set; }
```

### UseExtendedBorderGlyphs

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the lines of the theme should use the extended SadConsole font characters if available.

```csharp title="C#"
[DataMember]
public bool UseExtendedBorderGlyphs { get; set; }
```

### UseInsetBorder

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the border colors should make it appear like the border is inset.

```csharp title="C#"
[DataMember]
public bool UseInsetBorder { get; set; }
```

### Appearance

The current Appearance based on the control state.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase? Appearance { get; protected set; }
```

## Methods

### Clear()

Removes all controls.

```csharp title="C#"
public void Clear()
```


### Add(ControlBase)

```csharp title="C#"
public void Add(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  


### Remove(ControlBase)

```csharp title="C#"
public bool Remove(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### RemoveAt(int)

Removes a control at the specified index.

```csharp title="C#"
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the control to remove.


### IndexOf(ControlBase)

Returns the index of the specified control.

```csharp title="C#"
public int IndexOf(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to search for.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the control.

### Insert(int, ControlBase)

Inserts the control at the specified index.

```csharp title="C#"
public void Insert(int index, ControlBase control)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index to insert at.

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to insert.


### Contains(ControlBase)

```csharp title="C#"
public bool Contains(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### CopyTo(ControlBase[], int)

```csharp title="C#"
public void CopyTo(ControlBase[] array, int arrayIndex)
```

#### Parameters

`array` [ControlBase[]](../sadconsole.ui.controls.controlbase/)  

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### OnMouseExit(ControlMouseState)

Called when the mouse exits the area of the control. Raises the MouseExit event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnMouseExit(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### ProcessKeyboard(Keyboard)

Called when the keyboard is used on this control.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard state)
```

#### Parameters

`state` [Keyboard](../sadconsole.input.keyboard/)  
The state of the keyboard.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### OnIsDirtyChanged()

When [IsDirty](../sadconsole.ui.controls.controlbase/#isdirty) is set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, changes the child controls to also be dirty.

```csharp title="C#"
protected override void OnIsDirtyChanged()
```


### HasNamedControl(string)

```csharp title="C#"
public bool HasNamedControl(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### HasNamedControl(string, out ControlBase?)

```csharp title="C#"
public bool HasNamedControl(string name, out ControlBase? control)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### GetNamedControl(string)

```csharp title="C#"
public ControlBase GetNamedControl(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

#### Returns

[ControlBase](../sadconsole.ui.controls.controlbase/)

### GetEnumerator()

Gets an enumerator that iterates over the controls in this panel.

```csharp title="C#"
public IEnumerator<ControlBase> GetEnumerator()
```

#### Returns

[IEnumerator\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)  
The enumerator.

### UpdateAndRedraw(TimeSpan)

Updates each control hosted by this control.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The game frame time delta.