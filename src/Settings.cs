using ModSettings;
using System.Reflection;

namespace FullFeatAccess
{
    internal class Settings : JsonModSettings
    {
        [Name("Max Feats")]
        [Description("Enable access to 5 feats in all game modes or use TLD default values. (Does not apply to challenge modes)")]
        [Choice("Default", "Max")]
        public bool maxFeatsAllowed = false;

        [Name("Unlock Feats?")]
        [Description("Unlock or lock feats.")]
        [Choice("No", "Yes")]
        public bool unlockFeats = false;

        [Name("Enable DarkWalker Feat?")]
        [Description("Enabling the DarkWalker feat will also auto-complete the 'Escape The DarkWalker' challenge to prevent odd behavior.")]
        [Choice("No", "Yes")]
        public bool unlockNightWalker = false;

        [Name("Enable Tales Feats?")]
        [Description("This will enable Celestial Navigator & Settled Mind.")]
        [Choice("No", "Yes")]
        public bool unlockTalesFeats = false;

        [Section(" ")]

        [Name("Show Feat Adjustment Options?")]
        [Description("Adjust the requirements to earn a feat and the benefit the feat gives")]
        [Choice("No", "Yes")]
        public bool featAdjustment = false;

        //
        [Name("         - Blizzard Walker")]
        [Description("Show or hide Blizzard Walker settings")]
        [Choice("+", "-")]
        public bool blizzardWalker = false;

        [Name("                  - Days Required")]
        [Description("Days spent in a blizzard required. (Game default = 20)")]
        [Slider(1, 365)]
        public int daysOutsideRequired = 20;

        [Name("                  - Walk Speed Reduction")]
        [Description("Set the penalty reduction to walk speed while walking into the wind. (Game default = 25%)")]
        [Slider(0, 75)]
        public int walkSpeedReduction = 25;

        
        //
        [Name("         - Book Smarts")]
        [Description("Show or hide Book Smarts settings")]
        [Choice("+", "-")]
        public bool bookSmarts = false;

        [Name("                  - Hours Required")]
        [Description("Hours of research required. (Game default = 250)")]
        [Slider(1, 500)]
        public int numHoursRequired = 250;

        [Name("                  - Benefit")]
        [Description("Benefit received from a completely researched book. (Game default = 10%)")]
        [Slider(0, 25)]
        public int percentBenefit = 10;


        //
        [Name("         - Celestial Navigator")]
        [Description("Show or hide Celestial Navigator settings")]
        [Choice("+", "-")]
        public bool celestialNavigator = false;

        [Name("                  - Walking Speed Bonus")]
        [Description("Set how much faster you walk on a clear night or during an aurora. (Game default = 10%)")]
        [Slider(0, 50)]
        public int walkingSpeedBoostPercent = 10;


        //
        [Name("         - Cold Fusion")]
        [Description("Show or hide Cold Fusion settings")]
        [Choice("+", "-")]
        public bool coldFusion = false;

        [Name("                  - Days Outside Required")]
        [Description("Set how many days outside required. (Game default = 100)")]
        [Slider(1, 365)]
        public int numDaysRequiredColdFusion = 100;

        [Name("                  - Temperature Bonus")]
        [Description("Set the bonus to air temperature. (Game default = 2)")]
        [Slider(0, 10)]
        public int temperatureCelsiusBenefit = 2;


        //
        [Name("         - DarkWalker")]
        [Description("Show or hide DarkWalker settings")]
        [Choice("+", "-")]
        public bool nightWalker = false;

        [Name("                  - Day Fatigue")]
        [Description("Set how much more fatigued you are during the day. (Game default = 2.0)")]
        [Slider(1.0f, 3.0f)]
        public float fatigueScaleDayMultiplier = 2.0f;

        [Name("                  - Night Fatigue")]
        [Description("Set how much less fatigued you are during the night. (Game default = 0.5)")]
        [Slider(0.1f, 3.0f)]
        public float fatigueScaleNightMultiplier = 0.5f;


        //
        [Name("         - Efficient Machine")]
        [Description("Show or hide Efficient Machine settings")]
        [Choice("+", "-")]
        public bool efficientMachine = false;

        [Name("                  - Days Survived Required")]
        [Description("Set how many days you need to survive. (Game default = 500)")]
        [Slider(1, 1000)]
        public int numDaysRequiredEfficientMachine = 500;

        [Name("                  - Calorie Benefit")]
        [Description("Set how much less calories your body consumes. (Game default = 10%)")]
        [Slider(0, 25)]
        public int calorieReductionBenefit = 10;


        /*//
        [Name("         - Expert Trapper")]
        [Description("Show or hide Expert Trapper settings")]
        [Choice("+", "-")]
        public bool expertTrapper = false;

        [Name("                  - Snared rabbits Required")]
        [Description("Set how many snared rabbits are required. Snare effectiveness = Rabbits snared, a setting of 250 will set +250% effectiveness. (Game default = 100)")]
        [Slider(1, 500)]
        public int numSnaredRabbitsRequired = 100;*/


        //
        [Name("         - Fire Master")]
        [Description("Show or hide Fire Master settings")]
        [Choice("+", "-")]
        public bool fireMaster = false;

        [Name("                  - Starting Skill Level")]
        [Description("Set the starting Fire Master skill level. (Game default = 3)")]
        [Slider(1, 5)]
        public int defaultFireStartingSkillLevel = 3;

        [Name("                  - Lit Fires Required")]
        [Description("Set the amount of lit fires required. (Game default = 1000)")]
        [Slider(1, 2000)]
        public int numFiresRequired = 1000;


        //
        [Name("         - Free Runner")]
        [Description("Show or hide Free Runner settings")]
        [Choice("+", "-")]
        public bool freeRunner = false;

        [Name("                  - Km Required")]
        [Description("Set the amount of Km sprinted required. (Game default = 50)")]
        [Slider(1, 250)]
        public int numKilometersRequired = 50;

        [Name("                  - Sprinting Calorie Burn")]
        [Description("Set the reduction to calorie burn while sprinting. (Game default = 25%)")]
        [Slider(0, 50)]
        public int calorieReductionBenefitFreeRunner = 25;


        //
        /*[Name("         - Settled Mind")]
        [Description("Show or hide Settled Mind settings")]
        [Choice("+", "-")]
        public bool settledMind = false;

        [Name("                  - Research Benefit")]
        [Description("Set how much faster research actions happen. (Game default = 20%)")]
        [Slider(0f, 50)]
        public float readSpeedBoostPercent = 20f;*/


        //
        [Name("         - Snow Walker")]
        [Description("Show or hide Snow Walker settings")]
        [Choice("+", "-")]
        public bool snowWalker = false;

        [Name("                  - Km Traveled")]
        [Description("Set the amount of Km traveled required. (Game default = 1000)")]
        [Slider(1, 2000)]
        public int numKilometersRequiredSnowWalker = 1000;

        [Name("                  - Stamina recharge rate")]
        [Description("Set how much faster the stamina bar recharges. (Game default = 20%)")]
        [Slider(0, 50)]
        public int staminaRechargeFasterPercent = 20;


        //
        [Name("         - Straight To The Heart")]
        [Description("Show or hide Straight To The Heart settings")]
        [Choice("+", "-")]
        public bool straightToHeart = false;

        [Name("                  - Drinks Required")]
        [Description("Set the amount of coffee, energy drinks, or emergency stims required. (Game default = 250)")]
        [Slider(1, 500)]
        public int itemConsumedCountRequired = 250;

        [Name("                  - Effects Benefit")]
        [Description("Set how much longer the effects of coffee, energgy drinks, and emergenct stims last. (Game default = 25%)")]
        [Slider(0, 50)]
        public int effectiveLengthIncreasePercent = 25;


        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(featAdjustment) ||
                field.Name == nameof(blizzardWalker) ||
                field.Name == nameof(daysOutsideRequired) ||
                field.Name == nameof(walkSpeedReduction) ||

                field.Name == nameof(bookSmarts) ||
                field.Name == nameof(numHoursRequired) ||
                field.Name == nameof(percentBenefit) ||

                field.Name == nameof(celestialNavigator) ||
                field.Name == nameof(walkingSpeedBoostPercent) ||

                field.Name == nameof(coldFusion) ||
                field.Name == nameof(numDaysRequiredColdFusion) ||
                field.Name == nameof(temperatureCelsiusBenefit) ||

                field.Name == nameof(nightWalker) ||
                field.Name == nameof(fatigueScaleDayMultiplier) ||
                field.Name == nameof(fatigueScaleNightMultiplier) ||

                field.Name == nameof(efficientMachine) ||
                field.Name == nameof(numDaysRequiredEfficientMachine) ||
                field.Name == nameof(calorieReductionBenefit) ||

                //field.Name == nameof(expertTrapper) ||
                //field.Name == nameof(numSnaredRabbitsRequired) ||

                field.Name == nameof(fireMaster) ||
                field.Name == nameof(defaultFireStartingSkillLevel) ||
                field.Name == nameof(numFiresRequired) ||

                field.Name == nameof(freeRunner) ||
                field.Name == nameof(numKilometersRequired) ||
                field.Name == nameof(calorieReductionBenefitFreeRunner) ||

                //field.Name == nameof(settledMind) ||
                //field.Name == nameof(readSpeedBoostPercent) ||

                field.Name == nameof(snowWalker) ||
                field.Name == nameof(numKilometersRequiredSnowWalker) ||
                field.Name == nameof(staminaRechargeFasterPercent) ||

                field.Name == nameof(straightToHeart) ||
                field.Name == nameof(itemConsumedCountRequired) ||
                field.Name == nameof(effectiveLengthIncreasePercent))

            {
                Refresh();
            }
        }

        internal void Refresh()
        {
            SetFieldVisible(nameof(blizzardWalker), featAdjustment);
            SetFieldVisible(nameof(daysOutsideRequired), blizzardWalker && featAdjustment);
            SetFieldVisible(nameof(walkSpeedReduction), blizzardWalker && featAdjustment);

            SetFieldVisible(nameof(bookSmarts), featAdjustment);
            SetFieldVisible(nameof(numHoursRequired), bookSmarts && featAdjustment);
            SetFieldVisible(nameof(percentBenefit), bookSmarts && featAdjustment);

            SetFieldVisible(nameof(celestialNavigator), featAdjustment);
            SetFieldVisible(nameof(walkingSpeedBoostPercent), celestialNavigator && featAdjustment);

            SetFieldVisible(nameof(coldFusion), featAdjustment);
            SetFieldVisible(nameof(numDaysRequiredColdFusion), coldFusion && featAdjustment);
            SetFieldVisible(nameof(temperatureCelsiusBenefit), coldFusion && featAdjustment);

            SetFieldVisible(nameof(nightWalker), featAdjustment);
            SetFieldVisible(nameof(fatigueScaleDayMultiplier), nightWalker && featAdjustment);
            SetFieldVisible(nameof(fatigueScaleNightMultiplier), nightWalker && featAdjustment);
            
            SetFieldVisible(nameof(efficientMachine), featAdjustment);
            SetFieldVisible(nameof(numDaysRequiredEfficientMachine), efficientMachine && featAdjustment);
            SetFieldVisible(nameof(calorieReductionBenefit), efficientMachine && featAdjustment);

            //SetFieldVisible(nameof(expertTrapper), featAdjustment);
            //SetFieldVisible(nameof(numSnaredRabbitsRequired), expertTrapper && featAdjustment);

            SetFieldVisible(nameof(fireMaster), featAdjustment);
            SetFieldVisible(nameof(defaultFireStartingSkillLevel), fireMaster && featAdjustment);
            SetFieldVisible(nameof(numFiresRequired), fireMaster && featAdjustment);

            SetFieldVisible(nameof(freeRunner), featAdjustment);
            SetFieldVisible(nameof(numKilometersRequired), freeRunner && featAdjustment);
            SetFieldVisible(nameof(calorieReductionBenefitFreeRunner), freeRunner && featAdjustment);

            //SetFieldVisible(nameof(settledMind), featAdjustment);
            //SetFieldVisible(nameof(readSpeedBoostPercent), settledMind && featAdjustment);

            SetFieldVisible(nameof(snowWalker), featAdjustment);
            SetFieldVisible(nameof(numKilometersRequiredSnowWalker), snowWalker && featAdjustment);
            SetFieldVisible(nameof(staminaRechargeFasterPercent), snowWalker && featAdjustment);

            SetFieldVisible(nameof(straightToHeart), featAdjustment);
            SetFieldVisible(nameof(itemConsumedCountRequired), straightToHeart && featAdjustment);
            SetFieldVisible(nameof(effectiveLengthIncreasePercent), straightToHeart && featAdjustment);

        }

        protected override void OnConfirm()
        {
            base.OnConfirm();

            FeatsManagerReload.ReloadFeatsManager();
        }

        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("FullFeatAccess");
            settings.Refresh();
        }
    }
}
