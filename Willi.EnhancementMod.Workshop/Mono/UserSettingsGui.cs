using System.Collections.Generic;
using System;
using UnityEngine;
using Willi.EnhancementMod.Workshop.Config;
using Willi.EnhancementMod.Workshop.Helpers;

namespace Willi.EnhancementMod.Workshop.Mono
{
    internal class UserSettingsGui : MonoBehaviour
    {
        private static bool isWindowActive = false;

        private static int initialXPosition = Screen.width / 4;
        private static int initialYPosition = Screen.height / 4;
        private static float WindowHeight = Screen.height * 0.5f;
        private static float WindowWidth = Screen.width * 0.35f;
        private static Rect _windowRect = new Rect(initialXPosition, initialYPosition, WindowWidth, WindowHeight); //TODO: Make configurable

        private static Vector2 scrollPosition;
        private static string searchText = string.Empty;

        private void OnGUI()
        {
            if (isWindowActive)
            {
                //GUI.backgroundColor = new Color(1, 1, 1, 1);
                _windowRect = GUILayout.Window(1747174674, _windowRect, DraggableWindow, "Enhancement mod options", GuiStyles.WindowStyle , GUILayout.Width(WindowWidth));
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
                GUI.backgroundColor = Color.green;
                return "Enabled";
            }
            GUI.backgroundColor = Color.red;
            return "Disabled";
        }

        private static void DraggableWindow(int windowID)
        {
            GUILayout.Space(2);
            searchText = GUILayout.TextField(searchText);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, false, GUIStyle.none, GUI.skin.verticalScrollbar);

            GUILayout.BeginHorizontal();
            ConfigHelper.UserConfig.IsModEnabled = GUILayout.Toggle(ConfigHelper.UserConfig.IsModEnabled, new GUIContent($"{ModEnabledState()}", "enable / disable all"), GuiStyles.ToggleStyle, GUILayout.Width(WindowWidth * 0.2f));
            GUILayout.FlexibleSpace();
            var initColour = GUI.backgroundColor;
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("save", GuiStyles.ButtonStyle))
            {
                ConfigHelper.SaveUserConfig();
            }
            if (GUILayout.Button("load", GuiStyles.ButtonStyle))
            {
                ConfigHelper.LoadUserConfig();
            }
            if (GUILayout.Button("reset", GuiStyles.ButtonStyle))
            {
                ConfigHelper.UserConfig = new UserConfig();
            }
            GUI.backgroundColor = initColour;
            GUILayout.EndHorizontal();

            ConfigHelper.UserConfig.MoneyRewardMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.MoneyRewardMultiplier), ConfigHelper.UserConfig.MoneyRewardMultiplier, 0, 10);
            ConfigHelper.UserConfig.PatienceMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.PatienceMultiplier), ConfigHelper.UserConfig.PatienceMultiplier, 0, 10);
            ConfigHelper.UserConfig.NumberOfCustomersMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.NumberOfCustomersMultiplier), ConfigHelper.UserConfig.NumberOfCustomersMultiplier, 0, 10);
            ConfigHelper.UserConfig.MinGroupSize = IntSliderWithText(nameof(ConfigHelper.UserConfig.MinGroupSize), ConfigHelper.UserConfig.MinGroupSize, 1, 20);
            ConfigHelper.UserConfig.MaxGroupSize = IntSliderWithText(nameof(ConfigHelper.UserConfig.MaxGroupSize), ConfigHelper.UserConfig.MaxGroupSize, 1, 20);
            ConfigHelper.UserConfig.SpeedMultiplier = FloatSliderWithText(nameof(ConfigHelper.UserConfig.SpeedMultiplier), ConfigHelper.UserConfig.SpeedMultiplier, 0, 10);
            ConfigHelper.UserConfig.DefaultShopNumberOfItems = IntSliderWithText(nameof(ConfigHelper.UserConfig.DefaultShopNumberOfItems), ConfigHelper.UserConfig.DefaultShopNumberOfItems, 0, 10);
            ConfigHelper.UserConfig.DefaultShopUpgradedChance = FloatSliderWithText(nameof(ConfigHelper.UserConfig.DefaultShopUpgradedChance), ConfigHelper.UserConfig.DefaultShopUpgradedChance, 0, 10);
            ConfigHelper.UserConfig.RerollShopFixedCost = IntSliderWithText(nameof(ConfigHelper.UserConfig.RerollShopFixedCost), ConfigHelper.UserConfig.RerollShopFixedCost, -1, 200);
            ConfigHelper.UserConfig.ItemSpawnerWindowHeight = IntSliderWithText(nameof(ConfigHelper.UserConfig.ItemSpawnerWindowHeight), ConfigHelper.UserConfig.ItemSpawnerWindowHeight, 0, 1000);

            GUI.backgroundColor = Color.white;

            GUILayout.EndScrollView();
            GUI.DragWindow();
        }

        private static float FloatSliderWithText(string label, float configSetting, float minValue, float MaxValue)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(label, GuiStyles.LabelStyle, GUILayout.Width(WindowWidth * 0.4f));
            GUILayout.FlexibleSpace();
            string inputText = GUILayout.TextField($"{configSetting:0.00}", GUILayout.MinWidth(WindowWidth * 0.05f), GUILayout.ExpandWidth(false));
            if (TryParseFloatWithLimits(inputText, out float value, minValue, MaxValue))
            {
                configSetting = value;
            }
            configSetting = GUILayout.HorizontalSlider(configSetting, minValue, MaxValue, GUILayout.Width(WindowWidth * 0.35f));
            GUILayout.EndHorizontal();
            return configSetting;
        }


        private static int IntSliderWithText(string label, int configSetting, int minValue, int MaxValue)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(label, GuiStyles.LabelStyle, GUILayout.Width(WindowWidth * 0.4f));
            GUILayout.FlexibleSpace();
            string inputText = GUILayout.TextField(configSetting.ToString(), GUILayout.MinWidth(WindowWidth * 0.05f), GUILayout.ExpandWidth(false));
            if (TryParseIntWithLimits(inputText, out int value, minValue, MaxValue))
            {
                configSetting = value;
            }
            configSetting = Mathf.RoundToInt(GUILayout.HorizontalSlider(configSetting, minValue, MaxValue, GUILayout.Width(WindowWidth * 0.35f)));
            GUILayout.EndHorizontal();
            return configSetting;
        }

        private static bool TryParseFloatWithLimits(string inputText, out float actualValue, float minValue, float maxValue)
        {
            actualValue = 0f;
            if (float.TryParse(inputText, out float parsedValue))
            {
                if (parsedValue < minValue || parsedValue > maxValue)
                {
                    return false;
                }
                actualValue = parsedValue;
                return true;
            }
            return false;
        }

        private static bool TryParseIntWithLimits(string inputText, out int actualValue, int minValue, int maxValue)
        {
            actualValue = 0;
            if (int.TryParse(inputText, out int parsedValue))
            {
                if (parsedValue < minValue || parsedValue > maxValue)
                {
                    return false;
                }
                actualValue = parsedValue;
                return true;
            }
            return false;
        }
    }
}
