using Avalonia.Controls;
using HarmonyLib;
using Keen.Game2.Client.UI.Library;
using Keen.Game2.Client.UI.Menu;
using Keen.VRage.Core;
using Keen.VRage.Library.Reflection.DependencyInjections;
using Keen.VRage.Library.Utils;
using Keen.VRage.UI.Shared.Helpers;
using Keen.VRage.DCS.Components;
using PulsarGuiDemo.Screens;
using System.Linq;

namespace PulsarGuiDemo.Patches
{
    [HarmonyPatch(typeof(GameMenu), "UpdateButtons")]
    internal class GameMenu_UpdateButtons_Patch
    {
        private static void Postfix(ref StackPanel? ____buttonsPanel)
        {
            if (____buttonsPanel == null)
            {
                return;
            }

            Button pluginsButton = new()
            {
                Classes = { "Menu" },
                Content = "Plugins",
                Command = SimpleCommand.Create(() => Singleton<VRageCore>.Instance.Engine.Get<SharedUIComponent>().CreateScreen<PluginsScreen>(new PluginsScreenViewModel(), true))
            };

            ____buttonsPanel.Children.Insert(____buttonsPanel.Children.Count - 2, pluginsButton);
        }
    }
}
