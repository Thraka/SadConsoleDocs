---
title: Entity.Animated Class
slug: reference/sadconsole.entities.entity.animated
sidebar:
  label: Entity.Animated
---
## Definition

An entity that is a an animated surface.

```csharp title="C#"
[DataContract]
public class Entity.Animated
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### Animated(AnimatedScreenObject)

Creates a new instance of this type from an animated screen surface.

```csharp title="C#"
public Animated(AnimatedScreenObject surface)
```

#### Parameters

`surface` [AnimatedScreenObject](../sadconsole.animatedscreenobject/)  
The animation to use.


## Properties

### Animation

The animation associated with this animated entity.

```csharp title="C#"
[DataMember]
public AnimatedScreenObject Animation { get; }
```

### DefaultCollisionRectangle

Represents the collision rectangle for this animated surface which is the size of the animation frame.

```csharp title="C#"
public Rectangle DefaultCollisionRectangle { get; }
```

### CustomCollisionRectangle

A relative collision rectangle that you can specify. Defaults to the size of the animation surface.

```csharp title="C#"
[DataMember]
public Rectangle CustomCollisionRectangle { get; set; }
```
## Remarks

This rectangle should be declared without using the animation center. Only apply the center when you're testing for collision and reading this rectangle.

### IsDirty

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this animation is dirty and needs to be redrawn.

```csharp title="C#"
public bool IsDirty { get; set; }
```

## Methods

### Update(TimeSpan)

Updates the [Animation](../sadconsole.entities.entity.animated/#animation/).

```csharp title="C#"
public void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.