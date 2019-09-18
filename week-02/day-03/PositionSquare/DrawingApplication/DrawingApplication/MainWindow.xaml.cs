using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;

namespace DrawingApplication
{
    public class MainWindow : Window
    {

        public static void DrawSquare(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawRectangle(x, y, 50, 50);
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
            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            for (int i = 0; i < 3; i++)
            {
                DrawSquare(foxDraw, 10+150 * i, 10+100 * i);
            }

        }

        

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}