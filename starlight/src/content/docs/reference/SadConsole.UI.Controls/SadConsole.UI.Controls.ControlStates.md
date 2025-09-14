---
title: ControlStates Enum
slug: reference/sadconsole.ui.controls.controlstates
sidebar:
  label: ControlStates
---
## Definition

Indicates the state of a control.

```csharp title="C#"
[Flags]
public enum ControlStates
```


## Fields

### Normal

Normal state.

```csharp title="C#"
Normal = 0
```

### Disabled

The control is disabled.

```csharp title="C#"
Disabled = 1
```

### Focused

The control has focus.

```csharp title="C#"
Focused = 2
```

### Clicked

The control is selected

```csharp title="C#"
Clicked = 4
```

### MouseOver

The mouse is over the control.

```csharp title="C#"
MouseOver = 8
```

### MouseLeftButtonDown

The left mouse button is down.

```csharp title="C#"
MouseLeftButtonDown = 16
```

### MouseRightButtonDown

The Right mouse button is down.

```csharp title="C#"
MouseRightButtonDown = 32
```

### Selected

The control is selected

```csharp title="C#"
Selected = 64
```