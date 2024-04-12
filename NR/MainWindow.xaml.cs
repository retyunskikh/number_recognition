using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace NR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyInkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
            MyInkCanvas.DefaultDrawingAttributes.Width = 1;
            MyInkCanvas.DefaultDrawingAttributes.Height = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var strokes = MyInkCanvas.Strokes;
        }
    }
}