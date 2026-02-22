---
title: CellDecoratorHelpers Class
slug: reference/sadconsole.celldecoratorhelpers
sidebar:
  label: CellDecoratorHelpers
editUrl: false
description: Helpers for `SadConsole.CellDecorator` and `SadConsole.ColoredGlyphBase.Decorators` which manages null on the property.
---
## Definition

Helpers for [CellDecorator](../sadconsole.celldecorator/) and [Decorators](../sadconsole.coloredglyphbase/#decorators) which manages null on the property.

```csharp title="C#"
public static class CellDecoratorHelpers
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### Pool

The list pool used for creating the decorator lists applied to cells.

```csharp title="C#"
public static IListPool<CellDecorator> Pool { get; set; }
```

## Methods

### SetDecorators(IEnumerable\<CellDecorator>?, ColoredGlyphBase)

Replaces the decorators of a glyph.

```csharp title="C#"
public static void SetDecorators(IEnumerable<CellDecorator>? decorators, ColoredGlyphBase glyph)
```

#### Parameters

`decorators` [IEnumerable\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The decorators to set. <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> clears the decorators.

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to alter.


### SetDecorator(CellDecorator, ColoredGlyphBase)

Replaces the decorators of a glyph with a single decorator.

```csharp title="C#"
public static void SetDecorator(CellDecorator decorator, ColoredGlyphBase glyph)
```

#### Parameters

`decorator` [CellDecorator](../sadconsole.celldecorator/)  
The decorator to set.

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to alter.


### AddDecorators(IEnumerable\<CellDecorator>?, ColoredGlyphBase)

Adds the decorators to a glyph.

```csharp title="C#"
public static void AddDecorators(IEnumerable<CellDecorator>? decorators, ColoredGlyphBase glyph)
```

#### Parameters

`decorators` [IEnumerable\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The decorators to add. Duplicates are skipped.

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to alter.


### AddDecorator(CellDecorator, ColoredGlyphBase)

Adds the specified decorator to a glyph.

```csharp title="C#"
public static void AddDecorator(CellDecorator decorator, ColoredGlyphBase glyph)
```

#### Parameters

`decorator` [CellDecorator](../sadconsole.celldecorator/)  
The decorator to add.

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to alter.


### RemoveDecorators(IEnumerable\<CellDecorator>, ColoredGlyphBase)

Removes the specified decorators from a glyph. If no decorators remain on the glyph, the [Decorators](../sadconsole.coloredglyphbase/#decorators) collection is set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

```csharp title="C#"
public static void RemoveDecorators(IEnumerable<CellDecorator> decorators, ColoredGlyphBase glyph)
```

#### Parameters

`decorators` [IEnumerable\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The decorators to remove.

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to alter.


### RemoveAllDecorators(ColoredGlyphBase)

Removes all decorators from a glyph, returns the list to the pool, and sets the [Decorators](../sadconsole.coloredglyphbase/#decorators) collection to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

```csharp title="C#"
public static void RemoveAllDecorators(ColoredGlyphBase glyph)
```

#### Parameters

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to alter.


### RemoveDecorator(CellDecorator, ColoredGlyphBase)

Removes the specified decorator from a glyph. If no decorators remain on the glyph, the [Decorators](../sadconsole.coloredglyphbase/#decorators) collection is set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

```csharp title="C#"
public static void RemoveDecorator(CellDecorator decorator, ColoredGlyphBase glyph)
```

#### Parameters

`decorator` [CellDecorator](../sadconsole.celldecorator/)  
The decorator to remove.

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to alter.


### CloneDecorators(ColoredGlyphBase)

Returns a new list of decorators from the [Decorators](../sadconsole.coloredglyphbase/#decorators) property of `glyph`.

```csharp title="C#"
public static List<CellDecorator>? CloneDecorators(ColoredGlyphBase glyph)
```

#### Parameters

`glyph` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The glyph to copy the decorators from.

#### Returns

[List\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
A list with all of the decorators from `glyph`. If the glyph's decorators are <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> is returned.

### ItemsMatch(List\<CellDecorator>?, List\<CellDecorator>?)

Determines whether the contents of two [CellDecorator](../sadconsole.celldecorator/) arrays are equal.

```csharp title="C#"
public static bool ItemsMatch(this List<CellDecorator>? self, List<CellDecorator>? other)
```

#### Parameters

`self` [List\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The first object to compare.

`other` [List\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1/)  
The second object to compare.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A boolean value to indicate whether or not the two arrays are considered equal.