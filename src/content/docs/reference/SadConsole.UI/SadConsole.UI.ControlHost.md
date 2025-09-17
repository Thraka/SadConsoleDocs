---
title: ControlHost Class
slug: reference/sadconsole.ui.controlhost
sidebar:
  label: ControlHost
---
## Definition

Adds the ability for a host to contain and display controls from [SadConsole.UI.Controls](../sadconsole/).

```csharp title="C#"
public class ControlHost : IComponent, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComponent](../sadconsole.components.icomponent/), [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### ControlHost()

```csharp title="C#"
public ControlHost()
```


## Fields

### ControlsList

The collection of controls.

```csharp title="C#"
[DataMember]
protected List<ControlBase> ControlsList
```

### NamedControls

The controls added which contain a [Name](../sadconsole.ui.controls.controlbase/#name/) value.

```csharp title="C#"
protected Dictionary<string, ControlBase> NamedControls
```

## Properties

### SortOrder

Indicates priority to other components.

```csharp title="C#"
public uint SortOrder { get; set; }
```

### this[int]

Gets a control by index.

```csharp title="C#"
public ControlBase this[int index] { get; }
```

### ParentConsole

The parent object hosting the controls.

```csharp title="C#"
public IScreenSurface? ParentConsole { get; }
```

### ThemeColors

Gets or sets the colors to use with drawing the console and controls.

```csharp title="C#"
public Colors? ThemeColors { get; set; }
```

### IsDirty

Indicates that the control host needs to be redrawn.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### CapturedControl

Gets the control currently capturing mouse events.

```csharp title="C#"
public ControlBase? CapturedControl { get; }
```

### FocusedControl

Gets or sets the control that has keyboard focus.

```csharp title="C#"
public ControlBase? FocusedControl { get; set; }
```

### ClearOnAdded

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, the component will clear the console it's attached to with the theme color.

```csharp title="C#"
[DataMember]
public bool ClearOnAdded { get; set; }
```

### DisableCursorOnAdded

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, the component will disable the cursor of the console it's attached to.

```csharp title="C#"
[DataMember]
public bool DisableCursorOnAdded { get; set; }
```

### CanTabToNextConsole

When true, allows the tab command to move to the next console (when there is a parent) instead of cycling back to the first control on this console.

```csharp title="C#"
[DataMember]
public bool CanTabToNextConsole { get; set; }
```

### NextTabConsole

Sets reference to the console to tab to when the [CanTabToNextConsole](../sadconsole.ui.controlhost/#cantabtonextconsole/) property is true. Set this to null to allow the engine to determine the next console.

```csharp title="C#"
public IScreenSurface? NextTabConsole { get; set; }
```

### PreviousTabConsole

Sets reference to the console to tab to when the [CanTabToNextConsole](../sadconsole.ui.controlhost/#cantabtonextconsole/) property is true. Set this to null to allow the engine to determine the next console.

```csharp title="C#"
public IScreenSurface? PreviousTabConsole { get; set; }
```

### DisableControlFocusing

When set to true, child controls are not alerted to focused and non-focused states.

```csharp title="C#"
[DataMember]
public bool DisableControlFocusing { get; set; }
```

### Count

The total number of controls in this component.

```csharp title="C#"
public int Count { get; }
```

### IsReadOnly

Always returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsReadOnly { get; }
```

### this[string]

Gets a control by its [Name](../sadconsole.ui.controls.controlbase/#name/) property.

```csharp title="C#"
public ControlBase this[string name] { get; }
```

## Methods

### HasNamedControl(string)

Checks whether or not the container has a control registered with the given name.

```csharp title="C#"
public bool HasNamedControl(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the control is found; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### HasNamedControl(string, out ControlBase?)

Checks whether or not the container has a control registered with the given name. If found, the instance is assigned to the `control` parameter.

```csharp title="C#"
public bool HasNamedControl(string name, out ControlBase? control)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to check.

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control instance found.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the control is found; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### GetNamedControl(string)

Gets a control by its [Name](../sadconsole.ui.controls.controlbase/#name/) property.

```csharp title="C#"
public ControlBase GetNamedControl(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the control.

#### Returns

[ControlBase](../sadconsole.ui.controls.controlbase/)  
The control.

### TabNextControl()

Gives the focus to the next control in the tab order.

```csharp title="C#"
public void TabNextControl()
```


### TabPreviousControl()

Gives focus to the previous control in the tab order.

```csharp title="C#"
public void TabPreviousControl()
```


### TryTabPreviousConsole()

Tries to tab to the console that comes before this one in the [Parent](../sadconsole.iscreenobject/#parent/) collection of [Children](../sadconsole.iscreenobject/#children/). Sets focus to the target console if found.

```csharp title="C#"
protected bool TryTabPreviousConsole()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the tab was successful; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### TryTabNextConsole()

Tries to tab to the console that comes after this one in the [Parent](../sadconsole.iscreenobject/#parent/) collection of [Children](../sadconsole.iscreenobject/#children/). Sets focus to the target console if found.

```csharp title="C#"
protected bool TryTabNextConsole()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the tab was successful; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### GetThemeColors()

Returns the colors assigned to this console or the library default.

```csharp title="C#"
public Colors GetThemeColors()
```

#### Returns

[Colors](../sadconsole.ui.colors/)  
The found colors.

### ToArray()

Gets an array containing all of the controls this host contains.

```csharp title="C#"
public ControlBase[] ToArray()
```

#### Returns

[ControlBase[]](../sadconsole.ui.controls.controlbase/)

### FocusedControlChanging(ControlBase?, ControlBase?)

When overridden, allows you to prevent a control from taking focus from another control.

```csharp title="C#"
protected virtual bool FocusedControlChanging(ControlBase? newControl, ControlBase? oldControl)
```

#### Parameters

`newControl` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control requesting focus.

`oldControl` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control that has focus.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the focus change is allowed; otherwise false.

### FocusedControlChanged(ControlBase?, ControlBase?)

This method actually changes the variable that tracks which control is focused. It then sets the [IsFocused](../sadconsole.ui.controls.controlbase/#isfocused/) property to the appropriate value for both the previously focused control and the newly focused control.

```csharp title="C#"
protected virtual void FocusedControlChanged(ControlBase? newControl, ControlBase? oldControl)
```

#### Parameters

`newControl` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control that should be focused.

`oldControl` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control that currently has focus.


### CanFocusControl(ControlBase?)

Determins if a control is enabled and [CanFocus](../sadconsole.ui.controls.controlbase/#canfocus/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
protected virtual bool CanFocusControl(ControlBase? control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the control can be focused; otherwise false.

### ReOrderControls()

Reorders the control collection based on the tab index of each control.

```csharp title="C#"
public void ReOrderControls()
```


### CaptureControl(ControlBase)

Captures a control for exclusive mouse focus. Sets the ExclusiveMouse property to true.

```csharp title="C#"
public void CaptureControl(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to capture


### ReleaseControl()

Releases the control from exclusive mouse focus. Sets the ExclusiveMouse property to false and sets the CapturedControl property to null.

```csharp title="C#"
public void ReleaseControl()
```


### ForceRedrawAllControls()

Forces each control to dirty so that the next frame will redraw each control.

```csharp title="C#"
public void ForceRedrawAllControls()
```


### GetEnumerator()

Gets an enumerator of the controls collection.

```csharp title="C#"
public IEnumerator<ControlBase> GetEnumerator()
```

#### Returns

[IEnumerator\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)  
The enumerator of the controls collection.

### IndexOf(ControlBase)

Gets the index of the specified control.

```csharp title="C#"
public int IndexOf(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the control in the backing collection.

### Insert(int, ControlBase)

Inserts an item at the specified index and sets the [TabIndex](../sadconsole.ui.controls.controlbase/#tabindex/) to the specified index.

```csharp title="C#"
public void Insert(int index, ControlBase control)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Index to insert at.

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to insert.

#### Remarks

Index within the backing collection is always based on [TabIndex](../sadconsole.ui.controls.controlbase/#tabindex/) ranking. There may be conflicts so you're not guaranteed that the control will be available at the specified index.

### RemoveAt(int)

Removes a control by index.

```csharp title="C#"
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### Add(ControlBase)

Adds an existing control to this console.

```csharp title="C#"
public void Add(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to add.


### Clear()

Removes all controls from this console.

```csharp title="C#"
public void Clear()
```


### Contains(ControlBase)

Checks if the specified control exists in this console.

```csharp title="C#"
public bool Contains(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the control exists in this console; otherwise false.

### CopyTo(ControlBase[], int)

Copies the controls to a new array.

```csharp title="C#"
public void CopyTo(ControlBase[] array, int arrayIndex)
```

#### Parameters

`array` [ControlBase[]](../sadconsole.ui.controls.controlbase/)  
The destination array.

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The starting index of where to copy the controls in the destination array.


### Remove(ControlBase)

Removes a control from this console.

```csharp title="C#"
public bool Remove(ControlBase control)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control to remove.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if item was successfully removed; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>. This method also returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> if item is not found.