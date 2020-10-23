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

namespace WpfBlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // randomizer aanmaken
        Random rnd = new Random();

        // variabele aanmaken
        int kaartNrPlayer = 1;
        int kaartNrBank = 1;
        string kaart;
        int playerCardValue;
        int bankCardValue;
        int kaartNr;
        int bankScore = 0;
        int playerScore = 0;

        public MainWindow()
        {
            InitializeComponent();
            generateBackground();
        }


        // methode om achtergrond in te stellen bij het opstarten van de app
        public void generateBackground ()
        {
            // variabelen aanmaken
            int backgroundBank = rnd.Next(1, 6);
            int backgroundPlayer = rnd.Next(1, 6);

            // achtergrond kaarten speler 1 bepalen
            if (backgroundBank == 1)
            {
                imgBankCard1.Source = new BitmapImage(new Uri("Images/Background/back_blue.png", UriKind.Relative));
            }
            else if (backgroundBank == 2)
            {
                imgBankCard1.Source = new BitmapImage(new Uri("Images/Background/back_green.png", UriKind.Relative));
            }
            else if (backgroundBank == 3)
            {
                imgBankCard1.Source = new BitmapImage(new Uri("Images/Background/back_grey.png", UriKind.Relative));
            }
            else if (backgroundBank == 4)
            {
                imgBankCard1.Source = new BitmapImage(new Uri("Images/Background/back_purple.png", UriKind.Relative));
            }
            else if (backgroundBank == 5)
            {
                imgBankCard1.Source = new BitmapImage(new Uri("Images/Background/red_back.png", UriKind.Relative));
            }
            else
            {
                imgBankCard1.Source = new BitmapImage(new Uri("Images/Background/yellow_back.png", UriKind.Relative));
            }
            imgBankCard7.Source = imgBankCard1.Source;
            imgBankCard6.Source = imgBankCard1.Source;
            imgBankCard5.Source = imgBankCard1.Source;
            imgBankCard4.Source = imgBankCard1.Source;
            imgBankCard3.Source = imgBankCard1.Source;
            imgBankCard2.Source = imgBankCard1.Source;

            // achtergrond kaarten speler 2 bepalen
            if (backgroundPlayer == 1 && backgroundPlayer != backgroundBank)
            {
                imgPlayerCard1.Source = new BitmapImage(new Uri("Images/Background/back_blue.png", UriKind.Relative));
            }
            else if (backgroundPlayer == 2 && backgroundPlayer != backgroundBank)
            {
                imgPlayerCard1.Source = new BitmapImage(new Uri("Images/Background/back_green.png", UriKind.Relative));
            }
            else if (backgroundPlayer == 3 && backgroundPlayer != backgroundBank)
            {
                imgPlayerCard1.Source = new BitmapImage(new Uri("Images/Background/back_grey.png", UriKind.Relative));
            }
            else if (backgroundPlayer == 4 && backgroundPlayer != backgroundBank)
            {
                imgPlayerCard1.Source = new BitmapImage(new Uri("Images/Background/back_purple.png", UriKind.Relative));
            }
            else if (backgroundPlayer == 5 && backgroundPlayer != backgroundBank)
            {
                imgPlayerCard1.Source = new BitmapImage(new Uri("Images/Background/red_back.png", UriKind.Relative));
            }
            else
            {
                imgPlayerCard1.Source = new BitmapImage(new Uri("Images/Background/yellow_back.png", UriKind.Relative));
            }
            imgPlayerCard7.Source = imgPlayerCard1.Source;
            imgPlayerCard6.Source = imgPlayerCard1.Source;
            imgPlayerCard5.Source = imgPlayerCard1.Source;
            imgPlayerCard4.Source = imgPlayerCard1.Source;
            imgPlayerCard3.Source = imgPlayerCard1.Source;
            imgPlayerCard2.Source = imgPlayerCard1.Source;
        }

        // methode om kaart te genereren
        public void generateCard()
        {
            kaartNr = rnd.Next(1, 52);

            switch (kaartNr)
            {
                // ace
                case 1: kaart = "Images/Foreground/1C.png"; break;
                case 2: kaart = "Images/Foreground/1H.png"; break;
                case 3: kaart = "Images/Foreground/1S.png"; break;
                case 4: kaart = "Images/Foreground/1D.png"; break;
                // 2
                case 5: kaart = "Images/Foreground/2C.png"; break;
                case 6: kaart = "Images/Foreground/2H.png"; break;
                case 7: kaart = "Images/Foreground/2S.png"; break;
                case 8: kaart = "Images/Foreground/2D.png"; break;
                // 3
                case 9: kaart = "Images/Foreground/3C.png"; break;
                case 10: kaart = "Images/Foreground/3H.png"; break;
                case 11: kaart = "Images/Foreground/3S.png"; break;
                case 12: kaart = "Images/Foreground/3D.png"; break;
                // 4
                case 13: kaart = "Images/Foreground/4C.png"; break;
                case 14: kaart = "Images/Foreground/4H.png"; break;
                case 15: kaart = "Images/Foreground/4S.png"; break;
                case 16: kaart = "Images/Foreground/4D.png"; break;
                // 5
                case 17: kaart = "Images/Foreground/5C.png"; break;
                case 18: kaart = "Images/Foreground/5H.png"; break;
                case 19: kaart = "Images/Foreground/5S.png"; break;
                case 20: kaart = "Images/Foreground/5D.png"; break;
                // 6
                case 21: kaart = "Images/Foreground/6C.png"; break;
                case 22: kaart = "Images/Foreground/6H.png"; break;
                case 23: kaart = "Images/Foreground/6S.png"; break;
                case 24: kaart = "Images/Foreground/6D.png"; break;
                // 7
                case 25: kaart = "Images/Foreground/7C.png"; break;
                case 26: kaart = "Images/Foreground/7H.png"; break;
                case 27: kaart = "Images/Foreground/7S.png"; break;
                case 28: kaart = "Images/Foreground/7D.png"; break;
                // 8
                case 29: kaart = "Images/Foreground/8C.png"; break;
                case 30: kaart = "Images/Foreground/8H.png"; break;
                case 31: kaart = "Images/Foreground/8S.png"; break;
                case 32: kaart = "Images/Foreground/8D.png"; break;
                // 9
                case 33: kaart = "Images/Foreground/9C.png"; break;
                case 34: kaart = "Images/Foreground/9H.png"; break;
                case 35: kaart = "Images/Foreground/9S.png"; break;
                case 36: kaart = "Images/Foreground/9D.png"; break;
                // 10
                case 37: kaart = "Images/Foreground/10C.png"; break;
                case 38: kaart = "Images/Foreground/10H.png"; break;
                case 39: kaart = "Images/Foreground/10S.png"; break;
                case 40: kaart = "Images/Foreground/10D.png"; break;
                // jack
                case 41: kaart = "Images/Foreground/11C.png"; break;
                case 42: kaart = "Images/Foreground/11H.png"; break;
                case 43: kaart = "Images/Foreground/11S.png"; break;
                case 44: kaart = "Images/Foreground/11D.png"; break;
                // queen
                case 45: kaart = "Images/Foreground/12C.png"; break;
                case 46: kaart = "Images/Foreground/12H.png"; break;
                case 47: kaart = "Images/Foreground/12S.png"; break;
                case 48: kaart = "Images/Foreground/12D.png"; break;
                // kinh
                case 49: kaart = "Images/Foreground/13C.png"; break;
                case 50: kaart = "Images/Foreground/13H.png"; break;
                case 51: kaart = "Images/Foreground/13S.png"; break;
                case 52: kaart = "Images/Foreground/13D.png"; break;
            }
        }

        private void btnHitMe_Click(object sender, RoutedEventArgs e)
        {
            generateCard();
            switch (kaartNrPlayer)
            {
                case 1: imgPlayerCard1.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 2: imgPlayerCard2.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 3: imgPlayerCard3.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 4: imgPlayerCard4.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 5: imgPlayerCard5.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 6: imgPlayerCard6.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                default: imgPlayerCard7.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
            }
            kaartNrPlayer++;
            if (kaartNr <= 4)
            {
                playerCardValue += 11;
            }
            else if (kaartNr <= 8)
            {
                playerCardValue += 2;
            }
            else if (kaartNr <= 12)
            {
                playerCardValue += 3;
            }
            else if (kaartNr <= 16)
            {
                playerCardValue += 4;
            }
            else if (kaartNr <= 20)
            {
                playerCardValue += 5;
            }
            else if (kaartNr <= 24)
            {
                playerCardValue += 6;
            }
            else if (kaartNr <= 28)
            {
                playerCardValue += 7;
            }
            else if (kaartNr <= 32)
            {
                playerCardValue += 8;
            }
            else if (kaartNr <= 36)
            {
                playerCardValue += 9;
            }
            else if (kaartNr <= 40)
            {
                playerCardValue += 10;
            }
            else if (kaartNr <= 44)
            {
                playerCardValue += 10;
            }
            else if (kaartNr <= 48)
            {
                playerCardValue += 10;
            }
            else if (kaartNr <= 52)
            {
                playerCardValue += 10;
            }

            // score van speler in label invullen
            lblPlayerScore.Content = (playerCardValue);

            // als speler 21 of hoger heeft, stopt het spel
            if (playerCardValue == 21 || playerCardValue > 21)
            {
                btnHitBank.IsEnabled = false;
                btnHitMe.IsEnabled = false;
            }
        }

        private void btnHitBank_Click(object sender, RoutedEventArgs e)
        {
            generateCard();
            switch (kaartNrBank)
            {
                case 1: imgBankCard1.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 2: imgBankCard2.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 3: imgBankCard3.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 4: imgBankCard4.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 5: imgBankCard5.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                case 6: imgBankCard6.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
                default: imgBankCard7.Source = new BitmapImage(new Uri(kaart, UriKind.Relative)); break;
            }
            kaartNrBank++;

            if (kaartNr <= 4)
            {
                bankCardValue += 11;
            }
            else if (kaartNr <= 8)
            {
                bankCardValue += 2;
            }
            else if (kaartNr <= 12)
            {
                bankCardValue += 3;
            }
            else if (kaartNr <= 16)
            {
                bankCardValue += 4;
            }
            else if (kaartNr <= 20)
            {
                bankCardValue += 5;
            }
            else if (kaartNr <= 24)
            {
                bankCardValue += 6;
            }
            else if (kaartNr <= 28)
            {
                bankCardValue += 7;
            }
            else if (kaartNr <= 32)
            {
                bankCardValue += 8;
            }
            else if (kaartNr <= 36)
            {
                bankCardValue += 9;
            }
            else if (kaartNr <= 40)
            {
                bankCardValue += 10;
            }
            else if (kaartNr <= 44)
            {
                bankCardValue += 10;
            }
            else if (kaartNr <= 48)
            {
                bankCardValue += 10;
            }
            else if (kaartNr <= 52)
            {
                bankCardValue += 10;
            }

            // score van bank in label invullen
            lblBankScore.Content = (bankCardValue);

            // als bank 21 of hoger haalt, stopt het spel
            if (bankCardValue == 21 || bankCardValue > 21)
            {
                btnHitBank.IsEnabled = false;
                btnHitMe.IsEnabled = false;
            }
        }

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            generateBackground();
            lblBankScore.Content = "";
            lblPlayerScore.Content = "";

            // score bijhouden
            if (playerCardValue > bankCardValue && playerCardValue <=21)
            {
                playerScore++;
            }
            else if (bankCardValue > playerCardValue && bankCardValue <= 21)
            {
                bankScore++;
            }

            // score weergeven
            lblScore.Content = $"Score {bankScore} - {playerScore}";

            // oorspronkelijke staat van punten en buttons herstellen
            btnHitBank.IsEnabled = true;
            btnHitMe.IsEnabled = true;
            playerCardValue = 0;
            bankCardValue = 0;
            kaartNrPlayer = 1;
            kaartNrBank = 1;

        }
    }
}
