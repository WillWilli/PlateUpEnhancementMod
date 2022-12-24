using Kitchen;
using System.Collections.Generic;
using UnityEngine;
using Willi.EnhancementMod.Workshop.Config;
using Willi.EnhancementMod.Workshop.Helpers;

namespace Willi.EnhancementMod.Workshop.Mono
{
    public class NoClipHandler : MonoBehaviour
    {
        private static bool isNoClip = false;
        private static float? defaultPlayerSpeed = null;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                isNoClip = !isNoClip;
                ToggleNoClip();
            }
        }

        private static void ToggleNoClip()
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
            playerView.Speed = (float)(isNoClip ? defaultPlayerSpeed * ConfigHelper.UserConfig.SpeedMultiplier : defaultPlayerSpeed);
        }
    }
}
