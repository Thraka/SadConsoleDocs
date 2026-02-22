---
title: ImGuiImplementation Class
slug: reference/sadconsole.imguisystem.imguiimplementation
sidebar:
  label: ImGuiImplementation
editUrl: false
description: A basic ImGui interface that adds the `SadConsole.ImGuiSystem.ImGuiMonoGameComponent` to MonoGame, rendering ImGui over SadConsole.
---
## Definition

A basic ImGui interface that adds the [ImGuiMonoGameComponent](../sadconsole.imguisystem.imguimonogamecomponent/) to MonoGame, rendering ImGui over SadConsole.

```csharp title="C#"
public static class ImGuiImplementation
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### Renderer

Gets the renderer for ImGui.

```csharp title="C#"
public static ImGuiRenderer Renderer { get; }
```

### MonoGameComponent

Gets the MonoGame component that is rendering ImGui.

```csharp title="C#"
public static ImGuiMonoGameComponent MonoGameComponent { get; }
```

### UIObjects

Gets the list of UI objects that is drawn by ImGui.

```csharp title="C#"
public static List<ImGuiObjectBase> UIObjects { get; }
```

## Methods

### Start(bool, bool, bool, float, string)

Starts the ImGui system.

```csharp title="C#"
public static void Start(bool disableFinalDraw = true, bool disableUpdate = false, bool disableInput = true, float fontSize = 18, string fontFileTTF = "Roboto-Regular.ttf")
```

#### Parameters

`disableFinalDraw` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Turns off ``SadConsole.Settings.DoFinalDraw``, which causes SadConsole to only render ImGui to the screen.

`disableUpdate` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Turns off ``SadConsole.Settings.DoUpdate``, which pauses SadConsole's update loop.

`disableInput` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Turns off ``SadConsole.Settings.Input.DoKeyboard`` and ``SadConsole.Settings.Input.DoMouse``, allowing only ImGui to handle input.

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single/)  
The font size to use with ImGui.

`fontFileTTF` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The TTF font file to use with ImGui.