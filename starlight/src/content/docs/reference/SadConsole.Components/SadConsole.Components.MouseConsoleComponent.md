---
title: MouseConsoleComponent Class
slug: reference/sadconsole.components.mouseconsolecomponent
sidebar:
  label: MouseConsoleComponent
---
## Definition

A base class that implements `SadConsole.Components.IComponent.ProcessMouse(SadConsole.IScreenObject%2cSadConsole.Input.MouseScreenObjectState%2cSystem.Boolean%40)` of [IComponent](../sadconsole.components.icomponent/).

```csharp title="C#"
public abstract class MouseConsoleComponent : IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### MouseConsoleComponent()

```csharp title="C#"
protected MouseConsoleComponent()
```


## Properties

### SortOrder

Indicates priority to other components.

```csharp title="C#"
public uint SortOrder { get; set; }
```

## Methods

### ProcessMouse(IScreenObject, MouseScreenObjectState, out bool)

Called by a host when the mouse is being processed.

```csharp title="C#"
public abstract void ProcessMouse(IScreenObject host, MouseScreenObjectState state, out bool handled)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The state of the mouse in relation to the console.

`handled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> informs the host caller that we handled the mouse and to stop others from handling.


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