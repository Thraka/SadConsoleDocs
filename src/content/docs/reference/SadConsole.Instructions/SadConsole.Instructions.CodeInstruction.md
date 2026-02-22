---
title: CodeInstruction Class
slug: reference/sadconsole.instructions.codeinstruction
sidebar:
  label: CodeInstruction
editUrl: false
description: An instruction with a code callback.
---
## Definition

An instruction with a code callback.

```csharp title="C#"
public class CodeInstruction : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### CodeInstruction(Func\<IScreenObject, TimeSpan, bool>)

Creates a new instruction with the specified callback.

```csharp title="C#"
public CodeInstruction(Func<IScreenObject, TimeSpan, bool> callback)
```

#### Parameters

`callback` [Func\<IScreenObject, TimeSpan, bool\>](https://learn.microsoft.com/dotnet/api/system.func-3/)  
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


### SetCallback(Func\<IScreenObject, TimeSpan, bool>)

Sets the callback used by the instruction.

```csharp title="C#"
public void SetCallback(Func<IScreenObject, TimeSpan, bool> callback)
```

#### Parameters

`callback` [Func\<IScreenObject, TimeSpan, bool\>](https://learn.microsoft.com/dotnet/api/system.func-3/)  
The code invoked by this instruction. Return <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to set [IsFinished](../sadconsole.instructions.instructionbase/#isfinished).