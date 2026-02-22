---
title: ColoredGlyph Class
slug: reference/sadconsole.coloredglyph
sidebar:
  label: ColoredGlyph
editUrl: false
description: Represents an individual piece of a `SadConsole.ICellSurface` containing a glyph, foreground color, background color, and a mirror effect.
---
## Definition

Represents an individual piece of a [ICellSurface](../sadconsole.icellsurface/) containing a glyph, foreground color, background color, and a mirror effect.

```csharp title="C#"
public class ColoredGlyph : ColoredGlyphBase, IMatchable<ColoredGlyphBase>, IMatchable<ColoredGlyph>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ColoredGlyphBase](../sadconsole.coloredglyphbase/)

Implements [IMatchable\<ColoredGlyphBase\>](../sadconsole.coloredglyphbase/), [IMatchable\<ColoredGlyph\>](../sadconsole.coloredglyph/)

## Constructors

### ColoredGlyph()

Creates a cell with a white foreground, black background, glyph 0, and no mirror effect.

```csharp title="C#"
public ColoredGlyph()
```


### ColoredGlyph(Color)

Creates a cell with the specified foreground, black background, glyph 0, and no mirror effect.

```csharp title="C#"
public ColoredGlyph(Color foreground)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color.


### ColoredGlyph(Color, Color)

Creates a cell with the specified foreground, specified background, glyph 0, and no mirror effect.

```csharp title="C#"
public ColoredGlyph(Color foreground, Color background)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color.

`background` SadRogue.Primitives.Color  
Background color.


### ColoredGlyph(Color, Color, int)

Creates a cell with the specified foreground, background, and glyph, with no mirror effect.

```csharp title="C#"
public ColoredGlyph(Color foreground, Color background, int glyph)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color.

`background` SadRogue.Primitives.Color  
Background color.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.


### ColoredGlyph(Color, Color, int, Mirror)

Creates a cell with the specified foreground, background, glyph, and mirror effect.

```csharp title="C#"
public ColoredGlyph(Color foreground, Color background, int glyph, Mirror mirror)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color.

`background` SadRogue.Primitives.Color  
Background color.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror effect.


### ColoredGlyph(Color, Color, int, Mirror, bool)

Creates a cell with the specified foreground, background, glyph, mirror, and visibility.

```csharp title="C#"
public ColoredGlyph(Color foreground, Color background, int glyph, Mirror mirror, bool isVisible)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color.

`background` SadRogue.Primitives.Color  
Background color.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror effect.

`isVisible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
The visibility of the glyph.


### ColoredGlyph(Color, Color, int, Mirror, bool, List\<CellDecorator>)

Creates a cell with the specified foreground, background, glyph, mirror effect, visibility and decorators.

```csharp title="C#"
public ColoredGlyph(Color foreground, Color background, int glyph, Mirror mirror, bool isVisible, List<CellDecorator> decorators)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color.

`background` SadRogue.Primitives.Color  
Background color.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph index.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror effect.

`isVisible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
The visibility of the glyph.

`decorators` [List\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
Decorators for the cell.


## Methods

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

### Matches(ColoredGlyph?)

Checks if this [ColoredGlyph](../sadconsole.coloredglyph/) object's properties match another's.

```csharp title="C#"
public bool Matches(ColoredGlyph? other)
```

#### Parameters

`other` [ColoredGlyph](../sadconsole.coloredglyph/)  
The other object to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the object's properties match; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.