---
title: PredicateInstruction Class
slug: reference/sadconsole.instructions.predicateinstruction
sidebar:
  label: PredicateInstruction
editUrl: false
description: Instruction that waits until the code callback returns true.
---
## Definition

Instruction that waits until the code callback returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public class PredicateInstruction : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### PredicateInstruction(Func\<bool>)

Creates a new instruction with the specified callback.

```csharp title="C#"
public PredicateInstruction(Func<bool> callback)
```

#### Parameters

`callback` [Func\<bool\>](https://learn.microsoft.com/dotnet/api/system.func-1/)  
The code invoked by this instruction. Return <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to set [IsFinished](../sadconsole.instructions.instructionbase/#isfinished).


## Properties

### ID

Friendly ID to help track what this code instruction was created from since it cannot be fully serialized.

```csharp title="C#"
public string ID { get; set; }
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


### SetCallback(Func\<bool>)

Sets the callback used by the instruction.

```csharp title="C#"
public void SetCallback(Func<bool> callback)
```

#### Parameters

`callback` [Func\<bool\>](https://learn.microsoft.com/dotnet/api/system.func-1/)  
The code invoked by this instruction. Return <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to set [IsFinished](../sadconsole.instructions.instructionbase/#isfinished).