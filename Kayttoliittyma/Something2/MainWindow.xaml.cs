using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace Projekti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public abstract class Animal : INotifyPropertyChanged
        {
            public string Name { get; set; }
            public virtual string Species { get; set; }
            private double happiness;
            public double Happiness
            {
                get { return happiness; }
                set
                {
                    if (value != happiness)
                    {
                        happiness = value;
                        RaisePropertyChanged("Happiness");
                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            private void RaisePropertyChanged(string property)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
            public override string ToString()
            {
                return Species + " " + Name + " " + Happiness;
            }
        }
        public class Elukka : Animal
        {
            public Elukka(string species, string name, double happiness)
            {

                Species = species;
                Name = name;
                Happiness = happiness;
            }
        }
        public class Dog : Animal
        {
            public override string Species { get { return "Dog"; } }
            public Dog(string name, double Happi)
            {
                Name = name;
                Happiness = Happi;
            }
            public override string ToString()
            {
                return Species + " " + Name + " " + Happiness;
            }

        }
        public class Cat : Animal
        {
            public override string Species { get { return "Cat"; } }
            public Cat(string name, double Happi)
            {
                Name = name;
                Happiness = Happi;
            }
            public override string ToString()
            {
                return Species + " " + Name + " " + Happiness;
            }

        }
        class Item
        {
            public string RecSpecies { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public double Happinesspoint { get; set; }
            public string Description { get; set; }
            public Item(string recspecies, string name, int price, double happinesspoint, string description)
            {
                RecSpecies = recspecies;
                Name = name;
                Price = price;
                Happinesspoint = happinesspoint;
                Description = description;
            }
            public override string ToString()
            {
                return RecSpecies + " " + Name + " " + Price + " " + Happinesspoint + " " + Description;
            }
        }
        public class Player : INotifyPropertyChanged
        {
            public string X;


            public string Name { get; set; }

            private int money;
            public int Money
            {
                get { return money; }
                set
                {
                    if (value != money)
                    {
                        money = value;
                        RaisePropertyChanged("Happiness");
                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            private void RaisePropertyChanged(string property)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
            public void userToMain(string Y)
            {
                Y = X;

            }


        }





        Player player = new Player();
        public MainWindow()
        {
            Startup();
            InitializeComponent();
            InitializeCBAnimal();
            InitializeCBItems();
        }

        public void Startup()
        {


            Form1 form = new Form1();
            form.ShowDialog();


        }
        public void InitializeCBItems()
        {

            string line = "";
            string[] data;

            using (StreamReader X = new StreamReader("../../Items.txt"))
            {
                while ((line = X.ReadLine()) != null)
                {
                    data = line.Split(default(string[]), StringSplitOptions.None);
                    cbComItems.Items.Add(new Item(data[0], data[1], int.Parse(data[2]), double.Parse(data[3]), data[4]));
                }
            }


        }
        public void InitializeCBAnimal()
        {

            cbComboAnimal.Items.Add("Dog");
            cbComboAnimal.Items.Add("Cat");

        }
        public void ValueCheckandAdd()
        {
            string txtAnimal = "";
            if (cbComboAnimal.SelectedValue.ToString() == "Dog")
            {
                txtAnimal = txtName.Text;
                listBox1.Items.Add(new Dog(txtAnimal, 10));
            }
            else if (cbComboAnimal.SelectedValue.ToString() == "Cat")
            {
                txtAnimal = txtName.Text;
                listBox1.Items.Add(new Cat(txtAnimal, 20));

            }
        }

        private void btnGive(object sender, RoutedEventArgs e)
        {
            if (listBox.Items.Count == 0 || listBox.SelectedIndex < 0)
            {
                MessageBox.Show("Osta jotain / anna tuote");
            }

            else
            {
                Animal olio = (Animal)listBox1.SelectedItem;
                Item itemit = (Item)listBox.SelectedItem;
                if (!olio.Species.Equals(itemit.RecSpecies))
                {
                    double temp = 0;
                    temp = Math.Ceiling((double)itemit.Happinesspoint) / ((double)2);
                    olio.Happiness += temp;
                    txtInfo.Text = "Giving " + itemit.Name + " to " + olio.Species + " seems ineffective ";
                }
                else
                {
                    olio.Happiness += itemit.Happinesspoint;
                    txtInfo.Text = olio.Name + " Happiness increase by " + itemit.Happinesspoint;
                }
                listBox.Items.Remove(itemit);
                MyProgress.DataContext = olio.Happiness;
            }


        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            ValueCheckandAdd();
            txtuser.Text = player.Name;
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyProgress.DataContext = listBox1.SelectedItem;
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            if (cbComItems.SelectedIndex < 0)
            {
                MessageBox.Show("Valitse tuote");
            }
            else
            {
                listBox.Items.Add(cbComItems.SelectedItem);
            }

        }
        private void btnSell(object sender, RoutedEventArgs e)
        {
            Item itemit = (Item)listBox.SelectedItem;
            listBox.Items.Remove(itemit);
            double temp = Math.Ceiling((double)(itemit.Price) / (double)2);
            txtInfo.Text = "Sold" + itemit.Name + " for " + temp;
            player.Money -= (int)temp;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            player.Money += 1;


        }
    }
}
