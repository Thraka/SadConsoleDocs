---
title: EntityManager Class
slug: reference/sadconsole.entities.entitymanager
sidebar:
  label: EntityManager
---
## Definition

Manages a set of entities. Adds a render step and only renders the entities that are in the parent [IScreenSurface](../sadconsole.iscreensurface/) visible area.

```csharp title="C#"
[DataContract]
public class EntityManager : UpdateComponent, IComponent, IList<Entity>, ICollection<Entity>, IEnumerable<Entity>, IEnumerable, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/), [IList\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### EntityManager()

```csharp title="C#"
public EntityManager()
```


## Fields

### IsAttached

Indicates that the entity renderer has been added to a parent object.

```csharp title="C#"
protected bool IsAttached
```

### _entities

The entities to process.

```csharp title="C#"
[DataMember(Name = "Entities")]
protected List<Entity> _entities
```

### _entitiesVisible

The entities currently visible.

```csharp title="C#"
protected List<Entity> _entitiesVisible
```

### _screen

The parent screen hosting this component.

```csharp title="C#"
protected IScreenSurface? _screen
```

### _offsetAreaPixels

Cached rectangle for rendering.

```csharp title="C#"
protected Rectangle _offsetAreaPixels
```

### _screenCachedView

A cached copy of the [View](../sadconsole.icellsurface/#view/) of the hosting screen surface.

```csharp title="C#"
protected Rectangle _screenCachedView
```

### _screenCachedFont

A cached copy of the [Font](../sadconsole.iscreensurface/#font/) of the hosting screen surface.

```csharp title="C#"
protected IFont? _screenCachedFont
```

### _screenCachedFontSize

A cached copy of the [FontSize](../sadconsole.iscreensurface/#fontsize/) of the hosting screen surface.

```csharp title="C#"
protected Point _screenCachedFontSize
```

### RenderStep

Internal use only

```csharp title="C#"
public IRenderStep? RenderStep
```

## Properties

### Entities

The entities associated with this manager.

```csharp title="C#"
public IReadOnlyList<Entity> Entities { get; }
```

### EntitiesVisible

The entities within the visible portion of the parent surface.

```csharp title="C#"
public IReadOnlyList<Entity> EntitiesVisible { get; }
```

### IsDirty

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this object needs to be redrawn; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### DoEntityUpdate

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates this manager should call [Update(TimeSpan)](../sadconsole.iscreenobject/#/) on each entity; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool DoEntityUpdate { get; set; }
```

### SkipExistsChecks

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, the [Add(Entity)](../sadconsole.entities.entitymanager/#/) and [Remove(Entity)](../sadconsole.entities.entitymanager/#/) won't check if the entity exists before doing its operation.

```csharp title="C#"
public bool SkipExistsChecks { get; set; }
```

### AlternativeFont

An alternative font to use when drawing the entities. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, the hosting surface's font is used.

```csharp title="C#"
public IFont? AlternativeFont { get; set; }
```

### Count

The number of entities in the renderer.

```csharp title="C#"
public int Count { get; }
```

### IsReadOnly

Always returns false.

```csharp title="C#"
public bool IsReadOnly { get; }
```

### this[int]

Gets an entity by index.

```csharp title="C#"
public Entity this[int index] { get; set; }
```

## Methods

### Add(Entity)

Adds an entity to this manager.

```csharp title="C#"
public void Add(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to add.


### AddRange(IEnumerable<Entity>)

Adds a collection of entities to this manager.

```csharp title="C#"
public void AddRange(IEnumerable<Entity> entities)
```

#### Parameters

`entities` [IEnumerable\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The entities to add.


### AddEntity(Entity, bool)

Adds an entity to the collection, subscribes to events, and calls [OnEntityAdded(Entity)](../sadconsole.entities.entitymanager/#/) and `SadConsole.Entities.EntityManager.OnEntityChangedPosition(SadConsole.Entities.Entity%2cSadRogue.Primitives.ValueChangedEventArgs%7bSadRogue.Primitives.Point%7d)`.

```csharp title="C#"
protected void AddEntity(Entity entity, bool skipSort)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to remove.

`skipSort` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, skips sorting when <xref href="SadConsole.Entities.EntityManager.CalculateEntityVisibilityProtected(SadConsole.Entities.Entity%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref> is called inside this method.


### RemoveEntity(Entity)

Adds an entity to the collection, unsubscribes to events, and calls [OnEntityRemoved(Entity)](../sadconsole.entities.entitymanager/#/).

```csharp title="C#"
protected bool RemoveEntity(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to remove.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Remove(Entity)

Removes an entity from this manager.

```csharp title="C#"
public bool Remove(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to remove.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Clear()

Removes all entities from this renderer.

```csharp title="C#"
public void Clear()
```


### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added the component.


### OnRemoved(IScreenObject)

Called when the component is removed from the host.

```csharp title="C#"
public override void OnRemoved(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that removed the component.


### Update(IScreenObject, TimeSpan)

Called by a host on the update frame.

```csharp title="C#"
public override void Update(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.


### GetRenderRectangle(Point, bool)

Gets a render rectangle for a position.

```csharp title="C#"
public Rectangle GetRenderRectangle(Point position, bool isPixel)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The position of the entity.

`isPixel` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates the entity is pixel positioned.

#### Returns

SadRogue.Primitives.Rectangle

### SortVisibleEntities()

Sorts the [EntitiesVisible](../sadconsole.entities.entitymanager/#entitiesvisible/) collection according to the [ZIndex](../sadconsole.entities.entity/#zindex/) value.

```csharp title="C#"
public void SortVisibleEntities()
```


### OnEntityChangedPosition(Entity, ValueChangedEventArgs<Point>)

Called when an entity changes position.

```csharp title="C#"
protected virtual void OnEntityChangedPosition(Entity entity, ValueChangedEventArgs<Point> e)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity that moved.

`e` SadRogue.Primitives.ValueChangedEventArgsSadRogue.Primitives.Point  
The previous and new values of the position.


### OnEntityAdded(Entity)

Called when an entity is added.

```csharp title="C#"
protected virtual void OnEntityAdded(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity.


### OnEntityRemoved(Entity)

Called when an entity is removed.

```csharp title="C#"
protected virtual void OnEntityRemoved(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity.


### CalculateEntityVisibility(Entity)

Updates the visibility state of an entity.

```csharp title="C#"
public bool CalculateEntityVisibility(Entity entity)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this entity is considered visible; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.
#### Exceptions

[ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception/)  


### CalculateEntityVisibilityProtected(Entity, bool)

Detects a visibility state change of an entity and changes its internal list position.

```csharp title="C#"
protected bool CalculateEntityVisibilityProtected(Entity entity, bool skipSort)
```

#### Parameters

`entity` [Entity](../sadconsole.entities.entity/)  
The entity to check.

`skipSort` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, skips sorting the visible.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the entity is visible; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### UpdateCachedVisibilityArea()

Updates the cached view area based on the parent surface.

```csharp title="C#"
protected void UpdateCachedVisibilityArea()
```


### IndexOf(Entity)

```csharp title="C#"
public int IndexOf(Entity item)
```

#### Parameters

`item` [Entity](../sadconsole.entities.entity/)  

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

### Contains(Entity)

```csharp title="C#"
public bool Contains(Entity item)
```

#### Parameters

`item` [Entity](../sadconsole.entities.entity/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### CopyTo(Entity[], int)

```csharp title="C#"
public void CopyTo(Entity[] array, int arrayIndex)
```

#### Parameters

`array` [Entity[]](../sadconsole.entities.entity/)  

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### GetEnumerator()

```csharp title="C#"
public IEnumerator<Entity> GetEnumerator()
```

#### Returns

[IEnumerator\<Entity\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)

### Dispose(bool)

```csharp title="C#"
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### ~EntityManager()

```csharp title="C#"
protected ~EntityManager()
```


### Dispose()

```csharp title="C#"
public void Dispose()
```