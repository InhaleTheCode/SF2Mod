// SFStaminaMod.cs
using System;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using ExposureUnnoticed2.Object3D.Player.Scripts;

namespace SFMod
{
    public class SFStaminaMod : MonoBehaviour
    {
        internal static bool IsStaminaSuppressionEnabled = false;

        public SFStaminaMod(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var instance = loader.AddComponent<SFStaminaMod>();
            UnityEngine.Object.DontDestroyOnLoad(instance.gameObject);
            instance.hideFlags |= HideFlags.HideAndDontSave;

            var harmony = new Harmony("com.IInhaleTheZone.SFStaminaMod");
            harmony.PatchAll(typeof(Patch_StaminaManager_OnUpdate));
        }

        // (Removed old Update – handled now by SFMenuOverlay)

    }

    [HarmonyPatch(typeof(StaminaManager), "OnUpdate")]
    public class Patch_StaminaManager_OnUpdate
    {
        [HarmonyPrefix]
        public static bool Prefix(StaminaManager __instance)
        {
            if (!SFStaminaMod.IsStaminaSuppressionEnabled)
                return true;

            float max = __instance.Max;
            __instance.Current                     = max;
            __instance._Current_k__BackingField    = max;
            __instance.RegenerationCoolTime        = 0f;
            __instance.isZero                      = false;
            return false;
        }
    }
}
