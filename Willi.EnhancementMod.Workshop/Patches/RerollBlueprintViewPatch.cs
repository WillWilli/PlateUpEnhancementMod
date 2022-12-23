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
            SetRerollCost(ConfigHelper.UserConfig.RerollShopFixedCost);
        }

        public static void SetRerollCost(int rerollCost)
        {
            if (rerollCost < 0 || !ConfigHelper.UserConfig.IsModEnabled)
                return;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var rerollCostEQ = entityManager.CreateEntityQuery((ComponentType)typeof(SRerollCost));
            if (!rerollCostEQ.IsEmpty)
            {
                rerollCostEQ.SetSingleton(new SRerollCost() { Cost = rerollCost });
            }
        }
    }
}
