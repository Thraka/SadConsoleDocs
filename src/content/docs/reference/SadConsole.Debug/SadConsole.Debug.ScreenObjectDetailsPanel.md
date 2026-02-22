---
title: ScreenObjectDetailsPanel Class
slug: reference/sadconsole.debug.screenobjectdetailspanel
sidebar:
  label: ScreenObjectDetailsPanel
editUrl: false
---
## Definition

```csharp title="C#"
public class ScreenObjectDetailsPanel
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ScreenObjectDetailsPanel()

```csharp title="C#"
public ScreenObjectDetailsPanel()
```


## Fields

### CurrentScreenObject

```csharp title="C#"
public ScreenObjectState CurrentScreenObject
```

## Properties

### RegisteredPanels

```csharp title="C#"
public static Dictionary<Type, IScreenObjectPanel> RegisteredPanels { get; }
```

## Methods

### BuildUI(ImGuiRenderer, ScreenObjectState)

```csharp title="C#"
public void BuildUI(ImGuiRenderer renderer, ScreenObjectState state)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`state` [ScreenObjectState](../sadconsole.debug.screenobjectstate/)