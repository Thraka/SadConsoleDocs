---
title: SadConsoleGameComponent Class
slug: reference/sadconsole.host.sadconsolegamecomponent
sidebar:
  label: SadConsoleGameComponent
editUrl: false
description: A game component that handles updating, input, and rendering of SadConsole.
---
## Definition

A game component that handles updating, input, and rendering of SadConsole.

```csharp title="C#"
public class SadConsoleGameComponent : DrawableGameComponent, IGameComponent, IUpdateable, IDisposable, IDrawable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Microsoft.Xna.Framework.GameComponent → Microsoft.Xna.Framework.DrawableGameComponent

Implements Microsoft.Xna.Framework.IGameComponent, Microsoft.Xna.Framework.IUpdateable, [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), Microsoft.Xna.Framework.IDrawable

## Constructors

### SadConsoleGameComponent(Game)

```csharp title="C#"
public SadConsoleGameComponent(Game game)
```

#### Parameters

`game` Microsoft.Xna.Framework.Game  


## Methods

### Initialize()

```csharp title="C#"
public override void Initialize()
```


### Draw(GameTime)

Draws the SadConsole frame through draw calls when ``SadConsole.Settings.DoDraw`` is true.

```csharp title="C#"
public override void Draw(GameTime gameTime)
```

#### Parameters

`gameTime` Microsoft.Xna.Framework.GameTime  
Time between drawing frames.


### Update(GameTime)

Updates the SadConsole game objects and handles input. Only runs when ``SadConsole.Settings.DoUpdate`` is true.

```csharp title="C#"
public override void Update(GameTime gameTime)
```

#### Parameters

`gameTime` Microsoft.Xna.Framework.GameTime