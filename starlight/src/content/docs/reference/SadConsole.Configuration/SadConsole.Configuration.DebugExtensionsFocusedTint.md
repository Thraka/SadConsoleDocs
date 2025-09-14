---
title: DebugExtensionsFocusedTint Class
slug: reference/sadconsole.configuration.debugextensionsfocusedtint
sidebar:
  label: DebugExtensionsFocusedTint
---
## Definition

Extensions class for configuring focused object tint debugging.

```csharp title="C#"
public static class DebugExtensionsFocusedTint
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### EnableFocusedObjectTintDebug(Builder)

Adds a [RootComponents](../sadconsole.gamehost/#rootcomponents/) component that tints the currently focused object.

```csharp title="C#"
public static Builder EnableFocusedObjectTintDebug(this Builder builder)
```

#### Parameters

`builder` [Builder](../sadconsole.configuration.builder/)  
The config builder.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The config builder.

### EnableFocusedObjectTintDebug(Builder, Color)

Adds a [RootComponents](../sadconsole.gamehost/#rootcomponents/) component that tints the object under the mouse.

```csharp title="C#"
public static Builder EnableFocusedObjectTintDebug(this Builder builder, Color tintColor)
```

#### Parameters

`builder` [Builder](../sadconsole.configuration.builder/)  
The config builder.

`tintColor` SadRogue.Primitives.Color  
The color to tint objects.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The config builder.