---
title: SadConsole.Host
slug: reference/sadconsole.host
sidebar:
  order: 0
---
## Classes

| | |
| --- | --- |
| [FPSCounterComponent](../sadconsole.host.fpscountercomponent/) | A component to draw how many frames per second the engine is performing at. |
| [Game](../sadconsole.host.game/) | A MonoGame `Microsoft.Xna.Framework.Game` instance that runs SadConsole. |
| [GameTexture](../sadconsole.host.gametexture/) | Creates a `Microsoft.Xna.Framework.Graphics.Texture2D`. Generally you request this from the [GetTexture(string)](https://learn.microsoft.com/dotnet/api/system.string/) method. |
| [Global](../sadconsole.host.global/) | Global variables used by the MonoGame host. |
| [SadConsoleGameComponent](../sadconsole.host.sadconsolegamecomponent/) | A game component that handles updating, input, and rendering of SadConsole. |
| [Settings](../sadconsole.host.settings/) | A settings class usually used when creating the host object. |
## Delegates

| | |
| --- | --- |
| [Global.RecreateRenderOutputDelegate](../sadconsole.host.global.recreaterenderoutputdelegate/) | Regenerates the [RenderOutput](../sadconsole.host.global/#renderoutput/) if the desired size doesn't match the current size. |
| [Global.ResizeGraphicsDeviceManagerDelegate](../sadconsole.host.global.resizegraphicsdevicemanagerdelegate/) | Resizes the [GraphicsDeviceManager](../sadconsole.host.global/#graphicsdevicemanager/) by the specified font size. |