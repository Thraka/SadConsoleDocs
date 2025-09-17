---
title: DrawCallCustom Class
slug: reference/sadconsole.drawcalls.drawcallcustom
sidebar:
  label: DrawCallCustom
---
## Definition

A draw call that invokes an [Action](https://learn.microsoft.com/dotnet/api/system.action/) delegate.

```csharp title="C#"
public class DrawCallCustom : IDrawCall
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IDrawCall](../sadconsole.drawcalls.idrawcall/)

## Constructors

### DrawCallCustom(Action)

Creates a new instance of this object.

```csharp title="C#"
public DrawCallCustom(Action draw)
```

#### Parameters

`draw` [Action](https://learn.microsoft.com/dotnet/api/system.action/)  
The delegate to call when the draw call is drawn.


## Properties

### DrawCallback

The delegate to call.

```csharp title="C#"
public Action DrawCallback { get; set; }
```

## Methods

### Draw()

Invokes [DrawCallback](../sadconsole.drawcalls.drawcallcustom/#drawcallback/).

```csharp title="C#"
public void Draw()
```