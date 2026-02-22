---
title: ExtendedLib_StringExtensions2 Class
slug: reference/sadconsole.extendedlib_stringextensions2
sidebar:
  label: ExtendedLib_StringExtensions2
editUrl: false
description: Extensions for the `System.String` type.
---
## Definition

Extensions for the [string](https://learn.microsoft.com/dotnet/api/system.string/) type.

```csharp title="C#"
public static class ExtendedLib_StringExtensions2
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ToAscii(string, int)

Converts a string into codepage 437.

```csharp title="C#"
public static string ToAscii(this string text, int codepage = 437)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to convert

`codepage` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Optional codepage to provide.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A transformed string.