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

namespace WpfApplication3
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

            cbCombo.Items.Add("Lotto");
            cbCombo.Items.Add("VikingLotto");
            cbCombo.Items.Add("EuroJackpot");

        }
        class Game
        {

            public string Name { get; set; }
            private Random rnd = new Random();
            public int RNDL() { return rnd.Next(1, 39); }
            public int RNDV() { return rnd.Next(1, 48); }
            public int RNDE() { return rnd.Next(1, 50); }

            public string Lotto()
            {
                string X = "";
                string A = "";

                for (int y = 0; y < 7; y++)
                {
                    X += RNDL() + " ";
                }
                X += "\n";

                return A += X;

            }
            public string VikingLotto()
            {
                string X = "";
                string A = "";

                for (int y = 0; y < 6; y++)
                {
                    X += RNDV() + " ";
                }
                X += "\n";

                return A += X;

            }
            public string Ej()
            {
                string X = "";
                string A = "";

                for (int y = 0; y < 5; y++)
                {
                    X += RNDV() + " ";
                }
                X += " tähtinumerot ";
                for (int y = 0; y < 2; y++)
                {
                    X += RNDE() + " ";
                }
                X += "\n";

                return A += X;

            }
        }
        class X
        {
            private List<string> game { get; }
            public string Name { get; set; }
            public X()
            {
                game = new List<string>();
            }
            public void Add(string item)
            {

                game.Add(item);
            }
            //public void Delete()
            //    {
            //    game.RemoveAt(game.Count - 1);

            //    }
            public void Clear()
            {
                game.Clear();
            }
            public override string ToString()
            {
                string y = "";
                int Row = 1;
                foreach (string item in game)
                {
                    y += "Row " + Row + ": " + item;
                    Row++;
                }
                return y;
            }

        }
        Game Temp = new Game();
        X value = new X();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int X = 0;
            Int32.TryParse(txtBox.Text, out X);


            if (cbCombo.SelectedValue == null)
            {
                MessageBox.Show("Valitse peli");
                return;
            }
            if (cbCombo.SelectedValue.ToString() == "Lotto")
            {

                for (int i = 0; i < X; i++)
                {
                    value.Add(Temp.Lotto());
                }
            }
            else if (cbCombo.SelectedValue.ToString() == "VikingLotto")
            {

                for (int i = 0; i < X; i++)
                {
                    value.Add(Temp.VikingLotto());
                }
            }
            else if (cbCombo.SelectedValue.ToString() == "EuroJackpot")
            {

                for (int i = 0; i < X; i++)
                {
                    value.Add(Temp.Ej());
                }
            }

            textBlock.Text = value.ToString(); ;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (value.ToString() == "")
            {
                MessageBox.Show("Lista on tyhja");uioiuo
            }
            else
            {
                value.Clear();
            }
            textBlock.Text = value.ToString();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBox.Text, "[^0-9,]"))
            {
                MessageBox.Show("Syota luku");
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1);
            }
        }

        private void cbCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCombo.SelectedIndex > 0)
            {
                value.Clear();
                textBlock.Text = value.ToString();
            }
        }
    }
}
