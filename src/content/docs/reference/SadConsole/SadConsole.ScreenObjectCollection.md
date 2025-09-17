---
title: ScreenObjectCollection Class
slug: reference/sadconsole.screenobjectcollection
sidebar:
  label: ScreenObjectCollection
---
## Definition

Manages the parent and children relationship for [IScreenObject](../sadconsole.iscreenobject/).

```csharp title="C#"
public class ScreenObjectCollection : ScreenObjectCollection<IScreenObject>, IReadOnlyList<IScreenObject>, IReadOnlyCollection<IScreenObject>, IEnumerable<IScreenObject>, IEnumerable
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/) → [ScreenObjectCollection\<IScreenObject\>](../sadconsole.screenobjectcollection-1/)

Implements [IReadOnlyList\<IScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1/), [IReadOnlyCollection\<IScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1/), [IEnumerable\<IScreenObject\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1/), [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable/)

## Constructors

### ScreenObjectCollection(IScreenObject)

Creates a new object collection and parents it to the `owner` object.

```csharp title="C#"
public ScreenObjectCollection(IScreenObject owner)
```

#### Parameters

`owner` [IScreenObject](../sadconsole.iscreenobject/)  
The owning object of this collection.