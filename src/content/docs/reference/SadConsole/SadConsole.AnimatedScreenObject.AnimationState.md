---
title: AnimatedScreenObject.AnimationState Enum
slug: reference/sadconsole.animatedscreenobject.animationstate
sidebar:
  label: AnimatedScreenObject.AnimationState
editUrl: false
description: Represents what state the animation is in.
---
## Definition

Represents what state the animation is in.

```csharp title="C#"
public enum AnimatedScreenObject.AnimationState
```


## Fields

### Stopped

The animation has never been played or was forcibly stopped.

```csharp title="C#"
Stopped = 0
```

### Playing

The animation is currently playing.

```csharp title="C#"
Playing = 1
```

### Restarted

The animation was either manually restarted or repeated.

```csharp title="C#"
Restarted = 2
```

### Finished

The animation was played and completed.

```csharp title="C#"
Finished = 3
```

### Activated

The animation is now the current animation for an entity.

```csharp title="C#"
Activated = 4
```

### Deactivated

The animation is no longer the current animation for an entity.

```csharp title="C#"
Deactivated = 5
```