---
title: ScreenObjectState.ScreenSurfaceState Class
slug: reference/sadconsole.debug.screenobjectstate.screensurfacestate
sidebar:
  label: ScreenObjectState.ScreenSurfaceState
---
## Definition

```csharp title="C#"
public class ScreenObjectState.ScreenSurfaceState
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### ScreenSurfaceState()

```csharp title="C#"
public ScreenSurfaceState()
```


## Fields

### Tint

```csharp title="C#"
public Vector4 Tint
```

### View

```csharp title="C#"
public Vector4 View
```

### Width

```csharp title="C#"
public int Width
```

### Height

```csharp title="C#"
public int Height
```

### RenderStepSelectedItem

```csharp title="C#"
public int RenderStepSelectedItem
```

### RenderStepsNames

```csharp title="C#"
public string[] RenderStepsNames
```

### RenderSteps

```csharp title="C#"
public IRenderStepTexture[] RenderSteps
```

## Methods

### Refresh(IScreenSurface)

```csharp title="C#"
public void Refresh(IScreenSurface surface)
```

#### Parameters

`surface` [IScreenSurface](../sadconsole.iscreensurface/)