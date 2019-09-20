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
            int heightWithoutBorder = Convert.ToInt32(Height) - 2*border;
          
            for (int i = 0; i < 15; i++)
            {
                foxDraw.SetStrokeColor(Colors.LightGreen);
                //up left
                foxDraw.DrawLine(border + widthWithoutBorder/2 * (i + 1) / 15, Convert.ToInt32(Height) / 2, Convert.ToInt32(Width) / 2, Convert.ToInt32(Height)/2 - heightWithoutBorder / 2 * (i + 1) / 15);
                //down left
                foxDraw.DrawLine(border + widthWithoutBorder / 2 * (i + 1) / 15, Convert.ToInt32(Height) / 2, Convert.ToInt32(Width) / 2, Convert.ToInt32(Height) / 2 + heightWithoutBorder / 2 * (i + 1) / 15);
                //up right
                foxDraw.DrawLine(Convert.ToInt32(Width) - border - widthWithoutBorder / 2 * (i + 1) / 15, Convert.ToInt32(Height) / 2, Convert.ToInt32(Width) / 2, Convert.ToInt32(Height) / 2 - heightWithoutBorder / 2 * (i + 1) / 15);
                //down right
                foxDraw.DrawLine(Convert.ToInt32(Width) - border - widthWithoutBorder / 2 * (i + 1) / 15, Convert.ToInt32(Height) / 2, Convert.ToInt32(Width) / 2, Convert.ToInt32(Height) / 2 + heightWithoutBorder / 2 * (i + 1) / 15);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}