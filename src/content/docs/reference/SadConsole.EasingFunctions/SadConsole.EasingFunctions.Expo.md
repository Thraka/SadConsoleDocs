---
title: Expo Class
slug: reference/sadconsole.easingfunctions.expo
sidebar:
  label: Expo
---
## Definition

```csharp title="C#"
[DataContract]
public class Expo : EasingBase
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [EasingBase](../sadconsole.easingfunctions.easingbase/)

## Constructors

### Expo()

```csharp title="C#"
public Expo()
```


## Methods

### Ease(double, double, double, double)

Called to apply an easing function to the value.

```csharp title="C#"
public override double Ease(double time, double startingValue, double currentValue, double duration)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double/)  

`startingValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  
The starting value.

`currentValue` [double](https://learn.microsoft.com/dotnet/api/system.double/)  

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double/)  

#### Returns

[double](https://learn.microsoft.com/dotnet/api/system.double/)  
A calculated value.