---
title: FocusedScreenObjectStack Class
slug: reference/sadconsole.focusedscreenobjectstack
sidebar:
  label: FocusedScreenObjectStack
---
## Definition

A stack of screen objects. The top-most of the stack is considered active and represented by the [IScreenObject](../sadconsole.iscreenobject/) property.

```csharp title="C#"
public class FocusedScreenObjectStack
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### FocusedScreenObjectStack()

Creates a new instance of the class.

```csharp title="C#"
public FocusedScreenObjectStack()
```


## Properties

### ScreenObject

Gets the current active screen object.

```csharp title="C#"
public IScreenObject? ScreenObject { get; }
```

## Methods

### Clear()

Clears all screen objects from the active stack along with the current active screen object.

```csharp title="C#"
public void Clear()
```


### Push(IScreenObject)

Adds another screen object to active stack, setting it as the active (top most in the stack) screen object.

```csharp title="C#"
public void Push(IScreenObject screenObject)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  


### Set(IScreenObject)

Replaces the top screen object (active screen object) with the provided instance. Sets [IScreenObject](../sadconsole.iscreenobject/) to this instance.

```csharp title="C#"
public void Set(IScreenObject screenObject)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The screen object to make active.


### Pop(IScreenObject)

Removes the screen object from the active stack. If the instance is the current active screen object, the active screen object is set to the last screen object in the previous screen object.

```csharp title="C#"
public void Pop(IScreenObject screenObject)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The screen object to remove.


### Pop()

Removes the top screen object from the stack.

```csharp title="C#"
public void Pop()
```