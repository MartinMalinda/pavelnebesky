using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;

namespace DrawingApplication
{
    public class MainWindow : Window
    {

        public static void DrawSingleLine(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, x+50, y);
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
			//foxDraw.DrawLine(50, 50, 100, 100);

			// Create a function that draws a single line and takes 3 parameters:
			// The x and y coordinates of the line's starting point and the foxDraw
			// and draws a 50 long horizontal line from that point.
			// Draw at least 3 lines with that function using a loop.

			for (int i = 0; i < 200; i+=20)
            {
                DrawSingleLine(foxDraw, i*2, i);
            }
            

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}