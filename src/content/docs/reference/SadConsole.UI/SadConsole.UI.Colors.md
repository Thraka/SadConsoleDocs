---
title: Colors Class
slug: reference/sadconsole.ui.colors
sidebar:
  label: Colors
editUrl: false
description: Default colors used by control themes.
---
## Definition

Default colors used by control themes.

```csharp title="C#"
public class Colors
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### Colors()

Creates a color object based on the [CreateAnsi()](../sadconsole.ui.colors/#createansi) scheme.

```csharp title="C#"
public Colors()
```


### Colors(int)

Internal constructor to avoid creating any predefined colors.

```csharp title="C#"
protected Colors(int _)
```

#### Parameters

`_` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Discarded parameter


## Properties

### Default

The default colors used by controls and your code.

```csharp title="C#"
public static Colors Default { get; set; }
```

### IsLightTheme

Status flag to indicate that the primary backgrounds of the controls are considered light rather than dark.

```csharp title="C#"
public bool IsLightTheme { get; set; }
```

### Name

The name of this color scheme.

```csharp title="C#"
public string Name { get; set; }
```

### White

The white color.

```csharp title="C#"
public Color White { get; set; }
```

### Black

The black color.

```csharp title="C#"
public Color Black { get; set; }
```

### Gray

The gray color.

```csharp title="C#"
public Color Gray { get; set; }
```

### GrayDark

The dark gray color.

```csharp title="C#"
public Color GrayDark { get; set; }
```

### Red

The red color.

```csharp title="C#"
public Color Red { get; set; }
```

### Green

The green color.

```csharp title="C#"
public Color Green { get; set; }
```

### Blue

The blue color.

```csharp title="C#"
public Color Blue { get; set; }
```

### Purple

The purple color.

```csharp title="C#"
public Color Purple { get; set; }
```

### Yellow

The yellow color.

```csharp title="C#"
public Color Yellow { get; set; }
```

### Orange

The orange color.

```csharp title="C#"
public Color Orange { get; set; }
```

### Cyan

The cyan color.

```csharp title="C#"
public Color Cyan { get; set; }
```

### Brown

The brown color.

```csharp title="C#"
public Color Brown { get; set; }
```

### RedDark

The dark red color.

```csharp title="C#"
public Color RedDark { get; set; }
```

### GreenDark

The dark green color.

```csharp title="C#"
public Color GreenDark { get; set; }
```

### BlueDark

The dark blue color.

```csharp title="C#"
public Color BlueDark { get; set; }
```

### PurpleDark

The dark purple color.

```csharp title="C#"
public Color PurpleDark { get; set; }
```

### YellowDark

The dark yellow color.

```csharp title="C#"
public Color YellowDark { get; set; }
```

### OrangeDark

The dark orange color.

```csharp title="C#"
public Color OrangeDark { get; set; }
```

### CyanDark

The dark cyan color.

```csharp title="C#"
public Color CyanDark { get; set; }
```

### BrownDark

The dark brown color.

```csharp title="C#"
public Color BrownDark { get; set; }
```

### Gold

The gold color.

```csharp title="C#"
public Color Gold { get; set; }
```

### GoldDark

The dark gold color.

```csharp title="C#"
public Color GoldDark { get; set; }
```

### Silver

The silver color.

```csharp title="C#"
public Color Silver { get; set; }
```

### SilverDark

The dark silver color.

```csharp title="C#"
public Color SilverDark { get; set; }
```

### Bronze

The bronze color.

```csharp title="C#"
public Color Bronze { get; set; }
```

### BronzeDark

The dark bronze color.

```csharp title="C#"
public Color BronzeDark { get; set; }
```

### ModalBackground

The color used to darken the background when <see cref="o:UI.Window.Show"></see> is called and [IsModal](../sadconsole.ui.window/#ismodal) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>. Defaults to (20, 20, 20, 200).

```csharp title="C#"
public Color ModalBackground { get; set; }
```

### Title

Color used for titles.

```csharp title="C#"
public AdjustableColor Title { get; set; }
```

### Lines

Color used in drawing lines.

```csharp title="C#"
public AdjustableColor Lines { get; set; }
```

### ControlForegroundNormal

Color of a control's foreground in normal state.

```csharp title="C#"
public AdjustableColor ControlForegroundNormal { get; set; }
```

### ControlForegroundDisabled

Color of a control's foreground in disabled state.

```csharp title="C#"
public AdjustableColor ControlForegroundDisabled { get; set; }
```

### ControlForegroundMouseOver

Color of a control's foreground in mouse-over state.

```csharp title="C#"
public AdjustableColor ControlForegroundMouseOver { get; set; }
```

### ControlForegroundMouseDown

Color of a control's foreground in mouse-button-down state.

```csharp title="C#"
public AdjustableColor ControlForegroundMouseDown { get; set; }
```

### ControlForegroundSelected

Color of a control's foreground in selected state.

```csharp title="C#"
public AdjustableColor ControlForegroundSelected { get; set; }
```

### ControlForegroundFocused

Color of a control's foreground in focused state.

```csharp title="C#"
public AdjustableColor ControlForegroundFocused { get; set; }
```

### ControlBackgroundNormal

Color of a control's background in normal state.

```csharp title="C#"
public AdjustableColor ControlBackgroundNormal { get; set; }
```

### ControlBackgroundDisabled

Color of a control's background in disabled state.

```csharp title="C#"
public AdjustableColor ControlBackgroundDisabled { get; set; }
```

### ControlBackgroundMouseOver

Color of a control's background in normal state.

```csharp title="C#"
public AdjustableColor ControlBackgroundMouseOver { get; set; }
```

### ControlBackgroundMouseDown

Color of a control's background in mouse-button-down state.

```csharp title="C#"
public AdjustableColor ControlBackgroundMouseDown { get; set; }
```

### ControlBackgroundSelected

Color of a control's background in selected state.

```csharp title="C#"
public AdjustableColor ControlBackgroundSelected { get; set; }
```

### ControlBackgroundFocused

Color of a control's background in focused state.

```csharp title="C#"
public AdjustableColor ControlBackgroundFocused { get; set; }
```

### ControlHostForeground

Color of the control host's foreground.

```csharp title="C#"
public AdjustableColor ControlHostForeground { get; set; }
```

### ControlHostBackground

Color of the control host's background.

```csharp title="C#"
public AdjustableColor ControlHostBackground { get; set; }
```

### Appearance_ControlNormal

The appearance of a control when in the normal state.

```csharp title="C#"
public ColoredGlyphBase Appearance_ControlNormal { get; set; }
```

### Appearance_ControlDisabled

The appearance of a control when in the disabled state.

```csharp title="C#"
public ColoredGlyphBase Appearance_ControlDisabled { get; set; }
```

### Appearance_ControlOver

The appearance of a control when in the mouse-over state.

```csharp title="C#"
public ColoredGlyphBase Appearance_ControlOver { get; set; }
```

### Appearance_ControlSelected

The appearance of a control when in the selected state.

```csharp title="C#"
public ColoredGlyphBase Appearance_ControlSelected { get; set; }
```

### Appearance_ControlMouseDown

The appearance of a control when in the mouse-down state.

```csharp title="C#"
public ColoredGlyphBase Appearance_ControlMouseDown { get; set; }
```

### Appearance_ControlFocused

The appearance of a control when in the focused state.

```csharp title="C#"
public ColoredGlyphBase Appearance_ControlFocused { get; set; }
```

## Methods

### RebuildAppearances()

Sets all Appearance* properties based on the existing colors and settings.

```csharp title="C#"
public virtual void RebuildAppearances()
```


### GetOffColor(Color, Color)

Compares two colors and if they match, returns a color that is lighter or darker based on if [IsLightTheme](../sadconsole.ui.colors/#islighttheme).

```csharp title="C#"
public Color GetOffColor(Color inColor, Color compareColor)
```

#### Parameters

`inColor` SadRogue.Primitives.Color  
The base color.

`compareColor` SadRogue.Primitives.Color  
The color to compare with.

#### Returns

SadRogue.Primitives.Color  
A new color.

### NormalizeBlack(Color)

Normalizes a dark color to at least R:25 G:25 B:25 A:255.

```csharp title="C#"
public static Color NormalizeBlack(Color inColor)
```

#### Parameters

`inColor` SadRogue.Primitives.Color  
The color to check.

#### Returns

SadRogue.Primitives.Color  
A new color.

### CopyTo(Colors)

Copies the colors to another color object.

```csharp title="C#"
public void CopyTo(Colors colors)
```

#### Parameters

`colors` [Colors](../sadconsole.ui.colors/)  
The color object to copy to.


### FromColorName(ColorNames)

Gets a color by enumeration.

```csharp title="C#"
public Color FromColorName(Colors.ColorNames color)
```

#### Parameters

`color` [Colors.ColorNames](../sadconsole.ui.colors/)  
The color to get.

#### Returns

SadRogue.Primitives.Color  
A color.

### SetColorByName(ColorNames, Color)

Sets a named color to a specified value.

```csharp title="C#"
public void SetColorByName(Colors.ColorNames name, Color color)
```

#### Parameters

`name` [Colors.ColorNames](../sadconsole.ui.colors/)  
The name of the color.

`color` SadRogue.Primitives.Color  
The color value.


### TryToColorName(Color, out ColorNames)

Tries to get the color name of the specified color.

```csharp title="C#"
public bool TryToColorName(Color color, out Colors.ColorNames colorName)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to match.

`colorName` [Colors.ColorNames](../sadconsole.ui.colors/)  
Set to the color enumeration value when the `color` parameter matches a defined color.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified color matched a defined color name; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### AddToColorMappings()

Adds each color here to the [ColorMappings](../sadrogue.primitives.colorextensions2/#colormappings) dictionary. Uses the format of "theme.property-name".

```csharp title="C#"
public void AddToColorMappings()
```


### Clone()

Returns a clone of this object.

```csharp title="C#"
public Colors Clone()
```

#### Returns

[Colors](../sadconsole.ui.colors/)  
A new Colors object.

### CreateSadConsoleBlue()

Creates a new colors object with the default blue colors theme of SadConsole.

```csharp title="C#"
public static Colors CreateSadConsoleBlue()
```

#### Returns

[Colors](../sadconsole.ui.colors/)

### CreateAnsi()

Creates a new colors object with a standard black-based theme.

```csharp title="C#"
public static Colors CreateAnsi()
```

#### Returns

[Colors](../sadconsole.ui.colors/)