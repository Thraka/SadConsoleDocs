---
title: ExtensionsColorNumericsMonoGame Class
slug: reference/system.numerics.extensionscolornumericsmonogame
sidebar:
  label: ExtensionsColorNumericsMonoGame
editUrl: false
description: Extensions to convert `System.Numerics.Vector4` to/from `SadRogue.Primitives.Color`.
---
## Definition

Extensions to convert [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/) to/from ``SadRogue.Primitives.Color``.

```csharp title="C#"
public static class ExtensionsColorNumericsMonoGame
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToMonoGameColor(Vector4)

Converts a [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/) to a ``Microsoft.Xna.Framework.Color``.

```csharp title="C#"
public static Color ToMonoGameColor(this Vector4 value)
```

#### Parameters

`value` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  
The vector color to convert.

#### Returns

Microsoft.Xna.Framework.Color  
The ``Microsoft.Xna.Framework.Color`` representing the color.

### ToMonoGameColor(Vector3)

Converts a [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3/) to a ``Microsoft.Xna.Framework.Color``.

```csharp title="C#"
public static Color ToMonoGameColor(this Vector3 value)
```

#### Parameters

`value` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3/)  
The vector color to convert.

#### Returns

Microsoft.Xna.Framework.Color  
The ``Microsoft.Xna.Framework.Color`` representing the color.

### ToUV(Point, Point)

Gets a [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/) representing the UV coordinates of a ``Microsoft.Xna.Framework.Point`` within a ``Microsoft.Xna.Framework.Point`` size.

```csharp title="C#"
public static Vector2 ToUV(this Point point, Point size)
```

#### Parameters

`point` Microsoft.Xna.Framework.Point  
The coordinates within the size.

`size` Microsoft.Xna.Framework.Point  
The size.

#### Returns

[Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  
The UV coordinates.