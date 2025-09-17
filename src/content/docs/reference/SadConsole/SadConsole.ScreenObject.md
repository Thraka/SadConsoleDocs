---
title: ScreenObject Class
slug: reference/sadconsole.screenobject
sidebar:
  label: ScreenObject
---
## Definition

A generic object processed by SadConsole. Provides parent/child, components, and position.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization.OptIn)]
public class ScreenObject : IScreenObject, IPositionable, IComponentHost
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/)

## Constructors

### ScreenObject()

Creates a new instance of this class.

```csharp title="C#"
public ScreenObject()
```


## Fields

### ComponentsUpdate

A filtered list from [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) where [IsUpdate](../sadconsole.components.icomponent/#isupdate/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
protected List<IComponent> ComponentsUpdate
```

### ComponentsRender

A filtered list from [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) where [IsRender](../sadconsole.components.icomponent/#isrender/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
protected List<IComponent> ComponentsRender
```

### ComponentsMouse

A filtered list from [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) where [IsMouse](../sadconsole.components.icomponent/#ismouse/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
protected List<IComponent> ComponentsMouse
```

### ComponentsKeyboard

A filtered list from [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) where [IsKeyboard](../sadconsole.components.icomponent/#iskeyboard/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
protected List<IComponent> ComponentsKeyboard
```

### ComponentsEmpty

A filtered list from [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) that is not set for update, render, mouse, or keyboard.

```csharp title="C#"
protected List<IComponent> ComponentsEmpty
```

## Properties

### SortOrder

Indicates the sorting order this object should use when parented. Sorting is a manual operation on the [Children](../sadconsole.screenobject/#children/) collection.

```csharp title="C#"
[DataMember]
public uint SortOrder { get; set; }
```

### Children

The child objects of this instance.

```csharp title="C#"
public ScreenObjectCollection Children { get; protected set; }
```

### Parent

The parent object that this instance is a child of.

```csharp title="C#"
public IScreenObject? Parent { get; set; }
```

### Position

A position that is based on the current [Position](../sadconsole.screenobject/#position/) and [Parent](../sadconsole.screenobject/#parent/) position, in pixels.

```csharp title="C#"
public Point Position { get; set; }
```

### AbsolutePosition

A position that's based on the current `SadRogue.Primitives.IPositionable.Position`, as interpreted by the implementing class, in pixels.

```csharp title="C#"
public Point AbsolutePosition { get; protected set; }
```
## Remarks

Most objects will implement this property based on `SadRogue.Primitives.IPositionable.Position` which usually depends on the [Parent](../sadconsole.iscreenobject/#parent/) object's position.

### IgnoreParentPosition

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, this object should ignore it's parent position when calculating [AbsolutePosition](../sadconsole.iscreenobject/#absoluteposition/); otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public bool IgnoreParentPosition { get; set; }
```

### IsVisible

Gets or sets the visibility of this object.

```csharp title="C#"
[DataMember]
public bool IsVisible { get; set; }
```

### IsEnabled

Gets or sets the visibility of this object.

```csharp title="C#"
[DataMember]
public bool IsEnabled { get; set; }
```

### IsFocused

Gets or sets this console as the focused object for input.

```csharp title="C#"
public bool IsFocused { get; set; }
```

### FocusedMode

How the object should handle becoming active.

```csharp title="C#"
[DataMember]
public FocusBehavior FocusedMode { get; set; }
```

### IsExclusiveMouse

Gets or sets whether or not this object has exclusive access to the mouse events.

```csharp title="C#"
[DataMember]
public bool IsExclusiveMouse { get; set; }
```

### UseKeyboard

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, this object will use the keyboard; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public bool UseKeyboard { get; set; }
```

### UseMouse

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, this object will use the mouse; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public bool UseMouse { get; set; }
```

### SadComponents

A collection of components processed by this console.

```csharp title="C#"
public ObservableCollection<IComponent> SadComponents { get; protected set; }
```

## Methods

### Render(TimeSpan)

Draws all [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) and [Children](../sadconsole.iscreenobject/#children/).

```csharp title="C#"
public virtual void Render(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last call.

#### Remarks

Only processes if [IsVisible](../sadconsole.iscreenobject/#isvisible/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

### Update(TimeSpan)

Updates all [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) and [Children](../sadconsole.iscreenobject/#children/).

```csharp title="C#"
public virtual void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last call.

#### Remarks

Only processes if [IsEnabled](../sadconsole.iscreenobject/#isenabled/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

### ProcessKeyboard(Keyboard)

Called by the engine to process the keyboard.

```csharp title="C#"
public virtual bool ProcessKeyboard(Keyboard keyboard)
```

#### Parameters

`keyboard` [Keyboard](../sadconsole.input.keyboard/)  
Keyboard information.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the keyboard had data and this console did something with it.

### ProcessMouse(MouseScreenObjectState)

Processes the mouse.

```csharp title="C#"
public virtual bool ProcessMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The mouse state related to this object.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when this object should halt further mouse processing..

### LostMouse(MouseScreenObjectState)

Called when the mouse is being used by something else.

```csharp title="C#"
public virtual void LostMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The current state of the mouse based on this object.


### OnFocusLost()

Called when this object's focus has been lost.

```csharp title="C#"
public virtual void OnFocusLost()
```


### OnFocused()

Called when this object is focused.

```csharp title="C#"
public virtual void OnFocused()
```


### OnParentChanged(IScreenObject?, IScreenObject?)

Raises the [ParentChanged](../sadconsole.screenobject/#parentchanged/) event.

```csharp title="C#"
protected virtual void OnParentChanged(IScreenObject? oldParent, IScreenObject? newParent)
```

#### Parameters

`oldParent` [IScreenObject](../sadconsole.iscreenobject/)  
The previous parent.

`newParent` [IScreenObject](../sadconsole.iscreenobject/)  
The new parent.


### OnPositionChanging(Point, Point)

Raises the [PositionChanging](../sadconsole.screenobject/#positionchanging/) event.

```csharp title="C#"
protected virtual void OnPositionChanging(Point oldPosition, Point newPosition)
```

#### Parameters

`oldPosition` SadRogue.Primitives.Point  
The previous position.

`newPosition` SadRogue.Primitives.Point  
The new position.


### OnPositionChanged(Point, Point)

Raises the [PositionChanged](../sadconsole.screenobject/#positionchanged/) event.

```csharp title="C#"
protected virtual void OnPositionChanged(Point oldPosition, Point newPosition)
```

#### Parameters

`oldPosition` SadRogue.Primitives.Point  
The previous position.

`newPosition` SadRogue.Primitives.Point  
The new position.


### OnVisibleChanged()

Called when the visibility of the object changes.

```csharp title="C#"
protected virtual void OnVisibleChanged()
```


### OnEnabledChanged()

Called when the paused status of the object changes.

```csharp title="C#"
protected virtual void OnEnabledChanged()
```


### UpdateAbsolutePosition()

Sets a value for [AbsolutePosition](../sadconsole.iscreenobject/#absoluteposition/) based on the `SadRogue.Primitives.IPositionable.Position` of this instance and the [Parent](../sadconsole.iscreenobject/#parent/) instance.

```csharp title="C#"
public virtual void UpdateAbsolutePosition()
```


### ToString()

Returns the value "ScreenObject".

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string "ScreenObject".

### GetSadComponents<TComponent>()

Gets components of the specified types.

```csharp title="C#"
public IEnumerable<TComponent> GetSadComponents<TComponent>() where TComponent : class, IComponent
```

#### Returns

[IEnumerable\<TComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The components found.

### GetSadComponent<TComponent>()

Gets the first component of the specified type.

```csharp title="C#"
public TComponent? GetSadComponent<TComponent>() where TComponent : class, IComponent
```

#### Returns

TComponent  
The component if found, otherwise null.

### HasSadComponent<TComponent>(out TComponent?)

Indicates whether or not the component exists in the [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) collection.

```csharp title="C#"
public bool HasSadComponent<TComponent>(out TComponent? component) where TComponent : class, IComponent
```

#### Parameters

`component` TComponent  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the component exists; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### OnSadComponentAdded(IComponent)

Called when a component is added to the [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) collection.

```csharp title="C#"
protected virtual void OnSadComponentAdded(IComponent component)
```

#### Parameters

`component` [IComponent](../sadconsole.components.icomponent/)  
The component added.


### OnSadComponentRemoved(IComponent)

Called when a component is removed from the [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) collection.

```csharp title="C#"
protected virtual void OnSadComponentRemoved(IComponent component)
```

#### Parameters

`component` [IComponent](../sadconsole.components.icomponent/)  
The component removed.


### SortComponents()

Sorts the components based on the [SortOrder](../sadconsole.components.icomponent/#sortorder/) value.

```csharp title="C#"
public void SortComponents()
```


### Components_FilterAddItem(IComponent, List<IComponent>, List<IComponent>, List<IComponent>, List<IComponent>, List<IComponent>)

Adds a component to the provided collections, based on its configuration.

```csharp title="C#"
public static void Components_FilterAddItem(IComponent component, List<IComponent> componentsRender, List<IComponent> componentsUpdate, List<IComponent> componentsKeyboard, List<IComponent> componentsMouse, List<IComponent> componentsEmpty)
```

#### Parameters

`component` [IComponent](../sadconsole.components.icomponent/)  
The component.

`componentsRender` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The render collection.

`componentsUpdate` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The update collection.

`componentsKeyboard` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The keyboard collection.

`componentsMouse` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The mouse collection.

`componentsEmpty` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The empty collection.


### Components_FilterRemoveItem(IComponent, List<IComponent>, List<IComponent>, List<IComponent>, List<IComponent>, List<IComponent>)

Removes a component to the provided collections, based on its configuration.

```csharp title="C#"
public static void Components_FilterRemoveItem(IComponent component, List<IComponent> componentsRender, List<IComponent> componentsUpdate, List<IComponent> componentsKeyboard, List<IComponent> componentsMouse, List<IComponent> componentsEmpty)
```

#### Parameters

`component` [IComponent](../sadconsole.components.icomponent/)  
The component.

`componentsRender` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The render collection.

`componentsUpdate` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The update collection.

`componentsKeyboard` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The keyboard collection.

`componentsMouse` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The mouse collection.

`componentsEmpty` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The empty collection.


### Components_Sort(List<IComponent>, List<IComponent>, List<IComponent>, List<IComponent>, List<IComponent>)

Helper to sort the components in the split collections.

```csharp title="C#"
public static void Components_Sort(List<IComponent> componentsRender, List<IComponent> componentsUpdate, List<IComponent> componentsKeyboard, List<IComponent> componentsMouse, List<IComponent> componentsEmpty)
```

#### Parameters

`componentsRender` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The render collection.

`componentsUpdate` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The update collection.

`componentsKeyboard` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The keyboard collection.

`componentsMouse` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The mouse collection.

`componentsEmpty` [List\<IComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The empty collection.


### OnSerializingMethod(StreamingContext)

Nothing.

```csharp title="C#"
[OnSerializing]
protected void OnSerializingMethod(StreamingContext context)
```

#### Parameters

`context` [StreamingContext](https://learn.microsoft.com/dotnet/api/system.runtime.serialization.streamingcontext/)  
Nothing.


## Events

### ParentChanged

Raised when the [Parent](../sadconsole.iscreenobject/#parent/) property changes.

```csharp title="C#"
public event EventHandler<ValueChangedEventArgs<IScreenObject?>>? ParentChanged
```

#### Event Type

[EventHandler\<ValueChangedEventArgs\<IScreenObject\>\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### PositionChanged

```csharp title="C#"
public event EventHandler<ValueChangedEventArgs<Point>>? PositionChanged
```

#### Event Type

[EventHandler\<ValueChangedEventArgs\<Point\>\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### PositionChanging

```csharp title="C#"
public event EventHandler<ValueChangedEventArgs<Point>>? PositionChanging
```

#### Event Type

[EventHandler\<ValueChangedEventArgs\<Point\>\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### IsVisibleChanged

Raised when the [IsVisible](../sadconsole.iscreenobject/#isvisible/) property changes.

```csharp title="C#"
public event EventHandler? IsVisibleChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### IsEnabledChanged

Raised when the [IsEnabled](../sadconsole.iscreenobject/#isenabled/) property changes.

```csharp title="C#"
public event EventHandler? IsEnabledChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### FocusLost

Raised when the [IsFocused](../sadconsole.iscreenobject/#isfocused/) property is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public event EventHandler? FocusLost
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### Focused

Raised when the [IsFocused](../sadconsole.iscreenobject/#isfocused/) property is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public event EventHandler? Focused
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)