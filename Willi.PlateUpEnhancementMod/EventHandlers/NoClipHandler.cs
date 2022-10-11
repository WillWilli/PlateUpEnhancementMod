using System.Collections.Generic;
using UnityEngine;
using Willi.PlateUpEnhancementMod.Helpers;

namespace Willi.PlateUpEnhancementMod.EventHandlers
{
    public static class NoClipHandler
    {
        public static void SetNoClipState(bool isNoClip)
        {
            if (PlayerHelper.TryFindPlayers(out List<GameObject> players))
            {
                foreach(var player in players)
                {
                    var playerColliders = player.GetComponents<Collider>();
                    foreach(var collider in playerColliders)
                    {
                        collider.enabled = !isNoClip;
                    }
                }
            }
        }
    }
}
