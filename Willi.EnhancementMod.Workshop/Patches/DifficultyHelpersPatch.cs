using HarmonyLib;
using Kitchen;
using Willi.EnhancementMod.Workshop.Config;

namespace Willi.EnhancementMod.Workshop.Patches
{
    [HarmonyPatch(typeof(DifficultyHelpers))]
    public static class DifficultyHelpersPatch
    {
        [HarmonyPatch("TotalShopCount")]
        [HarmonyPrefix]
        public static bool TotalShopCountPrefix(ref int __result)
        {
            if (ConfigHelper.UserConfig.IsModEnabled)
            {
                __result = ConfigHelper.UserConfig.DefaultShopNumberOfItems;
                return false;
            }

            return true;
        }

        [HarmonyPatch("BaseUpgradedShopChance")]
        [HarmonyPostfix]
        public static void UpgradedShopChance_Postfix(ref float __result, int day)
        {
            if (!ConfigHelper.UserConfig.IsModEnabled)
                return;

            __result = ConfigHelper.UserConfig.DefaultShopUpgradedChance;
        }

        [HarmonyPatch("MoneyRewardPlayerModifier")]
        [HarmonyPostfix]
        public static void MoneyRewardPlayerModifier_Postfix(ref float __result, int player_count)
        {
            if (!ConfigHelper.UserConfig.IsModEnabled)
                return;

            __result *= ConfigHelper.UserConfig.MoneyRewardMultiplier;
        }

        [HarmonyPatch("PatiencePlayerCountModifier")]
        [HarmonyPostfix]
        public static void PatiencePlayerCountModifier_Postfix(ref float __result, int player_count)
        {
            if (!ConfigHelper.UserConfig.IsModEnabled)
                return;

            __result *= ConfigHelper.UserConfig.PatienceMultiplier;
        }
    }
}
