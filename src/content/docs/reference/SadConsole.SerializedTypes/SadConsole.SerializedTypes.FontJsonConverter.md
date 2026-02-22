---
title: FontJsonConverter Class
slug: reference/sadconsole.serializedtypes.fontjsonconverter
sidebar:
  label: FontJsonConverter
editUrl: false
---
## Definition

```csharp title="C#"
public class FontJsonConverter : JsonConverter<IFont>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Newtonsoft.Json.JsonConverter → [JsonConverter\<IFont\>](../sadconsole.ifont/)

## Constructors

### FontJsonConverter()

```csharp title="C#"
public FontJsonConverter()
```


## Methods

### WriteJson(JsonWriter, IFont, JsonSerializer)

```csharp title="C#"
public override void WriteJson(JsonWriter writer, IFont value, JsonSerializer serializer)
```

#### Parameters

`writer` Newtonsoft.Json.JsonWriter  

`value` [IFont](../sadconsole.ifont/)  

`serializer` Newtonsoft.Json.JsonSerializer  


### ReadJson(JsonReader, Type, IFont, bool, JsonSerializer)

```csharp title="C#"
public override IFont ReadJson(JsonReader reader, Type objectType, IFont existingValue, bool hasExistingValue, JsonSerializer serializer)
```

#### Parameters

`reader` Newtonsoft.Json.JsonReader  

`objectType` [Type](https://learn.microsoft.com/dotnet/api/system.type/)  

`existingValue` [IFont](../sadconsole.ifont/)  

`hasExistingValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`serializer` Newtonsoft.Json.JsonSerializer  

#### Returns

[IFont](../sadconsole.ifont/)