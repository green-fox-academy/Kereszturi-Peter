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
using LinePlay;

namespace LinePlay
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            TopRightPurpleLines(foxDraw);
            BottomLeftGreenLines(foxDraw);
        }

        public void TopRightPurpleLines(FoxDraw purpleLines)
        {
            double x = 0;
            double y = 25;

            for (int i = 0; i < canvas.Width / 25; i++)
            {
                purpleLines.StrokeColor(Colors.Purple);
                purpleLines.DrawLine(x, 0, canvas.Height, y);
                x += 25;
                y += 25;
            }
        }

        public void BottomLeftGreenLines(FoxDraw greenLines)
        {
            double x = 0;
            double y = 25;

            for (int i = 0; i < canvas.Width / 25; i++)
            {
                greenLines.StrokeColor(Colors.Green);
                greenLines.DrawLine(0, x, y, canvas.Height);
                x += 25;
                y += 25;
            }
        }
    }
}
