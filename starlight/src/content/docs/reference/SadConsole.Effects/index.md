---
title: SadConsole.Effects
slug: reference/sadconsole.effects
sidebar:
  order: 0
---
## Classes

| | |
| --- | --- |
| [Blink](../sadconsole.effects.blink/) | Switches between the normal foreground of a cell and a specified color for an amount of time, and then repeats. |
| [BlinkGlyph](../sadconsole.effects.blinkglyph/) | Switches between the glyph of a cell and a specified glyph for an amount of time, and then repeats. |
| [Blinker](../sadconsole.effects.blinker/) | Blinks the foreground and background colors of a cell with the specified colors. |
| [CellEffectBase](../sadconsole.effects.celleffectbase/) | A base class for cell effects. |
| [CodeEffect](../sadconsole.effects.codeeffect/) | Effect that runs code for the apply and update actions of an effect. |
| [Delay](../sadconsole.effects.delay/) | An effect that doesn't do anything except run the [StartDelay](../sadconsole.effects.celleffectbase/#startdelay/) timer. Usually used with the [EffectSet](../sadconsole.effects.effectset/) effect. |
| [EffectSet](../sadconsole.effects.effectset/) | Chains one effect after another. |
| [EffectsManager](../sadconsole.effects.effectsmanager/) | Effects manager for a text surface. |
| [EffectsManager.ColoredGlyphEffectData](../sadconsole.effects.effectsmanager.coloredglypheffectdata/) | Represents a mapping of a single effect and associated cells. |
| [EffectsManager.ColoredGlyphWithState](../sadconsole.effects.effectsmanager.coloredglyphwithstate/) | A glyph with its original state. |
| [Fade](../sadconsole.effects.fade/) | Fades both the background and foreground to separate colors. |
| [Recolor](../sadconsole.effects.recolor/) | Recors the foreground or the background of a cell. |
## Interfaces

| | |
| --- | --- |
| [ICellEffect](../sadconsole.effects.icelleffect/) | The interface describing a cell effect |