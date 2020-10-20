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

namespace WpfInterest
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

        private void sldPeriode_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // waarde van de slider weergeven
            lblPeriode.Content = sldPeriode.Value + " jaar";

        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            // aanmaken van variabelen om te kunnen gebruiken in een formule
            int startBedrag = Convert.ToInt32(txtStartBedrag.Text);
            double interest = Convert.ToInt32(txtInterest.Text);
            int periode = Convert.ToInt32(sldPeriode.Value);

            // van interest een kommagetal maken
            interest = interest / 100;

            // variabele maken om later de toekomstige waarde in te steken
            double toekomstigeWaarde;

            // machtsberekening
            double pow = Math.Pow(1 + interest, periode);

            // berekening maken
            toekomstigeWaarde = startBedrag * pow;

            // toekomstige waarden afronden op 2 cijfers na de komma
            toekomstigeWaarde = Math.Round(toekomstigeWaarde, 2);

            // antwoord weergeven 
            lblReply.Content = $"De waarde na {periode} jaar bedraagt € {toekomstigeWaarde}";
        }
    }
}
