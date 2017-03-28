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

namespace L09T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int laskuriC = 0;
        private int laskuriT = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {

            laskuriC++;
            txtCars.Text = laskuriC.ToString();
        }

        private void btnTrucks_Click(object sender, RoutedEventArgs e)
        {
            laskuriT++;
            txtTrucks.Text = laskuriT.ToString();

        }
    }
}
