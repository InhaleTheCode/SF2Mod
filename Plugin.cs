// Plugin.cs
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using SFMod;
using UnityEngine;

namespace SFMod
{
    [BepInPlugin(pluginGUID, pluginName, pluginVersion)]
    [BepInProcess("SecretFlasherManaka.exe")]
    public class Plugin : BasePlugin
    {
        public const string pluginGUID = "com.IInhaleTheZone.SFmod";
        public const string pluginName = "SFmod";
        public const string pluginVersion = "1.0.6";
        public const string pluginAuthor = "IInhaleTheZone";
        internal static new ManualLogSource Log;

        public static void LogMessage(LogLevel lv, object data)
        {
            Log?.Log(lv, data);
        }

        public override void Load()
        {
            Log = base.Log;
            Log.LogInfo($"Plugin {pluginGUID} loaded!");

            // Create all your mod components
            SFInvisMod.CreateInstance(this);
            SFStaminaMod.CreateInstance(this);
            SFPlayerStats.CreateInstance(this);
            SFMoveSpeedMod.CreateInstance(this);
            SFMenuOverlay.CreateInstance(this);
            SFNoClipMod.CreateInstance(this);
            SFBodyPaintMod.CreateInstance(this);
            SFRpMod.CreateInstance(this);

            /*
            // Instantiate the overlay menu
            var overlayGO = new GameObject("SFMenuOverlay");
            Object.DontDestroyOnLoad(overlayGO);
            overlayGO.AddComponent<SFMenuOverlay>();*/
        }
    }
}
