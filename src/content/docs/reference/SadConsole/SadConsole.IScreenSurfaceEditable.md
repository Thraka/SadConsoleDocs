---
title: IScreenSurfaceEditable Interface
slug: reference/sadconsole.iscreensurfaceeditable
sidebar:
  label: IScreenSurfaceEditable
editUrl: false
description: The same as a `SadConsole.IScreenSurface` interface, except that it also implements `SadConsole.ISurface` for convenience.
---
## Definition

The same as a [IScreenSurface](../sadconsole.iscreensurface/) interface, except that it also implements [ISurface](../sadconsole.isurface/) for convenience.

```csharp title="C#"
public interface IScreenSurfaceEditable : IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface
```