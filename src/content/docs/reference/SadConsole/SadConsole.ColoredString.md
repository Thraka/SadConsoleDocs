---
title: ColoredString Class
slug: reference/sadconsole.coloredstring
sidebar:
  label: ColoredString
editUrl: false
description: Represents a string that has foreground and background colors for each character in the string.
---
## Definition

Represents a string that has foreground and background colors for each character in the string.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class ColoredString : IEnumerable<ColoredGlyphAndEffect>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IEnumerable\<ColoredGlyphAndEffect\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### ColoredString()

Default constructor.

```csharp title="C#"
public ColoredString()
```


### ColoredString(int)

Creates a new instance of the ColoredString class with the specified blank characters.

```csharp title="C#"
public ColoredString(int capacity)
```

#### Parameters

`capacity` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of blank characters.


### ColoredString(string, bool)

Creates a new instance of this class with the specified string value.

```csharp title="C#"
public ColoredString(string value, bool treatAsString = false)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The backing string.

`treatAsString` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, sets all of the Ignore properties to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, treating this instance as a normal string.


### ColoredString(string, Color, Color, Mirror, CellDecorator[]?)

Creates a new instance of the ColoredString class with the specified string value, foreground and background colors, and a cell effect.

```csharp title="C#"
public ColoredString(string value, Color foreground, Color background, Mirror mirror = Mirror.None, CellDecorator[]? decorators = null)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The backing string.

`foreground` SadRogue.Primitives.Color  
The foreground color for each character.

`background` SadRogue.Primitives.Color  
The background color for each character.

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror for each character.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators to apply to each character.


### ColoredString(string, ColoredGlyphAndEffect)

Creates a new instance of the ColoredString class with the specified string value, foreground and background colors, and a cell effect.

```csharp title="C#"
public ColoredString(string value, ColoredGlyphAndEffect appearance)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The backing string.

`appearance` [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/)  
The appearance to use for each character.


### ColoredString(params ColoredGlyphAndEffect[])

Combines a [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) array into a [ColoredString](../sadconsole.coloredstring/).

```csharp title="C#"
public ColoredString(params ColoredGlyphAndEffect[] glyphs)
```

#### Parameters

`glyphs` [ColoredGlyphAndEffect[]](../sadconsole.coloredglyphandeffect/)  
The glyphs to combine.


### ColoredString(params ColoredGlyphBase[])

Combines a [ColoredGlyphBase](../sadconsole.coloredglyphbase/) array into a [ColoredString](../sadconsole.coloredstring/).

```csharp title="C#"
public ColoredString(params ColoredGlyphBase[] glyphs)
```

#### Parameters

`glyphs` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The glyphs to combine.


## Properties

### this[int]

Gets a [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) from the string.

```csharp title="C#"
public ColoredGlyphAndEffect this[int index] { get; set; }
```

### String

Gets or sets the characters representing this string. When set, first processes the string through [Parse(ReadOnlySpan\<char\>, int, ICellSurface, ParseCommandStacks)](../sadconsole.stringparser.iparser/#parsereadonlyspanchar-int-icellsurface-parsecommandstacks) method from [Parser](../sadconsole.coloredstring/#parser).

```csharp title="C#"
public string String { get; set; }
```

### Length

The total number of [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) characters in the string.

```csharp title="C#"
public int Length { get; }
```

### IgnoreGlyph

When true, instructs a caller to not render the glyphs of the string.

```csharp title="C#"
[DataMember]
public bool IgnoreGlyph { get; set; }
```

### IgnoreForeground

When true, instructs a caller to not render the foreground color.

```csharp title="C#"
[DataMember]
public bool IgnoreForeground { get; set; }
```

### IgnoreBackground

When true, instructs a caller to not render the background color.

```csharp title="C#"
[DataMember]
public bool IgnoreBackground { get; set; }
```

### IgnoreEffect

When true, instructs a caller to not render the effect.

```csharp title="C#"
[DataMember]
public bool IgnoreEffect { get; set; }
```

### IgnoreMirror

When true, instructs a caller to not render the mirror state.

```csharp title="C#"
[DataMember]
public bool IgnoreMirror { get; set; }
```

### IgnoreDecorators

When true, instructs a caller to not render the mirror state.

```csharp title="C#"
[DataMember]
public bool IgnoreDecorators { get; set; }
```

### Parser

The string parser to use for transforming strings into [ColoredString](../sadconsole.coloredstring/).

```csharp title="C#"
public static IParser Parser { get; set; }
```

## Methods

### Clone()

Returns a new [ColoredString](../sadconsole.coloredstring/) object by cloning this instance.

```csharp title="C#"
public ColoredString Clone()
```

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A new [ColoredString](../sadconsole.coloredstring/) object.

### SubString(int)

Returns a new [ColoredString](../sadconsole.coloredstring/) object using a substring of this instance from the index to the end.

```csharp title="C#"
public ColoredString SubString(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index to copy the contents from.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A new [ColoredString](../sadconsole.coloredstring/) object.

### SubString(int, int)

Returns a new [ColoredString](../sadconsole.coloredstring/) object using a substring of this instance.

```csharp title="C#"
public ColoredString SubString(int index, int count)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index to copy the contents from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The count of [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) objects to copy.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A new [ColoredString](../sadconsole.coloredstring/) object.

### SetEffect(ICellEffect?)

Applies the referenced cell effect to every character in the colored string.

```csharp title="C#"
public void SetEffect(ICellEffect? effect)
```

#### Parameters

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
The effect to apply.


### SetForeground(Color)

Applies the referenced color to every character foreground in the colored string.

```csharp title="C#"
public void SetForeground(Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to apply.


### SetBackground(Color)

Applies the referenced color to every character background in the colored string.

```csharp title="C#"
public void SetBackground(Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to apply.


### SetGlyph(int)

Applies the referenced glyph to every character in the colored string.

```csharp title="C#"
public void SetGlyph(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to apply.


### SetMirror(Mirror)

Applies the mirror value to each character in the colored string.

```csharp title="C#"
public void SetMirror(Mirror mirror)
```

#### Parameters

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror mode.


### SetDecorators(IEnumerable\<CellDecorator>)

Applies the decorators to each character in the colored string.

```csharp title="C#"
public void SetDecorators(IEnumerable<CellDecorator> decorators)
```

#### Parameters

`decorators` [IEnumerable\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The decorators.


### SetDecorators(params CellDecorator[])

Applies the decorators to each character in the colored string.

```csharp title="C#"
public void SetDecorators(params CellDecorator[] decorators)
```

#### Parameters

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators.


### ToString()

Returns a string representing the glyphs in this object.

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A string composed of each glyph in this object.

### GetEnumerator()

Gets an enumerator for the [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) objects in this string.

```csharp title="C#"
public IEnumerator<ColoredGlyphAndEffect> GetEnumerator()
```

#### Returns

[IEnumerator\<ColoredGlyphAndEffect\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)  
The enumerator in the string.

### FromGradient(Gradient, string)

Creates a new colored string from the specified gradient and text.

```csharp title="C#"
public static ColoredString FromGradient(Gradient colors, string text)
```

#### Parameters

`colors` SadRogue.Primitives.Gradient  
The gradient of colors to apply to the text.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text the colored string contains.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A colored string.