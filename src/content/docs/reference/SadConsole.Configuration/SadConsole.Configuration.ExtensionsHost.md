---
title: ExtensionsHost Class
slug: reference/sadconsole.configuration.extensionshost
sidebar:
  label: ExtensionsHost
---
## Definition

```csharp title="C#"
public static class ExtensionsHost
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### Run(Builder)

Runs the game using the builder configuration.

```csharp title="C#"
public static void Run(this Builder configBuilder)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.


### UseUnlimitedFPS(Builder)

Unlimited FPS when rendering (normally limited to 60fps). Must be set before the game is created.

```csharp title="C#"
public static Builder UseUnlimitedFPS(this Builder configBuilder)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### ShowMonoGameFPS(Builder)

Adds a MonoGame game component that renders the frames per-second of the game.

```csharp title="C#"
public static Builder ShowMonoGameFPS(this Builder configBuilder)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration builder.

### UseTitleContainer(Builder)

Tells the game host to use the `Microsoft.Xna.Framework.TitleContainer` to open streams for reading.

```csharp title="C#"
public static Builder UseTitleContainer(this Builder configBuilder)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration object.

### WithMonoGameCtor(Builder, Action<Game>)

The `monogameCtorCallback` method is called by the MonoGame constructor. Some MonoGame specific settings may only be settable via the constructor.

```csharp title="C#"
public static Builder WithMonoGameCtor(this Builder configBuilder, Action<Game> monogameCtorCallback)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`monogameCtorCallback` [Action\<Game\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
A method.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration object.

### WithMonoGameInit(Builder, Action<Game>)

Internal only. Called by the MonoGame game to finish configuring SadConsole.

```csharp title="C#"
public static Builder WithMonoGameInit(this Builder configBuilder, Action<Game> monogameInitCallback)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

`monogameInitCallback` [Action\<Game\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
A method.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration object.

### SkipMonoGameGameCreation(Builder)

When called, tells the game host not to create the monogame game instance at [MonoGameInstance](../sadconsole.game/#monogameinstance/).

```csharp title="C#"
public static Builder SkipMonoGameGameCreation(this Builder configBuilder)
```

#### Parameters

`configBuilder` [Builder](../sadconsole.configuration.builder/)  
The builder object that composes the game startup.

#### Returns

[Builder](../sadconsole.configuration.builder/)  
The configuration object.