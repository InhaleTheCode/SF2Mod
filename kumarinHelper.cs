using System;
using BepInEx.Unity.IL2CPP;
using ExposureUnnoticed2.Object3D.Player.Scripts.Other;
using ExposureUnnoticed2.Scripts.Base;
using ExposureUnnoticed2.Scripts.InGame;
using HadakaCoat.Objects3D.Dildo;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SFMod
{
    public class kumarinHelper : MonoBehaviour
    {
        private SFMod.Plugin loader;
        private static string last_scenename = string.Empty;

        public kumarinHelper(IntPtr ptr) : base(ptr) {}

        public static void CreateInstance(SFMod.Plugin loader)
        {
            var instance = loader.AddComponent<kumarinHelper>();
            instance.loader = loader;

            UnityEngine.Object.DontDestroyOnLoad(instance.gameObject);
            instance.hideFlags |= HideFlags.HideAndDontSave;


            var harmony = new Harmony("com.IInhaleTheZone.SFmod");
            harmony.PatchAll(typeof(kumarinHelper));
        }

        public void OnGUI()
        {
            string scene = SceneManager.GetActiveScene().name;
            if (last_scenename == scene) return;

            foreach (var item in UnityEngine.Object.FindObjectsOfType<GameObject>())
            {
                if (item.name.Contains("Censor"))
                    item.SetActive(false);
            }

            last_scenename = scene;
        }

        [HarmonyPatch(typeof(DildoController), "Start")]
        public class DildoController_Start
        {
            [HarmonyPostfix]
            public static void Postfix(DildoController __instance)
            {
                foreach (var obj in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (obj.name.StartsWith("Capsule"))
                        obj.SetActive(false);
                }
            }
        }

        [HarmonyPatch(typeof(FutanariController), "OnChangeBody")]
        public class FutanariController_OnChangeBody
        {
            [HarmonyPostfix]
            public static void Postfix(FutanariController __instance)
            {
                foreach (var obj in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (obj.name.StartsWith("Capsule"))
                        obj.SetActive(false);
                }

                __instance.TamaClothesPaintMaterial.SetFloat("_Pixelation", 0.001f);
            }
        }

        [HarmonyPatch(typeof(SystemManager), "Awake")]
        public class SystemManager_Awake
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                SystemManager.IsTrial = false;
            }
        }

        [HarmonyPatch(typeof(GameState), "get_IsTrial")]
        public class GameState_IsTrial
        {
            [HarmonyPostfix]
            public static void Postfix(ref bool __result)
            {
                __result = false;
            }
        }
    }
}
