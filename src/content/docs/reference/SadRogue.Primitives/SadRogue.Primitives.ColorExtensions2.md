---
title: ColorExtensions2 Class
slug: reference/sadrogue.primitives.colorextensions2
sidebar:
  label: ColorExtensions2
editUrl: false
description: Various extension methods to `SadRogue.Primitives.Color` class.
---
## Definition

Various extension methods to ``SadRogue.Primitives.Color`` class.

```csharp title="C#"
public static class ColorExtensions2
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### ColorMappings

Custom color mappings for the [FromName(string)](../sadrogue.primitives.colorextensions2/#fromnamestring) and [FromParser(Color, string, out bool, out bool, out bool, out bool, out bool)](../sadrogue.primitives.colorextensions2/#fromparsercolor-string-out-bool-out-bool-out-bool-out-bool-out-bool) methods. Key names should be lowercase.

```csharp title="C#"
public static Dictionary<string, Color> ColorMappings
```

## Methods

### LerpSteps(Color, Color, int)

Creates an array of colors that includes the `color` and `endingColor` and `steps` of colors between them.

```csharp title="C#"
public static Color[] LerpSteps(this Color color, Color endingColor, int steps)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The starting color which will be at index 0 in the array.

`endingColor` SadRogue.Primitives.Color  
The ending color which will be at index `steps - 1` in the array.

`steps` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The gradient steps in the array which uses [Lerp(Color, Color, float)](https://learn.microsoft.com/dotnet/api/system.single/).

#### Returns

SadRogue.Primitives.Color[]  
An array of colors.

### SetHSL(Color, float, float, float)

Sets the color values based on HSL instead of RGB.

```csharp title="C#"
public static Color SetHSL(this Color color, float h, float s, float l)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to change.

`h` [float](https://learn.microsoft.com/dotnet/api/system.single/)  
The hue amount.

`s` [float](https://learn.microsoft.com/dotnet/api/system.single/)  
The saturation amount.

`l` [float](https://learn.microsoft.com/dotnet/api/system.single/)  
The luminance amount.

#### Returns

SadRogue.Primitives.Color
#### Remarks

Taken from http://www.easyrgb.com/index.php?X=MATH&amp;H=19#text19

### GetRandomColor(Color, Random)

Gets a random color.

```csharp title="C#"
public static Color GetRandomColor(this Color color, Random random)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color object to start with. Will be overridden.

`random` [Random](https://learn.microsoft.com/dotnet/api/system.random/)  
A random object to get numbers from.

#### Returns

SadRogue.Primitives.Color  
A new color.

### GetDark(Color)

Gets a darker version of the color. R,G,B channels are * 0.25f.

```csharp title="C#"
public static Color GetDark(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A darker color.

### GetDarker(Color)

Gets a darker version of the color. R,G,B channels are * 0.50f.

```csharp title="C#"
public static Color GetDarker(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A darker color.

### GetDarkest(Color)

Gets a darker version of the color. R,G,B channels are * 0.75f.

```csharp title="C#"
public static Color GetDarkest(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A darker color.

### GetBright(Color)

Gets a brighter version of the color. R,G,B channels are * 1.25f.

```csharp title="C#"
public static Color GetBright(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A darker color.

### GetBrighter(Color)

Gets a brighter version of the color. R,G,B channels are * 1.50f.

```csharp title="C#"
public static Color GetBrighter(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A darker color.

### GetBrightest(Color)

Gets a brighter version of the color. R,G,B channels are * 1.75f.

```csharp title="C#"
public static Color GetBrightest(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A darker color.

### RedOnly(Color)

Returns a new Color using only the Red value of this color.

```csharp title="C#"
public static Color RedOnly(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with only the red channel set.

### GreenOnly(Color)

Returns a new Color using only the Green value of this color.

```csharp title="C#"
public static Color GreenOnly(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with only the green channel set.

### BlueOnly(Color)

Returns a new Color using only the Blue value of this color.

```csharp title="C#"
public static Color BlueOnly(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with only the blue channel set.

### AlphaOnly(Color)

Returns a new Color using only the Alpha value of this color.

```csharp title="C#"
public static Color AlphaOnly(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with only the alpha channel set.

### ClearRed(Color)

Returns a new color with the red channel set to 0.

```csharp title="C#"
public static Color ClearRed(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the red channel cleared.

### ClearGreen(Color)

Returns a new color with the green channel set to 0.

```csharp title="C#"
public static Color ClearGreen(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the green channel cleared.

### ClearBlue(Color)

Returns a new color with the blue channel set to 0.

```csharp title="C#"
public static Color ClearBlue(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the blue channel cleared.

### ClearAlpha(Color)

Returns a new color with the alpha channel set to 0.

```csharp title="C#"
public static Color ClearAlpha(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the alpha channel cleared.

### FillRed(Color)

Returns a new color with the red channel set to 255.

```csharp title="C#"
public static Color FillRed(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the red channel fully set.

### FillGreen(Color)

Returns a new color with the green channel set to 255.

```csharp title="C#"
public static Color FillGreen(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the green channel fully set.

### FillBlue(Color)

Returns a new color with the blue channel set to 255.

```csharp title="C#"
public static Color FillBlue(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the blue channel fully set.

### FillAlpha(Color)

Returns a new color with the alpha channel set to 255.

```csharp title="C#"
public static Color FillAlpha(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

#### Returns

SadRogue.Primitives.Color  
A color with the alpha channel fully set.

### SetRed(Color, byte)

Returns a new color with the red channel set to the specified value.

```csharp title="C#"
public static Color SetRed(this Color color, byte value)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

`value` [byte](https://learn.microsoft.com/dotnet/api/system.byte/)  
The new value for the red channel.

#### Returns

SadRogue.Primitives.Color  
A color with the red channel altered.

### SetGreen(Color, byte)

Returns a new color with the green channel set to the specified value.

```csharp title="C#"
public static Color SetGreen(this Color color, byte value)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

`value` [byte](https://learn.microsoft.com/dotnet/api/system.byte/)  
The new value for the green channel.

#### Returns

SadRogue.Primitives.Color  
A color with the green channel altered.

### SetBlue(Color, byte)

Returns a new color with the blue channel set to the specified value.

```csharp title="C#"
public static Color SetBlue(this Color color, byte value)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

`value` [byte](https://learn.microsoft.com/dotnet/api/system.byte/)  
The new value for the blue channel.

#### Returns

SadRogue.Primitives.Color  
A color with the blue channel altered.

### SetAlpha(Color, byte)

Returns a new color with the alpha channel set to the specified value.

```csharp title="C#"
public static Color SetAlpha(this Color color, byte value)
```

#### Parameters

`color` SadRogue.Primitives.Color  
Object instance.

`value` [byte](https://learn.microsoft.com/dotnet/api/system.byte/)  
The new value for the alpha channel.

#### Returns

SadRogue.Primitives.Color  
A color with the alpha channel altered.

### GetLuma(Color)

Gets the luma of an existing color.

```csharp title="C#"
public static float GetLuma(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to calculate the luma from.

#### Returns

[float](https://learn.microsoft.com/dotnet/api/system.single/)  
A value based on this code: (color.R + color.R + color.B + color.G + color.G + color.G) / 6f

### GetBrightness(Color)

Gets the brightness of a color.

```csharp title="C#"
public static float GetBrightness(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to process.

#### Returns

[float](https://learn.microsoft.com/dotnet/api/system.single/)  
The brightness value.
#### Remarks

Taken from the mono source code.

### GetSaturation(Color)

Gets the saturation of a color.

```csharp title="C#"
public static float GetSaturation(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to process.

#### Returns

[float](https://learn.microsoft.com/dotnet/api/system.single/)  
The saturation value.
#### Remarks

Taken from the mono source code.

### GetHue(Color)

Gets the hue of a color.

```csharp title="C#"
public static float GetHue(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to process.

#### Returns

[float](https://learn.microsoft.com/dotnet/api/system.single/)  
The hue value.
#### Remarks

Taken from the mono source code.

### ToParser(Color)

Converts a color to the format used by [ParseCommandRecolor](../sadconsole.stringparser.parsecommandrecolor/) command.

```csharp title="C#"
public static string ToParser(this Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to convert.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A string in this format R,G,B,A so for ``SadRogue.Primitives.Color.Green`` you would get <pre>`0,128,0,255`</pre>.

### FromParser(Color, string, out bool, out bool, out bool, out bool, out bool)

Gets a color in the format of [ParseCommandRecolor](../sadconsole.stringparser.parsecommandrecolor/).

```csharp title="C#"
public static Color FromParser(this Color color, string value, out bool keepR, out bool keepG, out bool keepB, out bool keepA, out bool useDefault)
```

#### Parameters

`color` SadRogue.Primitives.Color  
The color to use as a base.

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string parser color command.

`keepR` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates that command wanted to keep the Red color channel.

`keepG` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates that command wanted to keep the Green color channel.

`keepB` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates that command wanted to keep the Blue color channel.

`keepA` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates that command wanted to keep the Alpha color channel.

`useDefault` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Indicates that command wanted to use the default values passed.

#### Returns

SadRogue.Primitives.Color

### FromName(string)

Searches [ColorMappings](../sadrogue.primitives.colorextensions2/#colormappings) for a defined color.

```csharp title="C#"
public static Color FromName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of a color.

#### Returns

SadRogue.Primitives.Color  
A color.

### FromName(string, Color)

Searches [ColorMappings](../sadrogue.primitives.colorextensions2/#colormappings) for a defined color. If color is not defined, the color specified by `defaultColor` is returned.

```csharp title="C#"
public static Color FromName(string name, Color defaultColor)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of a color.

`defaultColor` SadRogue.Primitives.Color  
Fallback color.

#### Returns

SadRogue.Primitives.Color  
A color.

### ToColoredString(Gradient, string)

Creates a [ColoredString](../sadconsole.coloredstring/) object using the current gradient.

```csharp title="C#"
public static ColoredString ToColoredString(this Gradient gradient, string text)
```

#### Parameters

`gradient` SadRogue.Primitives.Gradient  
The gradient to work with.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to use for the colored string.

#### Returns

[ColoredString](../sadconsole.coloredstring/)  
A new colored string object.