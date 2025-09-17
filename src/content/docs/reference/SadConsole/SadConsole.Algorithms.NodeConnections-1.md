---
title: Algorithms.NodeConnections<TNode> Class
slug: reference/sadconsole.algorithms.nodeconnections-1
sidebar:
  label: Algorithms.NodeConnections<TNode>
---
## Definition

Describes the 4-way connections of a node.

```csharp title="C#"
public class Algorithms.NodeConnections<TNode>
```

### Type Parameters

`TNode`  
The type of object the node and its connections are.

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### NodeConnections(TNode, TNode, TNode, TNode, bool, bool, bool, bool)

Creates a new instance of this object with the specified connections.

```csharp title="C#"
public NodeConnections(TNode west, TNode east, TNode north, TNode south, bool isWest, bool isEast, bool isNorth, bool isSouth)
```

#### Parameters

`west` TNode  
The west connection.

`east` TNode  
The east connection.

`north` TNode  
The north connection.

`south` TNode  
The south connection.

`isWest` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the <xref href="SadConsole.Algorithms.NodeConnections%601.West" data-throw-if-not-resolved="false"></xref> connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

`isEast` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the <xref href="SadConsole.Algorithms.NodeConnections%601.East" data-throw-if-not-resolved="false"></xref> connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

`isNorth` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the <xref href="SadConsole.Algorithms.NodeConnections%601.North" data-throw-if-not-resolved="false"></xref> connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

`isSouth` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the <xref href="SadConsole.Algorithms.NodeConnections%601.South" data-throw-if-not-resolved="false"></xref> connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.


### NodeConnections()

Creates a new instance of this object with all connections set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

```csharp title="C#"
public NodeConnections()
```


## Fields

### West

The west or left node.

```csharp title="C#"
public TNode? West
```

### East

The east or right node.

```csharp title="C#"
public TNode? East
```

### North

The north or up node.

```csharp title="C#"
public TNode? North
```

### South

The south or down node.

```csharp title="C#"
public TNode? South
```

### HasWest

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the [West](../sadconsole.algorithms.nodeconnections-1/#west/) connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasWest
```

### HasEast

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the [East](../sadconsole.algorithms.nodeconnections-1/#east/) connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasEast
```

### HasNorth

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the [North](../sadconsole.algorithms.nodeconnections-1/#north/) connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasNorth
```

### HasSouth

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> indicates the [South](../sadconsole.algorithms.nodeconnections-1/#south/) connection is valid; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HasSouth
```