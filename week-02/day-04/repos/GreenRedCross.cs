using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);

            DrawGreenLines(foxDraw);
        }

        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 300, 600, 300);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(300, 0, 300, 600);
        }
    }
}