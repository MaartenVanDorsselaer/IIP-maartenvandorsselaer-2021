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

namespace WpfOpties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int check = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            check++;
            if (check >= 1)
            {
                imgPhoto.Source = new BitmapImage(new Uri("Image/checkMark.jpg", UriKind.Relative));
            }
            if (cb.Name != cbOther.Name)
            {
                txtOther.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtOther.Visibility = Visibility.Visible;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            check--;
            if (check < 1)
            {
                imgPhoto.Source = new BitmapImage(new Uri("", UriKind.Relative));
            }
            CheckBox cb = (CheckBox)sender;
            if (cb.Name == cbOther.Name)
            {
                txtOther.Visibility = Visibility.Collapsed;
            }
        }
    }
}
