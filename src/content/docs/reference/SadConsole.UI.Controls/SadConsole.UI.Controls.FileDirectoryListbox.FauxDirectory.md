---
title: FileDirectoryListbox.FauxDirectory Class
slug: reference/sadconsole.ui.controls.filedirectorylistbox.fauxdirectory
sidebar:
  label: FileDirectoryListbox.FauxDirectory
editUrl: false
description: A listbox item container that represents a fake directory, such as `..`.
---
## Definition

A listbox item container that represents a fake directory, such as `..`.

```csharp title="C#"
public class FileDirectoryListbox.FauxDirectory
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### FauxDirectory(string)

Creates a new instance of the class.

```csharp title="C#"
public FauxDirectory(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to display.


## Properties

### Name

The name of the directory.

```csharp title="C#"
public string Name { get; }
```