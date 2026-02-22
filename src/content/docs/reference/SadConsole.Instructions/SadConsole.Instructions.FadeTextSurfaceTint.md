---
title: FadeTextSurfaceTint Class
slug: reference/sadconsole.instructions.fadetextsurfacetint
sidebar:
  label: FadeTextSurfaceTint
editUrl: false
description: Animates a color change to `SadConsole.ScreenSurface.Tint`.
---
## Definition

Animates a color change to [Tint](../sadconsole.screensurface/#tint).

```csharp title="C#"
public class FadeTextSurfaceTint : AnimatedValue, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/) → [Wait](../sadconsole.instructions.wait/) → [AnimatedValue](../sadconsole.instructions.animatedvalue/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### FadeTextSurfaceTint(IScreenSurface, Gradient, TimeSpan)

Creates a new tint fade instruction that targets the specified console.

```csharp title="C#"
public FadeTextSurfaceTint(IScreenSurface objectSurface, Gradient colors, TimeSpan duration)
```

#### Parameters

`objectSurface` [IScreenSurface](../sadconsole.iscreensurface/)  
The [Tint](../sadconsole.iscreensurface/#tint) to fade.

`colors` SadRogue.Primitives.Gradient  
The gradient pattern to fade through.

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
How long the fade takes.


### FadeTextSurfaceTint(Gradient, TimeSpan)

Creates a new tint fade instruction that uses the console passed to [Update(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#updateiscreenobject-timespan).

```csharp title="C#"
public FadeTextSurfaceTint(Gradient colors, TimeSpan duration)
```

#### Parameters

`colors` SadRogue.Primitives.Gradient  
The gradient pattern to fade through.

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
How long the fade takes.


### FadeTextSurfaceTint()

Creates a new tint fade instruction with default settings that uses the console passed to [Update(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#updateiscreenobject-timespan).

```csharp title="C#"
public FadeTextSurfaceTint()
```

#### Remarks

The default settings are: - [Colors](../sadconsole.instructions.fadetextsurfacetint/#colors): ``SadRogue.Primitives.Color.White`` to ``SadRogue.Primitives.Color.Black`` - Duration: 1 second

## Properties

### Colors

The color to fade the tint to.

```csharp title="C#"
public Gradient Colors { get; set; }
```

## Methods

### Update(IScreenObject, TimeSpan)

Updates the timer with the time since the last call.

```csharp title="C#"
public override void Update(IScreenObject componentHost, TimeSpan delta)
```

#### Parameters

`componentHost` [IScreenObject](../sadconsole.iscreenobject/)  

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time since the last frame update.