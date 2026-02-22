---
title: MoveViewPortKeyboardHandler Class
slug: reference/sadconsole.components.moveviewportkeyboardhandler
sidebar:
  label: MoveViewPortKeyboardHandler
editUrl: false
description: Moves the view of an `SadConsole.IScreenSurface` with a set of specified keyboard keys.
---
## Definition

Moves the view of an [IScreenSurface](../sadconsole.iscreensurface/) with a set of specified keyboard keys.

```csharp title="C#"
public class MoveViewPortKeyboardHandler : KeyboardConsoleComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [KeyboardConsoleComponent](../sadconsole.components.keyboardconsolecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### MoveViewPortKeyboardHandler()

Creates this handler with the arrow keys.

```csharp title="C#"
public MoveViewPortKeyboardHandler()
```


### MoveViewPortKeyboardHandler(Keys, Keys, Keys, Keys)

Creates this handler with the specified keys.

```csharp title="C#"
public MoveViewPortKeyboardHandler(Keys left, Keys right, Keys up, Keys down)
```

#### Parameters

`left` [Keys](../sadconsole.input.keys/)  
The key to move left.

`right` [Keys](../sadconsole.input.keys/)  
The key to move right.

`up` [Keys](../sadconsole.input.keys/)  
The key to move up.

`down` [Keys](../sadconsole.input.keys/)  
The key to move down.


## Properties

### Left

The key to move left.

```csharp title="C#"
public Keys Left { get; set; }
```

### Right

The key to move right.

```csharp title="C#"
public Keys Right { get; set; }
```

### Up

The key to move up.

```csharp title="C#"
public Keys Up { get; set; }
```

### Down

The key to move down.

```csharp title="C#"
public Keys Down { get; set; }
```

## Methods

### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
public override void OnAdded(IScreenObject console)
```

#### Parameters

`console` [IScreenObject](../sadconsole.iscreenobject/)  


### ProcessKeyboard(IScreenObject, Keyboard, out bool)

Called by a host when the keyboard is being processed.

```csharp title="C#"
public override void ProcessKeyboard(IScreenObject consoleObject, Keyboard info, out bool handled)
```

#### Parameters

`consoleObject` [IScreenObject](../sadconsole.iscreenobject/)  

`info` [Keyboard](../sadconsole.input.keyboard/)  

`handled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> informs the host caller that we handled the mouse and to stop others from handling.