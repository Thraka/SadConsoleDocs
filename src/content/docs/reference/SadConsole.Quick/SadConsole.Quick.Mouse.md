---
title: Mouse Class
slug: reference/sadconsole.quick.mouse
sidebar:
  label: Mouse
editUrl: false
description: Adds mouse-related extension methods for `SadConsole.IScreenObject`.
---
## Definition

Adds mouse-related extension methods for [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public static class Mouse
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### WithMouse(IScreenObject, Func\<IScreenObject, MouseScreenObjectState, bool>)

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

Removes all of the mouse hooks added with [WithMouse(IScreenObject, Func\<IScreenObject, MouseScreenObjectState, bool\>)](../sadconsole.quick.mouse/#withmouseiscreenobject-funciscreenobject-mousescreenobjectstate-bool).

```csharp title="C#"
public static IScreenObject RemoveMouseHooks(this IScreenObject screenObject)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)

### RemoveMouseHook(IScreenObject, Func\<IScreenObject, MouseScreenObjectState, bool>)

Removes the specified handler that was added with [WithMouse(IScreenObject, Func\<IScreenObject, MouseScreenObjectState, bool\>)](../sadconsole.quick.mouse/#withmouseiscreenobject-funciscreenobject-mousescreenobjectstate-bool).

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