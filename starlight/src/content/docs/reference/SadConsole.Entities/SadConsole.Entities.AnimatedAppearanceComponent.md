---
title: AnimatedAppearanceComponent Class
slug: reference/sadconsole.entities.animatedappearancecomponent
sidebar:
  label: AnimatedAppearanceComponent
---
## Definition

A component for [Entity](../sadconsole.entities.entity/) that animates the [AppearanceSingle](../sadconsole.entities.entity/#appearancesingle/) property.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class AnimatedAppearanceComponent : UpdateComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### AnimatedAppearanceComponent()

```csharp title="C#"
public AnimatedAppearanceComponent()
```


## Properties

### Frames

The frames of animation.

```csharp title="C#"
public ColoredGlyphAndEffect[] Frames { get; set; }
```

### AnimationTime

The total time it takes to play all [Frames](../sadconsole.entities.animatedappearancecomponent/#frames/).

```csharp title="C#"
public TimeSpan AnimationTime { get; set; }
```

### IsRepeatable

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, the animation will automatically restart after the last frame is applied. Otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> and the animation stops when completed.

```csharp title="C#"
public bool IsRepeatable { get; set; }
```

## Methods

### OnAdded(IScreenObject)

Called by the component system when this component is added to an object. Must be of type [Entity](../sadconsole.entities.entity/).

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The component host.

#### Exceptions

[InvalidCastException](https://learn.microsoft.com/dotnet/api/system.invalidcastexception/)  
This component was added to a type other than [Entity](../sadconsole.entities.entity/).


### OnRemoved(IScreenObject)

Called by the component system when this component is removed from an object.

```csharp title="C#"
public override void OnRemoved(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The component host.


### Update(IScreenObject, TimeSpan)

Updates the animation frame index and applies the animation to the entity.

```csharp title="C#"
public override void Update(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The component host.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time between calls to this method.


### Start()

Starts the animation and immediately applies the current frame to the entity.

```csharp title="C#"
public void Start()
```

#### Exceptions

[InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception/)  
The animation was started but there aren't any frames to animate.


### Stop()

Stops the animation.

```csharp title="C#"
public void Stop()
```


### Restart()

Restarts the animation at the first frame.

```csharp title="C#"
public void Restart()
```