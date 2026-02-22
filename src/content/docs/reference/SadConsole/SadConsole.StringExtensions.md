---
title: StringExtensions Class
slug: reference/sadconsole.stringextensions
sidebar:
  label: StringExtensions
editUrl: false
description: Helpers for strings.
---
## Definition

Helpers for strings.

```csharp title="C#"
public static class StringExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### Align(string, HorizontalAlignment, int)

Aligns a string given a total character width and alignment style. Fills in the extra space with the space character.

```csharp title="C#"
public static string Align(this string value, HorizontalAlignment alignment, int totalWidth)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The current string.

`alignment` [HorizontalAlignment](../sadconsole.horizontalalignment/)  
The horizontal alignment.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the new string.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A new string instance.

### Align(string, HorizontalAlignment, int, char)

Aligns a string given a total character width and alignment style.

```csharp title="C#"
public static string Align(this string value, HorizontalAlignment alignment, int totalWidth, char fillCharacter)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The current string.

`alignment` [HorizontalAlignment](../sadconsole.horizontalalignment/)  
The horizontal alignment.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the new string.

`fillCharacter` [char](https://learn.microsoft.com/dotnet/api/system.char/)  
The character to use to fill in the extra spaces after alignment.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A new string instance.

### CreateColored(string, Color?, Color?, Mirror?, CellDecorator[]?)

Creates a [ColoredString](../sadconsole.coloredstring/) object from an existing string with the specified foreground and background, setting the ignore properties if needed.

```csharp title="C#"
public static ColoredString CreateColored(this string value, Color? foreground = null, Color? background = null, Mirror? mirror = null, CellDecorator[]? decorators = null)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The current string.

`foreground` System.NullableSadRogue.Primitives.Color  
The foreground color. If null, [IgnoreForeground](../sadconsole.coloredstring/#ignoreforeground) will be set.

`background` System.NullableSadRogue.Primitives.Color  
The background color. If null, [IgnoreBackground](../sadconsole.coloredstring/#ignorebackground) will be set.

`mirror` [Mirror?](../sadconsole.mirror/)  
The mirror setting. If null, [IgnoreMirror](../sadconsole.coloredstring/#ignoremirror) will be set.

`decorators` [CellDecorator[]](../sadconsole.celldecorator/)  
The decorators setting. If null, [IgnoreDecorators](../sadconsole.coloredstring/#ignoredecorators) will be set.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A [ColoredString](../sadconsole.coloredstring/) object instance.

### CreateGradient(string, Color, Color)

Creates a [ColoredString](../sadconsole.coloredstring/) object from an existing string with the specified foreground gradient and cell effect.

```csharp title="C#"
public static ColoredString CreateGradient(this string value, Color startingForeground, Color endingForeground)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The current string.

`startingForeground` SadRogue.Primitives.Color  
The starting foreground color to blend.

`endingForeground` SadRogue.Primitives.Color  
The ending foreground color to blend.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A [ColoredString](../sadconsole.coloredstring/) object instance.

### CreateGradient(string, Color, Color, Color, Color)

Creates a [ColoredString](../sadconsole.coloredstring/) object from an existing string with the specified foreground gradient, background gradient, and cell effect.

```csharp title="C#"
public static ColoredString CreateGradient(this string value, Color startingForeground, Color endingForeground, Color startingBackground, Color endingBackground)
```

#### Parameters

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The current string.

`startingForeground` SadRogue.Primitives.Color  
The starting foreground color to blend.

`endingForeground` SadRogue.Primitives.Color  
The ending foreground color to blend.

`startingBackground` SadRogue.Primitives.Color  
The starting background color to blend.

`endingBackground` SadRogue.Primitives.Color  
The ending background color to blend.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A [ColoredString](../sadconsole.coloredstring/) object instance.

### WordWrap(string, int)

Wraps text into lines by words, long words are also properly wrapped into multiple lines.

```csharp title="C#"
public static IEnumerable<string> WordWrap(this string text, int maxCharsPerLine)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to parse.

`maxCharsPerLine` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum number of characters per line of text returned.

#### Returns

[IEnumerable\<string\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
Each line in the string.

### ToBool(string)

Converts a string to a boolean when it is "0", "1", "true", or "false".

```csharp title="C#"
public static bool ToBool(this string item)
```

#### Parameters

`item` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to convert

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
The converted boolean value, otherwise false.

### Masked(string, char)

Returns a string of mask characters the same length as the input string.

```csharp title="C#"
public static string Masked(this string toMask, char mask)
```

#### Parameters

`toMask` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to mask.

`mask` [char](https://learn.microsoft.com/dotnet/api/system.char/)  
The mask to use.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A string of masks.