---
title: EntityManagerZoned.ZoneEventArgs Class
slug: reference/sadconsole.entities.entitymanagerzoned.zoneeventargs
sidebar:
  label: EntityManagerZoned.ZoneEventArgs
---
## Definition

Contains event data for a [Zone](../sadconsole.entities.entitymanagerzoned.zoneeventargs/#zone/) and [Entity](../sadconsole.entities.entitymanagerzoned.zoneeventargs/#entity/) interaction.

```csharp title="C#"
public class EntityManagerZoned.ZoneEventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ZoneEventArgs(IScreenSurface, Zone, Entity, Point)

Creates a new event args for a zone interaction.

```csharp title="C#"
public ZoneEventArgs(IScreenSurface host, Zone zone, Entity entity, Point triggeredPosition)
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


## Fields

### Zone

The zone associated with the event.

```csharp title="C#"
public readonly Zone Zone
```

### Entity

The entity associated with the event.

```csharp title="C#"
public readonly Entity Entity
```

### Host

The host that the zone and entity share.

```csharp title="C#"
public readonly IScreenSurface Host
```

### TriggeredPosition

The position within the zone associated with the event.

```csharp title="C#"
public readonly Point TriggeredPosition
```