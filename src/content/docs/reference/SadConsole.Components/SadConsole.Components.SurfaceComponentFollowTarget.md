---
title: SurfaceComponentFollowTarget Class
slug: reference/sadconsole.components.surfacecomponentfollowtarget
sidebar:
  label: SurfaceComponentFollowTarget
editUrl: false
description: Add to a `SadConsole.IScreenSurface` to have the `SadConsole.ICellSurface.ViewPosition` center on a specific object.
---
## Definition

Add to a [IScreenSurface](../sadconsole.iscreensurface/) to have the [ViewPosition](../sadconsole.icellsurface/#viewposition) center on a specific object.

```csharp title="C#"
public class SurfaceComponentFollowTarget : UpdateComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### SurfaceComponentFollowTarget()

```csharp title="C#"
public SurfaceComponentFollowTarget()
```


## Properties

### Target

Target to have the surface follow.

```csharp title="C#"
public IScreenObject? Target { get; set; }
```

## Methods

### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added the component.


### Update(IScreenObject, TimeSpan)

Called by a host on the update frame.

```csharp title="C#"
public override void Update(IScreenObject hostObject, TimeSpan delta)
```

#### Parameters

`hostObject` [IScreenObject](../sadconsole.iscreenobject/)  

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.