---
title: AnsiWriter Class
slug: reference/sadconsole.ansi.ansiwriter
sidebar:
  label: AnsiWriter
editUrl: false
description: Writes a `SadConsole.Ansi.Document` to a `SadConsole.ICellSurface`.
---
## Definition

Writes a [Document](../sadconsole.ansi.document/) to a [ICellSurface](../sadconsole.icellsurface/).

```csharp title="C#"
public class AnsiWriter
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### AnsiWriter(Document, ICellSurface)

Creates a new instance with the source document and target surface.

```csharp title="C#"
public AnsiWriter(Document ansiDocument, ICellSurface editor)
```

#### Parameters

`ansiDocument` [Document](../sadconsole.ansi.document/)  
The source document containing ANSI commands.

`editor` [ICellSurface](../sadconsole.icellsurface/)  
The surface to parse the ANSI to.


## Properties

### AnsiDocument

The document used to create this writer.

```csharp title="C#"
public Document AnsiDocument { get; }
```

### BlinkEffect

The blink effect to apply when the ansi document provides the ANSI blink command.

```csharp title="C#"
public ICellEffect BlinkEffect { get; set; }
```

### Cursor

The cursor used to write to the target [ICellSurface](../sadconsole.icellsurface/).

```csharp title="C#"
public Cursor Cursor { get; }
```

### CharactersPerSecond

How many characters to process a second. When set to 0 reads the entire document at once.

```csharp title="C#"
public int CharactersPerSecond { get; set; }
```

## Methods

### Process(double)

Processes the document by the amount of time that has elapsed. If [CharactersPerSecond](../sadconsole.ansi.ansiwriter/#characterspersecond) is 0, time elapsed has no affect.

```csharp title="C#"
public void Process(double timeElapsed)
```

#### Parameters

`timeElapsed` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The time in seconds.


### AnsiInterpret(string)

Interprets an individual ansi code.

```csharp title="C#"
public void AnsiInterpret(string code)
```

#### Parameters

`code` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The ANSI.SYS code to read.


### AnsiReadLine(string, bool)

Reads a line of ANSI.SYS code.

```csharp title="C#"
public bool AnsiReadLine(string line, bool moreLines = false)
```

#### Parameters

`line` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The line to read.

`moreLines` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, calls [LineFeed()](../sadconsole.components.cursor/#linefeed); otherwise does nothing.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Returns false when character 26 is encountered; otherwise true.

### ReadEntireDocument()

Loads an ansi file and parses it.

```csharp title="C#"
public void ReadEntireDocument()
```


### Restart()

Moves the reader back to the start of the file so that the source can .

```csharp title="C#"
public void Restart()
```