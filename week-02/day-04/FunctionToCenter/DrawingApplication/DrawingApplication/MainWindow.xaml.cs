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
        public void DrawLineToCenter(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, Width / 2, Height / 2);
        }

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            //canvas.Width = 800;
            //canvas.Height = 600;
            //here
            //foxDraw.DrawLine(50, 50, 100, 100);
            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            int x = 0;
            do
            {
                DrawLineToCenter(foxDraw, x, 0);
                DrawLineToCenter(foxDraw, x, Convert.ToInt32(Height));
                x += 20;
            } while (x != Convert.ToInt32(Width)+20);

            x = 0;
            do
            {
                DrawLineToCenter(foxDraw, 0, x);
                DrawLineToCenter(foxDraw, Convert.ToInt32(Width), x);
                x += 20;
            } while (x != Convert.ToInt32(Height) + 20);



        }

		private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}