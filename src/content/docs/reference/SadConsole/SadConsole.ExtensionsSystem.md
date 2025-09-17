---
title: ExtensionsSystem Class
slug: reference/sadconsole.extensionssystem
sidebar:
  label: ExtensionsSystem
---
## Definition

```csharp title="C#"
public static class ExtensionsSystem
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Methods

### GetDebuggerDisplayValue(object)

Searches the object for a [DebuggerDisplayAttribute](https://learn.microsoft.com/dotnet/api/system.diagnostics.debuggerdisplayattribute/) and returns its value. If not found, returns [ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring/).

```csharp title="C#"
public static string GetDebuggerDisplayValue(this object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object/)  
The object to check.

#### Returns

[string](https://learn.microsoft.com/dotnet/api/system.string/)  
A string representing the object.