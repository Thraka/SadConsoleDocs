---
title: EntityManagerZoned.ZoneMoveEventArgs Class
slug: reference/sadconsole.entities.entitymanagerzoned.zonemoveeventargs
sidebar:
  label: EntityManagerZoned.ZoneMoveEventArgs
---
## Definition

Contains event data for a [Zone](../sadconsole.entities.zone/) and [Entity](../sadconsole.entities.entity/) interaction.

```csharp title="C#"
public class EntityManagerZoned.ZoneMoveEventArgs : EntityManagerZoned.ZoneEventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EntityManagerZoned.ZoneEventArgs](../sadconsole.entities.entitymanagerzoned/)

## Constructors

### ZoneMoveEventArgs(IScreenSurface, Zone, Entity, Point, Point)

Creates a new event args for a zone movement event.

```csharp title="C#"
public ZoneMoveEventArgs(IScreenSurface host, Zone zone, Entity entity, Point triggeredPosition, Point movedFromPosition)
```

#### Parameters

`host` [IScreenSurface](../sadconsole.iscreensurface/)  
The host that the zone and entity share.

`zone` [Zone](../sadconsole.entities.zone/)  
The zone associated with the event.

`entity` [Entity](../sadconsole.entities.entity/)  
The entity associated with the event.

`triggeredPosition` SadRogue.Primitives.Point  
The new position within the zone associated with the event.

`movedFromPosition` SadRogue.Primitives.Point  
The position within the zone that the entity moved from.


## Fields

### MovedFromPosition

The position within the zone that the entity moved from.

```csharp title="C#"
public readonly Point MovedFromPosition
```