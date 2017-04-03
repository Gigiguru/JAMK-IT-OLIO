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

namespace WpfApplication4
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
            private Random rnd = new Random();
            private List<int> lista = new List<int>();
            private List<string> lista2 = new List<string>();
            string Answeri;
            public int RNDL() { return rnd.Next(1, 39); }
            public int RNDV() { return rnd.Next(1, 48); }
            public int RNDE() { return rnd.Next(1, 50); }
            public string Show()
            {
                int Row = 0;
                string temp = "";
                foreach (string item in lista2)
                {
                    Row++;
                    temp += "Row " + Row + " " + item + "\n";
                }
                return temp;
            }
            public void Draw(int X)
            {


                for (int i = 0; i < X; i++)
                {
                    lista2.Add(GameSelect(Answeri));
                }
                Show();


            }
            public void ListClear()
            {
                lista2.Clear();
            }
            public string GameSelect(string X)
            {
                string Answer = "";
                Answeri = "";
                if (X == "Lotto")
                {
                    Answer = Lotto();
                    Answeri = "Lotto";
                }
                else if (X == "VikingLotto")
                {
                    Answer = Vikinglotto();
                    Answeri = "VikingLotto";
                }
                else if (X == "EuroJackpot")
                {
                    Answer = Eurojackpot();
                    Answeri = "EuroJackpot";
                }

                return Answer;

            }
            public string Lotto()
            {
                int temp = 0;
                string msg2 = "";
                string msg = "";
                int[] lottoNumbers = new int[7];
                for (int i = 0; i < lottoNumbers.Length; i++)
                {
                    do
                    {
                        temp = RNDL();
                    }
                    while (lottoNumbers.Contains(temp));
                    lottoNumbers[i] = temp;
                    lista.Add(temp);
                }
                lista.Sort();
                foreach (int item in lista)
                {
                    msg += " " + item;
                }
                msg2 = msg;
                lista.Clear();
                return msg2;
            }
            public string Vikinglotto()
            {
                int temp = 0;
                string msg2 = "";
                string msg = "";
                int[] lottoNumbers = new int[6];
                for (int i = 0; i < lottoNumbers.Length; i++)
                {
                    do
                    {
                        temp = RNDV();
                    }
                    while (lottoNumbers.Contains(temp));
                    lottoNumbers[i] = temp;
                    lista.Add(temp);
                }
                lista.Sort();
                foreach (int item in lista)
                {
                    msg += " " + item;
                }
                msg2 = msg;
                lista.Clear();
                return msg2;
            }
            public string Eurojackpot()
            {
                int temp = 0;
                string msg2 = "";
                string msg = "";
                int[] lottoNumbers = new int[5];
                int[] lottoNumbersExtra = new int[2];
                for (int i = 0; i < lottoNumbers.Length; i++)
                {
                    do
                    {
                        temp = RNDE();
                    }
                    while (lottoNumbers.Contains(temp));
                    lottoNumbers[i] = temp;
                    lista.Add(temp);
                }
                lista.Sort();
                foreach (int item in lista)
                {
                    msg += " " + item;
                }
                msg += " Tähtinumerot ";
                for (int i = 0; i < lottoNumbersExtra.Length; i++)
                {
                    do
                    {
                        temp = RNDE();
                    }
                    while (lottoNumbers.Contains(temp) && lottoNumbersExtra.Contains(temp));
                    lottoNumbers[i] = temp;
                    msg += " " + temp;
                }
                msg2 = msg;
                lista.Clear();
                return msg2;
            }


        }
        Game game = new Game();
        int X = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtInput.Text, out X);
            if (cbCombo.SelectedValue == null)
            {
                MessageBox.Show("Valitse Peli");
            }
            else
            {
                game.GameSelect(cbCombo.SelectedValue.ToString());
                game.Draw(X);
                txtoutput.Text = game.Show();
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            game.ListClear();
            txtoutput.Text = game.Show();

        }

        private void cbCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCombo.SelectedIndex > -1)
            {
                game.ListClear();
                txtoutput.Text = game.Show();
            }
        }
    }
}
