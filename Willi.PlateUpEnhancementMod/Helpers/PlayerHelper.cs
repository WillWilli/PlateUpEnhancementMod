using Kitchen;
using UnityEngine;

namespace Willi.PlateUpEnhancementMod.Helpers
{
    public static class PlayerHelper
    {
        public static bool TryFindPlayer(out GameObject foundPlayer)
        {
            var playerView = GameObject.FindObjectOfType<PlayerView>();
            if (playerView != null)
            {
                foundPlayer = playerView.GameObject;
                return true;
            }

            var playerClone = GameObject.Find("Player(Clone)");
            if (playerClone != null)
            {
                foundPlayer = playerClone;
                return true;
            }

            var player = GameObject.Find("Player");
            if (player != null)
            {
                foundPlayer = player;
                return true;
            }

            foundPlayer = null;
            return false;
        }
    }
}
