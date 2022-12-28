using UnityEngine;
using Willi.EnhancementMod.Workshop.Config;
using Willi.EnhancementMod.Workshop.Helpers;
using Willi.EnhancementMod.Workshop.Patches;

namespace Willi.EnhancementMod.Workshop.Mono
{
    internal class UserConfigUpdateDetector : MonoBehaviour
    {
        private UserConfig _prevUserConfig = new UserConfig();
        private UserConfig _savedUserConfig = new UserConfig();

        private void Start()
        {
            _prevUserConfig = new UserConfig(ConfigHelper.UserConfig);
        }

        private bool hasChanged = false;

        private void Update()
        {
            // IsModEnabled
            if (ConfigHelper.UserConfig.IsModEnabled != _prevUserConfig.IsModEnabled)
            {
                if (ConfigHelper.UserConfig.IsModEnabled)
                {
                    ConfigHelper.UserConfig = _savedUserConfig;
                }
                else
                {
                    _savedUserConfig = ConfigHelper.UserConfig;
                    _savedUserConfig.IsModEnabled = true;
                    ConfigHelper.UserConfig = new UserConfig() { IsModEnabled = false };
                }
                hasChanged = true;
            }
            // Group size
            if (ConfigHelper.UserConfig.MaxGroupSize != _prevUserConfig.MaxGroupSize ||
                ConfigHelper.UserConfig.MinGroupSize != _prevUserConfig.MinGroupSize)
            {
                GroupSizeHandler.UpdateGroupSize();
                hasChanged = true;
            }

            // Reroll cost
            if (ConfigHelper.UserConfig.RerollShopFixedCost != _prevUserConfig.RerollShopFixedCost)
            {
                RerollBlueprintViewPatch.SetRerollCost(10);
                hasChanged = true;
            }


            if (hasChanged)
            {
                _prevUserConfig = new UserConfig(ConfigHelper.UserConfig);
                hasChanged = false;
            }

        }
    }
}
