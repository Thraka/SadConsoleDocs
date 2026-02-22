---
title: AnimatedBoxGrow Class
slug: reference/sadconsole.instructions.animatedboxgrow
sidebar:
  label: AnimatedBoxGrow
editUrl: false
description: Animates drawing a box. It can either
---
## Definition

Animates drawing a box. It can either

```csharp title="C#"
public class AnimatedBoxGrow : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### AnimatedBoxGrow(Rectangle, TimeSpan, ShapeParameters)

Creates a new animated box defined by the `area`. The box is animated over time and drawn with the set of shape parameters provided.

```csharp title="C#"
public AnimatedBoxGrow(Rectangle area, TimeSpan duration, ShapeParameters shapeParameters)
```

#### Parameters

`area` SadRogue.Primitives.Rectangle  
The final area the box is shown on the screen.

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
How long it takes to animate.

`shapeParameters` [ShapeParameters](../sadconsole.shapeparameters/)  
The shape parameters that define how the box looks.

#### Exceptions

[ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception/)  


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


### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added the component.