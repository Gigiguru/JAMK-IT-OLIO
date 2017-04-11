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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public abstract class Henkilo
        {
            public Henkilo(string sotu, string firstname, string lastname, DateTime D)
            {
                this.SOTU = sotu;
                this.Fistname = firstname;
                this.Lastname = lastname;
                this.BirthDate = D;
            }
            public string SOTU { get; set; }
            public string Fistname { get; set; }
            public string Lastname { get; set; }
            public DateTime BirthDate { get; set; }
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
            static int myID = 0;
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
           
            public override float LaskePalkka()
            {
                float X = Tuntipalkka * TehdytTunnit;
                return X;
            }
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
            if (olio.GetType() == typeof(OsaAikainen) )
            {
                rdOSA.IsChecked = true;
            }
            else
            {
                rdVAk.IsChecked = true;
            }
	
        }

        private void btnHae(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = tyontekijat;
        }

        private void btnTyhjennä(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listBox.SelectedIndex < 1)
                {
                    MessageBox.Show("val");
                    listBox.SelectedIndex = 0;
                    listBox.ItemsSource = null;
                }
                   
                
               

            }
            catch (Exception)
            {

                MessageBox.Show("Something unexpected");
            }

        }

       
    }
}
