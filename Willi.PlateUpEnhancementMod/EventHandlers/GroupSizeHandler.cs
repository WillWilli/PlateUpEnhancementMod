using Kitchen;
using Unity.Entities;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;


namespace Willi.PlateUpEnhancementMod.EventHandlers
{
    public static class GroupSizeHandler
    {
        private const int MaximumConfigurableGroupSize = 20;

        public static void UpdateGroupSize(int _)
        {
            if (!ValidateGroupSizes() || !IsModEnabled.Value)
                return;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var kitchenParametersEQ = entityManager.CreateEntityQuery(typeof(SKitchenParameters));

            if (!kitchenParametersEQ.IsEmpty)
            {
                var newKitchenParameters = kitchenParametersEQ.GetSingleton<SKitchenParameters>();
                newKitchenParameters.Parameters.MaximumGroupSize = MaxGroupSize.Value;
                newKitchenParameters.Parameters.MinimumGroupSize = MinGroupSize.Value;

                kitchenParametersEQ.SetSingleton<SKitchenParameters>(newKitchenParameters);
            }
        }

        private static bool ValidateGroupSizes()
        {
            return
                MaxGroupSize.Value > 0 &&
                MinGroupSize.Value > 0 &&
                MaxGroupSize.Value >= MinGroupSize.Value &&
                MaxGroupSize.Value <= MaximumConfigurableGroupSize;
        }
    }
}
