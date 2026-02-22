---
title: Entity.SingleCell Class
slug: reference/sadconsole.entities.entity.singlecell
sidebar:
  label: Entity.SingleCell
editUrl: false
description: An entity that is a single cell.
---
## Definition

An entity that is a single cell.

```csharp title="C#"
[DataContract]
public class Entity.SingleCell
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### SingleCell(Color, Color, int)

Creates a new entity with the specified foreground, background, and glyph.

```csharp title="C#"
public SingleCell(Color foreground, Color background, int glyph)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The foreground color of the entity.

`background` SadRogue.Primitives.Color  
The background color of the entity.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph color of the entity.


### SingleCell(ColoredGlyphBase)

Creates a new entity, references the provided glyph as the appearance.

```csharp title="C#"
public SingleCell(ColoredGlyphBase appearance)
```

#### Parameters

`appearance` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance of the entity.


## Properties

### IsDirty

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this cell is dirty and needs to be redrawn.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### Appearance

Represents what the entity looks like.

```csharp title="C#"
public ColoredGlyphBase Appearance { get; protected set; }
```

### Effect

An effect that can be applied to the [Appearance](../sadconsole.entities.entity.singlecell/#appearance).

```csharp title="C#"
public ICellEffect? Effect { get; set; }
```

## Methods

### Update(TimeSpan)

If an effect is applied to the cell, updates the effect.

```csharp title="C#"
public void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)