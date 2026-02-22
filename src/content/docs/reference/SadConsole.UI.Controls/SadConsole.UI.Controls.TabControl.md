---
title: TabControl Class
slug: reference/sadconsole.ui.controls.tabcontrol
sidebar:
  label: TabControl
editUrl: false
description: A control with tabs along the edge of the control. Each tab sets the content of the control.
---
## Definition

A control with tabs along the edge of the control. Each tab sets the content of the control.

```csharp title="C#"
public class TabControl : CompositeControl, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [CompositeControl](../sadconsole.ui.controls.compositecontrol/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### TabControl(IEnumerable\<TabItem>, int, int)

Creates a new tab control with the specified tab items.

```csharp title="C#"
public TabControl(IEnumerable<TabItem> tabItems, int width, int height)
```

#### Parameters

`tabItems` [IEnumerable\<TabItem\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
Tabs that are present on the tabcontrol

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the content area

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Heigh of the content area


### TabControl(IEnumerable\<TabItem>, int, int, int)

Creates a new tab control with the specified tab items.

```csharp title="C#"
public TabControl(IEnumerable<TabItem> tabItems, int activeTabIndex, int width, int height)
```

#### Parameters

`tabItems` [IEnumerable\<TabItem\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
Tabs that are present on the tabcontrol

`activeTabIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
What tab to be active on initialization

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the content area

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Heigh of the content area


## Fields

### InvalidActiveTabIndex

The index used when there isn't an active tab.

```csharp title="C#"
public const int InvalidActiveTabIndex = -1
```

### CachedMousePosition

The mouse position recorded from the last time the mouse was over the control.

```csharp title="C#"
protected Point CachedMousePosition
```

### ContentRegion

The region of the control where a tab item's content should be displayed.

```csharp title="C#"
protected Rectangle ContentRegion
```

### TabsRegion

The region of the control where a tab headers should be displayed.

```csharp title="C#"
protected Rectangle TabsRegion
```

## Properties

### TabItems

The list of tab items displayed by the control.

```csharp title="C#"
[DataMember]
protected List<TabItem> TabItems { get; set; }
```

### Tabs

Gets a list of tabs in this control.

```csharp title="C#"
public ListEnumerator<TabItem> Tabs { get; }
```

### ActiveTabIndex

The index of the active tab. If [InvalidActiveTabIndex](../sadconsole.ui.controls.tabcontrol/#invalidactivetabindex) is returned, there is no active tab.

```csharp title="C#"
[DataMember]
public int ActiveTabIndex { get; protected set; }
```

### CurrentTab

Retursn the current tab.

```csharp title="C#"
public TabItem CurrentTab { get; }
```

### TabOrientation

Sets the position of the tab strip to the top or bottom of the control.

```csharp title="C#"
[DataMember]
public TabControl.Orientation TabOrientation { get; set; }
```

### ConnectedLineStyle

An array of glyphs indexed by [ICellSurface.ConnectedLineIndex](../sadconsole.icellsurface.connectedlineindex/). Defaults to [ConnectedLineThin](../sadconsole.icellsurface/#connectedlinethin).

```csharp title="C#"
[DataMember]
public int[] ConnectedLineStyle { get; set; }
```

### this[int]

Gets or sets the tab item at the specified index.

```csharp title="C#"
public TabItem this[int index] { get; set; }
```

## Methods

### AddTab(TabItem)

Adds a tab to the control.

```csharp title="C#"
public void AddTab(TabItem tab)
```

#### Parameters

`tab` [TabItem](../sadconsole.ui.controls.tabitem/)  
TabItem with header and associated console for tab content


### AddTab(string, Panel)

Creates and adds a tab to the control.

```csharp title="C#"
public TabItem AddTab(string header, Panel content)
```

#### Parameters

`header` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The header of the new tab.

`content` [Panel](../sadconsole.ui.controls.panel/)  
Associated content for the new tab.

#### Returns

[TabItem](../sadconsole.ui.controls.tabitem/)  
The new tab item.

### RemoveTab(TabItem)

Removes a tab from the control.

```csharp title="C#"
public void RemoveTab(TabItem tab)
```

#### Parameters

`tab` [TabItem](../sadconsole.ui.controls.tabitem/)  
TabItem that should be removed


### RemoveTab(int)

Removes a tab by index.

```csharp title="C#"
public void RemoveTab(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the tab to remove.


### SetActiveTab(int)

Sets the tab specified by the `index` as active.

```csharp title="C#"
public void SetActiveTab(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Index of the tab.


### OnActiveTabItem(int, int)

Raises the [ActiveTabItemChanged](../sadconsole.ui.controls.tabcontrol/#activetabitemchanged) event.

```csharp title="C#"
protected void OnActiveTabItem(int previousActiveIndex, int activeIndex)
```

#### Parameters

`previousActiveIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The tab index of the previous item.

`activeIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the active tab.


### GetTabIndex(TabItem)

Gets the index of a tab

```csharp title="C#"
public int GetTabIndex(TabItem tab)
```

#### Parameters

`tab` [TabItem](../sadconsole.ui.controls.tabitem/)  
Tab you need the index of

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
0 based index of the tab

### ContainsTab(TabItem)

Determines whether a tab is contained in this control.

```csharp title="C#"
public bool ContainsTab(TabItem tab)
```

#### Parameters

`tab` [TabItem](../sadconsole.ui.controls.tabitem/)  
The tab to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the tab is in the control; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### SelectNextTab()

Sets the next tab as active. Stops at the last tab.

```csharp title="C#"
public bool SelectNextTab()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the active tab changes; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### SelectPreviousTab()

Sets the previous tab as active. Stops at the first tab.

```csharp title="C#"
public bool SelectPreviousTab()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the active tab changes; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### OnLeftMouseClicked(ControlMouseState)

Called when the left mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnLeftMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnMouseIn(ControlMouseState)

Called as the mouse moves around the control area. Raises the MouseMove event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate) method.

```csharp title="C#"
protected override void OnMouseIn(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnResized()

Resizes the tab item.

```csharp title="C#"
protected override void OnResized()
```


### ThemeDetermineContentRegion()

Sets the [ContentRegion](../sadconsole.ui.controls.tabcontrol/#contentregion) rectangle to how much space the tab control should give to tab item content.

```csharp title="C#"
protected void ThemeDetermineContentRegion()
```


### UpdateAndRedraw(TimeSpan)

Updates each control hosted by this control.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The game frame time delta.


## Events

### ActiveTabItemChanged

Raised when the active tab changes.

```csharp title="C#"
public event EventHandler<ValueChangedEventArgs<TabItem?>>? ActiveTabItemChanged
```

#### Event Type

[EventHandler\<ValueChangedEventArgs\<TabItem\>\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)