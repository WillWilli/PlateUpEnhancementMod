using BepInEx.Configuration;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Willi.PlateUpEnhancementMod.Config
{
    public static class ConfigHelper
    {
        public const string ModGuid = "Willi.PlateUpEnhancementMod";
        public const string ModName = "Shop & Item Enhancements by Willi";
        public const string ModVersion = "0.2.0";

        public readonly static ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource(ModGuid);

        // General
        public static ConfigEntry<float> MoneyRewardMultiplier { get; set; }
        public static ConfigEntry<float> PatienceMultiplier { get; set; }
        public static ConfigEntry<float> NumberOfCustomersMultiplier { get; set; }
        public static ConfigEntry<int> MinGroupSize { get; set; }
        public static ConfigEntry<int> MaxGroupSize { get; set; }

        // Default shop
        public static ConfigEntry<int> DefaultShopNumberOfItems { get; set; }
        public static ConfigEntry<bool> DefaultShopOverrideSettings { get; set; }
        public static ConfigEntry<float> DefaultShopUpgradedChance { get; set; }

        // Custom shop
        public static ConfigEntry<int> CustomShopNumItemsToSpawn { get; set; }
        public static ConfigEntry<float> CustomShopPriceMultiplier { get; set; }

        // Spawn Items
        public static ConfigEntry<int> ItemSpawnerWindowHeight { get; set; }
        public static ConfigEntry<int> ItemSpawnerWindowWidth { get; set; }
        public static ConfigEntry<KeyboardShortcut> SpawnItemMenuKeyboardShortcut { get; set; }

        // Debug
        public static ConfigEntry<bool> LogItemIdsOnStartup;

        #region Item Id's Config
        private static ConfigEntry<int> HeatedMixerId;
        private static ConfigEntry<int> ConveyorMixerId;
        private static ConfigEntry<int> RapidMixerId;
        private static ConfigEntry<int> MixerId;
        private static ConfigEntry<int> SuppliesId;
        private static ConfigEntry<int> CompactorBinId;
        private static ConfigEntry<int> ComposterBinId;
        private static ConfigEntry<int> ExpandedBinId;
        private static ConfigEntry<int> BinId;
        private static ConfigEntry<int> FireExtinguisherId;
        private static ConfigEntry<int> FloorBufferId;
        private static ConfigEntry<int> KitchenFloorProtectorId;
        private static ConfigEntry<int> FastMopId;
        private static ConfigEntry<int> LastingMopId;
        private static ConfigEntry<int> MopId;
        private static ConfigEntry<int> RobotBufferId;
        private static ConfigEntry<int> RobotMopId;
        private static ConfigEntry<int> CoffeeMachineId;
        private static ConfigEntry<int> ConveyorId;
        private static ConfigEntry<int> CombinerId;
        private static ConfigEntry<int> SmartGrabberId;
        private static ConfigEntry<int> GrabberId;
        private static ConfigEntry<int> PortionerId;
        private static ConfigEntry<int> CounterId;
        private static ConfigEntry<int> WorkstationId;
        private static ConfigEntry<int> AffordableBinId;
        private static ConfigEntry<int> GumballMachineId;
        private static ConfigEntry<int> NeonSignId;
        private static ConfigEntry<int> NeonSign2Id;
        private static ConfigEntry<int> CeilingLightId;
        private static ConfigEntry<int> StockPictureId;
        private static ConfigEntry<int> DirtyFloorSignId;
        private static ConfigEntry<int> BarrelId;
        private static ConfigEntry<int> BookcaseId;
        private static ConfigEntry<int> DartboardId;
        private static ConfigEntry<int> FireplaceId;
        private static ConfigEntry<int> RugId;
        private static ConfigEntry<int> WallLightId;
        private static ConfigEntry<int> CandelabraId;
        private static ConfigEntry<int> ChandelierId;
        private static ConfigEntry<int> PreciousFlowerId;
        private static ConfigEntry<int> ClassicalGlobeId;
        private static ConfigEntry<int> PaintingId;
        private static ConfigEntry<int> Rug2Id;
        private static ConfigEntry<int> StatueId;
        private static ConfigEntry<int> BrandMascotId;
        private static ConfigEntry<int> TidyPlantId;
        private static ConfigEntry<int> CeilingLight2Id;
        private static ConfigEntry<int> AbstractLampId;
        private static ConfigEntry<int> VaseId;
        private static ConfigEntry<int> IndoorfountainId;
        private static ConfigEntry<int> CalmPaintingId;
        private static ConfigEntry<int> PlantId;
        private static ConfigEntry<int> DumbwaiterId;
        private static ConfigEntry<int> GasLimiterId;
        private static ConfigEntry<int> GasOverrideId;
        private static ConfigEntry<int> DangerHobId;
        private static ConfigEntry<int> SafetyHobId;
        private static ConfigEntry<int> HobId;
        private static ConfigEntry<int> DisplayStandId;
        private static ConfigEntry<int> BlueprintCabinetId;
        private static ConfigEntry<int> CopyingDeskId;
        private static ConfigEntry<int> DiscountDeskId;
        private static ConfigEntry<int> BlueprintDeskId;
        private static ConfigEntry<int> ResearchDeskId;
        private static ConfigEntry<int> SpecialsTerminalId;
        private static ConfigEntry<int> OrderingTerminalId;
        private static ConfigEntry<int> MicrowaveId;
        private static ConfigEntry<int> OvenId;
        private static ConfigEntry<int> ApplesId;
        private static ConfigEntry<int> BeansId;
        private static ConfigEntry<int> BroccoliId;
        private static ConfigEntry<int> BurgerBunsId;
        private static ConfigEntry<int> CarrotsId;
        private static ConfigEntry<int> CheeseId;
        private static ConfigEntry<int> ChristmasCrackersId;
        private static ConfigEntry<int> EggsId;
        private static ConfigEntry<int> FlourId;
        private static ConfigEntry<int> HotdogbunId;
        private static ConfigEntry<int> HotDogsId;
        private static ConfigEntry<int> IceCreamId;
        private static ConfigEntry<int> ExtraKetchupId;
        private static ConfigEntry<int> LettuceId;
        private static ConfigEntry<int> MeatId;
        private static ConfigEntry<int> MushroomsId;
        private static ConfigEntry<int> ExtraMustardId;
        private static ConfigEntry<int> NutsId;
        private static ConfigEntry<int> OilId;
        private static ConfigEntry<int> OlivesId;
        private static ConfigEntry<int> OnionId;
        private static ConfigEntry<int> PotatoId;
        private static ConfigEntry<int> RiceId;
        private static ConfigEntry<int> ThickcutmeatId;
        private static ConfigEntry<int> ThincutmeatId;
        private static ConfigEntry<int> TomatoId;
        private static ConfigEntry<int> TurkeyId;
        private static ConfigEntry<int> WineId;
        private static ConfigEntry<int> AutoPlaterId;
        private static ConfigEntry<int> DishRackId;
        private static ConfigEntry<int> PlatesId;
        private static ConfigEntry<int> PotStackId;
        private static ConfigEntry<int> ServingBoardsId;
        private static ConfigEntry<int> WoksId;
        private static ConfigEntry<int> FreezerId;
        private static ConfigEntry<int> FrozenPrepStationId;
        private static ConfigEntry<int> PrepStationId;
        private static ConfigEntry<int> BreadsticksId;
        private static ConfigEntry<int> CandleBoxId;
        private static ConfigEntry<int> FlowerPotId;
        private static ConfigEntry<int> NapkinsId;
        private static ConfigEntry<int> SharpCutleryId;
        private static ConfigEntry<int> SpecialsMenuId;
        private static ConfigEntry<int> CoffeeTableId;
        private static ConfigEntry<int> BarTableId;
        private static ConfigEntry<int> TableSimpleClothId;
        private static ConfigEntry<int> MetalTableId;
        private static ConfigEntry<int> TableFancyClothId;
        private static ConfigEntry<int> DiningTableId;
        private static ConfigEntry<int> RollingPinId;
        private static ConfigEntry<int> ScrubbingBrushId;
        private static ConfigEntry<int> SharpKnifeId;
        private static ConfigEntry<int> TrainersId;
        private static ConfigEntry<int> WelliesId;
        private static ConfigEntry<int> WorkBootsId;
        private static ConfigEntry<int> TrayStandId;
        private static ConfigEntry<int> DishWasherId;
        private static ConfigEntry<int> WashBasinId;
        private static ConfigEntry<int> SinkId;
        private static ConfigEntry<int> PowerSinkId;
        private static ConfigEntry<int> SoakingSinkId;
        #endregion

        #region Item Spawn Rates Config
        private static ConfigEntry<int> HeatedMixerSpawnRate;
        private static ConfigEntry<int> ConveyorMixerSpawnRate;
        private static ConfigEntry<int> RapidMixerSpawnRate;
        private static ConfigEntry<int> MixerSpawnRate;
        private static ConfigEntry<int> SuppliesSpawnRate;
        private static ConfigEntry<int> CompactorBinSpawnRate;
        private static ConfigEntry<int> ComposterBinSpawnRate;
        private static ConfigEntry<int> ExpandedBinSpawnRate;
        private static ConfigEntry<int> BinSpawnRate;
        private static ConfigEntry<int> FireExtinguisherSpawnRate;
        private static ConfigEntry<int> FloorBufferSpawnRate;
        private static ConfigEntry<int> KitchenFloorProtectorSpawnRate;
        private static ConfigEntry<int> FastMopSpawnRate;
        private static ConfigEntry<int> LastingMopSpawnRate;
        private static ConfigEntry<int> MopSpawnRate;
        private static ConfigEntry<int> RobotBufferSpawnRate;
        private static ConfigEntry<int> RobotMopSpawnRate;
        private static ConfigEntry<int> CoffeeMachineSpawnRate;
        private static ConfigEntry<int> ConveyorSpawnRate;
        private static ConfigEntry<int> CombinerSpawnRate;
        private static ConfigEntry<int> SmartGrabberSpawnRate;
        private static ConfigEntry<int> GrabberSpawnRate;
        private static ConfigEntry<int> PortionerSpawnRate;
        private static ConfigEntry<int> CounterSpawnRate;
        private static ConfigEntry<int> WorkstationSpawnRate;
        private static ConfigEntry<int> AffordableBinSpawnRate;
        private static ConfigEntry<int> GumballMachineSpawnRate;
        private static ConfigEntry<int> NeonSignSpawnRate;
        private static ConfigEntry<int> NeonSign2SpawnRate;
        private static ConfigEntry<int> CeilingLightSpawnRate;
        private static ConfigEntry<int> StockPictureSpawnRate;
        private static ConfigEntry<int> DirtyFloorSignSpawnRate;
        private static ConfigEntry<int> BarrelSpawnRate;
        private static ConfigEntry<int> BookcaseSpawnRate;
        private static ConfigEntry<int> DartboardSpawnRate;
        private static ConfigEntry<int> FireplaceSpawnRate;
        private static ConfigEntry<int> RugSpawnRate;
        private static ConfigEntry<int> WallLightSpawnRate;
        private static ConfigEntry<int> CandelabraSpawnRate;
        private static ConfigEntry<int> ChandelierSpawnRate;
        private static ConfigEntry<int> PreciousFlowerSpawnRate;
        private static ConfigEntry<int> ClassicalGlobeSpawnRate;
        private static ConfigEntry<int> PaintingSpawnRate;
        private static ConfigEntry<int> Rug2SpawnRate;
        private static ConfigEntry<int> StatueSpawnRate;
        private static ConfigEntry<int> BrandMascotSpawnRate;
        private static ConfigEntry<int> TidyPlantSpawnRate;
        private static ConfigEntry<int> CeilingLight2SpawnRate;
        private static ConfigEntry<int> AbstractLampSpawnRate;
        private static ConfigEntry<int> VaseSpawnRate;
        private static ConfigEntry<int> IndoorfountainSpawnRate;
        private static ConfigEntry<int> CalmPaintingSpawnRate;
        private static ConfigEntry<int> PlantSpawnRate;
        private static ConfigEntry<int> DumbwaiterSpawnRate;
        private static ConfigEntry<int> GasLimiterSpawnRate;
        private static ConfigEntry<int> GasOverideSpawnRate;
        private static ConfigEntry<int> DangerHobSpawnRate;
        private static ConfigEntry<int> SafetyHobSpawnRate;
        private static ConfigEntry<int> HobSpawnRate;
        private static ConfigEntry<int> DisplayStandSpawnRate;
        private static ConfigEntry<int> BlueprintCabinetSpawnRate;
        private static ConfigEntry<int> CopyingDeskSpawnRate;
        private static ConfigEntry<int> DiscountDeskSpawnRate;
        private static ConfigEntry<int> BlueprintDeskSpawnRate;
        private static ConfigEntry<int> ResearchDeskSpawnRate;
        private static ConfigEntry<int> SpecialsTerminalSpawnRate;
        private static ConfigEntry<int> OrderingTerminalSpawnRate;
        private static ConfigEntry<int> MicrowaveSpawnRate;
        private static ConfigEntry<int> OvenSpawnRate;
        private static ConfigEntry<int> ApplesSpawnRate;
        private static ConfigEntry<int> BeansSpawnRate;
        private static ConfigEntry<int> BroccoliSpawnRate;
        private static ConfigEntry<int> BurgerBunsSpawnRate;
        private static ConfigEntry<int> CarrotsSpawnRate;
        private static ConfigEntry<int> CheeseSpawnRate;
        private static ConfigEntry<int> ChristmasCrackersSpawnRate;
        private static ConfigEntry<int> EggsSpawnRate;
        private static ConfigEntry<int> FlourSpawnRate;
        private static ConfigEntry<int> HotdogbunSpawnRate;
        private static ConfigEntry<int> HotDogsSpawnRate;
        private static ConfigEntry<int> IceCreamSpawnRate;
        private static ConfigEntry<int> ExtraKetchupSpawnRate;
        private static ConfigEntry<int> LettuceSpawnRate;
        private static ConfigEntry<int> MeatSpawnRate;
        private static ConfigEntry<int> MushroomsSpawnRate;
        private static ConfigEntry<int> ExtraMustardSpawnRate;
        private static ConfigEntry<int> NutsSpawnRate;
        private static ConfigEntry<int> OilSpawnRate;
        private static ConfigEntry<int> OlivesSpawnRate;
        private static ConfigEntry<int> OnionSpawnRate;
        private static ConfigEntry<int> PotatoSpawnRate;
        private static ConfigEntry<int> RiceSpawnRate;
        private static ConfigEntry<int> ThickcutmeatSpawnRate;
        private static ConfigEntry<int> ThincutmeatSpawnRate;
        private static ConfigEntry<int> TomatoSpawnRate;
        private static ConfigEntry<int> TurkeySpawnRate;
        private static ConfigEntry<int> WineSpawnRate;
        private static ConfigEntry<int> AutoPlaterSpawnRate;
        private static ConfigEntry<int> DishRackSpawnRate;
        private static ConfigEntry<int> PlatesSpawnRate;
        private static ConfigEntry<int> PotStackSpawnRate;
        private static ConfigEntry<int> ServingBoardsSpawnRate;
        private static ConfigEntry<int> WoksSpawnRate;
        private static ConfigEntry<int> FreezerSpawnRate;
        private static ConfigEntry<int> FrozenPrepStationSpawnRate;
        private static ConfigEntry<int> PrepStationSpawnRate;
        private static ConfigEntry<int> BreadsticksSpawnRate;
        private static ConfigEntry<int> CandleBoxSpawnRate;
        private static ConfigEntry<int> FlowerPotSpawnRate;
        private static ConfigEntry<int> NapkinsSpawnRate;
        private static ConfigEntry<int> SharpCutlerySpawnRate;
        private static ConfigEntry<int> SpecialsMenuSpawnRate;
        private static ConfigEntry<int> CoffeeTableSpawnRate;
        private static ConfigEntry<int> BarTableSpawnRate;
        private static ConfigEntry<int> TableSimpleClothSpawnRate;
        private static ConfigEntry<int> MetalTableSpawnRate;
        private static ConfigEntry<int> TableFancyClothSpawnRate;
        private static ConfigEntry<int> DiningTableSpawnRate;
        private static ConfigEntry<int> RollingPinSpawnRate;
        private static ConfigEntry<int> ScrubbingBrushSpawnRate;
        private static ConfigEntry<int> SharpKnifeSpawnRate;
        private static ConfigEntry<int> TrainersSpawnRate;
        private static ConfigEntry<int> WelliesSpawnRate;
        private static ConfigEntry<int> WorkBootsSpawnRate;
        private static ConfigEntry<int> TrayStandSpawnRate;
        private static ConfigEntry<int> DishWasherSpawnRate;
        private static ConfigEntry<int> WashBasinSpawnRate;
        private static ConfigEntry<int> SinkSpawnRate;
        private static ConfigEntry<int> PowerSinkSpawnRate;
        private static ConfigEntry<int> SoakingSinkSpawnRate;
        #endregion

        public static void BindAllConfig(this ConfigFile config)
        {
            config
                .BindAllItemsUserConfig()
                .BindGeneralConfig()
                .BindItemSpawnerConfig()
                .BindDefaultShopConfig()
                .BindCustomShopConfig()
                .BindDebugConfig();
        }

        public static List<int> GetCustomShopItemsIdList()
        {
            var itemIdSpawnList = new List<int>();

            foreach(var config in GetAllItemsConfigs())
            {
                for (int i = 0; i < config.SpawnRate; i++)
                {
                    itemIdSpawnList.Add(config.Id);
                }
            }

            return itemIdSpawnList;
        }

        public static int ToItemId(this string itemName)
        {
            try
            {
                return GetAllItemsConfigs()
                    .First(config => config.Name == itemName)
                    .Id;
            }
            catch
            {
                throw new ArgumentException($"ItemName {itemName} does not exist.", "itemName");
            }
        }

        public static List<string> GetItemNamesSorted()
        {
            var allItemNames = GetAllItemsConfigs().Select(config => config.Name).ToList();
            allItemNames.Sort();
            return allItemNames;
        }


        private static List<ItemConfig> GetAllItemsConfigs()
        {
            return new List<ItemConfig>
            {
                new ItemConfig("HeatedMixer", HeatedMixerId.Value, HeatedMixerSpawnRate.Value),
                new ItemConfig("ConveyorMixer", ConveyorMixerId.Value, ConveyorMixerSpawnRate.Value),
                new ItemConfig("RapidMixer", RapidMixerId.Value, RapidMixerSpawnRate.Value),
                new ItemConfig("Mixer", MixerId.Value, MixerSpawnRate.Value),
                new ItemConfig("Supplies", SuppliesId.Value, SuppliesSpawnRate.Value),
                new ItemConfig("CompactorBin", CompactorBinId.Value, CompactorBinSpawnRate.Value),
                new ItemConfig("ComposterBin", ComposterBinId.Value, ComposterBinSpawnRate.Value),
                new ItemConfig("ExpandedBin", ExpandedBinId.Value, ExpandedBinSpawnRate.Value),
                new ItemConfig("Bin", BinId.Value, BinSpawnRate.Value),
                new ItemConfig("FireExtinguisher", FireExtinguisherId.Value, FireExtinguisherSpawnRate.Value),
                new ItemConfig("FloorBuffer", FloorBufferId.Value, FloorBufferSpawnRate.Value),
                new ItemConfig("KitchenFloorProtector", KitchenFloorProtectorId.Value, KitchenFloorProtectorSpawnRate.Value),
                new ItemConfig("FastMop", FastMopId.Value, FastMopSpawnRate.Value),
                new ItemConfig("LastingMop", LastingMopId.Value, LastingMopSpawnRate.Value),
                new ItemConfig("Mop", MopId.Value, MopSpawnRate.Value),
                new ItemConfig("RobotBuffer", RobotBufferId.Value, RobotBufferSpawnRate.Value),
                new ItemConfig("RobotMop", RobotMopId.Value, RobotMopSpawnRate.Value),
                new ItemConfig("CoffeeMachine", CoffeeMachineId.Value, CoffeeMachineSpawnRate.Value),
                new ItemConfig("Conveyor", ConveyorId.Value, ConveyorSpawnRate.Value),
                new ItemConfig("Combiner", CombinerId.Value, CombinerSpawnRate.Value),
                new ItemConfig("SmartGrabber", SmartGrabberId.Value, SmartGrabberSpawnRate.Value),
                new ItemConfig("Grabber", GrabberId.Value, GrabberSpawnRate.Value),
                new ItemConfig("Portioner", PortionerId.Value, PortionerSpawnRate.Value),
                new ItemConfig("Counter", CounterId.Value, CounterSpawnRate.Value),
                new ItemConfig("Workstation", WorkstationId.Value, WorkstationSpawnRate.Value),
                new ItemConfig("AffordableBin", AffordableBinId.Value, AffordableBinSpawnRate.Value),
                new ItemConfig("GumballMachine", GumballMachineId.Value, GumballMachineSpawnRate.Value),
                new ItemConfig("NeonSign", NeonSignId.Value, NeonSignSpawnRate.Value),
                new ItemConfig("NeonSign2", NeonSign2Id.Value, NeonSign2SpawnRate.Value),
                new ItemConfig("CeilingLight", CeilingLightId.Value, CeilingLightSpawnRate.Value),
                new ItemConfig("StockPicture", StockPictureId.Value, StockPictureSpawnRate.Value),
                new ItemConfig("DirtyFloorSign", DirtyFloorSignId.Value, DirtyFloorSignSpawnRate.Value),
                new ItemConfig("Barrel", BarrelId.Value, BarrelSpawnRate.Value),
                new ItemConfig("Bookcase", BookcaseId.Value, BookcaseSpawnRate.Value),
                new ItemConfig("Dartboard", DartboardId.Value, DartboardSpawnRate.Value),
                new ItemConfig("Fireplace", FireplaceId.Value, FireplaceSpawnRate.Value),
                new ItemConfig("Rug", RugId.Value, RugSpawnRate.Value),
                new ItemConfig("WallLight", WallLightId.Value, WallLightSpawnRate.Value),
                new ItemConfig("Candelabra", CandelabraId.Value, CandelabraSpawnRate.Value),
                new ItemConfig("Chandelier", ChandelierId.Value, ChandelierSpawnRate.Value),
                new ItemConfig("PreciousFlower", PreciousFlowerId.Value, PreciousFlowerSpawnRate.Value),
                new ItemConfig("ClassicalGlobe", ClassicalGlobeId.Value, ClassicalGlobeSpawnRate.Value),
                new ItemConfig("Painting", PaintingId.Value, PaintingSpawnRate.Value),
                new ItemConfig("Rug2", Rug2Id.Value, Rug2SpawnRate.Value),
                new ItemConfig("Statue", StatueId.Value, StatueSpawnRate.Value),
                new ItemConfig("BrandMascot", BrandMascotId.Value, BrandMascotSpawnRate.Value),
                new ItemConfig("TidyPlant", TidyPlantId.Value, TidyPlantSpawnRate.Value),
                new ItemConfig("CeilingLight2", CeilingLight2Id.Value, CeilingLight2SpawnRate.Value),
                new ItemConfig("AbstractLamp", AbstractLampId.Value, AbstractLampSpawnRate.Value),
                new ItemConfig("Vase", VaseId.Value, VaseSpawnRate.Value),
                new ItemConfig("Indoorfountain", IndoorfountainId.Value, IndoorfountainSpawnRate.Value),
                new ItemConfig("CalmPainting", CalmPaintingId.Value, CalmPaintingSpawnRate.Value),
                new ItemConfig("Plant", PlantId.Value, PlantSpawnRate.Value),
                new ItemConfig("Dumbwaiter", DumbwaiterId.Value, DumbwaiterSpawnRate.Value),
                new ItemConfig("GasLimiter", GasLimiterId.Value, GasLimiterSpawnRate.Value),
                new ItemConfig("GasOveride", GasOverrideId.Value, GasOverideSpawnRate.Value),
                new ItemConfig("DangerHob", DangerHobId.Value, DangerHobSpawnRate.Value),
                new ItemConfig("SafetyHob", SafetyHobId.Value, SafetyHobSpawnRate.Value),
                new ItemConfig("Hob", HobId.Value, HobSpawnRate.Value),
                new ItemConfig("DisplayStand", DisplayStandId.Value, DisplayStandSpawnRate.Value),
                new ItemConfig("BlueprintCabinet", BlueprintCabinetId.Value, BlueprintCabinetSpawnRate.Value),
                new ItemConfig("CopyingDesk", CopyingDeskId.Value, CopyingDeskSpawnRate.Value),
                new ItemConfig("DiscountDesk", DiscountDeskId.Value, DiscountDeskSpawnRate.Value),
                new ItemConfig("BlueprintDesk", BlueprintDeskId.Value, BlueprintDeskSpawnRate.Value),
                new ItemConfig("ResearchDesk", ResearchDeskId.Value, ResearchDeskSpawnRate.Value),
                new ItemConfig("SpecialsTerminal", SpecialsTerminalId.Value, SpecialsTerminalSpawnRate.Value),
                new ItemConfig("OrderingTerminal", OrderingTerminalId.Value, OrderingTerminalSpawnRate.Value),
                new ItemConfig("Microwave", MicrowaveId.Value, MicrowaveSpawnRate.Value),
                new ItemConfig("Oven", OvenId.Value, OvenSpawnRate.Value),
                new ItemConfig("Apples", ApplesId.Value, ApplesSpawnRate.Value),
                new ItemConfig("Beans", BeansId.Value, BeansSpawnRate.Value),
                new ItemConfig("Broccoli", BroccoliId.Value, BroccoliSpawnRate.Value),
                new ItemConfig("BurgerBuns", BurgerBunsId.Value, BurgerBunsSpawnRate.Value),
                new ItemConfig("Carrots", CarrotsId.Value, CarrotsSpawnRate.Value),
                new ItemConfig("Cheese", CheeseId.Value, CheeseSpawnRate.Value),
                new ItemConfig("ChristmasCrackers", ChristmasCrackersId.Value, ChristmasCrackersSpawnRate.Value),
                new ItemConfig("Eggs", EggsId.Value, EggsSpawnRate.Value),
                new ItemConfig("Flour", FlourId.Value, FlourSpawnRate.Value),
                new ItemConfig("Hotdogbun", HotdogbunId.Value, HotdogbunSpawnRate.Value),
                new ItemConfig("HotDogs", HotDogsId.Value, HotDogsSpawnRate.Value),
                new ItemConfig("IceCream", IceCreamId.Value, IceCreamSpawnRate.Value),
                new ItemConfig("ExtraKetchup", ExtraKetchupId.Value, ExtraKetchupSpawnRate.Value),
                new ItemConfig("Lettuce", LettuceId.Value, LettuceSpawnRate.Value),
                new ItemConfig("Meat", MeatId.Value, MeatSpawnRate.Value),
                new ItemConfig("Mushrooms", MushroomsId.Value, MushroomsSpawnRate.Value),
                new ItemConfig("ExtraMustard", ExtraMustardId.Value, ExtraMustardSpawnRate.Value),
                new ItemConfig("Nuts", NutsId.Value, NutsSpawnRate.Value),
                new ItemConfig("Oil", OilId.Value, OilSpawnRate.Value),
                new ItemConfig("Olives", OlivesId.Value, OlivesSpawnRate.Value),
                new ItemConfig("Onion", OnionId.Value, OnionSpawnRate.Value),
                new ItemConfig("Potato", PotatoId.Value, PotatoSpawnRate.Value),
                new ItemConfig("Rice", RiceId.Value, RiceSpawnRate.Value),
                new ItemConfig("Thickcutmeat", ThickcutmeatId.Value, ThickcutmeatSpawnRate.Value),
                new ItemConfig("Thincutmeat", ThincutmeatId.Value, ThincutmeatSpawnRate.Value),
                new ItemConfig("Tomato", TomatoId.Value, TomatoSpawnRate.Value),
                new ItemConfig("Turkey", TurkeyId.Value, TurkeySpawnRate.Value),
                new ItemConfig("Wine", WineId.Value, WineSpawnRate.Value),
                new ItemConfig("AutoPlater", AutoPlaterId.Value, AutoPlaterSpawnRate.Value),
                new ItemConfig("DishRack", DishRackId.Value, DishRackSpawnRate.Value),
                new ItemConfig("Plates", PlatesId.Value, PlatesSpawnRate.Value),
                new ItemConfig("PotStack", PotStackId.Value, PotStackSpawnRate.Value),
                new ItemConfig("ServingBoards", ServingBoardsId.Value, ServingBoardsSpawnRate.Value),
                new ItemConfig("Woks", WoksId.Value, WoksSpawnRate.Value),
                new ItemConfig("Freezer", FreezerId.Value, FreezerSpawnRate.Value),
                new ItemConfig("FrozenPrepStation", FrozenPrepStationId.Value, FrozenPrepStationSpawnRate.Value),
                new ItemConfig("PrepStation", PrepStationId.Value, PrepStationSpawnRate.Value),
                new ItemConfig("Breadsticks", BreadsticksId.Value, BreadsticksSpawnRate.Value),
                new ItemConfig("CandleBox", CandleBoxId.Value, CandleBoxSpawnRate.Value),
                new ItemConfig("FlowerPot", FlowerPotId.Value, FlowerPotSpawnRate.Value),
                new ItemConfig("Napkins", NapkinsId.Value, NapkinsSpawnRate.Value),
                new ItemConfig("SharpCutlery", SharpCutleryId.Value, SharpCutlerySpawnRate.Value),
                new ItemConfig("SpecialsMenu", SpecialsMenuId.Value, SpecialsMenuSpawnRate.Value),
                new ItemConfig("CoffeeTable", CoffeeTableId.Value, CoffeeTableSpawnRate.Value),
                new ItemConfig("BarTable", BarTableId.Value, BarTableSpawnRate.Value),
                new ItemConfig("TableSimpleCloth", TableSimpleClothId.Value, TableSimpleClothSpawnRate.Value),
                new ItemConfig("MetalTable", MetalTableId.Value, MetalTableSpawnRate.Value),
                new ItemConfig("TableFancyCloth", TableFancyClothId.Value, TableFancyClothSpawnRate.Value),
                new ItemConfig("DiningTable", DiningTableId.Value, DiningTableSpawnRate.Value),
                new ItemConfig("RollingPin", RollingPinId.Value, RollingPinSpawnRate.Value),
                new ItemConfig("ScrubbingBrush", ScrubbingBrushId.Value, ScrubbingBrushSpawnRate.Value),
                new ItemConfig("SharpKnife", SharpKnifeId.Value, SharpKnifeSpawnRate.Value),
                new ItemConfig("Trainers", TrainersId.Value, TrainersSpawnRate.Value),
                new ItemConfig("Wellies", WelliesId.Value, WelliesSpawnRate.Value),
                new ItemConfig("WorkBoots", WorkBootsId.Value, WorkBootsSpawnRate.Value),
                new ItemConfig("TrayStand", TrayStandId.Value, TrayStandSpawnRate.Value),
                new ItemConfig("DishWasher", DishWasherId.Value, DishWasherSpawnRate.Value),
                new ItemConfig("WashBasin", WashBasinId.Value, WashBasinSpawnRate.Value),
                new ItemConfig("Sink", SinkId.Value, SinkSpawnRate.Value),
                new ItemConfig("PowerSink", PowerSinkId.Value, PowerSinkSpawnRate.Value),
                new ItemConfig("SoakingSink", SoakingSinkId.Value, SoakingSinkSpawnRate.Value),
            };
        }

        private static ConfigFile BindItemSpawnerConfig(this ConfigFile config)
        {
            SpawnItemMenuKeyboardShortcut = config.Bind("1. Item spawner window", "KeyboardShortcutToOpenWindow", new KeyboardShortcut(KeyCode.F2), new ConfigDescription("Use this keyboard shortcut to show/hide the item spawner window.", null, new ConfigurationManagerAttributes { Order = 100 }));
            ItemSpawnerWindowHeight = config.Bind("1. Item spawner window", "WindowHeight", 400, new ConfigDescription("The height of the draggable window.", null, new ConfigurationManagerAttributes { Order = 90 }));

            return config;
        }

        private static ConfigFile BindDefaultShopConfig(this ConfigFile config)
        {
            DefaultShopOverrideSettings = config.Bind("2. Default Shop", "OverrideDefaultShopSettings", true, new ConfigDescription("Whether or not to override the shop settings with these custom settings", null, new ConfigurationManagerAttributes { Order = 100 }));
            DefaultShopNumberOfItems = config.Bind("2. Default Shop", "NumberOfItemsToSpawn", 4, new ConfigDescription("The numbers of items to spawn in each shop", null, new ConfigurationManagerAttributes { Order = 90 }));
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
            MoneyRewardMultiplier = config.Bind("0. General", "MoneyRewardMultiplier", 1.25f, new ConfigDescription("Multiplier for the money rewards.", null, new ConfigurationManagerAttributes { Order = 100 }));
            PatienceMultiplier = config.Bind("0. General", "PatienceMultiplier", 1f, new ConfigDescription("Multiplier for customer patience, 0 = infinite patience.", null, new ConfigurationManagerAttributes { Order = 95 }));
            NumberOfCustomersMultiplier = config.Bind("0. General", "NumberOfCustomersMultiplier", 1f, new ConfigDescription("Multiplier for the number of customers to arrive each day.", null, new ConfigurationManagerAttributes { Order = 90 }));
            MinGroupSize = config.Bind("0. General", "MinGroupSize", -1, new ConfigDescription("Override the minimum table size (Max 20), invalid settings will be ignored.", null, new ConfigurationManagerAttributes { Order = 89 }));
            MaxGroupSize = config.Bind("0. General", "MaxGroupSize", -1, new ConfigDescription("Override the maximum table size (Max 20), invalid settings will be ignored.", null, new ConfigurationManagerAttributes { Order = 88 }));
            
            return config;
        }

        private static ConfigFile BindDebugConfig(this ConfigFile config)
        {
            LogItemIdsOnStartup = config.Bind("9. Debug", "ShouldLogItemIdsOnStartup", false, new ConfigDescription("Whether or not to log the item IDs in the console on startup", null, new ConfigurationManagerAttributes { Order = 80, IsAdvanced = true }));

            return config;
        }

        private static ConfigFile BindAllItemsUserConfig(this ConfigFile config)
        {
            HeatedMixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "HeatedMixerSpawnRate", 1);
            ConveyorMixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ConveyorMixerSpawnRate", 1);
            RapidMixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RapidMixerSpawnRate", 1);
            MixerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MixerSpawnRate", 0);
            SuppliesSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SuppliesSpawnRate", 0);
            CompactorBinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CompactorBinSpawnRate", 1);
            ComposterBinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ComposterBinSpawnRate", 0);
            ExpandedBinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ExpandedBinSpawnRate", 0);
            BinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BinSpawnRate", 0);
            FireExtinguisherSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FireExtinguisherSpawnRate", 0);
            FloorBufferSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FloorBufferSpawnRate", 0);
            KitchenFloorProtectorSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "KitchenFloorProtectorSpawnRate", 1);
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
            SafetyHobSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SafetyHobSpawnRate", 1);
            HobSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "HobSpawnRate", 0);
            DisplayStandSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DisplayStandSpawnRate", 0);
            BlueprintCabinetSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BlueprintCabinetSpawnRate", 1);
            CopyingDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "CopyingDeskSpawnRate", 0);
            DiscountDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DiscountDeskSpawnRate", 0);
            BlueprintDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "BlueprintDeskSpawnRate", 0);
            ResearchDeskSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ResearchDeskSpawnRate", 0);
            SpecialsTerminalSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "SpecialsTerminalSpawnRate", 0);
            OrderingTerminalSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "OrderingTerminalSpawnRate", 1);
            MicrowaveSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MicrowaveSpawnRate", 1);
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
            AutoPlaterSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "AutoPlaterSpawnRate", 1);
            DishRackSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DishRackSpawnRate", 0);
            PlatesSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PlatesSpawnRate", 0);
            PotStackSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "PotStackSpawnRate", 0);
            ServingBoardsSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ServingBoardsSpawnRate", 0);
            WoksSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "WoksSpawnRate", 0);
            FreezerSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FreezerSpawnRate", 0);
            FrozenPrepStationSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "FrozenPrepStationSpawnRate", 1);
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
            MetalTableSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "MetalTableSpawnRate", 1);
            TableFancyClothSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "TableFancyClothSpawnRate", 0);
            DiningTableSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "DiningTableSpawnRate", 0);
            RollingPinSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "RollingPinSpawnRate", 0);
            ScrubbingBrushSpawnRate = config.Bind("4. Custom Shop Spawn Rates", "ScrubbingBrushSpawnRate", 1);
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

            HeatedMixerId = config.Bind("9.1 Debug Item Ids", "HeatedMixerId", 505496455, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ConveyorMixerId = config.Bind("9.1 Debug Item Ids", "ConveyorMixerId", -1357906425, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            RapidMixerId = config.Bind("9.1 Debug Item Ids", "RapidMixerId", -1440053805, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            MixerId = config.Bind("9.1 Debug Item Ids", "MixerId", 1329097317, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SuppliesId = config.Bind("9.1 Debug Item Ids", "SuppliesId", -1013770159, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CompactorBinId = config.Bind("9.1 Debug Item Ids", "CompactorBinId", 2127051779, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ComposterBinId = config.Bind("9.1 Debug Item Ids", "ComposterBinId", -1632826946, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ExpandedBinId = config.Bind("9.1 Debug Item Ids", "ExpandedBinId", -1855909480, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BinId = config.Bind("9.1 Debug Item Ids", "BinId", 1551609169, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FireExtinguisherId = config.Bind("9.1 Debug Item Ids", "FireExtinguisherId", 1286554202, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FloorBufferId = config.Bind("9.1 Debug Item Ids", "FloorBufferId", 1351951642, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            KitchenFloorProtectorId = config.Bind("9.1 Debug Item Ids", "KitchenFloorProtectorId", 1765889988, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FastMopId = config.Bind("9.1 Debug Item Ids", "FastMopId", -1495393751, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            LastingMopId = config.Bind("9.1 Debug Item Ids", "LastingMopId", 1776760557, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            MopId = config.Bind("9.1 Debug Item Ids", "MopId", -1993346570, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            RobotBufferId = config.Bind("9.1 Debug Item Ids", "RobotBufferId", -1723340146, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            RobotMopId = config.Bind("9.1 Debug Item Ids", "RobotMopId", -2147057861, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CoffeeMachineId = config.Bind("9.1 Debug Item Ids", "CoffeeMachineId", -1609758240, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ConveyorId = config.Bind("9.1 Debug Item Ids", "ConveyorId", 1973114260, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CombinerId = config.Bind("9.1 Debug Item Ids", "CombinerId", -1906799936, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SmartGrabberId = config.Bind("9.1 Debug Item Ids", "SmartGrabberId", -1238047163, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            GrabberId = config.Bind("9.1 Debug Item Ids", "GrabberId", -1029710921, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PortionerId = config.Bind("9.1 Debug Item Ids", "PortionerId", -1462602185, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CounterId = config.Bind("9.1 Debug Item Ids", "CounterId", -1248669347, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            WorkstationId = config.Bind("9.1 Debug Item Ids", "WorkstationId", -1573577293, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            AffordableBinId = config.Bind("9.1 Debug Item Ids", "AffordableBinId", 620400448, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            GumballMachineId = config.Bind("9.1 Debug Item Ids", "GumballMachineId", 1830133512, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            NeonSignId = config.Bind("9.1 Debug Item Ids", "NeonSignId", 1724963734, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            NeonSign2Id = config.Bind("9.1 Debug Item Ids", "NeonSign2Id", 371247235, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CeilingLightId = config.Bind("9.1 Debug Item Ids", "CeilingLightId", 230540973, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            StockPictureId = config.Bind("9.1 Debug Item Ids", "StockPictureId", -1472471467, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DirtyFloorSignId = config.Bind("9.1 Debug Item Ids", "DirtyFloorSignId", -2108088224, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BarrelId = config.Bind("9.1 Debug Item Ids", "BarrelId", 1569358344, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BookcaseId = config.Bind("9.1 Debug Item Ids", "BookcaseId", -60168847, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DartboardId = config.Bind("9.1 Debug Item Ids", "DartboardId", -1941237931, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FireplaceId = config.Bind("9.1 Debug Item Ids", "FireplaceId", -441525746, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            RugId = config.Bind("9.1 Debug Item Ids", "RugId", 591400026, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            WallLightId = config.Bind("9.1 Debug Item Ids", "WallLightId", -1628995120, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CandelabraId = config.Bind("9.1 Debug Item Ids", "CandelabraId", -13481890, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ChandelierId = config.Bind("9.1 Debug Item Ids", "ChandelierId", 1233091186, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PreciousFlowerId = config.Bind("9.1 Debug Item Ids", "PreciousFlowerId", -1180623135, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ClassicalGlobeId = config.Bind("9.1 Debug Item Ids", "ClassicalGlobeId", 642318074, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PaintingId = config.Bind("9.1 Debug Item Ids", "PaintingId", -1486785449, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            Rug2Id = config.Bind("9.1 Debug Item Ids", "Rug2Id", 2076966627, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            StatueId = config.Bind("9.1 Debug Item Ids", "StatueId", -972644436, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BrandMascotId = config.Bind("9.1 Debug Item Ids", "BrandMascotId", 1551024733, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            TidyPlantId = config.Bind("9.1 Debug Item Ids", "TidyPlantId", -1339970600, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CeilingLight2Id = config.Bind("9.1 Debug Item Ids", "CeilingLight2Id", 908498444, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            AbstractLampId = config.Bind("9.1 Debug Item Ids", "AbstractLampId", 744277037, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            VaseId = config.Bind("9.1 Debug Item Ids", "VaseId", 531866927, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            IndoorfountainId = config.Bind("9.1 Debug Item Ids", "IndoorfountainId", 1220439284, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CalmPaintingId = config.Bind("9.1 Debug Item Ids", "CalmPaintingId", 668664567, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PlantId = config.Bind("9.1 Debug Item Ids", "PlantId", 756364626, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DumbwaiterId = config.Bind("9.1 Debug Item Ids", "DumbwaiterId", 532998682, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            GasLimiterId = config.Bind("9.1 Debug Item Ids", "GasLimiterId", 1921027834, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            GasOverrideId = config.Bind("9.1 Debug Item Ids", "GasOverrideId", -770041014, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DangerHobId = config.Bind("9.1 Debug Item Ids", "DangerHobId", -1448690107, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SafetyHobId = config.Bind("9.1 Debug Item Ids", "SafetyHobId", 1266458729, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            HobId = config.Bind("9.1 Debug Item Ids", "HobId", 862493270, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DisplayStandId = config.Bind("9.1 Debug Item Ids", "DisplayStandId", -1813414500, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BlueprintCabinetId = config.Bind("9.1 Debug Item Ids", "BlueprintCabinetId", -571205127, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CopyingDeskId = config.Bind("9.1 Debug Item Ids", "CopyingDeskId", -729493805, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DiscountDeskId = config.Bind("9.1 Debug Item Ids", "DiscountDeskId", 1586911545, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BlueprintDeskId = config.Bind("9.1 Debug Item Ids", "BlueprintDeskId", 1446975727, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ResearchDeskId = config.Bind("9.1 Debug Item Ids", "ResearchDeskId", 1139247360, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SpecialsTerminalId = config.Bind("9.1 Debug Item Ids", "SpecialsTerminalId", -246383526, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            OrderingTerminalId = config.Bind("9.1 Debug Item Ids", "OrderingTerminalId", -1610332021, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            MicrowaveId = config.Bind("9.1 Debug Item Ids", "MicrowaveId", -1311702572, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            OvenId = config.Bind("9.1 Debug Item Ids", "OvenId", -1068749602, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ApplesId = config.Bind("9.1 Debug Item Ids", "ApplesId", -905438738, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BeansId = config.Bind("9.1 Debug Item Ids", "BeansId", 1807525572, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BroccoliId = config.Bind("9.1 Debug Item Ids", "BroccoliId", -1573812073, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BurgerBunsId = config.Bind("9.1 Debug Item Ids", "BurgerBunsId", 759552160, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CarrotsId = config.Bind("9.1 Debug Item Ids", "CarrotsId", -452101383, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CheeseId = config.Bind("9.1 Debug Item Ids", "CheeseId", -117339838, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ChristmasCrackersId = config.Bind("9.1 Debug Item Ids", "ChristmasCrackersId", 303858729, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            EggsId = config.Bind("9.1 Debug Item Ids", "EggsId", 961148621, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FlourId = config.Bind("9.1 Debug Item Ids", "FlourId", 925796718, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            HotdogbunId = config.Bind("9.1 Debug Item Ids", "HotdogbunId", -1132411297, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            HotDogsId = config.Bind("9.1 Debug Item Ids", "HotDogsId", 1799769627, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            IceCreamId = config.Bind("9.1 Debug Item Ids", "IceCreamId", -1533430406, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ExtraKetchupId = config.Bind("9.1 Debug Item Ids", "ExtraKetchupId", -965827229, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            LettuceId = config.Bind("9.1 Debug Item Ids", "LettuceId", 1193867305, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            MeatId = config.Bind("9.1 Debug Item Ids", "MeatId", -484165118, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            MushroomsId = config.Bind("9.1 Debug Item Ids", "MushroomsId", -1097889139, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ExtraMustardId = config.Bind("9.1 Debug Item Ids", "ExtraMustardId", -117356585, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            NutsId = config.Bind("9.1 Debug Item Ids", "NutsId", 1834063794, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            OilId = config.Bind("9.1 Debug Item Ids", "OilId", -1963699221, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            OlivesId = config.Bind("9.1 Debug Item Ids", "OlivesId", -1434800013, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            OnionId = config.Bind("9.1 Debug Item Ids", "OnionId", -2042103798, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PotatoId = config.Bind("9.1 Debug Item Ids", "PotatoId", 44541785, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            RiceId = config.Bind("9.1 Debug Item Ids", "RiceId", -1201769154, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ThickcutmeatId = config.Bind("9.1 Debug Item Ids", "ThickcutmeatId", -1507801323, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ThincutmeatId = config.Bind("9.1 Debug Item Ids", "ThincutmeatId", 1800865634, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            TomatoId = config.Bind("9.1 Debug Item Ids", "TomatoId", -712909563, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            TurkeyId = config.Bind("9.1 Debug Item Ids", "TurkeyId", -1506824829, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            WineId = config.Bind("9.1 Debug Item Ids", "WineId", -1353971407, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            AutoPlaterId = config.Bind("9.1 Debug Item Ids", "AutoPlaterId", 739504637, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DishRackId = config.Bind("9.1 Debug Item Ids", "DishRackId", 434150763, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PlatesId = config.Bind("9.1 Debug Item Ids", "PlatesId", 1313469794, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PotStackId = config.Bind("9.1 Debug Item Ids", "PotStackId", -957949759, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ServingBoardsId = config.Bind("9.1 Debug Item Ids", "ServingBoardsId", 235423916, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            WoksId = config.Bind("9.1 Debug Item Ids", "WoksId", 314862254, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FreezerId = config.Bind("9.1 Debug Item Ids", "FreezerId", -1857890774, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FrozenPrepStationId = config.Bind("9.1 Debug Item Ids", "FrozenPrepStationId", -759808000, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PrepStationId = config.Bind("9.1 Debug Item Ids", "PrepStationId", 1656358740, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BreadsticksId = config.Bind("9.1 Debug Item Ids", "BreadsticksId", 639111696, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CandleBoxId = config.Bind("9.1 Debug Item Ids", "CandleBoxId", 1358522063, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            FlowerPotId = config.Bind("9.1 Debug Item Ids", "FlowerPotId", 221442949, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            NapkinsId = config.Bind("9.1 Debug Item Ids", "NapkinsId", 1528688658, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SharpCutleryId = config.Bind("9.1 Debug Item Ids", "SharpCutleryId", 2080633647, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SpecialsMenuId = config.Bind("9.1 Debug Item Ids", "SpecialsMenuId", 446555792, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            CoffeeTableId = config.Bind("9.1 Debug Item Ids", "CoffeeTableId", 1648733244, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            BarTableId = config.Bind("9.1 Debug Item Ids", "BarTableId", -3721951, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            TableSimpleClothId = config.Bind("9.1 Debug Item Ids", "TableSimpleClothId", -34659638, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            MetalTableId = config.Bind("9.1 Debug Item Ids", "MetalTableId", -203679687, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            TableFancyClothId = config.Bind("9.1 Debug Item Ids", "TableFancyClothId", -2019409936, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DiningTableId = config.Bind("9.1 Debug Item Ids", "DiningTableId", 209074140, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            RollingPinId = config.Bind("9.1 Debug Item Ids", "RollingPinId", 1738351766, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            ScrubbingBrushId = config.Bind("9.1 Debug Item Ids", "ScrubbingBrushId", 624465484, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SharpKnifeId = config.Bind("9.1 Debug Item Ids", "SharpKnifeId", 2023704259, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            TrainersId = config.Bind("9.1 Debug Item Ids", "TrainersId", 723626409, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            WelliesId = config.Bind("9.1 Debug Item Ids", "WelliesId", 1796077718, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            WorkBootsId = config.Bind("9.1 Debug Item Ids", "WorkBootsId", 230848637, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            TrayStandId = config.Bind("9.1 Debug Item Ids", "TrayStandId", 1129858275, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            DishWasherId = config.Bind("9.1 Debug Item Ids", "DishWasherId", -823922901, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            WashBasinId = config.Bind("9.1 Debug Item Ids", "WashBasinId", -214126192, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SinkId = config.Bind("9.1 Debug Item Ids", "SinkId", 1083874952, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            PowerSinkId = config.Bind("9.1 Debug Item Ids", "PowerSinkId", 1467371088, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));
            SoakingSinkId = config.Bind("9.1 Debug Item Ids", "SoakingSinkId", 1860904347, new ConfigDescription("Set the id's used when spawning items. Hopefully this should never change.", null, new ConfigurationManagerAttributes { IsAdvanced = true }));

            return config;
        }
    }
}
