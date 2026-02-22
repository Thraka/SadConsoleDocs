---
title: SadRogueRectangleExtensions Class
slug: reference/sadrogue.primitives.sadroguerectangleextensions
sidebar:
  label: SadRogueRectangleExtensions
editUrl: false
description: Extension methods for `SadRogue.Primitives.Rectangle` that enable operations involving `Microsoft.Xna.Framework.Rectangle`.
---
## Definition

Extension methods for ``SadRogue.Primitives.Rectangle`` that enable operations involving ``Microsoft.Xna.Framework.Rectangle``.

```csharp title="C#"
public static class SadRogueRectangleExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToMonoRectangle(Rectangle)

Converts from ``SadRogue.Primitives.Rectangle`` to ``Microsoft.Xna.Framework.Rectangle``.

```csharp title="C#"
public static Rectangle ToMonoRectangle(this Rectangle self)
```

#### Parameters

`self` SadRogue.Primitives.Rectangle  

#### Returns

Microsoft.Xna.Framework.Rectangle

### Matches(Rectangle, Rectangle)

Compares a ``SadRogue.Primitives.Rectangle`` to a ``Microsoft.Xna.Framework.Rectangle``.

```csharp title="C#"
public static bool Matches(this Rectangle self, Rectangle other)
```

#### Parameters

`self` SadRogue.Primitives.Rectangle  

`other` Microsoft.Xna.Framework.Rectangle  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)