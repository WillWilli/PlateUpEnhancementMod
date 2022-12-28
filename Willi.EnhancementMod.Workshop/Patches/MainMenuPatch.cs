using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Kitchen;
using Willi.EnhancementMod.Workshop.Mono;

namespace Willi.EnhancementMod.Workshop.Patches
{
    [HarmonyPatch]
    [HarmonyPatch(typeof(MainMenu), "Setup")]
    internal class MainMenuPatch
    {
        private static MethodInfo _addButtonMethod;
        private static MethodInfo _requestMenuAction;
        private static Action<int> _buttonAction;

        [HarmonyPrefix]
        private static bool Prefix(MainMenu __instance)
        {
            if (_addButtonMethod == null)
            {
                _addButtonMethod = AccessTools.Method(typeof(MainMenu), "AddButton");
                _requestMenuAction = AccessTools.Method(typeof(MainMenu), "RequestAction");
            }

            _addButtonMethod.Invoke(__instance, new object[]
            {
                "Enhancement Mod",
                _buttonAction = (playerId) =>
                {
                    _requestMenuAction.Invoke(__instance, new object[] { PauseMenuAction.CloseMenu });
                    EnhancementMod.GameObject.GetComponent<UserSettingsGui>().ToggleWindow();
                },
                0, // arg
                1, // scale
                0.2f, // padding
            });

            return true;
        }
    }
}
