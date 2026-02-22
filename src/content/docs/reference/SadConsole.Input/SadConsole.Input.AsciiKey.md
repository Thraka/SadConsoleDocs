---
title: AsciiKey Struct
slug: reference/sadconsole.input.asciikey
sidebar:
  label: AsciiKey
editUrl: false
description: Represents the state of a single key.
---
## Definition

Represents the state of a single key.

```csharp title="C#"
public struct AsciiKey
```


## Fields

### CapsLockedKeys

List of [Keys](../sadconsole.input.keys/) to consider as shifted when capslock is on.

```csharp title="C#"
public static readonly List<Keys> CapsLockedKeys
```

### ShiftKeyMappings

A dictionary that is keyed off of a [Keys](../sadconsole.input.keys/) and associates that key with a character in a shifted and unshifted state.

```csharp title="C#"
public static readonly Dictionary<Keys, AsciiKey.ShiftedCharacterMapping> ShiftKeyMappings
```

### NumberKeyMappings

Dictionary that maps [Keys](../sadconsole.input.keys/) usually triggered by the numberpad with a character and non-numpad key.

```csharp title="C#"
public static readonly Dictionary<Keys, AsciiKey.CharacterKeyMapping> NumberKeyMappings
```

### KeyRemapping

Remaps any incoming key to a combination of character and key.

```csharp title="C#"
public static readonly Dictionary<Keys, Keys> KeyRemapping
```

### Key

The key from MonoGame or XNA.

```csharp title="C#"
public Keys Key
```

### Character

The keyboard character of the key.

```csharp title="C#"
public char Character
```

### TimeHeld

Total time the key has been held.

```csharp title="C#"
public TimeSpan TimeHeld
```

### PostInitialDelay

Tracks if the key was previously held when calculating the [InitialRepeatDelay](../sadconsole.input.keyboard/#initialrepeatdelay).

```csharp title="C#"
public bool PostInitialDelay
```

## Methods

### Fill(Keys, bool, IKeyboardState)

Fills out the fields based on the key.

```csharp title="C#"
public void Fill(Keys key, bool shiftPressed, IKeyboardState state)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key.

`shiftPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Helps identify which [Character](../sadconsole.input.asciikey/#character) to use while the key is pressed.

`state` [IKeyboardState](../sadconsole.input.ikeyboardstate/)  
Keyboard state to read from.


### Get(Keys, IKeyboardState)

Shortcut to get the [AsciiKey](../sadconsole.input.asciikey/) for a specific MonoGame/XNA [Keys](../sadconsole.input.keys/) type. Shift is considered not pressed.

```csharp title="C#"
public static AsciiKey Get(Keys key, IKeyboardState state)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key.

`state` [IKeyboardState](../sadconsole.input.ikeyboardstate/)  
Keyboar state to read from.

#### Returns

[AsciiKey](../sadconsole.input.asciikey/)  
The [AsciiKey](../sadconsole.input.asciikey/) of the [Keys](../sadconsole.input.keys/).

### Get(Keys, bool, IKeyboardState)

Shortcut to get the [AsciiKey](../sadconsole.input.asciikey/) for a specific MonoGame/XNA [Keys](../sadconsole.input.keys/) type.

```csharp title="C#"
public static AsciiKey Get(Keys key, bool shiftPressed, IKeyboardState state)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key.

`shiftPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
If shift should be considered pressed or not.

`state` [IKeyboardState](../sadconsole.input.ikeyboardstate/)  
Keyboar state to read from.

#### Returns

[AsciiKey](../sadconsole.input.asciikey/)  
The [AsciiKey](../sadconsole.input.asciikey/) of the [Keys](../sadconsole.input.keys/).

### GetHashCode()

Gets a hashcode based on the key and character.

```csharp title="C#"
public override int GetHashCode()
```

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

### Equals(object?)

Compares references.

```csharp title="C#"
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)