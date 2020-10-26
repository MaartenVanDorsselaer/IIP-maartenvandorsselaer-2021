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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // aanmaak variabelen
        string hoogsteBieder;
        int hoogsteBod = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // text input in variabelen steken
            string bieder = txtName.Text;
            int bod = Convert.ToInt32(txtOffer.Text);

            // input vergelijken met hoogsteBieder en hoogsteBod
            if (bod > hoogsteBod)
            {
                hoogsteBod = bod;
                hoogsteBieder = bieder;
                lblWinnaar.Content = $"{hoogsteBieder} heeft met {hoogsteBod} het hoogste bod!";
            }
            else
            {
                lblWinnaar.Content = $"Sorry, {hoogsteBieder} heeft momenteel het hoogste bod";
            }
        }
    }
}
