// SFPlayerStats.cs
using System;
using UnityEngine;
using ExposureUnnoticed2.Scripts.InGame;

namespace SFMod
{
    public class SFPlayerStats : MonoBehaviour
    {
        public SFPlayerStats(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var instance = loader.AddComponent<SFPlayerStats>();
            UnityEngine.Object.DontDestroyOnLoad(instance.gameObject);
            instance.hideFlags |= HideFlags.HideAndDontSave;
        }

        private static GameStateData State => GameState.GameStateData;

        public static int CurrentLife => State != null ? State.PlayerLife : 0;
        public static int MaxLife => State != null ? State.PlayerMaxLife : 0;

        public static uint TotalPlayTime => State != null ? State.StatistisTotalPlayTime : 0;
        public static uint TotalExposeTime => State != null ? State.StatistisTotalExposeTime : 0;
        public static int GameOverCount => State != null ? State.StatistisGameOverCount : 0;
        public static int EcstasyCount => State != null ? State.StatistisEcstasyCount : 0;
        public static int MaxEarnRp => State != null ? State.StatistisMaxEarnRp : 0;
        public static double TotalEarnRp => State != null ? State.StatistisTotalEarnRp : 0;
        public static double TotalLostRp => State != null ? State.StatistisTotalLostRp : 0;

        public static string FormatTime(uint seconds)
        {
            var ts = TimeSpan.FromSeconds(seconds);
            return ts.ToString(@"hh\:mm\:ss");
        }

        public static void ChangeCurrentLife(int delta)
        {
            var state = State;
            if (state == null)
                return;

            state.PlayerLife = Mathf.Clamp(state.PlayerLife + delta, 0, state.PlayerMaxLife);
        }

        public static void ChangeMaxLife(int delta)
        {
            var state = State;
            if (state == null)
                return;

            state.PlayerMaxLife = Mathf.Max(1, state.PlayerMaxLife + delta);
            state.PlayerLife = Mathf.Clamp(state.PlayerLife, 0, state.PlayerMaxLife);
        }

        // Adds to both current and max life
        public static void AddLife(int delta)
        {
            var state = State;
            if (state == null)
                return;

            state.PlayerMaxLife = Mathf.Max(1, state.PlayerMaxLife + delta);
            state.PlayerLife = Mathf.Clamp(state.PlayerLife + delta, 0, state.PlayerMaxLife);
        }
    }
}
