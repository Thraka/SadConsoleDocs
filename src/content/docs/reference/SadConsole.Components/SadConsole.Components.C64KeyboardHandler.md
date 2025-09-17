---
title: C64KeyboardHandler Class
slug: reference/sadconsole.components.c64keyboardhandler
sidebar:
  label: C64KeyboardHandler
---
## Definition

A console prompt keyboard handler that acts like the text editor on the Commodore 64 and VIC-20 computers.

```csharp title="C#"
public class C64KeyboardHandler : KeyboardConsoleComponent, IComponent
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [KeyboardConsoleComponent](../sadconsole.components.keyboardconsolecomponent/)

Implements [IComponent](../sadconsole.components.icomponent/)
## Remarks

This handler lets the user move the cursor with the keyboard arrow keys. When the <kbd>ENTER</kbd> key is pressed, the current line is sent to the [EnterPressedAction](../sadconsole.components.c64keyboardhandler/#enterpressedaction/) callback. All empty characters are trimmed from the start and end of the string.

## Constructors

### C64KeyboardHandler(string)

Creates a new keyboard handler with the specified prompt.

```csharp title="C#"
public C64KeyboardHandler(string prompt)
```

#### Parameters

`prompt` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The prompt to display to the user.


## Fields

### EnterPressedAction

This is a callback for the owner of this keyboard handler. When it returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, the handler will print the prompt. The parameters are the component itself, the [Cursor](../sadconsole.components.cursor/) used by the handler, and the string input by the user. It's called when the user presses ENTER.

```csharp title="C#"
public Func<C64KeyboardHandler, Cursor, string, bool> EnterPressedAction
```

## Properties

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

The glyph used to replace the empty characters that may be in the string sent to [EnterPressedAction](../sadconsole.components.c64keyboardhandler/#enterpressedaction/).

```csharp title="C#"
public char ReplaceEmptyGlyph { get; set; }
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

Makes the cursor visible, disables word breaks and the string parser, and prints the prompt. If the host is a [Console](../sadconsole.console/), it uses the `SadConsole.Components.C64KeyboardHandler._attachedCursor` property, caching reference to it. You can't change the cursor reference unless you re-add this component. If the host is a [IScreenObject](../sadconsole.iscreenobject/), the first instance of a cursor in the [SadComponents](../sadconsole.components.icomponenthost/#sadcomponents/) collection is used. If there is no cursor, an exception is thrown.

### PrintPrompt()

Prints the prompt at the cursors current position.

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