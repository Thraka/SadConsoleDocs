---
title: StyleExtensions Class
slug: reference/hexa.net.imgui.styleextensions
sidebar:
  label: StyleExtensions
---
## Definition

Extensions that help with getting ImGui style values.

```csharp title="C#"
public static class StyleExtensions
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### GetSpacing(ImGuiStylePtr, out Vector2, out Vector2)

Gets the frame padding and item spacing values.

```csharp title="C#"
public static void GetSpacing(this ImGuiStylePtr style, out Vector2 framePadding, out Vector2 itemSpacing)
```

#### Parameters

`style` Hexa.NET.ImGui.ImGuiStylePtr  
The style object.

`framePadding` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  
Frame padding.

`itemSpacing` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  
Item spacing.


### GetWidthOfItems(ImGuiStylePtr, params string[])

Calculates the text size and adds frame padding * 2 for each item provided.

```csharp title="C#"
public static float GetWidthOfItems(this ImGuiStylePtr style, params string[] items)
```

#### Parameters

`style` Hexa.NET.ImGui.ImGuiStylePtr  
The style object.

`items` [string[]](https://learn.microsoft.com/dotnet/api/system.string/)  
String values to calculate.

#### Returns

[float](https://learn.microsoft.com/dotnet/api/system.single/)  
The total size.