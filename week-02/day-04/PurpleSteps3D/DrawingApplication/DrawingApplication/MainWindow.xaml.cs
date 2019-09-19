using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public static void DrawSquare(FoxDraw foxDraw, int position, int size)
        {
            foxDraw.DrawRectangle(position, position, size, size);
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

            foxDraw.SetFillColor(Colors.Violet);
            int move = 0;
            for (int i = 0; i < 6; i++)
            {
                
                    DrawSquare(foxDraw, (i * 10) + 10 + move, (i+1) * 10);
                    move += i * 10;



            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}