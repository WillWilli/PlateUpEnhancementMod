using Kitchen;
using UnityEngine;

namespace Willi.PlateUpEnhancementMod.Helpers
{
    public static class PlayerHelper
    {
        private static GameObject _player;

        public static bool TryFindPlayer(out GameObject foundPlayer)
        {
            if (_player != null)
            {
                foundPlayer = _player;
                return true;
            }

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
