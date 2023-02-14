using HarmonyLib;
using KitchenData;
using Kitchen;
using Willi.EnhancementMod.Workshop.Config;

namespace Willi.EnhancementMod.Workshop.Patches
{
    [HarmonyPatch(typeof(CreateCustomerSchedule))]
    public static class CreateCustomerSchedulePatch
    {

        [HarmonyPostfix]
        [HarmonyPatch(nameof(CreateCustomerSchedule.DetermineTotalCustomers))]
        public static void DetermineTotalCustomers_Postfix(ref float __result, ScheduleParameters schedule_parameters)
        {
            if (!ConfigHelper.UserConfig.IsModEnabled)
                return;

            __result *= ConfigHelper.UserConfig.NumberOfCustomersMultiplier;
        }
    }
}
