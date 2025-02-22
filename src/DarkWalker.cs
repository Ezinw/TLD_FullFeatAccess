using Il2Cpp;
using HarmonyLib;
using MelonLoader;
using Il2CppTLD.SaveState;


namespace FullFeatAccess
{
    // Unlock/Lock NightWalker feat & 'Escape the Dark Walker' challenge
    [HarmonyPatch(typeof(Feat_NightWalker), nameof(Feat_NightWalker.IsUnlocked))]
    public class FeatNightWalker
    {
        static void Postfix(Feat_NightWalker __instance, ref bool __result)
        {
            try
            {
                if (Settings.settings.unlockNightWalker)
                {
                    // Unlock the NightWalker feat
                    __result = true;

                    // Unlock Escape the Dark Walker challenge
                    if (!ProfileState.Instance.m_UnlockedBadges.Contains(BadgeInfoType.Badge_NowhereToHide2020Badge1))
                    {
                        ProfileState.Instance.AddUnlockedBadge(BadgeInfoType.Badge_NowhereToHide2020Badge1);
                    }
                }
                else
                {
                    // Lock the NightWalker feat
                    __result = false;

                    // Remove Escape the Dark Walker challenge badge
                    if (ProfileState.Instance.m_UnlockedBadges.Contains(BadgeInfoType.Badge_NowhereToHide2020Badge1))
                    {
                        ProfileState.Instance.RemoveUnlockedBadge(BadgeInfoType.Badge_NowhereToHide2020Badge1);
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Msg($"[FullFeatAccess] FeatNightWalker Error: {ex}");
            }
        }
    }
}
