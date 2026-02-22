---
title: ValueChangedCancelableEventArgs<T> Class
slug: reference/sadconsole.valuechangedcancelableeventargs-1
sidebar:
  label: ValueChangedCancelableEventArgs<T>
editUrl: false
description: Event arguments for an event fired when an object's properties are changed. The change can be cancelled.
---
## Definition

Event arguments for an event fired when an object's properties are changed. The change can be cancelled.

```csharp title="C#"
public class ValueChangedCancelableEventArgs<T> : ValueChangedEventArgs<T>
```

### Type Parameters

`T`  


Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs/) → SadRogue.Primitives.ValueChangedEventArgs\<T\>

## Constructors

### ValueChangedCancelableEventArgs(T, T)

Creates a new instance of this object with the specified old and new value.

```csharp title="C#"
public ValueChangedCancelableEventArgs(T oldValue, T newValue)
```

#### Parameters

`oldValue` T  
The old value.

`newValue` T  
The new value.


## Properties

### IsCancelled

Setting this property to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates that the change should be cancelled.

```csharp title="C#"
public bool IsCancelled { get; set; }
```