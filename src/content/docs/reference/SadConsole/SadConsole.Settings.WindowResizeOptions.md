---
title: Settings.WindowResizeOptions Enum
slug: reference/sadconsole.settings.windowresizeoptions
sidebar:
  label: Settings.WindowResizeOptions
---
## Definition

Resize modes for the final SadConsole render pass.

```csharp title="C#"
public enum Settings.WindowResizeOptions
```


## Fields

### Stretch

Stretches the output to fit the window.

```csharp title="C#"
Stretch = 0
```

### Center

Centers output in the window.

```csharp title="C#"
Center = 1
```

### Scale

Scales output to fit the window as best as possible while maintaining a good picture.

```csharp title="C#"
Scale = 2
```

### Fit

Fits output to the window using padding to maintain aspect ratio.

```csharp title="C#"
Fit = 3
```

### None

Output always matches the window.

```csharp title="C#"
None = 4
```