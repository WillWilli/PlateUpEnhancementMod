using BepInEx;
using HarmonyLib;
using System.Reflection;
using HarmonyLib.Tools;
using Willi.PlateUpEnhancementMod.Config;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;
using Willi.PlateUpEnhancementMod.EventHandlers;

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

            ChangeDetector.RegisterConfigToWatch(MaxGroupSize, Test1);

        }

        private void Test1()
        {
            Log.LogError("Executing callback...");
        }

        private void OnGUI()
        {
            SpawnItemsHandler.OnGui();
        }

        private void Update()
        {
            SpawnItemsHandler.Update();
            NoClipHandler.Update();
            ChangeDetector.Update();
        }
    }
}
