using Il2Cpp;
using MelonLoader;
using Il2CppTLD.SaveState;

namespace FullFeatAccess
{
    public static class FeatsManagerReload
    {
        public static void ReloadFeatsManager()
        {
            var featsManager = GameManager.GetFeatsManager();
            if (featsManager == null)
            {
                MelonLogger.Msg("[FullFeatAccess] FeatsManager not found!");
                return;
            }

            try
            {
                string serializedData = featsManager.Serialize();

                featsManager.HandleDeserialization(ProfileState.Instance);

                ApplyUpdatedFeatValues(featsManager);

                //MelonLogger.Msg("[FullFeatAccess] FeatsManager state reloaded successfully.");
            }
            catch (Exception ex)
            {
                MelonLogger.Msg($"[FullFeatAccess] Error reloading FeatsManager: {ex}");
            }
        }

        private static void ApplyUpdatedFeatValues(FeatsManager featsManager)
        {
            if (Settings.settings.featAdjustment)
            {
                if (featsManager.GetFeat(FeatType.BlizzardWalker))
                {
                    FeatsManager.m_Feat_BlizzardWalker.m_BlizzardDaysOutsideCountRequired = Settings.settings.daysOutsideRequired;
                    FeatsManager.m_Feat_BlizzardWalker.m_BlizzardHoursOutsideRequired = Settings.settings.daysOutsideRequired * 24;
                    FeatsManager.m_Feat_BlizzardWalker.m_WalkingSpeedInWindReductionPercent = Settings.settings.walkSpeedReduction;
                }

                if (featsManager.GetFeat(FeatType.BookSmarts))
                {
                    FeatsManager.m_Feat_BookSmarts.m_NumHoursRequired = Settings.settings.numHoursRequired;
                    FeatsManager.m_Feat_BookSmarts.m_PercentBenefit = Settings.settings.percentBenefit;
                }

                if (featsManager.GetFeat(FeatType.CelestialNavigator))
                {
                    FeatsManager.m_Feat_CelestialNavigator.m_WalkingSpeedBoostPercent = Settings.settings.walkingSpeedBoostPercent;
                }

                if (featsManager.GetFeat(FeatType.ColdFusion))
                {
                    FeatsManager.m_Feat_ColdFusion.m_NumDaysRequired = Settings.settings.numDaysRequiredColdFusion;
                    FeatsManager.m_Feat_ColdFusion.m_TemperatureCelsiusBenefit = Settings.settings.temperatureCelsiusBenefit;
                }

                if (featsManager.GetFeat(FeatType.NightWalker))
                {
                    FeatsManager.m_Feat_NightWalker.m_FatigueScaleDayMultiplier = Settings.settings.fatigueScaleDayMultiplier;
                    FeatsManager.m_Feat_NightWalker.m_FatigueScaleNightMultiplier = Settings.settings.fatigueScaleNightMultiplier;
                }

                if (featsManager.GetFeat(FeatType.EfficientMachine))
                {
                    FeatsManager.m_Feat_EfficientMachine.m_NumDaysRequired = Settings.settings.numDaysRequiredEfficientMachine;
                    FeatsManager.m_Feat_EfficientMachine.m_CalorieReductionBenefit = Settings.settings.calorieReductionBenefit;
                }

                /*if (featsManager.GetFeat(FeatType.ExpertTrapper))
                {
                    FeatsManager.m_Feat_ExpertTrapper.m_NumSnaredRabbitsRequired = Settings.settings.numSnaredRabbitsRequired;
                }*/

                if (featsManager.GetFeat(FeatType.FireMaster))
                {
                    FeatsManager.m_Feat_FireMaster.m_DefaultFireStartingSkillLevel = Settings.settings.defaultFireStartingSkillLevel;
                    FeatsManager.m_Feat_FireMaster.m_NumFiresRequired = Settings.settings.numFiresRequired;
                }

                if (featsManager.GetFeat(FeatType.FreeRunner))
                {
                    FeatsManager.m_Feat_FreeRunner.m_NumKilometersRequired = Settings.settings.numKilometersRequired;
                    FeatsManager.m_Feat_FreeRunner.m_CalorieReductionBenefit = Settings.settings.calorieReductionBenefitFreeRunner;
                }

                /*if (featsManager.GetFeat(FeatType.SettledMind))
                {
                    FeatsManager.m_Feat_SettledMind.m_ReadSpeedBoostPercent = Settings.settings.readSpeedBoostPercent;
                }*/

                if (featsManager.GetFeat(FeatType.SnowWalker))
                {
                    FeatsManager.m_Feat_SnowWalker.m_NumKilometersRequired = Settings.settings.numKilometersRequiredSnowWalker;
                    FeatsManager.m_Feat_SnowWalker.m_StaminaRechargeFasterPercent = Settings.settings.staminaRechargeFasterPercent;
                }

                if (featsManager.GetFeat(FeatType.StraightToHeart))
                {
                    FeatsManager.m_Feat_StraightToHeart.m_ItemConsumedCountRequired = Settings.settings.itemConsumedCountRequired;
                    FeatsManager.m_Feat_StraightToHeart.m_EffectiveLengthIncreasePercent = Settings.settings.effectiveLengthIncreasePercent;
                }
            }
        }
    }
}
