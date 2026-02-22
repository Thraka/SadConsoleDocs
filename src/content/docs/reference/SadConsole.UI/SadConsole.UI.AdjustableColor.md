---
title: AdjustableColor Class
slug: reference/sadconsole.ui.adjustablecolor
sidebar:
  label: AdjustableColor
editUrl: false
description: A color that can be adjusted by brightness and mapped to a `SadConsole.UI.Colors` color.
---
## Definition

A color that can be adjusted by brightness and mapped to a [Colors](../sadconsole.ui.colors/) color.

```csharp title="C#"
[DataContract]
public class AdjustableColor
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### AdjustableColor(Color, string)

Creates a color that isn't mapped to a [Colors](../sadconsole.ui.colors/) color.

```csharp title="C#"
public AdjustableColor(Color color, string name)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A friendly name of the color.


### AdjustableColor(Color, string, Colors)

Creates a color and tries to map it to a [Colors](../sadconsole.ui.colors/) color.

```csharp title="C#"
public AdjustableColor(Color color, string name, Colors colors)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A friendly name of the color.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to try and map to.


### AdjustableColor(ColorNames, string, Colors)

Creates a color that maps to a [Colors](../sadconsole.ui.colors/) color.

```csharp title="C#"
public AdjustableColor(Colors.ColorNames color, string name, Colors colors)
```

#### Parameters

`color` [Colors.ColorNames](../sadconsole.ui.colors/)  
The predefined color.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A friendly name of the color.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors used setting the [BaseColor](../sadconsole.ui.adjustablecolor/#basecolor) value.


## Properties

### Name

The name of the color.

```csharp title="C#"
[DataMember]
public string? Name { get; set; }
```

### BaseColor

The color without brightness.

```csharp title="C#"
[DataMember]
public Color BaseColor { get; }
```

### ComputedColor

The color with brightness applied.

```csharp title="C#"
public Color ComputedColor { get; }
```

### IsCustomColor

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when this color is not defined by a [Colors](../sadconsole.ui.colors/) object; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public bool IsCustomColor { get; set; }
```

### UIColor

The [Colors](../sadconsole.ui.colors/) mapped color when [IsCustomColor](../sadconsole.ui.adjustablecolor/#iscustomcolor) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[DataMember]
public Colors.ColorNames UIColor { get; }
```

### Brightness

A brightness to apply to the color.

```csharp title="C#"
[DataMember]
public Colors.Brightness Brightness { get; set; }
```

## Methods

### SetUIColor(ColorNames, Colors, Brightness)

Maps this adjustable color to a [Colors](../sadconsole.ui.colors/) color.

```csharp title="C#"
public void SetUIColor(Colors.ColorNames color, Colors colors, Colors.Brightness brightness)
```

#### Parameters

`color` [Colors.ColorNames](../sadconsole.ui.colors/)  
The predefined color.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors used setting the [BaseColor](../sadconsole.ui.adjustablecolor/#basecolor) value.

`brightness` [Colors.Brightness](../sadconsole.ui.colors/)  
The brightness to apply to the color.


### SetColor(Color, Colors, Brightness)

Tries to map this adjustable color to a [Colors](../sadconsole.ui.colors/) color.

```csharp title="C#"
public void SetColor(Color color, Colors colors, Colors.Brightness brightness)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to try and map to.

`brightness` [Colors.Brightness](../sadconsole.ui.colors/)  
The brightness to apply to the color.


### SetColor(Color)

Configures this adjustable color to the specified color.

```csharp title="C#"
public void SetColor(Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color.


### RefreshUIColor(Colors)

Refreshes [BaseColor](../sadconsole.ui.adjustablecolor/#basecolor) using [UIColor](../sadconsole.ui.adjustablecolor/#uicolor) and the provided [Colors](../sadconsole.ui.colors/) object.

```csharp title="C#"
public void RefreshUIColor(Colors colors)
```

#### Parameters

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to pull a color value from.


### Clone()

Creates a copy of this object.

```csharp title="C#"
public AdjustableColor Clone()
```

#### Returns

[AdjustableColor](../sadconsole.ui.adjustablecolor/)  
A new adjustable color object.