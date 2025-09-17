---
title: ScrollBar.ThemeStyle Class
slug: reference/sadconsole.ui.controls.scrollbar.themestyle
sidebar:
  label: ScrollBar.ThemeStyle
---
## Definition

The drawing code for the scrollbar

```csharp title="C#"
[DataContract]
public class ScrollBar.ThemeStyle
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ThemeStyle()

```csharp title="C#"
public ThemeStyle()
```


## Fields

### StartButtonVerticalGlyph

The glyph for the start button when the control is vertical.

```csharp title="C#"
[DataMember]
public int StartButtonVerticalGlyph
```

### EndButtonVerticalGlyph

The glyph for the end button when the control is vertical.

```csharp title="C#"
[DataMember]
public int EndButtonVerticalGlyph
```

### StartButtonHorizontalGlyph

The glyph for the start button when the control is horizontal.

```csharp title="C#"
[DataMember]
public int StartButtonHorizontalGlyph
```

### EndButtonHorizontalGlyph

The glyph for the end button when the control is horizontal.

```csharp title="C#"
[DataMember]
public int EndButtonHorizontalGlyph
```

### BarGlyph

The glyph for the scroll bar bar where the slider is not located.

```csharp title="C#"
[DataMember]
public int BarGlyph
```

### GripGlyph

The glyph for the scroll bar icon.

```csharp title="C#"
[DataMember]
public int GripGlyph
```

### BarSize

The size of the bar area. Calculated automatically by the control.

```csharp title="C#"
public int BarSize
```

### GripSize

The size of the grip. Calculated automatically by the control.

```csharp title="C#"
public int GripSize
```

### GripStart

The cell the grip starts at. Calculated automatically by the control.

```csharp title="C#"
public int GripStart
```

### IsMouseOverUpButton

Indicates that the mouse is above the up arrow button. Calculated automatically by the control.

```csharp title="C#"
public bool IsMouseOverUpButton
```

### IsMouseOverDownButton

Indicates that the mouse is above the down arrow button. Calculated automatically by the control.

```csharp title="C#"
public bool IsMouseOverDownButton
```

### IsMouseOverGripper

Indicates that the mouse is above the gripper. Calculated automatically by the control.

```csharp title="C#"
public bool IsMouseOverGripper
```

### IsMouseOverBar

Indicates that the mouse is not above the empty part of the bar. Calculated automatically by the control.

```csharp title="C#"
public bool IsMouseOverBar
```

## Properties

### GripEnd

The cell the grip ends at. Calculated automatically by the control.

```csharp title="C#"
public int GripEnd { get; }
```

## Methods

### UpdateAndRedraw(ScrollBar, TimeSpan)

Redraws the control.

```csharp title="C#"
public virtual void UpdateAndRedraw(ScrollBar control, TimeSpan time)
```

#### Parameters

`control` [ScrollBar](../sadconsole.ui.controls.scrollbar/)  
The control instance.

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Time of the update frame.