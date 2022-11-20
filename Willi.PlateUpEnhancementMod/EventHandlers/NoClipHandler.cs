using Kitchen;
using System.Collections.Generic;
using UnityEngine;
using Willi.PlateUpEnhancementMod.Helpers;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;


namespace Willi.PlateUpEnhancementMod.EventHandlers
{
    public static class NoClipHandler
    {
        private static bool isNoClip = false;
        private static float? defaultPlayerSpeed = null;
        public static void SetNoClipState()
        {
            if (PlayerHelper.TryFindPlayers(out List<GameObject> players))
            {
                foreach (var player in players)
                {
                    var playerColliders = player.GetComponents<Collider>();
                    foreach (var collider in playerColliders)
                    {
                        collider.enabled = !isNoClip;
                    }

                    SetPlayerSpeed(player);
                }
            }
        }

        private static void SetPlayerSpeed(GameObject player)
        {
            var playerView = player.GetComponent<PlayerView>();
            if (defaultPlayerSpeed == null)
            {
                defaultPlayerSpeed = playerView.Speed;
            }
            playerView.Speed = isNoClip ? defaultPlayerSpeed * SpeedMultiplier.Value : defaultPlayerSpeed;
        }

        public static void Update()
        {
            if (NoClipKeyboardShortcut.Value.IsDown())
            {
                isNoClip = !isNoClip;
            }
        }
    }
}
