---
title: StringValidation Class
slug: reference/sadconsole.stringvalidation
sidebar:
  label: StringValidation
---
## Definition

Validates a string

```csharp title="C#"
public static class StringValidation
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### None(string)

Always validates to true.

```csharp title="C#"
public static StringValidation.Result None(string input)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to validate.

#### Returns

[StringValidation.Result](../sadconsole.stringvalidation/)  
A positive validation result.

### Integer(string)

Returns a [StringValidation.Validator](../sadconsole.stringvalidation/) delegate that validates whether or not a string can be parsed by the `System.Int64.TryParse(System.String%2cSystem.Int64%40)`.

```csharp title="C#"
public static StringValidation.Validator Integer(string errorMessage)
```

#### Parameters

`errorMessage` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A message to provide to the result if the validation fails.

#### Returns

[StringValidation.Validator](../sadconsole.stringvalidation/)  
The validation result.

### Decimal(string)

Returns a [StringValidation.Validator](../sadconsole.stringvalidation/) delegate that validates whether or not a string can be parsed by the `System.Double.TryParse(System.String%2cSystem.Double%40)`.

```csharp title="C#"
public static StringValidation.Validator Decimal(string errorMessage)
```

#### Parameters

`errorMessage` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A message to provide to the result if the validation fails.

#### Returns

[StringValidation.Validator](../sadconsole.stringvalidation/)  
The validation result.

### LengthRange(int, int, string)

Returns a [StringValidation.Validator](../sadconsole.stringvalidation/) delegate that validates whether or not a length of a string falls within the specified range.

```csharp title="C#"
public static StringValidation.Validator LengthRange(int min, int max, string errorMessage)
```

#### Parameters

`min` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`max` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`errorMessage` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A message to provide to the result if the validation fails.

#### Returns

[StringValidation.Validator](../sadconsole.stringvalidation/)  
The validation result.

### All(params Validator[])

Uses multiple [StringValidation.Validator](../sadconsole.stringvalidation/) delegates to validate a string. All validators must pass.

```csharp title="C#"
public static StringValidation.Validator All(params StringValidation.Validator[] validators)
```

#### Parameters

`validators` [Validator[]](../sadconsole.stringvalidation.validator/)  
Each <xref href="SadConsole.StringValidation.Validator" data-throw-if-not-resolved="false"></xref> to use.

#### Returns

[StringValidation.Validator](../sadconsole.stringvalidation/)  
When all validators pass, a successful result; otherwise, the failed result.

### Letters(string)

Returns a [StringValidation.Validator](../sadconsole.stringvalidation/) delegate that validates whether a string contains only letters.

```csharp title="C#"
public static StringValidation.Validator Letters(string errorMessage)
```

#### Parameters

`errorMessage` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
A message to provide to the result if the validation fails.

#### Returns

[StringValidation.Validator](../sadconsole.stringvalidation/)  
The validation result.