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

namespace WpfCarConfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // aanmaken variabelen
        int totaalprijs;
        int modelprijs;
        int kleurprijs;
        int accessoireprijs;
        string model;
        string kleur = "blauw";
        public MainWindow()
        {
            InitializeComponent();
        }
        public void UpdateUI()
        {
            // juiste auto weergeven
            imgAuto.Source = new BitmapImage(new Uri($"images/{model}_{kleur}.jpg", UriKind.Relative));
            if (chbSpeakers.IsChecked == true)
            {
                imgSpeakers.Opacity = 1;
            }
            else
            {
                imgSpeakers.Opacity = 0.2;
            }
            if (chbMatjes.IsChecked == true)
            {
                imgMatjes.Opacity = 1;
            }
            else
            {
                imgMatjes.Opacity = 0.2;
            }
            if (chbVelgen.IsChecked == true)
            {
                imgVelgen.Opacity = 1;
            }
            else
            {
                imgVelgen.Opacity = 0.2;
            }
            lblPrijs.Content = $"{BerekenPrijs()} euro";

        }
        public int BerekenPrijs()
        {
            // prijs berekenen
            totaalprijs = 0;
            totaalprijs = modelprijs + kleurprijs + accessoireprijs;
            return totaalprijs;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            totaalprijs = 0;
            // img aanpassen aan de hand van model
            ComboBoxItem selectedItem = (ComboBoxItem)cbbModel.SelectedItem;
            if (cbbModel.SelectedIndex == 0)
            {
                model = "model1";
                modelprijs = 85000;
            }
            else if (cbbModel.SelectedIndex == 1)
            {
                model = "model2";
                modelprijs = 72000;
            }
            else if (cbbModel.SelectedIndex == 2)
            {
                model = "model3";
                modelprijs = 65300;
            }
            UpdateUI();
        }
        private void rbBlauw_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            // kleur van de auto bepalen
            if (rbtn.IsChecked == true)
            {
                kleur = Convert.ToString(rbtn.Tag);
                switch (kleur)
                {
                    case "blauw": kleurprijs = 0; break;
                    case "groen": kleurprijs = 250; break;
                    case "rood": kleurprijs = 700; break;
                }
            }
            UpdateUI();
        }
        private void chbSpeakers_Checked(object sender, RoutedEventArgs e)
        {
            // algemene checkbox aanmaakt die individuele checkboxes behandelt en prijs van de accessoires bepaalt
            CheckBox chbx = (CheckBox)sender;
            if (Convert.ToString(chbx.Tag) == "speakers")
            {
                accessoireprijs += 1250;
            }
            if (Convert.ToString(chbx.Tag) == "matjes")
            {
                accessoireprijs += 450;
            }
            if (Convert.ToString(chbx.Tag) == "velgen")
            {
                accessoireprijs += 300;
            }
            UpdateUI();
        }

        private void chbSpeakers_Unchecked(object sender, RoutedEventArgs e)
        {
            // algemene checkbox aanmaakt die individuele checkboxes behandelt en prijs van de accessoires bepaalt
            CheckBox chbx = (CheckBox)sender;
            if (Convert.ToString(chbx.Tag) == "speakers")
            {
                accessoireprijs -= 1250;
            }
            if (Convert.ToString(chbx.Tag) == "matjes")
            {
                accessoireprijs -= 450;
            }
            if (Convert.ToString(chbx.Tag) == "velgen")
            {
                accessoireprijs -= 300;
            }
            UpdateUI();
        }
    }
}
