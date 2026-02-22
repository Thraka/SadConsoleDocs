---
title: Default Class
slug: reference/sadconsole.stringparser.default
sidebar:
  label: Default
editUrl: false
description: The default string parser.
---
## Definition

The default string parser.

```csharp title="C#"
public class Default : IParser
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IParser](../sadconsole.stringparser.iparser/)

## Constructors

### Default()

```csharp title="C#"
public Default()
```


## Fields

### CustomProcessor

Custom processor called before the build in command resolver.

```csharp title="C#"
public Func<string, string, ColoredGlyphAndEffect[], ICellSurface?, ParseCommandStacks?, ParseCommandBase?>? CustomProcessor
```
#### Remarks

Signature is ("command", "parameters", existing glyphs, text surface, associated editor, command stacks).

## Properties

### Variables

A dictionary of variable resolution methods.

```csharp title="C#"
public Dictionary<string, Func<string>> Variables { get; }
```

## Methods

### Parse(ReadOnlySpan\<char>, int, ICellSurface?, ParseCommandStacks?)

Creates a colored string by parsing commands embedded in the string.

```csharp title="C#"
public ColoredString Parse(ReadOnlySpan<char> value, int surfaceIndex = -1, ICellSurface? surface = null, ParseCommandStacks? initialBehaviors = null)
```

#### Parameters

`value` [ReadOnlySpan\<char\>](https://learn.microsoft.com/dotnet/api/system.readonlyspan-1/)  
The string to parse.

`surfaceIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Index of where this string will be printed.

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface the string will be printed to.

`initialBehaviors` [ParseCommandStacks](../sadconsole.stringparser.parsecommandstacks/)  
Any initial defaults.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
The finalized string.