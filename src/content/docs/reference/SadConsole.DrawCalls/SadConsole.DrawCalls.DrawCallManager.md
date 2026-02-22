---
title: DrawCallManager Class
slug: reference/sadconsole.drawcalls.drawcallmanager
sidebar:
  label: DrawCallManager
editUrl: false
description: Helps manage the `SadConsole.Host.Global.SharedSpriteBatch` while draw calls are drawing.
---
## Definition

Helps manage the [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch) while draw calls are drawing.

```csharp title="C#"
public static class DrawCallManager
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### ResumeBatch(bool)

Resumes rendering to [RenderOutput](../sadconsole.host.global/#renderoutput) with SadConsole's default settings.

```csharp title="C#"
public static void ResumeBatch(bool skipSetRenderTarget = false)
```

#### Parameters

`skipSetRenderTarget` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When true, skips assinging [RenderOutput](../sadconsole.host.global/#renderoutput) as the render target.


### InterruptBatch()

Ends the [SharedSpriteBatch](../sadconsole.host.global/#sharedspritebatch) so another can be started, perhaps with an effect.

```csharp title="C#"
public static void InterruptBatch()
```