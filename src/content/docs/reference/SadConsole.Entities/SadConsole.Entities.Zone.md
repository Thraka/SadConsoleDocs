---
title: Zone Class
slug: reference/sadconsole.entities.zone
sidebar:
  label: Zone
editUrl: false
description: Defines an area for a scene.
---
## Definition

Defines an area for a scene.

```csharp title="C#"
[DataContract]
public class Zone : ScreenObject, IScreenObject, IPositionable, IComponentHost
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/)

Implements [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/)

## Constructors

### Zone(Area)

Creates a new zone object with the specified area.

```csharp title="C#"
public Zone(Area area)
```

#### Parameters

`area` SadRogue.Primitives.Area  
The area of the zone.


### Zone(Rectangle)

Creates a new zone object using the positions of a rectangle.

```csharp title="C#"
public Zone(Rectangle area)
```

#### Parameters

`area` SadRogue.Primitives.Rectangle  
The area of the zone.


### Zone(IEnumerable\<Point>)

Creates a new zone object using the specified positions.

```csharp title="C#"
public Zone(IEnumerable<Point> positions)
```

#### Parameters

`positions` [IEnumerable\<Point\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The positions that make up the zone.


## Fields

### Area

The area the zone covers.

```csharp title="C#"
[DataMember]
public readonly Area Area
```

### Settings

Key-value pairs for the zone.

```csharp title="C#"
[DataMember]
public Dictionary<string, string> Settings
```

## Properties

### Appearance

A visual for the area to help debug.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase? Appearance { get; set; }
```

### Name

The name of the zone.

```csharp title="C#"
[DataMember]
public string Name { get; set; }
```

### Entities

A list of entities in the

```csharp title="C#"
public IReadOnlyList<Entity> Entities { get; }
```

## Methods

### ToString()

Returns the string "Zone - " followed by the [Name](../sadconsole.entities.zone/#name) of the zone. If the name is empty, appends the [Area](../sadconsole.entities.zone/#area) bounds.

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the zone.