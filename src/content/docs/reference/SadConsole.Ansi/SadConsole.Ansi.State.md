---
title: State Class
slug: reference/sadconsole.ansi.state
sidebar:
  label: State
---
## Definition

Represents the state of an ANSI.SYS processor.

```csharp title="C#"
public class State
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### State()

Creates a new object to track the state of the ansi cursor.

```csharp title="C#"
public State()
```


## Properties

### Bold

Indicates that the state is using bold colors.

```csharp title="C#"
public bool Bold { get; set; }
```

### Reverse

Indicates that the state is printing reverse colors.

```csharp title="C#"
public bool Reverse { get; set; }
```

### Concealed

Not supported.

```csharp title="C#"
public bool Concealed { get; set; }
```

### Foreground

Foreground color for the state of the ANSI.SYS processor.

```csharp title="C#"
public Color Foreground { get; set; }
```

### Background

Background color for the state of the ANSI.SYS processor.

```csharp title="C#"
public Color Background { get; set; }
```

## Methods

### AnsiCorrectPrintColor()

Forces the Background of the print appearance to be the darkened color and the foreground to be bright or not based on the [Bold](../sadconsole.ansi.state/#bold/) property.

```csharp title="C#"
public void AnsiCorrectPrintColor()
```


### AnsiResetVideo()

Resets all of the print appearance and ansi settings back to the default.

```csharp title="C#"
public void AnsiResetVideo()
```