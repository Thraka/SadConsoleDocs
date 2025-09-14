---
title: PCBoot Class
slug: reference/sadconsole.splashscreens.pcboot
sidebar:
  label: PCBoot
---
## Definition

A spashscreen that simulates an old computer boot up process.

```csharp title="C#"
public class PCBoot : ScreenSurface, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### PCBoot()

Creates a new instance of this spashscreen.

```csharp title="C#"
public PCBoot()
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