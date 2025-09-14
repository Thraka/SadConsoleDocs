---
title: Console Class
slug: reference/sadconsole.console
sidebar:
  label: Console
---
## Definition

A surface that has a cursor.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class Console : ScreenSurface, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### Console(int, int)

Creates a new console.

```csharp title="C#"
public Console(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.


### Console(int, int, ColoredGlyphBase[])

Creates a new screen object that can render a surface. Uses the specified cells to generate the surface.

```csharp title="C#"
public Console(int width, int height, ColoredGlyphBase[] initialCells)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The initial cells to seed the surface.


### Console(int, int, int, int)

Creates a new console with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public Console(int width, int height, int bufferWidth, int bufferHeight)
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


### Console(int, int, int, int, ColoredGlyphBase[]?)

Creates a console with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public Console(int width, int height, int bufferWidth, int bufferHeight, ColoredGlyphBase[]? initialCells)
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


### Console(ICellSurface, IFont?, Point?)

Creates a new console using the existing surface.

```csharp title="C#"
public Console(ICellSurface surface, IFont? font = null, Point? fontSize = null)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface.

`font` [IFont](../sadconsole.ifont/)  
The font to use with the surface.

`fontSize` System.NullableSadRogue.Primitives.Point  
The font size.


## Properties

### Cursor

The virtual cursor reference.

```csharp title="C#"
public Cursor Cursor { get; protected set; }
```

### AutoCursorOnFocus

Toggles the cursor as visible\hidden when the console if focused\unfocused.

```csharp title="C#"
[DataMember]
public bool AutoCursorOnFocus { get; set; }
```

## Methods

### OnVisibleChanged()

Called when the visibility of the object changes.

```csharp title="C#"
protected override void OnVisibleChanged()
```


### OnFocusLost()

Called when this console's focus has been lost. Hides the [Cursor](../sadconsole.console/#cursor/) if [AutoCursorOnFocus](../sadconsole.console/#autocursoronfocus/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public override void OnFocusLost()
```


### OnFocused()

Called when this console is focused. Shows the [Cursor](../sadconsole.console/#cursor/) if [AutoCursorOnFocus](../sadconsole.console/#autocursoronfocus/) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
public override void OnFocused()
```


### ToString()

Returns the value "Console".

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string "Console".