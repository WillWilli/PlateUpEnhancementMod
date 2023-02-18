using Kitchen;
using System.Reflection;
using System;
using Unity.Entities;
using Willi.EnhancementMod.Workshop.Config;

namespace Willi.EnhancementMod.Workshop.Helpers
{
    public static class CustomerParametersHandler
    {
        private const int MaximumConfigurableGroupSize = 20;
        private static Type sCacheHashType = typeof(CreateCustomerSchedule).GetNestedType("SCacheHash", BindingFlags.NonPublic);

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

                kitchenParametersEQ.SetSingleton(newKitchenParameters);
            }
        }

        public static void ForceCustomerScheduleUpdate()
        {
            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var eq = entityManager.CreateEntityQuery(sCacheHashType);
            entityManager.DestroyEntity(eq);
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
