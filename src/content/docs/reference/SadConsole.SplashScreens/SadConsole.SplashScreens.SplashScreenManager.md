---
title: SplashScreenManager Class
slug: reference/sadconsole.splashscreens.splashscreenmanager
sidebar:
  label: SplashScreenManager
editUrl: false
description: GameHost use only. Use the `SadConsole.SplashScreens.SplashScreenManager.CheckRun` method to show any splash screens after `SadConsole.GameHost.OnGameStarted` was called.
---
## Definition

GameHost use only. Use the [CheckRun()](../sadconsole.splashscreens.splashscreenmanager/#checkrun) method to show any splash screens after [OnGameStarted()](../sadconsole.gamehost/#ongamestarted) was called.

```csharp title="C#"
public class SplashScreenManager : ScreenObject, IScreenObject, IPositionable, IComponentHost
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObject](../sadconsole.screenobject/)

Implements [IScreenObject](../sadconsole.iscreenobject/), SadRogue.Primitives.IPositionable, [IComponentHost](../sadconsole.components.icomponenthost/)

## Methods

### CheckRun()

Checks if any splash screens have been added with [SetSplashScreens(params IScreenSurface[])](../sadconsole.gamehost/#setsplashscreensparams-iscreensurface), if so, starts them.

```csharp title="C#"
public static void CheckRun()
```


### Update(TimeSpan)

Updates all [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents) and [Children](../sadconsole.iscreenobject/#children).

```csharp title="C#"
public override void Update(TimeSpan delta)
```

#### Parameters

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since the last call.

#### Remarks

Only processes if [IsEnabled](../sadconsole.iscreenobject/#isenabled) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

## Events

### SplashScreenFinished

Raised when all splash screens have finished.

```csharp title="C#"
public static event EventHandler? SplashScreenFinished
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)