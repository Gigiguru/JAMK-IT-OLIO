using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public abstract class Henkilo : INotifyPropertyChanged
        {
            public Henkilo(string sotu, string firstname, string lastname, DateTime D)
            {
                this.SOTU = sotu;
                this.Fistname = firstname;
                this.Lastname = lastname;
                this.BirthDate = D;


            }

            public int homo = 0;
            public int happiness;
            public int Happiness { get { return happiness = RANDOM(); } set { if (value != happiness) { happiness = value; Raize("Happiness"); } } }
            public event PropertyChangedEventHandler PropertyChanged;
            private void Raize(string property)
            { if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(property)); } }
            public string SOTU { get; set; }
            public string Fistname { get; set; }
            public string Lastname { get; set; }
            public DateTime BirthDate { get; set; }
            public int RANDOM()
            {
                int rndw = 0;
                Random rnd = new Random();
                rndw = rnd.Next(1, 20);

                return rndw;


            }
            public string Wname { get { return Fistname + " " + Lastname; } }
            public int age = 0;
            public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        }
        public class Tyontekija : Henkilo
        {
            public Tyontekija(string name, string sotu, string firstname, string lastname, DateTime D) : base(sotu, firstname, lastname, D)
            {
                myID = Interlocked.Increment(ref myID);
                this.TTID = myID;
                this.Nimike = name;
                this.SOTU = sotu;
                this.Fistname = firstname;
                this.Lastname = lastname;
                this.BirthDate = D;

            }

            public string Nimike { get; set; }
            public int TTID = 0;
            static int myID;
            private int MyID { get { return myID; } }
            public float Palkka { get { return 42; } }
            public DateTime date { get; set; }

            public virtual float LaskePalkka()
            {
                float X = Palkka;
                return X;
            }
            public override string ToString()
            {
                return TTID + " " + Wname + " " + Nimike;
            }
        }
        public class Vakituinen : Tyontekija
        {
            public Vakituinen(string sotu, string nimike, string firstname, string lastname, DateTime D) : base(sotu, nimike, firstname, lastname, D)
            {

                this.Nimike = nimike;
                this.SOTU = sotu;
                this.Fistname = firstname;
                this.Lastname = lastname;
                this.BirthDate = D;
                this.KuukausiPalkka = LaskePalkka();

            }
            public float KuukausiPalkka { get; set; }
            public string vakituinen { get { return "Vakituinen"; } }
            public override float LaskePalkka()
            {
                float X = Palkka * 30;
                return X;
            }
        }
        public class OsaAikainen : Tyontekija
        {
            public OsaAikainen(string sotu, string nimike, string firstname, string lastname, float TP, int TT, DateTime D) : base(sotu, nimike, firstname, lastname, D)
            {

                this.Nimike = nimike;
                this.SOTU = sotu;
                this.Fistname = firstname;
                this.Lastname = lastname;
                this.BirthDate = D;
                this.Tuntipalkka = TP;
                this.TehdytTunnit = TT;

            }
            public float Tuntipalkka { get; set; }
            public int TehdytTunnit { get; set; }
            public string vakituinen { get { return "Osaaikainen"; } }
            public override float LaskePalkka()
            {
                float X = Tuntipalkka * TehdytTunnit;
                return X;
            }
        }
        class Itemz
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public Itemz(string name, int value) { Name = name; Value = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            initilizaTyontekijat();


        }
        public List<Tyontekija> tyontekijat = new List<Tyontekija>();
        public void initilizaTyontekijat()
        {
            tyontekijat.Add(new Vakituinen("ITC-999", "Toimitusjohtaja", "Alfred", "Nobel", new DateTime(2000, 5, 5)));
            tyontekijat.Add(new Vakituinen("CTO-321", "Siivoaja", "Pile", "Bamboo", new DateTime(2000, 5, 5)));
            tyontekijat.Add(new OsaAikainen("PUK-654", "Työorja", "Cecilia", "Snowball", 2, 8, new DateTime(2000, 5, 5)));
            tyontekijat.Add(new OsaAikainen("PIG-888", "Lusmu", "Daavid", "Joker", 10, 5, new DateTime(2000, 5, 5)));


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tyontekija olio = (Tyontekija)listBox.SelectedItem;
            txtEn.Text = olio.Fistname;
            txtSn.Text = olio.Lastname;
            txtID.Text = olio.TTID.ToString();
            txtTitle.Text = olio.Nimike;
            txtP.Text = olio.LaskePalkka().ToString();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = tyontekijat;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listBox.ItemsSource = null;

            }
            catch (Exception)
            {

                MessageBox.Show("Something unexpected");
            }

        }


    }
}
