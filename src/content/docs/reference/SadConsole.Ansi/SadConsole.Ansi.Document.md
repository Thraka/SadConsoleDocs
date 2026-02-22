---
title: Document Class
slug: reference/sadconsole.ansi.document
sidebar:
  label: Document
editUrl: false
description: Represents an ANSI.SYS formatted document.
---
## Definition

Represents an ANSI.SYS formatted document.

```csharp title="C#"
public class Document : IDisposable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable/)

## Constructors

### Document(string)

Creates a new document from the provided file name.

```csharp title="C#"
public Document(string file)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The file to load.


## Properties

### AnsiBytes

Gets or sets the ANSI.SYS bytes that make up the document.

```csharp title="C#"
public byte[] AnsiBytes { get; set; }
```

### AnsiString

A string representing the [AnsiBytes](../sadconsole.ansi.document/#ansibytes).

```csharp title="C#"
public string AnsiString { get; }
```

### Stream

A stream that points to the [AnsiBytes](../sadconsole.ansi.document/#ansibytes).

```csharp title="C#"
public MemoryStream? Stream { get; }
```

## Methods

### ~Document()

```csharp title="C#"
protected ~Document()
```


### FromAsciiString(string)

Creates a new document from an existing string representing ANSI.SYS codes and characters.

```csharp title="C#"
public static Document FromAsciiString(string ansiContent)
```

#### Parameters

`ansiContent` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The ANSI.SYS encoded string.

#### Returns

[Document](../sadconsole.ansi.document/)  
A new document.

### FromBytes(byte[])

Creates a new document from an existing byte array representing ANSI.SYS codes and characters.

```csharp title="C#"
public static Document FromBytes(byte[] bytes)
```

#### Parameters

`bytes` [byte[]](https://learn.microsoft.com/dotnet/api/system.byte/)  
The ANSI.SYS encoded byte array.

#### Returns

[Document](../sadconsole.ansi.document/)  
A new document.