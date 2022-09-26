using BepInEx;
using HarmonyLib;
using System.Reflection;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;
using HarmonyLib.Tools;
using Willi.PlateUpEnhancementMod.Config;
using Willi.PlateUpEnhancementMod.Helpers;

namespace Willi.PlateUpEnhancementMod
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    [BepInProcess("PlateUp.exe")]
    public class PlateUpEnhancement : BaseUnityPlugin
    {
        private void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), ModGuid);
            HarmonyFileLog.Enabled = true;


            Config.BindAllConfig();
        }

        private void Update()
        {
            HandleSpawnItems.Update();
        }
    }
}
