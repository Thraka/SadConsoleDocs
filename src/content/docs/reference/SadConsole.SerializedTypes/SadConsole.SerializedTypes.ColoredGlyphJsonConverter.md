---
title: ColoredGlyphJsonConverter Class
slug: reference/sadconsole.serializedtypes.coloredglyphjsonconverter
sidebar:
  label: ColoredGlyphJsonConverter
editUrl: false
---
## Definition

```csharp title="C#"
public class ColoredGlyphJsonConverter : JsonConverter<ColoredGlyph>
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → Newtonsoft.Json.JsonConverter → [JsonConverter\<ColoredGlyph\>](../sadconsole.coloredglyph/)

## Constructors

### ColoredGlyphJsonConverter()

```csharp title="C#"
public ColoredGlyphJsonConverter()
```


## Methods

### WriteJson(JsonWriter, ColoredGlyph, JsonSerializer)

```csharp title="C#"
public override void WriteJson(JsonWriter writer, ColoredGlyph value, JsonSerializer serializer)
```

#### Parameters

`writer` Newtonsoft.Json.JsonWriter  

`value` [ColoredGlyph](../sadconsole.coloredglyph/)  

`serializer` Newtonsoft.Json.JsonSerializer  


### ReadJson(JsonReader, Type, ColoredGlyph, bool, JsonSerializer)

```csharp title="C#"
public override ColoredGlyph ReadJson(JsonReader reader, Type objectType, ColoredGlyph existingValue, bool hasExistingValue, JsonSerializer serializer)
```

#### Parameters

`reader` Newtonsoft.Json.JsonReader  

`objectType` [Type](https://learn.microsoft.com/dotnet/api/system.type/)  

`existingValue` [ColoredGlyph](../sadconsole.coloredglyph/)  

`hasExistingValue` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`serializer` Newtonsoft.Json.JsonSerializer  

#### Returns

[ColoredGlyph](../sadconsole.coloredglyph/)