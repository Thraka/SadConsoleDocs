---
title: RendererJsonConverter Class
slug: reference/sadconsole.serializedtypes.rendererjsonconverter
sidebar:
  label: RendererJsonConverter
---
## Definition

Converts a [IRenderer](../sadconsole.renderers.irenderer/) to its [Name](../sadconsole.renderers.irenderer/#name/) value and back.

```csharp title="C#"
public class RendererJsonConverter : JsonConverter<IRenderer>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Newtonsoft.Json.JsonConverter → [JsonConverter\<IRenderer\>](../sadconsole.renderers.irenderer/)

## Constructors

### RendererJsonConverter()

```csharp title="C#"
public RendererJsonConverter()
```


## Methods

### WriteJson(JsonWriter, IRenderer?, JsonSerializer)

```csharp title="C#"
public override void WriteJson(JsonWriter writer, IRenderer? value, JsonSerializer serializer)
```

#### Parameters

`writer` Newtonsoft.Json.JsonWriter  

`value` [IRenderer](../sadconsole.renderers.irenderer/)  

`serializer` Newtonsoft.Json.JsonSerializer  


### ReadJson(JsonReader, Type, IRenderer?, bool, JsonSerializer)

```csharp title="C#"
public override IRenderer? ReadJson(JsonReader reader, Type objectType, IRenderer? existingValue, bool hasExistingValue, JsonSerializer serializer)
```

#### Parameters

`reader` Newtonsoft.Json.JsonReader  

`objectType` [Type](https://learn.microsoft.com/dotnet/api/system.type/)  

`existingValue` [IRenderer](../sadconsole.renderers.irenderer/)  

`hasExistingValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`serializer` Newtonsoft.Json.JsonSerializer  

#### Returns

[IRenderer](../sadconsole.renderers.irenderer/)