---
title: IContainer Interface
slug: reference/sadconsole.ui.controls.icontainer
sidebar:
  label: IContainer
---
## Definition

A simple container for controls.

```csharp title="C#"
public interface IContainer : IList<ControlBase>, ICollection<ControlBase>, IEnumerable<ControlBase>, IEnumerable
```


## Properties

### AbsolutePosition

Gets the position of the container based on any parents position.

```csharp title="C#"
Point AbsolutePosition { get; }
```

### Host

The host owning this container.

```csharp title="C#"
ControlHost? Host { get; }
```

### this[string]

Gets a control by its [Name](../sadconsole.ui.controls.controlbase/#name/) property.

```csharp title="C#"
ControlBase this[string name] { get; }
```

## Methods

### HasNamedControl(string)

Checks whether or not the container has a control registered with the given name.

```csharp title="C#"
bool HasNamedControl(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to check.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the control is found; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### HasNamedControl(string, out ControlBase?)

Checks whether or not the container has a control registered with the given name. If found, the instance is assigned to the `control` parameter.

```csharp title="C#"
bool HasNamedControl(string name, out ControlBase? control)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name to check.

`control` [ControlBase](../sadconsole.ui.controls.controlbase/)  
The control instance found.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> when the control is found; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### GetNamedControl(string)

Gets a control by its [Name](../sadconsole.ui.controls.controlbase/#name/) property.

```csharp title="C#"
ControlBase GetNamedControl(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The name of the control.

#### Returns

[ControlBase](../sadconsole.ui.controls.controlbase/)  
The control.