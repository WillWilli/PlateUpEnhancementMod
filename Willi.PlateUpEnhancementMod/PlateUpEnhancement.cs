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

            ChangeDetectorRegister.RegisterAllCallbacks();
        }

        private void OnGUI()
        {
            SpawnItemsHandler.OnGui();
        }

        private void Update()
        {
            NoClipHandler.SetNoClipState();
            SpawnItemsHandler.Update();
            NoClipHandler.Update();
            ChangeDetector.InvokeCallbacks();
        }
    }
}
