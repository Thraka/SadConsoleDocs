---
title: ReadOnlySpanExtensions Class
slug: reference/sadconsole.extensions.readonlyspanextensions
sidebar:
  label: ReadOnlySpanExtensions
---
## Definition

Extensions for the [ReadOnlySpan\<T\>](https://learn.microsoft.com/dotnet/api/system.readonlyspan-1/) type.

```csharp title="C#"
public static class ReadOnlySpanExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### Next(ReadOnlySpan<char>, char, out int)

Gets the next instnace of the specified character in a [char](https://learn.microsoft.com/dotnet/api/system.char/) span.

```csharp title="C#"
public static bool Next(this ReadOnlySpan<char> span, char value, out int index)
```

#### Parameters

`span` [ReadOnlySpan\<char\>](https://learn.microsoft.com/dotnet/api/system.readonlyspan-1/)  
The span.

`value` [char](https://learn.microsoft.com/dotnet/api/system.char/)  
The character to find.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the character.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
True when the character is found.