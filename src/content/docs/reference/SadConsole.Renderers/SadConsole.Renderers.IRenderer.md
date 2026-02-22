---
title: IRenderer Interface
slug: reference/sadconsole.renderers.irenderer
sidebar:
  label: IRenderer
editUrl: false
description: Draws a surface.
---
## Definition

Draws a surface.

```csharp title="C#"
public interface IRenderer : IDisposable
```


## Properties

### Name

The name used to create the renderer from the host.

```csharp title="C#"
string Name { get; set; }
```

### Output

The output texture created by the renderer.

```csharp title="C#"
ITexture Output { get; }
```

### Opacity

A 0 to 255 value represening how transparent the surface is when drawn to the screen. 255 represents full visibility.

```csharp title="C#"
byte Opacity { get; set; }
```

### IsForced

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the renderer is being forced to be redrawn this frame; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool IsForced { get; set; }
```

### Steps

The render steps for the renderer.

```csharp title="C#"
List<IRenderStep> Steps { get; set; }
```

## Methods

### Refresh(IScreenSurface, bool)

Refreshes a cached drawing state.

```csharp title="C#"
void Refresh(IScreenSurface surface, bool force = false)
```

#### Parameters

`surface` [IScreenSurface](../sadconsole.iscreensurface/)  
Target surface.

`force` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates the refresh should happen even if a surface isn't dirty.


### Render(IScreenSurface)

Creates a drawcall in the drawing pipeline.

```csharp title="C#"
void Render(IScreenSurface surface)
```

#### Parameters

`surface` [IScreenSurface](../sadconsole.iscreensurface/)  
Target surface.


### OnHostUpdated(IScreenObject)

Called when various states in the host change.

```csharp title="C#"
void OnHostUpdated(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that uses this component.