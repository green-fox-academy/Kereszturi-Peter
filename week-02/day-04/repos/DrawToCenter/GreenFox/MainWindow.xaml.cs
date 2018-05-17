using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace GreenFox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawToCenter(foxDraw);
        }

        public static void DrawToCenter(FoxDraw foxDraw)
        {
            int[] x = { 543, 12, 150 };
            int[] y = { 71, 57, 0 };
            for (int i = 0; i < 3; i++)
            {
                var startPoint = new Point(x[i], y[i]);
                var endPoint = new Point(300, 300);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
    }
}
