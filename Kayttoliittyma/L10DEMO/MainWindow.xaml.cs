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

namespace L10DEMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeMyStuff();
        }
        private void InitializeMyStuff()
        {
            //kootan tähän metodiin kaiikki kontrllin alustukset
            //lisätään Comboboxiin item
            cbCombo.Items.Add("");
            cbCombo.Items.Add("Aku ankka");
            cbCombo.Items.Add("Urheilusanomat");
            cbCombo.Items.Add("Sudoku");
            cbCombo.Items.Add("V8 Magazine");

        }
        //ve1 kontrolli kerrallaan
        private string Checkkaus() {
            string msg = "";
            if ((bool)chkBanana.IsChecked)
            {
                msg += "Banana,";
            }
            if ((bool)chkBread.IsChecked)
            {
                msg += "Bread,";
            }
            if ((bool)chkBeer.IsChecked)
            {
                msg += "Beer,";
            }
            if ((bool)chkChicken.IsChecked)
            {
                msg += "Chicken,";
            }
            return msg; }
        private string CheckkausKaikki() //parempi metodi Ve2
        {
            string msg = "";
            foreach (object Control in spList.Children)
            {
                if (Control is CheckBox)
                {
                    CheckBox cb = (CheckBox)Control;
                    if ((bool)cb.IsChecked)
                    {
                        msg += cb.Content + "\n";
                    }
                }
               
            }
            //tutkitaan onko valittu joko lehti
            if (cbCombo.SelectedIndex > 0)
                msg += cbCombo.SelectedValue;
            else
                msg += "Ei vilkuilla hyllyä";
            return msg;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = CheckkausKaikki();
            //tutkitaan mita kontrollereja 
         //   string msg = "";
            //Kontrolli kerrrallaan
            //ve1 kontrolli kerrallaan
         //   if ((bool)chkBanana.IsChecked)
         //   {
         //       msg += "Banana,";
          //  }
          //  if ((bool)chkBread.IsChecked)
          //  {
          //      msg += "Bread,";
          //  }
            //Ve2 käydään kaikki lapi
            //ostokset näkyviin
          //  textBox.Text = msg.ToString();

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CheckkausKaikki());
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            //kutsutaan näkyviin about Ikkuna
            about Win = new about();
            //kaksi eri metodia näyttäää modaalinen ja ei modaalinen
            //modaalinen Win.Show(); 
            Win.ShowDialog();

        }
    }
}
