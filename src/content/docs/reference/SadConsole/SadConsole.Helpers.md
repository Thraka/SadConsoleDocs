---
title: Helpers Class
slug: reference/sadconsole.helpers
sidebar:
  label: Helpers
editUrl: false
description: General code helpers.
---
## Definition

General code helpers.

```csharp title="C#"
public static class Helpers
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### HasFlag(in int, in int)

Checks for the presense of a flag in a value.

```csharp title="C#"
public static bool HasFlag(in int value, in int flag)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The value.

`flag` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The flag.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the flag exists in the value; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### SetFlag(int, int)

Sets a flag in a value.

```csharp title="C#"
public static int SetFlag(int value, int flag)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The value.

`flag` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The flag.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
A new value with the flag added.

### UnsetFlag(int, int)

Removes a flag from a value.

```csharp title="C#"
public static int UnsetFlag(int value, int flag)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The value.

`flag` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The flag.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
A new value with the flag removed.