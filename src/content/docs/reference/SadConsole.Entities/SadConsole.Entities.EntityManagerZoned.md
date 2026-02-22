---
title: EntityManagerZoned Class
slug: reference/sadconsole.entities.entitymanagerzoned
sidebar:
  label: EntityManagerZoned
editUrl: false
description: Manages a set of entities. Adds a render step and only renders the entities that are in the parent `SadConsole.IScreenSurface` visible area.
---
## Definition

Manages a set of entities. Adds a render step and only renders the entities that are in the parent [IScreenSurface](../sadconsole.iscreensurface/) visible area.

```csharp title="C#"
[DataContract]
public class EntityManagerZoned : EntityManager, IList<Entity>, ICollection<Entity>, IEnumerable<Entity>, IEnumerable, IDisposable, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/) → [EntityManager](../sadconsole.entities.entitymanager/)

Implements [IList\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IComponent](../sadconsole.components.icomponent/)

## Constructors

### EntityManagerZoned()

Creates a new manager to handle entity movement within zones.

```csharp title="C#"
public EntityManagerZoned()
```


## Fields

### _zones

The zones in this manager.

```csharp title="C#"
[DataMember(Name = "Zones")]
protected List<Zone> _zones
```

## Properties

### Zones

The zones associated with this manager.

```csharp title="C#"
public IReadOnlyList<Zone> Zones { get; }
```

## Methods

### Add(Zone)

Adds a zone to this manager.

```csharp title="C#"
public void Add(Zone zone)
```

#### Parameters

`zone` [Zone](../sadconsole.entities.zone/)  
The zone to add.


### Remove(Zone)

Removes a zone from this manager.

```csharp title="C#"
public void Remove(Zone zone)
```

#### Parameters

`zone` [Zone](../sadconsole.entities.zone/)  
The hotspot to remove.


### Contains(Zone)

Checks if the manager contains the specified zone.

```csharp title="C#"
public bool Contains(Zone zone)
```

#### Parameters

`zone` [Zone](../sadconsole.entities.zone/)  
The zone to check for.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### GetEntityAtPosition(Point)

Returns an entity at the specified position or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> if there is no entity. If there are multiple entities at the specified position, only one of them is returned.

```csharp title="C#"
public Entity? GetEntityAtPosition(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position to get an entity at.

#### Returns

[Entity](../sadconsole.entities.entity/)  
The entity if it exists; otherwise it returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### GetEntitiesAtPosition(Point)

Returns an enumerator containing the entities, if any, at the specified position.

```csharp title="C#"
public ListEnumerator<Entity> GetEntitiesAtPosition(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position to get an entity at.

#### Returns

SadRogue.Primitives.ListEnumeratorSadConsole.Entities.Entity  
An array of entities if they exist; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### HasEntityAt(Point)

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when there is an entity at the specified position; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasEntityAt(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A value indicating if an entity exists.

### GetZonesAtPosition(Point)

Returns a collection of zones at the specified position.

```csharp title="C#"
public Zone[] GetZonesAtPosition(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position to check for zones.

#### Returns

[Zone[]](../sadconsole.entities.zone/)  
Every zone that contains the position.

### GetEntitiesInZone(Zone)

Returns a list of entities that are located in the specified zone.

```csharp title="C#"
public IReadOnlyList<Entity> GetEntitiesInZone(Zone zone)
```

#### Parameters

`zone` [Zone](../sadconsole.entities.zone/)  
The zone to filter entities by.

#### Returns

[IReadOnlyList\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1/)  
A list of entities.

### OnEntityChangedPosition(Entity, ValueChangedEventArgs\<Point>)

Called when an entity changes position.

```csharp title="C#"
protected override void OnEntityChangedPosition(Entity entity, ValueChangedEventArgs<Point> e)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity that moved.

`e` SadRogue.Primitives.ValueChangedEventArgsSadRogue.Primitives.Point  
The previous and new values of the position.


### OnEntityAdded(Entity)

Adds entity state information to an entity when it's added.

```csharp title="C#"
protected override void OnEntityAdded(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity that was added.


### OnEntityRemoved(Entity)

Removes the entity state information of an entity being removed.

```csharp title="C#"
protected override void OnEntityRemoved(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity that was removed.


### OnEntityEnterZone(IScreenSurface, Zone, Entity, Point)

Called when an entity enters a zone and raises the [EnterZone](../sadconsole.entities.entitymanagerzoned/#enterzone) event.

```csharp title="C#"
protected virtual void OnEntityEnterZone(IScreenSurface host, Zone zone, Entity entity, Point triggeredPosition)
```

#### Parameters

`host` [IScreenSurface](../sadconsole.iscreensurface/)  
The host that the zone and entity share.

`zone` [Zone](../sadconsole.entities.zone/)  
The zone the entity entered.

`entity` [Entity](../sadconsole.entities.entity/)  
The entity that entered the zone.

`triggeredPosition` SadRogue.Primitives.Point  
The position the entity entered.


### OnEntityExitZone(IScreenSurface, Zone, Entity, Point)

Called when an entity enters a zone and raises the [ExitZone](../sadconsole.entities.entitymanagerzoned/#exitzone) event.

```csharp title="C#"
protected virtual void OnEntityExitZone(IScreenSurface host, Zone zone, Entity entity, Point triggeredPosition)
```

#### Parameters

`host` [IScreenSurface](../sadconsole.iscreensurface/)  
The host that the zone and entity share.

`zone` [Zone](../sadconsole.entities.zone/)  
The zone the entity exited.

`entity` [Entity](../sadconsole.entities.entity/)  
The entity that exited the zone.

`triggeredPosition` SadRogue.Primitives.Point  
The new position the entity left.


### OnEntityMoveZone(IScreenSurface, Zone, Entity, Point, Point)

Called when an entity moves within a zone.

```csharp title="C#"
protected virtual void OnEntityMoveZone(IScreenSurface host, Zone zone, Entity entity, Point newPosition, Point oldPosition)
```

#### Parameters

`host` [IScreenSurface](../sadconsole.iscreensurface/)  
The host that the zone and entity share.

`zone` [Zone](../sadconsole.entities.zone/)  
The zone the entity moved in.

`entity` [Entity](../sadconsole.entities.entity/)  
The entity that moved in the zone.

`newPosition` SadRogue.Primitives.Point  
The position the entity moved to.

`oldPosition` SadRogue.Primitives.Point  
The position the entity moved from.


### GetZonesAtPosition(in Point, out HashSet\<Zone>)

Gets the zones that contain the specified position.

```csharp title="C#"
public bool GetZonesAtPosition(in Point point, out HashSet<Zone> zones)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The position to check.

`zones` [HashSet\<Zone\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset-1/)  
The zones that contain this position.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when at least one zone was found; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### DisableEntity(Entity)

Prevents an entity from being processed with the [Zones](../sadconsole.entities.entitymanagerzoned/#zones).

```csharp title="C#"
public void DisableEntity(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to disable.


### EnableEntity(Entity)

Enables the entity to be processed with with the [Zones](../sadconsole.entities.entitymanagerzoned/#zones).

```csharp title="C#"
public void EnableEntity(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to disable.


### IsEntityDisabled(Entity)

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the entity has been disabled by [DisableEntity(Entity)](../sadconsole.entities.entitymanagerzoned/#disableentityentity); otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsEntityDisabled(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the entity is disabled.

## Events

### EnterZone

An event to indicate that an entity entered a zone.

```csharp title="C#"
public event EventHandler<EntityManagerZoned.ZoneEventArgs>? EnterZone
```

#### Event Type

[EventHandler\<EntityManagerZoned.ZoneEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### ExitZone

An event to indicate that an entity exited a zone.

```csharp title="C#"
public event EventHandler<EntityManagerZoned.ZoneEventArgs>? ExitZone
```

#### Event Type

[EventHandler\<EntityManagerZoned.ZoneEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)