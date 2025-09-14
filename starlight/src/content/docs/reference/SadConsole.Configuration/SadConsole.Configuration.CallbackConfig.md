---
title: CallbackConfig Class
slug: reference/sadconsole.configuration.callbackconfig
sidebar:
  label: CallbackConfig
---
## Definition

```csharp title="C#"
public class CallbackConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### CallbackConfig()

```csharp title="C#"
public CallbackConfig()
```


## Properties

### event_Started

```csharp title="C#"
public EventHandler<GameHost>? event_Started { get; set; }
```

### event_Ending

```csharp title="C#"
public EventHandler<GameHost>? event_Ending { get; set; }
```

### event_FrameUpdate

```csharp title="C#"
public EventHandler<GameHost>? event_FrameUpdate { get; set; }
```

### event_FrameRender

```csharp title="C#"
public EventHandler<GameHost>? event_FrameRender { get; set; }
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