using BepInEx.Logging;
using HarmonyLib;
using Kitchen;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Entities;
using UnityEngine;
using static Willi.PlateUpEnhancementMod.Config.ConfigHelper;

namespace Willi.PlateUpEnhancementMod.Patches
{
    [HarmonyPatch]
    public static class HandleNewShopPatch
    {
        [HarmonyReversePatch]
        [HarmonyPatch(typeof(GenericSystemBase), "GetPostTiles")]
        [MethodImpl(MethodImplOptions.NoInlining)]
        static List<Vector3> GetPostTilesDummy(HandleNewShop instance) { return null; }

        [HarmonyPatch(typeof(HandleNewShop), "OnUpdate")]
        public static bool Prefix(
            HandleNewShop __instance,
            ref EntityQuery ___Blockers,
            ref EntityQuery ___NewShops,
            ref EntityQuery ___NewDecorShops,
            ref EntityQuery ___Extras,
            ref EntityQuery ___ShopOptions
            )
        {
            if (!IsModEnabled.Value)
                return true;

            if (___Blockers.IsEmpty && (!___NewShops.IsEmpty || !___NewDecorShops.IsEmpty))
            {
                int placedTile = 0;
                var floorTiles = GetPostTilesDummy(__instance);

                var idList = GetCustomShopItemsIdList();

                for (int i = 0; i < CustomShopNumItemsToSpawn.Value; i++)
                {
                    var randomIndex = UnityEngine.Random.Range(0, idList.Count - 1);
                    int randomApplianceId = idList[randomIndex];
                    var position = __instance.FindTile(ref placedTile, floorTiles);

                    PostHelpers.CreateBlueprintLetter(__instance.EntityManager, position, randomApplianceId, CustomShopPriceMultiplier.Value);
                }
            }

            return true; // return false to skip orignal method
        }
    }
}
