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

namespace WpfApplication5
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
        string msg = "";
        private void Custom(object sender, RoutedEventArgs e)
        {

            msg += (((Button)sender).Content).ToString();
            textBlock.Text = msg;
        }

        private void OKCLICK(object sender, RoutedEventArgs e)
        {
            double X = 0;
            double.TryParse(msg, out X);
            if (rdTemp.IsChecked == true)
            {
                double Value = 0;
                Double.TryParse(msg, out Value);
                if (Value >= 120 || Value <= 0)
                {
                    MessageBox.Show("vihree");
                }
                else
                {
                    txtTemp.Text = msg;
                }
            }
            else if (rdHum.IsChecked == true)
            {
                double Value = 0;
                Double.TryParse(msg, out Value);
                if (Value >= 100 || Value <= 0)
                {
                    MessageBox.Show("vihree");
                }
                else
                {
                    txtHum.Text = msg;
                }

            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            msg = msg.Remove(msg.Length - 1);
            textBlock.Text = msg;
        }


    }
}
