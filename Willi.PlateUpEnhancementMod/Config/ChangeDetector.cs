using System;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Config
{
    public static class ChangeDetector
    {
        private static List<object> _configsToWatch = new List<object>();

        public static void Update()
        {
            DetectChanges(_configsToWatch);
        }

        public static void RegisterConfigToWatch<T>(ConfigEntry<T> configEntry, Action callbackOnChange)
        {
            _configsToWatch.Add(new ConfigChange<T>(configEntry, callbackOnChange));
        }

        private static void DetectChanges(List<object> configsToWatch)
        {
            foreach(var config in configsToWatch)
            {
                switch(config)
                {
                    case ConfigChange<bool> b:
                        DetectChangeEvent(b);
                        break;
                    case ConfigChange<int> i:
                        DetectChangeEvent(i);
                        break;
                    case ConfigChange<float> f:
                        DetectChangeEvent(f);
                        break;
                    default:
                        Log.LogError($"Cannot register config of type {config.GetType()}");
                        break;
                }
            }
        }

        private static void DetectChangeEvent<T>(ConfigChange<T> config) where T : struct
        {
            if (!config.ConfigEntry.Value.Equals(config.PreviousValue))
            {
                Log.LogError($"config changed from {config.PreviousValue} to {config.ConfigEntry.Value}");
                config.PreviousValue = config.ConfigEntry.Value;
            }
        }

        private class ConfigChange<T>
        {
            public ConfigChange(ConfigEntry<T> configEntry, Action callbackOnChange)
            {
                ConfigEntry = configEntry;
                PreviousValue = configEntry.Value;
                CallbackOnChange = callbackOnChange;
            }

            public virtual ConfigEntry<T> ConfigEntry { get; set; }
            public T PreviousValue { get; set; }
            public Action CallbackOnChange { get; set; }
        }
    }

    
}
