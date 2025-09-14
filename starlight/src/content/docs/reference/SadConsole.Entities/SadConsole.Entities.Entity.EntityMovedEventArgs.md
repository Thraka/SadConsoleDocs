---
title: Entity.EntityMovedEventArgs Class
slug: reference/sadconsole.entities.entity.entitymovedeventargs
sidebar:
  label: Entity.EntityMovedEventArgs
---
## Definition

Arguments for the entity moved event.

```csharp title="C#"
public class Entity.EntityMovedEventArgs : EventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/)

## Constructors

### EntityMovedEventArgs(Entity, Point)

Creates a new event args for the entity movement.

```csharp title="C#"
public EntityMovedEventArgs(Entity entity, Point oldPosition)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity associated with the event.

`oldPosition` SadRogue.Primitives.Point  
The position the entity moved from.


## Fields

### Entity

The entity associated with the event.

```csharp title="C#"
public readonly Entity Entity
```

### FromPosition

The position the [Entity](../sadconsole.entities.entity.entitymovedeventargs/#entity/) moved from.

```csharp title="C#"
public readonly Point FromPosition
```