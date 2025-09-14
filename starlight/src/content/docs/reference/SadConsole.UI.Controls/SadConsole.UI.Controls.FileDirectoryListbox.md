---
title: FileDirectoryListbox Class
slug: reference/sadconsole.ui.controls.filedirectorylistbox
sidebar:
  label: FileDirectoryListbox
---
## Definition

A listbox control that displays the file system.

```csharp title="C#"
public class FileDirectoryListbox : ListBox, IContainer, IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/) → [CompositeControl](../sadconsole.ui.controls.compositecontrol/) → [ListBox](../sadconsole.ui.controls.listbox/)

Implements [IContainer](../sadconsole.ui.controls.icontainer/), [IList\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ControlBase\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### FileDirectoryListbox(int, int)

Creates a new instance of the control and uses [FileDirectoryListboxItem](../sadconsole.ui.controls.filedirectorylistboxitem/) as the item theme.

```csharp title="C#"
public FileDirectoryListbox(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the control.


### FileDirectoryListbox(int, int, ListBoxItemTheme)

Creates a new instance of the control with the specified item theme.

```csharp title="C#"
public FileDirectoryListbox(int width, int height, ListBoxItemTheme itemTheme)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the control.

`itemTheme` [ListBoxItemTheme](../sadconsole.ui.controls.listboxitemtheme/)  
The theme to use for the items.


## Properties

### CurrentFolder

The current folder displayed by the listbox.

```csharp title="C#"
public string? CurrentFolder { get; set; }
```

### FileFilter

A *.* wildcard filesystem filter. Use <pre>`;`</pre> to split multiple filters.

```csharp title="C#"
public string FileFilter { get; set; }
```

### OnlyRootAndSubDirs

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, only allows navigation from the root folder of the original value provided to [CurrentFolder](../sadconsole.ui.controls.filedirectorylistbox/#currentfolder/) and below; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool OnlyRootAndSubDirs { get; set; }
```

### HideNonFilterFiles

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, only displays files that match [FileFilter](../sadconsole.ui.controls.filedirectorylistbox/#filefilter/); otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> to display all files.

```csharp title="C#"
public bool HideNonFilterFiles { get; set; }
```

### HighlightedExtentions

A list of extensions of files to highlight, separated by a semicolon. The extension is just the name without any wildcards or periods, in lowercase. Example: `txt;json;xml`.

```csharp title="C#"
public string? HighlightedExtentions { get; set; }
```

## Methods

### OnItemAction()

Navigates a directory if a directory is selected. Raises the [SelectedItemExecuted](../sadconsole.ui.controls.listbox/#selecteditemexecuted/) event.

```csharp title="C#"
protected override void OnItemAction()
```