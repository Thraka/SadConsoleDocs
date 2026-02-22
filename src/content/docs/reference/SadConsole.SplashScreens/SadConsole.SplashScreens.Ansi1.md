---
title: Ansi1 Class
slug: reference/sadconsole.splashscreens.ansi1
sidebar:
  label: Ansi1
editUrl: false
description: A simple splashscreen that fades in a screen specifying "Powered by SadConsole".
---
## Definition

A simple splashscreen that fades in a screen specifying "Powered by SadConsole".

```csharp title="C#"
public class Ansi1 : ScreenSurface, IDisposable, IScreenSurfaceEditable, IScreenSurface, IScreenObject, IPositionable, IComponentHost, ISurface, ISurfaceSettable, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/) → [ScreenSurface](../sadconsole.screensurface/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/), [IScreenSurface](../sadconsole.iscreensurface/), [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/), [ISurface](../sadconsole.isurface/), [ISurfaceSettable](../sadconsole.isurfacesettable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### Ansi1(IFont, Sizes)

Creates the ansi splash screen using the specified font and size.

```csharp title="C#"
public Ansi1(IFont font, IFont.Sizes fontSize)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font to use.

`fontSize` [IFont.Sizes](../sadconsole.ifont/)  
The font size to use.


### Ansi1(Sizes)

Creates the ansi splash screen using the [EmbeddedFont](../sadconsole.gamehost/#embeddedfont) and the specified font size.

```csharp title="C#"
public Ansi1(IFont.Sizes fontSize)
```

#### Parameters

`fontSize` [IFont.Sizes](../sadconsole.ifont/)  
The size of font to use.


### Ansi1()

Creates the ansi splash screen using the [EmbeddedFont](../sadconsole.gamehost/#embeddedfont) and a font size of [One](../sadconsole.ifont.sizes/#one).

```csharp title="C#"
public Ansi1()
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