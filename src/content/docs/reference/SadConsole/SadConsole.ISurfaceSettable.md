---
title: ISurfaceSettable Interface
slug: reference/sadconsole.isurfacesettable
sidebar:
  label: ISurfaceSettable
editUrl: false
description: An interface that provides a Surface property which can be set.
---
## Definition

An interface that provides a Surface property which can be set.

```csharp title="C#"
public interface ISurfaceSettable
```


## Properties

### Surface

Sets the surface.

```csharp title="C#"
ICellSurface Surface { get; set; }
```