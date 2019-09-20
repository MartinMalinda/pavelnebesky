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
        public void DrawTriangle(FoxDraw foxDraw, int[,] arr)
        {
            for (int i = 0; i < 2; i++)
            {
                foxDraw.DrawLine(arr[i, 0], arr[i, 1], arr[i+1, 0], arr[i+1, 1]);
            }
            foxDraw.DrawLine(arr[0, 0], arr[0, 1], arr[2, 0], arr[2, 1]);
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

            int triangleBase = 20;
            int triangleHeight = 17;
            int positionFromTop = 100;
           
            int[,] trianglePoints = new int[3, 2];
            trianglePoints[0, 0] = Convert.ToInt32(Width/2 - triangleBase/2);
            trianglePoints[0, 1] = triangleHeight+positionFromTop;
            trianglePoints[1, 0] = Convert.ToInt32(Width / 2 + triangleBase / 2);
            trianglePoints[1, 1] = triangleHeight+positionFromTop;
            trianglePoints[2, 0] = Convert.ToInt32(Width / 2);
            trianglePoints[2, 1] = 0+positionFromTop;


            foxDraw.SetFillColor(Colors.White);
            DrawTriangle(foxDraw, trianglePoints);


            for (int row = 1; row < 22; row++)
            {
                for (int trianglleNum = 0; trianglleNum < row; trianglleNum++)
                {
                    DrawTriangle(foxDraw, trianglePoints);
                    for (int i = 0; i < 3; i++)
                    {
                        trianglePoints[i, 0] += triangleBase;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    trianglePoints[i, 0] -= row*triangleBase + triangleBase/2;
                }
                for (int i = 0; i < 3; i++)
                {
                    trianglePoints[i, 1] += triangleHeight;
                }
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
