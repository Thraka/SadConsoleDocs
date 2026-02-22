---
title: SadConsole.Components
slug: reference/sadconsole.components
sidebar:
  order: 0
editUrl: false
---
## Classes

| | |
| --- | --- |
| [C64KeyboardHandler](../sadconsole.components.c64keyboardhandler/) | A console prompt keyboard handler that acts like the text editor on the Commodore 64 and VIC-20 computers. |
| [ClassicConsoleKeyboardHandler](../sadconsole.components.classicconsolekeyboardhandler/) | A classic console/terminal prompt keyboard handler. |
| [CoroutineHandlerComponent](../sadconsole.components.coroutinehandlercomponent/) | An implementation of ``Coroutine.CoroutineHandlerInstance`` that calls [Tick(TimeSpan)](https://learn.microsoft.com/dotnet/api/system.timespan/) every time [Update(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#updateiscreenobject-timespan) is called. |
| [Cursor](../sadconsole.components.cursor/) | A cursor that is attached to a [Console](../sadconsole.console/) used for printing. |
| [DebugFocusedObjectTint](../sadconsole.components.debugfocusedobjecttint/) | Tints a surface when that surface is focused. Helps debug which object is focused in [FocusedScreenObjects](../sadconsole.gamehost/#focusedscreenobjects). |
| [DebugMouseTint](../sadconsole.components.debugmousetint/) | Tints a surface when that surface would use the mouse. Helps debug which object is receiving mouse input as you move the mouse around. |
| [DrawImage](../sadconsole.components.drawimage/) | Draws an image on top of a console. |
| [InputConsoleComponent](../sadconsole.components.inputconsolecomponent/) | A base class that implements [ProcessMouse(IScreenObject, MouseScreenObjectState, out bool)](../sadconsole.components.icomponent/#processmouseiscreenobject-mousescreenobjectstate-out-bool) and [ProcessKeyboard(IScreenObject, Keyboard, out bool)](../sadconsole.components.icomponent/#processkeyboardiscreenobject-keyboard-out-bool) of [IComponent](../sadconsole.components.icomponent/). |
| [KeyboardConsoleComponent](../sadconsole.components.keyboardconsolecomponent/) | A base class that implements [ProcessKeyboard(IScreenObject, Keyboard, out bool)](../sadconsole.components.icomponent/#processkeyboardiscreenobject-keyboard-out-bool) of [IComponent](../sadconsole.components.icomponent/). |
| [LayeredSurface](../sadconsole.components.layeredsurface/) | Manages a set of surface layers. |
| [LogicComponent](../sadconsole.components.logiccomponent/) | A base class that implements [Update(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#updateiscreenobject-timespan) and [Render(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#renderiscreenobject-timespan) of [IComponent](../sadconsole.components.icomponent/). |
| [MouseConsoleComponent](../sadconsole.components.mouseconsolecomponent/) | A base class that implements [ProcessMouse(IScreenObject, MouseScreenObjectState, out bool)](../sadconsole.components.icomponent/#processmouseiscreenobject-mousescreenobjectstate-out-bool) of [IComponent](../sadconsole.components.icomponent/). |
| [MouseDragViewPort](../sadconsole.components.mousedragviewport/) | Enables dragging a scrollable surface around by mouse. |
| [MoveViewPortKeyboardHandler](../sadconsole.components.moveviewportkeyboardhandler/) | Moves the view of an [IScreenSurface](../sadconsole.iscreensurface/) with a set of specified keyboard keys. |
| [ObjectComponentMove](../sadconsole.components.objectcomponentmove/) | Moves a [IScreenObject](../sadconsole.iscreenobject/) with the arrow keys. |
| [Overlay](../sadconsole.components.overlay/) | A surface that's rendered on top of a host surface. |
| [RenderComponent](../sadconsole.components.rendercomponent/) | A base class that implements [Render(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#renderiscreenobject-timespan) of [IComponent](../sadconsole.components.icomponent/). |
| [RootComponent](../sadconsole.components.rootcomponent/) | A component used only with [RootComponents](../sadconsole.gamehost/#rootcomponents). Runs logic before the [Screen](../sadconsole.gamehost/#screen) is processed. |
| [SmoothMove](../sadconsole.components.smoothmove/) | Animates the movement of an object. |
| [SurfaceComponentFollowTarget](../sadconsole.components.surfacecomponentfollowtarget/) | Add to a [IScreenSurface](../sadconsole.iscreensurface/) to have the [ViewPosition](../sadconsole.icellsurface/#viewposition) center on a specific object. |
| [Timer](../sadconsole.components.timer/) | A simple timer with callback. |
| [UpdateComponent](../sadconsole.components.updatecomponent/) | A base class that implements [Update(IScreenObject, TimeSpan)](../sadconsole.components.icomponent/#updateiscreenobject-timespan) of [IComponent](../sadconsole.components.icomponent/). |
## Interfaces

| | |
| --- | --- |
| [IComponent](../sadconsole.components.icomponent/) | A component that can be added to a [IScreenObject](../sadconsole.iscreenobject/). |
| [IComponentHost](../sadconsole.components.icomponenthost/) | Provides a collection of [IComponent](../sadconsole.components.icomponent/) objects. |
## Enums

| | |
| --- | --- |
| [DrawImage.PositionModes](../sadconsole.components.drawimage.positionmodes/) | Indicates how positioning is intepreted. |