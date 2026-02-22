---
title: Timer Class
slug: reference/sadconsole.components.timer
sidebar:
  label: Timer
editUrl: false
description: A simple timer with callback.
---
## Definition

A simple timer with callback.

```csharp title="C#"
public class Timer : UpdateComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### Timer(TimeSpan)

Creates a new timer.

```csharp title="C#"
public Timer(TimeSpan triggerTime)
```

#### Parameters

`triggerTime` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Duration of the timer.


## Properties

### Repeat

If true, the timer will restart when the time has elapsed.

```csharp title="C#"
public bool Repeat { get; set; }
```

### TimerAmount

How many milliseconds to cause the timer to trigger.

```csharp title="C#"
public TimeSpan TimerAmount { get; set; }
```

### IsRunning

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the timer is running; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsRunning { get; protected set; }
```

## Methods

### Update(IScreenObject, TimeSpan)

Updates the timer with the time since the last call.

```csharp title="C#"
public override void Update(IScreenObject console, TimeSpan delta)
```

#### Parameters

`console` [IScreenObject](../sadconsole.iscreenobject/)  
The parent object.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time since the last frame update.


### Restart()

Restarts the timer; raises the [TimerRestart](../sadconsole.components.timer/#timerrestart) event.

```csharp title="C#"
public void Restart()
```


### Start()

Starts the timer; raises the [TimerStart](../sadconsole.components.timer/#timerstart) event.

```csharp title="C#"
public void Start()
```


### Stop()

Starts the timer; raises the [TimerStop](../sadconsole.components.timer/#timerstop) event.

```csharp title="C#"
public void Stop()
```


## Events

### TimerElapsed

Called when the timer elapses.

```csharp title="C#"
public event EventHandler? TimerElapsed
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### TimerRestart

Called when the timer restarts.

```csharp title="C#"
public event EventHandler? TimerRestart
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### TimerStart

Called when the timer starts.

```csharp title="C#"
public event EventHandler? TimerStart
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### TimerStop

Called when the timer stops.

```csharp title="C#"
public event EventHandler? TimerStop
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)