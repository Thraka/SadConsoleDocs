---
title: IScreenSurfaceEditable Interface
slug: reference/sadconsole.iscreensurfaceeditable
sidebar:
  label: IScreenSurfaceEditable
---
## Definition

The same as a [IScreenSurface](../sadconsole.iscreensurface/) interface, except that it also implements [ISurface](../sadconsole.isurface/) for convenience.

```csharp title="C#"
public interface IScreenSurfaceEditable : IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface
```