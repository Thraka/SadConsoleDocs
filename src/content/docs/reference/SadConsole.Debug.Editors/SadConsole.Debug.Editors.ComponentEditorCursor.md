---
title: ComponentEditorCursor Class
slug: reference/sadconsole.debug.editors.componenteditorcursor
sidebar:
  label: ComponentEditorCursor
---
## Definition

```csharp title="C#"
public class ComponentEditorCursor : ISadComponentPanel
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [ISadComponentPanel](../sadconsole.debug.editors.isadcomponentpanel/)

## Constructors

### ComponentEditorCursor()

```csharp title="C#"
public ComponentEditorCursor()
```


## Methods

### BuildUI(ImGuiRenderer, ScreenObjectState, IComponent)

```csharp title="C#"
public void BuildUI(ImGuiRenderer renderer, ScreenObjectState state, IComponent component)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`state` [ScreenObjectState](../sadconsole.debug.screenobjectstate/)  

`component` [IComponent](../sadconsole.components.icomponent/)