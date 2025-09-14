---
title: MonoRectangleExtensions Class
slug: reference/microsoft.xna.framework.monorectangleextensions
sidebar:
  label: MonoRectangleExtensions
---
## Definition

Extension methods for `Microsoft.Xna.Framework.Rectangle` that enable operations involving `SadRogue.Primitives.Rectangle`.

```csharp title="C#"
public static class MonoRectangleExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToRectangle(Rectangle)

Converts from `Microsoft.Xna.Framework.Rectangle` to `SadRogue.Primitives.Rectangle`.

```csharp title="C#"
public static Rectangle ToRectangle(this Rectangle self)
```

#### Parameters

`self` Microsoft.Xna.Framework.Rectangle  

#### Returns

SadRogue.Primitives.Rectangle

### Matches(Rectangle, Rectangle)

Compares a `Microsoft.Xna.Framework.Rectangle` to a `SadRogue.Primitives.Rectangle`.

```csharp title="C#"
public static bool Matches(this Rectangle self, Rectangle other)
```

#### Parameters

`self` Microsoft.Xna.Framework.Rectangle  

`other` SadRogue.Primitives.Rectangle  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)