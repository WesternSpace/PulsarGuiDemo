using Avalonia;
using Avalonia.Markup.Xaml;

namespace ViewerApp
{
    internal class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
