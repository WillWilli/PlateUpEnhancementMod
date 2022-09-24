using HarmonyLib;
using Kitchen;
using Unity.Entities;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(ManageParameters))]
    public static class ManageParametersPatch
    {
        private static bool initialSet = false;
        private static EntityManager _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        private static int oldMaxGroupSize = MaxGroupSize.Value;
        private static int oldMinGroupSize = MinGroupSize.Value;

        [HarmonyPostfix]
        [HarmonyPatch("OnUpdate")]
        public static void OnUpdate_Prefix()
        {
            if (_entityManager == null)
            {
                _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            }
            if (_entityManager != null)
            {

                if (oldMaxGroupSize != MaxGroupSize.Value)
                {
                    UpdateKitchenParameters();
                    oldMaxGroupSize = MaxGroupSize.Value;
                }
                else if (oldMinGroupSize != MinGroupSize.Value)
                {
                    UpdateKitchenParameters();
                    oldMinGroupSize = MinGroupSize.Value;
                }
            }
        }

        private static void UpdateKitchenParameters()
        {
            Log.LogError("Updating kitchen params");
            var kitchenParametersEQ = _entityManager.CreateEntityQuery(typeof(SKitchenParameters));
            var newKitchenParameters = kitchenParametersEQ.GetSingleton<SKitchenParameters>();
            newKitchenParameters.Parameters.MaximumGroupSize = MaxGroupSize.Value;
            newKitchenParameters.Parameters.MinimumGroupSize = MinGroupSize.Value;

            kitchenParametersEQ.SetSingleton<SKitchenParameters>(newKitchenParameters);
        }
    }
}
