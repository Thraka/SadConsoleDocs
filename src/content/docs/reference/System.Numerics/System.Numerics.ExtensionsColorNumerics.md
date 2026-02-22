---
title: ExtensionsColorNumerics Class
slug: reference/system.numerics.extensionscolornumerics
sidebar:
  label: ExtensionsColorNumerics
editUrl: false
description: Extensions to convert `System.Numerics.Vector4` to/from `SadRogue.Primitives.Color`.
---
## Definition

Extensions to convert [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/) to/from ``SadRogue.Primitives.Color``.

```csharp title="C#"
public static class ExtensionsColorNumerics
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToVector4(Color)

Converts a ``SadRogue.Primitives.Color`` to a [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/).

```csharp title="C#"
public static Vector4 ToVector4(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to convert.

#### Returns

[Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  
The [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/) representing the color.

### ToVector3(Color)

Converts a ``SadRogue.Primitives.Color`` to a [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3/).

```csharp title="C#"
public static Vector3 ToVector3(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to convert.

#### Returns

[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3/)  
The [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3/) representing the color.

### ToColor(Vector4)

Converts a [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/) to a ``SadRogue.Primitives.Color``.

```csharp title="C#"
public static Color ToColor(this Vector4 value)
```

#### Parameters

`value` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  
The vector color to convert.

#### Returns

SadRogue.Primitives.Color  
The ``SadRogue.Primitives.Color`` representing the color.

### ToColor(Vector3)

Converts a [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3/) to a ``SadRogue.Primitives.Color``.

```csharp title="C#"
public static Color ToColor(this Vector3 value)
```

#### Parameters

`value` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3/)  
The vector color to convert.

#### Returns

SadRogue.Primitives.Color  
The ``SadRogue.Primitives.Color`` representing the color.

### ToVector2(Point)

Converts a ``SadRogue.Primitives.Point`` to a [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/).

```csharp title="C#"
public static Vector2 ToVector2(this Point point)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The point to convert.

#### Returns

[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  
The [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/) representing the point.

### ToUV(Point, Point)

Gets a [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/) representing the UV coordinates of a ``SadRogue.Primitives.Point`` within a ``SadRogue.Primitives.Point`` size.

```csharp title="C#"
public static Vector2 ToUV(this Point point, Point size)
```

#### Parameters

`point` SadRogue.Primitives.Point  
The coordinates within the size.

`size` SadRogue.Primitives.Point  
The size.

#### Returns

[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  
The UV coordinates.