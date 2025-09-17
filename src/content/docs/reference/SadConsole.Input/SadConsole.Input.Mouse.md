---
title: Mouse Class
slug: reference/sadconsole.input.mouse
sidebar:
  label: Mouse
---
## Definition

The state of the mouse.

```csharp title="C#"
public class Mouse
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### Mouse()

```csharp title="C#"
public Mouse()
```


## Properties

### ScreenPosition

The pixel position of the mouse on the screen.

```csharp title="C#"
public Point ScreenPosition { get; set; }
```

### MiddleButtonDown

Indicates the middle mouse button is currently being pressed.

```csharp title="C#"
public bool MiddleButtonDown { get; set; }
```

### MiddleButtonDownDuration

The amount of time the middle button has been held down.

```csharp title="C#"
public TimeSpan MiddleButtonDownDuration { get; }
```

### MiddleClicked

Indicates the middle mouse button was clicked. (Held and then released)

```csharp title="C#"
public bool MiddleClicked { get; set; }
```

### MiddleDoubleClicked

Indicates the middle mouse button was double-clicked within one second.

```csharp title="C#"
public bool MiddleDoubleClicked { get; set; }
```

### LeftButtonDown

Indicates the left mouse button is currently being pressed.

```csharp title="C#"
public bool LeftButtonDown { get; set; }
```

### LeftButtonDownDuration

The amount of time the left button has been held down.

```csharp title="C#"
public TimeSpan LeftButtonDownDuration { get; }
```

### LeftClicked

Indicates the left mouse button was clicked. (Held and then released)

```csharp title="C#"
public bool LeftClicked { get; set; }
```

### LeftDoubleClicked

Indicates the left mouse button was double-clicked within one second.

```csharp title="C#"
public bool LeftDoubleClicked { get; set; }
```

### RightButtonDown

Indicates the right mouse button is currently being pressed.

```csharp title="C#"
public bool RightButtonDown { get; set; }
```

### RightButtonDownDuration

The amount of time the right button has been held down.

```csharp title="C#"
public TimeSpan RightButtonDownDuration { get; }
```

### RightClicked

Indicates the right mouse button was clicked. (Held and then released)

```csharp title="C#"
public bool RightClicked { get; set; }
```

### RightDoubleClicked

Indicates the right mouse button was double-clicked within one second.

```csharp title="C#"
public bool RightDoubleClicked { get; set; }
```

### ScrollWheelValue

The cumulative value of the scroll wheel.

```csharp title="C#"
public int ScrollWheelValue { get; set; }
```

### ScrollWheelValueChange

The scroll wheel value change between frames.

```csharp title="C#"
public int ScrollWheelValueChange { get; set; }
```

### IsOnScreen

Indicates that the mouse is currently within the bounds of the rendering area.

```csharp title="C#"
public bool IsOnScreen { get; }
```

## Methods

### Update(TimeSpan)

Reads the mouse state from [GetMouseState()](../sadconsole.gamehost/#getmousestate/).

```csharp title="C#"
public void Update(TimeSpan elapsedSeconds)
```

#### Parameters

`elapsedSeconds` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Fractional seconds passed since Update was called.


### Clear()

Clears the buttons, position, wheel information.

```csharp title="C#"
public void Clear()
```


### Process()

Builds information about the mouse state based on the [FocusedScreenObjects](../sadconsole.gamehost/#focusedscreenobjects/) or [Screen](../sadconsole.gamehost/#screen/). Should be called each frame.

```csharp title="C#"
public virtual void Process()
```


### ClearLastMouseScreenObject()

Unlocks the last screen object the mouse was locked to. Allows another console to become locked to the mouse.

```csharp title="C#"
public void ClearLastMouseScreenObject()
```


### IsMouseOverScreenObjectSurface(IScreenSurface)

Returns true when the mouse is currently over the provided screen object.

```csharp title="C#"
public bool IsMouseOverScreenObjectSurface(IScreenSurface screenObject)
```

#### Parameters

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The screen object to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True or false indicating if the mouse is over the screen object.

### Clone()

Clones this mouse into a new object.

```csharp title="C#"
public Mouse Clone()
```

#### Returns

[Mouse](../sadconsole.input.mouse/)  
A clone.