---
title: ColorJsonConverter Class
slug: reference/sadconsole.serializedtypes.colorjsonconverter
sidebar:
  label: ColorJsonConverter
editUrl: false
---
## Definition

```csharp title="C#"
public class ColorJsonConverter : JsonConverter<Color>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Newtonsoft.Json.JsonConverter → Newtonsoft.Json.JsonConverterSadRogue.Primitives.Color

## Constructors

### ColorJsonConverter()

```csharp title="C#"
public ColorJsonConverter()
```


## Methods

### WriteJson(JsonWriter, Color, JsonSerializer)

```csharp title="C#"
public override void WriteJson(JsonWriter writer, Color value, JsonSerializer serializer)
```

#### Parameters

`writer` Newtonsoft.Json.JsonWriter  

`value` SadRogue.Primitives.Color  

`serializer` Newtonsoft.Json.JsonSerializer  


### ReadJson(JsonReader, Type, Color, bool, JsonSerializer)

```csharp title="C#"
public override Color ReadJson(JsonReader reader, Type objectType, Color existingValue, bool hasExistingValue, JsonSerializer serializer)
```

#### Parameters

`reader` Newtonsoft.Json.JsonReader  

`objectType` [Type](https://learn.microsoft.com/dotnet/api/system.type/)  

`existingValue` SadRogue.Primitives.Color  

`hasExistingValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`serializer` Newtonsoft.Json.JsonSerializer  

#### Returns

SadRogue.Primitives.Color