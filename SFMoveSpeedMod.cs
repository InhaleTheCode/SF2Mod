using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime;
using UnityEngine;
using ExposureUnnoticed2.Master.Common;
using System;
using SFMod;


namespace SFMod
{
    public class SFMoveSpeedMod : MonoBehaviour
    {
        //private Plugin loader;
        private static float _jogSpeedDelta = 0.5f;
        private static MCommon _mCommonInstance;

        public SFMoveSpeedMod(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var instance = loader.AddComponent<SFMoveSpeedMod>();
            //instance.loader = loader;
            DontDestroyOnLoad(instance.gameObject);
            instance.hideFlags |= HideFlags.HideAndDontSave;
        }

        public void Update()
        {
            if (_mCommonInstance == null)
            {
                var all = Resources.FindObjectsOfTypeAll<MCommon>();
                foreach (var mc in all)
                {
                    if (mc.playerJogSpeed > 0f)
                    {
                        _mCommonInstance = mc;
                        Plugin.LogMessage(BepInEx.Logging.LogLevel.Info,
                            $"[SFMoveSpeedMod] Selected MCommon w/ jog speed {mc.playerJogSpeed}");
                        break;
                    }
                }
            }

            // Adjust speed via hotkeys
            if (_mCommonInstance != null)
            {
                if (Input.GetKeyDown(KeyCode.F3))
                {
                    _mCommonInstance.playerJogSpeed -= _jogSpeedDelta;
                    Plugin.LogMessage(BepInEx.Logging.LogLevel.Info, $"[SFMoveSpeedMod] Jog speed decreased to {_mCommonInstance.playerJogSpeed}");

                }

                if (Input.GetKeyDown(KeyCode.F4))
                {
                    _mCommonInstance.playerJogSpeed += _jogSpeedDelta;
                    Plugin.LogMessage(BepInEx.Logging.LogLevel.Info, $"[SFMoveSpeedMod] Jog speed increased to {_mCommonInstance.playerJogSpeed}");
                }
            }
        }

        public static float GetCurrentJogSpeed()
            => _mCommonInstance != null ? _mCommonInstance.playerJogSpeed : 0f;

        /*
        //expose jog speed helpers for overly
        public static float GetCurrentJogSpeed()
        {
            return _mCommonInstance != null ? _mCommonInstance.playerJogSpeed : 0f;
        }

        public static void AdjustJogSpeed(float delta)
        {
            if (_mCommonInstance != null)
                _mCommonInstance.playerJogSpeed += delta;
        }

        */

   

        //for overlay
        public static void SetJogSpeed(float value, bool log = true)
        {
            if (_mCommonInstance != null)
            {
                _mCommonInstance.playerJogSpeed = value;
                if (log)
                    Plugin.LogMessage(BepInEx.Logging.LogLevel.Info, $"[SFMoveSpeedMod] Jog speed set to {value}");
            }
        }
        
        /*
        //for slider in overlay 
        public static void SetJogSpeed(float value)
        {
            if (_mCommonInstance != null)
                _mCommonInstance.playerJogSpeed = value;
        }
        */

    }

}
