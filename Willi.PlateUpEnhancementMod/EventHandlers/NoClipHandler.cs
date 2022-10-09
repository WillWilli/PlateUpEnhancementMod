using UnityEngine;
using Willi.PlateUpEnhancementMod.Helpers;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.EventHandlers
{
    public static class NoClipHandler
    {
        private static bool previousIsNoClip;

        public static void Update()
        {
            if (IsNoClip.Value != previousIsNoClip)
            {
                if (PlayerHelper.TryFindPlayer(out GameObject player))
                {
                    var playerColliders = player.GetComponents<Collider>();
                    foreach(var collider in playerColliders)
                    {
                        collider.enabled = !IsNoClip.Value;
                    }
                }

                previousIsNoClip = IsNoClip.Value;
            }
        }
    }
}
