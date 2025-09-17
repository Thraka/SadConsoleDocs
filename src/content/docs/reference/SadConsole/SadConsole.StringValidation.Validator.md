---
title: StringValidation.Validator Delegate
slug: reference/sadconsole.stringvalidation.validator
sidebar:
  label: StringValidation.Validator
---
## Definition

Validates a string value.

```csharp title="C#"
public delegate StringValidation.Result StringValidation.Validator(string input)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The string to validate.


## Constructors

### Validator(object, nint)

```csharp title="C#"
public Validator(object @object, nint method)
```

#### Parameters

`object` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

`method` [nint](https://learn.microsoft.com/dotnet/api/system.intptr/)  


## Methods

### Invoke(string)

```csharp title="C#"
public virtual StringValidation.Result Invoke(string input)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

#### Returns

[StringValidation.Result](../sadconsole.stringvalidation/)

### BeginInvoke(string, AsyncCallback, object)

```csharp title="C#"
public virtual IAsyncResult BeginInvoke(string input, AsyncCallback callback, object @object)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`callback` [AsyncCallback](https://learn.microsoft.com/dotnet/api/system.asynccallback/)  

`object` [object](https://learn.microsoft.com/dotnet/api/system.object/)  

#### Returns

[IAsyncResult](https://learn.microsoft.com/dotnet/api/system.iasyncresult/)

### EndInvoke(IAsyncResult)

```csharp title="C#"
public virtual StringValidation.Result EndInvoke(IAsyncResult result)
```

#### Parameters

`result` [IAsyncResult](https://learn.microsoft.com/dotnet/api/system.iasyncresult/)  

#### Returns

[StringValidation.Result](../sadconsole.stringvalidation/)