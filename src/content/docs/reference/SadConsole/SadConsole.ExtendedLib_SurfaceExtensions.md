---
title: ExtendedLib_SurfaceExtensions Class
slug: reference/sadconsole.extendedlib_surfaceextensions
sidebar:
  label: ExtendedLib_SurfaceExtensions
editUrl: false
description: Extensions for the `SadConsole.IScreenSurface` type
---
## Definition

Extensions for the [IScreenSurface](../sadconsole.iscreensurface/) type

```csharp title="C#"
public static class ExtendedLib_SurfaceExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### PrintFadingText(IScreenSurface, string, Point, TimeSpan, ICellEffect?)

Prints text that blinks out the characters each after the specified time, using the default foreground and background colors of the surface.

```csharp title="C#"
public static void PrintFadingText(this IScreenSurface surfaceObject, string text, Point position, TimeSpan time, ICellEffect? effect = null)
```

#### Parameters

`surfaceObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface to draw the text on.

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to print.

`position` SadRogue.Primitives.Point  
The position where to print the text.

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time each glyph (one after the other) takes to print then fade.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
Optional effect to use. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> is passed, uses an instant fade.


### PrintFadingText(IScreenSurface, ColoredString, Point, TimeSpan, ICellEffect?)

```csharp title="C#"
public static void PrintFadingText(this IScreenSurface surfaceObject, ColoredString text, Point position, TimeSpan time, ICellEffect? effect = null)
```

#### Parameters

`surfaceObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface to draw the text on.

`text` [ColoredString](../sadconsole.coloredstring/)  
The text to print.

`position` SadRogue.Primitives.Point  
The position where to print the text.

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time each glyph (one after the other) takes to print then fade.

`effect` [ICellEffect](../sadconsole.effects.icelleffect/)  
Optional effect to use. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> is passed, uses an instant fade.