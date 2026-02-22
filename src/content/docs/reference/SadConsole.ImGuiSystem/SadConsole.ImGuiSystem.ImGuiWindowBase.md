---
title: ImGuiWindowBase Class
slug: reference/sadconsole.imguisystem.imguiwindowbase
sidebar:
  label: ImGuiWindowBase
editUrl: false
---
## Definition

```csharp title="C#"
public abstract class ImGuiWindowBase : ImGuiObjectBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ImGuiObjectBase](../sadconsole.imguisystem.imguiobjectbase/)

## Constructors

### ImGuiWindowBase()

```csharp title="C#"
protected ImGuiWindowBase()
```


## Fields

### IsOpen

```csharp title="C#"
public bool IsOpen
```

### RemoveOnClose

```csharp title="C#"
public bool RemoveOnClose
```

### AddOnOpen

```csharp title="C#"
public bool AddOnOpen
```

### DialogResult

```csharp title="C#"
public bool DialogResult
```

## Properties

### Title

```csharp title="C#"
public string Title { get; set; }
```

## Methods

### Close()

```csharp title="C#"
public void Close()
```


### OnClosed()

```csharp title="C#"
protected virtual void OnClosed()
```


### Open()

```csharp title="C#"
public void Open()
```


### OnOpened()

```csharp title="C#"
protected virtual void OnOpened()
```


### DrawButtons(out bool, bool, string, string)

```csharp title="C#"
public static bool DrawButtons(out bool result, bool acceptDisabled = false, string cancelButtonText = "Cancel", string acceptButtonText = "Accept")
```

#### Parameters

`result` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`acceptDisabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`cancelButtonText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`acceptButtonText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

## Events

### Closed

```csharp title="C#"
public event EventHandler Closed
```

#### Event Type

[EventHandler](https://learn.microsoft.com/dotnet/api/system.eventhandler/)