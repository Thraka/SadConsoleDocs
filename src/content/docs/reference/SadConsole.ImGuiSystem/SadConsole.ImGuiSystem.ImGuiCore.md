---
title: ImGuiCore Class
slug: reference/sadconsole.imguisystem.imguicore
sidebar:
  label: ImGuiCore
editUrl: false
description: Shared objects that drive the ImGui integration for SadConsole.
---
## Definition

Shared objects that drive the ImGui integration for SadConsole.

```csharp title="C#"
public static class ImGuiCore
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### ImGuiComponent

MonoGame component for rendering ImGui.

```csharp title="C#"
public static ImGuiMonoGameComponent ImGuiComponent
```

## Properties

### GuiComponents

The ImGui objects to draw each game frame.

```csharp title="C#"
public static List<ImGuiObjectBase> GuiComponents { get; }
```

### Renderer

The ImGui renderer.

```csharp title="C#"
public static ImGuiRenderer Renderer { get; }
```