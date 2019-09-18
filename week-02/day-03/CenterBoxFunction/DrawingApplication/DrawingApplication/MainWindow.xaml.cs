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



        public static void DrawSquare(FoxDraw foxDraw, int size)
        {

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

            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            List<Color> colorsOfRectangles = new List<Color>
            {Colors.Blue, Colors.Red, Colors.Green};

            for (int i = 0; i < 3; i++)
            {
                foxDraw.SetFillColor(colorsOfRectangles[i]);
                DrawSquare(foxDraw, 100 - 20 * i);
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}