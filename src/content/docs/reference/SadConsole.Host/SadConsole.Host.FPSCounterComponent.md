---
title: FPSCounterComponent Class
slug: reference/sadconsole.host.fpscountercomponent
sidebar:
  label: FPSCounterComponent
editUrl: false
description: A component to draw how many frames per second the engine is performing at.
---
## Definition

A component to draw how many frames per second the engine is performing at.

```csharp title="C#"
public class FPSCounterComponent : DrawableGameComponent, IGameComponent, IUpdateable, IDisposable, IDrawable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Microsoft.Xna.Framework.GameComponent → Microsoft.Xna.Framework.DrawableGameComponent

Implements Microsoft.Xna.Framework.IGameComponent, Microsoft.Xna.Framework.IUpdateable, [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), Microsoft.Xna.Framework.IDrawable

## Constructors

### FPSCounterComponent(Game)

```csharp title="C#"
public FPSCounterComponent(Game game)
```

#### Parameters

`game` Microsoft.Xna.Framework.Game  


## Methods

### Update(GameTime)

```csharp title="C#"
public override void Update(GameTime gameTime)
```

#### Parameters

`gameTime` Microsoft.Xna.Framework.GameTime  


### Draw(GameTime)

```csharp title="C#"
public override void Draw(GameTime gameTime)
```

#### Parameters

`gameTime` Microsoft.Xna.Framework.GameTime