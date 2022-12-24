using System;
using UnityEngine;

namespace Willi.EnhancementMod.Workshop.Config
{
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
            NoClipKeyboardShortcut = userConfig.NoClipKeyboardShortcut;
            SpeedMultiplier = userConfig.SpeedMultiplier;
            DefaultShopNumberOfItems = userConfig.DefaultShopNumberOfItems;
            DefaultShopUpgradedChance = userConfig.DefaultShopUpgradedChance;
            RerollShopFixedCost  = userConfig.RerollShopFixedCost;
            ItemSpawnerWindowHeight = userConfig.ItemSpawnerWindowHeight;
            SpawnItemMenuKeyboardShortcut = userConfig.SpawnItemMenuKeyboardShortcut;
        }

        public bool IsModEnabled { get; set; } = true;

        // General
        public float MoneyRewardMultiplier { get; set; } = 1f;
        public float PatienceMultiplier { get; set; } = 1f;
        public float NumberOfCustomersMultiplier { get; set; } = 1f;
        public int MinGroupSize { get; set; } = 1;
        public int MaxGroupSize { get; set; } = 2;
        public KeyCode NoClipKeyboardShortcut { get; set; } = KeyCode.N;
        public float SpeedMultiplier { get; set; } = 1f;


        // Default shop
        public int DefaultShopNumberOfItems { get; set; } = 5;
        public float DefaultShopUpgradedChance { get; set; } = 1f;
        public int RerollShopFixedCost { get; set; } = -1;


        // Spawn Items
        public int ItemSpawnerWindowHeight { get; set; } = 400;
        public KeyCode SpawnItemMenuKeyboardShortcut { get; set; } = KeyCode.F2;
    }
}
