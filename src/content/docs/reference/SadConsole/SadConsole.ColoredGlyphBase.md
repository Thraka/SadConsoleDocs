---
title: ColoredGlyphBase Class
slug: reference/sadconsole.coloredglyphbase
sidebar:
  label: ColoredGlyphBase
editUrl: false
description: Represents an individual piece of a `SadConsole.ICellSurface` containing a glyph, foreground color, background color, and a mirror effect.
---
## Definition

Represents an individual piece of a [ICellSurface](../sadconsole.icellsurface/) containing a glyph, foreground color, background color, and a mirror effect.

```csharp title="C#"
public abstract class ColoredGlyphBase : IMatchable<ColoredGlyphBase>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IMatchable\<ColoredGlyphBase\>](../sadconsole.coloredglyphbase/)

## Constructors

### ColoredGlyphBase()

```csharp title="C#"
protected ColoredGlyphBase()
```


## Properties

### Decorators

Modifies the look of a cell with additional character.

```csharp title="C#"
public List<CellDecorator>? Decorators { get; set; }
```

### Foreground

The foreground color of this cell.

```csharp title="C#"
public Color Foreground { get; set; }
```

### Background

The background color of this cell.

```csharp title="C#"
public Color Background { get; set; }
```

### Glyph

The glyph index from a font for this cell.

```csharp title="C#"
public int Glyph { get; set; }
```

### Mirror

The mirror effect for this cell.

```csharp title="C#"
public Mirror Mirror { get; set; }
```

### GlyphCharacter

The glyph.

```csharp title="C#"
[IgnoreDataMember]
public char GlyphCharacter { get; set; }
```

### IsVisible

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this cell should be drawn; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsVisible { get; set; }
```

### IsDirty

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this cell needs to be redrawn; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsDirty { get; set; }
```

## Methods

### CopyAppearanceTo(ColoredGlyphBase, bool)

Copies the visual appearance to the specified cell. This includes foreground, background, glyph, mirror effect and decorators.

```csharp title="C#"
public virtual void CopyAppearanceTo(ColoredGlyphBase cell, bool deepCopy = true)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The target cell to copy to.

`deepCopy` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Whether to perform a deep copy.  Decorators are copied to a new array when true; when false, the old decorator array reference is moved directly.


### CopyAppearanceFrom(ColoredGlyphBase, bool)

Sets the foreground, background, glyph, mirror effect and decorators to the same as the specified cell.

```csharp title="C#"
public virtual void CopyAppearanceFrom(ColoredGlyphBase cell, bool deepCopy = true)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The target cell to copy from.

`deepCopy` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Whether to perform a deep copy.  Decorators are copied to a new array when true; when false, the old decorator array reference is moved directly.


### Clear()

Resets the foreground, background, glyph, mirror effect and decorators.

```csharp title="C#"
public abstract void Clear()
```


### Clone()

Returns a new cell with the same properties as this one.

```csharp title="C#"
public abstract ColoredGlyphBase Clone()
```

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The new cell.

### Matches(ColoredGlyphBase?)

Checks if this [ColoredGlyph](../sadconsole.coloredglyph/) object's properties match another's.

```csharp title="C#"
public bool Matches(ColoredGlyphBase? other)
```

#### Parameters

`other` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The other object to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the object's properties match; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### CreateArray(int)

Creates an array of colored glyphs.

```csharp title="C#"
public static ColoredGlyphBase[] CreateArray(int size)
```

#### Parameters

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)

## Events

### IsDirtySet

An event that is raised when the [IsDirty](../sadconsole.coloredglyphbase/#isdirty) property is set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public event EventHandler? IsDirtySet
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)