---
title: DrawCallGlyph Class
slug: reference/sadconsole.drawcalls.drawcallglyph
sidebar:
  label: DrawCallGlyph
---
## Definition

Draws a glyph to the active [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch/).

```csharp title="C#"
public class DrawCallGlyph : IDrawCall
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IDrawCall](../sadconsole.drawcalls.idrawcall/)

## Constructors

### DrawCallGlyph(ColoredGlyphBase, Rectangle, IFont, bool)

Creates a new instance of this draw call.

```csharp title="C#"
public DrawCallGlyph(ColoredGlyphBase cell, Rectangle targetRect, IFont font, bool drawBackground)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to be drawn.

`targetRect` Microsoft.Xna.Framework.Rectangle  
Where on the <xref href="SadConsole.Host.Global.SharedSpriteBatch" data-throw-if-not-resolved="false"></xref> the glyph should be drawn.

`font` [IFont](../sadconsole.ifont/)  
The font to use when drawing the glyph.

`drawBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, draws the <xref href="SadConsole.ColoredGlyphBase.Background" data-throw-if-not-resolved="false"></xref> color for the glyph; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.


## Fields

### Font

The font to use when drawing the glyph.

```csharp title="C#"
public IFont Font
```

### Cell

The glyph to be drawn.

```csharp title="C#"
public ColoredGlyphBase Cell
```

### TargetRect

Where on the [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch/) the glyph should be drawn.

```csharp title="C#"
public Rectangle TargetRect
```

### DrawBackground

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, draws the [Background](../sadconsole.coloredglyphbase/#background/) color for the glyph; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool DrawBackground
```

## Methods

### Draw()

Draws an object.

```csharp title="C#"
public void Draw()
```