---
title: IComponent Interface
slug: reference/sadconsole.components.icomponent
sidebar:
  label: IComponent
editUrl: false
description: A component that can be added to a `SadConsole.IScreenObject`.
---
## Definition

A component that can be added to a [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public interface IComponent
```


## Properties

### SortOrder

Indicates priority to other components.

```csharp title="C#"
uint SortOrder { get; }
```

### IsUpdate

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this component calls the [Update(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#updateiscreenobject-timespan) method.

```csharp title="C#"
bool IsUpdate { get; }
```

### IsRender

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this component calls the [Render(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#renderiscreenobject-timespan) method.

```csharp title="C#"
bool IsRender { get; }
```

### IsMouse

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this component calls the [ProcessMouse(IScreenObject, MouseScreenObjectState, out bool)](../sadconsole.components.icomponent/#processmouseiscreenobject-mousescreenobjectstate-out-bool) method.

```csharp title="C#"
bool IsMouse { get; }
```

### IsKeyboard

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that this component calls the [ProcessKeyboard(IScreenObject, Keyboard, out bool)](../sadconsole.components.icomponent/#processkeyboardiscreenobject-keyboard-out-bool) method.

```csharp title="C#"
bool IsKeyboard { get; }
```

## Methods

### Update(IScreenObject, TimeSpan)

Called by a host on the update frame.

```csharp title="C#"
void Update(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed from the last call to this component.


### Render(IScreenObject, TimeSpan)

Called by a host on the render frame.

```csharp title="C#"
void Render(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed from the last call to this component.


### ProcessMouse(IScreenObject, MouseScreenObjectState, out bool)

Called by a host when the mouse is being processed.

```csharp title="C#"
void ProcessMouse(IScreenObject host, MouseScreenObjectState state, out bool handled)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host console.

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The mouse state.

`handled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> informs the host caller that we handled the mouse and to stop others from handling.


### ProcessKeyboard(IScreenObject, Keyboard, out bool)

Called by a host when the keyboard is being processed.

```csharp title="C#"
void ProcessKeyboard(IScreenObject host, Keyboard keyboard, out bool handled)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added this component.

`keyboard` [Keyboard](../sadconsole.input.keyboard/)  
The keyboard state.

`handled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> informs the host caller that we handled the mouse and to stop others from handling.


### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added the component.


### OnRemoved(IScreenObject)

Called when the component is removed from the host.

```csharp title="C#"
void OnRemoved(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that removed the component.


### OnHostUpdated(IScreenObject)

Called when various states in the host change.

```csharp title="C#"
void OnHostUpdated(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that uses this component.