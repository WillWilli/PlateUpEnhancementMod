using UnityEngine;
using Kitchen;
using KitchenMods;
using Willi.EnhancementMod.Workshop.Config;
using HarmonyLib;
using Willi.EnhancementMod.Workshop.Mono;
using Willi.EnhancementMod.Workshop.Patches;
using Willi.EnhancementMod.Workshop.Helpers;

namespace Willi.EnhancementMod.Workshop
{
    public class EnhancementMod : IModInitializer
    {
        public const string Version = "1.0.3";

        public static GameObject GameObject { get; set; }


        public void PostActivate(Mod mod)
        {
            
        }

        public void PreInject()
        {
            Debug.Log("EnhancementMod Init");

            GameObject = new GameObject("Enhancement mod");
            GameObject.AddComponent<UserSettingsGui>();
            GameObject.AddComponent<SpawnItemGui>();
            GameObject.AddComponent<NoClipHandler>();
            GameObject.AddComponent<UserConfigUpdateDetector>();

            Object.DontDestroyOnLoad(GameObject);


            var harmony = new Harmony("Willi.EnhancementMod");
            harmony.PatchAll(GetType().Assembly);
        }

        public void PostInject()
        {
            ConfigHelper.LoadOrCreateUserConfig();
        }
    }
}
