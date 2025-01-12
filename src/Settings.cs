using ModSettings;

namespace FullFeatAccess
{
    internal class Settings : JsonModSettings
    {
        [Name("Max Feats")]
        [Description("Enable access to 5 feats in every game mode or use TLD default values. (Does not apply to challenge mode)")]
        [Choice("Default", "Max")]
        public bool maxFeatsAllowed = false;

        [Name("Unlock All Feats?")]
        [Description("Unlock or lock all feats. (Locking will still allow you to earn feats normally, as TLD intended)")]
        [Choice("No", "Yes")]
        public bool unlockFeats = false;

        [Section(" ")]

        [Name("Enable DarkWalker Feat?")]
        [Description("Enabling the DarkWalker feat will also auto-complete the 'Escape The DarkWalker' challenge to prevent odd behavior.")]
        [Choice("No", "Yes")]
        public bool unlockNightWalker = false;

        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("FullFeatAccess");
        }
    }
}
