---
title: ICellSurfaceResize Interface
slug: reference/sadconsole.icellsurfaceresize
sidebar:
  label: ICellSurfaceResize
editUrl: false
description: Adds a method to support resizing a surface.
---
## Definition

Adds a method to support resizing a surface.

```csharp title="C#"
public interface ICellSurfaceResize
```


## Methods

### Resize(int, int, int, int, bool)

Resizes the surface to the specified width and height. This can destroy the original backing array.

```csharp title="C#"
void Resize(int viewWidth, int viewHeight, int totalWidth, int totalHeight, bool clear)
```

#### Parameters

`viewWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable width of the surface.

`viewHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The viewable height of the surface.

`totalWidth` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum width of the surface.

`totalHeight` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The maximum height of the surface.

`clear` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates each cell should be reset to the default values.


### Resize(int, int, bool)

Resizes the surface and view to the specified width and height. This can destroy the original backing array.

```csharp title="C#"
void Resize(int width, int height, bool clear)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface and view.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface and view.

`clear` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates each cell should be reset to the default values.