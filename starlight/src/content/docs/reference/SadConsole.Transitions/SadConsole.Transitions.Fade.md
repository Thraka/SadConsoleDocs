---
title: Fade Class
slug: reference/sadconsole.transitions.fade
sidebar:
  label: Fade
---
## Definition

Fades out one [IScreenSurface](../sadconsole.iscreensurface/) while fading in another.

```csharp title="C#"
public class Fade : InstructionBase, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [InstructionBase](../sadconsole.instructions.instructionbase/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### Fade(IScreenSurface, IScreenSurface, TimeSpan, EasingBase?)

```csharp title="C#"
public Fade(IScreenSurface from, IScreenSurface to, TimeSpan duration, EasingBase? easingFunction = null)
```

#### Parameters

`from` [IScreenSurface](../sadconsole.iscreensurface/)  

`to` [IScreenSurface](../sadconsole.iscreensurface/)  

`duration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  

`easingFunction` [EasingBase](../sadconsole.easingfunctions.easingbase/)  


## Properties

### DeparentFromObject

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, removes the "From" object from the parent when the transition finishes. Supersedes [HideFromObject](../sadconsole.transitions.fade/#hidefromobject/).

```csharp title="C#"
public bool DeparentFromObject { get; set; }
```

### HideFromObject

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, sets [IsVisible](../sadconsole.iscreenobject/#isvisible/) to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> on the "From" object when the transition finishes.

```csharp title="C#"
public bool HideFromObject { get; set; }
```

### RepositionToObject

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, sets the position of the "To" object to match the "From" object when the transition finishes.

```csharp title="C#"
public bool RepositionToObject { get; set; }
```

## Methods

### Update(IScreenObject, TimeSpan)

Processes the fade between two objects.

```csharp title="C#"
public override void Update(IScreenObject componentHost, TimeSpan delta)
```

#### Parameters

`componentHost` [IScreenObject](../sadconsole.iscreenobject/)  
The host running the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time difference for the frame.