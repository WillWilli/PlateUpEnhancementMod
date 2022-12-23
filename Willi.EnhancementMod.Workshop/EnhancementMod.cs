using UnityEngine;
using Kitchen;
using KitchenMods;
using Willi.EnhancementMod.Workshop.Config;
using HarmonyLib;

namespace Willi.EnhancementMod.Workshop
{
    public class EnhancementMod : IModInitializer
    {
        public const string Version = "1.0.3";

        private static GameObject GameObject { get; set; }
        
        public static SpawnItemGui GuiManager { get; private set; }
        
        public void PostActivate(Mod mod)
        {
            
        }

        public void PreInject()
        {
            Debug.Log("EnhancementMod Init");

            GameObject = new GameObject("Enhancement mod");

            GuiManager = GameObject.AddComponent<SpawnItemGui>();
            GameObject.AddComponent<UserSettingsGui>();

            Object.DontDestroyOnLoad(GameObject);


            var harmony = new Harmony("Willi.EnhancementMod");
            harmony.PatchAll(GetType().Assembly);
        }

        public void PostInject()
        {
            Debug.LogError("PosInject");
        }
    }
}
