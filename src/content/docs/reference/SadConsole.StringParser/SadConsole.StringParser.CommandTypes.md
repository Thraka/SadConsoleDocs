---
title: CommandTypes Enum
slug: reference/sadconsole.stringparser.commandtypes
sidebar:
  label: CommandTypes
editUrl: false
description: Command type of a `SadConsole.StringParser.ParseCommandBase`.
---
## Definition

Command type of a [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/).

```csharp title="C#"
public enum CommandTypes
```


## Fields

### Foreground

Command should be added to the [Foreground](../sadconsole.stringparser.parsecommandstacks/#foreground) stack.

```csharp title="C#"
Foreground = 0
```

### Background

Command should be added to the [Background](../sadconsole.stringparser.parsecommandstacks/#background) stack.

```csharp title="C#"
Background = 1
```

### Glyph

Command should be added to the [Glyph](../sadconsole.stringparser.parsecommandstacks/#glyph) stack.

```csharp title="C#"
Glyph = 2
```

### Mirror

Command should be added to the [Mirror](../sadconsole.stringparser.parsecommandstacks/#mirror) stack.

```csharp title="C#"
Mirror = 3
```

### Effect

Command should be added to the [Effect](../sadconsole.stringparser.parsecommandstacks/#effect) stack.

```csharp title="C#"
Effect = 4
```

### Decorator

Command should be added to the [Decorator](../sadconsole.stringparser.parsecommandstacks/#decorator) stack.

```csharp title="C#"
Decorator = 5
```

### PureCommand

Command runs on creation and is not added to anything in [ParseCommandStacks](../sadconsole.stringparser.parsecommandstacks/).

```csharp title="C#"
PureCommand = 6
```

### Invalid

Command is invalid and should not be processed at all.

```csharp title="C#"
Invalid = 7
```