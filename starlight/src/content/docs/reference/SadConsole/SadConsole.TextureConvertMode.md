---
title: TextureConvertMode Enum
slug: reference/sadconsole.textureconvertmode
sidebar:
  label: TextureConvertMode
---
## Definition

The conversion mode from [ITexture](../sadconsole.itexture/) to [ICellSurface](../sadconsole.icellsurface/).

```csharp title="C#"
public enum TextureConvertMode
```


## Fields

### Background

Fills the background of each cell with the pixel color.

```csharp title="C#"
Background = 0
```

### Foreground

Fills the foreground of each cell with the pixel color.

```csharp title="C#"
Foreground = 1
```