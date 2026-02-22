---
title: ConnectedLineStyleType Class
slug: reference/sadconsole.imguitypes.connectedlinestyletype
sidebar:
  label: ConnectedLineStyleType
editUrl: false
---
## Definition

```csharp title="C#"
public class ConnectedLineStyleType : ITitle
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [ITitle](../sadconsole.imguisystem.ititle/)

## Constructors

### ConnectedLineStyleType(string, int[])

```csharp title="C#"
public ConnectedLineStyleType(string title, int[] connectedLineStyle)
```

#### Parameters

`title` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`connectedLineStyle` [int[]](https://learn.microsoft.com/dotnet/api/system.int32/)  


## Properties

### AllConnectedLineStyles

```csharp title="C#"
public static ConnectedLineStyleType[] AllConnectedLineStyles { get; }
```

### Title

The title of the object.

```csharp title="C#"
public string Title { get; }
```

### ConnectedLineStyle

```csharp title="C#"
public int[] ConnectedLineStyle { get; }
```

## Methods

### ToString()

```csharp title="C#"
public override string ToString()
```

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)