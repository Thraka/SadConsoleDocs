---
title: SmoothMove Class
slug: reference/sadconsole.components.smoothmove
sidebar:
  label: SmoothMove
---
## Definition

Animates the movement of an object.

```csharp title="C#"
public class SmoothMove : UpdateComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### SmoothMove()

Creates a new instance of this object with a default transition time of 200 milliseconds.

```csharp title="C#"
public SmoothMove()
```


### SmoothMove(Point)

Creates a new instance of this object with a fixed size for calculating smooth movement.

```csharp title="C#"
public SmoothMove(Point fontSize)
```

#### Parameters

`fontSize` SadRogue.Primitives.Point  
The size of the font used to display the object hosting the component.


### SmoothMove(TimeSpan)

Creates a new instance of this object with a specific transition time.

```csharp title="C#"
public SmoothMove(TimeSpan transitionTime)
```

#### Parameters

`transitionTime` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The amount of time it takes to animate the movement.


### SmoothMove(Point, TimeSpan)

Creates a new instance of this object with a fixed size for calculating smooth movement and the specified transition time.

```csharp title="C#"
public SmoothMove(Point fontSize, TimeSpan transitionTime)
```

#### Parameters

`fontSize` SadRogue.Primitives.Point  
The size of the font used to display the object hosting the component.

`transitionTime` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The amount of time it takes to animate the movement.


## Properties

### IsMoving

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this component currently is animating the movement of the host object; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsMoving { get; }
```

### FontSize

The size of the parent object's font.

```csharp title="C#"
public Point FontSize { get; set; }
```

### IsEnabled

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> to pause this component and prevent it from animating movement; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to enable animating movement.

```csharp title="C#"
public bool IsEnabled { get; set; }
```

### TransitionEasingFunction

The easing function applied to smoothing the objects movement.

```csharp title="C#"
public EasingBase? TransitionEasingFunction { get; set; }
```

### TransitionTime

The amount of time it takes to animated the movement.

```csharp title="C#"
public TimeSpan TransitionTime { get; set; }
```

## Methods

### OnAdded(IScreenObject)

Called by the `host` when the component is added to an object. Add to a [IScreenSurface](../sadconsole.iscreensurface/) or [Entity](../sadconsole.entities.entity/).

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The <xref href="SadConsole.IScreenSurface" data-throw-if-not-resolved="false"></xref> or <xref href="SadConsole.Entities.Entity" data-throw-if-not-resolved="false"></xref>.


### OnRemoved(IScreenObject)

Called when the component is removed from the host.

```csharp title="C#"
public override void OnRemoved(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that removed the component.


### Update(IScreenObject, TimeSpan)

Updates the component. If the object is moving, changes to pixel positioning (if required) and animates the movement.

```csharp title="C#"
public override void Update(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host object being moved.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time difference from the previous frame.


## Events

### MoveStarted

Raised when the smoothing component starts moving an object.

```csharp title="C#"
public event EventHandler? MoveStarted
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### MoveEnded

Raised when the smoothing component ends moving an object.

```csharp title="C#"
public event EventHandler? MoveEnded
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)