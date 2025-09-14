---
title: Helpers Class
slug: reference/sadconsole.ansi.helpers
sidebar:
  label: Helpers
---
## Definition

Helpers related to ANSI processing.

```csharp title="C#"
public static class Helpers
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### AnsiJustNormalColor(Color)

Returns the a normal, dark, ansi color based on the ansi color provided.

```csharp title="C#"
public static Color AnsiJustNormalColor(Color input)
```

#### Parameters

`input` SadRogue.Primitives.Color  
An ansi color.

#### Returns

SadRogue.Primitives.Color  
The adjusted color.
#### Remarks

If the color provided is not an ansi color, dark or light, the passed in color will be returned.

### AnsiAdjustColor(Color, bool)

Adjusts the provided color based on the `bold` value.

```csharp title="C#"
public static Color AnsiAdjustColor(Color input, bool bold)
```

#### Parameters

`input` SadRogue.Primitives.Color  
The ansi color to adjust.

`bold` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, adjusts the color to the bright version. When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, adjusts the color to the normal version.

#### Returns

SadRogue.Primitives.Color  
The adjusted color.
#### Remarks

If the color provided is not an ansi color, dark or light, the passed in color will be returned.

### AnsiConfigurePrintColor(bool, int, State)

Sets the print appearance of the cursor based on the ANSI.SYS code provided.

```csharp title="C#"
public static void AnsiConfigurePrintColor(bool isBackground, int code, State ansiState)
```

#### Parameters

`isBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, changes the background color instead of the foreground.

`code` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The 0-7 color code.

`ansiState` [State](../sadconsole.ansi.state/)  
The current state of the ANSI settings.