using Kitchen;
using Unity.Entities;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;


namespace Willi.PlateUpEnhancementMod.EventHandlers
{
    public static class GroupSizeHandler
    {
        private const int MaximumConfigurableGroupSize = 20;
        private static EntityManager _entityManager;

        public static void UpdateGroupSize(int _)
        {
            if (!ValidateGroupSizes())
                return;

            if (_entityManager == null)
            {
                _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            }
            if (_entityManager != null)
            {
                var kitchenParametersEQ = _entityManager.CreateEntityQuery(typeof(SKitchenParameters));
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
