---
title: Entity Class
slug: reference/sadconsole.entities.entity
sidebar:
  label: Entity
---
## Definition

A positioned and animated game object.

```csharp title="C#"
[DataContract]
public class Entity : ScreenObject, IScreenObject, IPositionable, IComponentHost, IHasID
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/)

Implements [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), SadRogue.Primitives.IHasID

## Constructors

### Entity(Animated, int)

Creates a new entity as an animated surface.

```csharp title="C#"
public Entity(Entity.Animated appearance, int zIndex)
```

#### Parameters

`appearance` [Entity.Animated](../sadconsole.entities.entity/)  
The surface appearance to use for the entity.

`zIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The rendering order. Higher values are drawn on top of lower values.


### Entity(AnimatedScreenObject, int)

Creates a new entity as an animated surface.

```csharp title="C#"
public Entity(AnimatedScreenObject appearance, int zIndex)
```

#### Parameters

`appearance` [AnimatedScreenObject](../sadconsole.animatedscreenobject/)  
The surface appearance to use for the entity.

`zIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The rendering order. Higher values are drawn on top of lower values.


### Entity(SingleCell, int)

Creates a new entity as a single cell.

```csharp title="C#"
public Entity(Entity.SingleCell appearance, int zIndex)
```

#### Parameters

`appearance` [Entity.SingleCell](../sadconsole.entities.entity/)  
The single cell appearance to use for the entity.

`zIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The rendering order. Higher values are drawn on top of lower values.


### Entity(ColoredGlyphBase, int)

Creates a new entity, copying the provided appearance to this entity.

```csharp title="C#"
public Entity(ColoredGlyphBase appearance, int zIndex)
```

#### Parameters

`appearance` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance of the entity.

`zIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The rendering order. Lower values are under higher values.


### Entity(Color, Color, int, int)

Creates a new entity, copying the provided appearance to this entity.

```csharp title="C#"
public Entity(Color foreground, Color background, int glyph, int zIndex)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The foreground color of the entity.

`background` SadRogue.Primitives.Color  
The background color of the entity.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph color of the entity.

`zIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The rendering order. Lower values are under higher values.


## Properties

### Name

A friendly name of the game object.

```csharp title="C#"
[DataMember]
public string Name { get; set; }
```

### ZIndex

The drawing layer this entity is drawn at

```csharp title="C#"
[DataMember]
public int ZIndex { get; set; }
```

### IsDirty

Indicates this entity's visual appearance has changed.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### UsePixelPositioning

Treats the `SadRogue.Primitives.IPositionable.Position` of the entity as if it is pixels and not cells.

```csharp title="C#"
public bool UsePixelPositioning { get; set; }
```

### AppearanceSingle

The appearance of the entity when [IsSingleCell](../sadconsole.entities.entity/#issinglecell/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public Entity.SingleCell? AppearanceSingle { get; set; }
```

### AppearanceSurface

The appearance of the entity when [IsSingleCell](../sadconsole.entities.entity/#issinglecell/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public Entity.Animated? AppearanceSurface { get; set; }
```

### IsSingleCell

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this entity is a single cell entity; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> and it's an animated surface entity.

```csharp title="C#"
public bool IsSingleCell { get; set; }
```

## Methods

### OnPositionChanged(Point, Point)

Raises the [PositionChanged](../sadconsole.screenobject/#positionchanged/) event.

```csharp title="C#"
protected override void OnPositionChanged(Point oldPosition, Point newPosition)
```

#### Parameters

`oldPosition` SadRogue.Primitives.Point  
The previous position.

`newPosition` SadRogue.Primitives.Point  
The new position.


### OnIsDirtyChanged()

Raises the [IsDirtyChanged](../sadconsole.entities.entity/#isdirtychanged/) event.

```csharp title="C#"
protected virtual void OnIsDirtyChanged()
```


### UpdateAbsolutePosition()

Sets a value for [AbsolutePosition](../sadconsole.iscreenobject/#absoluteposition/) based on the `SadRogue.Primitives.IPositionable.Position` of this instance and the [Parent](../sadconsole.iscreenobject/#parent/) instance.

```csharp title="C#"
public override void UpdateAbsolutePosition()
```


### Update(TimeSpan)

If an effect is applied to the cell, updates the effect.

```csharp title="C#"
public override void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  


### ToString()

Returns the name of the entity prefixed with "Entity - ".

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name.

### Save(string)

Saves the [Entity](../sadconsole.entities.entity/) to a file.

```csharp title="C#"
public void Save(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The destination file.


### Load(string)

Loads a [Entity](../sadconsole.entities.entity/) from a file.

```csharp title="C#"
public static Entity Load(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The source file.

#### Returns

[Entity](../sadconsole.entities.entity/)  
The entity.

## Events

### IsDirtyChanged

Raised when the [IsDirty](../sadconsole.entities.entity/#isdirty/) property changes value.

```csharp title="C#"
public event EventHandler? IsDirtyChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)