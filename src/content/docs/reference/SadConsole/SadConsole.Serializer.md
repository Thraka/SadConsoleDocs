---
title: Serializer Class
slug: reference/sadconsole.serializer
sidebar:
  label: Serializer
editUrl: false
description: Common serialization tasks for SadConsole.
---
## Definition

Common serialization tasks for SadConsole.

```csharp title="C#"
public static class Serializer
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### Settings

The settings to use during [Save\<T\>(T, string, bool, JsonSerializerSettings)](../sadconsole.serializer/#savett-string-bool-jsonserializersettings) and [Load\<T\>(string, bool, JsonSerializerSettings)](../sadconsole.serializer/#loadtstring-bool-jsonserializersettings).

```csharp title="C#"
public static JsonSerializerSettings Settings { get; set; }
```

## Methods

### Serialize\<T>(T)

A shortcut for serialization that uses [SerializeObject(object, Type, JsonSerializerSettings)](https://learn.microsoft.com/dotnet/api/system.object/) with the [Settings](../sadconsole.serializer/#settings) property defined by this class.

```csharp title="C#"
public static string Serialize<T>(T instance)
```

#### Parameters

`instance` T  
The object to serialize.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A json encoded string.

### Deserialize\<T>(string)

A shortcut for serialization that uses [DeserializeObject(string, Type, JsonSerializerSettings)](https://learn.microsoft.com/dotnet/api/system.string/) with the [Settings](../sadconsole.serializer/#settings) property defined by this class.

```csharp title="C#"
public static T Deserialize<T>(string json)
```

#### Parameters

`json` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The json string to create an object from.

#### Returns

T  
An object created from the `json` parameter.

### Save\<T>(T, string, bool, JsonSerializerSettings?)

Serializes the `instance` to the specified file.

```csharp title="C#"
public static void Save<T>(T instance, string file, bool compress, JsonSerializerSettings? settings = null)
```

#### Parameters

`instance` T  
The object to serialize.

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to save the object to.

`compress` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, uses GZIP compression on the json string saved to the `file`

`settings` Newtonsoft.Json.JsonSerializerSettings  
Optional settings to use during serialization. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, uses the [Settings](../sadconsole.serializer/#settings) property.


### Load\<T>(string, bool, JsonSerializerSettings?)

Deserializes a new instance of `T` from the specified file.

```csharp title="C#"
public static T Load<T>(string file, bool isCompressed, JsonSerializerSettings? settings = null)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to load from.

`isCompressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, indicates that the json `file` should be decompressed with GZIP compression.

`settings` Newtonsoft.Json.JsonSerializerSettings  
Optional settings to use during deserialization. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, uses the [Settings](../sadconsole.serializer/#settings) property.

#### Returns

T  
A new object instance.

### TryLoad\<T>(string, bool, out T?, JsonSerializerSettings?)

Tries to load the file, returning it as the specified tyupe.

```csharp title="C#"
public static bool TryLoad<T>(string file, bool isCompressed, out T? obj, JsonSerializerSettings? settings = null)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to load from.

`isCompressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, indicates that the json `file` should be decompressed with GZIP compression.

`obj` T  
The loaded object.

`settings` Newtonsoft.Json.JsonSerializerSettings  
Optional settings to use during deserialization. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, uses the [Settings](../sadconsole.serializer/#settings) property.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)