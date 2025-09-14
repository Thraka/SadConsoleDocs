---
title: OtherColorsPopup Class
slug: reference/sadconsole.ui.windows.othercolorspopup
sidebar:
  label: OtherColorsPopup
---
## Definition

A window that displays all known colors.

```csharp title="C#"
public class OtherColorsPopup : Window, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize, IWindowData
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/) → [Console](../sadconsole.console/) → [Window](../sadconsole.ui.window/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/), [IWindowData](../sadconsole.renderers.iwindowdata/)

## Constructors

### OtherColorsPopup()

Creates a new instance of this window with size 40, 20.

```csharp title="C#"
public OtherColorsPopup()
```


## Properties

### SelectedColor

The selected color.

```csharp title="C#"
public Color SelectedColor { get; }
```

## Methods

### DrawBorder()

Draws the border around the controls.

```csharp title="C#"
protected override void DrawBorder()
```