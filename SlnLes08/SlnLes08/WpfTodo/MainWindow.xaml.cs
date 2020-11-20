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

namespace WpfTodo
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtTaak.Text == "" && cbbPriotiteit.SelectedIndex == 0)
            {
                btnAdd.IsEnabled = false;
            }
            else
            {
                btnAdd.IsEnabled = true;
            }
            ListBoxItem taak = (ListBoxItem)lbxTodoList.SelectedItem;
            if (taak != null)
            {
                if (cbbPriotiteit.SelectedIndex == 1)
                {
                    lbxTodoList.Items.Add(txtTaak.Text);
                    taak.Foreground = Brushes.Green;
                }
                else if (cbbPriotiteit.SelectedIndex == 2)
                {
                    txtTaak.Foreground = Brushes.Orange;
                }
                else
                {
                    txtTaak.Foreground = Brushes.Red;
                }
            }
            lbxTodoList.Items.Add(txtTaak.Text);
            txtTaak.Text = "";

        }
    }
}
