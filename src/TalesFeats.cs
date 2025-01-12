using Il2Cpp;
using HarmonyLib;

namespace FullFeatAccess
{
    // Unlock Celestial Navigator & Settled Mind feats
    [HarmonyPatch(typeof(Feat_CelestialNavigator), nameof(Feat_CelestialNavigator.IsUnlocked))]
    public class FeatCelestialNavigator_SettledMind
    {
        static void Postfix(ref bool __result)
        {
            if (Settings.settings.unlockFeats)
            {
                // Unlock feat when the setting is true
                __result = true;
            }
            // If the setting is false, the original method's result remains unchanged
        }
    }
}


