---
title: HandledEventArgs Class
slug: reference/sadconsole.handledeventargs
sidebar:
  label: HandledEventArgs
---
## Definition

Event args that allow a handled flag to be set.

```csharp title="C#"
public class HandledEventArgs : EventArgs
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/)

## Constructors

### HandledEventArgs()

```csharp title="C#"
public HandledEventArgs()
```


## Properties

### IsHandled

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates that the event has been handled and no more processing should continue.

```csharp title="C#"
public bool IsHandled { get; set; }
```