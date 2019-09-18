using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
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

            //here
            // Draw a box that has different colored lines on each edge.

            var dict = new Dictionary<Color, List<int>>()
            {
                { Colors.BurlyWood, new List<int> () { 150, 50, 250, 50}},
                { Colors.Green, new List<int> () { 250, 50, 250, 150} },
                { Colors.Blue, new List<int> () { 250, 150, 150, 150} },
                { Colors.Violet, new List<int> () { 150, 150, 150, 50} },
                { Colors.LimeGreen, new List<int> () { 150, 50, 100, 100} },
                { Colors.Brown, new List<int> () { 250, 50, 200, 100} },
                { Colors.RosyBrown, new List<int> () { 250, 150, 200, 200} },
                { Colors.RoyalBlue, new List<int> () { 150, 150, 100, 200} },
                { Colors.Pink, new List<int> () { 100, 100, 200, 100} },
                { Colors.DarkCyan, new List<int> () { 200, 100, 200, 200} },
                { Colors.DarkGoldenrod, new List<int> () { 200, 200, 100, 200} },
                { Colors.DarkBlue, new List<int> () { 100, 200, 100, 100} }


            };


            foreach (var item in dict)
            {

                foxDraw.SetStrokeColor(item.Key);
                
                foxDraw.DrawLine(item.Value[0], item.Value[1], item.Value[2], item.Value[3]);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}