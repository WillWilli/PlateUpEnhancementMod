using System;
using Newtonsoft.Json;
using UnityEngine;
using Willi.EnhancementMod.Workshop.Helpers;

namespace Willi.EnhancementMod.Workshop.Config
{
    [Serializable]
    public class UserConfig
    {
        public UserConfig()
        {

        }

        public UserConfig(UserConfig userConfig)
        {
            IsModEnabled = userConfig.IsModEnabled;
            MoneyRewardMultiplier = userConfig.MoneyRewardMultiplier;
            PatienceMultiplier = userConfig.PatienceMultiplier;
            NumberOfCustomersMultiplier = userConfig.NumberOfCustomersMultiplier;
            MinGroupSize = userConfig.MinGroupSize;
            MaxGroupSize = userConfig.MaxGroupSize;
            NoClipKeyboardShortcutString = userConfig.NoClipKeyboardShortcutString;
            SpeedMultiplier = userConfig.SpeedMultiplier;
            DefaultShopNumberOfItems = userConfig.DefaultShopNumberOfItems;
            DefaultShopUpgradedChance = userConfig.DefaultShopUpgradedChance;
            RerollShopFixedCost  = userConfig.RerollShopFixedCost;
            ItemSpawnerWindowHeight = userConfig.ItemSpawnerWindowHeight;
            SpawnItemMenuKeyboardShortcutString = userConfig.SpawnItemMenuKeyboardShortcutString;
        }

        public bool IsModEnabled { get; set; } = true;

        // General
        public float MoneyRewardMultiplier { get; set; } = 1f;
        public float PatienceMultiplier { get; set; } = 1f;
        public float NumberOfCustomersMultiplier { get; set; } = 1f;
        public int MinGroupSize { get; set; } = 1;
        public int MaxGroupSize { get; set; } = 2;
        public string NoClipKeyboardShortcutString { get; set; } = "N";

        [JsonIgnore]
        public KeyCode NoClipKeyboardShortcut
        {
            get
            {
                if (Enum.TryParse(NoClipKeyboardShortcutString, true, out KeyCode keyCode))
                {
                    return keyCode;
                }
                Log.Error("Invalid config entry for 'NoClipKeyboardShortcut', defaulting to 'N'.");
                return KeyCode.N;
            }
        }

        public float SpeedMultiplier { get; set; } = 1f;


        // Default shop
        public int DefaultShopNumberOfItems { get; set; } = -1;
        public float DefaultShopUpgradedChance { get; set; } = -1f;
        public int RerollShopFixedCost { get; set; } = -1;


        // Spawn Items
        public int ItemSpawnerWindowHeight { get; set; } = 400;
        public string SpawnItemMenuKeyboardShortcutString{ get; set; } = "F2";
        [JsonIgnore]
        public KeyCode SpawnItemMenuKeyboardShortcut
        {
            get
            {
                if (Enum.TryParse(SpawnItemMenuKeyboardShortcutString, true, out KeyCode keyCode))
                {
                    return keyCode;
                }
                Log.Error("Invalid config entry for 'SpawnItemMenuKeyboardShortcut', defaulting to 'F2'.");
                return KeyCode.F2;
            }
        }
    }
}
