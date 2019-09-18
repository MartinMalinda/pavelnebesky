﻿using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;

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
            // Draw a green 10x10 square to the canvas' center.

            foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawRectangle(canvas.Width/2 - 5, canvas.Height/2 - 5, 10, 10);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}