using Il2Cpp;
using HarmonyLib;

namespace FullFeatAccess
{
    [HarmonyPatch(typeof(Panel_MainMenu), nameof(Panel_MainMenu.GetNumFeatsForXPMode))]
    public class SetMaxNumFeats
    {
        static void Postfix(ref int __result)
        {
            if (Settings.settings.maxFeatsAllowed)
            {
                __result = 5;
            }
        }
    }
}

