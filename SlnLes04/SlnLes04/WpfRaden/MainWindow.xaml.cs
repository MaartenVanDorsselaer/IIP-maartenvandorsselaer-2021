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
        // variabelen en constanten aanmaken
        int pogingenOver = 3;
        int randomGetal;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            randomGetal = rnd.Next(1, 10);
        }

        private void txtGok_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool bevatTekst = txtGok.Text != "";
            btnControleer.IsEnabled = bevatTekst;
        }

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            // lees de gok in
            int gok = Convert.ToInt32(txtGok.Text);
            if (pogingenOver > 1)
            {
                lblAntwoord.Content = $"Je hebt nog {pogingenOver} pogingen over";
            }
            else if (pogingenOver == 1)
            {
                lblAntwoord.Content = "Je hebt nog 1 poging over";
            }
            else
            {
                lblAntwoord.Content = "Je hebt geen pogingen meer over";
            }
            pogingenOver--;


        }
    }
}
