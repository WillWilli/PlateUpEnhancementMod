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
        public const string ModVersion = "0.4.2";

        public readonly static ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource(ModGuid);

        // On/Off switch
        public static ConfigEntry<bool> IsModEnabled { get; set; }

        // General
        public static ConfigEntry<float> MoneyRewardMultiplier { get; set; }
        public static ConfigEntry<float> PatienceMultiplier { get; set; }
        public static ConfigEntry<float> NumberOfCustomersMultiplier { get; set; }
        public static ConfigEntry<int> MinGroupSize { get; set; }
        public static ConfigEntry<int> MaxGroupSize { get; set; }
        public static ConfigEntry<KeyboardShortcut> NoClipKeyboardShortcut { get; set; }


        // Default shop
        public static ConfigEntry<int> DefaultShopNumberOfItems { get; set; }
        public static ConfigEntry<float> DefaultShopUpgradedChance { get; set; }
        public static ConfigEntry<int> RerollShopFixedCost { get; set; }


        // Custom shop
        public static ConfigEntry<int> CustomShopNumItemsToSpawn { get; set; }
        public static ConfigEntry<float> CustomShopPriceMultiplier { get; set; }

        // Spawn Items
        public static ConfigEntry<int> ItemSpawnerWindowHeight { get; set; }
        public static ConfigEntry<KeyboardShortcut> SpawnItemMenuKeyboardShortcut { get; set; }


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
        private static ConfigEntry<int> ColouringBookStandSpawnRate;
        private static ConfigEntry<int> ConveyorSpawnRate;
        private static ConfigEntry<int> CombinerSpawnRate;
        private static ConfigEntry<int> SmartGrabberSpawnRate;
        private static ConfigEntry<int> GrabberSpawnRate;
        private static ConfigEntry<int> PortionerSpawnRate;
        private static ConfigEntry<int> CounterSpawnRate;
        private static ConfigEntry<int> KneadingCounterSpawnRate;
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
        private static ConfigEntry<int> BannerSpawnRate;
        private static ConfigEntry<int> ChristmasTreeSpawnRate;
        private static ConfigEntry<int> FairyLightsSpawnRate;
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
        private static ConfigEntry<int> Rug3SpawnRate;
        private static ConfigEntry<int> DrinkTapSpawnRate;
        private static ConfigEntry<int> WineBarrelSpawnRate;
        private static ConfigEntry<int> DumbwaiterSpawnRate;
        private static ConfigEntry<int> FryerSpawnRate;
        private static ConfigEntry<int> BeehiveSpawnRate;
        private static ConfigEntry<int> FlowerSpawnSpawnRate;
        private static ConfigEntry<int> GasLimiterSpawnRate;
        private static ConfigEntry<int> GasOverrideSpawnRate;
        private static ConfigEntry<int> DangerHobSpawnRate;
        private static ConfigEntry<int> SafetyHobSpawnRate;
        private static ConfigEntry<int> StarterHobSpawnRate;
        private static ConfigEntry<int> HobSpawnRate;
        private static ConfigEntry<int> ManualHobSpawnRate;
        private static ConfigEntry<int> TutorialHobSpawnRate;
        private static ConfigEntry<int> BookingsStandSpawnRate;
        private static ConfigEntry<int> HostingStandSpawnRate;
        private static ConfigEntry<int> DisplayStandSpawnRate;
        private static ConfigEntry<int> NameplateSpawnRate;
        private static ConfigEntry<int> AccountingDeskSpawnRate;
        private static ConfigEntry<int> BlueprintCabinetSpawnRate;
        private static ConfigEntry<int> CopyingDeskSpawnRate;
        private static ConfigEntry<int> DiscountDeskSpawnRate;
        private static ConfigEntry<int> DiscountDesk2SpawnRate;
        private static ConfigEntry<int> BlueprintDeskSpawnRate;
        private static ConfigEntry<int> ResearchDeskSpawnRate;
        private static ConfigEntry<int> BookingDeskSpawnRate;
        private static ConfigEntry<int> ExtraLifeSpawnRate;
        private static ConfigEntry<int> FastFoodTerminalSpawnRate;
        private static ConfigEntry<int> SpecialsTerminalSpawnRate;
        private static ConfigEntry<int> OrderingTerminalSpawnRate;
        private static ConfigEntry<int> DoubleOvenSpawnRate;
        private static ConfigEntry<int> MicrowaveSpawnRate;
        private static ConfigEntry<int> OvenSpawnRate;
        private static ConfigEntry<int> BalloonsSpawnRate;
        private static ConfigEntry<int> BirthdayBannerSpawnRate;
        private static ConfigEntry<int> PianoSpawnRate;
        private static ConfigEntry<int> ApplesSpawnRate;
        private static ConfigEntry<int> BeansSpawnRate;
        private static ConfigEntry<int> BroccoliSpawnRate;
        private static ConfigEntry<int> BurgerBunsSpawnRate;
        private static ConfigEntry<int> PattiesSpawnRate;
        private static ConfigEntry<int> CarrotsSpawnRate;
        private static ConfigEntry<int> CheeseSpawnRate;
        private static ConfigEntry<int> ChristmasCrackersSpawnRate;
        private static ConfigEntry<int> EggsSpawnRate;
        private static ConfigEntry<int> FishSpawnRate;
        private static ConfigEntry<int> Fish2SpawnRate;
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
        private static ConfigEntry<int> Counter2SpawnRate;
        private static ConfigEntry<int> PracticeModeTriggerSpawnRate;
        private static ConfigEntry<int> RerollShopTriggerSpawnRate;
        private static ConfigEntry<int> TutorialTriggerSpawnRate;
        private static ConfigEntry<int> AutoPlaterSpawnRate;
        private static ConfigEntry<int> DishRackSpawnRate;
        private static ConfigEntry<int> DishRack2SpawnRate;
        private static ConfigEntry<int> ItemSourceReservationSpawnRate;
        private static ConfigEntry<int> ItemSourceSpawnRate;
        private static ConfigEntry<int> StarterPlatesSpawnRate;
        private static ConfigEntry<int> PlatesSpawnRate;
        private static ConfigEntry<int> PotStackSpawnRate;
        private static ConfigEntry<int> ServingBoardsSpawnRate;
        private static ConfigEntry<int> WoksSpawnRate;
        private static ConfigEntry<int> FreezerSpawnRate;
        private static ConfigEntry<int> FrozenPrepStationSpawnRate;
        private static ConfigEntry<int> PrepStationSpawnRate;
        private static ConfigEntry<int> RackSpawnRate;
        private static ConfigEntry<int> StorageCupboardSpawnRate;
        private static ConfigEntry<int> BreadsticksSpawnRate;
        private static ConfigEntry<int> CandleBoxSpawnRate;
        private static ConfigEntry<int> FlowerPotSpawnRate;
        private static ConfigEntry<int> NapkinsSpawnRate;
        private static ConfigEntry<int> SharpCutlerySpawnRate;
        private static ConfigEntry<int> SpecialsMenuSpawnRate;
        private static ConfigEntry<int> ChairSpawnRate;
        private static ConfigEntry<int> CoffeeTableSpawnRate;
        private static ConfigEntry<int> Chair2SpawnRate;
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
        private static ConfigEntry<int> StarterSinkSpawnRate;
        private static ConfigEntry<int> WheelieBinSpawnRate;
        private static ConfigEntry<int> BedSpawnRate;

        private static ConfigEntry<int> GrabberRotatingSpawnRate;
        private static ConfigEntry<int> TeleporterSpawnRate;
        private static ConfigEntry<int> CobwebsSpawnRate;
        private static ConfigEntry<int> GhostStatueSpawnRate;
        private static ConfigEntry<int> PumpkinSpawnRate;
        private static ConfigEntry<int> SkeletonSpawnRate;
        private static ConfigEntry<int> CornSpawnRate;
        private static ConfigEntry<int> BananasSpawnRate;
        private static ConfigEntry<int> StrawberriesSpawnRate;
        private static ConfigEntry<int> Pumpkin2SpawnRate;
        private static ConfigEntry<int> UpgradeKitSpawnRate;
        #endregion

        public static void BindAllConfig(this ConfigFile config)
        {
            config
                .BindItemSpawnRates()
                .BindGeneralConfig()
                .BindItemSpawnerConfig()
                .BindDefaultShopConfig()
                .BindCustomShopConfig();
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
                new ItemConfig("HeatedMixer", ItemIdReference.HeatedMixer, HeatedMixerSpawnRate.Value),
                new ItemConfig("ConveyorMixer", ItemIdReference.ConveyorMixer, ConveyorMixerSpawnRate.Value),
                new ItemConfig("RapidMixer", ItemIdReference.RapidMixer, RapidMixerSpawnRate.Value),
                new ItemConfig("Mixer", ItemIdReference.Mixer, MixerSpawnRate.Value),
                new ItemConfig("Supplies", ItemIdReference.Supplies, SuppliesSpawnRate.Value),
                new ItemConfig("CompactorBin", ItemIdReference.CompactorBin, CompactorBinSpawnRate.Value),
                new ItemConfig("ComposterBin", ItemIdReference.ComposterBin, ComposterBinSpawnRate.Value),
                new ItemConfig("ExpandedBin", ItemIdReference.ExpandedBin, ExpandedBinSpawnRate.Value),
                new ItemConfig("StarterBin", ItemIdReference.StarterBin, 0),
                new ItemConfig("Bin", ItemIdReference.Bin, BinSpawnRate.Value),
                new ItemConfig("FireExtinguisher", ItemIdReference.FireExtinguisher, FireExtinguisherSpawnRate.Value),
                new ItemConfig("FloorBuffer", ItemIdReference.FloorBuffer, FloorBufferSpawnRate.Value),
                new ItemConfig("KitchenFloorProtector", ItemIdReference.KitchenFloorProtector, KitchenFloorProtectorSpawnRate.Value),
                new ItemConfig("FastMop", ItemIdReference.FastMop, FastMopSpawnRate.Value),
                new ItemConfig("LastingMop", ItemIdReference.LastingMop, LastingMopSpawnRate.Value),
                new ItemConfig("Mop", ItemIdReference.Mop, MopSpawnRate.Value),
                new ItemConfig("RobotBuffer", ItemIdReference.RobotBuffer, RobotBufferSpawnRate.Value),
                new ItemConfig("RobotMop", ItemIdReference.RobotMop, RobotMopSpawnRate.Value),
                new ItemConfig("CoffeeMachine", ItemIdReference.CoffeeMachine, CoffeeMachineSpawnRate.Value),
                new ItemConfig("ColouringBookStand", ItemIdReference.ColouringBookStand, 0),
                new ItemConfig("Conveyor", ItemIdReference.Conveyor, ConveyorSpawnRate.Value),
                new ItemConfig("Combiner", ItemIdReference.Combiner, CombinerSpawnRate.Value),
                new ItemConfig("SmartGrabber", ItemIdReference.SmartGrabber, SmartGrabberSpawnRate.Value),
                new ItemConfig("Grabber", ItemIdReference.Grabber, GrabberSpawnRate.Value),
                new ItemConfig("Portioner", ItemIdReference.Portioner, PortionerSpawnRate.Value),
                new ItemConfig("Counter", ItemIdReference.Counter, CounterSpawnRate.Value),
                new ItemConfig("KneadingCounter", ItemIdReference.KneadingCounter, KneadingCounterSpawnRate.Value),
                new ItemConfig("Workstation", ItemIdReference.Workstation, WorkstationSpawnRate.Value),
                new ItemConfig("AffordableBin", ItemIdReference.AffordableBin, AffordableBinSpawnRate.Value),
                new ItemConfig("GumballMachine", ItemIdReference.GumballMachine, GumballMachineSpawnRate.Value),
                new ItemConfig("NeonSign", ItemIdReference.NeonSign, NeonSignSpawnRate.Value),
                new ItemConfig("NeonSign2", ItemIdReference.NeonSign2, NeonSign2SpawnRate.Value),
                new ItemConfig("CeilingLight", ItemIdReference.CeilingLight, CeilingLightSpawnRate.Value),
                new ItemConfig("StockPicture", ItemIdReference.StockPicture, StockPictureSpawnRate.Value),
                new ItemConfig("DirtyFloorSign", ItemIdReference.DirtyFloorSign, DirtyFloorSignSpawnRate.Value),
                new ItemConfig("Barrel", ItemIdReference.Barrel, BarrelSpawnRate.Value),
                new ItemConfig("Bookcase", ItemIdReference.Bookcase, BookcaseSpawnRate.Value),
                new ItemConfig("Dartboard", ItemIdReference.Dartboard, DartboardSpawnRate.Value),
                new ItemConfig("Fireplace", ItemIdReference.Fireplace, FireplaceSpawnRate.Value),
                new ItemConfig("Rug", ItemIdReference.Rug, RugSpawnRate.Value),
                new ItemConfig("WallLight", ItemIdReference.WallLight, WallLightSpawnRate.Value),
                new ItemConfig("Banner", ItemIdReference.Banner, BannerSpawnRate.Value),
                new ItemConfig("ChristmasTree", ItemIdReference.ChristmasTree, ChristmasTreeSpawnRate.Value),
                new ItemConfig("FairyLights", ItemIdReference.FairyLights, 0),
                new ItemConfig("Candelabra", ItemIdReference.Candelabra, CandelabraSpawnRate.Value),
                new ItemConfig("Chandelier", ItemIdReference.Chandelier, ChandelierSpawnRate.Value),
                new ItemConfig("PreciousFlower", ItemIdReference.PreciousFlower, PreciousFlowerSpawnRate.Value),
                new ItemConfig("ClassicalGlobe", ItemIdReference.ClassicalGlobe, ClassicalGlobeSpawnRate.Value),
                new ItemConfig("Painting", ItemIdReference.Painting, PaintingSpawnRate.Value),
                new ItemConfig("Rug2", ItemIdReference.Rug2, Rug2SpawnRate.Value),
                new ItemConfig("Statue", ItemIdReference.Statue, StatueSpawnRate.Value),
                new ItemConfig("BrandMascot", ItemIdReference.BrandMascot, BrandMascotSpawnRate.Value),
                new ItemConfig("TidyPlant", ItemIdReference.TidyPlant, TidyPlantSpawnRate.Value),
                new ItemConfig("CeilingLight2", ItemIdReference.CeilingLight2, CeilingLight2SpawnRate.Value),
                new ItemConfig("AbstractLamp", ItemIdReference.AbstractLamp, AbstractLampSpawnRate.Value),
                new ItemConfig("Vase", ItemIdReference.Vase, VaseSpawnRate.Value),
                new ItemConfig("Indoorfountain", ItemIdReference.Indoorfountain, IndoorfountainSpawnRate.Value),
                new ItemConfig("CalmPainting", ItemIdReference.CalmPainting, CalmPaintingSpawnRate.Value),
                new ItemConfig("Plant", ItemIdReference.Plant, PlantSpawnRate.Value),
                new ItemConfig("Rug3", ItemIdReference.Rug3, 0),
                new ItemConfig("DrinkTap", ItemIdReference.DrinkTap, DrinkTapSpawnRate.Value),
                new ItemConfig("WineBarrel", ItemIdReference.WineBarrel, WineBarrelSpawnRate.Value),
                new ItemConfig("Dumbwaiter", ItemIdReference.Dumbwaiter, DumbwaiterSpawnRate.Value),
                new ItemConfig("Fryer", ItemIdReference.Fryer, FryerSpawnRate.Value),
                new ItemConfig("Beehive", ItemIdReference.Beehive, BeehiveSpawnRate.Value),
                new ItemConfig("FlowerSpawn", ItemIdReference.FlowerSpawn, FlowerSpawnSpawnRate.Value),
                new ItemConfig("GasLimiter", ItemIdReference.GasLimiter, GasLimiterSpawnRate.Value),
                new ItemConfig("GasOverride", ItemIdReference.GasOverride, GasOverrideSpawnRate.Value),
                new ItemConfig("DangerHob", ItemIdReference.DangerHob, DangerHobSpawnRate.Value),
                new ItemConfig("SafetyHob", ItemIdReference.SafetyHob, SafetyHobSpawnRate.Value),
                new ItemConfig("StarterHob", ItemIdReference.StarterHob, StarterHobSpawnRate.Value),
                new ItemConfig("Hob", ItemIdReference.Hob, HobSpawnRate.Value),
                new ItemConfig("ManualHob", ItemIdReference.ManualHob, ManualHobSpawnRate.Value),
                new ItemConfig("TutorialHob", ItemIdReference.TutorialHob, TutorialHobSpawnRate.Value),
                new ItemConfig("BookingsStand", ItemIdReference.BookingsStand, BookingsStandSpawnRate.Value),
                new ItemConfig("HostingStand", ItemIdReference.HostingStand, HostingStandSpawnRate.Value),
                new ItemConfig("DisplayStand", ItemIdReference.DisplayStand, DisplayStandSpawnRate.Value),
                //new ItemConfig("BuffedFloor", ItemId.BuffedFloor, BuffedFloorSpawnRate.Value),
                //new ItemConfig("MessCustomer1", ItemId.MessCustomer1, MessCustomer1SpawnRate.Value),
                //new ItemConfig("MessCustomer2", ItemId.MessCustomer2, MessCustomer2SpawnRate.Value),
                //new ItemConfig("MessCustomer3", ItemId.MessCustomer3, MessCustomer3SpawnRate.Value),
                //new ItemConfig("MessKitchen1", ItemId.MessKitchen1, MessKitchen1SpawnRate.Value),
                //new ItemConfig("MessKitchen2", ItemId.MessKitchen2, MessKitchen2SpawnRate.Value),
                //new ItemConfig("MessKitchen3", ItemId.MessKitchen3, MessKitchen3SpawnRate.Value),
                //new ItemConfig("MopWaterLong", ItemId.MopWaterLong, MopWaterLongSpawnRate.Value),
                //new ItemConfig("MopWater", ItemId.MopWater, MopWaterSpawnRate.Value),
                new ItemConfig("Nameplate", ItemIdReference.Nameplate, NameplateSpawnRate.Value),
                //new ItemConfig("BlueprintLetter", ItemId.BlueprintLetter, BlueprintLetterSpawnRate.Value),
                //new ItemConfig("Blueprint", ItemId.Blueprint, BlueprintSpawnRate.Value),
                //new ItemConfig("FlooringApplicator", ItemId.FlooringApplicator, FlooringApplicatorSpawnRate.Value),
                //new ItemConfig("Parcel", ItemId.Parcel, ParcelSpawnRate.Value),
                //new ItemConfig("WallpaperApplicator", ItemId.WallpaperApplicator, WallpaperApplicatorSpawnRate.Value),
                new ItemConfig("AccountingDesk", ItemIdReference.AccountingDesk, AccountingDeskSpawnRate.Value),
                new ItemConfig("BlueprintCabinet", ItemIdReference.BlueprintCabinet, BlueprintCabinetSpawnRate.Value),
                new ItemConfig("CopyingDesk", ItemIdReference.CopyingDesk, CopyingDeskSpawnRate.Value),
                new ItemConfig("DiscountDesk", ItemIdReference.DiscountDesk, DiscountDeskSpawnRate.Value),
                new ItemConfig("DiscountDesk2", ItemIdReference.DiscountDesk2, DiscountDesk2SpawnRate.Value),
                new ItemConfig("BlueprintDesk", ItemIdReference.BlueprintDesk, BlueprintDeskSpawnRate.Value),
                new ItemConfig("ResearchDesk", ItemIdReference.ResearchDesk, ResearchDeskSpawnRate.Value),
                new ItemConfig("BookingDesk", ItemIdReference.BookingDesk, BookingDeskSpawnRate.Value),
                new ItemConfig("ExtraLife", ItemIdReference.ExtraLife, ExtraLifeSpawnRate.Value),
                new ItemConfig("FastFoodTerminal", ItemIdReference.FastFoodTerminal, FastFoodTerminalSpawnRate.Value),
                new ItemConfig("SpecialsTerminal", ItemIdReference.SpecialsTerminal, SpecialsTerminalSpawnRate.Value),
                new ItemConfig("OrderingTerminal", ItemIdReference.OrderingTerminal, OrderingTerminalSpawnRate.Value),
                new ItemConfig("DoubleOven", ItemIdReference.DoubleOven, DoubleOvenSpawnRate.Value),
                new ItemConfig("Microwave", ItemIdReference.Microwave, MicrowaveSpawnRate.Value),
                new ItemConfig("Oven", ItemIdReference.Oven, OvenSpawnRate.Value),
                new ItemConfig("Balloons", ItemIdReference.Balloons, BalloonsSpawnRate.Value),
                new ItemConfig("BirthdayBanner", ItemIdReference.BirthdayBanner, BirthdayBannerSpawnRate.Value),
                new ItemConfig("Piano", ItemIdReference.Piano, PianoSpawnRate.Value),
                new ItemConfig("Apples", ItemIdReference.Apples, ApplesSpawnRate.Value),
                new ItemConfig("Beans", ItemIdReference.Beans, BeansSpawnRate.Value),
                new ItemConfig("Broccoli", ItemIdReference.Broccoli, BroccoliSpawnRate.Value),
                new ItemConfig("BurgerBuns", ItemIdReference.BurgerBuns, BurgerBunsSpawnRate.Value),
                new ItemConfig("Patties", ItemIdReference.Patties, PattiesSpawnRate.Value),
                new ItemConfig("Carrots", ItemIdReference.Carrots, CarrotsSpawnRate.Value),
                new ItemConfig("Cheese", ItemIdReference.Cheese, CheeseSpawnRate.Value),
                new ItemConfig("ChristmasCrackers", ItemIdReference.ChristmasCrackers, ChristmasCrackersSpawnRate.Value),
                new ItemConfig("Eggs", ItemIdReference.Eggs, EggsSpawnRate.Value),
                new ItemConfig("Fish", ItemIdReference.Fish, FishSpawnRate.Value),
                new ItemConfig("Fish2", ItemIdReference.Fish2, Fish2SpawnRate.Value),
                new ItemConfig("Flour", ItemIdReference.Flour, FlourSpawnRate.Value),
                new ItemConfig("Hotdogbun", ItemIdReference.Hotdogbun, HotdogbunSpawnRate.Value),
                new ItemConfig("HotDogs", ItemIdReference.HotDogs, HotDogsSpawnRate.Value),
                new ItemConfig("IceCream", ItemIdReference.IceCream, IceCreamSpawnRate.Value),
                new ItemConfig("ExtraKetchup", ItemIdReference.ExtraKetchup, ExtraKetchupSpawnRate.Value),
                new ItemConfig("Lettuce", ItemIdReference.Lettuce, LettuceSpawnRate.Value),
                new ItemConfig("Meat", ItemIdReference.Meat, MeatSpawnRate.Value),
                new ItemConfig("Mushrooms", ItemIdReference.Mushrooms, MushroomsSpawnRate.Value),
                new ItemConfig("ExtraMustard", ItemIdReference.ExtraMustard, ExtraMustardSpawnRate.Value),
                new ItemConfig("Nuts", ItemIdReference.Nuts, NutsSpawnRate.Value),
                new ItemConfig("Oil", ItemIdReference.Oil, OilSpawnRate.Value),
                new ItemConfig("Olives", ItemIdReference.Olives, OlivesSpawnRate.Value),
                new ItemConfig("Onion", ItemIdReference.Onion, OnionSpawnRate.Value),
                new ItemConfig("Potato", ItemIdReference.Potato, PotatoSpawnRate.Value),
                new ItemConfig("Rice", ItemIdReference.Rice, RiceSpawnRate.Value),
                new ItemConfig("Thickcutmeat", ItemIdReference.Thickcutmeat, ThickcutmeatSpawnRate.Value),
                new ItemConfig("Thincutmeat", ItemIdReference.Thincutmeat, ThincutmeatSpawnRate.Value),
                new ItemConfig("Tomato", ItemIdReference.Tomato, TomatoSpawnRate.Value),
                new ItemConfig("Turkey", ItemIdReference.Turkey, TurkeySpawnRate.Value),
                new ItemConfig("Wine", ItemIdReference.Wine, WineSpawnRate.Value),
                //new ItemConfig("BrokenEntity", ItemId.BrokenEntity, BrokenEntitySpawnRate.Value),
                //new ItemConfig("FireEntity", ItemId.FireEntity, FireEntitySpawnRate.Value),
                new ItemConfig("Counter2", ItemIdReference.Counter2, Counter2SpawnRate.Value),
                new ItemConfig("PracticeModeTrigger", ItemIdReference.PracticeModeTrigger, PracticeModeTriggerSpawnRate.Value),
                new ItemConfig("RerollShopTrigger", ItemIdReference.RerollShopTrigger, RerollShopTriggerSpawnRate.Value),
                new ItemConfig("TutorialTrigger", ItemIdReference.TutorialTrigger, TutorialTriggerSpawnRate.Value),
                new ItemConfig("AutoPlater", ItemIdReference.AutoPlater, AutoPlaterSpawnRate.Value),
                new ItemConfig("DishRack", ItemIdReference.DishRack, DishRackSpawnRate.Value),
                new ItemConfig("DishRack2", ItemIdReference.DishRack2, DishRack2SpawnRate.Value),
                new ItemConfig("ItemSourceReservation", ItemIdReference.ItemSourceReservation, ItemSourceReservationSpawnRate.Value),
                new ItemConfig("ItemSource", ItemIdReference.ItemSource, ItemSourceSpawnRate.Value),
                new ItemConfig("StarterPlates", ItemIdReference.StarterPlates, StarterPlatesSpawnRate.Value),
                new ItemConfig("Plates", ItemIdReference.Plates, PlatesSpawnRate.Value),
                new ItemConfig("PotStack", ItemIdReference.PotStack, PotStackSpawnRate.Value),
                new ItemConfig("ServingBoards", ItemIdReference.ServingBoards, ServingBoardsSpawnRate.Value),
                new ItemConfig("Woks", ItemIdReference.Woks, WoksSpawnRate.Value),
                //new ItemConfig("AlpineGround", ItemId.AlpineGround, AlpineGroundSpawnRate.Value),
                //new ItemConfig("AlpineTree", ItemId.AlpineTree, AlpineTreeSpawnRate.Value),
                //new ItemConfig("Bush", ItemId.Bush, BushSpawnRate.Value),
                //new ItemConfig("Cobblestone", ItemId.Cobblestone, CobblestoneSpawnRate.Value),
                //new ItemConfig("CountrysideGround", ItemId.CountrysideGround, CountrysideGroundSpawnRate.Value),
                //new ItemConfig("Flower", ItemId.Flower, FlowerSpawnRate.Value),
                //new ItemConfig("Flowerbed", ItemId.Flowerbed, FlowerbedSpawnRate.Value),
                //new ItemConfig("LogWall", ItemId.LogWall, LogWallSpawnRate.Value),
                //new ItemConfig("OutdoorMovementBlocker", ItemId.OutdoorMovementBlocker, OutdoorMovementBlockerSpawnRate.Value),
                //new ItemConfig("Rock", ItemId.Rock, RockSpawnRate.Value),
                //new ItemConfig("InternalWallPiece", ItemId.InternalWallPiece, InternalWallPieceSpawnRate.Value),
                //new ItemConfig("StreetPiece", ItemId.StreetPiece, StreetPieceSpawnRate.Value),
                //new ItemConfig("WallPiece", ItemId.WallPiece, WallPieceSpawnRate.Value),
                //new ItemConfig("Tree", ItemId.Tree, TreeSpawnRate.Value),
                new ItemConfig("Freezer", ItemIdReference.Freezer, FreezerSpawnRate.Value),
                new ItemConfig("FrozenPrepStation", ItemIdReference.FrozenPrepStation, FrozenPrepStationSpawnRate.Value),
                new ItemConfig("PrepStation", ItemIdReference.PrepStation, PrepStationSpawnRate.Value),
                new ItemConfig("Rack", ItemIdReference.Rack, RackSpawnRate.Value),
                new ItemConfig("StorageCupboard", ItemIdReference.StorageCupboard, StorageCupboardSpawnRate.Value),
                new ItemConfig("Breadsticks", ItemIdReference.Breadsticks, BreadsticksSpawnRate.Value),
                new ItemConfig("CandleBox", ItemIdReference.CandleBox, CandleBoxSpawnRate.Value),
                new ItemConfig("FlowerPot", ItemIdReference.FlowerPot, FlowerPotSpawnRate.Value),
                new ItemConfig("Napkins", ItemIdReference.Napkins, NapkinsSpawnRate.Value),
                new ItemConfig("SharpCutlery", ItemIdReference.SharpCutlery, SharpCutlerySpawnRate.Value),
                new ItemConfig("SpecialsMenu", ItemIdReference.SpecialsMenu, SpecialsMenuSpawnRate.Value),
                new ItemConfig("Chair", ItemIdReference.Chair, ChairSpawnRate.Value),
                new ItemConfig("CoffeeTable", ItemIdReference.CoffeeTable, CoffeeTableSpawnRate.Value),
                new ItemConfig("Chair2", ItemIdReference.Chair2, Chair2SpawnRate.Value),
                new ItemConfig("BarTable", ItemIdReference.BarTable, BarTableSpawnRate.Value),
                new ItemConfig("TableSimpleCloth", ItemIdReference.TableSimpleCloth, TableSimpleClothSpawnRate.Value),
                new ItemConfig("MetalTable", ItemIdReference.MetalTable, MetalTableSpawnRate.Value),
                new ItemConfig("TableFancyCloth", ItemIdReference.TableFancyCloth, TableFancyClothSpawnRate.Value),
                new ItemConfig("DiningTable", ItemIdReference.DiningTable, DiningTableSpawnRate.Value),
                new ItemConfig("RollingPin", ItemIdReference.RollingPin, RollingPinSpawnRate.Value),
                new ItemConfig("ScrubbingBrush", ItemIdReference.ScrubbingBrush, ScrubbingBrushSpawnRate.Value),
                new ItemConfig("SharpKnife", ItemIdReference.SharpKnife, SharpKnifeSpawnRate.Value),
                new ItemConfig("Trainers", ItemIdReference.Trainers, TrainersSpawnRate.Value),
                new ItemConfig("Wellies", ItemIdReference.Wellies, WelliesSpawnRate.Value),
                new ItemConfig("WorkBoots", ItemIdReference.WorkBoots, WorkBootsSpawnRate.Value),
                new ItemConfig("TrayStand", ItemIdReference.TrayStand, TrayStandSpawnRate.Value),
                new ItemConfig("DishWasher", ItemIdReference.DishWasher, DishWasherSpawnRate.Value),
                new ItemConfig("WashBasin", ItemIdReference.WashBasin, WashBasinSpawnRate.Value),
                new ItemConfig("Sink", ItemIdReference.Sink, SinkSpawnRate.Value),
                new ItemConfig("PowerSink", ItemIdReference.PowerSink, PowerSinkSpawnRate.Value),
                new ItemConfig("SoakingSink", ItemIdReference.SoakingSink, SoakingSinkSpawnRate.Value),
                new ItemConfig("StarterSink", ItemIdReference.StarterSink, StarterSinkSpawnRate.Value),
                new ItemConfig("WheelieBin", ItemIdReference.WheelieBin, WheelieBinSpawnRate.Value),
                new ItemConfig("Bed", ItemIdReference.Bed, BedSpawnRate.Value),

                // Halloween update
                new ItemConfig("GrabberRotating", ItemIdReference.GrabberRotating, GrabberRotatingSpawnRate.Value),
                new ItemConfig("Teleporter", ItemIdReference.Teleporter, TeleporterSpawnRate.Value),
                new ItemConfig("Cobwebs", ItemIdReference.Cobwebs, CobwebsSpawnRate.Value),
                new ItemConfig("GhostStatue", ItemIdReference.GhostStatue, GhostStatueSpawnRate.Value),
                new ItemConfig("Pumpkin", ItemIdReference.Pumpkin, PumpkinSpawnRate.Value),
                new ItemConfig("Skeleton", ItemIdReference.Skeleton, SkeletonSpawnRate.Value),
                new ItemConfig("Corn", ItemIdReference.Corn, CornSpawnRate.Value),
                new ItemConfig("Bananas", ItemIdReference.Bananas, BananasSpawnRate.Value),
                new ItemConfig("Strawberries", ItemIdReference.Strawberries, StrawberriesSpawnRate.Value),
                new ItemConfig("Pumpkin2", ItemIdReference.Pumpkin2, Pumpkin2SpawnRate.Value),
                new ItemConfig("UpgradeKit", ItemIdReference.UpgradeKit, UpgradeKitSpawnRate.Value),

            };
        }

        private static ConfigFile BindGeneralConfig(this ConfigFile config)
        {
            IsModEnabled = config.Bind("0. Toggle Mod On / Off", "EnableMod", true, new ConfigDescription("Whether or not to apply this mod. Set to 'disabled' to play vanilla.", null, new ConfigurationManagerAttributes { Order = 100 }));

            MoneyRewardMultiplier = config.Bind("1. General", "MoneyRewardMultiplier", 1.25f, new ConfigDescription("Multiplier for the money rewards.", null, new ConfigurationManagerAttributes { Order = 100 }));
            PatienceMultiplier = config.Bind("1. General", "PatienceMultiplier", 1f, new ConfigDescription("Multiplier for customer patience, 0 = infinite patience.", null, new ConfigurationManagerAttributes { Order = 95 }));
            NumberOfCustomersMultiplier = config.Bind("1. General", "NumberOfCustomersMultiplier", 1f, new ConfigDescription("Multiplier for the number of customers to arrive each day.", null, new ConfigurationManagerAttributes { Order = 90 }));
            MinGroupSize = config.Bind("1. General", "MinGroupSize", -1, new ConfigDescription("Override the minimum table size (Max 20), invalid settings will be ignored.", null, new ConfigurationManagerAttributes { Order = 89 }));
            MaxGroupSize = config.Bind("1. General", "MaxGroupSize", -1, new ConfigDescription("Override the maximum table size (Max 20), invalid settings will be ignored.", null, new ConfigurationManagerAttributes { Order = 88 }));
            NoClipKeyboardShortcut = config.Bind("1. General", "NoClip", new KeyboardShortcut(KeyCode.N), new ConfigDescription("Toggle walking through walls & objects.", null, new ConfigurationManagerAttributes { Order = 80 }));

            return config;
        }

        private static ConfigFile BindItemSpawnerConfig(this ConfigFile config)
        {
            SpawnItemMenuKeyboardShortcut = config.Bind("2. Item spawner window", "KeyboardShortcutToOpenWindow", new KeyboardShortcut(KeyCode.F2), new ConfigDescription("Use this keyboard shortcut to show/hide the item spawner window.", null, new ConfigurationManagerAttributes { Order = 100 }));
            ItemSpawnerWindowHeight = config.Bind("2. Item spawner window", "WindowHeight", 400, new ConfigDescription("The height of the draggable window.", null, new ConfigurationManagerAttributes { Order = 90 }));

            return config;
        }

        private static ConfigFile BindDefaultShopConfig(this ConfigFile config)
        {
            DefaultShopNumberOfItems = config.Bind("3. Default Shop", "NumberOfItemsToSpawn", 4, new ConfigDescription("The numbers of items to spawn in each shop", null, new ConfigurationManagerAttributes { Order = 90 }));
            DefaultShopUpgradedChance = config.Bind("3. Default Shop", "UpgradeChance", 1.5f, new ConfigDescription("The chance of getting an upgraded shop", new AcceptableValueRange<float>(0, 1), new ConfigurationManagerAttributes { Order = 80 }));
            RerollShopFixedCost = config.Bind("3. Default Shop", "FixRerollCost", -1, new ConfigDescription("Override the shop reroll cost, set to -1 to ignore", null, new ConfigurationManagerAttributes { Order = 80 }));

            return config;
        }

        private static ConfigFile BindCustomShopConfig(this ConfigFile config)
        {
            CustomShopNumItemsToSpawn = config.Bind("4. Custom Shop", "NumberOfShopItemsToSpawn", 2, new ConfigDescription("The number of items to spawn in the custom shop", null, new ConfigurationManagerAttributes { Order = 100 }));
            CustomShopPriceMultiplier = config.Bind("4. Custom Shop", "PriceMultiplier", 1f, new ConfigDescription("The price factor of items spawned in the custom shop", new AcceptableValueRange<float>(0f, 10f), new ConfigurationManagerAttributes { Order = 90 }));
            return config;
        }


        private static ConfigFile BindItemSpawnRates(this ConfigFile config)
        {
            HeatedMixerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "HeatedMixerSpawnRate", 1);
            ConveyorMixerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ConveyorMixerSpawnRate", 1);
            RapidMixerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RapidMixerSpawnRate", 1);
            MixerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "MixerSpawnRate", 0);
            SuppliesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SuppliesSpawnRate", 0);
            CompactorBinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CompactorBinSpawnRate", 1);
            ComposterBinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ComposterBinSpawnRate", 0);
            ExpandedBinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ExpandedBinSpawnRate", 0);
            BinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BinSpawnRate", 0);
            FireExtinguisherSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FireExtinguisherSpawnRate", 0);
            FloorBufferSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FloorBufferSpawnRate", 1);
            KitchenFloorProtectorSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "KitchenFloorProtectorSpawnRate", 0);
            FastMopSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FastMopSpawnRate", 0);
            LastingMopSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "LastingMopSpawnRate", 0);
            MopSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "MopSpawnRate", 0);
            RobotBufferSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RobotBufferSpawnRate", 1);
            RobotMopSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RobotMopSpawnRate", 0);
            CoffeeMachineSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CoffeeMachineSpawnRate", 0);
            ColouringBookStandSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ColouringBookStandSpawnRate", 0);
            ConveyorSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ConveyorSpawnRate", 1);
            CombinerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CombinerSpawnRate", 1);
            SmartGrabberSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SmartGrabberSpawnRate", 1);
            GrabberSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "GrabberSpawnRate", 1);
            PortionerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PortionerSpawnRate", 1);
            CounterSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CounterSpawnRate", 0);
            KneadingCounterSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "KneadingCounterSpawnRate", 0);
            WorkstationSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WorkstationSpawnRate", 0);
            AffordableBinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "AffordableBinSpawnRate", 0);
            GumballMachineSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "GumballMachineSpawnRate", 0);
            NeonSignSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "NeonSignSpawnRate", 0);
            NeonSign2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "NeonSign2SpawnRate", 0);
            CeilingLightSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CeilingLightSpawnRate", 0);
            StockPictureSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StockPictureSpawnRate", 0);
            DirtyFloorSignSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DirtyFloorSignSpawnRate", 0);
            BarrelSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BarrelSpawnRate", 0);
            BookcaseSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BookcaseSpawnRate", 0);
            DartboardSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DartboardSpawnRate", 0);
            FireplaceSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FireplaceSpawnRate", 0);
            RugSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RugSpawnRate", 0);
            WallLightSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WallLightSpawnRate", 0);
            BannerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BannerSpawnRate", 0);
            ChristmasTreeSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ChristmasTreeSpawnRate", 0);
            FairyLightsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FairyLightsSpawnRate", 0);
            CandelabraSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CandelabraSpawnRate", 0);
            ChandelierSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ChandelierSpawnRate", 0);
            PreciousFlowerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PreciousFlowerSpawnRate", 0);
            ClassicalGlobeSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ClassicalGlobeSpawnRate", 0);
            PaintingSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PaintingSpawnRate", 0);
            Rug2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "Rug2SpawnRate", 0);
            StatueSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StatueSpawnRate", 0);
            BrandMascotSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BrandMascotSpawnRate", 0);
            TidyPlantSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TidyPlantSpawnRate", 0);
            CeilingLight2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CeilingLight2SpawnRate", 0);
            AbstractLampSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "AbstractLampSpawnRate", 0);
            VaseSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "VaseSpawnRate", 0);
            IndoorfountainSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "IndoorfountainSpawnRate", 0);
            CalmPaintingSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CalmPaintingSpawnRate", 0);
            PlantSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PlantSpawnRate", 0);
            Rug3SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "Rug3SpawnRate", 0);
            DrinkTapSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DrinkTapSpawnRate", 0);
            WineBarrelSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WineBarrelSpawnRate", 0);
            DumbwaiterSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DumbwaiterSpawnRate", 0);
            FryerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FryerSpawnRate", 0);
            BeehiveSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BeehiveSpawnRate", 0);
            FlowerSpawnSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FlowerSpawnSpawnRate", 0);
            GasLimiterSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "GasLimiterSpawnRate", 0);
            GasOverrideSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "GasOverrideSpawnRate", 0);
            DangerHobSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DangerHobSpawnRate", 0);
            SafetyHobSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SafetyHobSpawnRate", 1);
            StarterHobSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StarterHobSpawnRate", 0);
            HobSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "HobSpawnRate", 0);
            ManualHobSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ManualHobSpawnRate", 0);
            TutorialHobSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TutorialHobSpawnRate", 0);
            BookingsStandSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BookingsStandSpawnRate", 0);
            HostingStandSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "HostingStandSpawnRate", 0);
            DisplayStandSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DisplayStandSpawnRate", 0);
            NameplateSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "NameplateSpawnRate", 0);
            AccountingDeskSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "AccountingDeskSpawnRate", 0);
            BlueprintCabinetSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BlueprintCabinetSpawnRate", 0);
            CopyingDeskSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CopyingDeskSpawnRate", 0);
            DiscountDeskSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DiscountDeskSpawnRate", 0);
            DiscountDesk2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DiscountDesk2SpawnRate", 0);
            BlueprintDeskSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BlueprintDeskSpawnRate", 0);
            ResearchDeskSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ResearchDeskSpawnRate", 0);
            BookingDeskSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BookingDeskSpawnRate", 0);
            ExtraLifeSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ExtraLifeSpawnRate", 0);
            FastFoodTerminalSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FastFoodTerminalSpawnRate", 0);
            SpecialsTerminalSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SpecialsTerminalSpawnRate", 0);
            OrderingTerminalSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "OrderingTerminalSpawnRate", 0);
            DoubleOvenSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DoubleOvenSpawnRate", 0);
            MicrowaveSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "MicrowaveSpawnRate", 0);
            OvenSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "OvenSpawnRate", 0);
            BalloonsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BalloonsSpawnRate", 0);
            BirthdayBannerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BirthdayBannerSpawnRate", 0);
            PianoSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PianoSpawnRate", 0);
            ApplesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ApplesSpawnRate", 0);
            BeansSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BeansSpawnRate", 0);
            BroccoliSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BroccoliSpawnRate", 0);
            BurgerBunsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BurgerBunsSpawnRate", 0);
            PattiesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PattiesSpawnRate", 0);
            CarrotsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CarrotsSpawnRate", 0);
            CheeseSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CheeseSpawnRate", 0);
            ChristmasCrackersSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ChristmasCrackersSpawnRate", 0);
            EggsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "EggsSpawnRate", 0);
            FishSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FishSpawnRate", 0);
            Fish2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "Fish2SpawnRate", 0);
            FlourSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FlourSpawnRate", 0);
            HotdogbunSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "HotdogbunSpawnRate", 0);
            HotDogsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "HotDogsSpawnRate", 0);
            IceCreamSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "IceCreamSpawnRate", 0);
            ExtraKetchupSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ExtraKetchupSpawnRate", 0);
            LettuceSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "LettuceSpawnRate", 0);
            MeatSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "MeatSpawnRate", 0);
            MushroomsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "MushroomsSpawnRate", 0);
            ExtraMustardSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ExtraMustardSpawnRate", 0);
            NutsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "NutsSpawnRate", 0);
            OilSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "OilSpawnRate", 0);
            OlivesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "OlivesSpawnRate", 0);
            OnionSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "OnionSpawnRate", 0);
            PotatoSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PotatoSpawnRate", 0);
            RiceSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RiceSpawnRate", 0);
            ThickcutmeatSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ThickcutmeatSpawnRate", 0);
            ThincutmeatSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ThincutmeatSpawnRate", 0);
            TomatoSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TomatoSpawnRate", 0);
            TurkeySpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TurkeySpawnRate", 0);
            WineSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WineSpawnRate", 0);
            Counter2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "Counter2SpawnRate", 0);
            PracticeModeTriggerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PracticeModeTriggerSpawnRate", 0);
            RerollShopTriggerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RerollShopTriggerSpawnRate", 0);
            TutorialTriggerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TutorialTriggerSpawnRate", 0);
            AutoPlaterSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "AutoPlaterSpawnRate", 0);
            DishRackSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DishRackSpawnRate", 0);
            DishRack2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DishRack2SpawnRate", 0);
            ItemSourceReservationSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ItemSourceReservationSpawnRate", 0);
            ItemSourceSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ItemSourceSpawnRate", 0);
            StarterPlatesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StarterPlatesSpawnRate", 0);
            PlatesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PlatesSpawnRate", 0);
            PotStackSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PotStackSpawnRate", 0);
            ServingBoardsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ServingBoardsSpawnRate", 0);
            WoksSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WoksSpawnRate", 0);
            FreezerSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FreezerSpawnRate", 0);
            FrozenPrepStationSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FrozenPrepStationSpawnRate", 0);
            PrepStationSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PrepStationSpawnRate", 0);
            RackSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RackSpawnRate", 0);
            StorageCupboardSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StorageCupboardSpawnRate", 0);
            BreadsticksSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BreadsticksSpawnRate", 0);
            CandleBoxSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CandleBoxSpawnRate", 0);
            FlowerPotSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "FlowerPotSpawnRate", 0);
            NapkinsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "NapkinsSpawnRate", 0);
            SharpCutlerySpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SharpCutlerySpawnRate", 0);
            SpecialsMenuSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SpecialsMenuSpawnRate", 0);
            ChairSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ChairSpawnRate", 0);
            CoffeeTableSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CoffeeTableSpawnRate", 0);
            Chair2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "Chair2SpawnRate", 0);
            BarTableSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BarTableSpawnRate", 0);
            TableSimpleClothSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TableSimpleClothSpawnRate", 0);
            MetalTableSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "MetalTableSpawnRate", 0);
            TableFancyClothSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TableFancyClothSpawnRate", 0);
            DiningTableSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DiningTableSpawnRate", 0);
            RollingPinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "RollingPinSpawnRate", 0);
            ScrubbingBrushSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "ScrubbingBrushSpawnRate", 0);
            SharpKnifeSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SharpKnifeSpawnRate", 0);
            TrainersSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TrainersSpawnRate", 0);
            WelliesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WelliesSpawnRate", 0);
            WorkBootsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WorkBootsSpawnRate", 0);
            TrayStandSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TrayStandSpawnRate", 0);
            DishWasherSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "DishWasherSpawnRate", 0);
            WashBasinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WashBasinSpawnRate", 0);
            SinkSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SinkSpawnRate", 0);
            PowerSinkSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PowerSinkSpawnRate", 0);
            SoakingSinkSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SoakingSinkSpawnRate", 0);
            StarterSinkSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StarterSinkSpawnRate", 0);
            WheelieBinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "WheelieBinSpawnRate", 0);
            BedSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BedSpawnRate", 0);
            //Halloween update
            GrabberRotatingSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "GrabberRotatingSpawnRate", 1);
            TeleporterSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "TeleporterSpawnRate", 1);
            CobwebsSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CobwebsSpawnRate", 0);
            GhostStatueSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "GhostStatueSpawnRate", 0);
            PumpkinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "PumpkinSpawnRate", 0);
            SkeletonSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "SkeletonSpawnRate", 0);
            CornSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "CornSpawnRate", 0);
            BananasSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "BananasSpawnRate", 0);
            StrawberriesSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StrawberriesSpawnRate", 0);
            Pumpkin2SpawnRate = config.Bind("5. Custom Shop Spawn Rates", "Pumpkin2SpawnRate", 0);
            UpgradeKitSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "UpgradeKitSpawnRate", 1);


            return config;
        }
    }
}
