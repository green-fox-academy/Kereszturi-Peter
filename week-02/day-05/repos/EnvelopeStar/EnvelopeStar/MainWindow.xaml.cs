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
using EnvelopeStar;

namespace EnvelopeStar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            TopRightCorner(foxDraw);
        }

        public static void TopRightCorner(FoxDraw topRight)
        {
            double pointOne = 0;
            double pointTwo = 25;

            for (int i = 0; i < topRight.Canvas.Width / 25; i++)
            {
                topRight.StrokeColor(Colors.Green);
                topRight.DrawLine(pointOne, topRight.Canvas.Width / 2, topRight.Canvas.Height / 2, pointOne);

                pointOne += 25;
                pointTwo += 25;
            }
        }
    }
}
