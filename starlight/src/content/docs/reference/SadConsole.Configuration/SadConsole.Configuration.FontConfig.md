---
title: FontConfig Class
slug: reference/sadconsole.configuration.fontconfig
sidebar:
  label: FontConfig
---
## Definition

The config settings for loading the default fonts when the game starts.

```csharp title="C#"
public class FontConfig : IConfigurator
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IConfigurator](../sadconsole.configuration.iconfigurator/)

## Constructors

### FontConfig()

```csharp title="C#"
public FontConfig()
```


## Fields

### CustomFonts

An array of custom font files to load into SadConsole. The default is an empty array.

```csharp title="C#"
public string[] CustomFonts
```

### AlternativeDefaultFont

The default font to use when the game starts. A <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> value indicates that the default font is the built-in font.

```csharp title="C#"
public string? AlternativeDefaultFont
```

### UseExtendedFont

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, the default font is the SadConsole extended font. The default is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool UseExtendedFont
```

### DefaultFontSize

The size of font to use with the default font. The default is [One](../sadconsole.ifont.sizes/#one/).

```csharp title="C#"
public IFont.Sizes DefaultFontSize
```

## Properties

### FontLoader

The method invoked by the [GameHost](../sadconsole.gamehost/) as fonts are loaded.

```csharp title="C#"
public Action<FontConfig, GameHost>? FontLoader { get; set; }
```

## Methods

### UseBuiltinFont()

Sets the default font to the SadConsole standard font, an IBM 8x16 font.

```csharp title="C#"
public void UseBuiltinFont()
```


### UseBuiltinFontExtended()

Sets the default font to the SadConsole extended font, an IBM 8x16 font with SadConsole specific characters past index 255.

```csharp title="C#"
public void UseBuiltinFontExtended()
```


### UseCustomFont(string)

Sets the default font in SadConsole to the specified font file.

```csharp title="C#"
public void UseCustomFont(string fontFile)
```

#### Parameters

`fontFile` [string](https://learn.microsoft.com/dotnet/api/system.string/)  


### AddExtraFonts(params string[])

Loads the provided font files into SadConsole.

```csharp title="C#"
public void AddExtraFonts(params string[] fontFiles)
```

#### Parameters

`fontFiles` [string[]](https://learn.microsoft.com/dotnet/api/system.string/)  
An array of font files to load.


### SetDefaultFontSize(Sizes)

Sets the default font size for the game. The default is [One](../sadconsole.ifont.sizes/#one/).

```csharp title="C#"
public void SetDefaultFontSize(IFont.Sizes size)
```

#### Parameters

`size` [IFont.Sizes](../sadconsole.ifont/)  
The default font size.


### Run(BuilderBase, GameHost)

Invokes the [FontLoader](../sadconsole.configuration.fontconfig/#fontloader/) delegate.

```csharp title="C#"
public void Run(BuilderBase config, GameHost game)
```

#### Parameters

`config` [BuilderBase](../sadconsole.configuration.builderbase/)  
The builder running this configurator.

`game` [GameHost](../sadconsole.gamehost/)  
The game being created.