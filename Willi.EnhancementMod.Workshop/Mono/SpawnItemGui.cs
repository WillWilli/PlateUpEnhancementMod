using System;
using System.Collections.Generic;
using System.Linq;
using Kitchen;
using KitchenData;
using Unity.Entities;
using UnityEngine;
using Willi.EnhancementMod.Workshop.Config;
using Willi.EnhancementMod.Workshop.Extensions;
using Willi.EnhancementMod.Workshop.Helpers;
using EventType = UnityEngine.EventType;

namespace Willi.EnhancementMod.Workshop.Mono
{
    public class SpawnItemGui : MonoBehaviour
    {
        private static bool isWindowActive = false;

        private static int initialXPosition = Screen.width - 190;
        private static int initialYPosition = 130;

        private static int WindowWidth = 190;
        private static Rect windowRect = new Rect(initialXPosition, initialYPosition, WindowWidth, ConfigHelper.UserConfig.ItemSpawnerWindowHeight); //TODO: Make configurable

        private static Vector2 _scrollPosition;
        private static string _itemSearchText = string.Empty;
        private static string _customIdText = string.Empty;

        private static List<string> _itemNames = ConfigHelper.GetItemNamesSorted();

        private void OnGUI()
        {
            if (isWindowActive)
            {
                windowRect = GUILayout.Window(0, windowRect, DraggableWindow, "Spawn Items", GuiStyles.WindowStyle, GUILayout.Width(WindowWidth), GUILayout.Height(ConfigHelper.UserConfig.ItemSpawnerWindowHeight));
                //GUI.FocusControl("SearchInput");
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(ConfigHelper.UserConfig.SpawnItemMenuKeyboardShortcut))
            {
                isWindowActive = !isWindowActive;
            }
        }

        private static void DraggableWindow(int windowID)
        {
            GUILayout.Space(2);
            GUI.SetNextControlName("SearchInput");
            _itemSearchText = GUILayout.TextField(_itemSearchText);

            ScrollableItemList();

            GUILayout.Label("custom id spawn:", GuiStyles.LabelStyle);
            GUILayout.BeginHorizontal();
            _customIdText = GUILayout.TextField(_customIdText);
            if (GUILayout.Button("spawn", GuiStyles.ButtonStyle, GUILayout.Width(WindowWidth * 0.3f)) && int.TryParse(_customIdText, out int itemId))
            {
                SpawnItem(itemId, 0);
            }
            GUILayout.EndHorizontal();
            GUI.DragWindow();
        }

        private static void ScrollableItemList()
        {
            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition, false, false, GUIStyle.none, GUI.skin.verticalScrollbar);
            for (int i = 0; i < _itemNames.Count; i++)
            {
                if (string.IsNullOrEmpty(_itemSearchText) || _itemNames[i].Contains(_itemSearchText, StringComparison.OrdinalIgnoreCase))
                {
                    if (GUILayout.Button(new GUIContent(_itemNames[i], $"Click button to spawn {_itemNames[i]}"), GuiStyles.ButtonStyle))
                    {
                        SpawnItem(_itemNames[i].ToItemId(), 0);
                    }
                }
            }
            GUILayout.EndScrollView();
        }

        private static void SpawnItem(int itemId, int price)
        {
            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            var spawnPosition = FindPlayerPosition();

            var entity = entityManager.CreateEntity();
            entityManager.AddComponentData(entity, new CCreateAppliance { ID = ItemIdReference._BlueprintLetter });
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

            Debug.LogWarning("Unable to find player positon, reverting to default spawn position.");
            return new Vector3(-2, 0, -4); // default to static positon
        }
    }
}
