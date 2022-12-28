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
            if (!ConfigHelper.UserConfig.IsModEnabled)
                return;
            SetRerollCost(ConfigHelper.UserConfig.RerollShopFixedCost);
        }

        public static void SetRerollCost(int cost)
        {
            if (cost < 0)
                return;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var rerollCostEQ = entityManager.CreateEntityQuery((ComponentType)typeof(SRerollCost));
            if (!rerollCostEQ.IsEmpty)
            {
                rerollCostEQ.SetSingleton(new SRerollCost() { Cost = cost });
            }
        }
    }
}
