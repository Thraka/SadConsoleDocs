---
title: ParseCommandStacks Class
slug: reference/sadconsole.stringparser.parsecommandstacks
sidebar:
  label: ParseCommandStacks
---
## Definition

A list of behaviors applied as a string is processed.

```csharp title="C#"
public class ParseCommandStacks
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ParseCommandStacks()

Creates new stacks of commands.

```csharp title="C#"
public ParseCommandStacks()
```


## Properties

### Foreground

The commands that affect the foreground.

```csharp title="C#"
public Stack<ParseCommandBase> Foreground { get; set; }
```

### Background

The commands that affect the background.

```csharp title="C#"
public Stack<ParseCommandBase> Background { get; set; }
```

### Glyph

The commands that affect the glyph.

```csharp title="C#"
public Stack<ParseCommandBase> Glyph { get; set; }
```

### Mirror

The commands that affect the mirror setting.

```csharp title="C#"
public Stack<ParseCommandBase> Mirror { get; set; }
```

### Effect

The commands that affect the glyph effect.

```csharp title="C#"
public Stack<ParseCommandBase> Effect { get; set; }
```

### Decorator

The commands that affect the glyph decorators.

```csharp title="C#"
public Stack<ParseCommandBase> Decorator { get; set; }
```

### All

All commands.

```csharp title="C#"
public Stack<ParseCommandBase> All { get; set; }
```

### CalculatedDecorators

Returns the active array that is calculated from the [Decorator](../sadconsole.stringparser.parsecommandstacks/#decorator/) stack.

```csharp title="C#"
public CellDecorator[] CalculatedDecorators { get; set; }
```

## Methods

### AddSafe(ParseCommandBase)

Adds a behavior to the [All](../sadconsole.stringparser.parsecommandstacks/#all/) collection and the collection 
based on the [CommandType](../sadconsole.stringparser.parsecommandbase/#commandtype/) type.

```csharp title="C#"
public void AddSafe(ParseCommandBase command)
```

#### Parameters

`command` [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/)  


### RemoveSafe(ParseCommandBase)

Removes a command from the appropriate command stack and from the [All](../sadconsole.stringparser.parsecommandstacks/#all/) stack.

```csharp title="C#"
public void RemoveSafe(ParseCommandBase command)
```

#### Parameters

`command` [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/)  
The command to remove