---
title: IRenderStep Interface
slug: reference/sadconsole.renderers.irenderstep
sidebar:
  label: IRenderStep
---
## Definition

A rendering step processed by an [IRenderer](../sadconsole.renderers.irenderer/).

```csharp title="C#"
public interface IRenderStep : IDisposable
```


## Properties

### Name

The name of the render step.

```csharp title="C#"
string Name { get; }
```

### SortOrder

Indicates priority related to other steps. Lowest runs first.

```csharp title="C#"
uint SortOrder { get; set; }
```

## Methods

### SetData(object)

Adds supplemental data to the render step.

```csharp title="C#"
void SetData(object data)
```

#### Parameters

`data` [object](https://learn.microsoft.com/dotnet/api/system.object/)  
The data to add to the step.


### Reset()

Called when the step should reset any state or texture information.

```csharp title="C#"
void Reset()
```


### Refresh(IRenderer, IScreenSurface, bool, bool)

Called to redraw the render step if needed.

```csharp title="C#"
bool Refresh(IRenderer renderer, IScreenSurface screenObject, bool backingTextureChanged, bool isForced)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  
The renderer the render step is using.

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface associated with the renderer. This may be null.

`backingTextureChanged` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> to indicate the <xref href="SadConsole.Renderers.IRenderer.Output" data-throw-if-not-resolved="false"></xref> changed; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

`isForced` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when refresh is being forced; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the step is going to draw something new and is requesting a `SadConsole.Renderers.IRenderStep.Composing(SadConsole.Renderers.IRenderer%2cSadConsole.IScreenSurface)` step; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### Composing(IRenderer, IScreenSurface)

Called when the renderer needs to redraw the [Output](../sadconsole.renderers.irenderer/#output/) texture.

```csharp title="C#"
void Composing(IRenderer renderer, IScreenSurface screenObject)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  
The renderer the render step is using.

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface associated with the renderer. This may be null.


### Render(IRenderer, IScreenSurface)

Called when building draw calls for the render pipeline.

```csharp title="C#"
void Render(IRenderer renderer, IScreenSurface screenObject)
```

#### Parameters

`renderer` [IRenderer](../sadconsole.renderers.irenderer/)  
The renderer the render step is using.

`screenObject` [IScreenSurface](../sadconsole.iscreensurface/)  
The surface associated with the renderer. This may be null.


### OnHostUpdated(IScreenObject)

Called when various states in the host change.

```csharp title="C#"
void OnHostUpdated(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that uses this component.