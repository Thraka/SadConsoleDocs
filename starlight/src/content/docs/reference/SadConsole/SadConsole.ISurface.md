---
title: ISurface Interface
slug: reference/sadconsole.isurface
sidebar:
  label: ISurface
---
## Definition

An interface that provides a Surface property that allows the editor extensions to work.

```csharp title="C#"
public interface ISurface
```


## Properties

### Surface

The surface.

```csharp title="C#"
ICellSurface Surface { get; }
```