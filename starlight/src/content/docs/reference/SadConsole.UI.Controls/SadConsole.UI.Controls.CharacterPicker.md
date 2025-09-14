---
title: CharacterPicker Class
slug: reference/sadconsole.ui.controls.characterpicker
sidebar:
  label: CharacterPicker
---
## Definition

Displays the glyphs associated with a font and allows the user to select one.

```csharp title="C#"
public class CharacterPicker : SurfaceViewer, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [CompositeControl](../sadconsole.ui.controls.compositecontrol/) → [SurfaceViewer](../sadconsole.ui.controls.surfaceviewer/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### CharacterPicker(Color, Color, Color, IFont, int, int, int)

Creates a new character picker control.

```csharp title="C#"
public CharacterPicker(Color foreground, Color fill, Color selectedCharacterColor, IFont characterFont, int visibleColumns, int visibleRows, int fontColumns)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color of all the glyphs.

`fill` SadRogue.Primitives.Color  
Background color of all the glyphs.

`selectedCharacterColor` SadRogue.Primitives.Color  
The foreground color displayed on the selected glyph.

`characterFont` [IFont](../sadconsole.ifont/)  
The font used to display the glyphs.

`visibleColumns` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of columns to show. The control will be this wide plus 1.

`visibleRows` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of rows to show. The control will be this high plus 1.

`fontColumns` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
How many columns are defined in the font file.


### CharacterPicker(Color, Color, Color, SadFont, int, int)

Creates a new picker control with the specified font.

```csharp title="C#"
public CharacterPicker(Color foreground, Color fill, Color selectedCharacterColor, SadFont characterFont, int visibleColumns, int visibleRows)
```

#### Parameters

`foreground` SadRogue.Primitives.Color  
Foreground color of all the glyphs.

`fill` SadRogue.Primitives.Color  
Background color of all the glyphs.

`selectedCharacterColor` SadRogue.Primitives.Color  
The foreground color displayed on the selected glyph.

`characterFont` [SadFont](../sadconsole.sadfont/)  
The font used to display the glyphs.

`visibleColumns` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of columns to show. The control will be this wide plus 1.

`visibleRows` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The number of rows to show. The control will be this high plus 1.


## Properties

### UseFullClick

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates that the control should use a mouse click to select a new character; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> to indicate that just having the mouse down will select a new character.

```csharp title="C#"
public bool UseFullClick { get; set; }
```

### OldCharacterLocation

Gets the position of the previously selected character. Used by the theme.

```csharp title="C#"
public Point OldCharacterLocation { get; }
```

### NewCharacterLocation

Gets the position of the newly selected character. Used by the theme.

```csharp title="C#"
public Point NewCharacterLocation { get; }
```

### MirrorSetting

Gets or sets the mirror effect to apply in the theme.

```csharp title="C#"
public Mirror MirrorSetting { get; set; }
```

### HighlightSelectedCharacter

When true, highlights the selected character with [SelectedGlyphForeground](../sadconsole.ui.controls.characterpicker/#selectedglyphforeground/) when [HighlightSelectedCharacterWithEffect](../sadconsole.ui.controls.characterpicker/#highlightselectedcharacterwitheffect/) is false;

```csharp title="C#"
public bool HighlightSelectedCharacter { get; set; }
```

### HighlightSelectedCharacterWithEffect

When true, uses [SelectedGlyphEffect](../sadconsole.ui.controls.characterpicker/#selectedglypheffect/) to highlight the character.

```csharp title="C#"
public bool HighlightSelectedCharacterWithEffect { get; set; }
```

### GlyphForeground

Gets the foreground color used when drawing the glyphs.

```csharp title="C#"
public Color GlyphForeground { get; }
```

### GlyphBackground

Gets the background color used when drawing the glyphs.

```csharp title="C#"
public Color GlyphBackground { get; }
```

### SelectedGlyphForeground

Gets the foreground color used when drawing the selected glyph.

```csharp title="C#"
public Color SelectedGlyphForeground { get; }
```

### SelectedGlyphEffect

Gets the effect to apply when drawing the selected glyph.

```csharp title="C#"
public ICellEffect? SelectedGlyphEffect { get; set; }
```

### SelectedCharacter

Gets or sets the selected glyph character.

```csharp title="C#"
public int SelectedCharacter { get; set; }
```

## Methods

### OnMouseIn(ControlMouseState)

Called as the mouse moves around the control area. Raises the MouseMove event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnMouseIn(ControlBase.ControlMouseState info)
```

#### Parameters

`info` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  


### OnLeftMouseClicked(ControlMouseState)

Called when the left mouse button is clicked. Raises the MouseButtonClicked event and calls the [DetermineState()](../sadconsole.ui.controls.controlbase/#determinestate/) method.

```csharp title="C#"
protected override void OnLeftMouseClicked(ControlBase.ControlMouseState info)
```

#### Parameters

`info` [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase/)  


### ProcessMouse(MouseScreenObjectState)

Processes the mouse on each control hosted by this control.

```csharp title="C#"
public override bool ProcessMouse(MouseScreenObjectState state)
```

#### Parameters

`state` [MouseScreenObjectState](../sadconsole.input.mousescreenobjectstate/)  
The mouse state based on the parent screen object.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when a control processes the mouse; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### CreateControlSurface()

Generates the surface to be used by this control. This method is called internally to assign the [Surface](../sadconsole.ui.controls.controlbase/#surface/) property a value.

```csharp title="C#"
protected override ICellSurface CreateControlSurface()
```

#### Returns

[ICellSurface](../sadconsole.icellsurface/)  
A surface that should be assigned to the [Surface](../sadconsole.ui.controls.controlbase/#surface/) property.

### UpdateAndRedraw(TimeSpan)

Updates each control hosted by this control.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The game frame time delta.


## Events

### SelectedCharacterChanged

Raised when the [SelectedCharacter](../sadconsole.ui.controls.characterpicker/#selectedcharacter/) property changes.

```csharp title="C#"
public event EventHandler<ValueChangedEventArgs<int>>? SelectedCharacterChanged
```

#### Event Type

[EventHandler\<ValueChangedEventArgs\<int\>\>](https://learn.microsoft.com/dotnet/api/system.eventhandler-1/)