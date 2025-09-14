---
title: MessageWindow Class
slug: reference/hexa.net.imgui.sc.windows.messagewindow
sidebar:
  label: MessageWindow
---
## Definition

```csharp title="C#"
public class MessageWindow : ImGuiWindowBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/) → [ImGuiWindowBase](../sadconsole.imguisystem.imguiwindowbase/)

## Constructors

### MessageWindow(string, string)

```csharp title="C#"
public MessageWindow(string message, string title = "Message")
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


## Methods

### BuildUI(ImGuiRenderer)

Draws this object.

```csharp title="C#"
public override void BuildUI(ImGuiRenderer renderer)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  
The ImGui renderer drawing this object.


### Show(string, string)

```csharp title="C#"
public static void Show(string message, string title)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)