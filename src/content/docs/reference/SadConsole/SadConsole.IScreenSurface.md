---
title: IScreenSurface Interface
slug: reference/sadconsole.iscreensurface
sidebar:
  label: IScreenSurface
editUrl: false
description: A screen object that has mouse input, surface, and render information.
---
## Definition

A screen object that has mouse input, surface, and render information.

```csharp title="C#"
public interface IScreenSurface : IScreenObject, IPositionable, IComponentHost
```


## Properties

### DefaultRendererName

The name of the default renderer for this object.

```csharp title="C#"
string DefaultRendererName { get; }
```

### FocusOnMouseClick

When true, this object will set [IsFocused](../sadconsole.iscreenobject/#isfocused) to true when the mouse is clicked.

```csharp title="C#"
bool FocusOnMouseClick { get; set; }
```

### HeightPixels

The height of the surface in pixels.

```csharp title="C#"
int HeightPixels { get; }
```

### MoveToFrontOnMouseClick

When true, this object will move to the front of its parent object when the mouse is clicked.

```csharp title="C#"
bool MoveToFrontOnMouseClick { get; set; }
```

### Renderer

The renderer used to draw this surface.

```csharp title="C#"
IRenderer? Renderer { get; }
```

### Surface

The surface.

```csharp title="C#"
ICellSurface Surface { get; }
```

### UsePixelPositioning

Treats the ``SadRogue.Primitives.IPositionable.Position`` of the object as if it is pixels and not cells.

```csharp title="C#"
bool UsePixelPositioning { get; set; }
```

### WidthPixels

The width of the surface in pixels.

```csharp title="C#"
int WidthPixels { get; }
```

### AbsoluteArea

The pixel area on the screen this surface occupies.

```csharp title="C#"
Rectangle AbsoluteArea { get; }
```

### Font

Font used with rendering.

```csharp title="C#"
IFont Font { get; set; }
```

### FontSize

The size of the [Font](../sadconsole.iscreensurface/#font) cells applied to the object when rendering.

```csharp title="C#"
Point FontSize { get; set; }
```

### ForceRendererRefresh

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, forces the [Renderer](../sadconsole.iscreensurface/#renderer) to refresh the backing texture with the latest state of the object.

```csharp title="C#"
bool ForceRendererRefresh { get; set; }
```

### IsDirty

Indicates the surface has changed and needs to be rendered.

```csharp title="C#"
bool IsDirty { get; set; }
```

### Tint

A tint used in rendering.

```csharp title="C#"
Color Tint { get; set; }
```

## Events

### MouseButtonClicked

Raised when a mouse button is clicked on this object.

```csharp title="C#"
event EventHandler<MouseScreenObjectState> MouseButtonClicked
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseEnter

Raised when the mouse enters this object.

```csharp title="C#"
event EventHandler<MouseScreenObjectState> MouseEnter
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseExit

Raised when the mouse exits this object.

```csharp title="C#"
event EventHandler<MouseScreenObjectState> MouseExit
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)
### MouseMove

Raised when the mouse moves around the this object.

```csharp title="C#"
event EventHandler<MouseScreenObjectState> MouseMove
```

#### Event Type

[EventHandler\<MouseScreenObjectState\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)