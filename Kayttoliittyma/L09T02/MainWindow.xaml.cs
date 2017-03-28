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

namespace L09T2
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

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInput.Text, "[^0-9,]"))
            {
                MessageBox.Show("Syota luku");
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1);
            }
        }

        private void chMarkka_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)chMarkka.IsChecked)
            {
                chEuro.IsChecked = false;
            }
        }

        private void chEuro_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)chEuro.IsChecked)
            {
                chMarkka.IsChecked = false;
            }
        }

        private void Laske_Click(object sender, RoutedEventArgs e)
        {
            double Euro = 5.945;
            double Markka = 0.168;
            double Value = 0;
            if (chMarkka.IsChecked == false && chEuro.IsChecked == false)
            {
                MessageBox.Show("valitse vaihtoehto");
            }
            else if ((bool)chMarkka.IsChecked)
            {
                double temp = 0;
                double.TryParse(txtInput.Text, out Value);
                temp = Value * Markka;
                txtOutput.Text = temp.ToString("0.00") + " euroa ";
            }
            else if ((bool)chEuro.IsChecked)
            {
                double temp = 0;
                double.TryParse(txtInput.Text, out Value);
                temp = Value * Euro;
                txtOutput.Text = temp.ToString("0.00") + " Markkaa ";
            }

        }
    }
}
