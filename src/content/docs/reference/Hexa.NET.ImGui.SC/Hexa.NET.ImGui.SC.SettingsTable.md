---
title: SettingsTable Class
slug: reference/hexa.net.imgui.sc.settingstable
sidebar:
  label: SettingsTable
editUrl: false
---
## Definition

```csharp title="C#"
public static class SettingsTable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### BeginTable(string, ImGuiTableFlags, ImGuiTableColumnFlags, ImGuiTableColumnFlags)

```csharp title="C#"
public static bool BeginTable(string id, ImGuiTableFlags tableFlags = ImGuiTableFlags.None, ImGuiTableColumnFlags column1Flags = ImGuiTableColumnFlags.WidthStretch, ImGuiTableColumnFlags column2Flags = ImGuiTableColumnFlags.WidthStretch)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`tableFlags` Hexa.NET.ImGui.ImGuiTableFlags  

`column1Flags` Hexa.NET.ImGui.ImGuiTableColumnFlags  

`column2Flags` Hexa.NET.ImGui.ImGuiTableColumnFlags  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### EndTable()

```csharp title="C#"
public static void EndTable()
```


### DrawCommonSettings(bool, bool, bool, bool, bool, ref ColoredGlyphReference, Vector4?, Vector4?, IFont, ImGuiRenderer)

```csharp title="C#"
public static void DrawCommonSettings(bool showForeground, bool showBackground, bool showMirror, bool showGlyph, bool enableSwapForeBackRightClick, ref ColoredGlyphReference glyphRef, Vector4? foregroundResetColor, Vector4? backgroundResetColor, IFont font, ImGuiRenderer renderer)
```

#### Parameters

`showForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`showBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`showMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`showGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`enableSwapForeBackRightClick` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`glyphRef` [ColoredGlyphReference](../sadconsole.imguitypes.coloredglyphreference/)  

`foregroundResetColor` [Vector4?](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`backgroundResetColor` [Vector4?](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`font` [IFont](../sadconsole.ifont/)  

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  


### DrawCommonSettings(bool, bool, bool, bool, bool, ref Vector4, Vector4?, ref Vector4, Vector4?, ref Mirror, ref int, IFont, ImGuiRenderer)

```csharp title="C#"
public static void DrawCommonSettings(bool showForeground, bool showBackground, bool showMirror, bool showGlyph, bool enableSwapForeBackRightClick, ref Vector4 foreground, Vector4? foregroundResetColor, ref Vector4 background, Vector4? backgroundResetColor, ref Mirror mirror, ref int glyph, IFont font, ImGuiRenderer renderer)
```

#### Parameters

`showForeground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`showBackground` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`showMirror` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`showGlyph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`enableSwapForeBackRightClick` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`foreground` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`foregroundResetColor` [Vector4?](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`background` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`backgroundResetColor` [Vector4?](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`mirror` [Mirror](../sadconsole.imguitypes.mirror/)  

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`font` [IFont](../sadconsole.ifont/)  

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  


### DrawCheckbox(string, string, ref bool)

```csharp title="C#"
public static bool DrawCheckbox(string label, string id, ref bool isChecked)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`isChecked` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### DrawInt(string, string, ref int, int, int, int)

```csharp title="C#"
public static bool DrawInt(string label, string id, ref int intValue, int minValue = 0, int maxValue = -1, int width = -1)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`intValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`minValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`maxValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### DrawText(string, string, bool)

```csharp title="C#"
public static void DrawText(string label, string text, bool alignTextToFramePadding = true)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`alignTextToFramePadding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### DrawString(string, ref string, ulong)

```csharp title="C#"
public static bool DrawString(string label, ref string text, ulong maxLength)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`maxLength` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### DrawColor(string, string, ref Vector4, Vector4?, bool, out bool, ImGuiColorEditFlags)

```csharp title="C#"
public static bool DrawColor(string label, string id, ref Vector4 color, Vector4? resetColor, bool showPalette, out bool colorRightClicked, ImGuiColorEditFlags flags = ImGuiColorEditFlags.NoInputs | ImGuiColorEditFlags.AlphaPreviewHalf)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`color` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`resetColor` [Vector4?](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`showPalette` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`colorRightClicked` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`flags` Hexa.NET.ImGui.ImGuiColorEditFlags  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### DrawMirror(string, string, ref Mirror, int)

```csharp title="C#"
public static bool DrawMirror(string label, string id, ref Mirror mirror, int width = -1)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`mirror` [Mirror](../sadconsole.imguitypes.mirror/)  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### DrawFontGlyph(string, string, ref int, Vector4, Vector4, IFont, ImGuiRenderer)

```csharp title="C#"
public static bool DrawFontGlyph(string label, string id, ref int glyph, Vector4 glyphForeground, Vector4 glyphBackground, IFont font, ImGuiRenderer renderer)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`glyph` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`glyphForeground` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`glyphBackground` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`font` [IFont](../sadconsole.ifont/)  

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)