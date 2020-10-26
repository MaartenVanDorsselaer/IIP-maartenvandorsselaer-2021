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

namespace WpfFormChecking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // aanmaken van variabele
        int aantalFouten = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            // controleren of naam is ingevuld en gepast reageren
            if (txtName.Text == "")
            {
                lblName.Content = "Naam moet ingevuld zijn";
                aantalFouten++;
            }

            // controleren of email is ingevuld en gepast reageren
            if (txtMail.Text == "")
             {
                lblMail.Content = "E-mail moet ingevuld zijn";
                aantalFouten++;
            }

            // controleren of geboortedatum is ingevuld en gepast reageren
            if (txtBirthDate.Text == "")
            {
                lblBirthDate.Content = "Geboortedatum moet ingevuld zijn";
                aantalFouten++;
            }

            // kijken of het profiel is aangepast en gepast reageren
            if (cbbProfiel.Text == "")
            {
                lblProfile.Content = "Maak een keuze";
                aantalFouten++;
            }

            // controleren of er een passwoord is ingegeven en gepast reageren
            if (txtPassword.Text == "")
            {
                lblPass.Content = "Kies een passwoord";
                aantalFouten++;
            }

            // controleren of geslacht is gekozen en gepast reageren
            if (rbMan.IsChecked == false && rbVrouw.IsChecked == false)
            {
                lblGender.Content = "Kies een geslacht";
                aantalFouten++;
            }

            // controleren of er een interesse is gekozen en gepast reageren
            if (cbProgrammeren.IsChecked == false && cbNetwerken.IsChecked == false && cbBusiness.IsChecked == false)
            {
                lblInterest.Content = "Kies minstens één interesse";
                aantalFouten++;
            }

            // aantal fouten weergeven in label
            if (aantalFouten > 1)
            {
                lblFoutmelding.Content = $"Dit formulier bevat {aantalFouten} fouten";
            }
            else if (aantalFouten == 1)
            {
                lblFoutmelding.Content = $"Dit formulier bevat {aantalFouten} fout";
            }

            // fouten terug instellen op 0, anders wordt dit elke keer er op controleer geklikt wordt bij elkaar opgeteld
            aantalFouten = 0;
        }

        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            // alle textblokken en labels, radiobuttons, checkbuttons...  leegmaken
            txtName.Text = "";
            lblName.Content = "";
            txtMail.Text = "";
            lblMail.Content = "";
            txtBirthDate.Text = "";
            lblBirthDate.Content = "";
            cbbProfiel.SelectedIndex = 0;
            lblProfile.Content = "";
            txtPassword.Text = "";
            lblPass.Content = "";
            rbMan.IsChecked = false;
            rbVrouw.IsChecked = false;
            lblGender.Content = "";
            cbBusiness.IsChecked = false;
            cbNetwerken.IsChecked = false;
            cbProgrammeren.IsChecked = false;
            lblInterest.Content = "";
            lblFoutmelding.Content = "";
            aantalFouten = 0;
        }
    }
}
