---
title: SplashScreenConfig Class
slug: reference/sadconsole.configuration.splashscreenconfig
sidebar:
  label: SplashScreenConfig
---
## Definition

A config object that adds splash screen objects with the `SadConsole.GameHost.SetSplashScreens(SadConsole.IScreenSurface%5b%5d)` method.

```csharp title="C#"
public class SplashScreenConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### SplashScreenConfig()

```csharp title="C#"
public SplashScreenConfig()
```


## Properties

### GenerateSplashScreen

A delegate that returns a set of splash screens to use.

```csharp title="C#"
public Func<GameHost, IScreenSurface[]> GenerateSplashScreen { get; set; }
```

## Methods

### Run(BuilderBase, GameHost)

Called by the [Builder](../sadconsole.configuration.builder/); Runs the specific config for this object.

```csharp title="C#"
public void Run(BuilderBase config, GameHost game)
```

#### Parameters

`config` [BuilderBase](../sadconsole.configuration.builderbase/)  
The builder configuration object.

`game` [GameHost](../sadconsole.gamehost/)  
The game object being created.