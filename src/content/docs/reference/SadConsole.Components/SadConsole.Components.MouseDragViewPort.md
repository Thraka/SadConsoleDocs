---
title: MouseDragViewPort Class
slug: reference/sadconsole.components.mousedragviewport
sidebar:
  label: MouseDragViewPort
---
## Definition

Enables dragging a scrollable surface around by mouse.

```csharp title="C#"
public class MouseDragViewPort : MouseConsoleComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [MouseConsoleComponent](../sadconsole.components.mouseconsolecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### MouseDragViewPort()

```csharp title="C#"
public MouseDragViewPort()
```


## Properties

### IsEnabled

When true, enables this component.

```csharp title="C#"
public bool IsEnabled { get; set; }
```

## Methods

### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added the component.

#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Raised when the host this component is added to doesn't implement [IScreenSurface](../sadconsole.iscreensurface/).


### ProcessMouse(IScreenObject, MouseScreenObjectState, out bool)

Called by a host when the mouse is being processed.

```csharp title="C#"
public override void ProcessMouse(IScreenObject host, MouseScreenObjectState state, out bool handled)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The state of the mouse in relation to the console.

`handled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> informs the host caller that we handled the mouse and to stop others from handling.