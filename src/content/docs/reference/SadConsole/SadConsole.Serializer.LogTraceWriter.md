---
title: Serializer.LogTraceWriter Class
slug: reference/sadconsole.serializer.logtracewriter
sidebar:
  label: Serializer.LogTraceWriter
---
## Definition

A simple log writer that helps debug the JSON serialization.

```csharp title="C#"
public class Serializer.LogTraceWriter : ITraceWriter
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

Implements Newtonsoft.Json.Serialization.ITraceWriter

## Constructors

### LogTraceWriter()

```csharp title="C#"
public LogTraceWriter()
```


## Fields

### Log

THe string containing the log.

```csharp title="C#"
public readonly StringBuilder Log
```

## Properties

### LevelFilter

THe level filter for the log.

```csharp title="C#"
public TraceLevel LevelFilter { get; }
```

## Methods

### Trace(TraceLevel, string, Exception?)

Captures a JSON log event.

```csharp title="C#"
public void Trace(TraceLevel level, string message, Exception? ex)
```

#### Parameters

`level` [TraceLevel](https://learn.microsoft.com/dotnet/api/system.diagnostics.tracelevel/)  
The log level.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string/)  
The message.

`ex` [Exception](https://learn.microsoft.com/dotnet/api/system.exception/)  
The exception associated with the log event.