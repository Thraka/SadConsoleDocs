---
title: GuiDockspace Class
slug: reference/sadconsole.debug.guidockspace
sidebar:
  label: GuiDockspace
editUrl: false
---
## Definition

```csharp title="C#"
public class GuiDockspace : ImGuiObjectBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)

## Constructors

### GuiDockspace()

```csharp title="C#"
public GuiDockspace()
```


## Fields

### ID_LEFT_PANEL

```csharp title="C#"
public const string ID_LEFT_PANEL = "Scene##LeftPanel"
```

### ID_CENTER_PANEL

```csharp title="C#"
public const string ID_CENTER_PANEL = "Previews##RightPanel"
```

### ID_RIGHT_PANEL

```csharp title="C#"
public const string ID_RIGHT_PANEL = "Extras##CenterPanel"
```

### NoTabBarDock

```csharp title="C#"
public static ImGuiWindowClass NoTabBarDock
```

### AutoHideTabBar

```csharp title="C#"
public static ImGuiWindowClass AutoHideTabBar
```

## Methods

### BuildUI(ImGuiRenderer)

Draws this object.

```csharp title="C#"
public override void BuildUI(ImGuiRenderer renderer)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  
The ImGui renderer drawing this object.