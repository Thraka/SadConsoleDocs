---
title: FileDirectoryListboxItem Class
slug: reference/sadconsole.ui.controls.filedirectorylistboxitem
sidebar:
  label: FileDirectoryListboxItem
editUrl: false
description: Displays files and directories in various colors.
---
## Definition

Displays files and directories in various colors.

```csharp title="C#"
public class FileDirectoryListboxItem : ListBoxItemTheme
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ThemeStates](../sadconsole.ui.themestates/) → [ListBoxItemTheme](../sadconsole.ui.controls.listboxitemtheme/)

## Constructors

### FileDirectoryListboxItem()

```csharp title="C#"
public FileDirectoryListboxItem()
```


## Properties

### DirectoryAppNormal

The appearance of a directory in normal state.

```csharp title="C#"
public ColoredGlyphBase DirectoryAppNormal { get; set; }
```

### DirectoryAppMouseOver

The appearance of a directory when the mouse is over it.

```csharp title="C#"
public ColoredGlyphBase DirectoryAppMouseOver { get; set; }
```

### DirectoryAppSelected

The appearance of a directory when selected.

```csharp title="C#"
public ColoredGlyphBase DirectoryAppSelected { get; set; }
```

### DirectoryAppSelectedOver

The appearance of a directory when selected and the mouse is over it.

```csharp title="C#"
public ColoredGlyphBase DirectoryAppSelectedOver { get; set; }
```

### FileAppNormal

The appearance of a file in normal state.

```csharp title="C#"
public ColoredGlyphBase FileAppNormal { get; set; }
```

### FileAppMouseOver

The appearance of a file when the mouse is over it.

```csharp title="C#"
public ColoredGlyphBase FileAppMouseOver { get; set; }
```

### FileAppSelected

The appearance of a file when selected.

```csharp title="C#"
public ColoredGlyphBase FileAppSelected { get; set; }
```

### FileAppSelectedOver

The appearance of a file when selected and the mouse is over it.

```csharp title="C#"
public ColoredGlyphBase FileAppSelectedOver { get; set; }
```

### HighExtAppNormal

The appearance of a highlighted file in normal state.

```csharp title="C#"
public ColoredGlyphBase HighExtAppNormal { get; set; }
```

### HighExtAppMouseOver

The appearance of a highlighted file when the mouse is over it.

```csharp title="C#"
public ColoredGlyphBase HighExtAppMouseOver { get; set; }
```

### HighExtAppSelected

The appearance of a highlighted file when selected.

```csharp title="C#"
public ColoredGlyphBase HighExtAppSelected { get; set; }
```

### HighExtAppSelectedOver

The appearance of a highlighted file when selected and the mouse is over it.

```csharp title="C#"
public ColoredGlyphBase HighExtAppSelectedOver { get; set; }
```

## Methods

### RefreshTheme(Colors)

Reloads the theme values based on the colors provided.

```csharp title="C#"
public override void RefreshTheme(Colors themeColors)
```

#### Parameters

`themeColors` [Colors](../sadconsole.ui.colors/)  


### Draw(ControlBase, Rectangle, object, ControlStates)

Draws the `item` in the specified `area` of the listbox.

```csharp title="C#"
public override void Draw(ControlBase control, Rectangle area, object item, ControlStates itemState)
```

#### Parameters

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control containing a surface to draw on.

`area` SadRogue.Primitives.Rectangle  
The area to draw the item.

`item` [object](https://learn.microsoft.com/dotnet/api/system.object/)  
The item object.

`itemState` [ControlStates](../sadconsole.ui.controls.controlstates/)  
The state of the item.