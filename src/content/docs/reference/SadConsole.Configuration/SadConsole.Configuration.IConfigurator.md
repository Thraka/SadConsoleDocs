---
title: IConfigurator Interface
slug: reference/sadconsole.configuration.iconfigurator
sidebar:
  label: IConfigurator
---
## Definition

Configuration interface that's added to the [Builder](../sadconsole.configuration.builder/) object.

```csharp title="C#"
public interface IConfigurator
```


## Methods

### Run(BuilderBase, GameHost)

Called by the [Builder](../sadconsole.configuration.builder/); Runs the specific config for this object.

```csharp title="C#"
void Run(BuilderBase config, GameHost game)
```

#### Parameters

`config` [BuilderBase](../sadconsole.configuration.builderbase/)  
The builder configuration object.

`game` [GameHost](../sadconsole.gamehost/)  
The game object being created.