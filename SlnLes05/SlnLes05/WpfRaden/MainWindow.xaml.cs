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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // aanmaken van variabelen en constanten
        int randomGetal;
        const int MAX_POGINGEN = 3;
        int poging = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtGok_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool bevatTekst = txtGok.Text != "";
            btnControleer.IsEnabled = bevatTekst;

            // aanmaken van random getal generator
            Random rnd = new Random();
            randomGetal = rnd.Next(1, 10);
        }

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            // converteer ingegeven getal in getal
            int gok = Convert.ToInt32(txtGok.Text);

            // maak variabele aan om bericht in te steken
            string reply;

            // controleer de poging
            int pogingenOver = MAX_POGINGEN - poging;

            // kijk welk bericht je gaat weergeven om te zeggen hoeveel pogingen er nog over zijn
            if (pogingenOver > 1)
            {
                reply = $"je hebt nog {pogingenOver} pogingen over";
            }
            else if(pogingenOver == 1)
            {
                reply = "je hebt nog 1 poging over";
            }
            else
            {
                reply = "Helaas, je hebt geen pogingen meer over";
                btnControleer.IsEnabled = false;
            }

            // gok vergelijken met random getal
            if (gok == randomGetal)
            {
                lblReply.Content = "Geraden!";
                btnControleer.IsEnabled = false;
            }
            else if (gok < randomGetal)
            {
                lblReply.Content = $"Te laag, {reply}";
            }
            else
            {
                lblReply.Content = $"Te hoog, {reply}";
            }

            // poging +1 omdat er een poging gebeurd is
            poging++;

        }
    }
}
