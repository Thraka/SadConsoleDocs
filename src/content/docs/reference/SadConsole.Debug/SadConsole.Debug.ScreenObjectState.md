---
title: ScreenObjectState Class
slug: reference/sadconsole.debug.screenobjectstate
sidebar:
  label: ScreenObjectState
editUrl: false
---
## Definition

```csharp title="C#"
public class ScreenObjectState
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ScreenObjectState()

```csharp title="C#"
public ScreenObjectState()
```


## Fields

### Identifier

```csharp title="C#"
public int Identifier
```

### Found

```csharp title="C#"
public bool Found
```

### Object

```csharp title="C#"
public IScreenObject Object
```

### ObjectName

```csharp title="C#"
public string ObjectName
```

### PositionX

```csharp title="C#"
public int PositionX
```

### PositionY

```csharp title="C#"
public int PositionY
```

### IsVisible

```csharp title="C#"
public bool IsVisible
```

### IsEnabled

```csharp title="C#"
public bool IsEnabled
```

### IsScreenSurface

```csharp title="C#"
public bool IsScreenSurface
```

### IsWindow

```csharp title="C#"
public bool IsWindow
```

### ComponentsSelectedItem

```csharp title="C#"
public int ComponentsSelectedItem
```

### Components

```csharp title="C#"
public string[] Components
```

### Children

```csharp title="C#"
public ScreenObjectState[] Children
```

### SurfaceState

```csharp title="C#"
public ScreenObjectState.ScreenSurfaceState SurfaceState
```

### WindowState

```csharp title="C#"
public ScreenObjectState.WindowConsoleState WindowState
```

## Methods

### Create(IScreenObject)

```csharp title="C#"
public static ScreenObjectState Create(IScreenObject obj)
```

#### Parameters

`obj` [IScreenObject](../sadconsole.iscreenobject/)  

#### Returns

[ScreenObjectState](../sadconsole.debug.screenobjectstate/)

### Refresh()

```csharp title="C#"
public void Refresh()
```


### RefreshComponents()

```csharp title="C#"
public void RefreshComponents()
```


### RefreshChildren()

```csharp title="C#"
public void RefreshChildren()
```