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
        public const string Version = "0.5.2";
        public const string Name = "Willi.EnhancementMod";


        public static GameObject GameObject { get; set; }


        public void PostActivate(Mod mod)
        {
            Log.Info($"Loading {Name}.v{Version}");

            var harmony = new Harmony(Name);
            harmony.PatchAll(GetType().Assembly);
        }

        public void PreInject()
        {
            GameObject = new GameObject(Name);
            GameObject.AddComponent<UserSettingsGui>();
            GameObject.AddComponent<SpawnItemGui>();
            GameObject.AddComponent<NoClipHandler>();
            GameObject.AddComponent<UserConfigUpdateDetector>();

            Object.DontDestroyOnLoad(GameObject);

            ConfigHelper.LoadOrCreateUserConfig();
        }

        public void PostInject()
        {
            Log.Info($"Loaded.");
        }
    }
}
