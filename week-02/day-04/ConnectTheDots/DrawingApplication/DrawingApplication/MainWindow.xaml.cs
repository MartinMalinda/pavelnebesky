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
        public static void drawList(FoxDraw foxDraw, List<List<int>> listToDraw)
        {
            for (int i = 0; i < listToDraw.Count - 1; i++)
            {
                
                foxDraw.DrawLine(listToDraw[i][0], listToDraw[i][1], listToDraw[i + 1][0], listToDraw[i + 1][1]);
            }
            foxDraw.DrawLine(listToDraw[0][0], listToDraw[0][1], listToDraw[listToDraw.Count-1][0], listToDraw[listToDraw.Count-1][1]);
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

            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}


            List<List<int>> list1 = new List<List<int>>()
            {
                new List<int>() { 10, 10 },
                new List<int>() { 290, 10 },
                new List<int>() { 290, 290 },
                new List<int>() { 10, 290 }
            };

            List<List<int>> list2 = new List<List<int>>()
            {
                new List<int>() { 50, 100 },
                new List<int>() { 70, 70 },
                new List<int>() { 80, 90 },
                new List<int>() { 90, 90 },
                new List<int>() { 100, 70 },
                new List<int>() { 120, 100 },
                new List<int>() { 85, 130 },
                new List<int>() { 50, 100 }
            };

            drawList(foxDraw, list1);
            drawList(foxDraw, list2);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}