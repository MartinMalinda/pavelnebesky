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



        public static void DrawSquare(FoxDraw foxDraw, Color color, int size)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(800 / 2 - 0.5 * size, 600 / 2 - 0.5 * size, size, size);
        }

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

            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            List<Color> colorsOfSquares = new List<Color>
            {Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet};

            for (int i = 0; i < colorsOfSquares.Count; i++)
            {
                
                DrawSquare(foxDraw, colorsOfSquares[i], 600 - (600/colorsOfSquares.Count) * i);
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}