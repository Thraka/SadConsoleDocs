---
title: SadRoguePointExtensions Class
slug: reference/sadrogue.primitives.sadroguepointextensions
sidebar:
  label: SadRoguePointExtensions
editUrl: false
description: Extension methods for `SadRogue.Primitives.Point` that enable operations involving `Microsoft.Xna.Framework.Point`.
---
## Definition

Extension methods for ``SadRogue.Primitives.Point`` that enable operations involving ``Microsoft.Xna.Framework.Point``.

```csharp title="C#"
public static class SadRoguePointExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToMonoPoint(Point)

Converts from ``SadRogue.Primitives.Point`` to ``Microsoft.Xna.Framework.Point``.

```csharp title="C#"
public static Point ToMonoPoint(this Point self)
```

#### Parameters

`self` SadRogue.Primitives.Point  

#### Returns

Microsoft.Xna.Framework.Point

### Add(Point, Point)

Adds a ``Microsoft.Xna.Framework.Point`` to a ``SadRogue.Primitives.Point``.

```csharp title="C#"
public static Point Add(this Point self, Point other)
```

#### Parameters

`self` SadRogue.Primitives.Point  

`other` Microsoft.Xna.Framework.Point  

#### Returns

SadRogue.Primitives.Point

### Subtract(Point, Point)

Subtracts a ``Microsoft.Xna.Framework.Point`` from a ``SadRogue.Primitives.Point``.

```csharp title="C#"
public static Point Subtract(this Point self, Point other)
```

#### Parameters

`self` SadRogue.Primitives.Point  

`other` Microsoft.Xna.Framework.Point  

#### Returns

SadRogue.Primitives.Point

### Multiply(Point, Point)

Multiplies a ``SadRogue.Primitives.Point`` by a ``Microsoft.Xna.Framework.Point``.

```csharp title="C#"
public static Point Multiply(this Point self, Point other)
```

#### Parameters

`self` SadRogue.Primitives.Point  

`other` Microsoft.Xna.Framework.Point  

#### Returns

SadRogue.Primitives.Point

### Divide(Point, Point)

Divides a ``SadRogue.Primitives.Point`` by a ``Microsoft.Xna.Framework.Point``, and rounds the resulting X and Y values to the nearest integer.

```csharp title="C#"
public static Point Divide(this Point self, Point other)
```

#### Parameters

`self` SadRogue.Primitives.Point  

`other` Microsoft.Xna.Framework.Point  

#### Returns

SadRogue.Primitives.Point

### Matches(Point, Point)

Compares a ``SadRogue.Primitives.Point`` to a ``Microsoft.Xna.Framework.Point``.

```csharp title="C#"
public static bool Matches(this Point self, Point other)
```

#### Parameters

`self` SadRogue.Primitives.Point  

`other` Microsoft.Xna.Framework.Point  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)