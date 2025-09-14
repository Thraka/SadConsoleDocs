---
title: DrawImage Class
slug: reference/sadconsole.components.drawimage
sidebar:
  label: DrawImage
---
## Definition

Draws an image on top of a console.

```csharp title="C#"
public class DrawImage : RenderComponent, IComponent, IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [RenderComponent](../sadconsole.components.rendercomponent/)

Implements [IComponent](../sadconsole.components.icomponent/), [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### DrawImage(string)

Creates a new component with the specified image.

```csharp title="C#"
public DrawImage(string filePath)
```

#### Parameters

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Relative path to the image.


### DrawImage(Texture2D)

Creates a new component with the specified image.

```csharp title="C#"
public DrawImage(Texture2D texture)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  
The texture to use


## Properties

### PositionMode

Sets or gets how the [PositionOffset](../sadconsole.components.drawimage/#positionoffset/) property is interpreted.

```csharp title="C#"
public DrawImage.PositionModes PositionMode { get; set; }
```

### PositionOffset

The positioning offset.

```csharp title="C#"
public Point PositionOffset { get; set; }
```
## Remarks

The position the image is displayed is based on the hosting console's position. This property adjusts the position of the image by the specified amount.

## Methods

### ~DrawImage()

Calls [Dispose()](../sadconsole.components.drawimage/#dispose/).

```csharp title="C#"
protected ~DrawImage()
```


### OnAdded(IScreenObject)

Called when the component is added to a host.

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that added the component.


### OnRemoved(IScreenObject)

Called when the component is removed from the host.

```csharp title="C#"
public override void OnRemoved(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host that removed the component.


### Render(IScreenObject, TimeSpan)

Draws the image.

```csharp title="C#"
public override void Render(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host of the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
Unused.


### Dispose()

Disposes the image.

```csharp title="C#"
public void Dispose()
```