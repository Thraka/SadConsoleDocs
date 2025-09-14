---
title: DrawCallColor Class
slug: reference/sadconsole.drawcalls.drawcallcolor
sidebar:
  label: DrawCallColor
---
## Definition

Draws a colored rectangle to the active [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch/).

```csharp title="C#"
public class DrawCallColor : IDrawCall
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IDrawCall](../sadconsole.drawcalls.idrawcall/)

## Constructors

### DrawCallColor(Color, Texture2D, Rectangle, Rectangle)

Creates a new instance of this draw call.

```csharp title="C#"
public DrawCallColor(Color color, Texture2D texture, Rectangle targetRect, Rectangle fontSolidRect)
```

#### Parameters

`color` Microsoft.Xna.Framework.Color  
The folor of the rectangle.

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  
The texture containing a solid white rectangle referenced by <code class="paramref">fontSolidRect</code>.

`targetRect` Microsoft.Xna.Framework.Rectangle  
The drawing location of the rectangle.

`fontSolidRect` Microsoft.Xna.Framework.Rectangle  
The rectangle of the solid white glyph in the <code class="paramref">texture</code>.


## Fields

### Texture

The texture, most likely a SadConsole font texture, containing the solid white rectangle referenced by [FontSolidRect](../sadconsole.drawcalls.drawcallcolor/#fontsolidrect/).

```csharp title="C#"
public Texture2D Texture
```

### FontSolidRect

The solid white glyph rectangle from [Texture](../sadconsole.drawcalls.drawcallcolor/#texture/) used for shading.

```csharp title="C#"
public Rectangle FontSolidRect
```

### Color

The color of the target rectangle.

```csharp title="C#"
public Color Color
```

### TargetRect

Where on the [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch/) the glyph should be drawn.

```csharp title="C#"
public Rectangle TargetRect
```

## Methods

### Draw()

Draws an object.

```csharp title="C#"
public void Draw()
```