---
title: MonoGameSettings Class
slug: reference/sadconsole.configuration.monogamesettings
sidebar:
  label: MonoGameSettings
editUrl: false
---
## Definition

```csharp title="C#"
public class MonoGameSettings : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### MonoGameSettings()

```csharp title="C#"
public MonoGameSettings()
```


## Properties

### UseTitleContainer

```csharp title="C#"
public bool UseTitleContainer { get; set; }
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