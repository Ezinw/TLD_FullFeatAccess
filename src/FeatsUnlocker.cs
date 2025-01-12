using Il2Cpp;
using HarmonyLib;

namespace FullFeatAccess
{
    // Postfix patches for each feat
    [HarmonyPatch(typeof(Feat_BlizzardWalker), nameof(Feat_BlizzardWalker.IsUnlocked))]
    public class FeatBlizzardWalker
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_BookSmarts), nameof(Feat_BookSmarts.IsUnlocked))]
    public class FeatBookSmarts
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_ColdFusion), nameof(Feat_ColdFusion.IsUnlocked))]
    public class FeatColdFusion
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_EfficientMachine), nameof(Feat_EfficientMachine.IsUnlocked))]
    public class FeatEfficientMachine
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_ExpertTrapper), nameof(Feat_ExpertTrapper.IsUnlocked))]
    public class FeatExpertTrapper
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_FireMaster), nameof(Feat_FireMaster.IsUnlocked))]
    public class FeatFireMaster
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_FreeRunner), nameof(Feat_FreeRunner.IsUnlocked))]
    public class FeatFreeRunner
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_MasterHunter), nameof(Feat_MasterHunter.IsUnlocked))]
    public class FeatMasterHunter
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_SnowWalker), nameof(Feat_SnowWalker.IsUnlocked))]
    public class FeatSnowWalker
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }

    [HarmonyPatch(typeof(Feat_StraightToHeart), nameof(Feat_StraightToHeart.IsUnlocked))]
    public class FeatStraightToHeart
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                __result = true; // Unlock feat if setting is enabled
            }
        }
    }
}
