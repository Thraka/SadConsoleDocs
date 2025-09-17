---
title: ColorPickerPopup Class
slug: reference/sadconsole.ui.windows.colorpickerpopup
sidebar:
  label: ColorPickerPopup
---
## Definition

A window that allows a user to select a color in various ways.

```csharp title="C#"
public class ColorPickerPopup : Window, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize, IWindowData
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/) → [Console](../sadconsole.console/) → [Window](../sadconsole.ui.window/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/), [IWindowData](../sadconsole.renderers.iwindowdata/)

## Constructors

### ColorPickerPopup()

Creates a new instance of the window.

```csharp title="C#"
public ColorPickerPopup()
```


## Properties

### SelectedColor

The color selected.

```csharp title="C#"
public Color SelectedColor { get; set; }
```

### PreviousColors

An array of colors previously selected.

```csharp title="C#"
public Color[] PreviousColors { get; }
```

## Methods

### DrawBorder()

Draws the border lines around the controls.

```csharp title="C#"
protected override void DrawBorder()
```


### AddPreviousColor(Color)

Adds a color to the array of previous colors.

```csharp title="C#"
public void AddPreviousColor(Color color)
```

#### Parameters

`color` SadRogue.Primitives.Color  


### Show(bool)

Displays this window.

```csharp title="C#"
public override void Show(bool modal)
```

#### Parameters

`modal` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, the window will be displayed as modal; otherwise false.