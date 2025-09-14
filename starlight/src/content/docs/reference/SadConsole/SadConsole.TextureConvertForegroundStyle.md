---
title: TextureConvertForegroundStyle Enum
slug: reference/sadconsole.textureconvertforegroundstyle
sidebar:
  label: TextureConvertForegroundStyle
---
## Definition

The style applied when [Foreground](../sadconsole.textureconvertmode/#foreground/) is set.

```csharp title="C#"
public enum TextureConvertForegroundStyle
```


## Fields

### Block

Fills the surface with block ascii that represents the brightness of the pixel. Foreground is set to the pixel color.

```csharp title="C#"
Block = 0
```

### AsciiSymbol

Fills the surface with ascii symbols that represents the brightness of the pixel. Foreground is set to the pixel color.

```csharp title="C#"
AsciiSymbol = 1
```