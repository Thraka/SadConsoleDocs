---
title: ObjectComponentMove Class
slug: reference/sadconsole.components.objectcomponentmove
sidebar:
  label: ObjectComponentMove
---
## Definition

Moves a [IScreenObject](../sadconsole.iscreenobject/) with the arrow keys.

```csharp title="C#"
public class ObjectComponentMove : KeyboardConsoleComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [KeyboardConsoleComponent](../sadconsole.components.keyboardconsolecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### ObjectComponentMove()

Creates a new instance of the object with an [Amount](../sadconsole.components.objectcomponentmove/#amount/) of 1.

```csharp title="C#"
public ObjectComponentMove()
```


## Properties

### Amount

The amount to move the object by.

```csharp title="C#"
public int Amount { get; set; }
```

### LeftKey

The key to move the object `SadRogue.Primitives.Direction.Left` by [Amount](../sadconsole.components.objectcomponentmove/#amount/).

```csharp title="C#"
public Keys LeftKey { get; set; }
```

### RightKey

The key to move the object `SadRogue.Primitives.Direction.Right` by [Amount](../sadconsole.components.objectcomponentmove/#amount/).

```csharp title="C#"
public Keys RightKey { get; set; }
```

### UpKey

The key to move the object `SadRogue.Primitives.Direction.Up` by [Amount](../sadconsole.components.objectcomponentmove/#amount/).

```csharp title="C#"
public Keys UpKey { get; set; }
```

### DownKey

The key to move the object `SadRogue.Primitives.Direction.Down` by [Amount](../sadconsole.components.objectcomponentmove/#amount/).

```csharp title="C#"
public Keys DownKey { get; set; }
```

## Methods

### ProcessKeyboard(IScreenObject, Keyboard, out bool)

Moves the `host` by [Amount](../sadconsole.components.objectcomponentmove/#amount/) when the appropriate key is pressed.

```csharp title="C#"
public override void ProcessKeyboard(IScreenObject host, Keyboard keyboard, out bool handled)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  

`keyboard` [Keyboard](../sadconsole.input.keyboard/)  

`handled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)