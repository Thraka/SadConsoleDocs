---
title: AsciiKey.ShiftedCharacterMapping Struct
slug: reference/sadconsole.input.asciikey.shiftedcharactermapping
sidebar:
  label: AsciiKey.ShiftedCharacterMapping
---
## Definition

A link between two characters, one unshifted and the other shifted.

```csharp title="C#"
public readonly struct AsciiKey.ShiftedCharacterMapping : IEquatable<AsciiKey.ShiftedCharacterMapping>
```


Implements [IEquatable\<AsciiKey.ShiftedCharacterMapping\>](https://learn.microsoft.com/dotnet/api/system.iequatable-1/)

## Constructors

### ShiftedCharacterMapping(char, char)

A link between two characters, one unshifted and the other shifted.

```csharp title="C#"
public ShiftedCharacterMapping(char Unshifted, char Shifted)
```

#### Parameters

`Unshifted` [char](https://learn.microsoft.com/dotnet/api/system.char/)  
The character when unshifted.

`Shifted` [char](https://learn.microsoft.com/dotnet/api/system.char/)  
The character when shifted.


## Properties

### Unshifted

The character when unshifted.

```csharp title="C#"
public char Unshifted { get; init; }
```

### Shifted

The character when shifted.

```csharp title="C#"
public char Shifted { get; init; }
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

### Equals(ShiftedCharacterMapping)

```csharp title="C#"
public bool Equals(AsciiKey.ShiftedCharacterMapping other)
```

#### Parameters

`other` [AsciiKey.ShiftedCharacterMapping](../sadconsole.input.asciikey/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Deconstruct(out char, out char)

```csharp title="C#"
public void Deconstruct(out char Unshifted, out char Shifted)
```

#### Parameters

`Unshifted` [char](https://learn.microsoft.com/dotnet/api/system.char/)  

`Shifted` [char](https://learn.microsoft.com/dotnet/api/system.char/)