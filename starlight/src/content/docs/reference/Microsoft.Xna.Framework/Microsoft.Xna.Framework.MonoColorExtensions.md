---
title: MonoColorExtensions Class
slug: reference/microsoft.xna.framework.monocolorextensions
sidebar:
  label: MonoColorExtensions
---
## Definition

Extension methods for `Microsoft.Xna.Framework.Color` that enable operations involving `SadRogue.Primitives.Color`.

```csharp title="C#"
public static class MonoColorExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToSadRogueColor(Color)

Converts from `Microsoft.Xna.Framework.Color` to `SadRogue.Primitives.Color`.

```csharp title="C#"
public static Color ToSadRogueColor(this Color self)
```

#### Parameters

`self` Microsoft.Xna.Framework.Color  

#### Returns

SadRogue.Primitives.Color

### Matches(Color, Color)

Compares a `Microsoft.Xna.Framework.Color` to a `SadRogue.Primitives.Color`.

```csharp title="C#"
public static bool Matches(this Color self, Color other)
```

#### Parameters

`self` Microsoft.Xna.Framework.Color  

`other` SadRogue.Primitives.Color  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)