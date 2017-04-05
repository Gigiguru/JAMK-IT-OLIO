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

namespace L11Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Animal elukka;
        public MainWindow()
        {
            InitializeComponent();
            //omat alustukset
            elukka = new Animal();
            elukka.Name = "Musti";
            elukka.Happiness = 10;
            MyProgressBar.DataContext = elukka;
            tbAnimal.DataContext = elukka;
        }
       
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Animal olio = (Animal)MyProgressBar.DataContext;
            if (olio.Happiness > 100)
            {
                MessageBox.Show("full");
            }
            else
            {
                //ToDO lisätään olion Happiness Ominaisuutta
                olio.Happiness++;
                
            }
           
            
         
        }


        private void btnCreate(object sender, RoutedEventArgs e)
        {
            Animal kissa = new Animal();
            kissa.Name = "Karvapallo";
            kissa.Happiness = 50;
            MyProgressBar.DataContext = kissa;
            tbAnimal.DataContext = kissa;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Animal olio = (Animal)MyProgressBar.DataContext;
            for (int i = 0; i < 100; i++)
            {
                olio.Happiness++;
            }
        }
    }
}
