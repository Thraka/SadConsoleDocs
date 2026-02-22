---
title: Overlay Class
slug: reference/sadconsole.components.overlay
sidebar:
  label: Overlay
editUrl: false
description: A surface that's rendered on top of a host surface.
---
## Definition

A surface that's rendered on top of a host surface.

```csharp title="C#"
public sealed class Overlay : UpdateComponent, IComponent, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### Overlay()

```csharp title="C#"
public Overlay()
```


## Fields

### RenderStep

Internal use.

```csharp title="C#"
public IRenderStep? RenderStep
```
#### Remarks

The render step used to draw the overlay. This render step is added to the host object and should draw the [Surface](../sadconsole.components.overlay/#surface) of the Overlay component.

## Properties

### Surface

A surface that's sized to match.

```csharp title="C#"
public ScreenSurface? Surface { get; }
```

### ClearOnAdd

When true, clears the [Surface](../sadconsole.components.overlay/#surface) property when this object is added to a [IScreenSurface](../sadconsole.iscreensurface/).

```csharp title="C#"
public bool ClearOnAdd { get; set; }
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


### OnRemoved(IScreenObject)

Called when the component is removed from the host.

```csharp title="C#"
public override void OnRemoved(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that removed the component.


### Update(IScreenObject, TimeSpan)

Called by a host on the update frame.

```csharp title="C#"
public override void Update(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.


### Dispose(bool)

```csharp title="C#"
protected void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### ~Overlay()

```csharp title="C#"
protected ~Overlay()
```


### Dispose()

```csharp title="C#"
public void Dispose()
```