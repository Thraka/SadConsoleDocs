---
title: SadConsole
slug: reference/sadconsole
sidebar:
  order: 0
---
## Classes

| | |
| --- | --- |
| [Algorithms](../sadconsole.algorithms/) | Provides a few minor helper methods related to filling. |
| [Algorithms.NodeConnections<TNode>\<TNode\>](../sadconsole.algorithms.nodeconnections-1/) | Describes the 4-way connections of a node. |
| [AnimatedScreenObject](../sadconsole.animatedscreenobject/) | A [ScreenObject](../sadconsole.screenobject/) that displays an animated set of [ICellSurface](../sadconsole.icellsurface/) surfaces. |
| [AnimatedScreenObject.AnimationStateChangedEventArgs](../sadconsole.animatedscreenobject.animationstatechangedeventargs/) | Event args for when the animation state changes |
| [CellDecoratorHelpers](../sadconsole.celldecoratorhelpers/) | Helpers for [CellDecorator](../sadconsole.celldecorator/) and [Decorators](../sadconsole.coloredglyphbase/#decorators/) which manages null on the property. |
| [CellSurface](../sadconsole.cellsurface/) | An array of [ColoredGlyphBase](../sadconsole.coloredglyphbase/) objects used to represent a 2D surface. |
| [CellSurfaceEditor](../sadconsole.cellsurfaceeditor/) | Methods to interact with a [ICellSurface](../sadconsole.icellsurface/). |
| [ColoredGlyph](../sadconsole.coloredglyph/) | Represents an individual piece of a [ICellSurface](../sadconsole.icellsurface/) containing a glyph, foreground color, background color, and a mirror effect. |
| [ColoredGlyphAndEffect](../sadconsole.coloredglyphandeffect/) | A [ColoredGlyphBase](../sadconsole.coloredglyphbase/) with a [ICellEffect](../sadconsole.effects.icelleffect/). |
| [ColoredGlyphBase](../sadconsole.coloredglyphbase/) | Represents an individual piece of a [ICellSurface](../sadconsole.icellsurface/) containing a glyph, foreground color, background color, and a mirror effect. |
| [ColoredString](../sadconsole.coloredstring/) | Represents a string that has foreground and background colors for each character in the string. |
| [Console](../sadconsole.console/) | A surface that has a cursor. |
| [ExtendedLib_StringExtensions2](../sadconsole.extendedlib_stringextensions2/) | Extensions for the [string](https://learn.microsoft.com/dotnet/api/system.string/) type. |
| [ExtendedLib_SurfaceExtensions](../sadconsole.extendedlib_surfaceextensions/) | Extensions for the [IScreenSurface](../sadconsole.iscreensurface/) type |
| [ExtensionsSystem](../sadconsole.extensionssystem/) |  |
| [FocusedScreenObjectStack](../sadconsole.focusedscreenobjectstack/) | A stack of screen objects. The top-most of the stack is considered active and represented by the [IScreenObject](../sadconsole.iscreenobject/) property. |
| [FontExtensions](../sadconsole.fontextensions/) | Extensions for [IFont](../sadconsole.ifont/). |
| [Game](../sadconsole.game/) | The MonoGame implementation of the SadConsole Game Host. |
| [GameHost](../sadconsole.gamehost/) | Represents the SadConsole game engine. |
| [HandledEventArgs](../sadconsole.handledeventargs/) | Event args that allow a handled flag to be set. |
| [Helpers](../sadconsole.helpers/) | General code helpers. |
| [LayeredScreenSurface](../sadconsole.layeredscreensurface/) | A basic console that can contain controls. |
| [MonoGame_MirrorExtensions](../sadconsole.monogame_mirrorextensions/) | Extensions for [Mirror](../sadconsole.mirror/). |
| [PointExtensions](../sadconsole.pointextensions/) | Extensions for the `SadRogue.Primitives.Point` type. |
| [RectangleExtensions](../sadconsole.rectangleextensions/) | Extensions for the `SadRogue.Primitives.Rectangle` type. |
| [SadFont](../sadconsole.sadfont/) | Represents a graphical font used by SadConsole. |
| [ScreenObject](../sadconsole.screenobject/) | A generic object processed by SadConsole. Provides parent/child, components, and position. |
| [ScreenObjectCollection](../sadconsole.screenobjectcollection/) | Manages the parent and children relationship for [IScreenObject](../sadconsole.iscreenobject/). |
| [ScreenObjectCollection<TScreenObject>\<TScreenObject\>](../sadconsole.screenobjectcollection-1/) | Manages the parent and children relationship for [IScreenObject](../sadconsole.iscreenobject/). |
| [ScreenObjectComparer](../sadconsole.screenobjectcomparer/) | Compares [IScreenObject](../sadconsole.iscreenobject/) with the [SortOrder](../sadconsole.iscreenobject/#sortorder/) property. |
| [ScreenSurface](../sadconsole.screensurface/) | An object that renders a [ICellSurface](../sadconsole.icellsurface/). |
| [Serializer](../sadconsole.serializer/) | Common serialization tasks for SadConsole. |
| [Serializer.Contracts](../sadconsole.serializer.contracts/) | Registers the default converters for SadConsole objects, when needed. |
| [Serializer.LogTraceWriter](../sadconsole.serializer.logtracewriter/) | A simple log writer that helps debug the JSON serialization. |
| [Settings](../sadconsole.settings/) | Various settings for SadConsole. |
| [Settings.Input](../sadconsole.settings.input/) | Settings related to input. |
| [Settings.Rendering](../sadconsole.settings.rendering/) | Rendering options generally set by a game host. |
| [ShapeParameters](../sadconsole.shapeparameters/) | Defines the parameters for generating a shape with a border and fill glyphs. |
| [SimpleObjectDefinition](../sadconsole.simpleobjectdefinition/) |  |
| [StringExtensions](../sadconsole.stringextensions/) | Helpers for strings. |
| [StringValidation](../sadconsole.stringvalidation/) | Validates a string |
| [ValueChangedCancelableEventArgs<T>\<T\>](../sadconsole.valuechangedcancelableeventargs-1/) | Event arguments for an event fired when an object's properties are changed. The change can be cancelled. |
## Structs

| | |
| --- | --- |
| [CellDecorator](../sadconsole.celldecorator/) | Decorates a cell with a colored glyph. |
| [ColoredGlyphState](../sadconsole.coloredglyphstate/) | A [ColoredGlyphBase](../sadconsole.coloredglyphbase/) with state information. |
| [GlyphDefinition](../sadconsole.glyphdefinition/) | Represents a decorator (glyph and mirror) defined by a font. |
| [StringValidation.Result](../sadconsole.stringvalidation.result/) | The object produced when validating a string. |
## Interfaces

| | |
| --- | --- |
| [ICellSurface](../sadconsole.icellsurface/) | An array of [ColoredGlyphBase](../sadconsole.coloredglyphbase/) objects used to represent a 2D surface. |
| [ICellSurfaceResize](../sadconsole.icellsurfaceresize/) | Adds a method to support resizing a surface. |
| [ICellSurfaceSettable](../sadconsole.icellsurfacesettable/) | Adds a method to change the backing cells of a surface. |
| [IFont](../sadconsole.ifont/) | Represents a font used by the rendering engine. |
| [IScreenObject](../sadconsole.iscreenobject/) | A generic object processed by SadConsole. Provides parent/child, components, position, and input callbacks. |
| [IScreenSurface](../sadconsole.iscreensurface/) | A screen object that has mouse input, surface, and render information. |
| [IScreenSurfaceEditable](../sadconsole.iscreensurfaceeditable/) | The same as a [IScreenSurface](../sadconsole.iscreensurface/) interface, except that it also implements [ISurface](../sadconsole.isurface/) for convenience. |
| [ISurface](../sadconsole.isurface/) | An interface that provides a Surface property that allows the editor extensions to work. |
| [ISurfaceSettable](../sadconsole.isurfacesettable/) | An interface that provides a Surface property which can be set. |
| [ITexture](../sadconsole.itexture/) | Represents a texture provided by a game host. |
## Enums

| | |
| --- | --- |
| [AnimatedScreenObject.AnimationState](../sadconsole.animatedscreenobject.animationstate/) | Represents what state the animation is in. |
| [FocusBehavior](../sadconsole.focusbehavior/) | How the console handles becoming focused and added to the [FocusedScreenObjects](../sadconsole.gamehost/#focusedscreenobjects/) collection. |
| [HorizontalAlignment](../sadconsole.horizontalalignment/) | Horizontal alignment modes. |
| [ICellSurface.ConnectedLineIndex](../sadconsole.icellsurface.connectedlineindex/) | Array index enum for line glyphs. |
| [IFont.Sizes](../sadconsole.ifont.sizes/) | The size options of a font. |
| [Mirror](../sadconsole.mirror/) | The mirroring mode |
| [Orientation](../sadconsole.orientation/) | Orientation modes. |
| [Settings.WindowResizeOptions](../sadconsole.settings.windowresizeoptions/) | Resize modes for the final SadConsole render pass. |
| [TextureConvertBackgroundStyle](../sadconsole.textureconvertbackgroundstyle/) | The style applied when [Background](../sadconsole.textureconvertmode/#background/) is set. |
| [TextureConvertForegroundStyle](../sadconsole.textureconvertforegroundstyle/) | The style applied when [Foreground](../sadconsole.textureconvertmode/#foreground/) is set. |
| [TextureConvertMode](../sadconsole.textureconvertmode/) | The conversion mode from [ITexture](../sadconsole.itexture/) to [ICellSurface](../sadconsole.icellsurface/). |
| [VerticalAlignment](../sadconsole.verticalalignment/) | Vertical alignment modes. |
## Delegates

| | |
| --- | --- |
| [StringValidation.Validator](../sadconsole.stringvalidation.validator/) | Validates a string value. |