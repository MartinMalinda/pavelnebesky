using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System;
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
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            foxDraw.SetBackgroundColor(Colors.Black);

            int randomX = 0;
            int randomY = 0;
            int randomColorIndex = 0;
            int starSize = 5;

            var listOfGreyColors = new List<Color>()
                {   Colors.DarkGray,
                    Colors.DarkSlateGray,
                    Colors.DimGray,
                    Colors.Gray,
                    Colors.LightGray,
                    Colors.LightSlateGray,
                    Colors.SlateGray
                };

            var random = new Random();

            for (int i = 0; i < 2000; i++)
            {
                randomX = random.Next(Convert.ToInt32(Width)-starSize);
                randomY = random.Next(Convert.ToInt32(Height)-starSize);
                randomColorIndex = random.Next(listOfGreyColors.Count-1);
                foxDraw.SetFillColor(listOfGreyColors[randomColorIndex]);
                foxDraw.DrawRectangle(randomX, randomY, starSize, starSize);
            }
            


        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}