---
title: CodeEffect Class
slug: reference/sadconsole.effects.codeeffect
sidebar:
  label: CodeEffect
---
## Definition

Effect that runs code for the apply and update actions of an effect.

```csharp title="C#"
public class CodeEffect : CellEffectBase, ICellEffect
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [CellEffectBase](../sadconsole.effects.celleffectbase/)

Implements [ICellEffect](../sadconsole.effects.icelleffect/)

## Constructors

### CodeEffect(string, Func<CodeEffect, ColoredGlyphBase, ColoredGlyphBase, bool>, Action<CodeEffect, TimeSpan>, Action<CodeEffect>)

Creates a cell effect that runs custom code instead of hardcoded effect actions.

```csharp title="C#"
public CodeEffect(string id, Func<CodeEffect, ColoredGlyphBase, ColoredGlyphBase, bool> apply, Action<CodeEffect, TimeSpan> update, Action<CodeEffect> restart)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A user-definable identifier.

`apply` [Func\<CodeEffect, ColoredGlyphBase, ColoredGlyphBase, bool\>](https://learn.microsoft.com/dotnet/api/system.func-4/)  
The code to run for <xref href="SadConsole.Effects.ICellEffect.ApplyToCell(SadConsole.ColoredGlyphBase%2cSadConsole.ColoredGlyphBase)" data-throw-if-not-resolved="false"></xref>.

`update` [Action\<CodeEffect, TimeSpan\>](https://learn.microsoft.com/dotnet/api/system.action-2/)  
The code to run for <xref href="SadConsole.Effects.ICellEffect.Update(System.TimeSpan)" data-throw-if-not-resolved="false"></xref>.

`restart` [Action\<CodeEffect\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
The code to run for <xref href="SadConsole.Effects.ICellEffect.Restart" data-throw-if-not-resolved="false"></xref>.


## Properties

### Id

A user defined identifier of the effect.

```csharp title="C#"
public string Id { get; set; }
```

### Tag

An object associated with this effect.

```csharp title="C#"
public object? Tag { get; set; }
```

### UseDuration

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, uses the [Duration](../sadconsole.effects.codeeffect/#duration/) timer to stop this effect; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool UseDuration { get; set; }
```

### Duration

The amount of time this effect runs for in seconds.

```csharp title="C#"
public TimeSpan Duration { get; set; }
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

Not supported.

```csharp title="C#"
public override ICellEffect Clone()
```

#### Returns

[ICellEffect](../sadconsole.effects.icelleffect/)

### Update(TimeSpan)

Updates the state of the effect.

```csharp title="C#"
public override void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Time since the last call to this effect.


### Restart()

Restarts the cell effect.

```csharp title="C#"
public override void Restart()
```


### ToString()

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)