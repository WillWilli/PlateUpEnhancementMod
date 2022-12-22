using UnityEngine;
using Kitchen;
using KitchenMods;

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

            GameObject = new GameObject("Kitchen Designer");
            GuiManager = GameObject.AddComponent<SpawnItemGui>();
            Object.DontDestroyOnLoad(GameObject);


            //var harmony = new Harmony("ONe.KitchenDesigner");
            //harmony.PatchAll(GetType().Assembly);
        }

        public void PostInject()
        {
            Debug.LogError("PosInject");
        }
    }
}
