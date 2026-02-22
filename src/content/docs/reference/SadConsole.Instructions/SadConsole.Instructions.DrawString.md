---
title: DrawString Class
slug: reference/sadconsole.instructions.drawstring
sidebar:
  label: DrawString
editUrl: false
description: Draws a string to a console as if someone was typing.
---
## Definition

Draws a string to a console as if someone was typing.

```csharp title="C#"
public class DrawString : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### DrawString(ColoredString, TimeSpan)

Creates a new instance of the object with the specified text.

```csharp title="C#"
public DrawString(ColoredString text, TimeSpan duration)
```

#### Parameters

`text` [ColoredString](../sadconsole.coloredstring/)  
The text to print.

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time to print the entire text.


### DrawString(ColoredString)

Creates a new instance of the object with the specified text. Prints the text in one second.

```csharp title="C#"
public DrawString(ColoredString text)
```

#### Parameters

`text` [ColoredString](../sadconsole.coloredstring/)  


### DrawString()

Creates a new instance of the object. [Text](../sadconsole.instructions.drawstring/#text) must be set manually.

```csharp title="C#"
public DrawString()
```


## Properties

### Text

Gets or sets the text to print.

```csharp title="C#"
public ColoredString Text { get; set; }
```

### TotalTimeToPrint

Gets or sets the total time to take to write the string. Use [Zero](https://learn.microsoft.com/dotnet/api/system.timespan.zero/) for no duration.

```csharp title="C#"
public TimeSpan TotalTimeToPrint { get; set; }
```

### Position

Gets or sets the position on the console to write the text.

```csharp title="C#"
public Point Position { get; set; }
```

### Cursor

Represents the cursor used in printing. Use this for styling and printing behavior.

```csharp title="C#"
public Cursor? Cursor { get; set; }
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

On the base class, resets the [IsFinished](../sadconsole.instructions.instructionbase/#isfinished) to false. Override this method to reset the derived class' counters and status flags for the instruction.

### OnAdded(IScreenObject)

Creates an invisible cursor that prints on the target surface.

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host this instruction is added to.