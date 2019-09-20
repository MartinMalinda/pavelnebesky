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
            int widthWithoutBorder = Convert.ToInt32(Width) - 2 * border;
            int heightWithoutBorder = Convert.ToInt32(Width) - 2 * border;
            int moveX = 0;
            int moveY = 0;


            Console.WriteLine("Divide the canvas into 4 / 16 / 64 equal parts? (You can even try a diferent square number) ");
            int numberOfParts = Convert.ToInt32(Console.ReadLine());
            int sqrtnumberOfParts = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(numberOfParts)));

            widthWithoutBorder /= sqrtnumberOfParts;
            heightWithoutBorder /= sqrtnumberOfParts;

            for (int row = 0; row < sqrtnumberOfParts; row++)
            {               
                for (int column = 0;  column < sqrtnumberOfParts; column++)
                {               
                    for (int i = 0; i < 14; i++)
                    {
                        foxDraw.SetStrokeColor(Colors.Violet);
                        foxDraw.DrawLine(moveX + border + widthWithoutBorder * (i + 1) / 15, moveY + border, moveX + border + widthWithoutBorder, moveY + heightWithoutBorder * (i + 1) / 15);
                        foxDraw.SetStrokeColor(Colors.Lime);
                        foxDraw.DrawLine(moveX + border, moveY + border + heightWithoutBorder * (i + 1) / 15, moveX + widthWithoutBorder * (i + 1) / 15, moveY + border + heightWithoutBorder);
                    }
                    moveX += widthWithoutBorder;
                }
                moveX = 0;
                moveY += heightWithoutBorder;
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
