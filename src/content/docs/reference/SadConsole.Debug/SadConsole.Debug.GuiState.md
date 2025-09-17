---
title: GuiState Class
slug: reference/sadconsole.debug.guistate
sidebar:
  label: GuiState
---
## Definition

```csharp title="C#"
public static class GuiState
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### _selectedScreenObject

```csharp title="C#"
public static IScreenObject? _selectedScreenObject
```

### _selectedScreenObjectState

```csharp title="C#"
public static ScreenObjectState? _selectedScreenObjectState
```

### _hoveredScreenObjectState

```csharp title="C#"
public static ScreenObjectState? _hoveredScreenObjectState
```

### ScreenObjectUniques

```csharp title="C#"
public static Dictionary<IScreenObject, ScreenObjectState> ScreenObjectUniques
```

## Methods

### RefreshScreenObject()

```csharp title="C#"
public static void RefreshScreenObject()
```