---
title: AnimatedValue Class
slug: reference/sadconsole.instructions.animatedvalue
sidebar:
  label: AnimatedValue
editUrl: false
description: An function that applies an `SadConsole.EasingFunctions.EasingBase` function between two values.
---
## Definition

An function that applies an [EasingBase](../sadconsole.easingfunctions.easingbase/) function between two values.

```csharp title="C#"
public class AnimatedValue : Wait, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/) → [Wait](../sadconsole.instructions.wait/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### AnimatedValue(TimeSpan, double, double, EasingBase?)

Creates a new value animated over time.

```csharp title="C#"
public AnimatedValue(TimeSpan duration, double startingValue, double endingValue, EasingBase? easingFunction = null)
```

#### Parameters

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The total time this animation should run.

`startingValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The starting value of the animation.

`endingValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The ending value of the animation.

`easingFunction` [EasingBase](../sadconsole.easingfunctions.easingbase/)  
The easing function used during animation. Defaults to [Linear](../sadconsole.easingfunctions.linear/).


## Fields

### EasingFunction

The easing function assigned to animate the value.

```csharp title="C#"
protected EasingBase EasingFunction
```

## Properties

### Value

The current or last value of the animation.

```csharp title="C#"
public double Value { get; }
```

### StartingValue

The stating value of the animation.

```csharp title="C#"
public double StartingValue { get; }
```

### EndingValue

The ending value of the animation.

```csharp title="C#"
public double EndingValue { get; }
```

## Methods

### Reset(TimeSpan, double, double, EasingBase?)

Resets this object to new values.

```csharp title="C#"
public void Reset(TimeSpan duration, double startingValue, double endingValue, EasingBase? easingFunction = null)
```

#### Parameters

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The total time this animation should run.

`startingValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The starting value of the animation.

`endingValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The ending value of the animation.

`easingFunction` [EasingBase](../sadconsole.easingfunctions.easingbase/)  
The easing function used during animation. Defaults to [Linear](../sadconsole.easingfunctions.linear/).


### Reset()

Resets the Done flag.

```csharp title="C#"
public override void Reset()
```

#### Remarks

On the base class, resets the [IsFinished](../sadconsole.instructions.instructionbase/#isfinished) to false. Override this method to reset the derived class' counters and status flags for the instruction.

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


## Events

### ValueChanged

Raised when the instruction is running and the value changes during [Update(IScreenObject, TimeSpan)](../sadconsole.instructions.animatedvalue/#updateiscreenobject-timespan).

```csharp title="C#"
public event EventHandler<double>? ValueChanged
```

#### Event Type

[EventHandler\<double\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)