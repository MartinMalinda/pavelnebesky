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
            canvas.Width = 800;
            canvas.Height = 800;


            //foxDraw.DrawLine(50, 50, 100, 100);

            Sierpinski(foxDraw, 50, 600, 700, 5);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public static void DrawTriangle(FoxDraw foxDraw, double xPosition, double yPosition, double sideSize)
        {
            foxDraw.DrawLine(xPosition, yPosition, xPosition+sideSize, yPosition);
            foxDraw.DrawLine(xPosition + sideSize, yPosition, xPosition + (sideSize / 2), yPosition - sideSize*Math.Sqrt(2)/2);
            foxDraw.DrawLine(xPosition + (sideSize / 2), yPosition - sideSize * Math.Sqrt(2) / 2, xPosition, yPosition);
        }

        public static void Sierpinski(FoxDraw foxDraw, double xPosition, double yPosition, double sideSize, int depth)
        {
            if (depth==0)
            {
                DrawTriangle(foxDraw, xPosition, yPosition, sideSize);
            }
            else
            {
                Sierpinski(foxDraw, xPosition, yPosition, sideSize / 2, depth-1);
                Sierpinski(foxDraw, xPosition + sideSize/2 , yPosition, sideSize / 2, depth - 1);
                Sierpinski(foxDraw, xPosition + sideSize / 4, yPosition - sideSize * Math.Sqrt(2) / 4, sideSize / 2, depth - 1);
            }
            
        }
    }
}