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
using System.IO;

namespace WpfApplication7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            StartUP();
            StartInitializeGame();
            InitializeComponent();

        }
        Player user = new Player();
        string PN = "";
        string State = "";
        int tempp = 0;
        public void StartUP()
        {
            Form1 form = new Form1();
            form.ShowDialog();
            string Dir = "../../DB/";
            string txt = ".txt";
            string Main = "Main";

            using (StreamReader X = new StreamReader(Dir + Main + txt))
            {
                State = X.ReadLine();
                PN = X.ReadLine();
            }

        }
        public void StartInitializeGame()
        {
            if (State == "New")
            {
                user.Name = PN;
                string Dir = "../../DB/";
                string txt = ".txt";
                string Main = PN;
                user.Ite.Add(new Items("HumanOrgan", "Kidney", 20000, 200, "YourOwnOrgan"));
                user.Ite.Add(new Items("HumanOrgan", "Kidney", 20000, 200, "YourOwnOrgan"));
                user.Money = 0;
                using (StreamWriter X = new StreamWriter(Dir + Main + txt))
                {
                    X.WriteLine(user.Money);
                    foreach (Items item in user.Ite)
                    {
                        X.WriteLine("Item" + " " + item);
                    }
                }
                MessageBox.Show(PN);
            }
            else if (State == "CP")
            {
                user.Name = PN;
                string Dir = "../../DB/";
                string txt = ".txt";
                string Main = PN;
                string line = "";
                string temp = "";

                string[] data;
                using (StreamReader X = new StreamReader(Dir + Main + txt))
                {
                    temp = X.ReadLine();
                    int.TryParse(temp, out tempp);
                    while ((line = X.ReadLine()) != null)
                    {
                        if (line.Contains("Item"))
                        {

                            data = line.Split(default(string[]), StringSplitOptions.None);
                            user.Ite.Add(new Items(data[1], data[2], int.Parse(data[3]), double.Parse(data[4]), data[5]));
                        }
                        if (line.Contains("Animal"))
                        {
                            MessageBox.Show("Hellurei");
                            //data = line.Split(default(string[]), StringSplitOptions.None);
                            //user.Ite.Add(new Items(data[1], data[2], int.Parse(data[3]), double.Parse(data[4]), data[5]));
                        }

                    }

                }

            }

        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Items itemit = (Items)listInventory.SelectedItem;
            txtInfo.Text = itemit.Name + " Price " + itemit.Price + "  \nHappinesspoint " + itemit.HappinessPoint + " \n" +
                itemit.Description;
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

            listInventory.ItemsSource = user.Ite;
            listInventory.DisplayMemberPath = "Name";
            textBox.Text = user.Money.ToString();
        }
    }
}
