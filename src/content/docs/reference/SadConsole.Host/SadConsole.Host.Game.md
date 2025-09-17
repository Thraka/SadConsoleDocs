---
title: Game Class
slug: reference/sadconsole.host.game
sidebar:
  label: Game
---
## Definition

A MonoGame `Microsoft.Xna.Framework.Game` instance that runs SadConsole.

```csharp title="C#"
public class Game : Game, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Microsoft.Xna.Framework.Game

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### Game()

Creates the new MonoGame game object.

```csharp title="C#"
public Game()
```


## Properties

### WindowWidth

The current game window width.

```csharp title="C#"
public int WindowWidth { get; }
```

### WindowHeight

The current game window height.

```csharp title="C#"
public int WindowHeight { get; }
```

## Methods

### Initialize()

```csharp title="C#"
protected override void Initialize()
```


## Events

### WindowResized

Raised when the window is resized and the render area has been calculated.

```csharp title="C#"
public event EventHandler WindowResized
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)