---
title: SadConsole.UI.Controls
slug: reference/sadconsole.ui.controls
sidebar:
  order: 0
---
## Classes

| | |
| --- | --- |
| [Button](../sadconsole.ui.controls.button/) | Simple button control with a height of 1. |
| [Button3d](../sadconsole.ui.controls.button3d/) | A button control that is drawn with a shadow. |
| [ButtonBase](../sadconsole.ui.controls.buttonbase/) | Base class for creating a button type control. |
| [ButtonBox](../sadconsole.ui.controls.buttonbox/) | A button control that is drawn using lines around it. |
| [CharacterPicker](../sadconsole.ui.controls.characterpicker/) | Displays the glyphs associated with a font and allows the user to select one. |
| [CheckBox](../sadconsole.ui.controls.checkbox/) | Represents a button that can be toggled on/off within a group of other buttons. |
| [ColorBar](../sadconsole.ui.controls.colorbar/) | A color bar control. |
| [ColorPicker](../sadconsole.ui.controls.colorpicker/) | Displays a rectangle gradient area between `SadRogue.Primitives.Color.Black` and a target color, and `SadRogue.Primitives.Color.White` and a target color. |
| [ComboBox](../sadconsole.ui.controls.combobox/) | Represents a button that can be toggled on/off within a group of other buttons. |
| [CompositeControl](../sadconsole.ui.controls.compositecontrol/) | Base class for controls that host and render other controls. |
| [ControlBase](../sadconsole.ui.controls.controlbase/) | Base class for all controls. |
| [ControlBase.ControlMouseState](../sadconsole.ui.controls.controlbase.controlmousestate/) | Mouse state based on a specific control. |
| [DrawingArea](../sadconsole.ui.controls.drawingarea/) | A simple surface for drawing text that can be moved and sized like a control. |
| [FileDirectoryListbox](../sadconsole.ui.controls.filedirectorylistbox/) | A listbox control that displays the file system. |
| [FileDirectoryListbox.FauxDirectory](../sadconsole.ui.controls.filedirectorylistbox.fauxdirectory/) | A listbox item container that represents a fake directory, such as `..`. |
| [FileDirectoryListbox.HighlightedExtFile](../sadconsole.ui.controls.filedirectorylistbox.highlightedextfile/) | A listbox item container that represents a highlighted file. |
| [FileDirectoryListboxItem](../sadconsole.ui.controls.filedirectorylistboxitem/) | Displays files and directories in various colors. |
| [HueBar](../sadconsole.ui.controls.huebar/) | Displays the color hues on a bar. |
| [Label](../sadconsole.ui.controls.label/) | A simple surface for drawing text that can be moved and sized like a control. |
| [ListBox](../sadconsole.ui.controls.listbox/) | A scrollable list control. |
| [ListBox.SelectedItemEventArgs](../sadconsole.ui.controls.listbox.selecteditemeventargs/) | The event args used when the selected item changes. |
| [ListBoxItemColorTheme](../sadconsole.ui.controls.listboxitemcolortheme/) | A theme for a [ListBox](../sadconsole.ui.controls.listbox/) that displays a `SadRogue.Primitives.Color` object. |
| [ListBoxItemTheme](../sadconsole.ui.controls.listboxitemtheme/) | A generic theme for a [ListBox](../sadconsole.ui.controls.listbox/) item. |
| [NumberBox](../sadconsole.ui.controls.numberbox/) | InputBox control that allows text input. |
| [Panel](../sadconsole.ui.controls.panel/) | A control container that processes the mouse on each child. [TabStop](../sadconsole.ui.controls.controlbase/#tabstop/) defaults to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>. |
| [ProgressBar](../sadconsole.ui.controls.progressbar/) | A control that fills an area (vertical or horizontal) according to a value. |
| [RadioButton](../sadconsole.ui.controls.radiobutton/) | Represents a button that can be toggled on/off within a group of other buttons. |
| [ScrollBar](../sadconsole.ui.controls.scrollbar/) | Represents a scrollbar control. |
| [ScrollBar.ThemeStyle](../sadconsole.ui.controls.scrollbar.themestyle/) | The drawing code for the scrollbar |
| [SelectionButton](../sadconsole.ui.controls.selectionbutton/) | Provides a button-like control that changes focus to a designated previous or next selection button when the arrow keys are pushed. |
| [SurfaceViewer](../sadconsole.ui.controls.surfaceviewer/) | Draws a [ICellSurface](../sadconsole.icellsurface/) within an area. Optionally supports scroll bars. |
| [TabControl](../sadconsole.ui.controls.tabcontrol/) | A control with tabs along the edge of the control. Each tab sets the content of the control. |
| [TabItem](../sadconsole.ui.controls.tabitem/) | Contains the header and content of a tab for the [TabControl](../sadconsole.ui.controls.tabcontrol/). |
| [Table](../sadconsole.ui.controls.table/) | A scrollable table control. |
| [Table.Cell](../sadconsole.ui.controls.table.cell/) | A basic cell used in the Table control |
| [Table.Cell.Options](../sadconsole.ui.controls.table.cell.options/) | A collection of settings that are used by [Table.Cell](../sadconsole.ui.controls.table/) |
| [Table.CellChangedEventArgs](../sadconsole.ui.controls.table.cellchangedeventargs/) | Cell args for a table event |
| [Table.CellEventArgs](../sadconsole.ui.controls.table.celleventargs/) | Cell args for a table event |
| [Table.TableCells](../sadconsole.ui.controls.table.tablecells/) | A collection class that contains all the cells of the [Table](../sadconsole.ui.controls.table/) and methods to modify them. |
| [Table.TableCells.Layout](../sadconsole.ui.controls.table.tablecells.layout/) | Defines the layout for a row or a column defined in [Cells](../sadconsole.ui.controls.table/#cells/) |
| [Table.TableCells.Layout.RangeEnumerable](../sadconsole.ui.controls.table.tablecells.layout.rangeenumerable/) | An enumerable range that contains the layouts of all the rows and columns defined by the size of the range method within [Cells](../sadconsole.ui.controls.table/#cells/) |
| [TableExtensions](../sadconsole.ui.controls.tableextensions/) | Extensions used for the [Table](../sadconsole.ui.controls.table/) |
| [TextBox](../sadconsole.ui.controls.textbox/) | InputBox control that allows text input. |
| [ToggleButtonBase](../sadconsole.ui.controls.togglebuttonbase/) | Base class for toggle button controls, such as [CheckBox](../sadconsole.ui.controls.checkbox/) and [RadioButton](../sadconsole.ui.controls.radiobutton/). |
| [ToggleSwitch](../sadconsole.ui.controls.toggleswitch/) | Represents a button that can be toggled on/off within a group of other buttons. |
## Interfaces

| | |
| --- | --- |
| [IContainer](../sadconsole.ui.controls.icontainer/) | A simple container for controls. |
## Enums

| | |
| --- | --- |
| [ControlStates](../sadconsole.ui.controls.controlstates/) | Indicates the state of a control. |
| [SurfaceViewer.ScrollBarModes](../sadconsole.ui.controls.surfaceviewer.scrollbarmodes/) | Determines how the control draws the scroll bars. |
| [TabControl.Orientation](../sadconsole.ui.controls.tabcontrol.orientation/) | Horizontal alignment modes |
| [Table.Cell.Options.HorizontalAlign](../sadconsole.ui.controls.table.cell.options.horizontalalign/) | Alignment enum for the horizontal axis |
| [Table.Cell.Options.VerticalAlign](../sadconsole.ui.controls.table.cell.options.verticalalign/) | Alignment enum for the vertical axis |
| [Table.TableCells.Layout.Mode](../sadconsole.ui.controls.table.tablecells.layout.mode/) | Defines several visual modes |