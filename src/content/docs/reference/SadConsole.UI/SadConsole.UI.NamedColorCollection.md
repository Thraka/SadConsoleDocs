---
title: NamedColorCollection Class
slug: reference/sadconsole.ui.namedcolorcollection
sidebar:
  label: NamedColorCollection
editUrl: false
description: A collection of named colors
---
## Definition

A collection of named colors

```csharp title="C#"
public class NamedColorCollection : IEnumerable<NamedColor>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IEnumerable\<NamedColor\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### NamedColorCollection()

Creates a new instance with the default colors of White and Black.

```csharp title="C#"
public NamedColorCollection()
```


### NamedColorCollection(IEnumerable\<NamedColor>)

```csharp title="C#"
public NamedColorCollection(IEnumerable<NamedColor> initialCollection)
```

#### Parameters

`initialCollection` [IEnumerable\<NamedColor\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/)  


## Properties

### Colors

The backing dictionary of colors.

```csharp title="C#"
public Dictionary<string, NamedColor> Colors { get; set; }
```

## Methods

### Add(NamedColor)

Adds a color to the collection.

```csharp title="C#"
public void Add(NamedColor color)
```

#### Parameters

`color` [NamedColor](../sadconsole.ui.namedcolor/)  


### LoadDefaults()

Clears the collection of colors and adds White and Black colors.

```csharp title="C#"
public void LoadDefaults()
```


### Load(string)

Loads a [Colors](../sadconsole.ui.namedcolorcollection/#colors) dictionary from a file, and returns a new instance of the [NamedColorCollection](../sadconsole.ui.namedcolorcollection/) class with those colors.

```csharp title="C#"
public static NamedColorCollection Load(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file.

#### Returns

[NamedColorCollection](../sadconsole.ui.namedcolorcollection/)
#### Exceptions

[FileNotFoundException](https://learn.microsoft.com/dotnet/api/system.io.filenotfoundexception/)  
Thrown when the file isn't found.


### Save(string)

Saves the [Colors](../sadconsole.ui.namedcolorcollection/#colors) dictionary to a file.

```csharp title="C#"
public void Save(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file.


### GetEnumerator()

```csharp title="C#"
public IEnumerator<NamedColor> GetEnumerator()
```

#### Returns

[IEnumerator\<NamedColor\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1/)