---
title: PromptWindow Class
slug: reference/hexa.net.imgui.sc.windows.promptwindow
sidebar:
  label: PromptWindow
editUrl: false
---
## Definition

```csharp title="C#"
public class PromptWindow : ImGuiWindowBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/) → [ImGuiWindowBase](../sadconsole.imguisystem.imguiwindowbase/)

## Constructors

### PromptWindow(string, string, string, string)

```csharp title="C#"
public PromptWindow(string message, string title = "Message", string positiveText = "Yes", string negativeText = "No")
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`positiveText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`negativeText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


## Methods

### BuildUI(ImGuiRenderer)

Draws this object.

```csharp title="C#"
public override void BuildUI(ImGuiRenderer renderer)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  
The ImGui renderer drawing this object.