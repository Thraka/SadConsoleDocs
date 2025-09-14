---
title: GlyphSelectPopup Class
slug: reference/sadconsole.ui.windows.glyphselectpopup
sidebar:
  label: GlyphSelectPopup
---
## Definition

A popup window that displays the glyphs of a font.

```csharp title="C#"
public class GlyphSelectPopup : Window, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize, IWindowData
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/) → [Console](../sadconsole.console/) → [Window](../sadconsole.ui.window/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/), [IWindowData](../sadconsole.renderers.iwindowdata/)

## Constructors

### GlyphSelectPopup(int, int, IFont, Point)

Creates a new instance of this popup with the specified width, height, font, and font size.

```csharp title="C#"
public GlyphSelectPopup(int width, int height, IFont font, Point fontSize)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the window.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the window.

`font` [IFont](../sadconsole.ifont/)  
The font to use for the window and character picker.

`fontSize` SadRogue.Primitives.Point  
The font size of the window.


## Methods

### Show(IFont, Point)

Shows a modal version of this popup.

```csharp title="C#"
public static void Show(IFont font, Point fontSize)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font to display.

`fontSize` SadRogue.Primitives.Point  
The size of the font.


### AddRootComponent(Keys)

Adds a root component to SadConsole that displays the popup window when the specified key is pressed.

```csharp title="C#"
public static void AddRootComponent(Keys key)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to display the popup with.


### AddRootComponent(Keys, IFont, Point)

Adds a root component to SadConsole that displays the popup window with a specific font and font size, when the specified key is pressed.

```csharp title="C#"
public static void AddRootComponent(Keys key, IFont font, Point fontSize)
```

#### Parameters

`key` [Keys](../sadconsole.input.keys/)  
The key to display the popup with.

`font` [IFont](../sadconsole.ifont/)  
The font to display.

`fontSize` SadRogue.Primitives.Point  
The size of the font.


### DrawBorder()

Redraws the border, title, and lines.

```csharp title="C#"
protected override void DrawBorder()
```