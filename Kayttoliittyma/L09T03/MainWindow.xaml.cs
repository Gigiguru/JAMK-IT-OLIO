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

namespace WpfApplication2
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtKarmi.Text, "[^0-9,]"))
            {
                MessageBox.Show("Syota luku");
                txtKarmi.Text = txtKarmi.Text.Remove(txtKarmi.Text.Length - 1);
            }

        }

        private void txtH_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtH.Text, "[^0-9,]"))
            {
                MessageBox.Show("Syota luku");
                txtH.Text = txtH.Text.Remove(txtH.Text.Length - 1);

            }
        }

        private void txtL_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtL.Text, "[^0-9,]"))
            {
                MessageBox.Show("Syota luku");
                txtL.Text = txtL.Text.Remove(txtL.Text.Length - 1);
            }
        }
        private double Ikkunanpintaala()
        {

            double L, H = 0;
            double.TryParse(txtL.Text, out L);
            double.TryParse(txtH.Text, out H);
            return L * H;
        }
        private double Lasinpintaala()
        {

            double L, H, K = 0;
            double.TryParse(txtL.Text, out L);
            double.TryParse(txtH.Text, out H);
            double.TryParse(txtKarmi.Text, out K);
            return (L - (2 * K)) * (H - (2 * K));
        }
        private double Karminpiiri()
        {

            double L, H, Value = 0;
            double.TryParse(txtL.Text, out L);
            double.TryParse(txtH.Text, out H);
            Value = (((L * 2) + (H * 2)) / 10);
            return Value;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtBIA.Text = Ikkunanpintaala().ToString() + "CM^2";
            txtBLA.Text = Lasinpintaala().ToString() + "CM^2";
            txtKP.Text = Karminpiiri().ToString() + " CM";
        }
    }
}
