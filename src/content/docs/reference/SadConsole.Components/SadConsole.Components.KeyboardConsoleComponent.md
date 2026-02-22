---
title: KeyboardConsoleComponent Class
slug: reference/sadconsole.components.keyboardconsolecomponent
sidebar:
  label: KeyboardConsoleComponent
editUrl: false
description: A base class that implements `SadConsole.Components.IComponent.ProcessKeyboard(SadConsole.IScreenObject%2cSadConsole.Input.Keyboard%2cSystem.Boolean%40)` of `SadConsole.Components.IComponent`.
---
## Definition

A base class that implements [ProcessKeyboard(IScreenObject, Keyboard, out bool)](../sadconsole.components.icomponent/#processkeyboardiscreenobject-keyboard-out-bool) of [IComponent](../sadconsole.components.icomponent/).

```csharp title="C#"
public abstract class KeyboardConsoleComponent : IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### KeyboardConsoleComponent()

```csharp title="C#"
protected KeyboardConsoleComponent()
```


## Properties

### SortOrder

Indicates priority to other components.

```csharp title="C#"
public uint SortOrder { get; set; }
```

## Methods

### ProcessKeyboard(IScreenObject, Keyboard, out bool)

Called by a host when the keyboard is being processed.

```csharp title="C#"
public abstract void ProcessKeyboard(IScreenObject host, Keyboard keyboard, out bool handled)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`keyboard` [Keyboard](../sadconsole.input.keyboard/)  
The state of the keyboard.

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