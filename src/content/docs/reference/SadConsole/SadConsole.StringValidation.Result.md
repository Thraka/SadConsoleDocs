---
title: StringValidation.Result Struct
slug: reference/sadconsole.stringvalidation.result
sidebar:
  label: StringValidation.Result
editUrl: false
description: The object produced when validating a string.
---
## Definition

The object produced when validating a string.

```csharp title="C#"
public readonly struct StringValidation.Result
```


## Constructors

### Result(bool, string?)

Creates a new string validation result.

```csharp title="C#"
public Result(bool isValid, string? errorMsg = null)
```

#### Parameters

`isValid` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A value to indicate that the result is valid or not.

`errorMsg` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A message associated with the result when `isValid` is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.


## Fields

### IsValid

Indicates whether or not this result is valid.

```csharp title="C#"
public readonly bool IsValid
```

### ErrorMessage

The error message when [IsValid](../sadconsole.stringvalidation.result/#isvalid) is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>. May be an empty string when there isn't a message.

```csharp title="C#"
public readonly string ErrorMessage
```

## Methods

### Success()

A successful result.

```csharp title="C#"
public static StringValidation.Result Success()
```

#### Returns

[StringValidation.Result](../sadconsole.stringvalidation/)  
A successful result.