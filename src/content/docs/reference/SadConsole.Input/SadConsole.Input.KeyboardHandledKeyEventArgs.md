---
title: KeyboardHandledKeyEventArgs Class
slug: reference/sadconsole.input.keyboardhandledkeyeventargs
sidebar:
  label: KeyboardHandledKeyEventArgs
---
## Definition

Event handler to preview key presses and cancel them.

```csharp title="C#"
public class KeyboardHandledKeyEventArgs : HandledEventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/) → [HandledEventArgs](../sadconsole.handledeventargs/)

## Constructors

### KeyboardHandledKeyEventArgs()

```csharp title="C#"
public KeyboardHandledKeyEventArgs()
```


## Properties

### Key

The key being pressed.

```csharp title="C#"
public AsciiKey Key { get; }
```