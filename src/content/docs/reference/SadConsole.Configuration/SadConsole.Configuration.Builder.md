---
title: Builder Class
slug: reference/sadconsole.configuration.builder
sidebar:
  label: Builder
editUrl: false
description: Composes a game host object.
---
## Definition

Composes a game host object.

```csharp title="C#"
public sealed class Builder : BuilderBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [BuilderBase](../sadconsole.configuration.builderbase/)

## Constructors

### Builder()

```csharp title="C#"
public Builder()
```


## Methods

### GetBuilder()

Creates and returns a new instance of the [Builder](../sadconsole.configuration.builder/) class.

```csharp title="C#"
public static Builder GetBuilder()
```

#### Returns

[Builder](../sadconsole.configuration.builder/)  
A new [Builder](../sadconsole.configuration.builder/) instance.