using HarmonyLib;
using KitchenData;
using Kitchen;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;
using System.Runtime.CompilerServices;
using Unity.Entities;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch(typeof(ManageParameters))]
    public static class CreateCustomerSchedulePatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("OnUpdate")]
        public static void Defaults_Prefix(ManageParameters __instance)
        {
            var logger = BepInEx.Logging.Logger.CreateLogSource(ModGuid);
            var kp = KitchenParameters.Defaults;
            kp.MinimumGroupSize = MinTableSize.Value;
            kp.MaximumGroupSize = MaxTableSize.Value;

            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            //if (!__instance.HasSingleton<SKitchenParameters>())
            //{
                logger.LogWarning("Adding kitchen params");
                entityManager.SetComponentData<SKitchenParameters>(entityManager.CreateEntity((ComponentType)typeof(SKitchenParameters)), new SKitchenParameters()
                {
                    Parameters = kp
                });
            //}
        }
    }
}
