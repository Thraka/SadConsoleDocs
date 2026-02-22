---
title: BBCodeCommandBase Class
slug: reference/sadconsole.stringparser.bbcode.bbcodecommandbase
sidebar:
  label: BBCodeCommandBase
editUrl: false
description: The base class for a BBCode command.
---
## Definition

The base class for a BBCode command.

```csharp title="C#"
public abstract class BBCodeCommandBase : ParseCommandBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ParseCommandBase](../sadconsole.stringparser.parsecommandbase/)

## Constructors

### BBCodeCommandBase()

```csharp title="C#"
protected BBCodeCommandBase()
```


## Properties

### Tag

The tag used to create this command.

```csharp title="C#"
public string Tag { get; protected set; }
```

## Methods

### SetBBCode(string, string?, Dictionary\<string, string>?)

Provides the information about the tag that triggered this command.

```csharp title="C#"
public abstract void SetBBCode(string tag, string? value, Dictionary<string, string>? parameters)
```

#### Parameters

`tag` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The BBCode tag condition that triggered the command.

`value` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
Optional value provided by the BBCode.

`parameters` [Dictionary\<string, string\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2/)  
Optional parameters provided by the BBCode.