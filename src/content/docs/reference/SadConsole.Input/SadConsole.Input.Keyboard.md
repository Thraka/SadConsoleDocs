---
title: Keyboard Class
slug: reference/sadconsole.input.keyboard
sidebar:
  label: Keyboard
editUrl: false
description: Represents the state of the keyboard.
---
## Definition

Represents the state of the keyboard.

```csharp title="C#"
public class Keyboard
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### Keyboard()

Creates a new instance of the keyboard manager.

```csharp title="C#"
public Keyboard()
```


## Fields

### RepeatDelay

How often a key is included in the [KeysPressed](../sadconsole.input.keyboard/#keyspressed) collection after the [InitialRepeatDelay](../sadconsole.input.keyboard/#initialrepeatdelay) time has passed.

```csharp title="C#"
public TimeSpan RepeatDelay
```

### InitialRepeatDelay

The initial delay after a key is first pressed before it is included a second time (while held down) in the [KeysPressed](../sadconsole.input.keyboard/#keyspressed) collection.

```csharp title="C#"
public TimeSpan InitialRepeatDelay
```

## Properties

### KeysPressed

A collection of keys registered as pressed which behaves like a command prompt when holding down keys. 
Uses the [RepeatDelay](../sadconsole.input.keyboard/#repeatdelay) and [InitialRepeatDelay](../sadconsole.input.keyboard/#initialrepeatdelay) settings.

```csharp title="C#"
public ReadOnlyCollection<AsciiKey> KeysPressed { get; }
```

### KeysDown

A collection of keys currently held down.

```csharp title="C#"
public ReadOnlyCollection<AsciiKey> KeysDown { get; }
```

### KeysReleased

A collection of keys that were just released this frame.

```csharp title="C#"
public ReadOnlyCollection<AsciiKey> KeysReleased { get; }
```

### HasKeysDown

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the [KeysDown](../sadconsole.input.keyboard/#keysdown) collection has at least one key; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasKeysDown { get; }
```

### HasKeysPressed

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the [KeysPressed](../sadconsole.input.keyboard/#keyspressed) collection has at least one key; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasKeysPressed { get; }
```

## Methods

### Clear()

Clears the [KeysPressed](../sadconsole.input.keyboard/#keyspressed), [KeysDown](../sadconsole.input.keyboard/#keysdown), [KeysReleased](../sadconsole.input.keyboard/#keysreleased) collections.

```csharp title="C#"
public void Clear()
```


### IsKeyUp(Keys)

Returns true if the key is not in the [KeysDown](../sadconsole.input.keyboard/#keysdown) collection regardless of shift state.

```csharp title="C#"
public bool IsKeyUp(Keys key)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key is not being pressed.

### IsKeyUp(AsciiKey)

Returns true if the key is not in the [KeysDown](../sadconsole.input.keyboard/#keysdown) collection.

```csharp title="C#"
public bool IsKeyUp(AsciiKey key)
```

#### Parameters

`key` [AsciiKey](../sadconsole.input.asciikey/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key is not being pressed.

### IsKeyDown(Keys)

Returns true if the key is in the [KeysDown](../sadconsole.input.keyboard/#keysdown) collection regardless of shift state.

```csharp title="C#"
public bool IsKeyDown(Keys key)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key is being pressed.

### IsKeyDown(AsciiKey)

Returns true if the key is in the [KeysDown](../sadconsole.input.keyboard/#keysdown) collection.

```csharp title="C#"
public bool IsKeyDown(AsciiKey key)
```

#### Parameters

`key` [AsciiKey](../sadconsole.input.asciikey/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key is being pressed.

### IsKeyReleased(Keys)

Returns true when the key is in the [KeysReleased](../sadconsole.input.keyboard/#keysreleased) collection regardless of shift state.

```csharp title="C#"
public bool IsKeyReleased(Keys key)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key was released this update frame.

### IsKeyReleased(AsciiKey)

Returns true when the key is in the [KeysReleased](../sadconsole.input.keyboard/#keysreleased) collection.

```csharp title="C#"
public bool IsKeyReleased(AsciiKey key)
```

#### Parameters

`key` [AsciiKey](../sadconsole.input.asciikey/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key was released this update frame.

### IsKeyPressed(Keys)

Returns true when the key is in the [KeysPressed](../sadconsole.input.keyboard/#keyspressed) collection regardless of shift state.

```csharp title="C#"
public bool IsKeyPressed(Keys key)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key was considered first pressed.

### IsKeyPressed(AsciiKey)

Returns true when the key is in the [KeysPressed](../sadconsole.input.keyboard/#keyspressed) collection.

```csharp title="C#"
public bool IsKeyPressed(AsciiKey key)
```

#### Parameters

`key` [AsciiKey](../sadconsole.input.asciikey/)  
The key to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the key was considered first pressed.

### Update(TimeSpan)

Reads the keyboard state from [GetKeyboardState()](../sadconsole.gamehost/#getkeyboardstate).

```csharp title="C#"
public void Update(TimeSpan elapsedSeconds)
```

#### Parameters

`elapsedSeconds` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Fractional seconds passed since Update was called.