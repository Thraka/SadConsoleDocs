---
title: ICellSurface Interface
slug: reference/sadconsole.icellsurface
sidebar:
  label: ICellSurface
editUrl: false
description: An array of `SadConsole.ColoredGlyphBase` objects used to represent a 2D surface.
---
## Definition

An array of [ColoredGlyphBase](../sadconsole.coloredglyphbase/) objects used to represent a 2D surface.

```csharp title="C#"
public interface ICellSurface : IGridView<ColoredGlyphBase>, IEnumerable<ColoredGlyphBase>, IEnumerable, ISurface
```


## Properties

### TimesShiftedDown

A variable that tracks how many times this editor shifted the surface down.

```csharp title="C#"
int TimesShiftedDown { get; set; }
```

### TimesShiftedRight

A variable that tracks how many times this editor shifted the surface right.

```csharp title="C#"
int TimesShiftedRight { get; set; }
```

### TimesShiftedLeft

A variable that tracks how many times this editor shifted the surface left.

```csharp title="C#"
int TimesShiftedLeft { get; set; }
```

### TimesShiftedUp

A variable that tracks how many times this editor shifted the surface up.

```csharp title="C#"
int TimesShiftedUp { get; set; }
```

### UsePrintProcessor

When true, the [Parser](../sadconsole.coloredstring/#parser) is used to generate a [ColoredString](../sadconsole.coloredstring/) before printing.

```csharp title="C#"
bool UsePrintProcessor { get; set; }
```

### Effects

Processes the effects added to cells with ``CellSurfaceEditor.SetEffect*``.

```csharp title="C#"
EffectsManager Effects { get; }
```

### Area

Returns a rectangle that represents the entire size of the surface.

```csharp title="C#"
Rectangle Area { get; }
```

### DefaultBackground

The default background for glyphs on this surface.

```csharp title="C#"
Color DefaultBackground { get; set; }
```

### DefaultForeground

The default foreground for glyphs on this surface.

```csharp title="C#"
Color DefaultForeground { get; set; }
```

### DefaultGlyph

The default glyph used in clearing and erasing.

```csharp title="C#"
int DefaultGlyph { get; set; }
```

### IsDirty

Indicates the surface has changed and needs to be rendered.

```csharp title="C#"
bool IsDirty { get; set; }
```

### IsScrollable

Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the [View](../sadconsole.icellsurface/#view) width or height is different from [Area](../sadconsole.icellsurface/#area); otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool IsScrollable { get; }
```

### View

The visible portion of the surface.

```csharp title="C#"
Rectangle View { get; set; }
```

### ViewHeight

Gets or sets the visible height of the surface in cells.

```csharp title="C#"
int ViewHeight { get; set; }
```

### ViewPosition

The position of the view within the buffer.

```csharp title="C#"
Point ViewPosition { get; set; }
```

### ViewWidth

Gets or sets the visible width of the surface in cells.

```csharp title="C#"
int ViewWidth { get; set; }
```

### ConnectedLineThin

Glyph indexes for a thin line.

```csharp title="C#"
public static int[] ConnectedLineThin { get; }
```

### ConnectedLineThick

Glyph indexes for a thick line.

```csharp title="C#"
public static int[] ConnectedLineThick { get; }
```

### Connected3dBox

Glyph indexes for a block box that looks 3d.

```csharp title="C#"
public static int[] Connected3dBox { get; }
```

### ConnectedLineThinExtended

Glyph indexes for a thin line using a SadConsole extended font.

```csharp title="C#"
public static int[] ConnectedLineThinExtended { get; }
```

### ConnectedLineEmpty

Glyph indexes for an empty line 0.

```csharp title="C#"
public static int[] ConnectedLineEmpty { get; }
```

## Methods

### CreateLine(int)

Creates an array of glyphs that can be used as a connected line.

```csharp title="C#"
public static int[] CreateLine(int singleGlyph)
```

#### Parameters

`singleGlyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to use for the connected line array.

#### Returns

[int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  
An array of glyphs.

### ValidateLineStyle\<T>(in T[])

Returns a value that indicates a line style array is not null and contains the required number of elements.

```csharp title="C#"
public static bool ValidateLineStyle<T>(in T[] connectedLineStyle)
```

#### Parameters

`connectedLineStyle` T[]  
The array to check based on the [ICellSurface.ConnectedLineIndex](../sadconsole.icellsurface.connectedlineindex/) enum.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the line style is correct.

## Events

### IsDirtyChanged

An event that is raised when [IsDirty](../sadconsole.icellsurface/#isdirty) changes.

```csharp title="C#"
event EventHandler IsDirtyChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)