---
title: ImGuiGuardedValue<T> Struct
slug: reference/sadconsole.imguisystem.imguiguardedvalue-1
sidebar:
  label: ImGuiGuardedValue<T>
editUrl: false
description: Makes a copy of a value and allows it to be changed. The change can be committed or reverted.
---
## Definition

Makes a copy of a value and allows it to be changed. The change can be committed or reverted.

```csharp title="C#"
public struct ImGuiGuardedValue<T> where T : struct
```

### Type Parameters

`T`  
A structure.


## Constructors

### ImGuiGuardedValue(T)

Creates a new instance of this structure, wrapping the provided value.

```csharp title="C#"
public ImGuiGuardedValue(T value)
```

#### Parameters

`value` T  
The original value.


## Fields

### OriginalValue

The original value.

```csharp title="C#"
public T OriginalValue
```

### CurrentValue

The current value.

```csharp title="C#"
public T CurrentValue
```

## Methods

### IsChanged()

Returns true when the original value doesn't equal the current value.

```csharp title="C#"
public bool IsChanged()
```

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
A value to indicate changed state.

### Commit()

Sets the original value to the current value.

```csharp title="C#"
public void Commit()
```


### Reset()

Sets the current value to the original value.

```csharp title="C#"
public void Reset()
```