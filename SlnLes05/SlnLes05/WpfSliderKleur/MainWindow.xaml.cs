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

namespace WpfSliderKleur
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

        private void sldValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = Convert.ToInt32(sldValue.Value);
            if (value <= 25)
            {
                lblSliderValue.Foreground = Brushes.Green;
            }
            else if (value <= 50)
            {
                lblSliderValue.Foreground = Brushes.Yellow;
            }
            else if (value <= 75)
            {
                lblSliderValue.Foreground = Brushes.Orange;
            }
            else
            {
                lblSliderValue.Foreground = Brushes.Red;
            }
            lblSliderValue.Content = (value);
        }
    }
}
