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
        public static void DrawSquare(FoxDraw foxDraw, int x, int y, int size)
        {
            foxDraw.DrawRectangle(x, y, size, size);
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
			// Fill the canvas with a checkerboard pattern.

			foxDraw.SetFillColor(Colors.Violet);
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if ((row + column) % 2 == 0)
                        {
                        foxDraw.SetFillColor(Colors.Black);
                        }
                    else
                        {
                        foxDraw.SetFillColor(Colors.White);
                        }
                    DrawSquare(foxDraw, column * Convert.ToInt32(canvas.Height) / 8, row * Convert.ToInt32(canvas.Height) / 8, Convert.ToInt32(canvas.Height) / 8);
                }

                   
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}