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

namespace WpfBoodschappenlijst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string boodschappenlijst;
        string boodschap;
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void ListBoxItems_Selected(object sender, RoutedEventArgs e)
        //{
        //    // geeft telkens een foutmelding dat een object van type selectedItemCollection niet geconverteerd kan worden naar listBoxItem
        //    //ListBoxItem selectedItem = (ListBoxItem)lbxBoodschappen.SelectedItems;
        //    //foreach (object boodschap in lbxBoodschappen.SelectedItems)
        //    //{
        //    //    boodschappenlijst += selectedItem.Content;
        //    //}
        //    //lblBoodschappenlijst.Content = $"Je selecteerde: {boodschappenlijst}";
            
        //}

        private void lbxBoodschappen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // zou selectedItems moeten zijn, maar geeft telkens een exception not handled error, op deze manier werkt de app wel (half)
            // ListBoxItem selectedItem = (ListBoxItem)lbxBoodschappen.SelectedItem;

            // for loop om elk item te doorlopen en toe te voegen aan de boodschappenlijst
            for (int i = 0; i < lbxBoodschappen.Items.Count; i++)
            {
                ListBoxItem selectedItem = (ListBoxItem)lbxBoodschappen.Items.GetItemAt(i);
                if (selectedItem.IsSelected == true)
                {
                    // doorloopt elk listboxitem en onthoudt het laatste argument dat enabled is, dus als je eerst appel aanklikt en dan iets anders, toont het enkel appel
                    boodschap = " " + Convert.ToString(selectedItem.Content);
                }
            }
            // ik liet eerst de boodschappenlijst in de if maken, maar dit herhaalde dan telkens een aantal boodschappen
            // op deze manier geeft hij de juiste lijst weer, maar ik vind het niet logisch
            boodschappenlijst += boodschap;
            lblBoodschappenlijst.Content = $"Je selecteerde: {boodschappenlijst}";
        }
    }
}
