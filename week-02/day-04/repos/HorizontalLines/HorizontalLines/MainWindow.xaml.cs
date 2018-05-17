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
using HorizontalLines;

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            HorizontalLines(foxDraw);
        }

        public static void HorizontalLines(FoxDraw foxDraw)
        {
            int[] x = { 10, 70, 257};
            int[] y = { 430, 600, 12 };

            for (int i = 0; i < 3; i++)
            {
                foxDraw.StrokeColor(Colors.DarkCyan);
                foxDraw.DrawLine(x[i], y[i], x[i] + 50, y[i]);
            }
        }
    }
}
