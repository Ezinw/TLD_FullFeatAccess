using Il2Cpp;
using HarmonyLib;

namespace FullFeatAccess
{
    // Unlock Celestial Navigator & Settled Mind feats
    [HarmonyPatch(typeof(Feat_SettledMind), nameof(Feat_SettledMind.IsUnlocked))]
    public class FeatCelestialNavigator_SettledMind
    {
        static void Postfix(Feat_SettledMind __instance, ref bool __result)
        {
            if (Settings.settings.unlockTalesFeats)
            {
                __result = true;
            }
        }
    }
}
