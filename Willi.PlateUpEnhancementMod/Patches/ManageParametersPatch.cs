using HarmonyLib;
using Kitchen;
using Unity.Entities;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(ManageParameters))]
    public static class ManageParametersPatch
    {
        private const int MaximumConfigurableGroupSize = 20;
        private static EntityManager _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        private static int _oldMaxGroupSize = MaxGroupSize.Value;
        private static int _oldMinGroupSize = MinGroupSize.Value;

        [HarmonyPostfix]
        [HarmonyPatch("OnUpdate")]
        public static void OnUpdate_Prefix()
        {
            if (hasKitchenParametersUpdated())
            {
                if (_entityManager == null)
                {
                    _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
                }
                if (_entityManager != null && ValidateGroupSizes())
                {
                    UpdateKitchenParameters();
                }
            }

        }

        private static bool hasKitchenParametersUpdated()
        {
            if (_oldMaxGroupSize != MaxGroupSize.Value ||
                _oldMinGroupSize != MinGroupSize.Value)
            {
                _oldMinGroupSize = MinGroupSize.Value;
                _oldMaxGroupSize = MaxGroupSize.Value;
                return true;
            }
            return false;
        }

        private static bool ValidateGroupSizes()
        {
            return
                MaxGroupSize.Value > 0 &&
                MinGroupSize.Value > 0 &&
                MaxGroupSize.Value >= MinGroupSize.Value &&
                MaxGroupSize.Value <= MaximumConfigurableGroupSize;
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
