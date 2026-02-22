---
title: ComponentsPanel Class
slug: reference/sadconsole.debug.componentspanel
sidebar:
  label: ComponentsPanel
editUrl: false
---
## Definition

```csharp title="C#"
public class ComponentsPanel : ImGuiObjectBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)

## Constructors

### ComponentsPanel()

```csharp title="C#"
public ComponentsPanel()
```


## Fields

### CurrentScreenObject

```csharp title="C#"
public ScreenObjectState CurrentScreenObject
```

## Properties

### RegisteredPanels

```csharp title="C#"
public static Dictionary<Type, ISadComponentPanel> RegisteredPanels { get; }
```

## Methods

### BuildUI(ImGuiRenderer, ScreenObjectState)

```csharp title="C#"
public void BuildUI(ImGuiRenderer renderer, ScreenObjectState state)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`state` [ScreenObjectState](../sadconsole.debug.screenobjectstate/)  


### BuildUI(ImGuiRenderer)

Draws this object.

```csharp title="C#"
public override void BuildUI(ImGuiRenderer renderer)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  
The ImGui renderer drawing this object.