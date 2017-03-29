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

namespace L10T03
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
        class Game
        {
          
                public string Lotto(int X) {
                string temp = "";
                string A = "";
                int Row = 0;
               
                for (int i = 0; i < X; i++)
                {
                   
                    int Lottonumber = new Random().Next(1, 39);
                    temp +=  "" + Lottonumber;
                }

                A = Row + temp +"\n";
                return A.ToString(); }
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int X = 0;
            int.TryParse(txtInput.Text, out X);
            Game newGame = new L10T03.MainWindow.Game();
            txtOutput.Text= newGame.Lotto(X).ToString();

        }
    }
}
