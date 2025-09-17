---
title: InstructionBase Class
slug: reference/sadconsole.instructions.instructionbase
sidebar:
  label: InstructionBase
---
## Definition

Base class for all instructions.

```csharp title="C#"
public abstract class InstructionBase : UpdateComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### InstructionBase()

```csharp title="C#"
protected InstructionBase()
```


## Properties

### RemoveOnFinished

When true, this instruction will automatically remove itself from the parent's [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) collection.

```csharp title="C#"
public bool RemoveOnFinished { get; set; }
```

### IsFinished

Flags the instruction as completed or not. If completed, the [Finished](../sadconsole.instructions.instructionbase/#finished/) event will be raised.

```csharp title="C#"
public bool IsFinished { get; set; }
```

### RepeatCount

Indicates how many times this set will repeat. Use 0 to not repeat and -1 to repeat forever.

```csharp title="C#"
public int RepeatCount { get; set; }
```
## Remarks

This property counts down each time the instruction finishes. If set to -1 it will repeat forever. As this represents how many times to repeat, setting this value to 1 would allow the instruction to execute twice, once for the original time, and again for the repeat counter of 1.

## Methods

### Reset()

Resets the Done flag.

```csharp title="C#"
public virtual void Reset()
```

#### Remarks

On the base class, resets the [IsFinished](../sadconsole.instructions.instructionbase/#isfinished/) to false. Override this method to reset the derived class' counters and status flags for the instruction.

### Repeat()

Repeats the current instruction. Decrements the [RepeatCount](../sadconsole.instructions.instructionbase/#repeatcount/) value (if applicable), and raises the [Repeating](../sadconsole.instructions.instructionbase/#repeating/) event. This method should be overridden in derived classes to customize how the object is reset for a repeat.

```csharp title="C#"
public virtual void Repeat()
```


### Update(IScreenObject, TimeSpan)

Executes the instruction. This base class method should be called from derived classes. If the IsFinished property is set to true, will try to repeat if needed and will raise all appropriate events.

```csharp title="C#"
public override void Update(IScreenObject componentHost, TimeSpan delta)
```

#### Parameters

`componentHost` [IScreenObject](../sadconsole.iscreenobject/)  
The object that hosts this instruction.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.


### OnFinished(IScreenObject)

Called when the instruction finishes.

```csharp title="C#"
protected virtual void OnFinished(IScreenObject componentHost)
```

#### Parameters

`componentHost` [IScreenObject](../sadconsole.iscreenobject/)  


### OnRepeating()

Called when the instruction repeats.

```csharp title="C#"
protected virtual void OnRepeating()
```


### OnStarted()

Called when the instruction first runs.

```csharp title="C#"
protected virtual void OnStarted()
```


## Events

### Started

Raised when the instruction starts.

```csharp title="C#"
public event EventHandler? Started
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### Finished

Raised when the instruction completes.

```csharp title="C#"
public event EventHandler? Finished
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### Repeating

Raised when the instruction completes but is going to repeat.

```csharp title="C#"
public event EventHandler? Repeating
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)