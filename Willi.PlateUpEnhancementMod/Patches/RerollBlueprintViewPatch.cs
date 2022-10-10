using HarmonyLib;
using Kitchen;
using Unity.Entities;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(RerollBlueprintView))]
    public static class RerollBlueprintViewPatch
    {
        private static EntityManager _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        [HarmonyPatch("UpdateData")]
        [HarmonyPostfix]
        public static void UpdateData_Prefix()
        {
            if (RerollShopFixedCost.Value < 0)
                return;

            if (_entityManager == null)
                _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

            var eq = _entityManager.CreateEntityQuery((ComponentType)typeof(SRerollCost));
            eq.SetSingleton<SRerollCost>(new SRerollCost() { Cost = RerollShopFixedCost.Value });
        }
    }
}
