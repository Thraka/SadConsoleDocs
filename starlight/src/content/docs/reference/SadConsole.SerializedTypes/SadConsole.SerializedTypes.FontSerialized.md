---
title: FontSerialized Class
slug: reference/sadconsole.serializedtypes.fontserialized
sidebar:
  label: FontSerialized
---
## Definition

```csharp title="C#"
public class FontSerialized
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### FontSerialized()

```csharp title="C#"
public FontSerialized()
```


## Fields

### Name

```csharp title="C#"
public string Name
```

## Methods

### FromFont(IFont)

```csharp title="C#"
public static FontSerialized FromFont(IFont font)
```

#### Parameters

`font` [IFont](../sadconsole.ifont/)  

#### Returns

[FontSerialized](../sadconsole.serializedtypes.fontserialized/)

### ToFont(FontSerialized)

```csharp title="C#"
public static IFont ToFont(FontSerialized font)
```

#### Parameters

`font` [FontSerialized](../sadconsole.serializedtypes.fontserialized/)  

#### Returns

[IFont](../sadconsole.ifont/)