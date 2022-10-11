using System.Collections.Generic;
using System.Linq;
using Kitchen;
using UnityEngine;

namespace Willi.PlateUpEnhancementMod.Helpers
{
    public static class PlayerHelper
    {
        public static bool TryFindPlayers(out List<GameObject> foundPlayers)
        {
            var playerViews = GameObject.FindObjectsOfType<PlayerView>();
            if (playerViews.Count() > 0)
            {
                foundPlayers = playerViews.Select(p => p.GameObject).ToList();
                return true;
            }

            foundPlayers = null;
            return false;
        }
    }
}
