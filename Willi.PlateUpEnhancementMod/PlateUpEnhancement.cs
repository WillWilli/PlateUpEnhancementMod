using BepInEx;
using HarmonyLib;
using System.Reflection;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;
using HarmonyLib.Tools;
using Willi.PlateUpEnhancementMod.Config;
using Willi.PlateUpEnhancementMod.Helpers;
using UnityEngine;
using BepInEx.Configuration;
using System.Collections.Generic;
using System;
using Willi.PlateUpEnhancementMod.Extensions;
using System.Threading;

namespace Willi.PlateUpEnhancementMod
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    [BepInProcess("PlateUp.exe")]
    public class PlateUpEnhancement : BaseUnityPlugin
    {
        string searchText = String.Empty;
        List<string> _words;


        private void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), ModGuid);
            HarmonyFileLog.Enabled = true;


            Config.BindAllConfig();


            _words = GetItemNames();
        }

        bool isActive = false;
        private void OnGUI()
        {
            if (isActive)
            {
                windowRect = GUILayout.Window(0, windowRect, SpawnItemsDraggableWindow, "SpawnItems", GUILayout.Width(180), GUILayout.Height(400));
            }
        }

        private Rect windowRect = new Rect(Screen.width - 160, 40, 180, 400);
        Vector2 scrollPosition;

        void SpawnItemsDraggableWindow(int windowID)
        {
            searchText = GUILayout.TextField(searchText);
            GUILayout.Space(5);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, false, GUIStyle.none, GUI.skin.verticalScrollbar);
            for (int i = 0; i < _words.Count; i++)
            {
                if (string.IsNullOrEmpty(searchText) || _words[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    if (GUILayout.Button(new GUIContent(_words[i], $"Click button to spawn {_words[i]}")))
                    {
                        HandleSpawnItems.SpawnItem(_words[i].ToItemId(), 0);
                    }
                }
            }
            GUILayout.EndScrollView();
            GUI.DragWindow();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                isActive = !isActive;
                Log.LogError($"isActive: {isActive}");
            }
            HandleSpawnItems.Update();
        }
    }
}
