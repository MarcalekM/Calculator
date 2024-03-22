using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void No0_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No0.Content.ToString();
        }

        private void No1_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No1.Content.ToString();
        }

        private void No2_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No2.Content.ToString();
        }

        private void No3_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No3.Content.ToString();
        }

        private void No4_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No4.Content.ToString();
        }

        private void No5_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No5.Content.ToString();
        }

        private void No6_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No6.Content.ToString();
        }

        private void No7_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No7.Content.ToString();
        }

        private void No8_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No8.Content.ToString();
        }

        private void No9_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content += No9.Content.ToString();
        }
    }
}