---
title: DebugFocusedObjectTint Class
slug: reference/sadconsole.components.debugfocusedobjecttint
sidebar:
  label: DebugFocusedObjectTint
---
## Definition

Tints a surface when that surface is focused. Helps debug which object is focused in [FocusedScreenObjects](../sadconsole.gamehost/#focusedscreenobjects/).

```csharp title="C#"
public class DebugFocusedObjectTint : RootComponent, IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [RootComponent](../sadconsole.components.rootcomponent/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### DebugFocusedObjectTint()

```csharp title="C#"
public DebugFocusedObjectTint()
```


## Properties

### TintColor

The tint color to apply to the focused object.

```csharp title="C#"
public Color TintColor { get; set; }
```

### IsEnabled

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, disables this component and clears the tinted object.

```csharp title="C#"
public bool IsEnabled { get; set; }
```

## Methods

### Run(TimeSpan)

Code to run during update.

```csharp title="C#"
public override void Run(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last frame.