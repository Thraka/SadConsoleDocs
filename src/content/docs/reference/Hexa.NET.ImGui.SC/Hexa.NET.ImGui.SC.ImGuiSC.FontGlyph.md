---
title: ImGuiSC.FontGlyph Class
slug: reference/hexa.net.imgui.sc.imguisc.fontglyph
sidebar:
  label: ImGuiSC.FontGlyph
---
## Definition

```csharp title="C#"
public static class ImGuiSC.FontGlyph
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### DrawWithPopup(ImGuiRenderer, string, string, IFont, Vector4, Vector4, ref int, bool)

```csharp title="C#"
public static bool DrawWithPopup(ImGuiRenderer renderer, string id, string popupId, IFont font, Vector4 foreground, Vector4 background, ref int selectedGlyph, bool showNumber)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`popupId` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`font` [IFont](../sadconsole.ifont/)  

`foreground` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`background` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`selectedGlyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`showNumber` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### Draw(ImGuiRenderer, string, IFont, ColoredGlyph)

```csharp title="C#"
public static void Draw(ImGuiRenderer renderer, string id, IFont font, ColoredGlyph glyph)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`font` [IFont](../sadconsole.ifont/)  

`glyph` [ColoredGlyph](../sadconsole.coloredglyph/)  


### Draw(ImGuiRenderer, string, IFont, Vector4, Vector4, int)

```csharp title="C#"
public static void Draw(ImGuiRenderer renderer, string id, IFont font, Vector4 foreground, Vector4 background, int glyph)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`font` [IFont](../sadconsole.ifont/)  

`foreground` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`background` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)