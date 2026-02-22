---
title: FileListBox Class
slug: reference/hexa.net.imgui.sc.filelistbox
sidebar:
  label: FileListBox
editUrl: false
---
## Definition

```csharp title="C#"
public class FileListBox
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### FileListBox(string)

```csharp title="C#"
public FileListBox(string rootFolder)
```

#### Parameters

`rootFolder` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### FileListBox(string, string)

```csharp title="C#"
public FileListBox(string rootFolder, string currentFolder)
```

#### Parameters

`rootFolder` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`currentFolder` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


## Properties

### AllowNavigation

```csharp title="C#"
public bool AllowNavigation { get; set; }
```

### ShowDirectories

```csharp title="C#"
public bool ShowDirectories { get; set; }
```

### ShowFiles

```csharp title="C#"
public bool ShowFiles { get; set; }
```

### DoubleClickToSelect

```csharp title="C#"
public bool DoubleClickToSelect { get; set; }
```

### DirectoryColor

```csharp title="C#"
public Color DirectoryColor { get; set; }
```

### FileColor

```csharp title="C#"
public Color FileColor { get; set; }
```

### SearchPattern

```csharp title="C#"
public string SearchPattern { get; set; }
```

### ColoredExtensions

```csharp title="C#"
public Dictionary<string, Color> ColoredExtensions { get; set; }
```

### UseEvents

```csharp title="C#"
public bool UseEvents { get; set; }
```

### SelectedItem

```csharp title="C#"
public FileSystemInfo? SelectedItem { get; set; }
```

### IsSelectedItemDirectory

```csharp title="C#"
public bool IsSelectedItemDirectory { get; }
```

### HighlightedItem

```csharp title="C#"
public FileSystemInfo? HighlightedItem { get; set; }
```

### IsHighlightedItemDirectory

```csharp title="C#"
public bool IsHighlightedItemDirectory { get; }
```

### CurrentDirectory

```csharp title="C#"
public DirectoryInfo CurrentDirectory { get; }
```

## Methods

### Draw()

Draws the list box.

```csharp title="C#"
public void Draw()
```


### Begin(string)

```csharp title="C#"
public void Begin(string id)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### Begin(string, Vector2, ImGuiChildFlags, ImGuiWindowFlags)

```csharp title="C#"
public void Begin(string id, Vector2 size, ImGuiChildFlags childFlags = ImGuiChildFlags.None, ImGuiWindowFlags windowFlags = ImGuiWindowFlags.None)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`childFlags` Hexa.NET.ImGui.ImGuiChildFlags  

`windowFlags` Hexa.NET.ImGui.ImGuiWindowFlags  


### End()

```csharp title="C#"
public void End()
```


### Draw(out bool, out bool)

Draws the list box.

```csharp title="C#"
public bool Draw(out bool itemSelected, out bool itemHighlighted)
```

#### Parameters

`itemSelected` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`itemHighlighted` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when an item is single-clicked and [DoubleClickToSelect](../hexa.net.imgui.sc.filelistbox/#doubleclicktoselect) is true.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when an item is selected or highlighted.

## Events

### ItemHighlighted

```csharp title="C#"
public event EventHandler? ItemHighlighted
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### ItemSelected

```csharp title="C#"
public event EventHandler? ItemSelected
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)
### ChangeDirectory

```csharp title="C#"
public event EventHandler? ChangeDirectory
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)