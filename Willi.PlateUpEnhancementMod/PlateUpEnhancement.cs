using BepInEx;
using HarmonyLib;
using Kitchen;
using Unity.Entities;
using UnityEngine;
using KitchenData;
using BepInEx.Configuration;
using System.Reflection;
using BepInEx.Logging;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;
using HarmonyLib.Tools;
using Willi.PlateUpEnhancementMod.Config;

namespace Willi.PlateUpEnhancementMod
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    [BepInProcess("PlateUp.exe")]
    public class PlateUpEnhancement : BaseUnityPlugin
    {
        private Harmony _harmony;
        private readonly static ManualLogSource _logger = BepInEx.Logging.Logger.CreateLogSource(ModGuid);
        static string SpawnItemInputField { get { return SpawnItemId.Value; } set { SpawnItemId.Value = value; } }

        private void Awake()
        {
            _harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), ModGuid);
            HarmonyFileLog.Enabled = true;

            Config.BindAllConfig();
        }

        private void Update()
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

        public static void HandleSpawnItemConfigManager(ConfigEntryBase itemId)
        {
            SpawnItemInputField = GUILayout.TextField(SpawnItemInputField, GUILayout.ExpandWidth(true));
            var buttonPressed = GUILayout.Button("spawn", GUILayout.Width(50));

            if (buttonPressed && ValidateItemIdUserInput(out int inputId))
            {
                SpawnItem(inputId, SpawnItemPrice.Value);
            }
        }

        private static bool ValidateItemIdUserInput(out int inputId)
        {
            if (!int.TryParse(SpawnItemInputField, out inputId))
            {
                _logger.LogWarning("Spawn item id is not an integer.");
                return false;
            }

            if (!GameData.Main.TryGet<Appliance>(inputId, out _, true))
            {
                _logger.LogWarning($"Item with id {inputId} does not exist.");
                return false;
            }

            return true;
        }

        private static void SpawnItem(int itemId, int price)
        {
            var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

            if (!TryFindPlayerPosition(out Vector3 spawnPosition))
            {
                _logger.LogWarning("Unable to find player positon, reverting to default spawn position.");
            }

            var entity = entityManager.CreateEntity();
            entityManager.AddComponentData<CCreateAppliance>(entity, new CCreateAppliance { ID = 1553046198 });
            entityManager.AddComponentData<CPosition>(entity, new CPosition(spawnPosition));
            entityManager.AddComponentData<CLetter>(entity, default(CLetter));
            entityManager.AddComponentData<CLetterBlueprint>(entity, new CLetterBlueprint
            {
                BlueprintID = AssetReference.Blueprint,
                ApplianceID = itemId,
                Price = price
            });
            entityManager.AddComponentData<CShopEntity>(entity, default(CShopEntity));
        }

        private static bool TryFindPlayerPosition(out Vector3 playerPosition)
        {
            var playerView = FindObjectOfType<PlayerView>();
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
