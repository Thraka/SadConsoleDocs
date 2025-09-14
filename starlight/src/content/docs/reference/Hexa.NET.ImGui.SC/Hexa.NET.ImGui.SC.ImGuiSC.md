---
title: ImGuiSC Class
slug: reference/hexa.net.imgui.sc.imguisc
sidebar:
  label: ImGuiSC
---
## Definition

```csharp title="C#"
public static class ImGuiSC
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### Color_White

```csharp title="C#"
public static uint Color_White
```

### ZoomNormal

```csharp title="C#"
public static int ZoomNormal
```

### Zoom2x

```csharp title="C#"
public static int Zoom2x
```

### ZoomFit

```csharp title="C#"
public static int ZoomFit
```

## Methods

### DrawTexture(string, bool, int, Texture2D, ImGuiRenderer, out bool, out bool)

```csharp title="C#"
public static void DrawTexture(string id, bool border, int zoomMode, Texture2D texture, ImGuiRenderer renderer, out bool isItemActive, out bool isItemHovered)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`border` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`zoomMode` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`isItemActive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`isItemHovered` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### DrawTexture(string, bool, int, Texture2D, Vector2, ImGuiRenderer, out bool, out bool)

```csharp title="C#"
public static void DrawTexture(string id, bool border, int zoomMode, Texture2D texture, Vector2 region, ImGuiRenderer renderer, out bool isItemActive, out bool isItemHovered)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`border` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`zoomMode` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  

`region` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

`isItemActive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`isItemHovered` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### DrawTexture(string, bool, int, ImTextureID, Vector2, out bool, out bool)

```csharp title="C#"
public static void DrawTexture(string id, bool border, int zoomMode, ImTextureID texture, Vector2 textureSize, out bool isItemActive, out bool isItemHovered)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`border` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`zoomMode` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`texture` Hexa.NET.ImGui.ImTextureID  

`textureSize` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`isItemActive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`isItemHovered` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### DrawTexture(string, bool, int, ImTextureID, Vector2, Vector2, out bool, out bool)

```csharp title="C#"
public static void DrawTexture(string id, bool border, int zoomMode, ImTextureID texture, Vector2 textureSize, Vector2 region, out bool isItemActive, out bool isItemHovered)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`border` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`zoomMode` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`texture` Hexa.NET.ImGui.ImTextureID  

`textureSize` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`region` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`isItemActive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  

`isItemHovered` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  


### BeginGroupPanel(string)

```csharp title="C#"
public static void BeginGroupPanel(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### BeginGroupPanel(string, Vector2)

```csharp title="C#"
public static void BeginGroupPanel(string name, Vector2 size)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  


### EndGroupPanel()

```csharp title="C#"
public static void EndGroupPanel()
```


### BeginGroupPanel1(string)

```csharp title="C#"
public static void BeginGroupPanel1(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### BeginGroupPanel1(string, Vector2)

```csharp title="C#"
public static void BeginGroupPanel1(string name, Vector2 size)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  


### EndGroupPanel1()

```csharp title="C#"
public static void EndGroupPanel1()
```


### SeparatorText(string, Vector4)

```csharp title="C#"
public static void SeparatorText(string label, Vector4 color)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`color` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  


### SeparatorLabel(string)

```csharp title="C#"
public static void SeparatorLabel(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### SeparatorLabel(string, Vector4)

```csharp title="C#"
public static void SeparatorLabel(string text, Vector4 barColor)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`barColor` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  


### SeparatorLabel(string, Color)

```csharp title="C#"
public static void SeparatorLabel(string text, Color barColor)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`barColor` SadRogue.Primitives.Color  


### SeparatorLabel(string, Vector4, Vector4)

```csharp title="C#"
public static void SeparatorLabel(string text, Vector4 barColor, Vector4 textColor)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`barColor` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  

`textColor` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4/)  


### SeparatorLabel(string, Color, Color)

```csharp title="C#"
public static void SeparatorLabel(string text, Color barColor, Color textColor)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`barColor` SadRogue.Primitives.Color  

`textColor` SadRogue.Primitives.Color  


### ScrollableSurface(string, IScreenSurface, out Point, ImGuiRenderer)

```csharp title="C#"
public static bool ScrollableSurface(string id, IScreenSurface Surface, out Point hoveredCellPosition, ImGuiRenderer renderer)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`Surface` [IScreenSurface](../sadconsole.iscreensurface/)  

`hoveredCellPosition` SadRogue.Primitives.Point  

`renderer` [ImGuiRenderer](../sadconsole.imguisystem.imguirenderer/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### VSliderIntNudges(string, Vector2, ref int, int, int)

```csharp title="C#"
public static bool VSliderIntNudges(string label, Vector2 size, ref int v, int v_min, int v_max)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`v` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_min` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_max` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### VSliderIntNudges(string, Vector2, ref int, int, int, ImGuiSliderFlags)

```csharp title="C#"
public static bool VSliderIntNudges(string label, Vector2 size, ref int v, int v_min, int v_max, ImGuiSliderFlags flags)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`v` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_min` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_max` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`flags` Hexa.NET.ImGui.ImGuiSliderFlags  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### VSliderIntNudges(string, Vector2, ref int, int, int, string, ImGuiSliderFlags)

```csharp title="C#"
public static bool VSliderIntNudges(string label, Vector2 size, ref int v, int v_min, int v_max, string fmt, ImGuiSliderFlags flags)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2/)  

`v` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_min` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_max` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`fmt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`flags` Hexa.NET.ImGui.ImGuiSliderFlags  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### SliderIntNudges(string, int, ref int, int, int)

```csharp title="C#"
public static bool SliderIntNudges(string label, int width, ref int v, int v_min, int v_max)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_min` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_max` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### SliderIntNudges(string, int, ref int, int, int, ImGuiSliderFlags)

```csharp title="C#"
public static bool SliderIntNudges(string label, int width, ref int v, int v_min, int v_max, ImGuiSliderFlags flags)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_min` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_max` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`flags` Hexa.NET.ImGui.ImGuiSliderFlags  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### SliderIntNudges(string, int, ref int, int, int, string, ImGuiSliderFlags)

```csharp title="C#"
public static bool SliderIntNudges(string label, int width, ref int v, int v_min, int v_max, string fmt, ImGuiSliderFlags flags)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_min` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`v_max` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`fmt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`flags` Hexa.NET.ImGui.ImGuiSliderFlags  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### InputText(string, string)

```csharp title="C#"
public static string InputText(string label, string value)
```

#### Parameters

`label` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)

### CenterNextWindow()

```csharp title="C#"
public static void CenterNextWindow()
```


### XYEditPopup(string, ref int, ref int, string, string, int)

```csharp title="C#"
public static bool XYEditPopup(string id, ref int xValue, ref int yValue, string xText, string yText, int inputWidth = 100)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`xValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`yValue` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

`xText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`yText` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`inputWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)