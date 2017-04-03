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
        class Kiuas {
            double temp, hum = 0;
            string mgs = "";
            public string MSG { get { return mgs; } }
            public double Temp { get { return temp; } }
            public double Hum { get { return hum; } }
            public void TempCheck(double X)
            {
                mgs = "";
                if (X >= 0 && X <= 120)
                {
                    temp = X;
                    
                }
                else
                {
                    mgs = "Arvo ei kelpaa";
                }
                           
            }
            public void HumCheck(double X)
            {
                mgs = "";
                if (X >= 0 && X <= 100)
                {
                    hum = X;

                }
                else
                {
                    mgs = "Arvo ei kelpaa";
                }
            }

        }
        Kiuas kiuas = new Kiuas();
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
                
                kiuas.TempCheck(X);
                txtTemp.Text = kiuas.Temp.ToString();
            }
            else if (rdHum.IsChecked == true)
            {
                kiuas.HumCheck(X);
                txtHum.Text = kiuas.Hum.ToString();          
            }
            txtError.Text = kiuas.MSG;


        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (msg == "")
            {
                txtError.Text = "Tyhja";
            }
            else
            {
                msg = msg.Remove(msg.Length - 1);
                textBlock.Text = msg;
            }
           
        }


    }
}
