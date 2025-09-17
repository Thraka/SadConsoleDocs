---
title: Parser Class
slug: reference/sadconsole.stringparser.bbcode.parser
sidebar:
  label: Parser
---
## Definition

A BBCode string parser.

```csharp title="C#"
public class Parser : IParser
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IParser](../sadconsole.stringparser.iparser/)

## Constructors

### Parser()

Creates a new instanace of the class.

```csharp title="C#"
public Parser()
```


## Properties

### Tags

A collection of tags used by the parser.

```csharp title="C#"
public Dictionary<string, Type> Tags { get; set; }
```

## Methods

### Parse(ReadOnlySpan<char>, int, ICellSurface?, ParseCommandStacks?)

Creates a colored string by parsing BBCode commands embedded in the string.

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