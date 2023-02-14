using UnityEngine;
using KitchenMods;
using Willi.EnhancementMod.Workshop.Config;
using HarmonyLib;
using Willi.EnhancementMod.Workshop.Mono;
using Willi.EnhancementMod.Workshop.Helpers;

namespace Willi.EnhancementMod.Workshop
{
    public class EnhancementMod : IModInitializer
    {
        public const string Version = "0.5.1";
        public const string Name = "Willi.EnhancementMod";


        public static GameObject GameObject { get; set; }


        public void PostActivate(Mod mod)
        {
            
        }

        public void PreInject()
        {
            Log.Info($"Loading {Name}.v{Version}");

            GameObject = new GameObject(Name);
            GameObject.AddComponent<UserSettingsGui>();
            GameObject.AddComponent<SpawnItemGui>();
            GameObject.AddComponent<NoClipHandler>();
            GameObject.AddComponent<UserConfigUpdateDetector>();

            Object.DontDestroyOnLoad(GameObject);


            var harmony = new Harmony(Name);
            harmony.PatchAll(GetType().Assembly);
        }

        public void PostInject()
        {
            ConfigHelper.LoadOrCreateUserConfig();
            Log.Info($"Loaded.");
        }
    }
}
