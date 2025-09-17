---
title: SadRogueColorExtensions Class
slug: reference/sadrogue.primitives.sadroguecolorextensions
sidebar:
  label: SadRogueColorExtensions
---
## Definition

Extension methods for `SadRogue.Primitives.Color` that enable operations involving `Microsoft.Xna.Framework.Color`.

```csharp title="C#"
public static class SadRogueColorExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToMonoColor(Color)

Converts from `SadRogue.Primitives.Color` to `Microsoft.Xna.Framework.Color`.

```csharp title="C#"
public static Color ToMonoColor(this Color self)
```

#### Parameters

`self` SadRogue.Primitives.Color  

#### Returns

Microsoft.Xna.Framework.Color

### Matches(Color, Color)

Compares a `SadRogue.Primitives.Color` to a `Microsoft.Xna.Framework.Color`.

```csharp title="C#"
public static bool Matches(this Color self, Color other)
```

#### Parameters

`self` SadRogue.Primitives.Color  

`other` Microsoft.Xna.Framework.Color  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)