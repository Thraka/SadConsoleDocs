---
title: ProgressBar Class
slug: reference/sadconsole.ui.controls.progressbar
sidebar:
  label: ProgressBar
---
## Definition

A control that fills an area (vertical or horizontal) according to a value.

```csharp title="C#"
[DataContract]
public class ProgressBar : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### ProgressBar(int, int, HorizontalAlignment)

Creates a new horizontal progress bar.

```csharp title="C#"
public ProgressBar(int width, int height, HorizontalAlignment horizontalAlignment)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control.

`horizontalAlignment` [HorizontalAlignment](../sadconsole.horizontalalignment/)  
Sets the control to be horizontal, starting from the specified side. Center/Stretch is invalid.

#### Exceptions

[InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception/)  
Thrown when `horizontalAlignment` is set to either [Center](../sadconsole.horizontalalignment/#center/) or [Stretch](../sadconsole.horizontalalignment/#stretch/).


### ProgressBar(int, int, VerticalAlignment)

Creates a new vertical progress bar.

```csharp title="C#"
public ProgressBar(int width, int height, VerticalAlignment verticalAlignment)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Width of the control.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Height of the control.

`verticalAlignment` [VerticalAlignment](../sadconsole.verticalalignment/)  
Sets the control to be vertical, starting from the specified side. Center/Stretch is invalid.

#### Exceptions

[InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception/)  
Thrown when `verticalAlignment` is set to either [Center](../sadconsole.verticalalignment/#center/) or [Stretch](../sadconsole.verticalalignment/#stretch/).


## Fields

### progressValue

The progress bar fill value. Between 0f and 1f.

```csharp title="C#"
[DataMember]
protected float progressValue
```

### controlSize

The size of the bar.

```csharp title="C#"
[DataMember]
protected int controlSize
```

### fillSize

For theme use only. The size of the bar currently filled based on the [Progress](../sadconsole.ui.controls.progressbar/#progress/) property.

```csharp title="C#"
[DataMember]
public int fillSize
```

### isHorizontal

Flag to indicate this bar was created horizontal.

```csharp title="C#"
[DataMember]
protected bool isHorizontal
```

### horizontalAlignment

The alignment if the bar is horizontal.

```csharp title="C#"
[DataMember]
protected HorizontalAlignment horizontalAlignment
```

### verticalAlignment

The alignment if the bar is vertical.

```csharp title="C#"
[DataMember]
protected VerticalAlignment verticalAlignment
```

## Properties

### DisplayText

An optional text to display on the bar. If set to `"%"`, displays the percentage of the progress.

```csharp title="C#"
[DataMember]
public string DisplayText { get; set; }
```

### DisplayTextAlignment

Alignment to print the [DisplayText](../sadconsole.ui.controls.progressbar/#displaytext/). [Stretch](../sadconsole.horizontalalignment/#stretch/) is invalid for the property.

```csharp title="C#"
[DataMember]
public HorizontalAlignment DisplayTextAlignment { get; set; }
```

### HorizontalAlignment

The horizontal orientation used when [IsHorizontal](../sadconsole.ui.controls.progressbar/#ishorizontal/) is set to true.

```csharp title="C#"
public HorizontalAlignment HorizontalAlignment { get; set; }
```

### VerticalAlignment

The vertical orientation used when [IsHorizontal](../sadconsole.ui.controls.progressbar/#ishorizontal/) is set to false.

```csharp title="C#"
public VerticalAlignment VerticalAlignment { get; set; }
```

### IsHorizontal

When true, the progress bar uses the [HorizontalAlignment](../sadconsole.ui.controls.progressbar/#horizontalalignment/) property to determine the starting fill direction. When false, uses the [VerticalAlignment](../sadconsole.ui.controls.progressbar/#verticalalignment/) property.

```csharp title="C#"
public bool IsHorizontal { get; set; }
```

### Progress

Gets or sets the value of the scrollbar between 0.0 and 1.0.

```csharp title="C#"
public float Progress { get; set; }
```

### ThemeStateBar

The theme of the progressed part of the bar.

```csharp title="C#"
[DataMember]
public ThemeStates ThemeStateBar { get; protected set; }
```

### DisplayTextStates

The theme of the text displayed on the bar.

```csharp title="C#"
[DataMember]
public ThemeStates DisplayTextStates { get; protected set; }
```

### BackgroundGlyph

The glyph to use when drawing the unfilled part of the bar.

```csharp title="C#"
[DataMember]
public int BackgroundGlyph { get; set; }
```

### BarGlyph

The glyph to use when drawing the filled part of the bar.

```csharp title="C#"
[DataMember]
public int BarGlyph { get; set; }
```

### DisplayTextColor

The color to print the [DisplayText](../sadconsole.ui.controls.progressbar/#displaytext/) string.

```csharp title="C#"
[DataMember]
public Color? DisplayTextColor { get; set; }
```

### BarColor

The color to print the filled part of the progress bar.

```csharp title="C#"
[DataMember]
public Color? BarColor { get; set; }
```

### PrintDisplayAsDecorator

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, prints the [DisplayText](../sadconsole.ui.controls.label/#displaytext/) on the control in decorators instead of replacing the portation of the bar that overlaps the text.

```csharp title="C#"
[DataMember]
public bool PrintDisplayAsDecorator { get; set; }
```

## Methods

### ProcessKeyboard(Keyboard)

Called when the control should process keyboard information.

```csharp title="C#"
public override bool ProcessKeyboard(Keyboard info)
```

#### Parameters

`info` [Keyboard](../sadconsole.input.keyboard/)  
The keyboard information.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True if the keyboard was handled by this control.

### RefreshThemeStateColors(Colors)

Updates the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/) by calling [RefreshTheme(Colors)](../sadconsole.ui.themestates/#/) with the provided colors. Override this method to adjust how colors are used by the [ThemeState](../sadconsole.ui.controls.controlbase/#themestate/).

```csharp title="C#"
protected override void RefreshThemeStateColors(Colors colors)
```

#### Parameters

`colors` [Colors](../sadconsole.ui.colors/)  
The colors to apply to the theme state.


### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.


## Events

### ProgressChanged

Called when the [Progress](../sadconsole.ui.controls.progressbar/#progress/) property value changes.

```csharp title="C#"
public event EventHandler? ProgressChanged
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)