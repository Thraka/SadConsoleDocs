---
title: Label Class
slug: reference/sadconsole.ui.controls.label
sidebar:
  label: Label
editUrl: false
description: A simple surface for drawing text that can be moved and sized like a control.
---
## Definition

A simple surface for drawing text that can be moved and sized like a control.

```csharp title="C#"
[DataContract]
public class Label : ControlBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ControlBase](../sadconsole.ui.controls.controlbase/)

## Constructors

### Label(string)

A control to display simple one-line text.

```csharp title="C#"
public Label(string displayText)
```

#### Parameters

`displayText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The text to display. Sets the width based on the length.


### Label(int)

A control to display simple one-line text.

```csharp title="C#"
public Label(int length)
```

#### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The initial length of the label without any text.


## Properties

### ShowUnderline

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, shows an underline on the text.

```csharp title="C#"
public bool ShowUnderline { get; set; }
```

### ShowStrikethrough

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, shows a strikethrough on the text.

```csharp title="C#"
public bool ShowStrikethrough { get; set; }
```

### TextColor

Optional text color for the label. Otherwise the theme controls the color.

```csharp title="C#"
public Color? TextColor { get; set; }
```

### Alignment

Sets the horizontal alignment of the label. Defaults to [Left](../sadconsole.horizontalalignment/#left).

```csharp title="C#"
public HorizontalAlignment Alignment { get; set; }
```

### DisplayText

The text to display on the label. The label size is set in the constructor and cannot be changed.

```csharp title="C#"
public string DisplayText { get; set; }
```

### UseNormalStateOnly

When true, only uses [Normal](../sadconsole.ui.themestates/#normal) for drawing.

```csharp title="C#"
[DataMember]
public bool UseNormalStateOnly { get; set; }
```

### DecoratorUnderline

The decorator to use when the [ShowUnderline](../sadconsole.ui.controls.label/#showunderline) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
[DataMember]
public CellDecorator DecoratorUnderline { get; set; }
```

### DecoratorStrikethrough

The decorator to use when the [ShowStrikethrough](../sadconsole.ui.controls.label/#showstrikethrough) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp title="C#"
[DataMember]
public CellDecorator DecoratorStrikethrough { get; set; }
```

## Methods

### Resize(int, int)

Resizes the label but forces a height of 1.

```csharp title="C#"
public override void Resize(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the label.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Not used.


### UpdateAndRedraw(TimeSpan)

Redraws the control if applicable.

```csharp title="C#"
public override void UpdateAndRedraw(TimeSpan time)
```

#### Parameters

`time` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The duration of thecurrent frame.


### GetStrikethrough(IFont, Color)

Gets the strikethrough glyph defined by a font. If not found, returns glyph 196.

```csharp title="C#"
protected CellDecorator GetStrikethrough(IFont font, Color color)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font.

`color` SadRogue.Primitives.Color  
The color to shade the decorator.

#### Returns

[CellDecorator](../sadconsole.celldecorator/)  
The cell decorator.

### GetUnderline(IFont, Color)

Gets the underline glyph defined by a font. If not found, returns glyph 95.

```csharp title="C#"
protected CellDecorator GetUnderline(IFont font, Color color)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  
The font.

`color` SadRogue.Primitives.Color  
The color to shade the decorator.

#### Returns

[CellDecorator](../sadconsole.celldecorator/)  
The cell decorator.