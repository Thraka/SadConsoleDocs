---
title: BuilderBase Class
slug: reference/sadconsole.configuration.builderbase
sidebar:
  label: BuilderBase
editUrl: false
description: Base class for building startup config options.
---
## Definition

Base class for building startup config options.

```csharp title="C#"
public abstract class BuilderBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### BuilderBase()

```csharp title="C#"
protected BuilderBase()
```


## Properties

### Configs

A collection of [IConfigurator](../sadconsole.configuration.iconfigurator/) objects.

```csharp title="C#"
public List<IConfigurator> Configs { get; }
```

## Methods

### GetOrCreateConfig\<TConfig>()

Adds or gets the specified config object from the [Configs](../sadconsole.configuration.builderbase/#configs) collection.

```csharp title="C#"
public TConfig GetOrCreateConfig<TConfig>() where TConfig : IConfigurator, new()
```

#### Returns

TConfig  
A new instance of `TConfig` if it's not found in the [Configs](../sadconsole.configuration.builderbase/#configs) collection. If found in the collection, that instance is returned.

### ProcessConfigs(GameHost)

Runs each config object in the [Configs](../sadconsole.configuration.builderbase/#configs) collection with the specified game instance.

```csharp title="C#"
public void ProcessConfigs(GameHost game)
```

#### Parameters

`game` [GameHost](../sadconsole.gamehost/)  
The game being created.