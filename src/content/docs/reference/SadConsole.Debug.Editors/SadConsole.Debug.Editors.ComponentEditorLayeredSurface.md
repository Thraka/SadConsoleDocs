---
title: ComponentEditorLayeredSurface Class
slug: reference/sadconsole.debug.editors.componenteditorlayeredsurface
sidebar:
  label: ComponentEditorLayeredSurface
editUrl: false
---
## Definition

```csharp title="C#"
public class ComponentEditorLayeredSurface : ISadComponentPanel
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [ISadComponentPanel](../sadconsole.debug.editors.isadcomponentpanel/)

## Constructors

### ComponentEditorLayeredSurface()

```csharp title="C#"
public ComponentEditorLayeredSurface()
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