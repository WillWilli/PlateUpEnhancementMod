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
                    var playerView = player.GetComponent<PlayerView>();
                    playerView.Speed = isNoClip ? playerView.Speed = 3000f * SpeedMultiplier.Value : playerView.Speed = 3000f;
                }
            }
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
