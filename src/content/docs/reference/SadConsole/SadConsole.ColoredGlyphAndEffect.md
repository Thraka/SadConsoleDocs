---
title: ColoredGlyphAndEffect Class
slug: reference/sadconsole.coloredglyphandeffect
sidebar:
  label: ColoredGlyphAndEffect
editUrl: false
description: A `SadConsole.ColoredGlyphBase` with a `SadConsole.Effects.ICellEffect`.
---
## Definition

A [ColoredGlyphBase](../sadconsole.coloredglyphbase/) with a [ICellEffect](../sadconsole.effects.icelleffect/).

```csharp title="C#"
public sealed class ColoredGlyphAndEffect : ColoredGlyph, IMatchable<ColoredGlyphBase>, IMatchable<ColoredGlyph>, IMatchable<ColoredGlyphAndEffect>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ColoredGlyphBase](../sadconsole.coloredglyphbase/) → [ColoredGlyph](../sadconsole.coloredglyph/)

Implements [IMatchable\<ColoredGlyphBase\>](../sadconsole.coloredglyphbase/), [IMatchable\<ColoredGlyph\>](../sadconsole.coloredglyph/), [IMatchable\<ColoredGlyphAndEffect\>](../sadconsole.coloredglyphandeffect/)

## Constructors

### ColoredGlyphAndEffect()

```csharp title="C#"
public ColoredGlyphAndEffect()
```


## Properties

### Effect

The effect of this cell.

```csharp title="C#"
public ICellEffect? Effect { get; set; }
```

## Methods

### FromColoredGlyph(ColoredGlyphBase, ICellEffect?)

Creates a new [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) from a [ColoredGlyphBase](../sadconsole.coloredglyphbase/) with the specified effect.

```csharp title="C#"
public static ColoredGlyphAndEffect FromColoredGlyph(ColoredGlyphBase glyph, ICellEffect? effect = null)
```

#### Parameters

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
When provided, sets the [Effect](../sadconsole.coloredglyphandeffect/#effect).

#### Returns

[ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/)

### CopyAppearanceTo(ColoredGlyphAndEffect, bool)

Copies the visual appearance to the specified cell. This includes foreground, background, glyph, mirror effect and decorators.

```csharp title="C#"
public void CopyAppearanceTo(ColoredGlyphAndEffect cell, bool deepCopy = true)
```

#### Parameters

`cell` [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/)  
The target cell to copy to.

`deepCopy` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Whether to perform a deep copy.  Decorators are copied to a new array when true; when false, the old decorator array reference is moved directly.


### CopyAppearanceFrom(ColoredGlyphAndEffect, bool)

Sets the foreground, background, glyph, mirror effect and decorators to the same as the specified cell.

```csharp title="C#"
public void CopyAppearanceFrom(ColoredGlyphAndEffect cell, bool deepCopy = true)
```

#### Parameters

`cell` [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/)  
The target cell to copy from.

`deepCopy` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Whether to perform a deep copy.  Decorators are copied to a new array when true; when false, the old decorator array reference is moved directly.


### Clear()

Resets the foreground, background, glyph, mirror effect and decorators.

```csharp title="C#"
public override void Clear()
```


### Clone()

Returns a new cell with the same properties as this one.

```csharp title="C#"
public override ColoredGlyphBase Clone()
```

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The new cell.

### Matches(ColoredGlyphAndEffect?)

Checks if this [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) object's properties match another's.

```csharp title="C#"
public bool Matches(ColoredGlyphAndEffect? other)
```

#### Parameters

`other` [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/)  
The other object to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the object's properties match; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.