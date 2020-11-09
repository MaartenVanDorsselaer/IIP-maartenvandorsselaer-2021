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
            
        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            // variabelen aanmaken + invullen
            int cirkels = Convert.ToInt32(sldAantalCirkel.Value);
            int minRadius = Convert.ToInt32(sldMinRadius.Value);
            int maxRadius = Convert.ToInt32(sldMaxRadius.Value);
            Random rnd = new Random(); 
            
            if (sldMaxRadius.Value < sldMinRadius.Value)
            {
                lblError.Content = "De minimum mag niet groter zijn dan de maximum straal!";
                lblError.Foreground = Brushes.Red;
            }
            else
            {
                lblError.Content = "";
                lblError.Foreground = Brushes.Black;

                for (int i = 1; i <= cirkels; i++)
                {
                    byte r = Convert.ToByte(rnd.Next(0, 255));
                    byte g = Convert.ToByte(rnd.Next(0, 255));
                    byte b = Convert.ToByte(rnd.Next(0, 255));
                    // maak de ellips
                    Ellipse newEllipse = new Ellipse();
                    newEllipse.Width = Convert.ToInt32(rnd.Next(minRadius, maxRadius));
                    newEllipse.Height = Convert.ToInt32(rnd.Next(minRadius, maxRadius));
                    newEllipse.Fill = new SolidColorBrush(Color.FromRgb(r, g, b ));
                    double xPos = Convert.ToInt32(rnd.Next(0, 255));
                    double yPos = Convert.ToInt32(rnd.Next(0, 700));
                    newEllipse.SetValue(Canvas.LeftProperty, xPos);
                    newEllipse.SetValue(Canvas.TopProperty, yPos);
                    //voeg ellips toe aan het canvas
                    canvas1.Children.Add(newEllipse);
                }
            }
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
