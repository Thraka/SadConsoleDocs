---
title: Algorithms Class
slug: reference/sadconsole.algorithms
sidebar:
  label: Algorithms
editUrl: false
description: Provides a few minor helper methods related to filling.
---
## Definition

Provides a few minor helper methods related to filling.

```csharp title="C#"
public static class Algorithms
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### FloodFill\<TNode>(TNode, Func\<TNode, bool>, Action\<TNode>, Func\<TNode, NodeConnections\<TNode>>)

A very slow 4-way fill algorithm to change items from one type to another.

```csharp title="C#"
public static void FloodFill<TNode>(TNode node, Func<TNode, bool> shouldNodeChange, Action<TNode> changeNode, Func<TNode, Algorithms.NodeConnections<TNode>> getNodeConnections)
```

#### Parameters

`node` TNode  
The item to change.

`shouldNodeChange` [Func\<TNode, bool\>](https://learn.microsoft.com/dotnet/api/system.func-2/)  
Determines if the node should change.

`changeNode` [Action\<TNode\>](https://learn.microsoft.com/dotnet/api/system.action-1/)  
After it is determined if the node should change, this changes the node.

`getNodeConnections` [Func\<TNode, Algorithms.NodeConnections\<TNode\>\>](https://learn.microsoft.com/dotnet/api/system.func-2/)  
Gets any other nodes connected to this node.


### GradientFill(Point, Point, int, int, Rectangle, Gradient, Action\<int, int, Color>)

Processes an area and applies a gradient calculation to each part of the area.

```csharp title="C#"
public static void GradientFill(Point cellSize, Point position, int strength, int angle, Rectangle area, Gradient gradient, Action<int, int, Color> applyAction)
```

#### Parameters

`cellSize` SadRogue.Primitives.Point  
The size of an individual cell. Makes the angle uniform.

`position` SadRogue.Primitives.Point  
The center of the gradient.

`strength` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The width of the gradient spread.

`angle` [int](https://learn.microsoft.com/dotnet/api/system.int32/)  
The angle to apply the gradient.

`area` SadRogue.Primitives.Rectangle  
The area to calculate.

`gradient` SadRogue.Primitives.Gradient  
The color gradient to fill with.

`applyAction` [Action\<int, int, Color\>](https://learn.microsoft.com/dotnet/api/system.action-3/)  
The callback called for each part of the area.