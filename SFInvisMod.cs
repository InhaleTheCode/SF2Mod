// SFInvisMod.cs
using System;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using ExposureUnnoticed2.Object3D.NPC.Script;
using UnityEngine;

namespace SFMod
{
    public class SFInvisMod : MonoBehaviour
    {
        public static bool _suppressEnabled = false;

        public SFInvisMod(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var instance = loader.AddComponent<SFInvisMod>();
            UnityEngine.Object.DontDestroyOnLoad(instance.gameObject);
            instance.hideFlags |= HideFlags.HideAndDontSave;

            var harmony = new Harmony("com.IInhaleTheZone.SFInvisMod");
            harmony.PatchAll(typeof(SFInvisMod));
            harmony.PatchAll(typeof(Patch_StrangenessValueManager_OnUpdate));
        }

        // (Removed old Update – handled now by SFMenuOverlay)

        [HarmonyPatch(typeof(NpcController), "OnUpdate")]
        public class NpcController_OnUpdate_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(NpcController __instance)
            {
                if (_suppressEnabled && __instance.IsRiseStrangeness)
                    __instance.IsRiseStrangeness = false;
            }
        }
    }

    [HarmonyPatch(typeof(StrangenessValueManager), "OnUpdate")]
    public class Patch_StrangenessValueManager_OnUpdate
    {
        [HarmonyPrefix]
        public static bool Prefix(StrangenessValueManager __instance)
        {
            if (!SFInvisMod._suppressEnabled)
                return true;

            __instance.Value = 0f;
            __instance.CurrentReduceParSecond = 0f;
            __instance.strangenessReduceCount = 0;
            return false;
        }
    }
}
