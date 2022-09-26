using BepInEx.Logging;
using HarmonyLib;
using Kitchen.ShopBuilder;
using KitchenData;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(CreateShopOptions), "AddOption", new[] { typeof(Appliance) })]
    public static class CreateShopOptionsPatch
    {
        static void Postfix(Appliance app)
        {
            if (LogItemIdsOnStartup.Value)
                Log.LogInfo($"{app.Name}, {app.ID}");
        }
    }
}
