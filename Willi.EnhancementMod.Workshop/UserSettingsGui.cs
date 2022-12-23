using System.Collections.Generic;
using System;
using UnityEngine;
using Willi.EnhancementMod.Workshop.Config;
using Random = System.Random;

namespace Willi.EnhancementMod.Workshop
{
    internal class UserSettingsGui : MonoBehaviour
    {
        private static bool isWindowActive = false;

        private static int initialXPosition = Screen.width / 4;
        private static int initialYPosition = Screen.height / 4;
        private static float WindowHeight = Screen.height * 0.8f;
        private static float WindowWidth = Screen.width * 0.35f;
        private static Rect _windowRect = new Rect(initialXPosition, initialYPosition, 180, 400); //TODO: Make configurable

        private static Vector2 scrollPosition;
        private static string searchText = string.Empty;
        private static GUIStyle _guiStyle;

        private void OnGUI()
        {
            if (isWindowActive)
            {
                if (_guiStyle == null)
                {
                    _guiStyle = new GUIStyle(GUI.skin.toggle);

                }
                _windowRect = GUILayout.Window(1747174674, _windowRect, DraggableWindow, "Enhancement mod options", GUILayout.Width(WindowWidth), GUILayout.ExpandHeight(true));
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                isWindowActive = !isWindowActive;
                Debug.LogError("Toggle User settings Window");
            }
        }

        private static string ModEnabledState()
        {
            if (ConfigHelper.UserConfig.IsModEnabled)
            {
                _guiStyle.normal.textColor = Color.green;
                _guiStyle.active.textColor = Color.green;

                return "Disable all";
            }
            _guiStyle.normal.textColor = Color.red;
            _guiStyle.active.textColor = Color.red;
            return "Enable all";
        }

        private static void DraggableWindow(int windowID)
        {
            GUILayout.Space(2);
            searchText = GUILayout.TextField(searchText);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, false, GUIStyle.none, GUI.skin.verticalScrollbar);

            ConfigHelper.UserConfig.IsModEnabled = GUILayout.Toggle(ConfigHelper.UserConfig.IsModEnabled, $"{ModEnabledState()}", _guiStyle);

            ConfigHelper.UserConfig.MoneyRewardMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.MoneyRewardMultiplier), ConfigHelper.UserConfig.MoneyRewardMultiplier, 0, 10);
            ConfigHelper.UserConfig.PatienceMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.PatienceMultiplier), ConfigHelper.UserConfig.PatienceMultiplier, 0, 10);
            ConfigHelper.UserConfig.NumberOfCustomersMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.NumberOfCustomersMultiplier), ConfigHelper.UserConfig.NumberOfCustomersMultiplier, 0, 10);
            ConfigHelper.UserConfig.MinGroupSize = IntSliderWithText(nameof(ConfigHelper.UserConfig.MinGroupSize), ConfigHelper.UserConfig.MinGroupSize, 1, 20);
            ConfigHelper.UserConfig.MaxGroupSize = IntSliderWithText(nameof(ConfigHelper.UserConfig.MaxGroupSize), ConfigHelper.UserConfig.MaxGroupSize, 1, 20);
            ConfigHelper.UserConfig.SpeedMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.SpeedMultiplier), ConfigHelper.UserConfig.SpeedMultiplier, 0, 10);
            ConfigHelper.UserConfig.DefaultShopNumberOfItems = IntSliderWithText(nameof(ConfigHelper.UserConfig.DefaultShopNumberOfItems), ConfigHelper.UserConfig.DefaultShopNumberOfItems, 0, 10);
            ConfigHelper.UserConfig.DefaultShopUpgradedChance = FloatSliderWithText(nameof(ConfigHelper.UserConfig.DefaultShopUpgradedChance), ConfigHelper.UserConfig.DefaultShopUpgradedChance, 0, 10);
            ConfigHelper.UserConfig.RerollShopFixedCost = IntSliderWithText(nameof(ConfigHelper.UserConfig.RerollShopFixedCost), ConfigHelper.UserConfig.RerollShopFixedCost, -1, 1000);
            ConfigHelper.UserConfig.ItemSpawnerWindowHeight = IntSliderWithText(nameof(ConfigHelper.UserConfig.ItemSpawnerWindowHeight), ConfigHelper.UserConfig.ItemSpawnerWindowHeight, 0, 1000);

            GUILayout.EndScrollView();
            GUI.DragWindow();
        }

        private static float FloatSliderWithText(string label, float configSetting, float minValue, float MaxValue)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label($"{label}: {configSetting:0.00}", GUILayout.ExpandWidth(true));
            GUILayout.FlexibleSpace();
            configSetting = GUILayout.HorizontalSlider(configSetting, minValue, MaxValue, GUILayout.Width(WindowWidth * 0.4f));
            GUILayout.EndHorizontal();
            return configSetting;
        }

        private static int IntSliderWithText(string label, int configSetting, int minValue, int MaxValue)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label($"{label}: {configSetting}", GUILayout.ExpandWidth(true));
            GUILayout.FlexibleSpace();
            configSetting = Mathf.RoundToInt(GUILayout.HorizontalSlider(configSetting, minValue, MaxValue, GUILayout.Width(WindowWidth * 0.6f)));
            GUILayout.EndHorizontal();
            return configSetting;
        }
    }
}
