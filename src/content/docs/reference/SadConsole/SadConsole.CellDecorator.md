---
title: CellDecorator Struct
slug: reference/sadconsole.celldecorator
sidebar:
  label: CellDecorator
editUrl: false
description: Decorates a cell with a colored glyph.
---
## Definition

Decorates a cell with a colored glyph.

```csharp title="C#"
[DataContract]
public readonly struct CellDecorator : IEquatable<CellDecorator>
```


Implements [IEquatable\<CellDecorator\>](https://learn.microsoft.com/dotnet/api/system.iequatable-1/)

## Constructors

### CellDecorator(Color, int, Mirror)

Creates a new decorator with the specified colors, glyph, visiblity, and mirror settings.

```csharp title="C#"
public CellDecorator(Color color, int glyph, Mirror mirror)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Foreground color.

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Glyph value.

`mirror` [Mirror](../sadconsole.mirror/)  
Mirror setting.


## Properties

### Empty

An empty cell decorator.

```csharp title="C#"
public static CellDecorator Empty { get; }
```

### Color

Foreground color of the decorator.

```csharp title="C#"
[DataMember]
public Color Color { get; init; }
```

### Glyph

Glyph of the decorator.

```csharp title="C#"
[DataMember]
public int Glyph { get; init; }
```

### Mirror

Mirror setting of the decorator.

```csharp title="C#"
[DataMember]
public Mirror Mirror { get; init; }
```

## Methods

### Equals(CellDecorator)

Determines if this object has the same value as the other.

```csharp title="C#"
public bool Equals(CellDecorator other)
```

#### Parameters

`other` [CellDecorator](../sadconsole.celldecorator/)  
The object to test against.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True if the objects have the same values.

### Equals(object?)

```csharp title="C#"
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### GetHashCode()

```csharp title="C#"
public override int GetHashCode()
```

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)