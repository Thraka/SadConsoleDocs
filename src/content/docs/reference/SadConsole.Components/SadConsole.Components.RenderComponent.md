---
title: RenderComponent Class
slug: reference/sadconsole.components.rendercomponent
sidebar:
  label: RenderComponent
---
## Definition

A base class that implements `SadConsole.Components.IComponent.Render(SadConsole.IScreenObject%2cSystem.TimeSpan)` of [IComponent](../sadconsole.components.icomponent/).

```csharp title="C#"
public abstract class RenderComponent : IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### RenderComponent()

```csharp title="C#"
protected RenderComponent()
```


## Properties

### SortOrder

Indicates priority to other components.

```csharp title="C#"
public uint SortOrder { get; set; }
```

## Methods

### Render(IScreenObject, TimeSpan)

Called by a host on the draw frame.

```csharp title="C#"
public abstract void Render(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed from the last call to this component.


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