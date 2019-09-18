using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

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
            //foxDraw.DrawLine(50, 50, 100, 100);
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 300, 400, 300);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(400, 0, 400, 300);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}