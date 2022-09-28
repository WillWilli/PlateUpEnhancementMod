using Kitchen;
using KitchenData;
using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Willi.PlateUpEnhancementMod.Extensions;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Helpers
{
    public static class HandleSpawnItems
    {
        private static bool isWindowActive = false;

        private static int initialXPosition = Screen.width - 190;
        private static int initialYPosition = 80;
        private static Rect windowRect = new Rect(initialXPosition, initialYPosition, 180, ItemSpawnerWindowHeight.Value);

        private static Vector2 scrollPosition;
        private static string searchText = string.Empty;
        private static List<string> _itemNames = GetItemNamesSorted();

        public static void OnGui()
        {
            if (isWindowActive)
            {
                windowRect = GUILayout.Window(0, windowRect, DraggableWindow, "Spawn Items", GUILayout.Width(180), GUILayout.Height(ItemSpawnerWindowHeight.Value));
            }
        }

        public static void Update()
        {
            if (SpawnItemMenuKeyboardShortcut.Value.IsDown())
            {
                isWindowActive = !isWindowActive;
            }
        }

        private static void DraggableWindow(int windowID)
        {
            GUILayout.Space(2);
            searchText = GUILayout.TextField(searchText);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, false, GUIStyle.none, GUI.skin.verticalScrollbar);
            for (int i = 0; i < _itemNames.Count; i++)
            {
                if (string.IsNullOrEmpty(searchText) || _itemNames[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    if (GUILayout.Button(new GUIContent(_itemNames[i], $"Click button to spawn {_itemNames[i]}")))
                    {
                        SpawnItem(_itemNames[i].ToItemId(), 0);
                    }
                }
            }
            GUILayout.EndScrollView();
            GUI.DragWindow();
        }

        private static void SpawnItem(int itemId, int price)
        {
            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

            if (!TryFindPlayerPosition(out Vector3 spawnPosition))
            {
                Log.LogWarning("Unable to find player positon, reverting to default spawn position.");
                spawnPosition = new Vector3(-2, 0, -4); // default to static positon
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
            var playerView = UnityEngine.Object.FindObjectOfType<PlayerView>();
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
