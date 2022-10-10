using Kitchen;
using KitchenData;
using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Willi.PlateUpEnhancementMod.Config;
using Willi.PlateUpEnhancementMod.Extensions;
using Willi.PlateUpEnhancementMod.Helpers;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;
using System.Linq;


namespace Willi.PlateUpEnhancementMod.EventHandlers
{
    public static class SpawnItemsHandler
    {
        private static bool isWindowActive = false;

        private static int initialXPosition = Screen.width - 190;
        private static int initialYPosition = 130;
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
            var spawnPosition = FindPlayerPosition();

            var entity = entityManager.CreateEntity();
            entityManager.AddComponentData(entity, new CCreateAppliance { ID = ItemIdReference.BlueprintLetter });
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

        private static Vector3 FindPlayerPosition()
        {
            if (PlayerHelper.TryFindPlayers(out List<GameObject> players))
            {
                return players.First().transform.position;
            }

            Log.LogWarning("Unable to find player positon, reverting to default spawn position.");
            return new Vector3(-2, 0, -4); // default to static positon
        }
    }
}
