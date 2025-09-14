---
title: ScreenSurface Class
slug: reference/sadconsole.screensurface
sidebar:
  label: ScreenSurface
---
## Definition

An object that renders a [ICellSurface](../sadconsole.icellsurface/).

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization.OptIn)]
public class ScreenSurface : ScreenObject, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### ScreenSurface(int, int)

Creates a new screen object that can render a surface.

```csharp title="C#"
public ScreenSurface(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.


### ScreenSurface(int, int, ColoredGlyphBase[])

Creates a new screen object that can render a surface. Uses the specified cells to generate the surface.

```csharp title="C#"
public ScreenSurface(int width, int height, ColoredGlyphBase[] initialCells)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The initial cells to seed the surface.


### ScreenSurface(int, int, int, int)

Creates a new surface with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public ScreenSurface(int viewWidth, int viewHeight, int totalWidth, int totalHeight)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible width of the surface in cells.

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible height of the surface in cells.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the surface in cells.

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the surface in cells.


### ScreenSurface(IGridView<ColoredGlyphBase>, int, int)

Creates a new surface from a grid view. The cells between this object and the grid view are shared.

```csharp title="C#"
public ScreenSurface(IGridView<ColoredGlyphBase> surface, int visibleWidth = 0, int visibleHeight = 0)
```

#### Parameters

`surface` [IGridView\<ColoredGlyphBase\>](../sadconsole.coloredglyphbase/)  
The surface to use as the source of cells.

`visibleWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Optional view width. If <code>0</code>, the view width matches the width of the surface.

`visibleHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Optional view height. If <code>0</code>, the view width matches the height of the surface.


### ScreenSurface(int, int, int, int, ColoredGlyphBase[]?)

Creates a new surface with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public ScreenSurface(int viewWidth, int viewHeight, int totalWidth, int totalHeight, ColoredGlyphBase[]? initialCells)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface in cells to show.

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface in cells to show.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the surface in cells.

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the surface in cells.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The cells to seed the surface with. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, creates the cell array for you.


### ScreenSurface(ICellSurface, IFont?, Point?)

Creates a new screen object wrapping an existing surface.

```csharp title="C#"
[JsonConstructor]
public ScreenSurface(ICellSurface surface, IFont? font = null, Point? fontSize = null)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface.

`font` [IFont](../sadconsole.ifont/)  
The font to use with the surface.

`fontSize` System.NullableSadRogue.Primitives.Point  
The font size.


## Fields

### MouseState_EnteredWithButtonDown

A cached value determined by [OnMouseEnter(MouseScreenObjectState)](../sadconsole.screensurface/#/). <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the mouse entered the surface bounds with the mouse button down.

```csharp title="C#"
protected bool MouseState_EnteredWithButtonDown
```

### IsMouseOver

Indicates that the mouse is currently over this console.

```csharp title="C#"
protected bool IsMouseOver
```

## Properties

### ForceRendererRefresh

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, forces the [Renderer](../sadconsole.iscreensurface/#renderer/) to refresh the backing texture with the latest state of the object.

```csharp title="C#"
public bool ForceRendererRefresh { get; set; }
```

### DefaultRendererName

The name of the default renderer for this object.

```csharp title="C#"
public virtual string DefaultRendererName { get; }
```

### Renderer

The renderer used to draw this surface.

```csharp title="C#"
[DataMember]
[JsonConverter(typeof(RendererJsonConverter))]
public IRenderer? Renderer { get; protected set; }
```

### QuietSurfaceHandling

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, prevents the [Surface](../sadconsole.screensurface/#surface/) property from raising events and virtual methods when the surface changes.

```csharp title="C#"
[DataMember]
public bool QuietSurfaceHandling { get; set; }
```

### Surface

The surface this screen object represents.

```csharp title="C#"
public ICellSurface Surface { get; set; }
```

### IsDirty

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the [Surface](../sadconsole.screensurface/#surface/) needs to be redrawn; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### Font

Font used with rendering.

```csharp title="C#"
public IFont Font { get; set; }
```

### FontSize

The size of the [Font](../sadconsole.iscreensurface/#font/) cells applied to the object when rendering.

```csharp title="C#"
public Point FontSize { get; set; }
```

### Tint

A tint used in rendering.

```csharp title="C#"
public Color Tint { get; set; }
```

### AbsoluteArea

The pixel area on the screen this surface occupies.

```csharp title="C#"
public Rectangle AbsoluteArea { get; }
```

### UsePixelPositioning

Treats the `SadRogue.Primitives.IPositionable.Position` of the object as if it is pixels and not cells.

```csharp title="C#"
public bool UsePixelPositioning { get; set; }
```

### WidthPixels

The width of the surface in pixels.

```csharp title="C#"
public int WidthPixels { get; }
```

### HeightPixels

The height of the surface in pixels.

```csharp title="C#"
public int HeightPixels { get; }
```

### Width

The total width of the console.

```csharp title="C#"
public int Width { get; }
```

### Height

The total height of the console.

```csharp title="C#"
public int Height { get; }
```

### ViewWidth

Gets or sets the visible width of the surface in cells.

```csharp title="C#"
public int ViewWidth { get; set; }
```

### ViewHeight

Gets or sets the visible height of the surface in cells.

```csharp title="C#"
public int ViewHeight { get; set; }
```

### ViewPosition

The position of the view within the console.

```csharp title="C#"
public Point ViewPosition { get; set; }
```

### MoveToFrontOnMouseClick

When true, this object will move to the front of its parent object when the mouse is clicked.

```csharp title="C#"
[DataMember]
public bool MoveToFrontOnMouseClick { get; set; }
```

### FocusOnMouseClick

When true, this object will set [IsFocused](../sadconsole.iscreenobject/#isfocused/) to true when the mouse is clicked.

```csharp title="C#"
[DataMember]
public bool FocusOnMouseClick { get; set; }
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
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, resets every cell to the <xref href="SadConsole.ICellSurface.DefaultForeground" data-throw-if-not-resolved="false"></xref>, <xref href="SadConsole.ICellSurface.DefaultBackground" data-throw-if-not-resolved="false"></xref> and glyph 0.


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
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, resets every cell to the <xref href="SadConsole.ICellSurface.DefaultForeground" data-throw-if-not-resolved="false"></xref>, <xref href="SadConsole.ICellSurface.DefaultBackground" data-throw-if-not-resolved="false"></xref> and glyph 0.


### UpdateAbsolutePosition()

Sets a value for [AbsolutePosition](../sadconsole.iscreenobject/#absoluteposition/) based on the `SadRogue.Primitives.IPositionable.Position` of this instance and the [Parent](../sadconsole.iscreenobject/#parent/) instance.

```csharp title="C#"
public override void UpdateAbsolutePosition()
```


### Render(TimeSpan)

Draws the [Surface](../sadconsole.screensurface/#surface/) and all [SadComponents](../sadconsole.screenobject/#sadcomponents/) and [Children](../sadconsole.screenobject/#children/).

```csharp title="C#"
public override void Render(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last call.


### Update(TimeSpan)

Updates the [Surface](../sadconsole.screensurface/#surface/) effects and all [SadComponents](../sadconsole.screenobject/#sadcomponents/) and [Children](../sadconsole.screenobject/#children/).

```csharp title="C#"
public override void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.


### OnIsDirtyChanged()

Called when the [IsDirty](../sadconsole.screensurface/#isdirty/) property changes.

```csharp title="C#"
protected virtual void OnIsDirtyChanged()
```


### OnFontChanged(IFont, Point)

Called when the [Font](../sadconsole.screensurface/#font/) or [FontSize](../sadconsole.screensurface/#fontsize/) property changes.

```csharp title="C#"
protected virtual void OnFontChanged(IFont oldFont, Point oldFontSize)
```

#### Parameters

`oldFont` [IFont](../sadconsole.ifont/)  
The font prior to the change.

`oldFontSize` SadRogue.Primitives.Point  
The font size prior to the change.


### OnSurfaceChanged(ICellSurface)

Called when the [Surface](../sadconsole.screensurface/#surface/) property is changed.

```csharp title="C#"
protected virtual void OnSurfaceChanged(ICellSurface oldSurface)
```

#### Parameters

`oldSurface` [ICellSurface](../sadconsole.icellsurface/)  
The previous surface.


### OnRendererChanged()

Called when the [Renderer](../sadconsole.screensurface/#renderer/) property is changed.

```csharp title="C#"
protected virtual void OnRendererChanged()
```


### ToString()

Returns the value "ScreenSurface".

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string "ScreenSurface".

### CallOnHostUpdated()

Calls the OnHostUpdated method on components, renderer, and rendersteps.

```csharp title="C#"
public void CallOnHostUpdated()
```


### Dispose(bool)

```csharp title="C#"
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### ~ScreenSurface()

Disposes [Renderer](../sadconsole.screensurface/#renderer/).

```csharp title="C#"
protected ~ScreenSurface()
```


### Dispose()

```csharp title="C#"
public void Dispose()
```


### OnMouseEnter(MouseScreenObjectState)

Raises the [MouseEnter](../sadconsole.screensurface/#mouseenter/) event.

```csharp title="C#"
protected virtual void OnMouseEnter(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnMouseExit(MouseScreenObjectState)

Raises the [MouseExit](../sadconsole.screensurface/#mouseexit/) event.

```csharp title="C#"
protected virtual void OnMouseExit(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnMouseMove(MouseScreenObjectState)

Raises the [MouseMove](../sadconsole.screensurface/#mousemove/) event.

```csharp title="C#"
protected virtual void OnMouseMove(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnMouseLeftClicked(MouseScreenObjectState)

Raises the [MouseButtonClicked](../sadconsole.screensurface/#mousebuttonclicked/) event. Possibly moves the console to the top of it's parent's children collection.

```csharp title="C#"
protected virtual void OnMouseLeftClicked(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnRightMouseClicked(MouseScreenObjectState)

Raises the [MouseButtonClicked](../sadconsole.screensurface/#mousebuttonclicked/) event.

```csharp title="C#"
protected virtual void OnRightMouseClicked(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### LostMouse(MouseScreenObjectState)

Called when the mouse is being used by something else.

```csharp title="C#"
public override void LostMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The current state of the mouse based on this object.


### ProcessMouse(MouseScreenObjectState)

Processes the mouse.

```csharp title="C#"
public override bool ProcessMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The mouse state related to this object.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when this object should halt further mouse processing..

## Events

### MouseButtonClicked

Raised when a mouse button is clicked on this object.

```csharp title="C#"
public event EventHandler<MouseScreenObjectState>? MouseButtonClicked
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseMove

Raised when the mouse moves around the this object.

```csharp title="C#"
public event EventHandler<MouseScreenObjectState>? MouseMove
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseExit

Raised when the mouse exits this object.

```csharp title="C#"
public event EventHandler<MouseScreenObjectState>? MouseExit
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseEnter

Raised when the mouse enters this object.

```csharp title="C#"
public event EventHandler<MouseScreenObjectState>? MouseEnter
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)