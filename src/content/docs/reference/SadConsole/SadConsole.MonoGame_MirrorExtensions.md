---
title: MonoGame_MirrorExtensions Class
slug: reference/sadconsole.monogame_mirrorextensions
sidebar:
  label: MonoGame_MirrorExtensions
editUrl: false
description: Extensions for `SadConsole.Mirror`.
---
## Definition

Extensions for [Mirror](../sadconsole.mirror/).

```csharp title="C#"
public static class MonoGame_MirrorExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToMonoGame(Mirror)

Converts a [Mirror](../sadconsole.mirror/) type to a MonoGame ``Microsoft.Xna.Framework.Graphics.SpriteEffects`` type.

```csharp title="C#"
public static SpriteEffects ToMonoGame(this Mirror mirror)
```

#### Parameters

`mirror` [Mirror](../sadconsole.mirror/)  
The value to convert.

#### Returns

Microsoft.Xna.Framework.Graphics.SpriteEffects  
The MonoGame equivalent.