---
title: ConcurrentInstructions Class
slug: reference/sadconsole.instructions.concurrentinstructions
sidebar:
  label: ConcurrentInstructions
---
## Definition

Runs one or more instructions at the same time. This instruction completes when all added instructions have finished.

```csharp title="C#"
public class ConcurrentInstructions : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### ConcurrentInstructions(IEnumerable<InstructionBase>)

Creates a new instruction that runs the provided instructions concurrently.

```csharp title="C#"
public ConcurrentInstructions(IEnumerable<InstructionBase> instructions)
```

#### Parameters

`instructions` [IEnumerable\<InstructionBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The instructions


## Properties

### Instructions

The instructions to run concurrently.

```csharp title="C#"
public IEnumerable<InstructionBase> Instructions { get; set; }
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


### Repeat()

Repeats the current instruction. Decrements the [RepeatCount](../sadconsole.instructions.instructionbase/#repeatcount/) value (if applicable), and raises the [Repeating](../sadconsole.instructions.instructionbase/#repeating/) event. This method should be overridden in derived classes to customize how the object is reset for a repeat.

```csharp title="C#"
public override void Repeat()
```


### Reset()

Resets the Done flag.

```csharp title="C#"
public override void Reset()
```

#### Remarks

On the base class, resets the [IsFinished](../sadconsole.instructions.instructionbase/#isfinished/) to false. Override this method to reset the derived class' counters and status flags for the instruction.