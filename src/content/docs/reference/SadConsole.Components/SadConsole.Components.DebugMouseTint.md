---
title: DebugMouseTint Class
slug: reference/sadconsole.components.debugmousetint
sidebar:
  label: DebugMouseTint
editUrl: false
description: Tints a surface when that surface would use the mouse. Helps debug which object is receiving mouse input as you move the mouse around.
---
## Definition

Tints a surface when that surface would use the mouse. Helps debug which object is receiving mouse input as you move the mouse around.

```csharp title="C#"
public class DebugMouseTint : RootComponent, IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [RootComponent](../sadconsole.components.rootcomponent/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### DebugMouseTint()

```csharp title="C#"
public DebugMouseTint()
```


## Properties

### TintColor

The tint color to apply to the object under the mouse.

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