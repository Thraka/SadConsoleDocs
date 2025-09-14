---
title: Settings.Input Class
slug: reference/sadconsole.settings.input
sidebar:
  label: Settings.Input
---
## Definition

Settings related to input.

```csharp title="C#"
public static class Settings.Input
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### ProcessMouseOffscreen

Not currently used

```csharp title="C#"
public static bool ProcessMouseOffscreen { get; set; }
```

### DoMouse

Indicates that the [GameHost](../sadconsole.gamehost/) should process mouse input.

```csharp title="C#"
public static bool DoMouse { get; set; }
```

### DoKeyboard

Indicates that the [GameHost](../sadconsole.gamehost/) should process keyboard input.

```csharp title="C#"
public static bool DoKeyboard { get; set; }
```

### MouseClickTime

The maximum amount of time to trigger a mouse click.

```csharp title="C#"
public static TimeSpan MouseClickTime { get; set; }
```

### MouseDoubleClickTime

The maximum amount of time to trigger a mouse double click.

```csharp title="C#"
public static TimeSpan MouseDoubleClickTime { get; set; }
```