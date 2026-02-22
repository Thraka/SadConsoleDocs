---
title: DrawCallTexture Class
slug: reference/sadconsole.drawcalls.drawcalltexture
sidebar:
  label: DrawCallTexture
editUrl: false
description: Draws an image ot the active `SadConsole.Host.Global.SharedSpriteBatch`.
---
## Definition

Draws an image ot the active [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch).

```csharp title="C#"
public class DrawCallTexture : IDrawCall
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IDrawCall](../sadconsole.drawcalls.idrawcall/)

## Constructors

### DrawCallTexture(Texture2D, Vector2, Color?, Effect)

Creates a new instance of this draw call.

```csharp title="C#"
public DrawCallTexture(Texture2D texture, Vector2 position, Color? tint = null, Effect effect = null)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  
The image to draw.

`position` Microsoft.Xna.Framework.Vector2  
The position on the [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch) to draw the image.

`tint` System.NullableMicrosoft.Xna.Framework.Color  
A color tint to apply to the drawn image.

`effect` Microsoft.Xna.Framework.Graphics.Effect  
A shader to apply to the texture being drawn.

#### Exceptions

[NullReferenceException](https://learn.microsoft.com/dotnet/api/system.nullreferenceexception/)  
Thrown when `texture` is null.


## Fields

### Texture

The image to draw.

```csharp title="C#"
public Texture2D Texture
```

### ShaderEffect

The shader to use when drawing the texture.

```csharp title="C#"
public Effect ShaderEffect
```

### Position

Where on the [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch) to draw the texture.

```csharp title="C#"
public Vector2 Position
```

### Tint

A color tint to apply when drawn.

```csharp title="C#"
public Color Tint
```

## Methods

### Draw()

Draws an object.

```csharp title="C#"
public void Draw()
```