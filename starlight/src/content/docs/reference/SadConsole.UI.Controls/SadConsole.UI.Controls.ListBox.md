---
title: ListBox Class
slug: reference/sadconsole.ui.controls.listbox
sidebar:
  label: ListBox
---
## Definition

A scrollable list control.

```csharp title="C#"
[DataContract]
public class ListBox : CompositeControl, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [CompositeControl](../sadconsole.ui.controls.compositecontrol/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### ListBox(int, int)

Creates a new instance of the listbox control with the default theme for the items.

```csharp title="C#"
public ListBox(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the listbox.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the listbox.


### ListBox(int, int, ListBoxItemTheme)

Creates a new instance of the listbox control with the specified item theme.

```csharp title="C#"
public ListBox(int width, int height, ListBoxItemTheme itemTheme)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the listbox.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the listbox.

`itemTheme` [ListBoxItemTheme](../sadconsole.ui.controls.listboxitemtheme/)  
The theme to use with rendering the listbox items.


## Fields

### _reconfigureScrollBar

Internal flag to indicate the scroll bar needs to be reconfigured.

```csharp title="C#"
protected bool _reconfigureScrollBar
```

## Properties

### IsScrollBarVisible

Internal use only; used in rendering.

```csharp title="C#"
public bool IsScrollBarVisible { get; set; }
```

### ScrollBar

The scroll bar control used with this list box.

```csharp title="C#"
[DataMember(Name = "ScrollBar")]
public ScrollBar ScrollBar { get; protected set; }
```

### ItemIndexMouseOver

Used in rendering.

```csharp title="C#"
public int ItemIndexMouseOver { get; }
```

### VisibleItemsTotal

The total items visible in the listbox.

```csharp title="C#"
public int VisibleItemsTotal { get; set; }
```

### VisibleItemsMax

The maximum amount of items that can be shown in the listbox.

```csharp title="C#"
public int VisibleItemsMax { get; set; }
```

### CompareByReference

When the [SelectedItem](../sadconsole.ui.controls.listbox/#selecteditem/) changes, and this property is true, objects will be compared by reference. If false, they will be compared by value.

```csharp title="C#"
[DataMember]
public bool CompareByReference { get; set; }
```

### SingleClickItemExecute

When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, the [SelectedItemExecuted](../sadconsole.ui.controls.listbox/#selecteditemexecuted/) event will fire when an item is single-clicked instead of double-clicked.

```csharp title="C#"
[DataMember]
public bool SingleClickItemExecute { get; set; }
```

### Items

The items in the listbox.

```csharp title="C#"
[DataMember]
public ObservableCollection<object> Items { get; }
```

### SelectedIndex

Gets or sets the index of the selected item.

```csharp title="C#"
public int SelectedIndex { get; set; }
```

### SelectedItem

Gets or sets the selected item.

```csharp title="C#"
public object? SelectedItem { get; set; }
```

### BorderTheme

The drawing theme for the border when [DrawBorder](../sadconsole.ui.controls.listbox/#drawborder/) is true.

```csharp title="C#"
public ThemeStates BorderTheme { get; protected set; }
```

### BorderLineStyle

The line style for the border when [DrawBorder](../sadconsole.ui.controls.listbox/#drawborder/) is true.

```csharp title="C#"
[DataMember]
public int[] BorderLineStyle { get; set; }
```

### DrawBorder

If false the border will not be drawn.

```csharp title="C#"
[DataMember]
public bool DrawBorder { get; set; }
```

### ItemTheme

The appearance of the items displayed by the listbox control.

```csharp title="C#"
[DataMember]
public ListBoxItemTheme ItemTheme { get; set; }
```

### ItemsArea

The area on the control where items are drawn.

```csharp title="C#"
public Rectangle ItemsArea { get; set; }
```

## Methods

### OnSelectedItemChanged()

Invokes the [SelectedItemChanged](../sadconsole.ui.controls.listbox/#selecteditemchanged/) event.

```csharp title="C#"
protected virtual void OnSelectedItemChanged()
```


### OnItemAction()

Invokes the [SelectedItemExecuted](../sadconsole.ui.controls.listbox/#selecteditemexecuted/) event.

```csharp title="C#"
protected virtual void OnItemAction()
```


### OnResized()

Called when `SadConsole.UI.Controls.ControlBase.Resize(System.Int32%2cSystem.Int32)` was called.

```csharp title="C#"
protected override void OnResized()
```


### SetupScrollBar(Orientation, int, Point)

Configures the associated [ScrollBar](../sadconsole.ui.controls.listbox/#scrollbar/).

```csharp title="C#"
public void SetupScrollBar(Orientation orientation, int sizeValue, Point position)
```

#### Parameters

`orientation` [Orientation](../sadconsole.orientation/)  
The orientation of the scrollbar.

`sizeValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The size of the scrollbar.

`position` SadRogue.Primitives.Point  
The position of the scrollbar.


### ScrollToSelectedItem()

Scrolls the list to the item currently selected.

```csharp title="C#"
public void ScrollToSelectedItem()
```


### ProcessKeyboard(Keyboard)

Called when the keyboard is used on this control.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard info)
```

#### Parameters

`info` [Keyboard](../sadconsole.input.keyboard/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### OnMouseIn(ControlMouseState)

Called as the mouse moves around the control area. Raises the MouseMove event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnMouseIn(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnLeftMouseClicked(ControlMouseState)

Called when the left mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnLeftMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### GetItemAndIndexUnderMouse(ControlMouseState)

Returns the item under the mouse, and its array position.

```csharp title="C#"
public (object? item, int itemIndex) GetItemAndIndexUnderMouse(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The mouse state.

#### Returns

[(object item, int itemIndex)](https://learn.microsoft.com/dotnet/api/system.object/)  
A tuple containing the item and the item's array position.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when the theme for the listbox isn't based on ListBoxTheme.


### SetupScrollBar()

Sets up the scroll bar for the listbox.

```csharp title="C#"
protected virtual void SetupScrollBar()
```


### ShowHideScrollBar()

Shows the scroll bar when there are too many items to display; otherwise, hides it.

```csharp title="C#"
protected void ShowHideScrollBar()
```


### RefreshThemeStateColors(Colors)

Updates the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/) by calling [RefreshTheme(Colors)](../sadconsole.ui.themestates/#/) with the provided colors. Override this method to adjust how colors are used by the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/).

```csharp title="C#"
protected override void RefreshThemeStateColors(Colors colors)
```

#### Parameters

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply to the theme state.


### UpdateAndRedraw(TimeSpan)

Updates each control hosted by this control.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The game frame time delta.


## Events

### SelectedItemChanged

An event that triggers when the [SelectedItem](../sadconsole.ui.controls.listbox/#selecteditem/) property changes.

```csharp title="C#"
public event EventHandler<ListBox.SelectedItemEventArgs>? SelectedItemChanged
```

#### Event Type

[EventHandler\<ListBox.SelectedItemEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### SelectedItemReselected

An event that triggers when the [SelectedItem](../sadconsole.ui.controls.listbox/#selecteditem/) property is reselected by the mouse.

```csharp title="C#"
public event EventHandler<ListBox.SelectedItemEventArgs>? SelectedItemReselected
```

#### Event Type

[EventHandler\<ListBox.SelectedItemEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### SelectedItemExecuted

An event that triggers when an item is double clicked or the Enter key is pressed while the listbox has focus.

```csharp title="C#"
public event EventHandler<ListBox.SelectedItemEventArgs>? SelectedItemExecuted
```

#### Event Type

[EventHandler\<ListBox.SelectedItemEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)