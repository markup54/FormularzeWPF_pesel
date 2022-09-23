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

namespace Formularze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool czyPani = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void witaj(object sender, RoutedEventArgs e)
        {

            string imieTextBox = imie.Text;
            string nazwiskoTextBox = nazwisko.Text;
            if (K.IsChecked == true)
            {
                MessageBox.Show("witaj Pani " + imieTextBox + " " + nazwiskoTextBox);
            }
            else if(M.IsChecked == true)
            {
                MessageBox.Show("witaj Panie " + imieTextBox + " " + nazwiskoTextBox);
            }
        }
        private bool sprawdzDate()
        {
            if (rok.Text == "")
                return false;
            if (mies.Text == "")
                return false;
            if (dz.Text == "")
                return false;
            if (rok.Text.Length != 4)
                return false;
            if(int.Parse(rok.Text)<1922 || int.Parse(rok.Text)>2022)
                return false;
            if (mies.Text.Length != 2)
                return false;
            if (int.Parse(mies.Text) < 1 || int.Parse(mies.Text) > 12)
                return false;
            if (dz.Text.Length != 2)
                return false;
            if (int.Parse(dz.Text) < 1 || int.Parse(dz.Text) > 31)
                return false;
            return true;
                
        }
        private bool sprawdzImie(string imie)
        {
             // meżczyzna true
             //kobieta false
            if(imie == "Kuba")
            {
                return true;
            }
            if (imie[imie.Length-1] == 'a')
            {
                return false;
            }
            if(imie == "Ines" || imie == "Inez" || imie=="Dolores")
            {
                return false;
            }
            return true;
        }

        private void czyKobieta(object sender, RoutedEventArgs e)
        {
            czyPani=true;
            if(imie.Text != "")
            if (sprawdzImie(imie.Text))
            {
                MessageBox.Show("Sprawdż czy poprawnie wpisałaś imię");
                    var radio = sender as RadioButton;
                    radio.IsChecked = false;
            }
            
        }

        private void czyMezczyzna(object sender, RoutedEventArgs e)
        {
            czyPani = false;
            if (imie.Text != "")
                if (!sprawdzImie(imie.Text))
                {
                    MessageBox.Show("Sprawdż czy poprawnie wpisałeś imię");
                    var radio = sender as RadioButton;
                    radio.IsChecked = false;
                }
        }
    }
}
