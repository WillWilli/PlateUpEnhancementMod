using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Willi.EnhancementMod.Workshop.Config
{
    public class UserConfig
    {
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
