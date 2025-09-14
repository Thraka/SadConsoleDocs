---
title: ClassicConsoleKeyboardHandler Class
slug: reference/sadconsole.components.classicconsolekeyboardhandler
sidebar:
  label: ClassicConsoleKeyboardHandler
---
## Definition

A classic console/terminal prompt keyboard handler.

```csharp title="C#"
public class ClassicConsoleKeyboardHandler : KeyboardConsoleComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [KeyboardConsoleComponent](../sadconsole.components.keyboardconsolecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)

## Constructors

### ClassicConsoleKeyboardHandler(string)

Creates the handler with the specified prompt.

```csharp title="C#"
public ClassicConsoleKeyboardHandler(string prompt = "> ")
```

#### Parameters

`prompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The prompt to display to the user.


## Fields

### EnterPressedAction

This is a callback for the owner of this keyboard handler. The parameters are the component itself, the [Cursor](../sadconsole.components.cursor/) used by the handler, and the string input by the user. It's called when the user presses ENTER.

```csharp title="C#"
public Action<ClassicConsoleKeyboardHandler, Cursor, string> EnterPressedAction
```

## Properties

### IsReady

A flag that when set to true prints a new line and the prompt.

```csharp title="C#"
public bool IsReady { get; set; }
```

### Prompt

The prompt to display to the user.

```csharp title="C#"
public string Prompt { get; set; }
```

### EraseGlyph

The glyph to print when erasing a character, such as when the backspace key is pressed to erase a character.

```csharp title="C#"
public char EraseGlyph { get; set; }
```

### ReplaceEmptyGlyph

The glyph used to replace the empty characters that may be in the string sent to [EnterPressedAction](../sadconsole.components.classicconsolekeyboardhandler/#enterpressedaction/).

```csharp title="C#"
public char ReplaceEmptyGlyph { get; set; }
```

### CursorLastY

This holds the row that the virtual cursor is starting from when someone is typing.

```csharp title="C#"
public int CursorLastY { get; set; }
```

## Methods

### OnAdded(IScreenObject)

Called when this component is added to an object with a cursor; caches reference to the cursor.

```csharp title="C#"
public override void OnAdded(IScreenObject host)
```

#### Parameters

`host` [IScreenObject](../sadconsole.iscreenobject/)  
The host object for the component.

#### Remarks

Makes the cursor visible, disables word breaks and the string parser, and prints the prompt. If the host is a [Console](../sadconsole.console/), it uses the `SadConsole.Components.ClassicConsoleKeyboardHandler._attachedCursor` property, caching reference to it. You can't change the cursor reference unless you re-add this component. If the host is a [IScreenObject](../sadconsole.iscreenobject/), the first instance of a cursor in the [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) collection is used. If there is no cursor, an exception is thrown.

### PrintPrompt()

Prints the prompt and locks the cursor to the column that ends at the prompt.

```csharp title="C#"
public void PrintPrompt()
```


### ProcessKeyboard(IScreenObject, Keyboard, out bool)

Called by a host when the keyboard is being processed.

```csharp title="C#"
public override void ProcessKeyboard(IScreenObject consoleObject, Keyboard info, out bool handled)
```

#### Parameters

`consoleObject` [IScreenObject](../sadconsole.iscreenobject/)  

`info` [Keyboard](../sadconsole.input.keyboard/)  

`handled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean/)  
When set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> informs the host caller that we handled the mouse and to stop others from handling.