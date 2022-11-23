using Willi.PlateUpEnhancementMod.EventHandlers;
using Willi.PlateUpEnhancementMod.Patches;

namespace Willi.PlateUpEnhancementMod.Config
{
    /// <summary>
    /// Register callback methods to be invoked on config change
    /// </summary>
    public static class ChangeDetectorRegister
    {
        public static void RegisterAllCallbacks()
        {
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.MaxGroupSize, GroupSizeHandler.UpdateGroupSize);
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.MinGroupSize, GroupSizeHandler.UpdateGroupSize);
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.RerollShopFixedCost, RerollBlueprintViewPatch.SetRerollCost);
        }
    }
}