---
title: Simple Class
slug: reference/sadconsole.splashscreens.simple
sidebar:
  label: Simple
editUrl: false
description: A simple splashscreen that fades in a screen specifying "Powered by SadConsole".
---
## Definition

A simple splashscreen that fades in a screen specifying "Powered by SadConsole".

```csharp title="C#"
public class Simple : ScreenSurface, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### Simple()

A new instance of this class.

```csharp title="C#"
public Simple()
```


## Methods

### ProcessKeyboard(Keyboard)

Ends the animation when a key is pressed.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard keyboard)
```

#### Parameters

`keyboard` [Keyboard](../sadconsole.input.keyboard/)  
The keyboard state.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
The base implementation of the keyboard.