using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System.Collections.Generic;
using System;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public void DrawHexagon(FoxDraw foxDraw, int x, int y, int baseSize)
        {
            foxDraw.DrawLine(x, y, x + baseSize, y);
            foxDraw.DrawLine(x + baseSize, y, x + baseSize * 3 / 2, y + baseSize);
            foxDraw.DrawLine(x + baseSize * 3 / 2, y + baseSize, x + baseSize, y + 2 * baseSize);
            foxDraw.DrawLine(x + baseSize, y + 2 * baseSize, x , y + 2 * baseSize);
            foxDraw.DrawLine(x, y + 2 * baseSize, x - baseSize/2, y + baseSize);
            foxDraw.DrawLine(x - baseSize / 2, y + baseSize , x, y);
        }

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            //here

            int hexagonBase = 20;
            int positionFromTop = 100;
            int hexagonX = Convert.ToInt32(Width) / 2 - hexagonBase / 2;
            int hexagonY = positionFromTop;
            int hexagonsCount = 0;
   
            foxDraw.SetFillColor(Colors.White);
      
            for (int row = 0; row < 14; row++)
            {
                if (row < 4)
                {
                    hexagonsCount++;
                }
                else if (row >= 4 && row <= 10)

                {
                    if (row % 2 == 0)
                    {
                        hexagonsCount--;
                        hexagonX += 3 * hexagonBase;
                    }
                    else
                    {
                            hexagonsCount++;
                    }
                 }

                else 
                {
                    hexagonsCount--;
                    hexagonX += 3 * hexagonBase;
                }
                for (int hexagonNo = 0; hexagonNo < hexagonsCount; hexagonNo++)
                {
                    DrawHexagon(foxDraw, hexagonX, hexagonY, hexagonBase);
                    hexagonX += hexagonBase * 3;
                }
                hexagonX = Convert.ToInt32(Width) / 2 - hexagonBase/2 - (hexagonBase*(hexagonsCount))*3/2;
                hexagonY += hexagonBase;
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
