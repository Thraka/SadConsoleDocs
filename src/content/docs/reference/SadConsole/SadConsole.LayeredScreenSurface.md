---
title: LayeredScreenSurface Class
slug: reference/sadconsole.layeredscreensurface
sidebar:
  label: LayeredScreenSurface
editUrl: false
description: A basic console that can contain controls.
---
## Definition

A basic console that can contain controls.

```csharp title="C#"
[DataContract]
public class LayeredScreenSurface : ScreenSurface, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ILayeredData, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ILayeredData](../sadconsole.renderers.ilayereddata/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### LayeredScreenSurface(int, int)

Creates a new console.

```csharp title="C#"
public LayeredScreenSurface(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.


### LayeredScreenSurface(int, int, ColoredGlyphBase[])

Creates a new screen object that can render a surface. Uses the specified cells to generate the surface.

```csharp title="C#"
public LayeredScreenSurface(int width, int height, ColoredGlyphBase[] initialCells)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The initial cells to seed the surface.


### LayeredScreenSurface(int, int, int, int)

Creates a new console with the specified width and height, with ``SadRogue.Primitives.Color.Transparent`` for the background and ``SadRogue.Primitives.Color.White`` for the foreground.

```csharp title="C#"
public LayeredScreenSurface(int width, int height, int bufferWidth, int bufferHeight)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible width of the console in cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible height of the console in cells.

`bufferWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the console in cells.

`bufferHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the console in cells.


### LayeredScreenSurface(int, int, int, int, ColoredGlyphBase[]?)

Creates a console with the specified width and height, with ``SadRogue.Primitives.Color.Transparent`` for the background and ``SadRogue.Primitives.Color.White`` for the foreground.

```csharp title="C#"
public LayeredScreenSurface(int width, int height, int bufferWidth, int bufferHeight, ColoredGlyphBase[]? initialCells)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the console in cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the console in cells.

`bufferWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the console in cells.

`bufferHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the console in cells.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The cells to seed the console with. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, creates the cells for you.


### LayeredScreenSurface(ICellSurface, IFont?, Point?)

Creates a new console using the existing surface.

```csharp title="C#"
public LayeredScreenSurface(ICellSurface surface, IFont? font = null, Point? fontSize = null)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface.

`font` [IFont](../sadconsole.ifont/)  
The font to use with the surface.

`fontSize` System.NullableSadRogue.Primitives.Point  
The font size.


## Properties

### Layers

The controls host holding all the controls.

```csharp title="C#"
public LayeredSurface Layers { get; }
```

## Methods

### Resize(int, int, int, int, bool)

Resizes the surface to the specified width and height.

```csharp title="C#"
public void Resize(int viewWidth, int viewHeight, int totalWidth, int totalHeight, bool clear)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable width of the surface.

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable height of the surface.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum width of the surface.

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum height of the surface.

`clear` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, resets every cell to the [DefaultForeground](../sadconsole.icellsurface/#defaultforeground), [DefaultBackground](../sadconsole.icellsurface/#defaultbackground) and glyph 0.


### Resize(int, int, bool)

Resizes the surface and view to the specified width and height.

```csharp title="C#"
public void Resize(int width, int height, bool clear)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface and view.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface and view.

`clear` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, resets every cell to the [DefaultForeground](../sadconsole.icellsurface/#defaultforeground), [DefaultBackground](../sadconsole.icellsurface/#defaultbackground) and glyph 0.


### ToString()

Returns the value "ScreenSurface (Layered)".

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string "ScreenSurface (Layered)".