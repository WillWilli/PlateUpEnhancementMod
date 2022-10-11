using Willi.PlateUpEnhancementMod.EventHandlers;

namespace Willi.PlateUpEnhancementMod.Config
{
    public static class ChangeDetectorRegister
    {
        public static void RegisterAllCallbacks()
        {
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.IsNoClip, NoClipHandler.SetNoClipState);
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.MaxGroupSize, GroupSizeHandler.UpdateGroupSize);
            ChangeDetector.RegisterConfigChangeCallback(ConfigHelper.MinGroupSize, GroupSizeHandler.UpdateGroupSize);
        }
    }
}
