---
title: InstructionSet Class
slug: reference/sadconsole.instructions.instructionset
sidebar:
  label: InstructionSet
editUrl: false
description: A set of instructions to be executed sequentially.
---
## Definition

A set of instructions to be executed sequentially.

```csharp title="C#"
public class InstructionSet : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### InstructionSet()

```csharp title="C#"
public InstructionSet()
```


## Properties

### Instructions

All instructions in this set.

```csharp title="C#"
public LinkedList<InstructionBase> Instructions { get; }
```

### Name

The name of this instruction to identify it apart from other instruction sets.

```csharp title="C#"
public string Name { get; set; }
```

### CurrentInstruction

Represents the current instruction if this set is currently executing.

```csharp title="C#"
public InstructionBase? CurrentInstruction { get; }
```

## Methods

### Reset()

Resets the Done flag.

```csharp title="C#"
public override void Reset()
```

#### Remarks

On the base class, resets the [IsFinished](../sadconsole.instructions.instructionbase/#isfinished) to false. Override this method to reset the derived class' counters and status flags for the instruction.

### Update(IScreenObject, TimeSpan)

Runs the instruction set. Once all instructions are finished, this set will set the [IsFinished](../sadconsole.instructions.instructionbase/#isfinished) property will be set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public override void Update(IScreenObject componentHost, TimeSpan delta)
```

#### Parameters

`componentHost` [IScreenObject](../sadconsole.iscreenobject/)  

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  


### Wait(TimeSpan)

Adds a new [Wait](../sadconsole.instructions.wait/) instruction with the specified duration to the end of this set.

```csharp title="C#"
public InstructionSet Wait(TimeSpan duration)
```

#### Parameters

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time to wait.

#### Returns

[InstructionSet](../sadconsole.instructions.instructionset/)  
This instruction set.

### Instruct(InstructionBase)

Adds an instruction to the end of this set.

```csharp title="C#"
public InstructionSet Instruct(InstructionBase instruction)
```

#### Parameters

`instruction` [InstructionBase](../sadconsole.instructions.instructionbase/)  

#### Returns

[InstructionSet](../sadconsole.instructions.instructionset/)  
This instruction set.

### Code(Func\<IScreenObject, TimeSpan, bool>)

Adds a new [CodeInstruction](../sadconsole.instructions.codeinstruction/) instruction with the specified callback to the end of this set.

```csharp title="C#"
public InstructionSet Code(Func<IScreenObject, TimeSpan, bool> expression)
```

#### Parameters

`expression` [Func\<IScreenObject, TimeSpan, bool\>](https://learn.microsoft.com/dotnet/api/system.func-3/)  
The code callback.

#### Returns

[InstructionSet](../sadconsole.instructions.instructionset/)  
This instruction set.

### Code(Action)

Adds a new [CodeInstruction](../sadconsole.instructions.codeinstruction/) instruction with the specified callback to the end of this set.

```csharp title="C#"
public InstructionSet Code(Action expression)
```

#### Parameters

`expression` [Action](https://learn.microsoft.com/dotnet/api/system.action/)  
The code callback.

#### Returns

[InstructionSet](../sadconsole.instructions.instructionset/)  
This instruction set.

### WaitTrue(Func\<bool>)

Adds a new [PredicateInstruction](../sadconsole.instructions.predicateinstruction/) instruction with the specified callback to the end of this set.

```csharp title="C#"
public InstructionSet WaitTrue(Func<bool> expression)
```

#### Parameters

`expression` [Func\<bool\>](https://learn.microsoft.com/dotnet/api/system.func-1/)  
The code callback.

#### Returns

[InstructionSet](../sadconsole.instructions.instructionset/)  
This instruction set.

### InstructConcurrent(params InstructionBase[])

Adds a [ConcurrentInstructions](../sadconsole.instructions.concurrentinstructions/) to the end of this set.

```csharp title="C#"
public InstructionSet InstructConcurrent(params InstructionBase[] instructions)
```

#### Parameters

`instructions` [InstructionBase[]](../sadconsole.instructions.instructionbase/)  
Instructions to add. Must be two or more instructions.

#### Returns

[InstructionSet](../sadconsole.instructions.instructionset/)  
This instruction set.