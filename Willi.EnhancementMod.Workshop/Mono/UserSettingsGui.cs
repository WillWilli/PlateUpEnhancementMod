using System.Collections.Generic;
using System;
using UnityEngine;
using Willi.EnhancementMod.Workshop.Config;
using Willi.EnhancementMod.Workshop.Helpers;
using static System.Net.Mime.MediaTypeNames;

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

        private static Vector2 _scrollPosition;
        private static string _noClipKeybindInputString = ConfigHelper.UserConfig.NoClipKeyboardShortcutString;
        private static bool _isNoClipKeybindValid = true;

        private static string _itemSpawnerKeybindInputString = ConfigHelper.UserConfig.SpawnItemMenuKeyboardShortcutString;
        private static bool _isItemSpawnerKeybindValid = true;

        private void OnGUI()
        {
            if (isWindowActive)
            {
                //GUI.backgroundColor = new Color(66, 125, 245, 1);
                
                _windowRect = GUILayout.Window(1747174674, _windowRect, DraggableWindow, "Enhancement Mod Options - (ESC to close)", GuiStyles.WindowStyle , GUILayout.Width(WindowWidth));
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isWindowActive = false;
            }
        }

        public void ToggleWindow()
        {
            isWindowActive = !isWindowActive;
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

            // Top bar buttons
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

            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition, false, false, GUIStyle.none, GUI.skin.verticalScrollbar);
            if (!ConfigHelper.UserConfig.IsModEnabled)
                GUI.enabled = false;

            SectionHeading("Shop");
            ConfigHelper.UserConfig.DefaultShopNumberOfItems = IntSliderWithLabel(nameof(ConfigHelper.UserConfig.DefaultShopNumberOfItems), ConfigHelper.UserConfig.DefaultShopNumberOfItems, -1, 10);
            ConfigHelper.UserConfig.DefaultShopUpgradedChance = FloatSliderWithLabel(nameof(ConfigHelper.UserConfig.DefaultShopUpgradedChance), ConfigHelper.UserConfig.DefaultShopUpgradedChance, -1, 10f);
            ConfigHelper.UserConfig.MoneyRewardMultiplier = FloatSliderWithLabel(nameof(ConfigHelper.UserConfig.MoneyRewardMultiplier), ConfigHelper.UserConfig.MoneyRewardMultiplier, 0f, 10f);
            ConfigHelper.UserConfig.RerollShopFixedCost = IntSliderWithLabel(nameof(ConfigHelper.UserConfig.RerollShopFixedCost), ConfigHelper.UserConfig.RerollShopFixedCost, -1, 200);


            SectionHeading("Customers");
            ConfigHelper.UserConfig.NumberOfCustomersMultiplier = FloatSliderWithLabel(nameof(ConfigHelper.UserConfig.NumberOfCustomersMultiplier), ConfigHelper.UserConfig.NumberOfCustomersMultiplier, 0, 20f);
            ConfigHelper.UserConfig.PatienceMultiplier = FloatSliderWithLabel(nameof(ConfigHelper.UserConfig.PatienceMultiplier), ConfigHelper.UserConfig.PatienceMultiplier, 0f, 10f);
            ConfigHelper.UserConfig.MinGroupSize = IntSliderWithLabel(nameof(ConfigHelper.UserConfig.MinGroupSize), ConfigHelper.UserConfig.MinGroupSize, 1, 20);
            ConfigHelper.UserConfig.MaxGroupSize = IntSliderWithLabel(nameof(ConfigHelper.UserConfig.MaxGroupSize), ConfigHelper.UserConfig.MaxGroupSize, 1, 20);


            SectionHeading("No Clip");
            NoClipKeybordShortcutWithLabel();
            GUILayout.EndHorizontal();
            GUI.backgroundColor = initColour;
            ConfigHelper.UserConfig.SpeedMultiplier = FloatSliderWithLabel(nameof(ConfigHelper.UserConfig.SpeedMultiplier), ConfigHelper.UserConfig.SpeedMultiplier, 0f, 10f);

            SectionHeading("Item Spawner");
            ItemSpawnerKeybordShortcutWithLabel();
            GUILayout.EndHorizontal();
            GUI.backgroundColor = initColour;
            ConfigHelper.UserConfig.ItemSpawnerWindowHeight = IntSliderWithLabel(nameof(ConfigHelper.UserConfig.ItemSpawnerWindowHeight), ConfigHelper.UserConfig.ItemSpawnerWindowHeight, 0, 1000);
            GUILayout.EndScrollView();
            GUI.enabled = true;

            // Footnote
            GUILayout.Space(1);
            var labelStyle = GuiStyles.LabelStyle;
            labelStyle.fontSize = 12;
            GUILayout.Label("* To ignore a setting, set it to '-1'.", labelStyle);
            GUI.backgroundColor = Color.white;

            GUI.DragWindow();
        }

        private static void NoClipKeybordShortcutWithLabel()
        {
            if (!_isNoClipKeybindValid)
                GUI.backgroundColor = Color.red;
            GUILayout.BeginHorizontal();
            GUILayout.Label(new GUIContent("Keyboard shortcut", "set the keyboard shortcut, maps to UnityEngine.Keycode enum."), GuiStyles.LabelStyle);
            _noClipKeybindInputString = GUILayout.TextField(_noClipKeybindInputString);
            if (_noClipKeybindInputString != string.Empty)
            {
                var capitaliseFirstLetter = string.Concat(_noClipKeybindInputString[0].ToString().ToUpper(), _noClipKeybindInputString.Substring(1));
                if (Enum.TryParse<KeyCode>(capitaliseFirstLetter, out var keyCode))
                {
                    ConfigHelper.UserConfig.NoClipKeyboardShortcutString = keyCode.ToString();
                    _isNoClipKeybindValid = true;
                    return;
                }
            }
            _isNoClipKeybindValid = false;
        }

        private static void ItemSpawnerKeybordShortcutWithLabel()
        {
            if (!_isItemSpawnerKeybindValid)
                GUI.backgroundColor = Color.red;
            GUILayout.BeginHorizontal();
            GUILayout.Label(new GUIContent("Keyboard shortcut", "set the keyboard shortcut, maps to UnityEngine.Keycode enum."), GuiStyles.LabelStyle);
            _itemSpawnerKeybindInputString = GUILayout.TextField(_itemSpawnerKeybindInputString);
            if (_itemSpawnerKeybindInputString != string.Empty)
            {
                var capitaliseFirstLetter = string.Concat(_itemSpawnerKeybindInputString[0].ToString().ToUpper(), _itemSpawnerKeybindInputString.Substring(1));
                if (Enum.TryParse<KeyCode>(capitaliseFirstLetter, out var keyCode))
                {
                    ConfigHelper.UserConfig.SpawnItemMenuKeyboardShortcutString = keyCode.ToString();
                    _isItemSpawnerKeybindValid = true;
                    return;
                }
            }
            _isItemSpawnerKeybindValid = false;
        }

        private static void SectionHeading(string headingTitle)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label($"---- {headingTitle} ----", GuiStyles.LabelTitleStyle);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        private static float FloatSliderWithLabel(string label, float configSetting, float minValue, float MaxValue)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(label, GuiStyles.LabelStyle, GUILayout.Width(WindowWidth * 0.4f));
            GUILayout.FlexibleSpace();
            string inputText = GUILayout.TextField($"{configSetting:0.00}", GUILayout.Width(WindowWidth * 0.1f), GUILayout.ExpandWidth(false));
            if (TryParseFloatWithLimits(inputText, out float value, minValue, MaxValue))
            {
                configSetting = value;
            }
            configSetting = GUILayout.HorizontalSlider(configSetting, minValue, MaxValue, GUILayout.Width(WindowWidth * 0.35f));
            GUILayout.EndHorizontal();
            return configSetting;
        }


        private static int IntSliderWithLabel(string label, int configSetting, int minValue, int MaxValue)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(label, GuiStyles.LabelStyle, GUILayout.Width(WindowWidth * 0.4f));
            GUILayout.FlexibleSpace();
            string inputText = GUILayout.TextField(configSetting.ToString(), GUILayout.Width(WindowWidth * 0.1f), GUILayout.ExpandWidth(false));
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
