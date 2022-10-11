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
            SetRerollCost(RerollShopFixedCost.Value);
        }

        public static void SetRerollCost(int rerollCost)
        {
            if (rerollCost < 0)
                return;

            if (_entityManager == null)
                _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

            if (_entityManager != null)
            {
                var eq = _entityManager.CreateEntityQuery((ComponentType)typeof(SRerollCost));
                eq.SetSingleton<SRerollCost>(new SRerollCost() { Cost = rerollCost});
            }

        }
    }
}
