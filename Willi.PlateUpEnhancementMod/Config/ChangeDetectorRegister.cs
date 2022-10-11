using Willi.PlateUpEnhancementMod.EventHandlers;
using Willi.PlateUpEnhancementMod.Patches;

namespace Willi.PlateUpEnhancementMod.Config
{
    public static class ChangeDetectorRegister
    {
        public static void RegisterAllCallbacks()
        {
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.IsNoClip, NoClipHandler.SetNoClipState);
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.MaxGroupSize, GroupSizeHandler.UpdateGroupSize);
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.MinGroupSize, GroupSizeHandler.UpdateGroupSize);
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.RerollShopFixedCost, RerollBlueprintViewPatch.SetRerollCost);

        }
    }
}
