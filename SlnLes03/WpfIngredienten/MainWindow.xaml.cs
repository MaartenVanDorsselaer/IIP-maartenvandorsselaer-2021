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

namespace WpfIngredienten
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
        private void cbbPersonen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItemPersonen = (ComboBoxItem) cbbPersonen.SelectedItem;
        }

        private void cbbEenheid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItemEenheid1 = (ComboBoxItem)cbbEenheid1.SelectedItem;

        }
        private void cbbEenheid2_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItemEenheid2 = (ComboBoxItem)cbbEenheid2.SelectedItem;

        }
        private void cbbEenheid3_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItemEenheid3 = (ComboBoxItem)cbbEenheid3.SelectedItem;

        }
        private void cbbEenheid4_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItemEenheid4 = (ComboBoxItem)cbbEenheid4.SelectedItem;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // textberichten omzetten naar getallen zodat we ze kunnen gebruiken in de berekeningen
            // string personen = Convert.ToString(cbbPersonen.SelectedIndex);
            int persoon = Convert.ToInt32(cbbPersonen.Text);
            int hoeveelheid1 = Convert.ToInt32(txtHoeveel1.Text);
            int hoeveelheid2 = Convert.ToInt32(txtHoeveel2.Text);
            int hoeveelheid3 = Convert.ToInt32(txtHoeveel3.Text);
            int hoeveelheid4 = Convert.ToInt32(txtHoeveel4.Text);

            // totaal van de ingrediënten berekenen
            int totaal1 = hoeveelheid1 * persoon;
            int totaal2 = hoeveelheid2 * persoon;
            int totaal3 = hoeveelheid3 * persoon;
            int totaal4 = hoeveelheid4 * persoon;

            // eenheden omzetten in string om makkelijker in de boodschappenlijst te kunnen zetten 
            // --- uiteindelijk niet nodig, kan rechtstreeks in de boodschappenlijst printen ---
            //string eenheid1 = Convert.ToString(cbbEenheid1.SelectedValue);
            //string eenheid2 = Convert.ToString(cbbEenheid2.SelectedValue);
            //string eenheid3 = Convert.ToString(cbbEenheid3.SelectedValue);
            //string eenheid4 = Convert.ToString(cbbEenheid4.SelectedValue);

            // ingrediënten omzetten in string om makkelijker de boodschappenlijst te kunnen maken
            string ingredient1 = txtIngredient1.Text;
            string ingredient2 = txtIngredient2.Text;
            string ingredient3 = txtIngredient3.Text;
            string ingredient4 = txtIngredient4.Text;

            // boodschappelijst printen
            lblBoodschappenlijst.Content = "- " + totaal1 + " " + cbbEenheid1.Text + " " + ingredient1 + Environment.NewLine +
            "- " + totaal2 + " " + cbbEenheid2.Text + " " + ingredient2 + Environment.NewLine +
            "- " + totaal3 + " " + cbbEenheid3.Text + " " + ingredient3 + Environment.NewLine +
            "- " + totaal4 + " " + cbbEenheid4.Text+ " " + ingredient4;
        }
    }
}
