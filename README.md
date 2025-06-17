
# SF2Mod
A Mod for SF2
## Overview

The repository hosts a C# project that builds a BepInEx IL2CPP mod for the Unity game “SecretFlasherManaka.exe.” The entry point is Plugin.cs, which registers the mod with BepInEx and constructs the various mod components when Load runs:

```
[BepInPlugin(pluginGUID, pluginName, pluginVersion)]
[BepInProcess("SecretFlasherManaka.exe")]
public class Plugin : BasePlugin
{
    public const string pluginGUID = "com.IInhaleTheZone.SFmod";
    public const string pluginName = "SFmod";
    public const string pluginVersion = "1.0.5";
    ...
    public override void Load()
    {
        Log = base.Log;
        Log.LogInfo($"Plugin {pluginGUID} loaded!");

        // Create all your mod components
        SFInvisMod.CreateInstance(this);
        SFStaminaMod.CreateInstance(this);
        SFMoveSpeedMod.CreateInstance(this);
        SFMenuOverlay.CreateInstance(this);
        SFNoClipMod.CreateInstance(this);
    }
}
```

The project’s SFMod.csproj references a large set of precompiled DLLs located in Libraries/ so that the mod can hook into Unity and the game’s assemblies

. Builds are produced under bin/Debug/net6.0/ where several plugin versions (SFMod_V1.0.x.dll) and the supporting DLLs reside.

## Main Components

Each mod feature is a MonoBehaviour and is responsible for hooking game functionality using Harmony patches.

### Invisibility Mod (SFInvisMod.cs)
Disables NPC detection and manipulates StrangenessValueManager to keep the player unseen when toggled.

### Stamina Mod (SFStaminaMod.cs)
Prevents stamina loss by patching StaminaManager.OnUpdate.

### Move Speed Mod (SFMoveSpeedMod.cs)
Finds MCommon at runtime and lets the user change the player’s jog speed via F3/F4 keys or via a slider in the overlay window.

### No-Clip Mod (SFNoClipMod.cs)
Patches several player movement classes to bypass built-in movement and collision code, with optional manual controls when enabled.

### Overlay Menu (SFMenuOverlay.cs)
Provides an in‑game GUI (toggled with F5) that exposes checkboxes and a slider for the above mods. It also listens for F1/F2 key toggles so that checkboxes stay in sync with key presses.

### Kumarin Helper (kumarinHelper.cs)
Removes “Censor” game objects, modifies certain controllers, and patches GameState and SystemManager to disable trial mode restrictions.
- note to self, remove this 

The solution file SFMod.sln simply references this single project.

## What to Know

- Mod Framework – The mod relies on BepInEx (IL2CPP flavor) and Harmony for patching. Understanding how BepInEx loads plugins and how Harmony method patches work is crucial.
- Unity IL2CPP – The project links to many Unity DLLs and uses Il2CppInterop to interact with Unity’s IL2CPP runtime. Knowledge of Unity’s IL2CPP modding workflow and Il2CppInterop basics will help when extending the mod.
- Input Controls – Most features use key bindings (F1–F6) in Update() methods or through the overlay; customizing controls would involve modifying these key checks.
- GUI/Overlay – The overlay uses Unity’s immediate-mode OnGUI to draw toggles and sliders. The menu becomes draggable and can control the other mod components directly.


