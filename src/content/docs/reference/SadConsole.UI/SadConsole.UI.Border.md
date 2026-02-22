---
title: Border Class
slug: reference/sadconsole.ui.border
sidebar:
  label: Border
editUrl: false
description: Creates a 3D border around a surface.
---
## Definition

Creates a 3D border around a surface.

```csharp title="C#"
public class Border : ScreenSurface, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### Border(IScreenSurface, BorderParameters, IFont?)

Creates a border and adds it as a child object to `contents`.

```csharp title="C#"
public Border(IScreenSurface contents, Border.BorderParameters parameters, IFont? font = null)
```

#### Parameters

`contents` [IScreenSurface](../sadconsole.iscreensurface/)  
The object the border will be around.

`parameters` [Border.BorderParameters](../sadconsole.ui.border/)  
[Border.BorderParameters](../sadconsole.ui.border.borderparameters/) to be used in creating the [Border](../sadconsole.ui.border/).

`font` [IFont](../sadconsole.ifont/)  
Optional [IFont](../sadconsole.ifont/) for the border [CellSurface](../sadconsole.cellsurface/).


### Border(IScreenSurface, string)

Creates a border (with a shadow and a title) and adds it as a child object to `contents`.

```csharp title="C#"
public Border(IScreenSurface contents, string title)
```

#### Parameters

`contents` [IScreenSurface](../sadconsole.iscreensurface/)  
The object the border will be around.

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Title to display on the border.


### Border(IScreenSurface, string, Color, Color)

Creates a border (with a shadow and a title) and adds it as a child object to `contents`.

```csharp title="C#"
public Border(IScreenSurface contents, string title, Color textColor, Color borderColor)
```

#### Parameters

`contents` [IScreenSurface](../sadconsole.iscreensurface/)  
The object the border will be around.

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Optional title to display on the border.

`textColor` SadRogue.Primitives.Color  
Title text foreground color.

`borderColor` SadRogue.Primitives.Color  
Border line foreground color and title text background color.


### Border(Window)

Creates a border and adds it as a child object to the window.

```csharp title="C#"
public Border(Window contents)
```

#### Parameters

`contents` [Window](../sadconsole.ui.window/)  
The window the border will be around.


## Methods

### Create3DForSurface(IScreenSurface, string, Color?, Color?, Color?, Color?, Color?)

Creates a chunky 3d border using ``SadConsole.ICellSurface.Connected3dBox`` glyphs.

```csharp title="C#"
public static Border Create3DForSurface(IScreenSurface contents, string title, Color? titleForeground = null, Color? titleBackground = null, Color? borderBrightColor = null, Color? borderDarkColor = null, Color? borderBetweenColor = null)
```

#### Parameters

`contents` [IScreenSurface](../sadconsole.iscreensurface/)  
The object the border will be around.

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Optional title to display on the border.

`titleForeground` System.NullableSadRogue.Primitives.Color  
Foreground color of the title. Defaults to a brighter version of the content's [DefaultBackground](../sadconsole.icellsurface/#defaultbackground).

`titleBackground` System.NullableSadRogue.Primitives.Color  
Background color of the title. Defaults to the content's [DefaultForeground](../sadconsole.icellsurface/#defaultforeground).

`borderBrightColor` System.NullableSadRogue.Primitives.Color  
The bright color of the 3D border. Defaults to ``SadRogue.Primitives.Color.AnsiWhiteBright``.

`borderDarkColor` System.NullableSadRogue.Primitives.Color  
The dark color of the 3D border. Defaults to ``SadRogue.Primitives.Color.AnsiBlackBright``.

`borderBetweenColor` System.NullableSadRogue.Primitives.Color  
The corner color of the 3D border. Defaults to the content's [DefaultBackground](../sadconsole.icellsurface/#defaultbackground).

#### Returns

[Border](../sadconsole.ui.border/)  
The created border, attached to the content.
#### Remarks

For a nice looking border, set the content's [DefaultForeground](../sadconsole.icellsurface/#defaultforeground) to ``SadRogue.Primitives.Color.AnsiWhite`` and the [DefaultBackground](../sadconsole.icellsurface/#defaultbackground) to ``SadRogue.Primitives.Color.AnsiBlue``, before calling this method.

### CreateForSurface(IScreenSurface, string)

Helper method to add a border to a surface.

```csharp title="C#"
public static void CreateForSurface(IScreenSurface contents, string title)
```

#### Parameters

`contents` [IScreenSurface](../sadconsole.iscreensurface/)  
The object the border will be around.

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Optional title to display on the border.


### CreateForWindow(Window)

Helper method to add a border to a window.

```csharp title="C#"
public static void CreateForWindow(Window contents)
```

#### Parameters

`contents` [Window](../sadconsole.ui.window/)  
The window the border will be around.