---
title: IParser Interface
slug: reference/sadconsole.stringparser.iparser
sidebar:
  label: IParser
---
## Definition

Describes a parser

```csharp title="C#"
public interface IParser
```


## Methods

### Parse(ReadOnlySpan<char>, int, ICellSurface?, ParseCommandStacks?)

Generates a colored string from a string of characters.

```csharp title="C#"
ColoredString Parse(ReadOnlySpan<char> value, int surfaceIndex = -1, ICellSurface? surface = null, ParseCommandStacks? initialBehaviors = null)
```

#### Parameters

`value` [ReadOnlySpan\<char\>](https://learn.microsoft.com/dotnet/api/system.readonlyspan-1/)  
The characters to process.

`surfaceIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index on the backing surface, if it applies.

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The backing surface the parser is interacting with, if it applies.

`initialBehaviors` [ParseCommandStacks](../sadconsole.stringparser.parsecommandstacks/)  
A set of known behaviors to apply to the parser.

#### Returns

[ColoredString](../sadconsole.coloredstring/)