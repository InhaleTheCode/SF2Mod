// SFMenuOverlay.cs
using UnityEngine;
using System;

namespace SFMod
{
    public class SFMenuOverlay : MonoBehaviour
    {
        private bool showMenu = false;
        // Individual window rects
        private Rect mainRect      = new Rect(10, 10, 320, 200);
        private Rect statsRect     = new Rect(340, 10, 320, 200);
        private Rect gameplayRect  = new Rect(670, 10, 320, 200);
        private Rect charRect      = new Rect(1000, 10, 320, 200);

        // Collapsed states
        private bool mainCollapsed     = false;
        private bool statsCollapsed    = false;
        private bool gameplayCollapsed = false;
        private bool charCollapsed     = false;

        private float rpEarnSlider = 100f;
        private float rpHomeSlider = 100f;

        // Header height constant
        private const float headerHeight = 22f;

        public SFMenuOverlay(IntPtr ptr) : base(ptr) { }

        public static void CreateInstance(Plugin loader)
        {
            var inst = loader.AddComponent<SFMenuOverlay>();
            UnityEngine.Object.DontDestroyOnLoad(inst.gameObject);
            inst.hideFlags |= HideFlags.HideAndDontSave;
        }


        public void Update()
        {
            // Toggle menu visibility
            if (Input.GetKeyDown(KeyCode.F5))
            {
                showMenu = !showMenu;
                if (showMenu)
                {
                    // arrange windows left to right along the top
                    mainRect.position      = new Vector2(10, 10);
                    statsRect.position     = new Vector2(mainRect.xMax + 10, 10);
                    gameplayRect.position  = new Vector2(statsRect.xMax + 10, 10);
                    charRect.position      = new Vector2(gameplayRect.xMax + 10, 10);
                }
            }

            // Keybinds now handled here so menu checkboxes stay in sync
            if (Input.GetKeyDown(KeyCode.F1))
            {
                SFInvisMod._suppressEnabled = !SFInvisMod._suppressEnabled;
                Plugin.LogMessage(
                    BepInEx.Logging.LogLevel.Info,
                    $"[SFOverlay] Invisibility toggled: {(SFInvisMod._suppressEnabled ? "ON" : "OFF")}"
                );
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                SFStaminaMod.IsStaminaSuppressionEnabled = !SFStaminaMod.IsStaminaSuppressionEnabled;
                Plugin.LogMessage(
                    BepInEx.Logging.LogLevel.Info,
                    $"[SFOverlay] Stamina toggled: {(SFStaminaMod.IsStaminaSuppressionEnabled ? "ON" : "OFF")}"
                );
            }

            if (Input.GetKeyDown(KeyCode.F8))
            {
                SFPlayerStats.AddLife(1);
                Plugin.LogMessage(
                    BepInEx.Logging.LogLevel.Info,
                    $"[SFOverlay] Added life. Current: {SFPlayerStats.CurrentLife}/{SFPlayerStats.MaxLife}"
                );
            }

            if (Input.GetKeyDown(KeyCode.F7))
            {
                SFBodyPaintMod.InfiniteBodyPaint = !SFBodyPaintMod.InfiniteBodyPaint;
                Plugin.LogMessage(
                    BepInEx.Logging.LogLevel.Info,
                    $"[SFOverlay] Infinite body paint toggled: {(SFBodyPaintMod.InfiniteBodyPaint ? "ON" : "OFF")}"
                );
            }
        }

        public void OnGUI()
        {
            if (!showMenu)
                return;

            // Draw all windows left to right
            mainRect = GUI.Window(
                1234,
                mainRect,
                (GUI.WindowFunction)DrawMainWindow,
                string.Empty
            );
            statsRect = GUI.Window(
                1235,
                statsRect,
                (GUI.WindowFunction)DrawStatsWindow,
                string.Empty
            );
            /*
            gameplayRect = GUI.Window(
                1236,
                gameplayRect,
                (GUI.WindowFunction)DrawGameplayWindow,
                string.Empty
            );
            charRect = GUI.Window(
                1237,
                charRect,
                (GUI.WindowFunction)DrawCharacterWindow,
                string.Empty
            );
            */
        }

        private void DrawMainWindow(int id)
        {
            GUIStyle labelStyle = GUI.skin.label;
            labelStyle.fontSize = 14;

            DrawHeader(ref mainCollapsed, mainRect.width, $"SF Mod Menu v{Plugin.pluginVersion} {Plugin.pluginAuthor}");
            if (mainCollapsed)
            {
                mainRect.height = headerHeight;
                return;
            }

            GUIStyle toggleStyle;
            toggleStyle = GUI.skin.button;
            toggleStyle.fontSize = 12;

            float y = headerHeight + 3f, spacing = 30f;

            // Invisibility toggle
            bool invis = GUI.Toggle(
                new Rect(10, y, 20, 20),
                SFInvisMod._suppressEnabled,
                GUIContent.none,
                toggleStyle
            );
            GUI.Label(
                new Rect(35, y, 200, 25),
                $"F1: SFInvisMod: {(invis ? "ON" : "OFF")}",
                labelStyle
            );
            if (invis != SFInvisMod._suppressEnabled)
                SFInvisMod._suppressEnabled = invis;

            y += spacing;

            // Stamina toggle
            bool stam = GUI.Toggle(
                new Rect(10, y, 20, 20),
                SFStaminaMod.IsStaminaSuppressionEnabled,
                GUIContent.none,
                toggleStyle
            );
            GUI.Label(
                new Rect(35, y, 200, 25),
                $"F2: SFStaminaMod: {(stam ? "ON" : "OFF")}",
                labelStyle
            );
            if (stam != SFStaminaMod.IsStaminaSuppressionEnabled)
                SFStaminaMod.IsStaminaSuppressionEnabled = stam;

            y += spacing;

            // Jog speed slider
            float cur  = SFMoveSpeedMod.GetCurrentJogSpeed();
            float next = GUI.HorizontalSlider(new Rect(10, y, 200, 25), cur, 0.5f, 10f);
            next = Mathf.Round(next * 2f) / 2f;
            if (Mathf.Abs(next - cur) > 0.001f)
                SFMoveSpeedMod.SetJogSpeed(next);
            GUI.Label(new Rect(220, y, 90, 25), $"Speed: {next:0.0}", labelStyle);

            y += spacing;

            // No-clip toggle
            bool noclip = GUI.Toggle(
                new Rect(10, y, 20, 20),
                SFNoClipMod.IsNoClipEnabled,
                GUIContent.none,
                toggleStyle
            );
            GUI.Label(
                new Rect(35, y, 200, 25),
                $"F6: No Clip (experimental!): {(noclip ? "ON" : "OFF")}",
                labelStyle
            );
            if (noclip != SFNoClipMod.IsNoClipEnabled)
                SFNoClipMod.IsNoClipEnabled = noclip;

            y += spacing;

            // Infinite body paint toggle
            bool bodypaint = GUI.Toggle(
                new Rect(10, y, 20, 20),
                SFBodyPaintMod.InfiniteBodyPaint,
                GUIContent.none,
                toggleStyle
            );
            GUI.Label(
                new Rect(35, y, 200, 25),
                $"F7: Infinite Body Paint: {(bodypaint ? "ON" : "OFF")}",
                labelStyle
            );
            if (bodypaint != SFBodyPaintMod.InfiniteBodyPaint)
                SFBodyPaintMod.InfiniteBodyPaint = bodypaint;

            mainRect.height = y + spacing;
        }

        private void DrawStatsWindow(int id)
        {
            GUIStyle labelStyle = GUI.skin.label;
            labelStyle.fontSize = 14;

            DrawHeader(ref statsCollapsed, statsRect.width, "Player Stats");
            if (statsCollapsed)
            {
                statsRect.height = headerHeight;
                return;
            }

            float y = headerHeight + 3f, spacing = 30f;

            GUI.Label(new Rect(10, y, 120, 25), $"Life: {SFPlayerStats.CurrentLife}", labelStyle);
            if (GUI.Button(new Rect(135, y, 25, 25), "-"))
                SFPlayerStats.ChangeCurrentLife(-1);
            if (GUI.Button(new Rect(165, y, 25, 25), "+"))
                SFPlayerStats.ChangeCurrentLife(1);

            y += spacing;

            GUI.Label(new Rect(10, y, 120, 25), $"Max Life: {SFPlayerStats.MaxLife}", labelStyle);
            if (GUI.Button(new Rect(135, y, 25, 25), "-"))
                SFPlayerStats.ChangeMaxLife(-1);
            if (GUI.Button(new Rect(165, y, 25, 25), "+"))
                SFPlayerStats.ChangeMaxLife(1);

            GUI.Label(new Rect(200, y, 100, 25), "F8: +1", labelStyle);

            y += spacing;

            GUI.Label(new Rect(10, y, 120, 25), $"Earn RP: {SFRpMod.EarnedRp:0}", labelStyle);
            rpEarnSlider = GUI.HorizontalSlider(new Rect(135, y + 7, 100, 20), rpEarnSlider, 100f, 1000f);
            rpEarnSlider = Mathf.Round(rpEarnSlider / 100f) * 100f;
            if (GUI.Button(new Rect(240, y, 25, 25), "-"))
                SFRpMod.EarnedRp = Math.Max(0, SFRpMod.EarnedRp - rpEarnSlider);
            if (GUI.Button(new Rect(270, y, 25, 25), "+"))
                SFRpMod.EarnedRp += rpEarnSlider;

            y += spacing;

            GUI.Label(new Rect(10, y, 120, 25), $"Home RP: {SFRpMod.HomeRp:0}", labelStyle);
            rpHomeSlider = GUI.HorizontalSlider(new Rect(135, y + 7, 100, 20), rpHomeSlider, 100f, 1000f);
            rpHomeSlider = Mathf.Round(rpHomeSlider / 100f) * 100f;
            if (GUI.Button(new Rect(240, y, 25, 25), "-"))
                SFRpMod.HomeRp = Math.Max(0, SFRpMod.HomeRp - rpHomeSlider);
            if (GUI.Button(new Rect(270, y, 25, 25), "+"))
                SFRpMod.HomeRp += rpHomeSlider;

            y += spacing;

            GUI.Label(new Rect(10, y, 150, 25), $"Play Time: {SFPlayerStats.FormatTime(SFPlayerStats.TotalPlayTime)}", labelStyle);
            y += spacing;

            GUI.Label(new Rect(10, y, 150, 25), $"Expose Time: {SFPlayerStats.FormatTime(SFPlayerStats.TotalExposeTime)}", labelStyle);
            y += spacing;

            GUI.Label(new Rect(10, y, 150, 25), $"Game Over: {SFPlayerStats.GameOverCount}", labelStyle);
            y += spacing;

            GUI.Label(new Rect(10, y, 150, 25), $"Ecstasy Count: {SFPlayerStats.EcstasyCount}", labelStyle);
            y += spacing;

            GUI.Label(new Rect(10, y, 170, 25), $"Max Earn RP: {SFPlayerStats.MaxEarnRp}", labelStyle);
            y += spacing;

            GUI.Label(new Rect(10, y, 170, 25), $"Total Earn RP: {SFPlayerStats.TotalEarnRp:0}", labelStyle);
            y += spacing;

            GUI.Label(new Rect(10, y, 170, 25), $"Total Lost RP: {SFPlayerStats.TotalLostRp:0}", labelStyle);

            statsRect.height = y + spacing;
        }

        /*
        private void DrawGameplayWindow(int id)
        {
            DrawHeader(ref gameplayCollapsed, gameplayRect.width, "Gameplay");
            if (gameplayCollapsed)
            {
                gameplayRect.height = headerHeight;
                return;
            }

            gameplayRect.height = headerHeight + 4f;
        }

        private void DrawCharacterWindow(int id)
        {
            DrawHeader(ref charCollapsed, charRect.width, "Character");
            if (charCollapsed)
            {
                charRect.height = headerHeight;
                return;
            }

            charRect.height = headerHeight + 4f;
        }
        */

        private void DrawHeader(ref bool collapsed, float width, string title)
        {
            const float arrowSize = 18f;
            Rect arrowRect = new Rect(width - arrowSize - 2f, 2f, arrowSize, headerHeight - 4f);
            if (GUI.Button(arrowRect, collapsed ? "\u25B6" : "\u25BC"))
                collapsed = !collapsed;

            GUI.Label(new Rect(5f, 2f, width - arrowSize - 10f, headerHeight + 2f), title);

            GUI.DragWindow(new Rect(0, 0, width - arrowSize - 4f, headerHeight));
        }
    }
}
