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

namespace WpfEllipsen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // random generator aanmaken voor kleur
            Random rnd = new Random();
        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            // variabelen aanmaken + invullen
            int cirkels = Convert.ToInt32(sldAantalCirkel.Value);
            int minRadius = Convert.ToInt32(sldMinRadius.Value);
            int maxRadius = Convert.ToInt32(sldMaxRadius.Value);

            for (int i = 1; i<= cirkels; i++)
            {

            }

            // maak de ellips
            Ellipse newEllipse = new Ellipse();
            newEllipse.Width = 150;
            newEllipse.Height = 60;
            newEllipse.Fill = new SolidColorBrush(Color.FromRgb(122, 78, 200));
            double xPos = 50;
            double yPos = 85;
            newEllipse.SetValue(Canvas.LeftProperty, xPos);
            newEllipse.SetValue(Canvas.TopProperty, yPos);
            //voeg ellips toe aan het canvas
            canvas1.Children.Add(newEllipse);
        }

        private void sldAantalCirkel_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAantalCirkels.Content = sldAantalCirkel.Value;
        }

        private void sldMinRadius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMinRadius.Content = sldMinRadius.Value;
        }

        private void sldMaxRadius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMaxRad.Content = sldMaxRadius.Value;
        }
    }
}
