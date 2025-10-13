using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using HarmonyLib;
using Keen.Game2.Game.Plugins;
using Keen.VRage.Library.Diagnostics;
using Keen.VRage.UI.AvaloniaInterface;
using System.Reflection;

namespace PulsarGuiDemo
{
    public class Plugin : IPlugin, IDisposable
    {
        public const string Name = "PulsarGuiDemo";

        public Plugin()
        {
            Log.Default.WriteLine($"[{Name}] Loaded plugin.");
#if DEBUG
            Harmony.DEBUG = true;
#endif
            Harmony harmony = new Harmony(Name);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Log.Default.WriteLine($"[{Name}] Applied patches");
        }

        public void Dispose()
        {
            
        }
    }
}
