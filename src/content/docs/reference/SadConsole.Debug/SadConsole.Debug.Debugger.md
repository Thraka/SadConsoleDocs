---
title: Debugger Class
slug: reference/sadconsole.debug.debugger
sidebar:
  label: Debugger
editUrl: false
description: The SadConsole debugger class.
---
## Definition

The SadConsole debugger class.

```csharp title="C#"
public static class Debugger
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### IsOpened

True when the debugger is currently opened.

```csharp title="C#"
public static bool IsOpened { get; }
```

## Methods

### Start()

Starts the debugger.

```csharp title="C#"
public static void Start()
```


### Stop()

Stops the debugger.

```csharp title="C#"
public static void Stop()
```


## Events

### Opened

An event that's raised when the debugger is opened. True is passed if it's the first time it's opened.

```csharp title="C#"
public static event Action<bool> Opened
```

#### Event Type

[Action\<bool\>](https://learn.microsoft.com/dotnet/api/system.action-1/)
### Closed

An event that's raised when the debugger is closed.

```csharp title="C#"
public static event Action Closed
```

#### Event Type

[Action](https://learn.microsoft.com/dotnet/api/system.action/)