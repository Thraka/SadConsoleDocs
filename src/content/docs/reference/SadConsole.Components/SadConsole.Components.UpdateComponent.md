---
title: UpdateComponent Class
slug: reference/sadconsole.components.updatecomponent
sidebar:
  label: UpdateComponent
editUrl: false
description: A base class that implements `SadConsole.Components.IComponent.Update(SadConsole.IScreenObject%2cSystem.TimeSpan)` of `SadConsole.Components.IComponent`.
---
## Definition

A base class that implements [Update(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#updateiscreenobject-timespan) of [IComponent](../sadconsole.components.icomponent/).

```csharp title="C#"
public abstract class UpdateComponent : IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### UpdateComponent()

```csharp title="C#"
protected UpdateComponent()
```


## Properties

### SortOrder

Indicates priority to other components.

```csharp title="C#"
public uint SortOrder { get; set; }
```

## Methods

### Update(IScreenObject, TimeSpan)

Called by a host on the update frame.

```csharp title="C#"
public abstract void Update(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.


### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
public virtual void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added the component.


### OnRemoved(IScreenObject)

Called when the component is removed from the host.

```csharp title="C#"
public virtual void OnRemoved(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that removed the component.