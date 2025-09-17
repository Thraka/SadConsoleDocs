---
title: Settings Class
slug: reference/sadconsole.settings
sidebar:
  label: Settings
---
## Definition

Various settings for SadConsole.

```csharp title="C#"
public static class Settings
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Fields

### DefaultConsoleUseKeyboard

Gets and sets the default value for [UseKeyboard](../sadconsole.iscreenobject/#usekeyboard/) when the console is created.

```csharp title="C#"
public static bool DefaultConsoleUseKeyboard
```

### DefaultScreenObjectUseKeyboard

Gets and sets the default value for [UseKeyboard](../sadconsole.screenobject/#usekeyboard/).

```csharp title="C#"
public static bool DefaultScreenObjectUseKeyboard
```

### DefaultScreenObjectUseMouse

Gets and sets the default value for [UseMouse](../sadconsole.screenobject/#usemouse/).

```csharp title="C#"
public static bool DefaultScreenObjectUseMouse
```

### ClearColor

The color to automatically clear the device with.

```csharp title="C#"
public static Color ClearColor
```

### ResizeMode

The type of resizing options for the window.

```csharp title="C#"
public static Settings.WindowResizeOptions ResizeMode
```

### AllowWindowResize

Allow the user to resize the window. Must be set before the game is created.

```csharp title="C#"
public static bool AllowWindowResize
```

### DoDraw

When true, indicates that the game loop should call [Render(TimeSpan)](../sadconsole.iscreenobject/#/) on each object in [Screen](../sadconsole.gamehost/#screen/).

```csharp title="C#"
public static bool DoDraw
```

### DoFinalDraw

When true, indicates that any game framework should render a composed image, of all consoles, to the screen.

```csharp title="C#"
public static bool DoFinalDraw
```

### DoUpdate

When true, indicates that the game loop should call [Update(TimeSpan)](../sadconsole.iscreenobject/#/) on each object in [Screen](../sadconsole.gamehost/#screen/).

```csharp title="C#"
public static bool DoUpdate
```

## Properties

### WindowMinimumSize

When not set to (0,0) this property specifies the minimum size of the game window in pixels.

```csharp title="C#"
public static Point WindowMinimumSize { get; set; }
```

### SerializationIsCompressed

When set to true, all loading and saving performed by SadConsole uses GZIP. [LoadFont(string)](../sadconsole.gamehost/#/) does not use this setting and always runs uncompressed.

```csharp title="C#"
public static bool SerializationIsCompressed { get; set; }
```

### UseDefaultExtendedFont

When set to true, and a font is not specified with the [GameHost](../sadconsole.gamehost/), the IBM 8x16 extended SadConsole font will be used.

```csharp title="C#"
public static bool UseDefaultExtendedFont { get; set; }
```

### WindowTitle

The window title to display when the app is windowed.

```csharp title="C#"
public static string WindowTitle { get; set; }
```

### DebuggerPipeId

The identifier of the named pipe used to communicate with the in game debugger app.

```csharp title="C#"
public static string DebuggerPipeId { get; }
```

### AutomaticAddColorsToMappings

Automatically adds all of the static color declarations of `SadRogue.Primitives.Color` to [ColorMappings](../sadrogue.primitives.colorextensions2/#colormappings/).

```csharp title="C#"
public static bool AutomaticAddColorsToMappings { get; set; }
```