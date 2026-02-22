---
title: ImGuiObjectBase Class
slug: reference/sadconsole.imguisystem.imguiobjectbase
sidebar:
  label: ImGuiObjectBase
editUrl: false
description: Represents an object drawn in ImGui.
---
## Definition

Represents an object drawn in ImGui.

```csharp title="C#"
public abstract class ImGuiObjectBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ImGuiObjectBase()

```csharp title="C#"
protected ImGuiObjectBase()
```


## Properties

### IsVisible

When true, this object should be drawn.

```csharp title="C#"
public bool IsVisible { get; set; }
```

## Methods

### BuildUI(ImGuiRenderer)

Draws this object.

```csharp title="C#"
public abstract void BuildUI(ImGuiRenderer renderer)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  
The ImGui renderer drawing this object.