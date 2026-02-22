---
title: FocusBehavior Enum
slug: reference/sadconsole.focusbehavior
sidebar:
  label: FocusBehavior
editUrl: false
description: How the console handles becoming focused and added to the `SadConsole.GameHost.FocusedScreenObjects` collection.
---
## Definition

How the console handles becoming focused and added to the [FocusedScreenObjects](../sadconsole.gamehost/#focusedscreenobjects) collection.

```csharp title="C#"
public enum FocusBehavior
```


## Fields

### Set

Becomes the only active input object when focused.

```csharp title="C#"
Set = 0
```

### Push

Pushes to the top of the stack when it becomes the active input object.

```csharp title="C#"
Push = 1
```

### None

Don't use the global focus manager.

```csharp title="C#"
None = 2
```