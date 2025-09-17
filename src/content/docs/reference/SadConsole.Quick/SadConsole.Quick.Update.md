---
title: Update Class
slug: reference/sadconsole.quick.update
sidebar:
  label: Update
---
## Definition

Adds logic extension methods for [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public static class Update
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### WithUpdate(IScreenObject, Action<IScreenObject, TimeSpan>)

Adds a keyboard handler to a [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public static IScreenObject WithUpdate(this IScreenObject screenObject, Action<IScreenObject, TimeSpan> handler)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

`handler` [Action\<IScreenObject, TimeSpan\>](https://learn.microsoft.com/dotnet/api/system.action-2/)  
The handler callback.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)

### RemoveUpdateHooks(IScreenObject)

Removes all of the keyboard hooks added with `SadConsole.Quick.Update.WithUpdate(SadConsole.IScreenObject%2cSystem.Action%7bSadConsole.IScreenObject%2cSystem.TimeSpan%7d)`.

```csharp title="C#"
public static IScreenObject RemoveUpdateHooks(this IScreenObject screenObject)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)

### RemoveUpdateHook(IScreenObject, Action<IScreenObject, TimeSpan>)

Removes the specified handler that was added with `SadConsole.Quick.Update.WithUpdate(SadConsole.IScreenObject%2cSystem.Action%7bSadConsole.IScreenObject%2cSystem.TimeSpan%7d)`.

```csharp title="C#"
public static IScreenObject RemoveUpdateHook(this IScreenObject screenObject, Action<IScreenObject, TimeSpan> handler)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

`handler` [Action\<IScreenObject, TimeSpan\>](https://learn.microsoft.com/dotnet/api/system.action-2/)  
The handler callback.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)