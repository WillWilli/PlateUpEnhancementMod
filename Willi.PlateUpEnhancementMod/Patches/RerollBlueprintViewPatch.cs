using HarmonyLib;
using Kitchen;
using Unity.Entities;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(RerollBlueprintView))]
    public static class RerollBlueprintViewPatch
    {
        [HarmonyPatch("UpdateData")]
        [HarmonyPostfix]
        public static void UpdateData_Prefix()
        {
            SetRerollCost(RerollShopFixedCost.Value);
        }

        public static void SetRerollCost(int rerollCost)
        {
            if (rerollCost < 0 || !IsModEnabled.Value)
                return;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var rerollCostEQ = entityManager.CreateEntityQuery((ComponentType)typeof(SRerollCost));
            if (!rerollCostEQ.IsEmpty)
            {
                rerollCostEQ.SetSingleton<SRerollCost>(new SRerollCost() { Cost = rerollCost});
            }
        }
    }
}
