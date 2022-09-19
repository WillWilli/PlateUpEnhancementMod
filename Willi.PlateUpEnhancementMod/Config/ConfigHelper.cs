using BepInEx.Configuration;
using System.Collections.Generic;
using UnityEngine;

namespace Willi.PlateUpEnhancementMod.Config
{
    public static class ConfigHelper
    {
        public const string ModGuid = "Willi.ShopEnhancement";
        public const string ModName = "Shop & Item Enhancements by Willi";
        public const string ModVersion = "0.1";

        // General
        public static ConfigEntry<bool> LogItemIdsOnStartup;
        public static ConfigEntry<float> MoneyRewardMultiplier;
        public static ConfigEntry<float> NumberOfCustomersMultiplier;


        // Default shop
        public static ConfigEntry<int> DefaultShopNumberOfItems;
        public static ConfigEntry<bool> DefaultShopOverrideSettings;
        public static ConfigEntry<float> DefaultShopUpgradedChance;

        // Custom shop
        public static ConfigEntry<int> CustomShopNumItemsToSpawn;
        public static ConfigEntry<float> CustomShopPriceMultiplier;


        // Spawn Items
        public static ConfigEntry<int> SpawnItemId;
        public static ConfigEntry<int> SpawnItemPrice;
        public static ConfigEntry<KeyboardShortcut> SpawnItemKeyboardShortcut;

        #region Item Id's Config
        public static ConfigEntry<int> HeatedMixerId;
        public static ConfigEntry<int> ConveyorMixerId;
        public static ConfigEntry<int> RapidMixerId;
        public static ConfigEntry<int> MixerId;
        public static ConfigEntry<int> SuppliesId;
        public static ConfigEntry<int> CompactorBinId;
        public static ConfigEntry<int> ComposterBinId;
        public static ConfigEntry<int> ExpandedBinId;
        public static ConfigEntry<int> BinId;
        public static ConfigEntry<int> FireExtinguisherId;
        public static ConfigEntry<int> FloorBufferId;
        public static ConfigEntry<int> KitchenFloorProtectorId;
        public static ConfigEntry<int> FastMopId;
        public static ConfigEntry<int> LastingMopId;
        public static ConfigEntry<int> MopId;
        public static ConfigEntry<int> RobotBufferId;
        public static ConfigEntry<int> RobotMopId;
        public static ConfigEntry<int> CoffeeMachineId;
        public static ConfigEntry<int> ConveyorId;
        public static ConfigEntry<int> CombinerId;
        public static ConfigEntry<int> SmartGrabberId;
        public static ConfigEntry<int> GrabberId;
        public static ConfigEntry<int> PortionerId;
        public static ConfigEntry<int> CounterId;
        public static ConfigEntry<int> WorkstationId;
        public static ConfigEntry<int> AffordableBinId;
        public static ConfigEntry<int> GumballMachineId;
        public static ConfigEntry<int> NeonSignId;
        public static ConfigEntry<int> NeonSign2Id;
        public static ConfigEntry<int> CeilingLightId;
        public static ConfigEntry<int> StockPictureId;
        public static ConfigEntry<int> DirtyFloorSignId;
        public static ConfigEntry<int> BarrelId;
        public static ConfigEntry<int> BookcaseId;
        public static ConfigEntry<int> DartboardId;
        public static ConfigEntry<int> FireplaceId;
        public static ConfigEntry<int> RugId;
        public static ConfigEntry<int> WallLightId;
        public static ConfigEntry<int> CandelabraId;
        public static ConfigEntry<int> ChandelierId;
        public static ConfigEntry<int> PreciousFlowerId;
        public static ConfigEntry<int> ClassicalGlobeId;
        public static ConfigEntry<int> PaintingId;
        public static ConfigEntry<int> Rug2Id;
        public static ConfigEntry<int> StatueId;
        public static ConfigEntry<int> BrandMascotId;
        public static ConfigEntry<int> TidyPlantId;
        public static ConfigEntry<int> CeilingLight2Id;
        public static ConfigEntry<int> AbstractLampId;
        public static ConfigEntry<int> VaseId;
        public static ConfigEntry<int> IndoorfountainId;
        public static ConfigEntry<int> CalmPaintingId;
        public static ConfigEntry<int> PlantId;
        public static ConfigEntry<int> DumbwaiterId;
        public static ConfigEntry<int> GasLimiterId;
        public static ConfigEntry<int> GasOverrideId;
        public static ConfigEntry<int> DangerHobId;
        public static ConfigEntry<int> SafetyHobId;
        public static ConfigEntry<int> HobId;
        public static ConfigEntry<int> DisplayStandId;
        public static ConfigEntry<int> BlueprintCabinetId;
        public static ConfigEntry<int> CopyingDeskId;
        public static ConfigEntry<int> DiscountDeskId;
        public static ConfigEntry<int> BlueprintDeskId;
        public static ConfigEntry<int> ResearchDeskId;
        public static ConfigEntry<int> SpecialsTerminalId;
        public static ConfigEntry<int> OrderingTerminalId;
        public static ConfigEntry<int> MicrowaveId;
        public static ConfigEntry<int> OvenId;
        public static ConfigEntry<int> ApplesId;
        public static ConfigEntry<int> BeansId;
        public static ConfigEntry<int> BroccoliId;
        public static ConfigEntry<int> BurgerBunsId;
        public static ConfigEntry<int> CarrotsId;
        public static ConfigEntry<int> CheeseId;
        public static ConfigEntry<int> ChristmasCrackersId;
        public static ConfigEntry<int> EggsId;
        public static ConfigEntry<int> FlourId;
        public static ConfigEntry<int> HotdogbunId;
        public static ConfigEntry<int> HotDogsId;
        public static ConfigEntry<int> IceCreamId;
        public static ConfigEntry<int> ExtraKetchupId;
        public static ConfigEntry<int> LettuceId;
        public static ConfigEntry<int> MeatId;
        public static ConfigEntry<int> MushroomsId;
        public static ConfigEntry<int> ExtraMustardId;
        public static ConfigEntry<int> NutsId;
        public static ConfigEntry<int> OilId;
        public static ConfigEntry<int> OlivesId;
        public static ConfigEntry<int> OnionId;
        public static ConfigEntry<int> PotatoId;
        public static ConfigEntry<int> RiceId;
        public static ConfigEntry<int> ThickcutmeatId;
        public static ConfigEntry<int> ThincutmeatId;
        public static ConfigEntry<int> TomatoId;
        public static ConfigEntry<int> TurkeyId;
        public static ConfigEntry<int> WineId;
        public static ConfigEntry<int> AutoPlaterId;
        public static ConfigEntry<int> DishRackId;
        public static ConfigEntry<int> PlatesId;
        public static ConfigEntry<int> PotStackId;
        public static ConfigEntry<int> ServingBoardsId;
        public static ConfigEntry<int> WoksId;
        public static ConfigEntry<int> FreezerId;
        public static ConfigEntry<int> FrozenPrepStationId;
        public static ConfigEntry<int> PrepStationId;
        public static ConfigEntry<int> BreadsticksId;
        public static ConfigEntry<int> CandleBoxId;
        public static ConfigEntry<int> FlowerPotId;
        public static ConfigEntry<int> NapkinsId;
        public static ConfigEntry<int> SharpCutleryId;
        public static ConfigEntry<int> SpecialsMenuId;
        public static ConfigEntry<int> CoffeeTableId;
        public static ConfigEntry<int> BarTableId;
        public static ConfigEntry<int> TableSimpleClothId;
        public static ConfigEntry<int> MetalTableId;
        public static ConfigEntry<int> TableFancyClothId;
        public static ConfigEntry<int> DiningTableId;
        public static ConfigEntry<int> RollingPinId;
        public static ConfigEntry<int> ScrubbingBrushId;
        public static ConfigEntry<int> SharpKnifeId;
        public static ConfigEntry<int> TrainersId;
        public static ConfigEntry<int> WelliesId;
        public static ConfigEntry<int> WorkBootsId;
        public static ConfigEntry<int> TrayStandId;
        public static ConfigEntry<int> DishWasherId;
        public static ConfigEntry<int> WashBasinId;
        public static ConfigEntry<int> SinkId;
        public static ConfigEntry<int> PowerSinkId;
        public static ConfigEntry<int> SoakingSinkId;
        #endregion

        #region Item Spawn Rates Config
        public static ConfigEntry<int> HeatedMixerSpawnRate;
        public static ConfigEntry<int> ConveyorMixerSpawnRate;
        public static ConfigEntry<int> RapidMixerSpawnRate;
        public static ConfigEntry<int> MixerSpawnRate;
        public static ConfigEntry<int> SuppliesSpawnRate;
        public static ConfigEntry<int> CompactorBinSpawnRate;
        public static ConfigEntry<int> ComposterBinSpawnRate;
        public static ConfigEntry<int> ExpandedBinSpawnRate;
        public static ConfigEntry<int> BinSpawnRate;
        public static ConfigEntry<int> FireExtinguisherSpawnRate;
        public static ConfigEntry<int> FloorBufferSpawnRate;
        public static ConfigEntry<int> KitchenFloorProtectorSpawnRate;
        public static ConfigEntry<int> FastMopSpawnRate;
        public static ConfigEntry<int> LastingMopSpawnRate;
        public static ConfigEntry<int> MopSpawnRate;
        public static ConfigEntry<int> RobotBufferSpawnRate;
        public static ConfigEntry<int> RobotMopSpawnRate;
        public static ConfigEntry<int> CoffeeMachineSpawnRate;
        public static ConfigEntry<int> ConveyorSpawnRate;
        public static ConfigEntry<int> CombinerSpawnRate;
        public static ConfigEntry<int> SmartGrabberSpawnRate;
        public static ConfigEntry<int> GrabberSpawnRate;
        public static ConfigEntry<int> PortionerSpawnRate;
        public static ConfigEntry<int> CounterSpawnRate;
        public static ConfigEntry<int> WorkstationSpawnRate;
        public static ConfigEntry<int> AffordableBinSpawnRate;
        public static ConfigEntry<int> GumballMachineSpawnRate;
        public static ConfigEntry<int> NeonSignSpawnRate;
        public static ConfigEntry<int> NeonSign2SpawnRate;
        public static ConfigEntry<int> CeilingLightSpawnRate;
        public static ConfigEntry<int> StockPictureSpawnRate;
        public static ConfigEntry<int> DirtyFloorSignSpawnRate;
        public static ConfigEntry<int> BarrelSpawnRate;
        public static ConfigEntry<int> BookcaseSpawnRate;
        public static ConfigEntry<int> DartboardSpawnRate;
        public static ConfigEntry<int> FireplaceSpawnRate;
        public static ConfigEntry<int> RugSpawnRate;
        public static ConfigEntry<int> WallLightSpawnRate;
        public static ConfigEntry<int> CandelabraSpawnRate;
        public static ConfigEntry<int> ChandelierSpawnRate;
        public static ConfigEntry<int> PreciousFlowerSpawnRate;
        public static ConfigEntry<int> ClassicalGlobeSpawnRate;
        public static ConfigEntry<int> PaintingSpawnRate;
        public static ConfigEntry<int> Rug2SpawnRate;
        public static ConfigEntry<int> StatueSpawnRate;
        public static ConfigEntry<int> BrandMascotSpawnRate;
        public static ConfigEntry<int> TidyPlantSpawnRate;
        public static ConfigEntry<int> CeilingLight2SpawnRate;
        public static ConfigEntry<int> AbstractLampSpawnRate;
        public static ConfigEntry<int> VaseSpawnRate;
        public static ConfigEntry<int> IndoorfountainSpawnRate;
        public static ConfigEntry<int> CalmPaintingSpawnRate;
        public static ConfigEntry<int> PlantSpawnRate;
        public static ConfigEntry<int> DumbwaiterSpawnRate;
        public static ConfigEntry<int> GasLimiterSpawnRate;
        public static ConfigEntry<int> GasOverideSpawnRate;
        public static ConfigEntry<int> DangerHobSpawnRate;
        public static ConfigEntry<int> SafetyHobSpawnRate;
        public static ConfigEntry<int> HobSpawnRate;
        public static ConfigEntry<int> DisplayStandSpawnRate;
        public static ConfigEntry<int> BlueprintCabinetSpawnRate;
        public static ConfigEntry<int> CopyingDeskSpawnRate;
        public static ConfigEntry<int> DiscountDeskSpawnRate;
        public static ConfigEntry<int> BlueprintDeskSpawnRate;
        public static ConfigEntry<int> ResearchDeskSpawnRate;
        public static ConfigEntry<int> SpecialsTerminalSpawnRate;
        public static ConfigEntry<int> OrderingTerminalSpawnRate;
        public static ConfigEntry<int> MicrowaveSpawnRate;
        public static ConfigEntry<int> OvenSpawnRate;
        public static ConfigEntry<int> ApplesSpawnRate;
        public static ConfigEntry<int> BeansSpawnRate;
        public static ConfigEntry<int> BroccoliSpawnRate;
        public static ConfigEntry<int> BurgerBunsSpawnRate;
        public static ConfigEntry<int> CarrotsSpawnRate;
        public static ConfigEntry<int> CheeseSpawnRate;
        public static ConfigEntry<int> ChristmasCrackersSpawnRate;
        public static ConfigEntry<int> EggsSpawnRate;
        public static ConfigEntry<int> FlourSpawnRate;
        public static ConfigEntry<int> HotdogbunSpawnRate;
        public static ConfigEntry<int> HotDogsSpawnRate;
        public static ConfigEntry<int> IceCreamSpawnRate;
        public static ConfigEntry<int> ExtraKetchupSpawnRate;
        public static ConfigEntry<int> LettuceSpawnRate;
        public static ConfigEntry<int> MeatSpawnRate;
        public static ConfigEntry<int> MushroomsSpawnRate;
        public static ConfigEntry<int> ExtraMustardSpawnRate;
        public static ConfigEntry<int> NutsSpawnRate;
        public static ConfigEntry<int> OilSpawnRate;
        public static ConfigEntry<int> OlivesSpawnRate;
        public static ConfigEntry<int> OnionSpawnRate;
        public static ConfigEntry<int> PotatoSpawnRate;
        public static ConfigEntry<int> RiceSpawnRate;
        public static ConfigEntry<int> ThickcutmeatSpawnRate;
        public static ConfigEntry<int> ThincutmeatSpawnRate;
        public static ConfigEntry<int> TomatoSpawnRate;
        public static ConfigEntry<int> TurkeySpawnRate;
        public static ConfigEntry<int> WineSpawnRate;
        public static ConfigEntry<int> AutoPlaterSpawnRate;
        public static ConfigEntry<int> DishRackSpawnRate;
        public static ConfigEntry<int> PlatesSpawnRate;
        public static ConfigEntry<int> PotStackSpawnRate;
        public static ConfigEntry<int> ServingBoardsSpawnRate;
        public static ConfigEntry<int> WoksSpawnRate;
        public static ConfigEntry<int> FreezerSpawnRate;
        public static ConfigEntry<int> FrozenPrepStationSpawnRate;
        public static ConfigEntry<int> PrepStationSpawnRate;
        public static ConfigEntry<int> BreadsticksSpawnRate;
        public static ConfigEntry<int> CandleBoxSpawnRate;
        public static ConfigEntry<int> FlowerPotSpawnRate;
        public static ConfigEntry<int> NapkinsSpawnRate;
        public static ConfigEntry<int> SharpCutlerySpawnRate;
        public static ConfigEntry<int> SpecialsMenuSpawnRate;
        public static ConfigEntry<int> CoffeeTableSpawnRate;
        public static ConfigEntry<int> BarTableSpawnRate;
        public static ConfigEntry<int> TableSimpleClothSpawnRate;
        public static ConfigEntry<int> MetalTableSpawnRate;
        public static ConfigEntry<int> TableFancyClothSpawnRate;
        public static ConfigEntry<int> DiningTableSpawnRate;
        public static ConfigEntry<int> RollingPinSpawnRate;
        public static ConfigEntry<int> ScrubbingBrushSpawnRate;
        public static ConfigEntry<int> SharpKnifeSpawnRate;
        public static ConfigEntry<int> TrainersSpawnRate;
        public static ConfigEntry<int> WelliesSpawnRate;
        public static ConfigEntry<int> WorkBootsSpawnRate;
        public static ConfigEntry<int> TrayStandSpawnRate;
        public static ConfigEntry<int> DishWasherSpawnRate;
        public static ConfigEntry<int> WashBasinSpawnRate;
        public static ConfigEntry<int> SinkSpawnRate;
        public static ConfigEntry<int> PowerSinkSpawnRate;
        public static ConfigEntry<int> SoakingSinkSpawnRate;
        #endregion

        public static void BindAllConfig(this ConfigFile config)
        {
            config
                .BindItemSpawnerConfig()
                .BindDefaultShopConfig()
                .BindCustomShopConfig()
                .BindAllItemsConfig()
                .BindGeneralConfig();
        }

        private static ConfigFile BindItemSpawnerConfig(this ConfigFile config)
        {
            SpawnItemId = config.Bind("1. Spawn Any Item", "ItemIdToSpawn:", -571205127,
                new ConfigDescription("Enter an item id to spawn it", null, new ConfigDescription("The price of the item when spawned", null, new ConfigurationManagerAttributes { CustomDrawer = PlateUpEnhancement.HandleSpawnItemConfigManager, Order = 100 })));
            SpawnItemPrice = config.Bind("1. Spawn Any Item", "PriceOfItem", 10, new ConfigDescription("The price of the item when spawned", null, new ConfigurationManagerAttributes { Order = 90 }));
            SpawnItemKeyboardShortcut = config.Bind("1. Spawn Any Item", "KeyboardShortcut", new KeyboardShortcut(KeyCode.J), new ConfigDescription("Use this keyboard shortcut to spawn the item", null, new ConfigurationManagerAttributes { Order = 80 }));

            return config;
        }

        private static ConfigFile BindDefaultShopConfig(this ConfigFile config)
        {
            DefaultShopOverrideSettings = config.Bind("2. Default Shop", "OverrideDefaultShopSettings", false, new ConfigDescription("Whether or not to override the shop settings with these custom settings", null, new ConfigurationManagerAttributes { Order = 100 }));
            DefaultShopNumberOfItems = config.Bind("2. Default Shop", "NumberOfItemsToSpawn", 5, new ConfigDescription("The numbers of items to spawn in each shop", null, new ConfigurationManagerAttributes { Order = 90 }));
            DefaultShopUpgradedChance = config.Bind("2. Default Shop", "UpgradeChance", 0.5f, new ConfigDescription("The chance of getting an upgraded shop", new AcceptableValueRange<float>(0, 1), new ConfigurationManagerAttributes { Order = 80 }));

            return config;
        }
        private static ConfigFile BindCustomShopConfig(this ConfigFile config)
        {
            CustomShopNumItemsToSpawn = config.Bind("3. Custom Shop", "NumberOfShopItemsToSpawn", 2, new ConfigDescription("The number of items to spawn in the custom shop", null, new ConfigurationManagerAttributes { Order = 100 }));
            CustomShopPriceMultiplier = config.Bind("3. Custom Shop", "PriceMultiplier", 1f, new ConfigDescription("The price factor of items spawned in the custom shop", new AcceptableValueRange<float>(0f, 10f), new ConfigurationManagerAttributes { Order = 90 }));
            return config;
        }

        private static ConfigFile BindGeneralConfig(this ConfigFile config)
        {
            MoneyRewardMultiplier = config.Bind("0. General", "MoneyRewardMultiplier", 1f, new ConfigDescription("Multiplier for the money rewards.", null, new ConfigurationManagerAttributes { Order = 100 }));
            NumberOfCustomersMultiplier = config.Bind("0. General", "NumberOfCustomersMultiplier", 1f, new ConfigDescription("Multiplier for the number of customers to arrive each day.", null, new ConfigurationManagerAttributes { Order = 90 }));
            LogItemIdsOnStartup = config.Bind("0. General", "ShouldLogItemIdsOnStartup", false, new ConfigDescription("Whether or not to log the item IDs in the console on startup", null, new ConfigurationManagerAttributes { Order = 80 }));

            return config;
        }


        public static List<int> GetCustomShopItemsIdList()
        {
            var allItemsConfig = GetAllItemsConfig();
            var itemIdSpawnList = new List<int>();
            foreach (KeyValuePair<int, int> itemConfig in allItemsConfig)
            {
                for (int i = 0; i < itemConfig.Value; i++)
                {
                    itemIdSpawnList.Add(itemConfig.Key);
                }
            }
            return itemIdSpawnList;
        }

        private static Dictionary<int, int> GetAllItemsConfig()
        {
            return new Dictionary<int, int>()
            {
                { HeatedMixerId.Value, HeatedMixerSpawnRate.Value },
                { ConveyorMixerId.Value, ConveyorMixerSpawnRate.Value },
                { RapidMixerId.Value, RapidMixerSpawnRate.Value },
                { MixerId.Value, MixerSpawnRate.Value },
                { SuppliesId.Value, SuppliesSpawnRate.Value },
                { CompactorBinId.Value, CompactorBinSpawnRate.Value },
                { ComposterBinId.Value, ComposterBinSpawnRate.Value },
                { ExpandedBinId.Value, ExpandedBinSpawnRate.Value },
                { BinId.Value, BinSpawnRate.Value },
                { FireExtinguisherId.Value, FireExtinguisherSpawnRate.Value },
                { FloorBufferId.Value, FloorBufferSpawnRate.Value },
                { KitchenFloorProtectorId.Value, KitchenFloorProtectorSpawnRate.Value },
                { FastMopId.Value, FastMopSpawnRate.Value },
                { LastingMopId.Value, LastingMopSpawnRate.Value },
                { MopId.Value, MopSpawnRate.Value },
                { RobotBufferId.Value, RobotBufferSpawnRate.Value },
                { RobotMopId.Value, RobotMopSpawnRate.Value },
                { CoffeeMachineId.Value, CoffeeMachineSpawnRate.Value },
                { ConveyorId.Value, ConveyorSpawnRate.Value },
                { CombinerId.Value, CombinerSpawnRate.Value },
                { SmartGrabberId.Value, SmartGrabberSpawnRate.Value },
                { GrabberId.Value, GrabberSpawnRate.Value },
                { PortionerId.Value, PortionerSpawnRate.Value },
                { CounterId.Value, CounterSpawnRate.Value },
                { WorkstationId.Value, WorkstationSpawnRate.Value },
                { AffordableBinId.Value, AffordableBinSpawnRate.Value },
                { GumballMachineId.Value, GumballMachineSpawnRate.Value },
                { NeonSignId.Value, NeonSignSpawnRate.Value },
                { NeonSign2Id.Value, NeonSign2SpawnRate.Value },
                { CeilingLightId.Value, CeilingLightSpawnRate.Value },
                { StockPictureId.Value, StockPictureSpawnRate.Value },
                { DirtyFloorSignId.Value, DirtyFloorSignSpawnRate.Value },
                { BarrelId.Value, BarrelSpawnRate.Value },
                { BookcaseId.Value, BookcaseSpawnRate.Value },
                { DartboardId.Value, DartboardSpawnRate.Value },
                { FireplaceId.Value, FireplaceSpawnRate.Value },
                { RugId.Value, RugSpawnRate.Value },
                { WallLightId.Value, WallLightSpawnRate.Value },
                { CandelabraId.Value, CandelabraSpawnRate.Value },
                { ChandelierId.Value, ChandelierSpawnRate.Value },
                { PreciousFlowerId.Value, PreciousFlowerSpawnRate.Value },
                { ClassicalGlobeId.Value, ClassicalGlobeSpawnRate.Value },
                { PaintingId.Value, PaintingSpawnRate.Value },
                { Rug2Id.Value, Rug2SpawnRate.Value },
                { StatueId.Value, StatueSpawnRate.Value },
                { BrandMascotId.Value, BrandMascotSpawnRate.Value },
                { TidyPlantId.Value, TidyPlantSpawnRate.Value },
                { CeilingLight2Id.Value, CeilingLight2SpawnRate.Value },
                { AbstractLampId.Value, AbstractLampSpawnRate.Value },
                { VaseId.Value, VaseSpawnRate.Value },
                { IndoorfountainId.Value, IndoorfountainSpawnRate.Value },
                { CalmPaintingId.Value, CalmPaintingSpawnRate.Value },
                { PlantId.Value, PlantSpawnRate.Value },
                { DumbwaiterId.Value, DumbwaiterSpawnRate.Value },
                { GasLimiterId.Value, GasLimiterSpawnRate.Value },
                { GasOverrideId.Value, GasOverideSpawnRate.Value },
                { DangerHobId.Value, DangerHobSpawnRate.Value },
                { SafetyHobId.Value, SafetyHobSpawnRate.Value },
                { HobId.Value, HobSpawnRate.Value },
                { DisplayStandId.Value, DisplayStandSpawnRate.Value },
                { BlueprintCabinetId.Value, BlueprintCabinetSpawnRate.Value },
                { CopyingDeskId.Value, CopyingDeskSpawnRate.Value },
                { DiscountDeskId.Value, DiscountDeskSpawnRate.Value },
                { BlueprintDeskId.Value, BlueprintDeskSpawnRate.Value },
                { ResearchDeskId.Value, ResearchDeskSpawnRate.Value },
                { SpecialsTerminalId.Value, SpecialsTerminalSpawnRate.Value },
                { OrderingTerminalId.Value, OrderingTerminalSpawnRate.Value },
                { MicrowaveId.Value, MicrowaveSpawnRate.Value },
                { OvenId.Value, OvenSpawnRate.Value },
                { ApplesId.Value, ApplesSpawnRate.Value },
                { BeansId.Value, BeansSpawnRate.Value },
                { BroccoliId.Value, BroccoliSpawnRate.Value },
                { BurgerBunsId.Value, BurgerBunsSpawnRate.Value },
                { CarrotsId.Value, CarrotsSpawnRate.Value },
                { CheeseId.Value, CheeseSpawnRate.Value },
                { ChristmasCrackersId.Value, ChristmasCrackersSpawnRate.Value },
                { EggsId.Value, EggsSpawnRate.Value },
                { FlourId.Value, FlourSpawnRate.Value },
                { HotdogbunId.Value, HotdogbunSpawnRate.Value },
                { HotDogsId.Value, HotDogsSpawnRate.Value },
                { IceCreamId.Value, IceCreamSpawnRate.Value },
                { ExtraKetchupId.Value, ExtraKetchupSpawnRate.Value },
                { LettuceId.Value, LettuceSpawnRate.Value },
                { MeatId.Value, MeatSpawnRate.Value },
                { MushroomsId.Value, MushroomsSpawnRate.Value },
                { ExtraMustardId.Value, ExtraMustardSpawnRate.Value },
                { NutsId.Value, NutsSpawnRate.Value },
                { OilId.Value, OilSpawnRate.Value },
                { OlivesId.Value, OlivesSpawnRate.Value },
                { OnionId.Value, OnionSpawnRate.Value },
                { PotatoId.Value, PotatoSpawnRate.Value },
                { RiceId.Value, RiceSpawnRate.Value },
                { ThickcutmeatId.Value, ThickcutmeatSpawnRate.Value },
                { ThincutmeatId.Value, ThincutmeatSpawnRate.Value },
                { TomatoId.Value, TomatoSpawnRate.Value },
                { TurkeyId.Value, TurkeySpawnRate.Value },
                { WineId.Value, WineSpawnRate.Value },
                { AutoPlaterId.Value, AutoPlaterSpawnRate.Value },
                { DishRackId.Value, DishRackSpawnRate.Value },
                { PlatesId.Value, PlatesSpawnRate.Value },
                { PotStackId.Value, PotStackSpawnRate.Value },
                { ServingBoardsId.Value, ServingBoardsSpawnRate.Value },
                { WoksId.Value, WoksSpawnRate.Value },
                { FreezerId.Value, FreezerSpawnRate.Value },
                { FrozenPrepStationId.Value, FrozenPrepStationSpawnRate.Value },
                { PrepStationId.Value, PrepStationSpawnRate.Value },
                { BreadsticksId.Value, BreadsticksSpawnRate.Value },
                { CandleBoxId.Value, CandleBoxSpawnRate.Value },
                { FlowerPotId.Value, FlowerPotSpawnRate.Value },
                { NapkinsId.Value, NapkinsSpawnRate.Value },
                { SharpCutleryId.Value, SharpCutlerySpawnRate.Value },
                { SpecialsMenuId.Value, SpecialsMenuSpawnRate.Value },
                { CoffeeTableId.Value, CoffeeTableSpawnRate.Value },
                { BarTableId.Value, BarTableSpawnRate.Value },
                { TableSimpleClothId.Value, TableSimpleClothSpawnRate.Value },
                { MetalTableId.Value, MetalTableSpawnRate.Value },
                { TableFancyClothId.Value, TableFancyClothSpawnRate.Value },
                { DiningTableId.Value, DiningTableSpawnRate.Value },
                { RollingPinId.Value, RollingPinSpawnRate.Value },
                { ScrubbingBrushId.Value, ScrubbingBrushSpawnRate.Value },
                { SharpKnifeId.Value, SharpKnifeSpawnRate.Value },
                { TrainersId.Value, TrainersSpawnRate.Value },
                { WelliesId.Value, WelliesSpawnRate.Value },
                { WorkBootsId.Value, WorkBootsSpawnRate.Value },
                { TrayStandId.Value, TrayStandSpawnRate.Value },
                { DishWasherId.Value, DishWasherSpawnRate.Value },
                { WashBasinId.Value, WashBasinSpawnRate.Value },
                { SinkId.Value, SinkSpawnRate.Value },
                { PowerSinkId.Value, PowerSinkSpawnRate.Value },
                { SoakingSinkId.Value, SoakingSinkSpawnRate.Value },
            };
        }

        private static ConfigFile BindAllItemsConfig(this ConfigFile config)
        {
            HeatedMixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "HeatedMixerSpawnRate", 0);
            ConveyorMixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ConveyorMixerSpawnRate", 0);
            RapidMixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RapSpawnRateMixerSpawnRate", 0);
            MixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MixerSpawnRate", 0);
            SuppliesSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SuppliesSpawnRate", 0);
            CompactorBinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CompactorBinSpawnRate", 0);
            ComposterBinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ComposterBinSpawnRate", 0);
            ExpandedBinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ExpandedBinSpawnRate", 0);
            BinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BinSpawnRate", 0);
            FireExtinguisherSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FireExtinguisherSpawnRate", 0);
            FloorBufferSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FloorBufferSpawnRate", 0);
            KitchenFloorProtectorSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "KitchenFloorProtectorSpawnRate", 0);
            FastMopSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FastMopSpawnRate", 0);
            LastingMopSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "LastingMopSpawnRate", 0);
            MopSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MopSpawnRate", 0);
            RobotBufferSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RobotBufferSpawnRate", 0);
            RobotMopSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RobotMopSpawnRate", 0);
            CoffeeMachineSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CoffeeMachineSpawnRate", 0);
            ConveyorSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ConveyorSpawnRate", 1);
            CombinerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CombinerSpawnRate", 1);
            SmartGrabberSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SmartGrabberSpawnRate", 1);
            GrabberSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "GrabberSpawnRate", 1);
            PortionerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PortionerSpawnRate", 0);
            CounterSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CounterSpawnRate", 0);
            WorkstationSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WorkstationSpawnRate", 0);
            AffordableBinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "AffordableBinSpawnRate", 0);
            GumballMachineSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "GumballMachineSpawnRate", 0);
            NeonSignSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "NeonSignSpawnRate", 0);
            NeonSign2SpawnRate = config.Bind("4. Custom Shop Spawn Rates", "NeonSign2SpawnRate", 0);
            CeilingLight2SpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CeilingLight2SpawnRate", 0);
            StockPictureSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "StockPictureSpawnRate", 0);
            DirtyFloorSignSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DirtyFloorSignSpawnRate", 0);
            BarrelSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BarrelSpawnRate", 0);
            BookcaseSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BookcaseSpawnRate", 0);
            DartboardSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DartboardSpawnRate", 0);
            FireplaceSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FireplaceSpawnRate", 0);
            RugSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RugSpawnRate", 0);
            WallLightSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WallLightSpawnRate", 0);
            CandelabraSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CandelabraSpawnRate", 0);
            ChandelierSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ChandelierSpawnRate", 0);
            PreciousFlowerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PreciousFlowerSpawnRate", 0);
            ClassicalGlobeSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ClassicalGlobeSpawnRate", 0);
            PaintingSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PaintingSpawnRate", 0);
            Rug2SpawnRate = config.Bind("4. Custom Shop Spawn Rates", "Rug2SpawnRate", 0);
            StatueSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "StatueSpawnRate", 0);
            BrandMascotSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BrandMascotSpawnRate", 0);
            TidyPlantSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TSpawnRateyPlantSpawnRate", 0);
            CeilingLightSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CeilingLightSpawnRate", 0);
            AbstractLampSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "AbstractLampSpawnRate", 0);
            VaseSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "VaseSpawnRate", 0);
            IndoorfountainSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "IndoorfountainSpawnRate", 0);
            CalmPaintingSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CalmPaintingSpawnRate", 0);
            PlantSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PlantSpawnRate", 0);
            DumbwaiterSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DumbwaiterSpawnRate", 0);
            GasLimiterSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "GasLimiterSpawnRate", 0);
            GasOverideSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "GasOverrSpawnRateeSpawnRate", 0);
            DangerHobSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DangerHobSpawnRate", 0);
            SafetyHobSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SafetyHobSpawnRate", 0);
            HobSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "HobSpawnRate", 0);
            DisplayStandSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DisplayStandSpawnRate", 0);
            BlueprintCabinetSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BlueprintCabinetSpawnRate", 1);
            CopyingDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CopyingDeskSpawnRate", 0);
            DiscountDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DiscountDeskSpawnRate", 0);
            BlueprintDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BlueprintDeskSpawnRate", 0);
            ResearchDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ResearchDeskSpawnRate", 0);
            SpecialsTerminalSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SpecialsTerminalSpawnRate", 0);
            OrderingTerminalSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "OrderingTerminalSpawnRate", 0);
            MicrowaveSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MicrowaveSpawnRate", 0);
            OvenSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "OvenSpawnRate", 0);
            ApplesSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ApplesSpawnRate", 0);
            BeansSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BeansSpawnRate", 0);
            BroccoliSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BroccoliSpawnRate", 0);
            BurgerBunsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BurgerBunsSpawnRate", 0);
            CarrotsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CarrotsSpawnRate", 0);
            CheeseSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CheeseSpawnRate", 0);
            ChristmasCrackersSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ChristmasCrackersSpawnRate", 0);
            EggsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "EggsSpawnRate", 0);
            FlourSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FlourSpawnRate", 0);
            HotdogbunSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "HotdogbunSpawnRate", 0);
            HotDogsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "HotDogsSpawnRate", 0);
            IceCreamSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "IceCreamSpawnRate", 0);
            ExtraKetchupSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ExtraKetchupSpawnRate", 0);
            LettuceSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "LettuceSpawnRate", 0);
            MeatSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MeatSpawnRate", 0);
            MushroomsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MushroomsSpawnRate", 0);
            ExtraMustardSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ExtraMustardSpawnRate", 0);
            NutsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "NutsSpawnRate", 0);
            OilSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "OilSpawnRate", 0);
            OlivesSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "OlivesSpawnRate", 0);
            OnionSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "OnionSpawnRate", 0);
            PotatoSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PotatoSpawnRate", 0);
            RiceSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RiceSpawnRate", 0);
            ThickcutmeatSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ThickcutmeatSpawnRate", 0);
            ThincutmeatSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ThincutmeatSpawnRate", 0);
            TomatoSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TomatoSpawnRate", 0);
            TurkeySpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TurkeySpawnRate", 0);
            WineSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WineSpawnRate", 0);
            AutoPlaterSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "AutoPlaterSpawnRate", 0);
            DishRackSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DishRackSpawnRate", 0);
            PlatesSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PlatesSpawnRate", 0);
            PotStackSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PotStackSpawnRate", 0);
            ServingBoardsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ServingBoardsSpawnRate", 0);
            WoksSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WoksSpawnRate", 0);
            FreezerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FreezerSpawnRate", 0);
            FrozenPrepStationSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FrozenPrepStationSpawnRate", 0);
            PrepStationSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PrepStationSpawnRate", 0);
            BreadsticksSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BreadsticksSpawnRate", 0);
            CandleBoxSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CandleBoxSpawnRate", 0);
            FlowerPotSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FlowerPotSpawnRate", 0);
            NapkinsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "NapkinsSpawnRate", 0);
            SharpCutlerySpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SharpCutlerySpawnRate", 0);
            SpecialsMenuSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SpecialsMenuSpawnRate", 0);
            CoffeeTableSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CoffeeTableSpawnRate", 0);
            BarTableSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BarTableSpawnRate", 0);
            TableSimpleClothSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TableSimpleClothSpawnRate", 0);
            MetalTableSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MetalTableSpawnRate", 0);
            TableFancyClothSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TableFancyClothSpawnRate", 0);
            DiningTableSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DiningTableSpawnRate", 0);
            RollingPinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RollingPinSpawnRate", 0);
            ScrubbingBrushSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ScrubbingBrushSpawnRate", 0);
            SharpKnifeSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SharpKnifeSpawnRate", 0);
            TrainersSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TrainersSpawnRate", 0);
            WelliesSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WelliesSpawnRate", 0);
            WorkBootsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WorkBootsSpawnRate", 0);
            TrayStandSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TrayStandSpawnRate", 0);
            DishWasherSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DishWasherSpawnRate", 1);
            WashBasinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WashBasinSpawnRate", 0);
            SinkSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SinkSpawnRate", 0);
            PowerSinkSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PowerSinkSpawnRate", 0);
            SoakingSinkSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SoakingSinkSpawnRate", 1);

            HeatedMixerId = config.Bind("5. Item IDs", "HeatedMixerId", 505496455);
            ConveyorMixerId = config.Bind("5. Item IDs", "ConveyorMixerId", -1357906425);
            RapidMixerId = config.Bind("5. Item IDs", "RapidMixerId", -1440053805);
            MixerId = config.Bind("5. Item IDs", "MixerId", 1329097317);
            SuppliesId = config.Bind("5. Item IDs", "SuppliesId", -1013770159);
            CompactorBinId = config.Bind("5. Item IDs", "CompactorBinId", 2127051779);
            ComposterBinId = config.Bind("5. Item IDs", "ComposterBinId", -1632826946);
            ExpandedBinId = config.Bind("5. Item IDs", "ExpandedBinId", -1855909480);
            BinId = config.Bind("5. Item IDs", "BinId", 1551609169);
            FireExtinguisherId = config.Bind("5. Item IDs", "FireExtinguisherId", 1286554202);
            FloorBufferId = config.Bind("5. Item IDs", "FloorBufferId", 1351951642);
            KitchenFloorProtectorId = config.Bind("5. Item IDs", "KitchenFloorProtectorId", 1765889988);
            FastMopId = config.Bind("5. Item IDs", "FastMopId", -1495393751);
            LastingMopId = config.Bind("5. Item IDs", "LastingMopId", 1776760557);
            MopId = config.Bind("5. Item IDs", "MopId", -1993346570);
            RobotBufferId = config.Bind("5. Item IDs", "RobotBufferId", -1723340146);
            RobotMopId = config.Bind("5. Item IDs", "RobotMopId", -2147057861);
            CoffeeMachineId = config.Bind("5. Item IDs", "CoffeeMachineId", -1609758240);
            ConveyorId = config.Bind("5. Item IDs", "ConveyorId", 1973114260);
            CombinerId = config.Bind("5. Item IDs", "CombinerId", -1906799936);
            SmartGrabberId = config.Bind("5. Item IDs", "SmartGrabberId", -1238047163);
            GrabberId = config.Bind("5. Item IDs", "GrabberId", -1029710921);
            PortionerId = config.Bind("5. Item IDs", "PortionerId", -1462602185);
            CounterId = config.Bind("5. Item IDs", "CounterId", -1248669347);
            WorkstationId = config.Bind("5. Item IDs", "WorkstationId", -1573577293);
            AffordableBinId = config.Bind("5. Item IDs", "AffordableBinId", 620400448);
            GumballMachineId = config.Bind("5. Item IDs", "GumballMachineId", 1830133512);
            NeonSignId = config.Bind("5. Item IDs", "NeonSignId", 1724963734);
            NeonSign2Id = config.Bind("5. Item IDs", "NeonSign2Id", 371247235);
            CeilingLightId = config.Bind("5. Item IDs", "CeilingLightId", 230540973);
            StockPictureId = config.Bind("5. Item IDs", "StockPictureId", -1472471467);
            DirtyFloorSignId = config.Bind("5. Item IDs", "DirtyFloorSignId", -2108088224);
            BarrelId = config.Bind("5. Item IDs", "BarrelId", 1569358344);
            BookcaseId = config.Bind("5. Item IDs", "BookcaseId", -60168847);
            DartboardId = config.Bind("5. Item IDs", "DartboardId", -1941237931);
            FireplaceId = config.Bind("5. Item IDs", "FireplaceId", -441525746);
            RugId = config.Bind("5. Item IDs", "RugId", 591400026);
            WallLightId = config.Bind("5. Item IDs", "WallLightId", -1628995120);
            CandelabraId = config.Bind("5. Item IDs", "CandelabraId", -13481890);
            ChandelierId = config.Bind("5. Item IDs", "ChandelierId", 1233091186);
            PreciousFlowerId = config.Bind("5. Item IDs", "PreciousFlowerId", -1180623135);
            ClassicalGlobeId = config.Bind("5. Item IDs", "ClassicalGlobeId", 642318074);
            PaintingId = config.Bind("5. Item IDs", "PaintingId", -1486785449);
            Rug2Id = config.Bind("5. Item IDs", "Rug2Id", 2076966627);
            StatueId = config.Bind("5. Item IDs", "StatueId", -972644436);
            BrandMascotId = config.Bind("5. Item IDs", "BrandMascotId", 1551024733);
            TidyPlantId = config.Bind("5. Item IDs", "TidyPlantId", -1339970600);
            CeilingLight2Id = config.Bind("5. Item IDs", "CeilingLight2Id", 908498444);
            AbstractLampId = config.Bind("5. Item IDs", "AbstractLampId", 744277037);
            VaseId = config.Bind("5. Item IDs", "VaseId", 531866927);
            IndoorfountainId = config.Bind("5. Item IDs", "IndoorfountainId", 1220439284);
            CalmPaintingId = config.Bind("5. Item IDs", "CalmPaintingId", 668664567);
            PlantId = config.Bind("5. Item IDs", "PlantId", 756364626);
            DumbwaiterId = config.Bind("5. Item IDs", "DumbwaiterId", 532998682);
            GasLimiterId = config.Bind("5. Item IDs", "GasLimiterId", 1921027834);
            GasOverrideId = config.Bind("5. Item IDs", "GasOverrideId", -770041014);
            DangerHobId = config.Bind("5. Item IDs", "DangerHobId", -1448690107);
            SafetyHobId = config.Bind("5. Item IDs", "SafetyHobId", 1266458729);
            HobId = config.Bind("5. Item IDs", "HobId", 862493270);
            DisplayStandId = config.Bind("5. Item IDs", "DisplayStandId", -1813414500);
            BlueprintCabinetId = config.Bind("5. Item IDs", "BlueprintCabinetId", -571205127);
            CopyingDeskId = config.Bind("5. Item IDs", "CopyingDeskId", -729493805);
            DiscountDeskId = config.Bind("5. Item IDs", "DiscountDeskId", 1586911545);
            BlueprintDeskId = config.Bind("5. Item IDs", "BlueprintDeskId", 1446975727);
            ResearchDeskId = config.Bind("5. Item IDs", "ResearchDeskId", 1139247360);
            SpecialsTerminalId = config.Bind("5. Item IDs", "SpecialsTerminalId", -246383526);
            OrderingTerminalId = config.Bind("5. Item IDs", "OrderingTerminalId", -1610332021);
            MicrowaveId = config.Bind("5. Item IDs", "MicrowaveId", -1311702572);
            OvenId = config.Bind("5. Item IDs", "OvenId", -1068749602);
            ApplesId = config.Bind("5. Item IDs", "ApplesId", -905438738);
            BeansId = config.Bind("5. Item IDs", "BeansId", 1807525572);
            BroccoliId = config.Bind("5. Item IDs", "BroccoliId", -1573812073);
            BurgerBunsId = config.Bind("5. Item IDs", "BurgerBunsId", 759552160);
            CarrotsId = config.Bind("5. Item IDs", "CarrotsId", -452101383);
            CheeseId = config.Bind("5. Item IDs", "CheeseId", -117339838);
            ChristmasCrackersId = config.Bind("5. Item IDs", "ChristmasCrackersId", 303858729);
            EggsId = config.Bind("5. Item IDs", "EggsId", 961148621);
            FlourId = config.Bind("5. Item IDs", "FlourId", 925796718);
            HotdogbunId = config.Bind("5. Item IDs", "HotdogbunId", -1132411297);
            HotDogsId = config.Bind("5. Item IDs", "HotDogsId", 1799769627);
            IceCreamId = config.Bind("5. Item IDs", "IceCreamId", -1533430406);
            ExtraKetchupId = config.Bind("5. Item IDs", "ExtraKetchupId", -965827229);
            LettuceId = config.Bind("5. Item IDs", "LettuceId", 1193867305);
            MeatId = config.Bind("5. Item IDs", "MeatId", -484165118);
            MushroomsId = config.Bind("5. Item IDs", "MushroomsId", -1097889139);
            ExtraMustardId = config.Bind("5. Item IDs", "ExtraMustardId", -117356585);
            NutsId = config.Bind("5. Item IDs", "NutsId", 1834063794);
            OilId = config.Bind("5. Item IDs", "OilId", -1963699221);
            OlivesId = config.Bind("5. Item IDs", "OlivesId", -1434800013);
            OnionId = config.Bind("5. Item IDs", "OnionId", -2042103798);
            PotatoId = config.Bind("5. Item IDs", "PotatoId", 44541785);
            RiceId = config.Bind("5. Item IDs", "RiceId", -1201769154);
            ThickcutmeatId = config.Bind("5. Item IDs", "ThickcutmeatId", -1507801323);
            ThincutmeatId = config.Bind("5. Item IDs", "ThincutmeatId", 1800865634);
            TomatoId = config.Bind("5. Item IDs", "TomatoId", -712909563);
            TurkeyId = config.Bind("5. Item IDs", "TurkeyId", -1506824829);
            WineId = config.Bind("5. Item IDs", "WineId", -1353971407);
            AutoPlaterId = config.Bind("5. Item IDs", "AutoPlaterId", 739504637);
            DishRackId = config.Bind("5. Item IDs", "DishRackId", 434150763);
            PlatesId = config.Bind("5. Item IDs", "PlatesId", 1313469794);
            PotStackId = config.Bind("5. Item IDs", "PotStackId", -957949759);
            ServingBoardsId = config.Bind("5. Item IDs", "ServingBoardsId", 235423916);
            WoksId = config.Bind("5. Item IDs", "WoksId", 314862254);
            FreezerId = config.Bind("5. Item IDs", "FreezerId", -1857890774);
            FrozenPrepStationId = config.Bind("5. Item IDs", "FrozenPrepStationId", -759808000);
            PrepStationId = config.Bind("5. Item IDs", "PrepStationId", 1656358740);
            BreadsticksId = config.Bind("5. Item IDs", "BreadsticksId", 639111696);
            CandleBoxId = config.Bind("5. Item IDs", "CandleBoxId", 1358522063);
            FlowerPotId = config.Bind("5. Item IDs", "FlowerPotId", 221442949);
            NapkinsId = config.Bind("5. Item IDs", "NapkinsId", 1528688658);
            SharpCutleryId = config.Bind("5. Item IDs", "SharpCutleryId", 2080633647);
            SpecialsMenuId = config.Bind("5. Item IDs", "SpecialsMenuId", 446555792);
            CoffeeTableId = config.Bind("5. Item IDs", "CoffeeTableId", 1648733244);
            BarTableId = config.Bind("5. Item IDs", "BarTableId", -3721951);
            TableSimpleClothId = config.Bind("5. Item IDs", "TableSimpleClothId", -34659638);
            MetalTableId = config.Bind("5. Item IDs", "MetalTableId", -203679687);
            TableFancyClothId = config.Bind("5. Item IDs", "TableFancyClothId", -2019409936);
            DiningTableId = config.Bind("5. Item IDs", "DiningTableId", 209074140);
            RollingPinId = config.Bind("5. Item IDs", "RollingPinId", 1738351766);
            ScrubbingBrushId = config.Bind("5. Item IDs", "ScrubbingBrushId", 624465484);
            SharpKnifeId = config.Bind("5. Item IDs", "SharpKnifeId", 2023704259);
            TrainersId = config.Bind("5. Item IDs", "TrainersId", 723626409);
            WelliesId = config.Bind("5. Item IDs", "WelliesId", 1796077718);
            WorkBootsId = config.Bind("5. Item IDs", "WorkBootsId", 230848637);
            TrayStandId = config.Bind("5. Item IDs", "TrayStandId", 1129858275);
            DishWasherId = config.Bind("5. Item IDs", "DishWasherId", -823922901);
            WashBasinId = config.Bind("5. Item IDs", "WashBasinId", -214126192);
            SinkId = config.Bind("5. Item IDs", "SinkId", 1083874952);
            PowerSinkId = config.Bind("5. Item IDs", "PowerSinkId", 1467371088);
            SoakingSinkId = config.Bind("5. Item IDs", "SoakingSinkId", 1860904347);

            return config;
        }
    }
}
