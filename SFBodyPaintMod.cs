// SFBodyPaintMod.cs
using System;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using ExposureUnnoticed2.Scripts.InGame;
using UnityEngine;

namespace SFMod
{
    public class SFBodyPaintMod : MonoBehaviour
    {
        public static bool InfiniteBodyPaint = false;

        public SFBodyPaintMod(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var inst = loader.AddComponent<SFBodyPaintMod>();
            DontDestroyOnLoad(inst.gameObject);
            inst.hideFlags |= HideFlags.HideAndDontSave;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F7))
            {
                InfiniteBodyPaint = !InfiniteBodyPaint;
                Plugin.LogMessage(
                    LogLevel.Info,
                    $"[SFBodyPaintMod] Infinite body paint: {(InfiniteBodyPaint ? "ON" : "OFF")}");
            }

            if (InfiniteBodyPaint)
            {
                var state = GameState.GameStateData;
                if (state != null)
                {
                    // keep a generous amount of remaining paint time
                    state.PlayerRemainBodyPaintTime = 9999f;
                }
            }
        }
    }
}
