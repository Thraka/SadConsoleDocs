---
title: IRenderStepTexture Interface
slug: reference/sadconsole.renderers.irendersteptexture
sidebar:
  label: IRenderStepTexture
---
## Definition

Indicates the render step has an associated texture.

```csharp title="C#"
public interface IRenderStepTexture
```


## Properties

### CachedTexture

The texture created by the render step.

```csharp title="C#"
ITexture? CachedTexture { get; }
```