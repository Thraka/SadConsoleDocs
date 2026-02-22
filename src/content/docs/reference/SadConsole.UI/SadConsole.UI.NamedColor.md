---
title: NamedColor Class
slug: reference/sadconsole.ui.namedcolor
sidebar:
  label: NamedColor
editUrl: false
description: A color associated with a name.
---
## Definition

A color associated with a name.

```csharp title="C#"
public record NamedColor : IEquatable<NamedColor>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IEquatable\<NamedColor\>](https://learn.microsoft.com/dotnet/api/system.iequatable-1/)

## Constructors

### NamedColor(string, Color)

A color associated with a name.

```csharp title="C#"
public NamedColor(string Name, Color Color)
```

#### Parameters

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the color.

`Color` SadRogue.Primitives.Color  
The color.


### NamedColor(NamedColor)

```csharp title="C#"
protected NamedColor(NamedColor original)
```

#### Parameters

`original` [NamedColor](../sadconsole.ui.namedcolor/)  


## Properties

### EqualityContract

```csharp title="C#"
protected virtual Type EqualityContract { get; }
```

### Name

The name of the color.

```csharp title="C#"
public string Name { get; init; }
```

### Color

The color.

```csharp title="C#"
public Color Color { get; init; }
```

## Methods

### ToString()

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)

### PrintMembers(StringBuilder)

```csharp title="C#"
protected virtual bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### GetHashCode()

```csharp title="C#"
public override int GetHashCode()
```

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)

### Equals(object?)

```csharp title="C#"
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Equals(NamedColor?)

```csharp title="C#"
public virtual bool Equals(NamedColor? other)
```

#### Parameters

`other` [NamedColor](../sadconsole.ui.namedcolor/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Deconstruct(out string, out Color)

```csharp title="C#"
public void Deconstruct(out string Name, out Color Color)
```

#### Parameters

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`Color` SadRogue.Primitives.Color