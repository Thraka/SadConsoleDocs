---
title: IComponentHost Interface
slug: reference/sadconsole.components.icomponenthost
sidebar:
  label: IComponentHost
---
## Definition

Provides a collection of [IComponent](../sadconsole.components.icomponent/) objects.

```csharp title="C#"
public interface IComponentHost
```


## Properties

### SadComponents

A collection of components processed by this console.

```csharp title="C#"
ObservableCollection<IComponent> SadComponents { get; }
```

## Methods

### GetSadComponent<TComponent>()

Gets the first component of the specified type.

```csharp title="C#"
TComponent? GetSadComponent<TComponent>() where TComponent : class, IComponent
```

#### Returns

TComponent  
The component if found, otherwise null.

### GetSadComponents<TComponent>()

Gets components of the specified types.

```csharp title="C#"
IEnumerable<TComponent> GetSadComponents<TComponent>() where TComponent : class, IComponent
```

#### Returns

[IEnumerable\<TComponent\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The components found.

### HasSadComponent<TComponent>(out TComponent?)

Indicates whether or not the component exists in the [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) collection.

```csharp title="C#"
bool HasSadComponent<TComponent>(out TComponent? component) where TComponent : class, IComponent
```

#### Parameters

`component` TComponent  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the component exists; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### CompareComponent(IComponent, IComponent)

Uses the [SortOrder](../sadconsole.components.icomponent/#sortorder/) to compare the `left` component with the `right` component.

```csharp title="C#"
public static int CompareComponent(IComponent left, IComponent right)
```

#### Parameters

`left` [IComponent](../sadconsole.components.icomponent/)  
The first component to compare.

`right` [IComponent](../sadconsole.components.icomponent/)  
The second component to compare.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
<pre>`1`</pre> when the `left` sort order is greater than `right`; <pre>`-1`</pre> when `left` is less than `right`; <pre>`0`</pre> when they are equal.