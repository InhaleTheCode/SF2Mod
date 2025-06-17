// SFNoClipMod.cs
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using ExposureUnnoticed2.Object3D.Player.Scripts;  // for PlayerLocomotion
using HarmonyLib;
using System;
using UnityEngine;

namespace SFMod
{
    public class SFNoClipMod : MonoBehaviour
    {
        // exposed for your F6 & menu
        public static bool IsNoClipEnabled = false;
        private static BoxCollider[] _envBoxColliders;
        //private static MeshCollider[] _envMeshColliders; //mesh is floor. need to control gravity if we enable this
        private static PolygonCollider2D[] _envPolyColliders;


        public SFNoClipMod(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var inst = loader.AddComponent<SFNoClipMod>();
            UnityEngine.Object.DontDestroyOnLoad(inst.gameObject);
            inst.hideFlags |= HideFlags.HideAndDontSave;

            // Install our Harmony patch
            var harmony = new Harmony("com.IInhaleTheZone.SFNoClipMod");
            harmony.PatchAll(typeof(SFNoClipMod));
        }

        // Patch the game's PlayerLocomotion.OnUpdate(InputData)
        [HarmonyPatch(typeof(PlayerLocomotion), "OnUpdate")]
        class Patch_PlayerLocomotion_OnUpdate
        {
            [HarmonyPostfix]
            static void Postfix(PlayerLocomotion __instance)
            {
                var cc = __instance.characterController;
                if (cc != null)
                    // when no-clip is ON, disable CC collisions; restore when OFF
                    cc.detectCollisions = !SFNoClipMod.IsNoClipEnabled;
            }
        }




        void Update()
        {
            // your F6 toggle
            if (Input.GetKeyDown(KeyCode.F6))
            {
                IsNoClipEnabled = !IsNoClipEnabled;
                Plugin.LogMessage(
                    LogLevel.Info,
                    $"[SFNoClipMod] No-clip: {(IsNoClipEnabled ? "ON" : "OFF")}"
                );
            }

            if (IsNoClipEnabled)
            {
                _envBoxColliders = FindObjectsOfType<BoxCollider>();
                //_envMeshColliders = FindObjectsOfType<MeshCollider>();
                _envPolyColliders = FindObjectsOfType<PolygonCollider2D>();
                foreach (var bc in _envBoxColliders) bc.enabled = false;
                //foreach (var bc in _envMeshColliders) bc.enabled = false;
                foreach (var bc in _envPolyColliders) bc.enabled = false;
            }
            else if (_envBoxColliders != null)
            {
                foreach (var bc in _envBoxColliders) bc.enabled = true;
                //foreach (var bc in _envMeshColliders) bc.enabled = true;
                foreach (var bc in _envPolyColliders) bc.enabled = true;
                _envBoxColliders = null;
                //_envMeshColliders = null;
                _envPolyColliders = null;
            }
        }
    }
}