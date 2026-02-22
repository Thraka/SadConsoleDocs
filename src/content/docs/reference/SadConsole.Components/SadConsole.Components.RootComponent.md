---
title: RootComponent Class
slug: reference/sadconsole.components.rootcomponent
sidebar:
  label: RootComponent
editUrl: false
description: A component used only with `SadConsole.GameHost.RootComponents`. Runs logic before the `SadConsole.GameHost.Screen` is processed.
---
## Definition

A component used only with [RootComponents](../sadconsole.gamehost/#rootcomponents). Runs logic before the [Screen](../sadconsole.gamehost/#screen) is processed.

```csharp title="C#"
public abstract class RootComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### RootComponent()

```csharp title="C#"
protected RootComponent()
```


## Methods

### Run(TimeSpan)

Code to run during update.

```csharp title="C#"
public abstract void Run(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last frame.