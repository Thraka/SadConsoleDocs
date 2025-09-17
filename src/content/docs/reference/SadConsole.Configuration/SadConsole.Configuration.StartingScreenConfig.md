---
title: StartingScreenConfig Class
slug: reference/sadconsole.configuration.startingscreenconfig
sidebar:
  label: StartingScreenConfig
---
## Definition

```csharp title="C#"
public class StartingScreenConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### StartingScreenConfig()

```csharp title="C#"
public StartingScreenConfig()
```


## Properties

### GenerateStartingObject

```csharp title="C#"
public Func<GameHost, IScreenObject> GenerateStartingObject { get; set; }
```

### FocusStartingScreen

```csharp title="C#"
public bool? FocusStartingScreen { get; set; }
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