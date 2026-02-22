---
title: ImGuiListEnum<TEnum> Class
slug: reference/sadconsole.imguisystem.imguilistenum-1
sidebar:
  label: ImGuiListEnum<TEnum>
editUrl: false
description: Wraps an enum type for ImGui controls, like listboxes.
---
## Definition

Wraps an enum type for ImGui controls, like listboxes.

```csharp title="C#"
public static class ImGuiListEnum<TEnum> where TEnum : struct, Enum
```

### Type Parameters

`TEnum`  
The enum to wrap.

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### Names

A collection of each enum name.

```csharp title="C#"
public static string[] Names
```

### Values

A collection of each enum value.

```csharp title="C#"
public static TEnum[] Values
```

## Properties

### Count

The count of the enums items.

```csharp title="C#"
public static int Count { get; }
```

## Methods

### GetValueFromIndex(int)

Gets a value from an index.

```csharp title="C#"
public static TEnum GetValueFromIndex(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
Index of the value to get.

#### Returns

TEnum  
A value.

### GetIndexFromValue(TEnum)

Gets an index from a value.

```csharp title="C#"
public static int GetIndexFromValue(TEnum value)
```

#### Parameters

`value` TEnum  
The value to get an index from.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index.