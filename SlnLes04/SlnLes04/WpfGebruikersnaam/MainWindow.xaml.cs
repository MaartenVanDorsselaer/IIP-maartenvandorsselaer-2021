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

namespace WpfGebruikersnaam
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

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            string username = txtUsername.Text;
            if (txtUsername.Text.Contains(" "))
            {
                lblError.Content = "Mag geen spaties bevatten";
                lblError.Foreground = Brushes.Red;
                txtUsername.Background = Brushes.Red;
            }
            else if (txtUsername.Text.Contains("@"))
            {
                lblError.Content = "Mag geen \"@\" bevatten";
                lblError.Foreground = Brushes.Red;
                txtUsername.Background = Brushes.Red;
            }
            else if (txtUsername.Text.Length > 0 && char.IsLower(username, 0)) /* als eerst gechecked wordt op hoofdletter, sluit het programma vanzelf*/
            {                                                                  
                lblError.Content = "Moet met een hoofdletter starten";
                lblError.Foreground = Brushes.Red;
                txtUsername.Background = Brushes.Red;
            }
            //else if (txtUsername.Text.Contains())
            //{
            //    lblError.Content = "Mag geen cijfer bevatten";
            //    lblError.Foreground = Brushes.Red;
            //    txtUsername.Background = Brushes.Red;
            //}
            else if (txtUsername.Text.Length > 0)
            {
                lblError.Content = "";
                txtUsername.Background = Brushes.Green;
            }
            else
            {
                lblError.Content = "";
                txtUsername.Background = Brushes.White;
            }
        }
    }
}
