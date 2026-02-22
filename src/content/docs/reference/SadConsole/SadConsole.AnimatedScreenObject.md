---
title: AnimatedScreenObject Class
slug: reference/sadconsole.animatedscreenobject
sidebar:
  label: AnimatedScreenObject
editUrl: false
description: A `SadConsole.ScreenObject` that displays an animated set of `SadConsole.ICellSurface` surfaces.
---
## Definition

A [ScreenObject](../sadconsole.screenobject/) that displays an animated set of [ICellSurface](../sadconsole.icellsurface/) surfaces.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class AnimatedScreenObject : ScreenObject, IScreenSurface, IScreenObject, IPositionable, IComponentHost
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/)

Implements [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/)

## Constructors

### AnimatedScreenObject(string, int, int)

Creates a new animation with the specified name, width, and height.

```csharp title="C#"
public AnimatedScreenObject(string name, int width, int height)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the animation.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of each frame this animation will have.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of each frame this animation will have.


### AnimatedScreenObject(string, IEnumerable\<ICellSurface>)

Creates a new animation with the specified name and frames.

```csharp title="C#"
public AnimatedScreenObject(string name, IEnumerable<ICellSurface> frames)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the animation.

`frames` [IEnumerable\<ICellSurface\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The frames that make up the animation.


### AnimatedScreenObject(string, int, int, IFont, Point)

Creates a new animation with the specified name, width, and height.

```csharp title="C#"
public AnimatedScreenObject(string name, int width, int height, IFont font, Point fontSize)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the animation.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of each frame this animation will have.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of each frame this animation will have.

`font` [IFont](../sadconsole.ifont/)  
The font used with this animation.

`fontSize` SadRogue.Primitives.Point  
The size of the font.


### AnimatedScreenObject(string, IFont, Point, IEnumerable\<ICellSurface>)

```csharp title="C#"
[JsonConstructor]
public AnimatedScreenObject(string name, IFont font, Point fontSize, IEnumerable<ICellSurface> frames)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`font` [IFont](../sadconsole.ifont/)  

`fontSize` SadRogue.Primitives.Point  

`frames` [IEnumerable\<ICellSurface\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  


## Fields

### AddedTime

Time counter for the animation

```csharp title="C#"
protected TimeSpan AddedTime
```

### CurrentFrameIndexValue

The current frame index being animated.

```csharp title="C#"
protected int CurrentFrameIndexValue
```

### TimePerFrame

How much time per animated frame should be used.

```csharp title="C#"
protected TimeSpan TimePerFrame
```

### IsMouseOver

Indicates that the mouse is currently over this console.

```csharp title="C#"
protected bool IsMouseOver
```

### NewFrameWidth

The width to assign a frame when [CreateFrame()](../sadconsole.animatedscreenobject/#createframe) is called.

```csharp title="C#"
[DataMember]
protected int NewFrameWidth
```

### NewFrameHeight

The height to assign a frame when [CreateFrame()](../sadconsole.animatedscreenobject/#createframe) is called.

```csharp title="C#"
[DataMember]
protected int NewFrameHeight
```

## Properties

### Center

Center of the animation used in positioning.

```csharp title="C#"
[DataMember]
public Point Center { get; set; }
```

### Repeat

Indicates whether or not this animation will repeat once it has finished animating.

```csharp title="C#"
[DataMember]
public bool Repeat { get; set; }
```

### IsPlaying

When true, Indicates the animation is currently animating. The [Update(TimeSpan)](../sadconsole.animatedscreenobject/#updatetimespan) method will advance the frames.

```csharp title="C#"
[DataMember]
public bool IsPlaying { get; protected set; }
```

### AnimationDuration

The length of the animation.

```csharp title="C#"
[DataMember]
public TimeSpan AnimationDuration { get; set; }
```

### CurrentFrameIndex

Gets or sets the current frame index to animate.

```csharp title="C#"
public int CurrentFrameIndex { get; set; }
```

### IsEmpty

Indicates the animation is empty.

```csharp title="C#"
public bool IsEmpty { get; }
```

### Frames

The frames of the animated surface.

```csharp title="C#"
[DataMember]
public List<ICellSurface> Frames { get; }
```

### Name

Gets the name of this animation.

```csharp title="C#"
[DataMember]
public string Name { get; set; }
```

### State

Gets the current animation state.

```csharp title="C#"
public AnimatedScreenObject.AnimationState State { get; set; }
```

### MoveToFrontOnMouseClick

When true, this object will move to the front of its parent object when the mouse is clicked.

```csharp title="C#"
[DataMember]
public bool MoveToFrontOnMouseClick { get; set; }
```

### FocusOnMouseClick

When true, this object will set [IsFocused](../sadconsole.iscreenobject/#isfocused) to true when the mouse is clicked.

```csharp title="C#"
[DataMember]
public bool FocusOnMouseClick { get; set; }
```

### ForceRendererRefresh

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, forces the [Renderer](../sadconsole.iscreensurface/#renderer) to refresh the backing texture with the latest state of the object.

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
public IRenderer? Renderer { get; set; }
```

### IsDirty

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the animation needs to be redrawn; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsDirty { get; set; }
```

### Font

Font used with rendering.

```csharp title="C#"
public IFont Font { get; set; }
```

### FontSize

The size of the [Font](../sadconsole.iscreensurface/#font) cells applied to the object when rendering.

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

Treats the ``SadRogue.Primitives.IPositionable.Position`` of the object as if it is pixels and not cells.

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

### CurrentFrame

Gets the current animation frame surface. A shortcut for <pre>`Frames[CurrentFrameIndex]`</pre>

```csharp title="C#"
public ICellSurface CurrentFrame { get; }
```

## Methods

### CreateFrame()

Creates a new frame with the same dimensions as this entity and adds it to the Frames collection of the entity.

```csharp title="C#"
public ICellSurface CreateFrame()
```

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
The created frame.

### Stop()

Stops animating.

```csharp title="C#"
public void Stop()
```


### Start()

Starts animating the frames.

```csharp title="C#"
public void Start()
```


### Restart()

Restarts the animation from the first frame.

```csharp title="C#"
public void Restart()
```


### MoveNext(bool)

Changes the [CurrentFrame](../sadconsole.animatedscreenobject/#currentframe) to the next frame.

```csharp title="C#"
public void MoveNext(bool circular = false)
```

#### Parameters

`circular` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
If true and the current frame is the last, sets the current frame to the first frame.


### MovePrevious(bool)

Changes the [CurrentFrame](../sadconsole.animatedscreenobject/#currentframe) to the previous frame.

```csharp title="C#"
public void MovePrevious(bool circular = false)
```

#### Parameters

`circular` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
If true and the current frame is the first, sets the current frame to the last frame.


### MoveEnd()

Changes the [CurrentFrame](../sadconsole.animatedscreenobject/#currentframe) to the last frame.

```csharp title="C#"
public void MoveEnd()
```


### MoveStart()

Changes the [CurrentFrame](../sadconsole.animatedscreenobject/#currentframe) to the first frame.

```csharp title="C#"
public void MoveStart()
```


### CreateStatic(int, int, int, double, Color?, Color?)

Creates an animated surface that looks like static noise.

```csharp title="C#"
public static AnimatedScreenObject CreateStatic(int width, int height, int frames, double blankChance, Color? background = null, Color? foreground = null)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface.

`frames` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many frames the animation should have.

`blankChance` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
Chance a character will be blank. Characters are between index 48-158. Chance is evaluated versus [NextDouble()](https://learn.microsoft.com/dotnet/api/system.random.nextdouble/).

`background` System.NullableSadRogue.Primitives.Color  
The background color of the animation. Defaults to transparent.

`foreground` System.NullableSadRogue.Primitives.Color  
The foreground color of the animation. Defaults to white.

#### Returns

[AnimatedScreenObject](../sadconsole.animatedscreenobject/)  
An animation.

### FromImage(string, string, Point, TimeSpan, Point?, Point?, IFont?, Action\<ColoredGlyphBase>?, TextureConvertMode, TextureConvertForegroundStyle, TextureConvertBackgroundStyle, Color?)

Converts an image file containing frames to an instance of [AnimatedScreenObject](../sadconsole.animatedscreenobject/).

```csharp title="C#"
public static AnimatedScreenObject FromImage(string name, string filePath, Point frameLayout, TimeSpan frameDuration, Point? pixelPadding = null, Point? frameStartAndFinish = null, IFont? font = null, Action<ColoredGlyphBase>? action = null, TextureConvertMode convertMode = TextureConvertMode.Foreground, TextureConvertForegroundStyle convertForegroundStyle = TextureConvertForegroundStyle.Block, TextureConvertBackgroundStyle convertBackgroundStyle = TextureConvertBackgroundStyle.Pixel, Color? frameDefaultBackground = null)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Name for the animation.

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
File path to the image file.

`frameLayout` SadRogue.Primitives.Point  
Layout of frames in the image file: X number of columns, Y number of rows.

`frameDuration` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Duration for a frame in the animation.

`pixelPadding` System.NullableSadRogue.Primitives.Point  
Pixel padding separating frames: X between the columns, Y between the rows.

`frameStartAndFinish` System.NullableSadRogue.Primitives.Point  
Limits the number of frames copied to the animation. X first frame index, Y last frame index.

`font` [IFont](../sadconsole.ifont/)  
[IFont](../sadconsole.ifont/) to be used when creating the [AnimatedScreenObject](../sadconsole.animatedscreenobject/).

`action` [Action\<ColoredGlyphBase\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
Callback that will be applied to each [ColoredGlyphBase](../sadconsole.coloredglyphbase/) when creating a frame.

`convertMode` [TextureConvertMode](../sadconsole.textureconvertmode/)  
The mode used when converting the texture to a surface.

`convertForegroundStyle` [TextureConvertForegroundStyle](../sadconsole.textureconvertforegroundstyle/)  
The style to use when `convertMode` is [Foreground](../sadconsole.textureconvertmode/#foreground).

`convertBackgroundStyle` [TextureConvertBackgroundStyle](../sadconsole.textureconvertbackgroundstyle/)  
The style to use when `convertMode` is [Background](../sadconsole.textureconvertmode/#background).

`frameDefaultBackground` System.NullableSadRogue.Primitives.Color  
The default background to use in the animation frames. Defaults to transparent.

#### Returns

[AnimatedScreenObject](../sadconsole.animatedscreenobject/)  
An instance of [AnimatedScreenObject](../sadconsole.animatedscreenobject/) with converted frames.
#### Remarks

This method assumes the image file contains only frames and optional padding between the frames, no border space. Frame count is calculated by multiplying rows and columns from the frame layout. It can by limited by specifying frame start and finish indexes. Frame size and the subsequent AnimatedScreenSurface size is calculated from the size of the image file, number of frames, padding and the font size ratio.

### Save(string)

Saves the [AnimatedScreenObject](../sadconsole.animatedscreenobject/) to a file.

```csharp title="C#"
public void Save(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The destination file.


### Load(string)

Loads a [AnimatedScreenObject](../sadconsole.animatedscreenobject/) from a file.

```csharp title="C#"
public static AnimatedScreenObject Load(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The source file.

#### Returns

[AnimatedScreenObject](../sadconsole.animatedscreenobject/)  
The animated surface.

### OnMouseEnter(MouseScreenObjectState)

Raises the [MouseEnter](../sadconsole.animatedscreenobject/#mouseenter) event.

```csharp title="C#"
protected virtual void OnMouseEnter(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnMouseExit(MouseScreenObjectState)

Raises the [MouseExit](../sadconsole.animatedscreenobject/#mouseexit) event.

```csharp title="C#"
protected virtual void OnMouseExit(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnMouseMove(MouseScreenObjectState)

Raises the [MouseMove](../sadconsole.animatedscreenobject/#mousemove) event.

```csharp title="C#"
protected virtual void OnMouseMove(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnMouseLeftClicked(MouseScreenObjectState)

Raises the [MouseButtonClicked](../sadconsole.animatedscreenobject/#mousebuttonclicked) event. Possibly moves the console to the top of it's parent's children collection.

```csharp title="C#"
protected virtual void OnMouseLeftClicked(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
Current mouse state in relation to this console.


### OnRightMouseClicked(MouseScreenObjectState)

Raises the [MouseButtonClicked](../sadconsole.animatedscreenobject/#mousebuttonclicked) event.

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

### UpdateAbsolutePosition()

Sets a value for [AbsolutePosition](../sadconsole.iscreenobject/#absoluteposition) based on the ``SadRogue.Primitives.IPositionable.Position`` of this instance and the [Parent](../sadconsole.iscreenobject/#parent) instance.

```csharp title="C#"
public override void UpdateAbsolutePosition()
```


### Render(TimeSpan)

Draws the animation's current frame and all [SadComponents](../sadconsole.screenobject/#sadcomponents) and [Children](../sadconsole.screenobject/#children).

```csharp title="C#"
public override void Render(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last call.


### Update(TimeSpan)

Updates the [AnimatedScreenObject](../sadconsole.animatedscreenobject/) effects and all [SadComponents](../sadconsole.screenobject/#sadcomponents) and [Children](../sadconsole.screenobject/#children).

```csharp title="C#"
public override void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.


### ToString()

Returns the value "ScreenSurface".

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string "ScreenSurface".

### Dispose(bool)

```csharp title="C#"
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### ~AnimatedScreenObject()

Disposes [Renderer](../sadconsole.animatedscreenobject/#renderer).

```csharp title="C#"
protected ~AnimatedScreenObject()
```


### Dispose()

```csharp title="C#"
public void Dispose()
```


## Events

### AnimationStateChanged

Raised when the [AnimatedScreenObject.AnimationState](../sadconsole.animatedscreenobject.animationstate/) changes.

```csharp title="C#"
public event EventHandler<AnimatedScreenObject.AnimationStateChangedEventArgs>? AnimationStateChanged
```

#### Event Type

[EventHandler\<AnimatedScreenObject.AnimationStateChangedEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
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