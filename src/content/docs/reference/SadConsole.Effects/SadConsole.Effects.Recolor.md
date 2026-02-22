---
title: Recolor Class
slug: reference/sadconsole.effects.recolor
sidebar:
  label: Recolor
editUrl: false
description: Recors the foreground or the background of a cell.
---
## Definition

Recors the foreground or the background of a cell.

```csharp title="C#"
[DataContract]
public class Recolor : CellEffectBase, ICellEffect
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [CellEffectBase](../sadconsole.effects.celleffectbase/)

Implements [ICellEffect](../sadconsole.effects.icelleffect/)

## Constructors

### Recolor()

Creates a new instance of the effect.

```csharp title="C#"
public Recolor()
```


## Properties

### Foreground

The foreground color applied to a cell.

```csharp title="C#"
[DataMember]
public Color Foreground { get; set; }
```

### Background

The background color applied to a cell.

```csharp title="C#"
[DataMember]
public Color Background { get; set; }
```

### DoForeground

When true, the [Foreground](../sadconsole.effects.recolor/#foreground) color will be applied to the cell.

```csharp title="C#"
[DataMember]
public bool DoForeground { get; set; }
```

### DoBackground

/// When true, the [Background](../sadconsole.effects.recolor/#background) color will be applied to the cell.

```csharp title="C#"
[DataMember]
public bool DoBackground { get; set; }
```

## Methods

### ApplyToCell(ColoredGlyphBase, ColoredGlyphBase)

Applies the state of the effect to a cell.

```csharp title="C#"
public override bool ApplyToCell(ColoredGlyphBase cell, ColoredGlyphBase originalState)
```

#### Parameters

`cell` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The surface cell using this effect.

`originalState` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The state of the cell prior to the effect being applied.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this method modified the `cell`; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### Clone()

Returns a duplicate of this effect.

```csharp title="C#"
public override ICellEffect Clone()
```

#### Returns

[ICellEffect](../sadconsole.effects.icelleffect/)  
A new copy of this effect.

### ToString()

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)