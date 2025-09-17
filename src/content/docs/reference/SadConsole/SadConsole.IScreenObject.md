---
title: IScreenObject Interface
slug: reference/sadconsole.iscreenobject
sidebar:
  label: IScreenObject
---
## Definition

A generic object processed by SadConsole. Provides parent/child, components, position, and input callbacks.

```csharp title="C#"
public interface IScreenObject : IPositionable, IComponentHost
```


## Properties

### SortOrder

Indicates the sorting order this object should use when parented. Sorting is a manual operation on the [Children](../sadconsole.iscreenobject/#children/) collection.

```csharp title="C#"
uint SortOrder { get; set; }
```

### FocusedMode

How the object should handle becoming active.

```csharp title="C#"
FocusBehavior FocusedMode { get; set; }
```

### AbsolutePosition

A position that's based on the current `SadRogue.Primitives.IPositionable.Position`, as interpreted by the implementing class, in pixels.

```csharp title="C#"
Point AbsolutePosition { get; }
```
## Remarks

Most objects will implement this property based on `SadRogue.Primitives.IPositionable.Position` which usually depends on the [Parent](../sadconsole.iscreenobject/#parent/) object's position.

### IgnoreParentPosition

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, this object should ignore it's parent position when calculating [AbsolutePosition](../sadconsole.iscreenobject/#absoluteposition/); otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool IgnoreParentPosition { get; set; }
```

### Children

The child objects of this instance.

```csharp title="C#"
ScreenObjectCollection Children { get; }
```

### IsEnabled

Gets or sets the visibility of this object.

```csharp title="C#"
bool IsEnabled { get; set; }
```

### IsExclusiveMouse

Gets or sets whether or not this object has exclusive access to the mouse events.

```csharp title="C#"
bool IsExclusiveMouse { get; set; }
```

### IsFocused

Gets or sets this console as the focused object for input.

```csharp title="C#"
bool IsFocused { get; set; }
```

### IsVisible

Gets or sets the visibility of this object.

```csharp title="C#"
bool IsVisible { get; set; }
```

### Parent

The parent object that this instance is a child of.

```csharp title="C#"
IScreenObject? Parent { get; set; }
```

### UseKeyboard

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, this object will use the keyboard; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool UseKeyboard { get; set; }
```

### UseMouse

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, this object will use the mouse; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool UseMouse { get; set; }
```

## Methods

### Render(TimeSpan)

Draws all [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) and [Children](../sadconsole.iscreenobject/#children/).

```csharp title="C#"
void Render(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last call.

#### Remarks

Only processes if [IsVisible](../sadconsole.iscreenobject/#isvisible/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

### OnFocused()

Called when this object is focused.

```csharp title="C#"
void OnFocused()
```


### OnFocusLost()

Called when this object's focus has been lost.

```csharp title="C#"
void OnFocusLost()
```


### ProcessKeyboard(Keyboard)

Called by the engine to process the keyboard.

```csharp title="C#"
bool ProcessKeyboard(Keyboard keyboard)
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
bool ProcessMouse(MouseScreenObjectState state)
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
void LostMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The current state of the mouse based on this object.


### Update(TimeSpan)

Updates all [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) and [Children](../sadconsole.iscreenobject/#children/).

```csharp title="C#"
void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last call.

#### Remarks

Only processes if [IsEnabled](../sadconsole.iscreenobject/#isenabled/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

### UpdateAbsolutePosition()

Sets a value for [AbsolutePosition](../sadconsole.iscreenobject/#absoluteposition/) based on the `SadRogue.Primitives.IPositionable.Position` of this instance and the [Parent](../sadconsole.iscreenobject/#parent/) instance.

```csharp title="C#"
void UpdateAbsolutePosition()
```


## Events

### IsEnabledChanged

Raised when the [IsEnabled](../sadconsole.iscreenobject/#isenabled/) property changes.

```csharp title="C#"
event EventHandler IsEnabledChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### ParentChanged

Raised when the [Parent](../sadconsole.iscreenobject/#parent/) property changes.

```csharp title="C#"
event EventHandler<ValueChangedEventArgs<IScreenObject?>> ParentChanged
```

#### Event Type

[EventHandler\<ValueChangedEventArgs\<IScreenObject\>\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### IsVisibleChanged

Raised when the [IsVisible](../sadconsole.iscreenobject/#isvisible/) property changes.

```csharp title="C#"
event EventHandler IsVisibleChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### FocusLost

Raised when the [IsFocused](../sadconsole.iscreenobject/#isfocused/) property is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
event EventHandler FocusLost
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### Focused

Raised when the [IsFocused](../sadconsole.iscreenobject/#isfocused/) property is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
event EventHandler Focused
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)