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

namespace WpfAlcohol
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

        private void sldAantalPint_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAantalPint.Content = sldAantalPint.Value + " glazen";
        }

        private void sldAantalWijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAantalWijn.Content = sldAantalWijn.Value + " glazen";
        }

        private void sldAantalKorteDrank_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAantalKorteDrank.Content = sldAantalKorteDrank.Value + " glazen";
        }
    }
}
