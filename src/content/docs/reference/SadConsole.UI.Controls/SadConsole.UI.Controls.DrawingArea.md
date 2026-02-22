---
title: DrawingArea Class
slug: reference/sadconsole.ui.controls.drawingarea
sidebar:
  label: DrawingArea
editUrl: false
description: A simple surface for drawing text that can be moved and sized like a control.
---
## Definition

A simple surface for drawing text that can be moved and sized like a control.

```csharp title="C#"
[DataContract]
public class DrawingArea : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### DrawingArea(int, int)

Creates a new drawing surface control with the specified width and height.

```csharp title="C#"
public DrawingArea(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control.


## Properties

### UseNormalStateOnly

When true, only uses [Normal](../sadconsole.ui.themestates/#normal) for drawing.

```csharp title="C#"
[DataMember]
public bool UseNormalStateOnly { get; set; }
```

### Appearance

The current appearance based on the control state.

```csharp title="C#"
public ColoredGlyphBase? Appearance { get; protected set; }
```

### OnDraw

Called when the surface is redrawn.

```csharp title="C#"
public Action<DrawingArea, TimeSpan>? OnDraw { get; set; }
```

## Methods

### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.