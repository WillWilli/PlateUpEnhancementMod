using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Willi.EnhancementMod.Workshop.Helpers;
using KitchenData;

namespace Willi.EnhancementMod.Workshop.Config
{
    internal static class ConfigHelper
    {
        private static string UserConfigFileLocation;

        public static UserConfig UserConfig { get; set; } = new UserConfig();
        public static Dictionary<string, int> AllItems { get; private set; }

        public static void LoadOrCreateUserConfig()
        {
            AllItems = GetAllItems();

            UserConfigFileLocation = Path.Combine(Application.persistentDataPath, "EnhancementMod.Settings.json");

            if (File.Exists(UserConfigFileLocation))
            {
                LoadUserConfig();
            }
            else
            {
                UserConfig = new UserConfig();
                SaveUserConfig();
            }
        }

        public static void LoadUserConfig()
        {
            try
            {
                var jsonString = File.ReadAllText(UserConfigFileLocation);
                UserConfig = JsonConvert.DeserializeObject<UserConfig>(jsonString);
            }
            catch(Exception ex)
            {
                if (UserConfig == null)
                {
                    Log.Warning($"Failed to load user config from {UserConfigFileLocation}, using default values.");
                    UserConfig = new UserConfig();
                    SaveUserConfig();
                }
                Log.Warning($"Failed to load user config from {UserConfigFileLocation}.");
            }
        }

        public static void SaveUserConfig()
        {
            try
            {
                var jsonString = JsonConvert.SerializeObject(UserConfig, Formatting.Indented);
                File.WriteAllText(UserConfigFileLocation, jsonString);
                Log.Info($"Config file saved to { UserConfigFileLocation }");
            }
            catch
            {
                Log.Error("Failed to save user config");
            }
        }

        private static Dictionary<string, int> GetAllItems()
        {
            var items = new Dictionary<string, int>();

            var appliances = GameData.Main.Get<Appliance>();

            foreach (var appliance in appliances)
            {
                if (appliance.Name == string.Empty)
                    continue;

                int appendNumber = 1;
                var itemPotentialName = appliance.Name;
                while(items.ContainsKey(itemPotentialName))
                {
                    itemPotentialName = appliance.Name + appendNumber++;
                }

                items.Add(itemPotentialName, appliance.ID);
            }

            return items;
        }
    }
}
