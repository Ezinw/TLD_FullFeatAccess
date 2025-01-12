using MelonLoader;

namespace FullFeatAccess
{
    internal sealed class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        { 
            Settings.OnLoad();
        }
    }
}
