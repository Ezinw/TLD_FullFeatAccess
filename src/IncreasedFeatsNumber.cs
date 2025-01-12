using Il2Cpp;
using HarmonyLib;
using MelonLoader;

namespace FullFeatAccess
{
    [HarmonyPatch(typeof(Panel_MainMenu), nameof(Panel_MainMenu.GetNumFeatsForXPMode))]
    public class SetMaxNumFeats
    {
        static void Postfix(ref int __result)
        {
            try
            {
                if (Settings.settings.maxFeatsAllowed)
                {
                    // Override the result to set the max number of feats to 5
                    __result = 5;
                }
                // If maxFeatsAllowed is false, leave __result unchanged to preserve the original behavior
            }
            catch (Exception ex)
            {
                MelonLogger.Msg($"SetMaxNumFeats Error: {ex}");
            }
        }
    }
}
