using HarmonyLib;
using Kitchen;
using Unity.Entities;
using Willi.EnhancementMod.Workshop.Config;

namespace Willi.EnhancementMod.Workshop.Patches
{
    [HarmonyPatch(typeof(RerollBlueprintView))]
    public static class RerollBlueprintViewPatch
    {
        [HarmonyPatch("UpdateData")]
        [HarmonyPostfix]
        public static void UpdateData_Prefix()
        {
            SetRerollCost();
        }

        public static void SetRerollCost()
        {
            if (ConfigHelper.UserConfig.RerollShopFixedCost < 0 || !ConfigHelper.UserConfig.IsModEnabled)
                return;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var rerollCostEQ = entityManager.CreateEntityQuery((ComponentType)typeof(SRerollCost));
            if (!rerollCostEQ.IsEmpty)
            {
                rerollCostEQ.SetSingleton(new SRerollCost() { Cost = ConfigHelper.UserConfig.RerollShopFixedCost });
            }
        }
    }
}
