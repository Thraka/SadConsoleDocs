---
title: TextureConvertBackgroundStyle Enum
slug: reference/sadconsole.textureconvertbackgroundstyle
sidebar:
  label: TextureConvertBackgroundStyle
---
## Definition

The style applied when [Background](../sadconsole.textureconvertmode/#background/) is set.

```csharp title="C#"
public enum TextureConvertBackgroundStyle
```


## Fields

### Pixel

Simply resizes the image and maps the cell to the pixel without any other color conversion.

```csharp title="C#"
Pixel = 0
```

### Smooth

Calculates the cell color based on the surrounding colors of the image.

```csharp title="C#"
Smooth = 1
```