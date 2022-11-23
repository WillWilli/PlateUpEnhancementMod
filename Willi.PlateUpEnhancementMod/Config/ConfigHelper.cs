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
        public const string ModVersion = "0.4.3";

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
        public static ConfigEntry<float> SpeedMultiplier { get; set; }


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
        public static ConfigEntry<int> HeatedMixerSpawnRate;
        public static ConfigEntry<int> ConveyorMixerSpawnRate;
        public static ConfigEntry<int> RapidMixerSpawnRate;
        public static ConfigEntry<int> MixerSpawnRate;
        public static ConfigEntry<int> SuppliesSpawnRate;
        public static ConfigEntry<int> CompactorBinSpawnRate;
        public static ConfigEntry<int> ComposterBinSpawnRate;
        public static ConfigEntry<int> ExpandedBinSpawnRate;
        public static ConfigEntry<int> BinSpawnRate;
        public static ConfigEntry<int> StarterBinSpawnRate;
        public static ConfigEntry<int> FireExtinguisherSpawnRate;
        public static ConfigEntry<int> FloorBufferSpawnRate;
        public static ConfigEntry<int> KitchenFloorProtectorSpawnRate;
        public static ConfigEntry<int> FastMopSpawnRate;
        public static ConfigEntry<int> LastingMopSpawnRate;
        public static ConfigEntry<int> MopSpawnRate;
        public static ConfigEntry<int> RobotBufferSpawnRate;
        public static ConfigEntry<int> RobotMopSpawnRate;
        public static ConfigEntry<int> CoffeeMachineSpawnRate;
        public static ConfigEntry<int> ColouringBookStandSpawnRate;
        public static ConfigEntry<int> ConveyorSpawnRate;
        public static ConfigEntry<int> CombinerSpawnRate;
        public static ConfigEntry<int> SmartGrabberSpawnRate;
        public static ConfigEntry<int> GrabberSpawnRate;
        public static ConfigEntry<int> PortionerSpawnRate;
        public static ConfigEntry<int> CounterSpawnRate;
        public static ConfigEntry<int> KneadingCounterSpawnRate;
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
        public static ConfigEntry<int> BannerSpawnRate;
        public static ConfigEntry<int> ChristmasTreeSpawnRate;
        public static ConfigEntry<int> FairyLightsSpawnRate;
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
        public static ConfigEntry<int> Rug3SpawnRate;
        public static ConfigEntry<int> DrinkTapSpawnRate;
        public static ConfigEntry<int> WineBarrelSpawnRate;
        public static ConfigEntry<int> DumbwaiterSpawnRate;
        public static ConfigEntry<int> FryerSpawnRate;
        public static ConfigEntry<int> BeehiveSpawnRate;
        public static ConfigEntry<int> FlowerSpawnSpawnRate;
        public static ConfigEntry<int> GasLimiterSpawnRate;
        public static ConfigEntry<int> GasOverrideSpawnRate;
        public static ConfigEntry<int> DangerHobSpawnRate;
        public static ConfigEntry<int> SafetyHobSpawnRate;
        public static ConfigEntry<int> StarterHobSpawnRate;
        public static ConfigEntry<int> HobSpawnRate;
        public static ConfigEntry<int> ManualHobSpawnRate;
        public static ConfigEntry<int> TutorialHobSpawnRate;
        public static ConfigEntry<int> BookingsStandSpawnRate;
        public static ConfigEntry<int> HostingStandSpawnRate;
        public static ConfigEntry<int> DisplayStandSpawnRate;
        public static ConfigEntry<int> NameplateSpawnRate;
        public static ConfigEntry<int> AccountingDeskSpawnRate;
        public static ConfigEntry<int> BlueprintCabinetSpawnRate;
        public static ConfigEntry<int> CopyingDeskSpawnRate;
        public static ConfigEntry<int> DiscountDeskSpawnRate;
        public static ConfigEntry<int> DiscountDesk2SpawnRate;
        public static ConfigEntry<int> BlueprintDeskSpawnRate;
        public static ConfigEntry<int> ResearchDeskSpawnRate;
        public static ConfigEntry<int> BookingDeskSpawnRate;
        public static ConfigEntry<int> ExtraLifeSpawnRate;
        public static ConfigEntry<int> FastFoodTerminalSpawnRate;
        public static ConfigEntry<int> SpecialsTerminalSpawnRate;
        public static ConfigEntry<int> OrderingTerminalSpawnRate;
        public static ConfigEntry<int> DoubleOvenSpawnRate;
        public static ConfigEntry<int> MicrowaveSpawnRate;
        public static ConfigEntry<int> OvenSpawnRate;
        public static ConfigEntry<int> BalloonsSpawnRate;
        public static ConfigEntry<int> BirthdayBannerSpawnRate;
        public static ConfigEntry<int> PianoSpawnRate;
        public static ConfigEntry<int> ApplesSpawnRate;
        public static ConfigEntry<int> BeansSpawnRate;
        public static ConfigEntry<int> BroccoliSpawnRate;
        public static ConfigEntry<int> BurgerBunsSpawnRate;
        public static ConfigEntry<int> PattiesSpawnRate;
        public static ConfigEntry<int> CarrotsSpawnRate;
        public static ConfigEntry<int> CheeseSpawnRate;
        public static ConfigEntry<int> ChristmasCrackersSpawnRate;
        public static ConfigEntry<int> EggsSpawnRate;
        public static ConfigEntry<int> FishSpawnRate;
        public static ConfigEntry<int> Fish2SpawnRate;
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
        public static ConfigEntry<int> Counter2SpawnRate;
        public static ConfigEntry<int> PracticeModeTriggerSpawnRate;
        public static ConfigEntry<int> RerollShopTriggerSpawnRate;
        public static ConfigEntry<int> TutorialTriggerSpawnRate;
        public static ConfigEntry<int> AutoPlaterSpawnRate;
        public static ConfigEntry<int> DishRackSpawnRate;
        public static ConfigEntry<int> DishRack2SpawnRate;
        public static ConfigEntry<int> ItemSourceReservationSpawnRate;
        public static ConfigEntry<int> ItemSourceSpawnRate;
        public static ConfigEntry<int> StarterPlatesSpawnRate;
        public static ConfigEntry<int> PlatesSpawnRate;
        public static ConfigEntry<int> PotStackSpawnRate;
        public static ConfigEntry<int> ServingBoardsSpawnRate;
        public static ConfigEntry<int> WoksSpawnRate;
        public static ConfigEntry<int> FreezerSpawnRate;
        public static ConfigEntry<int> FrozenPrepStationSpawnRate;
        public static ConfigEntry<int> PrepStationSpawnRate;
        public static ConfigEntry<int> RackSpawnRate;
        public static ConfigEntry<int> StorageCupboardSpawnRate;
        public static ConfigEntry<int> BreadsticksSpawnRate;
        public static ConfigEntry<int> CandleBoxSpawnRate;
        public static ConfigEntry<int> FlowerPotSpawnRate;
        public static ConfigEntry<int> NapkinsSpawnRate;
        public static ConfigEntry<int> SharpCutlerySpawnRate;
        public static ConfigEntry<int> SpecialsMenuSpawnRate;
        public static ConfigEntry<int> ChairSpawnRate;
        public static ConfigEntry<int> CoffeeTableSpawnRate;
        public static ConfigEntry<int> Chair2SpawnRate;
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
        public static ConfigEntry<int> StarterSinkSpawnRate;
        public static ConfigEntry<int> WheelieBinSpawnRate;
        public static ConfigEntry<int> BedSpawnRate;
        
        public static ConfigEntry<int> GrabberRotatingSpawnRate;
        public static ConfigEntry<int> TeleporterSpawnRate;
        public static ConfigEntry<int> CobwebsSpawnRate;
        public static ConfigEntry<int> GhostStatueSpawnRate;
        public static ConfigEntry<int> PumpkinSpawnRate;
        public static ConfigEntry<int> SkeletonSpawnRate;
        public static ConfigEntry<int> CornSpawnRate;
        public static ConfigEntry<int> BananasSpawnRate;
        public static ConfigEntry<int> StrawberriesSpawnRate;
        public static ConfigEntry<int> Pumpkin2SpawnRate;
        public static ConfigEntry<int> UpgradeKitSpawnRate;

        public static ConfigEntry<int> CherrySpawnRate;
        public static ConfigEntry<int> MilkSpawnRate;
        public static ConfigEntry<int> SugarSpawnRate;
        public static ConfigEntry<int> CranberrySpawnRate;
        #endregion

        public static void BindAllConfig(this ConfigFile config)
        {
            config
                .BindItemSpawnRates()
                .BindGeneralConfig()
                .BindNoClip()
                .BindItemSpawnerConfig()
                .BindDefaultShopConfig()
                .BindCustomShopConfig();
        }

        public static List<int> GetCustomShopItemsIdList()
        {
            var itemIdSpawnList = new List<int>();

            foreach(var config in GetAllItemsConfigs().WithSpawnRates())
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
                throw new ArgumentException($"ID for item {itemName} does not exist.", "itemName");
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
            var itemIdFields = typeof(ItemIdReference).GetFields();

            var items = new List<ItemConfig>();
            foreach(var field in itemIdFields)
            {
                if (field.Name.StartsWith("_"))
                    continue;
                items.Add(GetItemConfigFromField(field));
            }

            return items;
        }
        private static ItemConfig GetItemConfigFromField(System.Reflection.FieldInfo field)
        {
            var fieldName = field.Name;
            var fieldValue = (int)field.GetValue(typeof(int));
            return new ItemConfig() { Name = fieldName, Id = fieldValue};
        }

        private static List<ItemConfig> WithSpawnRates(this List<ItemConfig> itemConfigs)
        {
            var spawnRateProperties = typeof(ConfigHelper).GetFields()
                .Where(property => property.Name.Contains("SpawnRate"));

            foreach (var itemConfig in itemConfigs)
            {
                try
                {
                    var spawnRateForConfig = spawnRateProperties.First((spawnRate) =>
                        spawnRate.Name == itemConfig.Name + "SpawnRate");

                    var spawnRateValue = (ConfigEntry<int>)spawnRateForConfig.GetValue(typeof(ConfigEntry<int>));
                    itemConfig.SpawnRate = spawnRateValue.Value;
                }
                catch (InvalidOperationException)
                {
                    Log.LogWarning($"No custom spawn rate found for item '{itemConfig.Name}'");
                }
            }

            return itemConfigs;
        }

        private static ConfigFile BindGeneralConfig(this ConfigFile config)
        {
            IsModEnabled = config.Bind("0. Toggle Mod On / Off", "EnableMod", true, new ConfigDescription("Whether or not to apply this mod. Set to 'disabled' to play vanilla.", null, new ConfigurationManagerAttributes { Order = 100 }));

            MoneyRewardMultiplier = config.Bind("1. General", "MoneyRewardMultiplier", 1.25f, new ConfigDescription("Multiplier for the money rewards.", null, new ConfigurationManagerAttributes { Order = 100 }));
            PatienceMultiplier = config.Bind("1. General", "PatienceMultiplier", 1f, new ConfigDescription("Multiplier for customer patience, 0 = infinite patience.", null, new ConfigurationManagerAttributes { Order = 95 }));
            NumberOfCustomersMultiplier = config.Bind("1. General", "NumberOfCustomersMultiplier", 1f, new ConfigDescription("Multiplier for the number of customers to arrive each day.", null, new ConfigurationManagerAttributes { Order = 90 }));
            MinGroupSize = config.Bind("1. General", "MinGroupSize", -1, new ConfigDescription("Override the minimum table size (Max 20), invalid settings will be ignored.", null, new ConfigurationManagerAttributes { Order = 89 }));
            MaxGroupSize = config.Bind("1. General", "MaxGroupSize", -1, new ConfigDescription("Override the maximum table size (Max 20), invalid settings will be ignored.", null, new ConfigurationManagerAttributes { Order = 88 }));

            return config;
        }

        private static ConfigFile BindNoClip(this ConfigFile config)
        {
            NoClipKeyboardShortcut = config.Bind("2. NoClip", "NoClip", new KeyboardShortcut(KeyCode.N), new ConfigDescription("Toggle walking through walls & objects (stand still to toggle).", null, new ConfigurationManagerAttributes { Order = 90 }));
            SpeedMultiplier = config.Bind("2. NoClip", "NoClipSpeedMultiplier", 1.25f, new ConfigDescription("Multiplier for the walk speed while NoClip is active.", null, new ConfigurationManagerAttributes { Order = 80 }));

            return config;
        }

        private static ConfigFile BindItemSpawnerConfig(this ConfigFile config)
        {
            SpawnItemMenuKeyboardShortcut = config.Bind("3. Item spawner window", "KeyboardShortcutToOpenWindow", new KeyboardShortcut(KeyCode.F2), new ConfigDescription("Use this keyboard shortcut to show/hide the item spawner window.", null, new ConfigurationManagerAttributes { Order = 100 }));
            ItemSpawnerWindowHeight = config.Bind("3. Item spawner window", "WindowHeight", 400, new ConfigDescription("The height of the draggable window.", null, new ConfigurationManagerAttributes { Order = 90 }));

            return config;
        }

        private static ConfigFile BindDefaultShopConfig(this ConfigFile config)
        {
            DefaultShopNumberOfItems = config.Bind("4. Default Shop", "NumberOfItemsToSpawn", 4, new ConfigDescription("The numbers of items to spawn in each shop", null, new ConfigurationManagerAttributes { Order = 90 }));
            DefaultShopUpgradedChance = config.Bind("4. Default Shop", "UpgradeChance", 1.5f, new ConfigDescription("The chance of getting an upgraded shop", new AcceptableValueRange<float>(0, 1), new ConfigurationManagerAttributes { Order = 80 }));
            RerollShopFixedCost = config.Bind("4. Default Shop", "FixRerollCost", -1, new ConfigDescription("Override the shop reroll cost, set to -1 to ignore", null, new ConfigurationManagerAttributes { Order = 80 }));

            return config;
        }

        private static ConfigFile BindCustomShopConfig(this ConfigFile config)
        {
            CustomShopNumItemsToSpawn = config.Bind("5. Custom Shop", "NumberOfShopItemsToSpawn", 2, new ConfigDescription("The number of items to spawn in the custom shop", null, new ConfigurationManagerAttributes { Order = 100 }));
            CustomShopPriceMultiplier = config.Bind("5. Custom Shop", "PriceMultiplier", 1f, new ConfigDescription("The price factor of items spawned in the custom shop", new AcceptableValueRange<float>(0f, 10f), new ConfigurationManagerAttributes { Order = 90 }));
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
            StarterBinSpawnRate = config.Bind("5. Custom Shop Spawn Rates", "StarterBinSpawnRate", 0);
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
            GrabberRotatingSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "GrabberRotatingSpawnRate", 1);
            TeleporterSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "TeleporterSpawnRate", 1);
            CobwebsSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "CobwebsSpawnRate", 0);
            GhostStatueSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "GhostStatueSpawnRate", 0);
            PumpkinSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "PumpkinSpawnRate", 0);
            SkeletonSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "SkeletonSpawnRate", 0);
            CornSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "CornSpawnRate", 0);
            BananasSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "BananasSpawnRate", 0);
            StrawberriesSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "StrawberriesSpawnRate", 0);
            Pumpkin2SpawnRate = config.Bind("6. Custom Shop Spawn Rates", "Pumpkin2SpawnRate", 0);
            UpgradeKitSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "UpgradeKitSpawnRate", 1);

            // Turkey day update
            CherrySpawnRate = config.Bind("6. Custom Shop Spawn Rates", "CherrySpawnRate", 0);
            MilkSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "MilkSpawnRate", 0);
            SugarSpawnRate = config.Bind("6. Custom Shop Spawn Rates", "SugarSpawnRate", 0);
            CranberrySpawnRate = config.Bind("6. Custom Shop Spawn Rates", "CranberrySpawnRate", 0);

            return config;
        }
    }
}
