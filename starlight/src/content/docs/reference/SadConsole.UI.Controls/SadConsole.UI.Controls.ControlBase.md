---
title: ControlBase Class
slug: reference/sadconsole.ui.controls.controlbase
sidebar:
  label: ControlBase
---
## Definition

Base class for all controls.

```csharp title="C#"
[DataContract]
public abstract class ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ControlBase(int, int)

Creates a control.

```csharp title="C#"
protected ControlBase(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


## Fields

### MouseState_IsMouseOver

A cached value determined by [OnMouseEnter(ControlMouseState)](../sadconsole.ui.controls.controlbase/#/). <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the mouse is over the bounds defined by [MouseArea](../sadconsole.ui.controls.controlbase/#mousearea/) .

```csharp title="C#"
protected bool MouseState_IsMouseOver
```

### MouseState_EnteredWithButtonDown

A cached value determined by [OnMouseEnter(ControlMouseState)](../sadconsole.ui.controls.controlbase/#/). <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the mouse entered the control's bounds with the mouse button down.

```csharp title="C#"
protected bool MouseState_EnteredWithButtonDown
```

### MouseState_IsMouseLeftDown

A cached value determined by [OnMouseIn(ControlMouseState)](../sadconsole.ui.controls.controlbase/#/). <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the left mouse button is down.

```csharp title="C#"
protected bool MouseState_IsMouseLeftDown
```

### MouseState_IsMouseRightDown

A cached value determined by [OnMouseIn(ControlMouseState)](../sadconsole.ui.controls.controlbase/#/). <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the right mouse button is down.

```csharp title="C#"
protected bool MouseState_IsMouseRightDown
```

## Properties

### ThemeState

The theme of the control based on its state.

```csharp title="C#"
public ThemeStates ThemeState { get; set; }
```

### UseKeyboard

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to allow this control to respond to keyboard interactions when focused.

```csharp title="C#"
[DataMember]
public bool UseKeyboard { get; set; }
```

### UseMouse

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to allow this control to respond to mouse interactions.

```csharp title="C#"
[DataMember]
public bool UseMouse { get; set; }
```

### CanFocus

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate this control can be focused, generally by clicking on the control or tabbing with the keyboard. Otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public bool CanFocus { get; set; }
```

### CanResize

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this control can be resized with the `SadConsole.UI.Controls.ControlBase.Resize(System.Int32%2cSystem.Int32)` method; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public bool CanResize { get; protected set; }
```

### AlternateFont

An alternate font used to render this control.

```csharp title="C#"
[DataMember]
public IFont? AlternateFont { get; set; }
```

### Surface

The cell data to render the control. Controlled by a theme.

```csharp title="C#"
public ICellSurface Surface { get; set; }
```

### MouseArea

The relative region the of the control used for mouse input.

```csharp title="C#"
[DataMember]
public Rectangle MouseArea { get; set; }
```

### IsMouseButtonStateClean

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the mouse button state has only been set with this control and not another; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsMouseButtonStateClean { get; }
```
## Remarks

This property is only set when the mouse enters the control with the buttons pressed. Once the buttons are let go, the mouse is considered clean for this control.

### Position

The relative position of this control.

```csharp title="C#"
[DataMember]
public Point Position { get; set; }
```

### AbsolutePosition

Gets the position of this control based on the control's [Position](../sadconsole.ui.controls.controlbase/#position/) and the position of the [Parent](../sadconsole.ui.controls.controlbase/#parent/).

```csharp title="C#"
public Point AbsolutePosition { get; }
```

### IsVisible

Indicates whether or not this control is visible.

```csharp title="C#"
[DataMember]
public bool IsVisible { get; set; }
```

### Tag

A user-definable data object.

```csharp title="C#"
public object? Tag { get; set; }
```

### TabStop

Indicates whether or not this control can be tabbed to.

```csharp title="C#"
[DataMember]
public bool TabStop { get; set; }
```

### TabIndex

Sets the tab index of this control.

```csharp title="C#"
[DataMember]
public int TabIndex { get; set; }
```

### IsDirty

Indicates whether or not this control is dirty and should be redrawn.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### Name

Represents a name to identify a control by.

```csharp title="C#"
[DataMember]
public string? Name { get; init; }
```

### FocusOnMouseClick

Gets or sets whether or not this control will become focused when the mouse is clicked.

```csharp title="C#"
[DataMember]
public bool FocusOnMouseClick { get; set; }
```

### Width

The width of the control.

```csharp title="C#"
public int Width { get; protected set; }
```

### Height

The height of the control.

```csharp title="C#"
public int Height { get; protected set; }
```

### IsFocused

Gets or sets whether or not this control is focused.

```csharp title="C#"
public bool IsFocused { get; set; }
```

### IsEnabled

Gets or sets whether or not this control is enabled.

```csharp title="C#"
[DataMember]
public bool IsEnabled { get; set; }
```

### Bounds

The area of the host this control covers.

```csharp title="C#"
public Rectangle Bounds { get; }
```

### Parent

Gets or sets the parent container of this control.

```csharp title="C#"
public IContainer? Parent { get; set; }
```

### State

The state of the control.

```csharp title="C#"
public ControlStates State { get; protected set; }
```

## Methods

### OnUnfocused()

Called when the control loses focus.

```csharp title="C#"
protected virtual void OnUnfocused()
```


### OnFocused()

Called when the control is focused.

```csharp title="C#"
protected virtual void OnFocused()
```


### OnIsDirtyChanged()

Called when the [IsDirty](../sadconsole.ui.controls.controlbase/#isdirty/) property changes value.

```csharp title="C#"
protected virtual void OnIsDirtyChanged()
```


### ProcessKeyboard(Keyboard)

Called when the keyboard is used on this control.

```csharp title="C#"
public virtual bool ProcessKeyboard(Keyboard state)
```

#### Parameters

`state` [Keyboard](../sadconsole.input.keyboard/)  
The state of the keyboard.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### ProcessMouse(MouseScreenObjectState)

Checks if the mouse is the control and calls the appropriate mouse methods.

```csharp title="C#"
public virtual bool ProcessMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Mouse information.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the control is enabled, set to use the mouse and the mouse is over it, otherwise false.

### LostMouse(MouseScreenObjectState)

Called to trigger the state of losing mouse focus.

```csharp title="C#"
public void LostMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The mouse state.


### OnParentChanged()

Called when the parent property is changed.

```csharp title="C#"
protected virtual void OnParentChanged()
```


### OnPositionChanged()

Called when the control changes position.

```csharp title="C#"
protected virtual void OnPositionChanged()
```


### PlaceRelativeTo(ControlBase, Types, int)

Places this control relative to another, taking into account the bounds of the control.

```csharp title="C#"
public void PlaceRelativeTo(ControlBase control, Direction.Types direction, int padding = 1)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The other control to place this one relative to.

`direction` SadRogue.Primitives.Direction.Types  
The direction this control should be placed.

`padding` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Additional space between the controls after placement.

#### Remarks

If this control hasn't been added to the parent of `control`, it will be added.

### DetermineState()

Sets the appropriate theme for the control based on the current state of the control.

```csharp title="C#"
public virtual void DetermineState()
```

#### Remarks

Called by the control as the mouse state changes, like when the mouse is clicked on top of the control or leaves the area of the control. This method is implemented by each derived control.

### OnStateChanged(ControlStates, ControlStates)

Called when the [State](../sadconsole.ui.controls.controlbase/#state/) changes. Sets the [IsDirty](../sadconsole.ui.controls.controlbase/#isdirty/) to true.

```csharp title="C#"
protected virtual void OnStateChanged(ControlStates oldState, ControlStates newState)
```

#### Parameters

`oldState` [ControlStates](../sadconsole.ui.controls.controlstates/)  
The original state.

`newState` [ControlStates](../sadconsole.ui.controls.controlstates/)  
The new state.


### OnSurfaceChanged(ICellSurface, ICellSurface)

Called when the [Surface](../sadconsole.ui.controls.controlbase/#surface/) property is set.

```csharp title="C#"
protected virtual void OnSurfaceChanged(ICellSurface oldSurface, ICellSurface newSurface)
```

#### Parameters

`oldSurface` [ICellSurface](../sadconsole.icellsurface/)  
The previous surface instance.

`newSurface` [ICellSurface](../sadconsole.icellsurface/)  
The new surface instance.


### FindThemeFont()

Returns the [AlternateFont](../sadconsole.ui.controls.controlbase/#alternatefont/). If null, returns the host's console font or the default engine font.

```csharp title="C#"
public IFont FindThemeFont()
```

#### Returns

[IFont](../sadconsole.ifont/)

### FindThemeColors()

Returns the colors assigned to this control, the parent, or the library default.

```csharp title="C#"
public Colors FindThemeColors()
```

#### Returns

[Colors](../sadconsole.ui.colors/)  
The found colors.

### SetThemeColors(Colors?)

Sets the theme colors used by this control. When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, indicates this control should read the theme colors from the parent.

```csharp title="C#"
public void SetThemeColors(Colors? value)
```

#### Parameters

`value` [Colors](../sadconsole.ui.colors/)  
The colors to use with this control.


### HasThemeColors()

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the control has custom theme colors assigned to it; othwerise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasThemeColors()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Resize(int, int)

Resizes the control if the [CanResize](../sadconsole.ui.controls.controlbase/#canresize/) property is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public virtual void Resize(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The desired height of the control.


### OnResized()

Called when `SadConsole.UI.Controls.ControlBase.Resize(System.Int32%2cSystem.Int32)` was called.

```csharp title="C#"
protected virtual void OnResized()
```


### CreateControlSurface()

Generates the surface to be used by this control. This method is called internally to assign the [Surface](../sadconsole.ui.controls.controlbase/#surface/) property a value.

```csharp title="C#"
protected virtual ICellSurface CreateControlSurface()
```

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
A surface that should be assigned to the [Surface](../sadconsole.ui.controls.controlbase/#surface/) property.

### RefreshThemeStateColors(Colors)

Updates the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/) by calling [RefreshTheme(Colors)](../sadconsole.ui.themestates/#/) with the provided colors. Override this method to adjust how colors are used by the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/).

```csharp title="C#"
protected virtual void RefreshThemeStateColors(Colors colors)
```

#### Parameters

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply to the theme state.


### OnMouseEnter(ControlMouseState)

Called when the mouse first enters the control. Raises the MouseEnter event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected virtual void OnMouseEnter(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnMouseExit(ControlMouseState)

Called when the mouse exits the area of the control. Raises the MouseExit event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected virtual void OnMouseExit(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnMouseIn(ControlMouseState)

Called as the mouse moves around the control area. Raises the MouseMove event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected virtual void OnMouseIn(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnLeftMouseClicked(ControlMouseState)

Called when the left mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected virtual void OnLeftMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data


### OnRightMouseClicked(ControlMouseState)

Called when the right mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected virtual void OnRightMouseClicked(ControlBase.ControlMouseState state)
```

#### Parameters

`state` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  
The current mouse data.


### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public abstract void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.


## Events

### IsDirtyChanged

Raised when the [IsDirty](../sadconsole.ui.controls.controlbase/#isdirty/) property changes.

```csharp title="C#"
public event EventHandler<EventArgs>? IsDirtyChanged
```

#### Event Type

[EventHandler\<EventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### Focused

Raised when the [IsFocused](../sadconsole.ui.controls.controlbase/#isfocused/) is set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public event EventHandler<EventArgs>? Focused
```

#### Event Type

[EventHandler\<EventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### Unfocused

Raised when the [IsFocused](../sadconsole.ui.controls.controlbase/#isfocused/) is set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public event EventHandler<EventArgs>? Unfocused
```

#### Event Type

[EventHandler\<EventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### PositionChanged

Raised when the [Position](../sadconsole.ui.controls.controlbase/#position/) property changes value.

```csharp title="C#"
public event EventHandler<EventArgs>? PositionChanged
```

#### Event Type

[EventHandler\<EventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseEnter

Raised when the mouse enters this control.

```csharp title="C#"
public event EventHandler<ControlBase.ControlMouseState>? MouseEnter
```

#### Event Type

[EventHandler\<ControlBase.ControlMouseState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseExit

Raised when the mouse exits this control.

```csharp title="C#"
public event EventHandler<ControlBase.ControlMouseState>? MouseExit
```

#### Event Type

[EventHandler\<ControlBase.ControlMouseState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseMove

Raised when the mouse is moved over this control.

```csharp title="C#"
public event EventHandler<ControlBase.ControlMouseState>? MouseMove
```

#### Event Type

[EventHandler\<ControlBase.ControlMouseState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseButtonClicked

Raised when a mouse button is clicked while the mouse is over this control.

```csharp title="C#"
public event EventHandler<ControlBase.ControlMouseState>? MouseButtonClicked
```

#### Event Type

[EventHandler\<ControlBase.ControlMouseState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)