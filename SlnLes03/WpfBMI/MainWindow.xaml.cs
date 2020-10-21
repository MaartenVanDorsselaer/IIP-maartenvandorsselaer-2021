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

namespace WpfBMI
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

        /// <summary>
        /// gebruiker klikt op knop om bmi te berekenen
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // lengte converteren naar een double om ermee te kunnen rekenen
            double height = Math.Pow(Convert.ToDouble(txtHeight.Text) / 100, 2);

            // lengte converteren naar een double om ermee te kunnen rekenen
            int weight = Convert.ToInt32(txtWeight.Text);

            // kwadraat van de lengte maken
            // double heightSquare = Math.Pow(height, 2);

            // bmi berekenen
            double bmi = Math.Round(weight / height);

            // bmi afronden tot 1 getal na de komma
            //bmi = Math.Round(bmi, 1);

            // bmi weergeven
            lblBmi.Content = ("BMI: " + bmi);
        }
    }
}
