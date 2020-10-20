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

namespace WpfPizza
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            lblDescription.Content = "Tomatensaus, mozarella, rode ui, kip," + Environment.NewLine + "paprika, pepperoni & spaanse pepers.";
            imgPhoto.Source = new BitmapImage(new Uri("Images/Hot&Spicy.jpg", UriKind.Relative));
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            lblDescription.Content = "Tomatensaus, mozarellan, rode ui," + Environment.NewLine + "paprika, kip en BBQ saus.";
            imgPhoto.Source = new BitmapImage(new Uri("Images/BBQChicken.jpg", UriKind.Relative));

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            lblDescription.Content = "Tomatensaus, mozarella, gegrilde ham" + Environment.NewLine + "en ananas.";
            imgPhoto.Source = new BitmapImage(new Uri("Images/Hawaï.jpg", UriKind.Relative));

        }
    }
}
