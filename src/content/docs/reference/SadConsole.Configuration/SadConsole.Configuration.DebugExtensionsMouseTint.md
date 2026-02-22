---
title: DebugExtensionsMouseTint Class
slug: reference/sadconsole.configuration.debugextensionsmousetint
sidebar:
  label: DebugExtensionsMouseTint
editUrl: false
description: Extensions class for configuring mouse tint debugging.
---
## Definition

Extensions class for configuring mouse tint debugging.

```csharp title="C#"
public static class DebugExtensionsMouseTint
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### EnableMouseTintDebug(Builder)

Adds a [RootComponents](../sadconsole.gamehost/#rootcomponents) component that tints the object under the mouse ``SadRogue.Primitives.Color.Purple``.

```csharp title="C#"
public static Builder EnableMouseTintDebug(this Builder builder)
```

#### Parameters

`builder` [Builder](../sadconsole.configuration.builder/)  
The config builder.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The config builder.

### EnableMouseTintDebug(Builder, Color)

Adds a [RootComponents](../sadconsole.gamehost/#rootcomponents) component that tints the object under the mouse.

```csharp title="C#"
public static Builder EnableMouseTintDebug(this Builder builder, Color tintColor)
```

#### Parameters

`builder` [Builder](../sadconsole.configuration.builder/)  
The config builder.

`tintColor` SadRogue.Primitives.Color  
The color to tint objects.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The config builder.