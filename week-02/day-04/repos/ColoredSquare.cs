using System.Windows;
using System.Windows.Media;

namespace GreenFox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);

            DrawColoredSquare(foxDraw);
        }

        public static void DrawColoredSquare(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(200, 200, 400, 200, 5);

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(200, 400, 400, 400, 5);

            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(200, 200, 200, 400, 5);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(400, 200, 400, 400, 5);

        }
    }
}