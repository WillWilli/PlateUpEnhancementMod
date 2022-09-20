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
        static string SpawnItemInputField;

        private void Awake()
        {
            _harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), ModGuid);
            HarmonyFileLog.Enabled = true;

            Config.BindAllConfig();

            SpawnItemInputField = SpawnItemId.Value.ToString();
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
            var spawnPosition = new Vector3(-2, 0, -4);

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
    }
}
