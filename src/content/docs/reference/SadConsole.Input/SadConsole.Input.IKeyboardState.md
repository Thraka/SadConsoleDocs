---
title: IKeyboardState Interface
slug: reference/sadconsole.input.ikeyboardstate
sidebar:
  label: IKeyboardState
---
## Definition

Holds the state of keystrokes by a keyboard.

```csharp title="C#"
public interface IKeyboardState
```


## Properties

### CapsLock

Gets the current state of the Caps Lock key.

```csharp title="C#"
bool CapsLock { get; }
```

### NumLock

Gets the current state of the Num Lock key.

```csharp title="C#"
bool NumLock { get; }
```

## Methods

### IsKeyDown(Keys)

Gets whether given key is currently being pressed.

```csharp title="C#"
bool IsKeyDown(Keys key)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to query.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
true if the key is pressed; false otherwise.

### IsKeyUp(Keys)

Gets whether given key is currently being not pressed.

```csharp title="C#"
bool IsKeyUp(Keys key)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to query.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
true if the key is not pressed; false otherwise.

### GetPressedKeys()

Returns an array of values holding keys that are currently being pressed.

```csharp title="C#"
Keys[] GetPressedKeys()
```

#### Returns

[Keys[]](../sadconsole.input.keys/)  
The keys that are currently being pressed.

### Refresh()

If applicable to the host implementation, refreshes the keyboard state.

```csharp title="C#"
void Refresh()
```