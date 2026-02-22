---
title: DebugExtensionsImGui Class
slug: reference/sadconsole.configuration.debugextensionsimgui
sidebar:
  label: DebugExtensionsImGui
editUrl: false
description: Extensions to enable the ImGui debug UI.
---
## Definition

Extensions to enable the ImGui debug UI.

```csharp title="C#"
public static class DebugExtensionsImGui
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### EnableImGuiDebugger(Builder, Keys, Action\<bool>, Action)

Adds a [RootComponents](../sadconsole.gamehost/#rootcomponents) component that uses the specified hotkey to invoke [Start()](../sadconsole.debug.debugger/#start).

```csharp title="C#"
public static Builder EnableImGuiDebugger(this Builder builder, Keys hotkey, Action<bool> openedEventHandler = null, Action closedEventHandler = null)
```

#### Parameters

`builder` [Builder](../sadconsole.configuration.builder/)  
The config builder.

`hotkey` [Keys](../sadconsole.input.keys/)  
The keyboard key to start the debugger.

`openedEventHandler` [Action\<bool\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
An event handler that's raised when the debugger opens.

`closedEventHandler` [Action](https://learn.microsoft.com/dotnet/api/system.action/)  
An event handler that's raised when the debugger closes.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The config builder.