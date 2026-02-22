---
title: ImGuiSC.GlyphPickerPopup Class
slug: reference/hexa.net.imgui.sc.imguisc.glyphpickerpopup
sidebar:
  label: ImGuiSC.GlyphPickerPopup
editUrl: false
---
## Definition

```csharp title="C#"
public static class ImGuiSC.GlyphPickerPopup
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### Show(ImGuiRenderer, string, IFont, ImTextureID, Point, ref int)

```csharp title="C#"
public static bool Show(ImGuiRenderer renderer, string popupId, IFont font, ImTextureID fontTexture, Point fontTextureSize, ref int selectedGlyph)
```

#### Parameters

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`popupId` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`font` [IFont](../sadconsole.ifont/)  

`fontTexture` Hexa.NET.ImGui.ImTextureID  

`fontTextureSize` SadRogue.Primitives.Point  

`selectedGlyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)