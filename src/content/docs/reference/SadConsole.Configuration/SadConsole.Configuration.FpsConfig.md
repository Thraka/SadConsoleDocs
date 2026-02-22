---
title: FpsConfig Class
slug: reference/sadconsole.configuration.fpsconfig
sidebar:
  label: FpsConfig
editUrl: false
---
## Definition

```csharp title="C#"
public class FpsConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### FpsConfig()

```csharp title="C#"
public FpsConfig()
```


## Properties

### UnlimitedFPS

```csharp title="C#"
public bool UnlimitedFPS { get; set; }
```

### ShowFPSVisual

```csharp title="C#"
public bool ShowFPSVisual { get; set; }
```

## Methods

### Run(BuilderBase, GameHost)

Called by the [Builder](../sadconsole.configuration.builder/); Runs the specific config for this object.

```csharp title="C#"
public void Run(BuilderBase configBuilder, GameHost game)
```

#### Parameters

`configBuilder` [BuilderBase](../sadconsole.configuration.builderbase/)  

`game` [GameHost](../sadconsole.gamehost/)  
The game object being created.