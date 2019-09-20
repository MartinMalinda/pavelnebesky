using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            int border = 5;
            int widthWithoutBorder = Convert.ToInt32(Width) - 2*border;
            int heightWithoutBorder = Convert.ToInt32(Width) - 2*border;
           
            for (int i = 0; i < 14; i++)
            {
                foxDraw.SetStrokeColor(Colors.Violet);
                foxDraw.DrawLine(border + widthWithoutBorder * (i + 1) / 15, border, border + widthWithoutBorder, heightWithoutBorder * (i + 1) / 15);
                foxDraw.SetStrokeColor(Colors.Lime);
                foxDraw.DrawLine(border, border + heightWithoutBorder * (i + 1) / 15, widthWithoutBorder * (i + 1) / 15, border + heightWithoutBorder);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
