using Kitchen;
using Unity.Entities;
using Willi.EnhancementMod.Workshop.Config;

namespace Willi.EnhancementMod.Workshop.Helpers
{
    public static class CustomerParametersHandler
    {
        private const int MaximumConfigurableGroupSize = 20;

        public static void UpdateGroupSize()
        {
            if (!ValidateGroupSizes())
                return;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var kitchenParametersEQ = entityManager.CreateEntityQuery(typeof(SKitchenParameters));

            if (!kitchenParametersEQ.IsEmpty)
            {
                var newKitchenParameters = kitchenParametersEQ.GetSingleton<SKitchenParameters>();
                newKitchenParameters.Parameters.MaximumGroupSize = ConfigHelper.UserConfig.MaxGroupSize;
                newKitchenParameters.Parameters.MinimumGroupSize = ConfigHelper.UserConfig.MinGroupSize;
                newKitchenParameters.Parameters.CustomersPerHour *= 10;


                kitchenParametersEQ.SetSingleton(newKitchenParameters);
            }
        }

        // Hack to force CreateCustomerSchedulePatch.DetermineTotalCustomers to update
        private static bool FlipEachTime = true;
        public static void UpdateNumberOfCustomers()
        {
            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var kitchenParametersEQ = entityManager.CreateEntityQuery(typeof(SKitchenParameters));

            var newKitchenParameters = kitchenParametersEQ.GetSingleton<SKitchenParameters>();
            if (FlipEachTime)
                newKitchenParameters.Parameters.CustomersPerHour *= 1.00001f;
            newKitchenParameters.Parameters.CustomersPerHour /= 1.00001f;

            kitchenParametersEQ.SetSingleton(newKitchenParameters);

            FlipEachTime = !FlipEachTime;
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
