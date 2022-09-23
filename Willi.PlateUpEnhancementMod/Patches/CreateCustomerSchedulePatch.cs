using HarmonyLib;
using KitchenData;
using Kitchen;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;
using Unity.Entities;
using BepInEx.Logging;
using System;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(CreateCustomerSchedule))]
    public static class CreateCustomerSchedulePatch
    {
        private readonly static ManualLogSource _logger = BepInEx.Logging.Logger.CreateLogSource(ModGuid);

        [HarmonyPrefix]
        [HarmonyPatch(nameof(CreateCustomerSchedule.GetCustomersForDay))]
        public static void GetCustomersForDay_Prefix(
            CreateCustomerSchedule system,
            ref KitchenParameters parameters,
            int player_count,
            int day,
            Action<int, float, bool> group_callback)
        {
            parameters.MinimumGroupSize = MinTableSize.Value;
            parameters.MaximumGroupSize = MaxTableSize.Value;
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(CreateCustomerSchedule.DetermineTotalCustomers))]
        public static void DetermineTotalCustomers_Postfix(ref float __result, KitchenParameters parameters, int player_count, int day, GameDifficultySettings difficulty_settings)
        {
            __result *= NumberOfCustomersMultiplier.Value;
        }
    }

}
