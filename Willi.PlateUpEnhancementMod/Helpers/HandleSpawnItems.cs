using BepInEx.Configuration;
using Kitchen;
using KitchenData;
using Unity.Entities;
using UnityEngine;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Helpers
{
    public static class HandleSpawnItems
    {
        static string SpawnItemInputField { get { return SpawnItemId.Value; } set { SpawnItemId.Value = value; } }

        public static void HandleSpawnItemConfigManager(ConfigEntryBase itemId)
        {
            SpawnItemInputField = GUILayout.TextField(SpawnItemInputField, GUILayout.ExpandWidth(true));
            var buttonPressed = GUILayout.Button("spawn", GUILayout.Width(50));

            if (buttonPressed && ValidateItemIdUserInput(out int inputId))
            {
                SpawnItem(inputId, SpawnItemPrice.Value);
            }
        }

        public static void Update()
        {
            HandleSpawnItemKeyboardShortcut();
        }

        private static void HandleSpawnItemKeyboardShortcut()
        {
            if (SpawnItemKeyboardShortcut.Value.IsDown() && ValidateItemIdUserInput(out int inputId))
            {
                SpawnItem(inputId, SpawnItemPrice.Value);
            }
        }

        private static bool ValidateItemIdUserInput(out int inputId)
        {
            if (!int.TryParse(SpawnItemInputField, out inputId))
            {
                Log.LogWarning("Spawn item id is not an integer.");
                return false;
            }

            if (!GameData.Main.TryGet<Appliance>(inputId, out _, true))
            {
                Log.LogWarning($"Item with id {inputId} does not exist.");
                return false;
            }

            return true;
        }

        private static void SpawnItem(int itemId, int price)
        {
            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

            if (!TryFindPlayerPosition(out Vector3 spawnPosition))
            {
                Log.LogWarning("Unable to find player positon, reverting to default spawn position.");
            }

            var entity = entityManager.CreateEntity();
            entityManager.AddComponentData(entity, new CCreateAppliance { ID = 1553046198 });
            entityManager.AddComponentData(entity, new CPosition(spawnPosition));
            entityManager.AddComponentData(entity, default(CLetter));
            entityManager.AddComponentData(entity, new CLetterBlueprint
            {
                BlueprintID = AssetReference.Blueprint,
                ApplianceID = itemId,
                Price = price
            });
            entityManager.AddComponentData(entity, default(CShopEntity));
        }

        private static bool TryFindPlayerPosition(out Vector3 playerPosition)
        {
            var playerView = Object.FindObjectOfType<PlayerView>();
            if (playerView != null)
            {
                playerPosition = playerView.transform.position;
                return true;
            }

            var playerClone = GameObject.Find("Player(Clone)");
            if (playerClone != null)
            {
                playerPosition = playerClone.transform.position;
                return true;
            }

            var player = GameObject.Find("Player");
            if (player != null)
            {
                playerPosition = player.transform.position;
                return true;
            }

            playerPosition = new Vector3(-2, 0, -4); // default to static positon
            return false;
        }
    }
}
