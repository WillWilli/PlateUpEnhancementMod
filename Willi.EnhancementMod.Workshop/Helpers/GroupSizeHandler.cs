using Kitchen;
using Unity.Entities;
using Willi.EnhancementMod.Workshop.Config;

namespace Willi.EnhancementMod.Workshop.Helpers
{
    public static class GroupSizeHandler
    {
        private const int MaximumConfigurableGroupSize = 20;

        public static void UpdateGroupSize()
        {
            if (!ValidateGroupSizes() || !ConfigHelper.UserConfig.IsModEnabled)
                return;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var kitchenParametersEQ = entityManager.CreateEntityQuery(typeof(SKitchenParameters));

            if (!kitchenParametersEQ.IsEmpty)
            {
                var newKitchenParameters = kitchenParametersEQ.GetSingleton<SKitchenParameters>();
                newKitchenParameters.Parameters.MaximumGroupSize = ConfigHelper.UserConfig.MaxGroupSize;
                newKitchenParameters.Parameters.MinimumGroupSize = ConfigHelper.UserConfig.MinGroupSize;

                kitchenParametersEQ.SetSingleton(newKitchenParameters);
            }
        }

        private static bool ValidateGroupSizes()
        {
            return
                ConfigHelper.UserConfig.MaxGroupSize > 0 &&
                ConfigHelper.UserConfig.MinGroupSize > 0 &&
                ConfigHelper.UserConfig.MaxGroupSize >= ConfigHelper.UserConfig.MinGroupSize &&
                ConfigHelper.UserConfig.MaxGroupSize <= MaximumConfigurableGroupSize;
        }
    }
}
