---
title: Cursor Class
slug: reference/sadconsole.components.cursor
sidebar:
  label: Cursor
editUrl: false
description: A cursor that is attached to a `SadConsole.Console` used for printing.
---
## Definition

A cursor that is attached to a [Console](../sadconsole.console/) used for printing.

```csharp title="C#"
[DataContract]
[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class Cursor : IComponent, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IComponent](../sadconsole.components.icomponent/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### Cursor()

Creates a new instance of the cursor as a component.

```csharp title="C#"
public Cursor()
```


### Cursor(ICellSurface)

Creates a new instance of the cursor that works with the specified surface.

```csharp title="C#"
public Cursor(ICellSurface surface)
```

#### Parameters

`surface` [ICellSurface](../sadconsole.icellsurface/)  


## Fields

### DefaultCursorGlyph

The default glyph used for a new cursor. Value 219.

```csharp title="C#"
public static readonly int DefaultCursorGlyph
```

## Properties

### CursorRenderCell

Cell used to render the cursor on the screen.

```csharp title="C#"
[DataMember(Order = 0)]
public ColoredGlyphBase CursorRenderCell { get; set; }
```

### CursorRenderCellActiveState

Used in rendering. The cell after the effect has been applied.

```csharp title="C#"
public ColoredGlyphBase CursorRenderCellActiveState { get; }
```

### PrintAppearance

Appearance used when printing text. [PrintOnlyCharacterData](../sadconsole.components.cursor/#printonlycharacterdata) must be set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> for this to apply.

```csharp title="C#"
[DataMember]
public ColoredGlyphBase PrintAppearance { get; set; }
```

### PrintAppearanceMatchesHost

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, printing will use the host's [DefaultForeground](../sadconsole.icellsurface/#defaultforeground) and [DefaultBackground](../sadconsole.icellsurface/#defaultbackground) color properties.

```csharp title="C#"
[DataMember]
public bool PrintAppearanceMatchesHost { get; set; }
```

### PrintEffect

This effect is applied to each cell printed by the cursor.

```csharp title="C#"
[DataMember]
public ICellEffect? PrintEffect { get; set; }
```

### CursorRenderEffect

This is the cursor visible effect, like blinking.

```csharp title="C#"
[DataMember]
public ICellEffect? CursorRenderEffect { get; set; }
```

### CursorGlyph

Sets the glyph used in rendering. A shortcut to [CursorRenderCell](../sadconsole.components.cursor/#cursorrendercell).

```csharp title="C#"
public int CursorGlyph { get; set; }
```

### PrintOnlyCharacterData

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the cursor, when printing, should not use the [PrintAppearance](../sadconsole.components.cursor/#printappearance) property in determining the color/effect of the cell, but keep the cell the same as it was.

```csharp title="C#"
[DataMember]
public bool PrintOnlyCharacterData { get; set; }
```

### MouseClickReposition

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, left-clicking on the host surface will reposition the cursor to the clicked position.

```csharp title="C#"
[DataMember]
public bool MouseClickReposition { get; set; }
```

### MouseClickRepositionHandlesMouse

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, returns a handled status from the mouse processor when the [MouseClickReposition](../sadconsole.components.cursor/#mouseclickreposition) is enabled. This prevents further left-mouse processing on the host.

```csharp title="C#"
[DataMember]
public bool MouseClickRepositionHandlesMouse { get; set; }
```

### IsVisible

Shows or hides the cursor. This does not affect how the cursor operates.

```csharp title="C#"
[DataMember]
public bool IsVisible { get; set; }
```

### IsEnabled

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, prevents the cursor from running on the host.

```csharp title="C#"
[DataMember]
public bool IsEnabled { get; set; }
```

### ApplyCursorEffect

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, prevents the [CursorRenderEffect](../sadconsole.components.cursor/#cursorrendereffect) from being applied.

```csharp title="C#"
public bool ApplyCursorEffect { get; set; }
```

### UsePrintEffect

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, applies the [PrintEffect](../sadconsole.components.cursor/#printeffect) to the cursor when it prints.

```csharp title="C#"
[DataMember]
public bool UsePrintEffect { get; set; }
```

### Position

Gets or sets the location of the cursor on the console.

```csharp title="C#"
[DataMember]
public Point Position { get; set; }
```

### DisableWordBreak

When true, prevents any print method from breaking words up by spaces when wrapping lines.

```csharp title="C#"
[DataMember]
public bool DisableWordBreak { get; set; }
```

### DisablePrintAutomaticLineFeed

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, printing characters to the end of a line won't wrap to the next line. Defaults to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, which moves the cursor to the next line if printing goes past the end of the line.

```csharp title="C#"
public bool DisablePrintAutomaticLineFeed { get; set; }
```

### UseLinuxLineEndings

Enables Linux-like string parsing where a \n behaves like a \r\n.

```csharp title="C#"
[DataMember]
public bool UseLinuxLineEndings { get; set; }
```

### UseStringParser

Indicates this cursor should process te string through the [Parse(ReadOnlySpan\<char\>, int, ICellSurface, ParseCommandStacks)](../sadconsole.stringparser.iparser/#parsereadonlyspanchar-int-icellsurface-parsecommandstacks) method from [Parser](../sadconsole.coloredstring/#parser) to create a colored string when using [Print(string)](../sadconsole.components.cursor/#printstring) or [Print(string, ColoredGlyphBase, ICellEffect)](../sadconsole.components.cursor/#printstring-coloredglyphbase-icelleffect).

```csharp title="C#"
[DataMember]
public bool UseStringParser { get; set; }
```

### Row

Gets or sets the row of the cursor position.

```csharp title="C#"
public int Row { get; set; }
```

### Column

Gets or sets the column of the cursor position.

```csharp title="C#"
public int Column { get; set; }
```

### AutomaticallyShiftRowsUp

Indicates that when the cursor goes past the last cell of the console, that the rows should be shifted up when the cursor is automatically reset to the next line.

```csharp title="C#"
[DataMember]
public bool AutomaticallyShiftRowsUp { get; set; }
```

### SortOrder

Sets the sort order of this component within the host.

```csharp title="C#"
[DataMember]
public uint SortOrder { get; set; }
```

## Methods

### ApplyDefaultCursorEffect()

Resets the [CursorRenderEffect](../sadconsole.components.cursor/#cursorrendereffect) back to the default.

```csharp title="C#"
public Cursor ApplyDefaultCursorEffect()
```

#### Returns

[Cursor](../sadconsole.components.cursor/)

### RestartCursorEffect()

Clones and reassigns [CursorRenderEffect](../sadconsole.components.cursor/#cursorrendereffect) to restart it.

```csharp title="C#"
public Cursor RestartCursorEffect()
```

#### Returns

[Cursor](../sadconsole.components.cursor/)

### SetPrintAppearanceToHost()

Sets the cursor appearance to the console's default foreground and background.

```csharp title="C#"
public Cursor SetPrintAppearanceToHost()
```

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when the cursor is not attached to any surface.


### SetPrintAppearance(ColoredGlyphBase)

Sets [PrintAppearance](../sadconsole.components.cursor/#printappearance).

```csharp title="C#"
public Cursor SetPrintAppearance(ColoredGlyphBase appearance)
```

#### Parameters

`appearance` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The appearance to set.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### SetPrintAppearance(Color, Color)

Sets [PrintAppearance](../sadconsole.components.cursor/#printappearance).

```csharp title="C#"
public Cursor SetPrintAppearance(Color foreground, Color background)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The foreground color.

`background` SadRogue.Primitives.Color  
The background color

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### SetPrintAppearance(Color)

Sets [PrintAppearance](../sadconsole.components.cursor/#printappearance), only changing the foreground color.

```csharp title="C#"
public Cursor SetPrintAppearance(Color foreground)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
The foreground color.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### Print(string)

Prints text to the console using the default print appearance.

```csharp title="C#"
public Cursor Print(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to print.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
Returns this cursor object.

### Print(string, ColoredGlyphBase, ICellEffect?)

Prints text on the console.

```csharp title="C#"
public Cursor Print(string text, ColoredGlyphBase template, ICellEffect? templateEffect)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to print.

`template` [ColoredGlyphBase](../sadconsole.coloredglyphbase/)  
The way the text will look when it is printed.

`templateEffect` [ICellEffect](../sadconsole.effects.icelleffect/)  
Effect to apply to the text as its printed. Can be <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
Returns this cursor object.

### PrintCoroutine(ColoredString)

Prints text to the console using the appearance of the colored string, but with coroutine.

```csharp title="C#"
public IEnumerator<Wait> PrintCoroutine(ColoredString text)
```

#### Parameters

`text` [ColoredString](../sadconsole.coloredstring/)  
The text to print.

#### Returns

[IEnumerator\<Wait\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)  
An enumerator that returns at each character printed.

### Print(ColoredString)

Prints text to the console using the appearance of the colored string.

```csharp title="C#"
public Cursor Print(ColoredString text)
```

#### Parameters

`text` [ColoredString](../sadconsole.coloredstring/)  
The text to print.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
Returns this cursor object.

### CarriageReturn()

Returns the cursor to the start of the current line.

```csharp title="C#"
public Cursor CarriageReturn()
```

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The current cursor object.

### LineFeed()

Moves the cursor down a line.

```csharp title="C#"
public Cursor LineFeed()
```

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The current cursor object.

### NewLine()

Calls the [CarriageReturn()](../sadconsole.components.cursor/#carriagereturn) and [LineFeed()](../sadconsole.components.cursor/#linefeed) methods in a single call.

```csharp title="C#"
public Cursor NewLine()
```

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The current cursor object.

### Move(Point)

Moves the cursor to the specified position.

```csharp title="C#"
public Cursor Move(Point position)
```

#### Parameters

`position` SadRogue.Primitives.Point  
The destination of the cursor.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### Move(int, int)

Moves the cursor to the specified position.

```csharp title="C#"
public Cursor Move(int x, int y)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x (horizontal) of the position.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The x (vertical) of the position.

#### Returns

[Cursor](../sadconsole.components.cursor/)

### Up(int)

Moves the cursor up by the specified amount of lines.

```csharp title="C#"
public Cursor Up(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount of lines to move the cursor

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### Down(int)

Moves the cursor down by the specified amount of lines.

```csharp title="C#"
public Cursor Down(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount of lines to move the cursor

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### Left(int)

Moves the cursor left by the specified amount of columns.

```csharp title="C#"
public Cursor Left(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount of columns to move the cursor

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### LeftWrap(int)

Moves the cursor left by the specified amount of columns, wrapping the cursor if needed.

```csharp title="C#"
public Cursor LeftWrap(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount of columns to move the cursor

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### Right(int)

Moves the cursor right by the specified amount of columns.

```csharp title="C#"
public Cursor Right(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount of columns to move the cursor

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### RightWrap(int)

Moves the cursor right by the specified amount of columns, wrapping the cursor if needed.

```csharp title="C#"
public Cursor RightWrap(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The amount of columns to move the cursor

#### Returns

[Cursor](../sadconsole.components.cursor/)  
This cursor object.

### Erase(int)

Clears the cell at the position of the cursor.

```csharp title="C#"
public Cursor Erase(int glyph = 0)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to set on the erased cell. Defaults to glyph index 0.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when a host isn't attached to the cursor.


### EraseColumn(int)

Clears the cells in the same column as the cursor.

```csharp title="C#"
public Cursor EraseColumn(int glyph = 0)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to set on the erased cells. Defaults to glyph index 0.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when a host isn't attached to the cursor.


### EraseRow(int)

Clears the cells in the same row as the cursor.

```csharp title="C#"
public Cursor EraseRow(int glyph = 0)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to set on the erased cells. Defaults to glyph index 0.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when a host isn't attached to the cursor.


### EraseUp(int)

Clears the cells above the cursor.

```csharp title="C#"
public Cursor EraseUp(int glyph = 0)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to set on the erased cells. Defaults to glyph index 0.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when a host isn't attached to the cursor.


### EraseDown(int)

Clears the cells below the cursor.

```csharp title="C#"
public Cursor EraseDown(int glyph = 0)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to set on the erased cells. Defaults to glyph index 0.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when a host isn't attached to the cursor.


### EraseLeft(int)

Clears the cells to the left of the cursor.

```csharp title="C#"
public Cursor EraseLeft(int glyph = 0)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to set on the erased cells. Defaults to glyph index 0.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when a host isn't attached to the cursor.


### EraseRight(int)

Clears the cells to the right of the cursor.

```csharp title="C#"
public Cursor EraseRight(int glyph = 0)
```

#### Parameters

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The glyph to set on the erased cells. Defaults to glyph index 0.

#### Returns

[Cursor](../sadconsole.components.cursor/)  
The cursor object.
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
Thrown when a host isn't attached to the cursor.


### Dispose(bool)

```csharp title="C#"
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### ~Cursor()

```csharp title="C#"
protected ~Cursor()
```


### Dispose()

```csharp title="C#"
public void Dispose()
```


## Events

### KeyboardPreview

Raised when the keyboard is processing keys. Each key is sent to this event and can be cancelled

```csharp title="C#"
public event EventHandler<KeyboardHandledKeyEventArgs>? KeyboardPreview
```

#### Event Type

[EventHandler\<KeyboardHandledKeyEventArgs\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)