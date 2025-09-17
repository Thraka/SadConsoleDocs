---
title: StartingConsoleConfig Class
slug: reference/sadconsole.configuration.startingconsoleconfig
sidebar:
  label: StartingConsoleConfig
---
## Definition

```csharp title="C#"
public class StartingConsoleConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### StartingConsoleConfig()

```csharp title="C#"
public StartingConsoleConfig()
```


## Methods

### Run(BuilderBase, GameHost)

Called by the [Builder](../sadconsole.configuration.builder/); Runs the specific config for this object.

```csharp title="C#"
public void Run(BuilderBase configBuilder, GameHost game)
```

#### Parameters

`configBuilder` [BuilderBase](../sadconsole.configuration.builderbase/)  

`game` [GameHost](../sadconsole.gamehost/)  
The game object being created.