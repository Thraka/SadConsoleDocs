---
title: IMouseState Interface
slug: reference/sadconsole.input.imousestate
sidebar:
  label: IMouseState
---
## Definition

Reports the state of the mouse.

```csharp title="C#"
public interface IMouseState
```


## Properties

### IsLeftButtonDown

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>  when the left mouse button is pressed; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool IsLeftButtonDown { get; }
```

### IsRightButtonDown

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>  when the right mouse button is pressed; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool IsRightButtonDown { get; }
```

### IsMiddleButtonDown

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>  when the middle mouse button is pressed; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
bool IsMiddleButtonDown { get; }
```

### ScreenPosition

The pixel position of the mouse on the screen relative to the game window.

```csharp title="C#"
Point ScreenPosition { get; }
```

### MouseWheel

The value of the mouse wheel.

```csharp title="C#"
int MouseWheel { get; }
```

## Methods

### Refresh()

If applicable to the host implementation, refreshes the mouse state.

```csharp title="C#"
void Refresh()
```