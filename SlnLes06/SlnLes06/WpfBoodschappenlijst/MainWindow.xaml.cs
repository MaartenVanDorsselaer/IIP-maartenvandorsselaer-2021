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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void lbxBoodschappen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // for loop om elk item te doorlopen en toe te voegen aan de boodschappenlijst
            for (int i = 0; i < lbxBoodschappen.Items.Count; i++)
            {
                // gaat elk item af
                ListBoxItem selectedItem = (ListBoxItem)lbxBoodschappen.Items.GetItemAt(i);
                if (selectedItem.IsSelected == true)
                {
                    // doorloopt elk listboxitem en onthoudt het laatste argument dat enabled is, dus als je eerst appel aanklikt en dan iets anders, toont het enkel appel
                    boodschappenlijst += " " + Convert.ToString(selectedItem.Content);
                }
            }
            // ik liet eerst de boodschappenlijst in de if maken, maar dit herhaalde dan telkens een aantal boodschappen
            // op deze manier geeft hij wel de lijst weer
            lblBoodschappenlijst.Content = $"Je selecteerde: {boodschappenlijst}";
            // boodschap leegmaken zodat er geen herhaling komt van de nieuwe boodschappenlijst, maar dat de selecties die niet meer geselectteerd zijn
            // ook niet meer in de boodschappenlijst zitten
            boodschappenlijst = "";
        }
    }
}
