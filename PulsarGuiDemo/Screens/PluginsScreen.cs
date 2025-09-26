using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Media;
using Avalonia.Platform;
using Keen.VRage.UI.AvaloniaInterface.Services;
using Keen.VRage.UI.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsarGuiDemo.Screens
{
    [NeedsWindowStyles]
    internal class PluginsScreen : ScreenView
    {
        public PluginsScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Canvas canvas = new Canvas();
            canvas.Height = Height;
            canvas.Width = Width;
            canvas.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
            canvas.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;

            TextBlock textBlock = new TextBlock();
            textBlock.Height = 100;
            textBlock.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            textBlock.FontSize = 25;
            textBlock.TextAlignment = TextAlignment.Left;
            textBlock.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
            textBlock.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Text = "Test";
            canvas.Children.Add(textBlock);
            Content = canvas;
        }
    }
}
