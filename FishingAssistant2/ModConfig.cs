using StardewModdingAPI;

namespace ChibiKyu.StardewMods.FishingAssistant2
{
    public class ModConfig
    {
        /// <summary>Button for toggling max or free fishing rod cast power</summary>
        public SButton EnableModButton { get; set; } = SButton.F5;

        /// <summary>Button for toggling catch or ignore treasure in fishing mini-game</summary>
        public SButton CatchTreasureButton { get; set; } = SButton.F6;

        /// <summary>Position to display mod status</summary>
        public string ModStatusPosition { get; set; } = "Left";
        
        /// <summary>Toggle for enabling max cast power</summary>
        public bool MaxCastPower { get; set; } = true;

        /// <summary>Toggle for making fish bite instantly</summary>
        public bool InstantFishBite { get; set; } = false;
        
        /// <summary>Chance of finding treasure while fishing</summary>
        public string TreasureChance { get; set; } = "Default";
        
        /// <summary>Preference for fish quality</summary>
        public string PreferFishQuality { get; set; } = "Any";

        /// <summary>Whether to consider every catch as perfectly executed</summary>
        public bool AlwaysPerfect { get; set; } = false;
        
        /// <summary>Toggle for always maximum fish size</summary>
        public bool AlwaysMaxFishSize { get; set; } = false;
        
        /// <summary>Multiplier applied to fish difficulty</summary>
        public float FishDifficultyMultiplier { get; set; } = 1;

        /// <summary>Value added to fish difficulty</summary>
        public int FishDifficultyAdditive { get; set; } = 0;

        /// <summary>Toggle for instant fish catching</summary>
        public bool InstantCatchFish { get; set; } = false;

        /// <summary>Toggle for instant treasure catching</summary>
        public bool InstantCatchTreasure { get; set; } = false;
        
        /// <summary>Toggle for auto casting fishing rod</summary>
        public bool AutoCastFishingRod { get; set; } = true;

        /// <summary>Toggle for auto hooking fish</summary>
        public bool AutoHookFish { get; set; } = true;

        /// <summary>Toggle for auto playing fishing mini-game</summary>
        public bool AutoPlayMiniGame { get; set; } = true;

        /// <summary>Toggle for auto closing fish popup</summary>
        public bool AutoClosePopup { get; set; } = true;

        /// <summary>Toggle for auto looting treasure</summary>
        public bool AutoLootTreasure { get; set; } = true;
        
        /// <summary>Action to take if inventory is full</summary>
        public string ActionIfInventoryFull { get; set; } = "Stop Loot";
        
        /// <summary>Toggle for auto attaching bait if possible</summary>
        public bool AutoAttachBait { get; set; } = false;
        
        /// <summary>Preference for bait type</summary>
        public string PreferBait { get; set; } = "Any";
        
        /// <summary>Toggle for infinite fishing bait</summary>
        public bool InfiniteBait { get; set; } = false;
        
        /// <summary>Toggle for spawning bait if none is available</summary>
        public bool SpawnBaitIfDontHave { get; set; } = false;
        
        /// <summary>Toggle for auto attaching tackles if possible</summary>
        public bool AutoAttachTackles { get; set; } = false;
        
        /// <summary>Preference for tackle type</summary>
        public string PreferTackle { get; set; } = "Any";
        
        /// <summary>Toggle for infinite fishing tackles</summary>
        public bool InfiniteTackle { get; set; } = false;
        
        /// <summary>Toggle for spawning tackles if none are available</summary>
        public bool SpawnTackleIfDontHave { get; set; } = false;
        
        /// <summary>Toggle for pausing fishing at a certain time</summary>
        public string AutoPauseFishing { get; set; } = "WarnAndPause";

        /// <summary>Time to stop fishing</summary>
        public int PauseFishingTime { get; set; } = 24;
        
        /// <summary>Number of warnings before pausing fishing</summary>
        public int NumToWarn { get; set; } = 1;

        /// <summary>Toggle for auto eating food if needed</summary>
        public bool AutoEatFood { get; set; } = false;

        /// <summary>Toggle for allowing eating of caught fish</summary>
        public bool AllowEatingFish { get; set; } = false;

        /// <summary>Toggle for displaying fish info while catching fish</summary>
        public bool DisplayFishInfo { get; set; } = true;

        /// <summary>Position to display fish info while playing fishing mini-game</summary>
        public string FishInfoDisplayPosition { get; set; } = "UpperRight";

        /// <summary>Toggle for showing fish name with fish info</summary>
        public bool ShowFishName { get; set; } = true;

        /// <summary>Toggle for showing treasure with fish info</summary>
        public bool ShowTreasure { get; set; } = true;

        /// <summary>Toggle for showing fish info whether uncaught or not</summary>
        public bool ShowUncaughtFishSpecies { get; set; } = false;

        /// <summary>Toggle for always showing fish info if current fish is legendary</summary>
        public bool AlwaysShowLegendaryFish { get; set; } = false;

        /// <summary>Toggle for adding auto-Hook enchantment to fishing rod</summary>
        public bool AddAutoHookEnchantment { get; set; } = false;

        /// <summary>Toggle for adding Efficient enchantment to fishing rod</summary>
        public bool AddEfficientEnchantment { get; set; } = false;

        /// <summary>Toggle for adding Master enchantment to fishing rod</summary>
        public bool AddMasterEnchantment { get; set; } = false;

        /// <summary>Toggle for adding Preserving enchantment to fishing rod</summary>
        public bool AddPreservingEnchantment { get; set; } = false;

        /// <summary>Toggle for removing enchantment when fishing rod is unequipped</summary>
        public bool RemoveEnchantmentWhenUnequipped { get; set; } = true;
    }
}
