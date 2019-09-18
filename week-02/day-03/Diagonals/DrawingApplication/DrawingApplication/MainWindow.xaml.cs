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
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 800, 600);

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(800, 0, 0, 600);


        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}