using System.Collections.Generic;
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
                if (PlayerHelper.TryFindPlayers(out List<GameObject> players))
                {
                    foreach(var player in players)
                    {
                        var playerColliders = player.GetComponents<Collider>();
                        foreach(var collider in playerColliders)
                        {
                            collider.enabled = !IsNoClip.Value;
                        }
                    }
                }

                previousIsNoClip = IsNoClip.Value;
            }
        }
    }
}
