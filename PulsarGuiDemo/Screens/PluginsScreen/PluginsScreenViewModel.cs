using Keen.VRage.UI.Screens;

namespace PulsarGuiDemo.Screens.PluginsScreen
{
    internal class PluginsScreenViewModel : ScreenViewModel
    {
        public PluginsScreenViewModel() 
        {
            KeepsOtherScreensVisible = false;
            AllowsInputBelowUI = false;
            AllowsInputFromLowerScreens = false;
            InitializeInputContext();
        }
    }
}
