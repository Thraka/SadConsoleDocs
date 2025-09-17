---
title: MonoPointExtensions Class
slug: reference/microsoft.xna.framework.monopointextensions
sidebar:
  label: MonoPointExtensions
---
## Definition

Extension methods for `Microsoft.Xna.Framework.Point` that enable operations involving `SadRogue.Primitives.Point`.

```csharp title="C#"
public static class MonoPointExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToPoint(Point)

Converts from `Microsoft.Xna.Framework.Point` to `SadRogue.Primitives.Point`.

```csharp title="C#"
public static Point ToPoint(this Point self)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

#### Returns

SadRogue.Primitives.Point

### Add(Point, Point)

Adds a `SadRogue.Primitives.Point` to a `Microsoft.Xna.Framework.Point`.

```csharp title="C#"
public static Point Add(this Point self, Point other)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`other` SadRogue.Primitives.Point  

#### Returns

Microsoft.Xna.Framework.Point

### Add(Point, int)

Adds an integer to both the X and Y values of a `Microsoft.Xna.Framework.Point`.

```csharp title="C#"
public static Point Add(this Point self, int i)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`i` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

Microsoft.Xna.Framework.Point

### Add(Point, Direction)

Adds a `SadRogue.Primitives.Direction` to a `Microsoft.Xna.Framework.Point`.

```csharp title="C#"
public static Point Add(this Point self, Direction dir)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`dir` SadRogue.Primitives.Direction  

#### Returns

Microsoft.Xna.Framework.Point

### Subtract(Point, Point)

Subtracts a `SadRogue.Primitives.Point` from a `Microsoft.Xna.Framework.Point`.

```csharp title="C#"
public static Point Subtract(this Point self, Point other)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`other` SadRogue.Primitives.Point  

#### Returns

Microsoft.Xna.Framework.Point

### Subtract(Point, int)

Subtracts an integer from both the X and Y values of a `Microsoft.Xna.Framework.Point`.

```csharp title="C#"
public static Point Subtract(this Point self, int i)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`i` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

Microsoft.Xna.Framework.Point

### Subtract(Point, Direction)

Subtracts a `SadRogue.Primitives.Direction` from a `Microsoft.Xna.Framework.Point`.

```csharp title="C#"
public static Point Subtract(this Point self, Direction dir)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`dir` SadRogue.Primitives.Direction  

#### Returns

Microsoft.Xna.Framework.Point

### Multiply(Point, Point)

Multiplies a `Microsoft.Xna.Framework.Point` by a `SadRogue.Primitives.Point`.

```csharp title="C#"
public static Point Multiply(this Point self, Point other)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`other` SadRogue.Primitives.Point  

#### Returns

Microsoft.Xna.Framework.Point

### Multiply(Point, int)

Multiplies the X and Y values of a `Microsoft.Xna.Framework.Point` by an integer.

```csharp title="C#"
public static Point Multiply(this Point self, int i)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`i` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

Microsoft.Xna.Framework.Point

### Multiply(Point, double)

Multiplies the X and Y values of a `Microsoft.Xna.Framework.Point` by a double, then rounds the values to the nearest integer.

```csharp title="C#"
public static Point Multiply(this Point self, double d)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`d` [double](https://learn.microsoft.com/dotnet/api/system.double/)  

#### Returns

Microsoft.Xna.Framework.Point

### Divide(Point, Point)

Divides a `Microsoft.Xna.Framework.Point` by a `SadRogue.Primitives.Point`, and rounds the resulting X and Y values to the nearest integer.

```csharp title="C#"
public static Point Divide(this Point self, Point other)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`other` SadRogue.Primitives.Point  

#### Returns

Microsoft.Xna.Framework.Point

### Divide(Point, double)

Divides the X and Y values of a `Microsoft.Xna.Framework.Point` by a double, then rounds the values to the nearest integer.

```csharp title="C#"
public static Point Divide(this Point self, double d)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`d` [double](https://learn.microsoft.com/dotnet/api/system.double/)  

#### Returns

Microsoft.Xna.Framework.Point

### Matches(Point, Point)

Compares a `Microsoft.Xna.Framework.Point` to a `SadRogue.Primitives.Point`.

```csharp title="C#"
public static bool Matches(this Point self, Point other)
```

#### Parameters

`self` Microsoft.Xna.Framework.Point  

`other` SadRogue.Primitives.Point  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)