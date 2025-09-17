---
title: CoroutineHandlerComponent Class
slug: reference/sadconsole.components.coroutinehandlercomponent
sidebar:
  label: CoroutineHandlerComponent
---
## Definition

An implementation of `Coroutine.CoroutineHandlerInstance` that calls [Tick(TimeSpan)](https://learn.microsoft.com/dotnet/api/system.timespan/) every time `SadConsole.Components.IComponent.Update(SadConsole.IScreenObject%2cSystem.TimeSpan)` is called.

```csharp title="C#"
public class CoroutineHandlerComponent : CoroutineHandlerInstance, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Coroutine.CoroutineHandlerInstance

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### CoroutineHandlerComponent()

Creates a new instance of the coroutine handler.

```csharp title="C#"
public CoroutineHandlerComponent()
```


## Properties

### SortOrder

The sort order for this component.

```csharp title="C#"
public uint SortOrder { get; set; }
```