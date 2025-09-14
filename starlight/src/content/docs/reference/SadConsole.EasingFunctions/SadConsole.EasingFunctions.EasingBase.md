---
title: EasingBase Class
slug: reference/sadconsole.easingfunctions.easingbase
sidebar:
  label: EasingBase
---
## Definition

The base class for an easing function.

```csharp title="C#"
[DataContract]
public abstract class EasingBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Constructors

### EasingBase()

Creates a new instance of this type.

```csharp title="C#"
public EasingBase()
```


## Properties

### Mode

The easing mode.

```csharp title="C#"
[DataMember]
public EasingMode Mode { get; set; }
```

## Methods

### Ease(double, double, double, double)

Called to apply an easing function to the value.

```csharp title="C#"
public abstract double Ease(double elapsedTime, double startingValue, double endingValue, double maxDuration)
```

#### Parameters

`elapsedTime` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The total time applied to the function.

`startingValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The starting value.

`endingValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The ending value.

`maxDuration` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
Total time applied to easing.

#### Returns

[double](https://learn.microsoft.com/dotnet/api/system.double/)  
A calculated value.