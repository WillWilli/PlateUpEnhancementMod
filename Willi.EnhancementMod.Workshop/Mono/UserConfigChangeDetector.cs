using UnityEngine;
using Willi.EnhancementMod.Workshop.Config;
using Willi.EnhancementMod.Workshop.Helpers;
using Willi.EnhancementMod.Workshop.Patches;

namespace Willi.EnhancementMod.Workshop.Mono
{
    internal class UserConfigUpdateDetector : MonoBehaviour
    {
        private UserConfig _prevUserConfig;

        private void Start()
        {
            _prevUserConfig = new UserConfig(ConfigHelper.UserConfig);
        }

        private void Update()
        {
            if (ConfigHelper.UserConfig.MaxGroupSize != _prevUserConfig.MaxGroupSize ||
                ConfigHelper.UserConfig.MinGroupSize != _prevUserConfig.MinGroupSize)
            {
                GroupSizeHandler.UpdateGroupSize();
                _prevUserConfig = new UserConfig(ConfigHelper.UserConfig);
            }

            if (ConfigHelper.UserConfig.RerollShopFixedCost != _prevUserConfig.RerollShopFixedCost)
            {
                RerollBlueprintViewPatch.SetRerollCost();
                _prevUserConfig = new UserConfig(ConfigHelper.UserConfig);
            }
        }
    }
}
