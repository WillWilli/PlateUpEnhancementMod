using HarmonyLib;
using KitchenData;
using Kitchen;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(CreateCustomerSchedule))]
    public static class CreateCustomerSchedulePatch
    {

        [HarmonyPostfix]
        [HarmonyPatch(nameof(CreateCustomerSchedule.DetermineTotalCustomers))]
        public static void DetermineTotalCustomers_Postfix(ref float __result, KitchenParameters parameters, int player_count, int day, GameDifficultySettings difficulty_settings)
        {
            __result *= NumberOfCustomersMultiplier.Value;
        }
    }
}
