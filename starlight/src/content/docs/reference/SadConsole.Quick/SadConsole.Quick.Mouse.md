---
title: Mouse Class
slug: reference/sadconsole.quick.mouse
sidebar:
  label: Mouse
---
## Definition

Adds mouse-related extension methods for [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public static class Mouse
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### WithMouse(IScreenObject, Func<IScreenObject, MouseScreenObjectState, bool>)

Adds a mouse handler to a [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public static IScreenObject WithMouse(this IScreenObject screenObject, Func<IScreenObject, MouseScreenObjectState, bool> handler)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

`handler` [Func\<IScreenObject, MouseScreenObjectState, bool\>](https://learn.microsoft.com/dotnet/api/system.func-3/)  
The handler callback.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)

### RemoveMouseHooks(IScreenObject)

Removes all of the mouse hooks added with `SadConsole.Quick.Mouse.WithMouse(SadConsole.IScreenObject%2cSystem.Func%7bSadConsole.IScreenObject%2cSadConsole.Input.MouseScreenObjectState%2cSystem.Boolean%7d)`.

```csharp title="C#"
public static IScreenObject RemoveMouseHooks(this IScreenObject screenObject)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)

### RemoveMouseHook(IScreenObject, Func<IScreenObject, MouseScreenObjectState, bool>)

Removes the specified handler that was added with `SadConsole.Quick.Mouse.WithMouse(SadConsole.IScreenObject%2cSystem.Func%7bSadConsole.IScreenObject%2cSadConsole.Input.MouseScreenObjectState%2cSystem.Boolean%7d)`.

```csharp title="C#"
public static IScreenObject RemoveMouseHook(this IScreenObject screenObject, Func<IScreenObject, MouseScreenObjectState, bool> handler)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

`handler` [Func\<IScreenObject, MouseScreenObjectState, bool\>](https://learn.microsoft.com/dotnet/api/system.func-3/)  
The handler callback.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)