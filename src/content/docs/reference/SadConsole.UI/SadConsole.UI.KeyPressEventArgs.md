---
title: KeyPressEventArgs Class
slug: reference/sadconsole.ui.keypresseventargs
sidebar:
  label: KeyPressEventArgs
editUrl: false
description: Event arguments to indicate that a key is being pressed on a control that allows keyboard key cancelling.
---
## Definition

Event arguments to indicate that a key is being pressed on a control that allows keyboard key cancelling.

```csharp title="C#"
public class KeyPressEventArgs : EventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/)

## Constructors

### KeyPressEventArgs(AsciiKey)

Creates a new event args object.

```csharp title="C#"
public KeyPressEventArgs(AsciiKey key)
```

#### Parameters

`key` [AsciiKey](../sadconsole.input.asciikey/)  
The key being pressed.


## Fields

### Key

The key being pressed by the textbox.

```csharp title="C#"
public readonly AsciiKey Key
```

## Properties

### IsCancelled

When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, causes the textbox to cancel the key press.

```csharp title="C#"
public bool IsCancelled { get; set; }
```