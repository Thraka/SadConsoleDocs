---
title: Window Class
slug: reference/sadconsole.ui.window
sidebar:
  label: Window
---
## Definition

Represents a windowed controls console.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization.OptIn)]
public class Window : Console, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize, IWindowData
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/) → [Console](../sadconsole.console/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/), [IWindowData](../sadconsole.renderers.iwindowdata/)

## Constructors

### Window(int, int)

Creates a new window.

```csharp title="C#"
public Window(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.


### Window(int, int, ColoredGlyphBase[]?)

Creates a new screen object that can render a surface. Uses the specified cells to generate the surface.

```csharp title="C#"
public Window(int width, int height, ColoredGlyphBase[]? initialCells)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width in cells of the surface.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height in cells of the surface.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The initial cells to seed the surface.


### Window(int, int, int, int)

Creates a new window with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public Window(int width, int height, int bufferWidth, int bufferHeight)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible width of the window in cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The visible height of the window in cells.

`bufferWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the window in cells.

`bufferHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the window in cells.


### Window(int, int, int, int, ColoredGlyphBase[]?)

Creates a window with the specified width and height, with `SadRogue.Primitives.Color.Transparent` for the background and `SadRogue.Primitives.Color.White` for the foreground.

```csharp title="C#"
public Window(int width, int height, int bufferWidth, int bufferHeight, ColoredGlyphBase[]? initialCells)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the window in cells.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the window in cells.

`bufferWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total width of the window in cells.

`bufferHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The total height of the window in cells.

`initialCells` [ColoredGlyphBase[]](../sadconsole.coloredglyphbase/)  
The cells to seed the window with. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, creates the cells for you.


### Window(ICellSurface, IFont?, Point?)

Creates a new window using the existing surface.

```csharp title="C#"
public Window(ICellSurface surface, IFont? font = null, Point? fontSize = null)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  
The surface.

`font` [IFont](../sadconsole.ifont/)  
The font to use with the surface.

`fontSize` System.NullableSadRogue.Primitives.Point  
The font size.


## Fields

### PreviousMouseLeftButtonDown

The mouse state of the previous update frame.

```csharp title="C#"
protected bool PreviousMouseLeftButtonDown
```

## Properties

### Controls

The controls host holding all the controls.

```csharp title="C#"
public ControlHost Controls { get; }
```

### TitleAreaY

The Y coordinate of the title drawing area. This can be set to any value &gt; 0 and &lt; the height.

```csharp title="C#"
[DataMember]
public int TitleAreaY { get; set; }
```

### TitleAreaX

The X coordinate of the title drawing area. This is automatically set by the theme.

```csharp title="C#"
[DataMember]
public int TitleAreaX { get; set; }
```

### TitleAreaLength

The width of the title drawing area. This is automatically set by the theme.

```csharp title="C#"
[DataMember]
public int TitleAreaLength { get; set; }
```

### BorderLineStyle

The line style for the border.

```csharp title="C#"
[DataMember]
public int[] BorderLineStyle { get; set; }
```

### CellAtDragPosition

The position of the cell that the window drag started at.

```csharp title="C#"
[IgnoreDataMember]
protected Point CellAtDragPosition { get; set; }
```

### PreviousMouseExclusiveDrag

Temporary value to hold the state of [IsExclusiveMouse](../sadconsole.iscreenobject/#isexclusivemouse/) prior to dragging.

```csharp title="C#"
[IgnoreDataMember]
protected bool PreviousMouseExclusiveDrag { get; set; }
```

### AddedToParent

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the window has been added to a parent; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[IgnoreDataMember]
protected bool AddedToParent { get; set; }
```

### IsDragging

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the window is being dragged; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
[IgnoreDataMember]
protected bool IsDragging { get; set; }
```

### TitleAlignment

Gets or sets the alignment of the window title.

```csharp title="C#"
[DataMember]
public HorizontalAlignment TitleAlignment { get; set; }
```

### IsModal

Gets the whether or not the window is being shown as modal.

```csharp title="C#"
[IgnoreDataMember]
public bool IsModal { get; }
```

### CanDrag

Gets or sets whether or not this window can be moved with the mouse.

```csharp title="C#"
[DataMember]
public bool CanDrag { get; set; }
```

### CloseOnEscKey

Gets or sets whether or not this window can be closed when the escape key is pressed.

```csharp title="C#"
[DataMember]
public bool CloseOnEscKey { get; set; }
```

### DialogResult

Gets or set the dialog result status of the window.

```csharp title="C#"
[DataMember]
public bool DialogResult { get; set; }
```

### IsModalDefault

Indicates that when this window is shown by the [Show()](../sadconsole.ui.window/#show/) method or by setting the [IsVisible](../sadconsole.iscreenobject/#isvisible/) property to true, the window will be shown as modal.

```csharp title="C#"
[DataMember]
public bool IsModalDefault { get; set; }
```

### Title

Gets or sets the title displayed on the window.

```csharp title="C#"
public string Title { get; set; }
```

## Methods

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

### DrawBorder()

```csharp title="C#"
protected virtual void DrawBorder()
```


### ProcessKeyboard(Keyboard)

Processes the keyboard looking for the ESC key press to close the window, if required. Otherwise the base ControlsConsole will process the keyboard.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard info)
```

#### Parameters

`info` [Keyboard](../sadconsole.input.keyboard/)  
Keyboard state.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### OnVisibleChanged()

Depending on if the window is visible, calls [Show(bool)](../sadconsole.ui.window/#/) or [Hide()](../sadconsole.ui.window/#hide/).

```csharp title="C#"
protected override void OnVisibleChanged()
```


### OnShown()

User-definable code called when the window is shown.

```csharp title="C#"
protected virtual void OnShown()
```


### OnHidden()

User-definable code called when the window is hidden.

```csharp title="C#"
protected virtual void OnHidden()
```


### Show()

Displays this window using the modal value of the [IsModalDefault](../sadconsole.ui.window/#ismodaldefault/) property.

```csharp title="C#"
public void Show()
```


### Show(bool)

Displays this window.

```csharp title="C#"
public virtual void Show(bool modal)
```

#### Parameters

`modal` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, the window will be displayed as modal; otherwise false.


### Hide()

Hides the window.

```csharp title="C#"
public virtual void Hide()
```


### Center()

Centers the window within the bounds of [RenderWidth](../sadconsole.settings.rendering/#renderwidth/) and [RenderHeight](../sadconsole.settings.rendering/#renderheight/)

```csharp title="C#"
public void Center()
```


### ToString()

Returns the value "Window".

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string "Window".

### Ask(string, string, string, Action<bool, string>?, Validator?, string?, Colors?)

Displays a window with an input box and an optional validator with a text prompt.

```csharp title="C#"
public static void Ask(string message, string acceptPrompt, string cancelPrompt, Action<bool, string>? closedCallback, StringValidation.Validator? validator = null, string? defaultValue = null, Colors? colors = null)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The message to print in the window.

`acceptPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text of the accept button.

`cancelPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text of the cancel button.

`closedCallback` [Action\<bool, string\>](https://learn.microsoft.com/dotnet/api/system.action-2/)  
A delegate called when the window is closed.

`validator` [StringValidation.Validator](../sadconsole.stringvalidation/)  
An optional validator to validate the input text.

`defaultValue` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
An optional default value of the input text box.

`colors` [Colors](../sadconsole.ui.colors/)  
An optional set of colors to apply to the window.


### Ask(ColoredString, string, string, Action<bool, string>?, Validator?, string?, Colors?)

Displays a window with an input box and an optional validator, using a [ColoredString](../sadconsole.coloredstring/) as the prompt text.

```csharp title="C#"
public static void Ask(ColoredString message, string acceptPrompt, string cancelPrompt, Action<bool, string>? closedCallback, StringValidation.Validator? validator = null, string? defaultValue = null, Colors? colors = null)
```

#### Parameters

`message` [ColoredString](../sadconsole.coloredstring/)  
The message to print in the window.

`acceptPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text of the accept button.

`cancelPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text of the cancel button.

`closedCallback` [Action\<bool, string\>](https://learn.microsoft.com/dotnet/api/system.action-2/)  
A delegate called when the window is closed.

`validator` [StringValidation.Validator](../sadconsole.stringvalidation/)  
An optional validator to validate the input text.

`defaultValue` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
An optional default value of the input text box.

`colors` [Colors](../sadconsole.ui.colors/)  
An optional set of colors to apply to the window.


### Prompt(string, string, string, Action<bool>?, Colors?)

Shows a window prompt with two buttons for the user to click.

```csharp title="C#"
public static void Prompt(string message, string yesPrompt, string noPrompt, Action<bool>? closedCallback, Colors? colors = null)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to display.

`yesPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The yes button's text.

`noPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The no button's text.

`closedCallback` [Action\<bool\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
Callback with the yes (true) or no (false) result.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply for the message box and buttons. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.


### Prompt(ColoredString, string, string, Action<bool>?, Colors?)

Shows a window prompt with two buttons for the user to click.

```csharp title="C#"
public static void Prompt(ColoredString message, string yesPrompt, string noPrompt, Action<bool>? closedCallback, Colors? colors = null)
```

#### Parameters

`message` [ColoredString](../sadconsole.coloredstring/)  
The text to display. (background color is ignored)

`yesPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The yes button's text.

`noPrompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The no button's text.

`closedCallback` [Action\<bool\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
Callback with the yes (true) or no (false) result.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply for the message box and buttons. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.


### Message(string, string, Action?, Colors?)

Displays a dialog to the user with a specific message.

```csharp title="C#"
public static void Message(string message, string closeButtonText, Action? closedCallback = null, Colors? colors = null)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The message.

`closeButtonText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text of the dialog's close button.

`closedCallback` [Action](https://learn.microsoft.com/dotnet/api/system.action/)  
A callback indicating the message was dismissed.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply for the message box and buttons. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.


### Message(ColoredString, string, Action?, Colors?)

Displays a dialog to the user with a specific message.

```csharp title="C#"
public static void Message(ColoredString message, string closeButtonText, Action? closedCallback = null, Colors? colors = null)
```

#### Parameters

`message` [ColoredString](../sadconsole.coloredstring/)  
The message. (background color is ignored)

`closeButtonText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text of the dialog's close button.

`closedCallback` [Action](https://learn.microsoft.com/dotnet/api/system.action/)  
A callback indicating the message was dismissed.

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply for the message box and buttons. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.


## Events

### Closed

Raised when the window is closed.

```csharp title="C#"
public event EventHandler? Closed
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### Shown

Raised when the window is shown.

```csharp title="C#"
public event EventHandler? Shown
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)