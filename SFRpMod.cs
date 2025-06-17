using System;
using UnityEngine;
using ExposureUnnoticed2.Scripts.InGame;

namespace SFMod
{
    public class SFRpMod : MonoBehaviour
    {
        public SFRpMod(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var inst = loader.AddComponent<SFRpMod>();
            DontDestroyOnLoad(inst.gameObject);
            inst.hideFlags |= HideFlags.HideAndDontSave;
        }

        private static GameStateData State => GameState.GameStateData;

        public static double EarnedRp
        {
            get => State != null ? State.CurrentEarnThisTimeRp : 0;
            set { if (State != null) State.CurrentEarnThisTimeRp = value; }
        }

        public static double HomeRp
        {
            get => State != null ? State.CurrentRp : 0;
            set { if (State != null) State.CurrentRp = value; }
        }
    }
}
