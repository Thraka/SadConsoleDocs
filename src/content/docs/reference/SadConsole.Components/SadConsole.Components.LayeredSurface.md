---
title: LayeredSurface Class
slug: reference/sadconsole.components.layeredsurface
sidebar:
  label: LayeredSurface
editUrl: false
description: Manages a set of surface layers.
---
## Definition

Manages a set of surface layers.

```csharp title="C#"
[DataContract]
public class LayeredSurface : UpdateComponent, IComponent, IList<ICellSurface>, ICollection<ICellSurface>, IEnumerable<ICellSurface>, IEnumerable, ICellSurfaceResize
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [UpdateComponent](../sadconsole.components.updatecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/), [IList\<ICellSurface\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1/), [ICollection\<ICellSurface\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1/), [IEnumerable\<ICellSurface\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/), [ICellSurfaceResize](../sadconsole.icellsurfaceresize/)

## Constructors

### LayeredSurface()

```csharp title="C#"
public LayeredSurface()
```


## Fields

### _screen

The parent screen hosting this component.

```csharp title="C#"
protected IScreenSurface? _screen
```

### _screenCachedView

A cached copy of the [View](../sadconsole.icellsurface/#view) of the hosting screen surface.

```csharp title="C#"
protected Rectangle _screenCachedView
```

### _layers

The layers.

```csharp title="C#"
[DataMember(Name = "Layers")]
protected List<ICellSurface> _layers
```

### RenderStep

Internal use only

```csharp title="C#"
public IRenderStep? RenderStep
```

## Properties

### IsAttached

Indicates that the entity renderer has been added to a parent object.

```csharp title="C#"
protected bool IsAttached { get; set; }
```

### View

The visible portion of the surface layers.

```csharp title="C#"
public Rectangle View { get; set; }
```

### DefaultBackground

The default color to clear the rendering surface. This is used instead of the individual layer's default background.

```csharp title="C#"
public Color DefaultBackground { get; set; }
```

### Count

The numbers of layers.

```csharp title="C#"
public int Count { get; }
```

### IsReadOnly

Always returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool IsReadOnly { get; }
```

### this[int]

Gets or sets a layer by index.

```csharp title="C#"
public ICellSurface this[int index] { get; set; }
```

## Methods

### Add(ICellSurface)

Adds a layer to this component.

```csharp title="C#"
public void Add(ICellSurface layer)
```

#### Parameters

`layer` [ICellSurface](../sadconsole.icellsurface/)  
The layer to add.


### AddRange(IEnumerable\<ICellSurface>)

Adds a collection if layers to this component.

```csharp title="C#"
public void AddRange(IEnumerable<ICellSurface> layers)
```

#### Parameters

`layers` [IEnumerable\<ICellSurface\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  
The layers to add.


### Replace(ICellSurface, ICellSurface)

Replaces a layer with a new instance.

```csharp title="C#"
public void Replace(ICellSurface oldLayer, ICellSurface newLayer)
```

#### Parameters

`oldLayer` [ICellSurface](../sadconsole.icellsurface/)  
The layer to remove.

`newLayer` [ICellSurface](../sadconsole.icellsurface/)  
The layer to add.

#### Exceptions

[ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception/)  
<p>Thrown when the old layer doesn't exist in this collection.</p> <p>- or -</p> <p>Thrown when the new layer already exists in this collection.</p> <p>- or -</p> <p>Thrown when the new layer isn't the same size as the other layers.</p>


### Remove(ICellSurface)

Removes a layer from this component.

```csharp title="C#"
public bool Remove(ICellSurface layer)
```

#### Parameters

`layer` [ICellSurface](../sadconsole.icellsurface/)  
The layer to remove.

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### IndexOf(ICellSurface)

Returns the index of the specified layer.

```csharp title="C#"
public int IndexOf(ICellSurface layer)
```

#### Parameters

`layer` [ICellSurface](../sadconsole.icellsurface/)  
The layer to search for.

#### Returns

[int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the layer.

### Insert(int, ICellSurface)

Inserts the layer at the specified index.

```csharp title="C#"
public void Insert(int index, ICellSurface layer)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index to insert at.

`layer` [ICellSurface](../sadconsole.icellsurface/)  
The layer to insert.


### RemoveAt(int)

Removes a layer at the specified index.

```csharp title="C#"
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The index of the layer to remove.


### Clear()

Removes all layers.

```csharp title="C#"
public void Clear()
```


### Clear(ICellSurface)

Removes all layers and adds the `initialLayer` parameter as the first layer.

```csharp title="C#"
public void Clear(ICellSurface initialLayer)
```

#### Parameters

`initialLayer` [ICellSurface](../sadconsole.icellsurface/)  
The new first layer.


### Contains(ICellSurface)

```csharp title="C#"
public bool Contains(ICellSurface layer)
```

#### Parameters

`layer` [ICellSurface](../sadconsole.icellsurface/)  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### CopyTo(ICellSurface[], int)

```csharp title="C#"
public void CopyTo(ICellSurface[] array, int arrayIndex)
```

#### Parameters

`array` [ICellSurface[]](../sadconsole.icellsurface/)  

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  


### GetEnumerator()

```csharp title="C#"
public IEnumerator<ICellSurface> GetEnumerator()
```

#### Returns

[IEnumerator\<ICellSurface\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)

### Create()

Adds a new layer. The layer is based on the first layer's width and height.

```csharp title="C#"
public CellSurface Create()
```

#### Returns

[CellSurface](../sadconsole.cellsurface/)
#### Exceptions

[Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  


### Resize(int, int, int, int, bool)

Resizes each layer to the specified width and height.

```csharp title="C#"
public void Resize(int viewWidth, int viewHeight, int totalWidth, int totalHeight, bool clear)
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
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, resets every cell to the [DefaultForeground](../sadconsole.icellsurface/#defaultforeground), [DefaultBackground](../sadconsole.icellsurface/#defaultbackground) and glyph 0.


### Resize(int, int, bool)

Resizes the surface and view to the specified width and height.

```csharp title="C#"
public void Resize(int width, int height, bool clear)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the surface and view.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The height of the surface and view.

`clear` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, resets every cell to the [DefaultForeground](../sadconsole.icellsurface/#defaultforeground), [DefaultBackground](../sadconsole.icellsurface/#defaultbackground) and glyph 0.


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


### Update(IScreenObject, TimeSpan)

Called by a host on the update frame.

```csharp title="C#"
public override void Update(IScreenObject host, TimeSpan delta)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host calling the component.

`delta` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan/)  
The time that has elapsed since this method was last called.