---
title: AsciiKey.CharacterKeyMapping Struct
slug: reference/sadconsole.input.asciikey.characterkeymapping
sidebar:
  label: AsciiKey.CharacterKeyMapping
---
## Definition

Associates a character glyph and a [Keys](../sadconsole.input.keys/) value.

```csharp title="C#"
public readonly struct AsciiKey.CharacterKeyMapping : IEquatable<AsciiKey.CharacterKeyMapping>
```


Implements [IEquatable\<AsciiKey.CharacterKeyMapping\>](https://learn.microsoft.com/dotnet/api/system.iequatable-1/)
## Remarks

Used when the [NumLock](../sadconsole.input.keys/#numlock/) is active.

## Constructors

### CharacterKeyMapping(char, Keys)

Associates a character glyph and a [Keys](../sadconsole.input.keys/) value.

```csharp title="C#"
public CharacterKeyMapping(char CharacterGlyph, Keys Key)
```

#### Parameters

`CharacterGlyph` [char](https://learn.microsoft.com/dotnet/api/system.char/)  
The number pad character.

`Key` [Keys](../sadconsole.input.keys/)  
The key the character maps to.

#### Remarks

Used when the [NumLock](../sadconsole.input.keys/#numlock/) is active.

## Properties

### CharacterGlyph

The number pad character.

```csharp title="C#"
public char CharacterGlyph { get; init; }
```

### Key

The key the character maps to.

```csharp title="C#"
public Keys Key { get; init; }
```

## Methods

### ToString()

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)

### GetHashCode()

```csharp title="C#"
public override int GetHashCode()
```

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

### Equals(object)

```csharp title="C#"
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Equals(CharacterKeyMapping)

```csharp title="C#"
public bool Equals(AsciiKey.CharacterKeyMapping other)
```

#### Parameters

`other` [AsciiKey.CharacterKeyMapping](../sadconsole.input.asciikey/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Deconstruct(out char, out Keys)

```csharp title="C#"
public void Deconstruct(out char CharacterGlyph, out Keys Key)
```

#### Parameters

`CharacterGlyph` [char](https://learn.microsoft.com/dotnet/api/system.char/)  

`Key` [Keys](../sadconsole.input.keys/)