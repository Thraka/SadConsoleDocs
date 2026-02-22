---
title: ConfigurationImGui Class
slug: reference/sadconsole.configuration.configurationimgui
sidebar:
  label: ConfigurationImGui
editUrl: false
description: Extensions to enable ImGui with SadConsole.
---
## Definition

Extensions to enable ImGui with SadConsole.

```csharp title="C#"
public static class ConfigurationImGui
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### EnableImGui(Builder, string, float, bool, Action\<ImGuiMonoGameComponent>)

Adds the ImGui MonoGame component to MonoGame.

```csharp title="C#"
public static Builder EnableImGui(this Builder builder, string fontFile = "Roboto-Regular.ttf", float fontSize = 16, bool enableDocking = false, Action<ImGuiMonoGameComponent> startupAction = null)
```

#### Parameters

`builder` [Builder](../sadconsole.configuration.builder/)  
The config builder.

`fontFile` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The font file to use with ImGui. Defaults to 'Roboto-Regular.ttf'.

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single/)  
The font size to use with ImGui. Defaults to 16.

`enableDocking` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
Enables the docking feature of ImGui. Defaults to false.

`startupAction` [Action\<ImGuiMonoGameComponent\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
A callback to add objects to the ImGui MonoGame component.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The config builder.