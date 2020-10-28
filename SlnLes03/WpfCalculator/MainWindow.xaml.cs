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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        double number = Convert.ToDouble(txtNumber.Text);
        double total = Convert.ToDouble(lblUitkomst.Content);
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int getal = Convert.ToInt32(btn.Tag);
            // getal 1 invoeren
            txtNumber.Text += getal;
        }

        //private void btn2_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 2 invoeren
        //    txtNumber.Text += 2;

        //}

        //private void btn3_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 3 invoeren
        //    txtNumber.Text += 3;
        //}

        //private void btn4_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 4 invoeren
        //    txtNumber.Text += 4;
        //}

        //private void btn5_Click(object sender, RoutedEventArgs e)
        //{   // getal 5 invoeren
        //    txtNumber.Text += 5;
        //}

        //private void btn6_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 6 invoeren
        //    txtNumber.Text += 6;
        //}

        //private void btn7_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 7 invoeren
        //    txtNumber.Text += 7;
        //}

        //private void btn8_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 8 invoeren
        //    txtNumber.Text += 8;
        //}

        //private void btn9_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 9 invoeeren
        //    txtNumber.Text += 9;
        //}

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            // komma invoeren
            txtNumber.Text += ",";
        }

        //private void btn0_Click(object sender, RoutedEventArgs e)
        //{
        //    // getal 0 invoeren
        //    txtNumber.Text += 0;
        //}

        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            // tekstbox leegmaken
            txtNumber.Text += "";
            lblUitkomst.Content = "0,0";
        }

        private void btnRnd_Click(object sender, RoutedEventArgs e)
        {
            // random getal genereren als invoer
            txtNumber.Text += rnd.Next(0,9);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            // optelling
            // double number = Convert.ToDouble(txtNumber.Text);
            // double total = Convert.ToDouble(lblUitkomst.Content);
            total += number;
            lblUitkomst.Content = ("" + total);
            txtNumber.Text = "";
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            // aftrekking
            //double number = Convert.ToDouble(txtNumber.Text);
            //double total = Convert.ToDouble(lblUitkomst.Content);
            total -= number;
            lblUitkomst.Content = ("" + total);
            txtNumber.Text = "";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            // vermenigvuldiging
            // double number = Convert.ToDouble(txtNumber.Text);
            // double total = Convert.ToDouble(lblUitkomst.Content);
            total *= number;
            lblUitkomst.Content = ("" + total);
            txtNumber.Text = "";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            // deling
            // double number = Convert.ToDouble(txtNumber.Text);
            // double total = Convert.ToDouble(lblUitkomst.Content);
            total /= number;
            lblUitkomst.Content = ("" + total);
            txtNumber.Text = "";
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            // macht 
            // double number = Convert.ToDouble(txtNumber.Text);
            // double total = Convert.ToDouble(lblUitkomst.Content);
            total = Math.Pow(total, number);
            lblUitkomst.Content = ("" + total);
            txtNumber.Text = "";
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            // vierkantswortel
            // double number = Convert.ToDouble(txtNumber.Text);
            // double total = Convert.ToDouble(lblUitkomst.Content);
            total = Math.Sqrt(number);
            lblUitkomst.Content = ("" + total);
            txtNumber.Text = "";
        }
    }
}
