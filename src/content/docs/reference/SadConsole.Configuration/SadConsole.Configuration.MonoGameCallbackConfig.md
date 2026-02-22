---
title: MonoGameCallbackConfig Class
slug: reference/sadconsole.configuration.monogamecallbackconfig
sidebar:
  label: MonoGameCallbackConfig
editUrl: false
---
## Definition

```csharp title="C#"
public class MonoGameCallbackConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### MonoGameCallbackConfig()

```csharp title="C#"
public MonoGameCallbackConfig()
```


## Properties

### MonoGameCtorCallback

```csharp title="C#"
public Action<Game>? MonoGameCtorCallback { get; set; }
```

### MonoGameInitCallback

```csharp title="C#"
public Action<Game>? MonoGameInitCallback { get; set; }
```

### SkipMonoGameGameCreation

```csharp title="C#"
public bool SkipMonoGameGameCreation { get; set; }
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