---
title: IWindowData Interface
slug: reference/sadconsole.renderers.iwindowdata
sidebar:
  label: IWindowData
editUrl: false
description: Provides the methods and properties used by the Window renderer.
---
## Definition

Provides the methods and properties used by the Window renderer.

```csharp title="C#"
public interface IWindowData
```


## Properties

### IsModal

The status of whether or not the window is being shown in modal mode.

```csharp title="C#"
bool IsModal { get; }
```

### Controls

Access to the controls used by the window.

```csharp title="C#"
ControlHost Controls { get; }
```