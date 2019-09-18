using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System.Collections.Generic;

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
            canvas.Width = 800;
            canvas.Height = 600;

            //here
            //foxDraw.DrawLine(50, 50, 100, 100);
            // draw four different size and color rectangles.
            // avoid code duplication.

            List<Color> colorsOfRectangles = new List<Color>
            { Colors.Black, Colors.Blue, Colors.Red, Colors.Green};

            for (int i = 0; i < 4; i++)
            {
                foxDraw.SetFillColor(colorsOfRectangles[i]);
                foxDraw.DrawRectangle(10+100*i, 10+50*i, 50+10*i, 100-10*i);
            }
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}