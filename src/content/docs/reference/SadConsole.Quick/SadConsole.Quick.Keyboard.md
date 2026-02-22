---
title: Keyboard Class
slug: reference/sadconsole.quick.keyboard
sidebar:
  label: Keyboard
editUrl: false
description: Adds keyboard-related extension methods for `SadConsole.IScreenObject`.
---
## Definition

Adds keyboard-related extension methods for [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public static class Keyboard
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### WithKeyboard(IScreenObject, Func\<IScreenObject, Keyboard, bool>)

Adds a keyboard handler to a [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public static IScreenObject WithKeyboard(this IScreenObject screenObject, Func<IScreenObject, Keyboard, bool> handler)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

`handler` [Func\<IScreenObject, Keyboard, bool\>](https://learn.microsoft.com/dotnet/api/system.func-3/)  
The handler callback.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)

### RemoveKeyboardHooks(IScreenObject)

Removes all of the keyboard hooks added with [WithKeyboard(IScreenObject, Func\<IScreenObject, Keyboard, bool\>)](../sadconsole.quick.keyboard/#withkeyboardiscreenobject-funciscreenobject-keyboard-bool).

```csharp title="C#"
public static IScreenObject RemoveKeyboardHooks(this IScreenObject screenObject)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)

### RemoveKeyboardHook(IScreenObject, Func\<IScreenObject, Keyboard, bool>)

Removes the specified handler that was added with [WithKeyboard(IScreenObject, Func\<IScreenObject, Keyboard, bool\>)](../sadconsole.quick.keyboard/#withkeyboardiscreenobject-funciscreenobject-keyboard-bool).

```csharp title="C#"
public static IScreenObject RemoveKeyboardHook(this IScreenObject screenObject, Func<IScreenObject, Keyboard, bool> handler)
```

#### Parameters

`screenObject` [IScreenObject](../sadconsole.iscreenobject/)  
The object to use.

`handler` [Func\<IScreenObject, Keyboard, bool\>](https://learn.microsoft.com/dotnet/api/system.func-3/)  
The handler callback.

#### Returns

[IScreenObject](../sadconsole.iscreenobject/)