---
title: AnimatedScreenObject.AnimationStateChangedEventArgs Class
slug: reference/sadconsole.animatedscreenobject.animationstatechangedeventargs
sidebar:
  label: AnimatedScreenObject.AnimationStateChangedEventArgs
editUrl: false
description: Event args for when the animation state changes
---
## Definition

Event args for when the animation state changes

```csharp title="C#"
public class AnimatedScreenObject.AnimationStateChangedEventArgs : EventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/)

## Constructors

### AnimationStateChangedEventArgs(AnimationState, AnimationState)

Creates a new instance of the event args.

```csharp title="C#"
public AnimationStateChangedEventArgs(AnimatedScreenObject.AnimationState previousState, AnimatedScreenObject.AnimationState newState)
```

#### Parameters

`previousState` [AnimatedScreenObject.AnimationState](../sadconsole.animatedscreenobject/)  
The previous state.

`newState` [AnimatedScreenObject.AnimationState](../sadconsole.animatedscreenobject/)  
The new state.


## Fields

### PreviousState

The previous state.

```csharp title="C#"
public readonly AnimatedScreenObject.AnimationState PreviousState
```

### NewState

The new state.

```csharp title="C#"
public readonly AnimatedScreenObject.AnimationState NewState
```