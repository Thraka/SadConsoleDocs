---
title: ImGuiMonoGameComponent Class
slug: reference/sadconsole.imguisystem.imguimonogamecomponent
sidebar:
  label: ImGuiMonoGameComponent
---
## Definition

```csharp title="C#"
public class ImGuiMonoGameComponent : DrawableGameComponent, IGameComponent, IUpdateable, IDisposable, IDrawable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Microsoft.Xna.Framework.GameComponent → Microsoft.Xna.Framework.DrawableGameComponent

Implements Microsoft.Xna.Framework.IGameComponent, Microsoft.Xna.Framework.IUpdateable, [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/), Microsoft.Xna.Framework.IDrawable

## Constructors

### ImGuiMonoGameComponent(GraphicsDeviceManager, Game, bool)

```csharp title="C#"
public ImGuiMonoGameComponent(GraphicsDeviceManager graphics, Game game, bool enableDocking)
```

#### Parameters

`graphics` Microsoft.Xna.Framework.GraphicsDeviceManager  

`game` Microsoft.Xna.Framework.Game  

`enableDocking` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


## Fields

### ImGuiRenderer

```csharp title="C#"
public ImGuiRenderer ImGuiRenderer
```

## Properties

### WantsMouseCapture

```csharp title="C#"
public bool WantsMouseCapture { get; }
```

### WantsKeyboardCapture

```csharp title="C#"
public bool WantsKeyboardCapture { get; }
```

### UIComponents

```csharp title="C#"
public List<ImGuiObjectBase> UIComponents { get; }
```

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


## Events

### HostClosed

```csharp title="C#"
public event EventHandler HostClosed
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)