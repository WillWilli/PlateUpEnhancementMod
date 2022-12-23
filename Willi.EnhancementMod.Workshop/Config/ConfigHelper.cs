using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Willi.EnhancementMod.Workshop.Config
{
    internal static class ConfigHelper
    {
        private static string UserConfigFileName = "Mods/Willi/EnhancementMod.Settings.json";

        public static UserConfig UserConfig { get; set; } = LoadUserConfig();

        public static UserConfig LoadUserConfig()
        {
            Debug.LogError($"In Directory {Directory.GetCurrentDirectory()}");
            var jsonString = File.ReadAllText(UserConfigFileName);
            Debug.LogError(jsonString);
            return JsonConvert.DeserializeObject<UserConfig>(jsonString);
        }


        public static int ToItemId(this string itemName)
        {
            try
            {
                return GetAllItemsConfigs()
                    .First(config => config.Name == itemName)
                    .Id;
            }
            catch
            {
                throw new ArgumentException($"ID for item {itemName} does not exist.", itemName);
            }
        }

        public static List<string> GetItemNamesSorted()
        {
            var allItemNames = GetAllItemsConfigs().Select(config => config.Name).ToList();
            allItemNames.Sort();
            return allItemNames;
        }

        private static List<ItemConfig> GetAllItemsConfigs()
        {
            var itemIdFields = typeof(ItemIdReference).GetFields();

            var items = new List<ItemConfig>();
            foreach (var field in itemIdFields)
            {
                if (field.Name.StartsWith("_"))
                    continue;
                items.Add(GetItemConfigFromField(field));
            }

            return items;
        }

        private static ItemConfig GetItemConfigFromField(System.Reflection.FieldInfo field)
        {
            var fieldName = field.Name;
            var fieldValue = (int)field.GetValue(typeof(int));
            return new ItemConfig() { Name = fieldName, Id = fieldValue };
        }
    }
}
