using System;
using System.Collections.Generic;
using BepInEx.Configuration;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Config
{
    public static class ChangeDetector
    {
        private static List<object> _configsToWatch = new List<object>();

        /// <summary>
        /// Register a  BepInEx ConfigEntry to be watched and invoke a method on change. Supports bool, int, float & string.
        /// </summary>
        /// <param name="configEntry">The ConfigEntry to be watched</param>
        /// <param name="callbackOnChange">The method to be called on config change, new config value passed in</param>
        /// 
        public static void RegisterConfigChangeCallback<T>(ConfigEntry<T> configEntry, Action<T> callbackOnChange)
        {
            _configsToWatch.Add(new ConfigEntryWatcher<T>(configEntry, callbackOnChange));
        }

        public static void InvokeCallbacks()
        {
            foreach(var config in _configsToWatch)
            {
                switch(config)
                {
                    case ConfigEntryWatcher<bool> configEntryWatcher:
                        DetectChange(configEntryWatcher);
                        break;
                    case ConfigEntryWatcher<int> configEntryWatcher:
                        DetectChange(configEntryWatcher);
                        break;
                    case ConfigEntryWatcher<float> configEntryWatcher:
                        DetectChange(configEntryWatcher);
                        break;
                    case ConfigEntryWatcher<string> configEntryWatcher:
                        DetectChange(configEntryWatcher);
                        break;
                    default:
                        Log.LogError($"Registered type of {config.GetType()} is not supported.");
                        break;
                }
            }
        }

        private static void DetectChange<T>(ConfigEntryWatcher<T> config)
        {
            if (!config.ConfigEntry.Value.Equals(config.PreviousValue))
            {
                //Log.LogInfo($"'{config.ConfigEntry.Definition}' changed from {config.PreviousValue} to {config.ConfigEntry.Value}");
                config.PreviousValue = config.ConfigEntry.Value;
                config.CallbackOnChange.Invoke(config.ConfigEntry.Value);
            }
        }

        private class ConfigEntryWatcher<T>
        {
            public ConfigEntryWatcher(ConfigEntry<T> configEntry, Action<T> callbackOnChange)
            {
                ConfigEntry = configEntry;
                PreviousValue = configEntry.Value;
                CallbackOnChange = callbackOnChange;
            }

            public ConfigEntry<T> ConfigEntry { get; set; }
            public T PreviousValue { get; set; }
            public Action<T> CallbackOnChange { get; set; }
        }
    }

    
}
