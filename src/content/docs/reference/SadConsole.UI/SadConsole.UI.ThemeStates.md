---
title: ThemeStates Class
slug: reference/sadconsole.ui.themestates
sidebar:
  label: ThemeStates
editUrl: false
description: Has the basic appearances of each control state.
---
## Definition

Has the basic appearances of each control state.

```csharp title="C#"
[DataContract]
public class ThemeStates
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ThemeStates()

```csharp title="C#"
public ThemeStates()
```


## Properties

### Normal

The normal appearance of the control.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase Normal { get; set; }
```

### Disabled

The appearance of the control when it is disabled.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase Disabled { get; set; }
```

### Focused

The appearance of the control when it is focused.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase Focused { get; set; }
```

### Selected

The appearance of the control when it is in a selected state.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase Selected { get; set; }
```

### MouseOver

The appearance of the control when the mouse is over it.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase MouseOver { get; set; }
```

### MouseDown

THe appearance of the control when a mouse button is held down.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase MouseDown { get; set; }
```

## Methods

### SetForeground(Color)

Sets the same foreground color to all theme states.

```csharp title="C#"
public void SetForeground(Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The foreground color.


### SetBackground(Color)

Sets the same background color to all theme states.

```csharp title="C#"
public void SetBackground(Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The background color.


### SetGlyph(int)

Sets the same glyph to all theme states.

```csharp title="C#"
public void SetGlyph(int glyph)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph.


### SetMirror(Mirror)

Sets the same mirror setting to all theme states.

```csharp title="C#"
public void SetMirror(Mirror mirror)
```

#### Parameters

`mirror` [Mirror](../sadconsole.mirror/)  
The mirror setting.


### GetStateAppearance(ControlStates)

Gets an appearance defined by this theme from the `state` parameter.

```csharp title="C#"
public ColoredGlyphBase GetStateAppearance(ControlStates state)
```

#### Parameters

`state` [ControlStates](../sadconsole.ui.controls.controlstates/)  
The state to check.

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
A cell appearance.

### GetStateAppearanceNoMouse(ControlStates)

Gets an appearance defined by this theme from the `state` parameter. Treats mouse related states as normal.

```csharp title="C#"
public ColoredGlyphBase GetStateAppearanceNoMouse(ControlStates state)
```

#### Parameters

`state` [ControlStates](../sadconsole.ui.controls.controlstates/)  
The state to check.

#### Returns

[ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
A cell appearance.

### Clone()

Performs a deep copy of this theme.

```csharp title="C#"
public ThemeStates Clone()
```

#### Returns

[ThemeStates](../sadconsole.ui.themestates/)  
A new instance of the theme.

### RefreshTheme(Colors)

Reloads the theme values based on the colors provided.

```csharp title="C#"
public virtual void RefreshTheme(Colors colors)
```

#### Parameters

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to create the theme with.