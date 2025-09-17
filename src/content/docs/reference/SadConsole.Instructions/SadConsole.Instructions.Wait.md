---
title: Wait Class
slug: reference/sadconsole.instructions.wait
sidebar:
  label: Wait
---
## Definition

Represents an instruction to pause for a specified duration.

```csharp title="C#"
public class Wait : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### Wait(TimeSpan)

Creates a new wait timer with the specified duration.

```csharp title="C#"
public Wait(TimeSpan duration)
```

#### Parameters

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
How long this instruction waits until it signals <xref href="SadConsole.Instructions.InstructionBase.IsFinished" data-throw-if-not-resolved="false"></xref>.


### Wait()

Creates a new wait timer with a 1-second delay.

```csharp title="C#"
public Wait()
```


## Fields

### CountedTime

How much time has passed.

```csharp title="C#"
protected TimeSpan CountedTime
```

## Properties

### Duration

The duration of the wait.

```csharp title="C#"
public TimeSpan Duration { get; set; }
```

## Methods

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


### Reset()

Resets the Done flag.

```csharp title="C#"
public override void Reset()
```

#### Remarks

On the base class, resets the [IsFinished](../sadconsole.instructions.instructionbase/#isfinished/) to false. Override this method to reset the derived class' counters and status flags for the instruction.