---
title: Serializer.Contracts Class
slug: reference/sadconsole.serializer.contracts
sidebar:
  label: Serializer.Contracts
---
## Definition

Registers the default converters for SadConsole objects, when needed.

```csharp title="C#"
public class Serializer.Contracts : DefaultContractResolver, IContractResolver
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Newtonsoft.Json.Serialization.DefaultContractResolver

Implements Newtonsoft.Json.Serialization.IContractResolver

## Constructors

### Contracts()

```csharp title="C#"
public Contracts()
```


## Methods

### ResolveContractConverter(Type)

```csharp title="C#"
protected override JsonConverter? ResolveContractConverter(Type objectType)
```

#### Parameters

`objectType` [Type](https://learn.microsoft.com/dotnet/api/system.type/)  

#### Returns

Newtonsoft.Json.JsonConverter