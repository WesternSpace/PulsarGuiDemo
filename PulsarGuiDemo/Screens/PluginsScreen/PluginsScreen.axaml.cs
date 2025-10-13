using Avalonia.Interactivity;
using Keen.Game2;
using Keen.Game2.Client.UI.Library.Dialogs.ThreeOptionsDialog;
using Keen.VRage.Core;
using Keen.VRage.Library.Utils;
using Keen.VRage.UI.AvaloniaInterface.Services;
using Keen.VRage.UI.Screens;

namespace PulsarGuiDemo.Screens.PluginsScreen;

[NeedsWindowStyles]
public partial class PluginsScreen : ScreenView
{
    public PluginsScreen()
    {
        InitializeComponent();
    }

    private void CancelButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Dispose();
    }

    private void ApplyButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if ((DataContext as PluginsScreenViewModel).RequiresRestart())
        {
            // Probably should have a wrapper class for the Dialogs
            var definition = Util.GetDefaultYesNoCancelDialog();
            definition.Title = Util.GetKeyFromString("Apply Changes?");
            definition.Content = Util.GetKeyFromString("A restart is required to apply changes. Would you like to restart the game now?");

            Singleton<VRageCore>.Instance.Engine.Get<GameAppComponent>().MainMenu._sharedUI.ShowDialog(new ThreeOptionsDialogViewModel(definition)
            {
                ConfirmAction = () =>
                {
                    (DataContext as PluginsScreenViewModel).Save();
                    //LoaderTools.AskToRestart();
                },
                DefaultAction = () => 
                {
                    (DataContext as PluginsScreenViewModel).Save();
                    Dispose();
                }
            });
        }
        else
        {
            Dispose();
        }
    }
}