---
title: ImGuiRenderer Class
slug: reference/sadconsole.imguisystem.imguirenderer
sidebar:
  label: ImGuiRenderer
---
## Definition

```csharp title="C#"
public class ImGuiRenderer
```

Inheritance [object](https://learn.microsoft.com/dotnet/api/system.object/)

## Properties

### WantsMouseCapture

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates thats the ImGui input system is going to use the mouse, for example when the mouse is over a UI element; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool WantsMouseCapture { get; }
```

### WantsKeyboardCapture

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates thats the ImGui input system is going to use the mouse, for example when focus is on a textbox; otherwise <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool WantsKeyboardCapture { get; }
```

### HideRequested

When <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, indicates thats the UI should be hidden and stopped. Once it's hidden and stopped, this property is set to <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

```csharp title="C#"
public bool HideRequested { get; set; }
```

## Methods

### RebuildFontAtlas()

Creates a texture and loads the font data from ImGui. Should be called when the `Microsoft.Xna.Framework.Graphics.GraphicsDevice` is initialized but before any rendering is done

```csharp title="C#"
public virtual void RebuildFontAtlas()
```


### BindTexture(Texture2D)

Creates a pointer to a texture, which can be passed through ImGui calls such as `Hexa.NET.ImGui.ImGui.Image(Hexa.NET.ImGui.ImTextureID%2cSystem.Numerics.Vector2%2cSystem.Numerics.Vector2%2cSystem.Numerics.Vector2%2cSystem.Numerics.Vector4%2cSystem.Numerics.Vector4)`. That pointer is then used by ImGui to let us know what texture to draw

```csharp title="C#"
public virtual ImTextureID BindTexture(Texture2D texture)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  

#### Returns

Hexa.NET.ImGui.ImTextureID

### UnbindTexture(ImTextureID)

Removes a previously created texture pointer, releasing its reference and allowing it to be deallocated

```csharp title="C#"
public virtual void UnbindTexture(ImTextureID textureId)
```

#### Parameters

`textureId` Hexa.NET.ImGui.ImTextureID  


### UnbindTexture(Texture2D)

Removes a previously created texture pointer, releasing its reference and allowing it to be deallocated

```csharp title="C#"
public virtual void UnbindTexture(Texture2D texture)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  


### BeforeLayoutInput(GameTime)

Runs the ImGui input. Call before [BeforeLayout(GameTime)](../sadconsole.imguisystem.imguirenderer/#/).

```csharp title="C#"
public void BeforeLayoutInput(GameTime gameTime)
```

#### Parameters

`gameTime` Microsoft.Xna.Framework.GameTime  
Game frame delta.


### BeforeLayout(GameTime)

Sets up ImGui for a new frame, should be called at frame start

```csharp title="C#"
public virtual void BeforeLayout(GameTime gameTime)
```

#### Parameters

`gameTime` Microsoft.Xna.Framework.GameTime  


### AfterLayout()

Asks ImGui for the generated geometry data and sends it to the graphics pipeline, should be called after the UI is drawn using ImGui.** calls

```csharp title="C#"
public virtual void AfterLayout()
```


### SetupInput()

Setup key input event handler.

```csharp title="C#"
protected virtual void SetupInput()
```


### UpdateEffect(Texture2D)

Updates the `Microsoft.Xna.Framework.Graphics.Effect` to the current matrices and texture

```csharp title="C#"
protected virtual Effect UpdateEffect(Texture2D texture)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  

#### Returns

Microsoft.Xna.Framework.Graphics.Effect

### UpdateInput()

Sends XNA input state to ImGui

```csharp title="C#"
protected virtual void UpdateInput()
```


### AddFontTTF(string, float)

```csharp title="C#"
public ImFontPtr AddFontTTF(string file, float size)
```

#### Parameters

`file` [string](https://learn.microsoft.com/dotnet/api/system.string/)  

`size` [float](https://learn.microsoft.com/dotnet/api/system.single/)  

#### Returns

Hexa.NET.ImGui.ImFontPtr

### SetDefaultFont(ImFontPtr)

```csharp title="C#"
public void SetDefaultFont(ImFontPtr value)
```

#### Parameters

`value` Hexa.NET.ImGui.ImFontPtr  


### HasBoundTexture(Texture2D)

```csharp title="C#"
public bool HasBoundTexture(Texture2D texture)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  

#### Returns

[bool](https://learn.microsoft.com/dotnet/api/system.boolean/)

### GetBoundTexturePointer(Texture2D)

```csharp title="C#"
public ImTextureID GetBoundTexturePointer(Texture2D texture)
```

#### Parameters

`texture` Microsoft.Xna.Framework.Graphics.Texture2D  

#### Returns

Hexa.NET.ImGui.ImTextureID

### ReplaceBoundTexture(ImTextureID, Texture2D)

```csharp title="C#"
public void ReplaceBoundTexture(ImTextureID textureID, Texture2D texture)
```

#### Parameters

`textureID` Hexa.NET.ImGui.ImTextureID  

`texture` Microsoft.Xna.Framework.Graphics.Texture2D