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
using WMPLib;

namespace WpfMusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }

        // event handlers
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // titel toevoegen aan listbox
            ListBoxItem song = new ListBoxItem();
            song.Content = txtTitel.Text;
            lbxAfspeellijst.Items.Add(song);
            txtTitel.Text = "";
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // liedje verwijderd uit afspeellijst
            lbxAfspeellijst.Items.RemoveAt(lbxAfspeellijst.Items.IndexOf(lbxAfspeellijst.SelectedItem));
        }

        public void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedItem = (ListBoxItem)lbxAfspeellijst.SelectedItem;
            if (selectedItem.Content != null)
            {
                string bestandslocatie = $"{selectedItem.Content}.mp3";
                Button btn = (Button)sender;
                // als op play geklikt wordt wordt nieuw liedje afgespeeld
                if ((string)btn.Content == "PLAY")
                {
                    PlaySong(bestandslocatie);
                }
                else if ((string)btn.Name == "btnPauze")
                {
                    // als liedje bezig is met afspelen, wordt het gepauzeerd
                    if ((string)btn.Content == "PAUSE")
                    {
                        PauseSong();
                        btn.Content = "RESUME";
                    }
                    // als liedje gepauzeerd is, wordt het verder afgespeeld
                    else if ((string)btn.Content == "RESUME")
                    {
                        ResumeSong();
                        btn.Content = "PAUSE";
                    }
                }
                // afspelen stoppen
                else if ((string)btn.Content == "STOP")
                {
                    StopSong();
                }
            }
        }
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            string bestandslocatie;
            ListBoxItem selectedItem = (ListBoxItem)lbxAfspeellijst.SelectedItem;
            Button btn = (Button)sender;
            // vorig liedje laten afspelen
            if ((selectedItem.TabIndex >= 1) && ((string)btn.Content == "PREVIOUS"))
            {
                for (int i = 0; i < lbxAfspeellijst.Items.Count; i++)
                {
                    ListBoxItem item = (ListBoxItem)lbxAfspeellijst.Items.GetItemAt(i);
                    if (item.IsSelected == true)
                    {
                        ListBoxItem newItem = (ListBoxItem)lbxAfspeellijst.Items.GetItemAt(i-1);
                        newItem.IsSelected = true;
                        string vorigLiedje = (string)newItem.Content;
                        bestandslocatie = $"{vorigLiedje}.mp3";
                        PlaySong(bestandslocatie);
                        break;
                    }
                }
            }
            // volgend liedje laten afspelen
            else if (((string)btn.Content == "NEXT"))
            {
                for (int i = lbxAfspeellijst.Items.Count - 1; i >= 0; i--)
                {
                    ListBoxItem item = (ListBoxItem)lbxAfspeellijst.Items.GetItemAt(i);
                    if (item.IsSelected == true)
                    {
                        ListBoxItem newItem = (ListBoxItem)lbxAfspeellijst.Items.GetItemAt(i + 1);
                        newItem.IsSelected = true;
                        string vorigLiedje = (string)newItem.Content;
                        bestandslocatie = $"{vorigLiedje}.mp3";
                        PlaySong(bestandslocatie);
                        break;
                    }
                }
            }
        }
        // volume aanpassen dmv slider
        private void sldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblVolume.Content = $"{sldVolume.Value} %";
            ChangeVolume(Convert.ToInt32(sldVolume.Value));
        }
        private void btnMute_Click(object sender, RoutedEventArgs e)
        {
            // geluid muten
            if ((string)btnMute.Content == "MUTE")
            {
                Mute();
                btnMute.Content = "UNMUTE";
            }
            // geluid unmuten
            else if((string)btnMute.Content == "UNMUTE")
            {
                UnMute();
                btnMute.Content = "MUTE";
            }
        }
        // liedje starten op dubbelklik
        private void lbxAfspeellijst_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem selectedItem = (ListBoxItem)lbxAfspeellijst.SelectedItem;
            string bestandslocatie = $"{selectedItem.Content}.mp3";
            PlaySong(bestandslocatie);
        }

        // liedje naar boven of beneden in de afspeellijst verplaatsen
        private void btnMoveUp_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if((string)btn.Content == "Move Up")
            {
                MoveItem(-1);
            }
            else if ((string)btn.Content == "Move Down")
            {
                MoveItem(+1);
            }
        }
        // skin updaten
        private void cbxSkin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSkin(cbxSkin.SelectedIndex);
        }

        // methodes

        // liedje afspelen
        private void PlaySong(string bestandslocatie)
        {
            // als ik  background kies, gebeurt er niets
            // de code moet hier staan, als het staat in de selection_changed event van de textbox, verandert de kleur al wanneer je selecteert
            // maar nog niet op play hebt gedrukt
            foreach (ListBoxItem item in lbxAfspeellijst.Items)
            {
                if (item.IsSelected == true)
                {
                    // letterkleur van selectie aanpassen
                    item.Foreground = Brushes.Red;
                    string content = Convert.ToString(item.Content);
                    string artist="Onbekende Artist";
                    string titel= content;
                    if (content.Contains("-"))
                    {
                        artist = "";
                        titel = "";
                        for (int i = 0; i < content.Length; i++)
                        {
                            char c = Convert.ToChar(content[i]);
                            if (c != '-')
                            {
                                artist += c;
                            }
                            else if (c == '-')
                            {
                                for (int n = i+1; n < content.Length; n++)
                                {
                                    char k = Convert.ToChar(content[n]);
                                    titel += k;
                                }
                                break;
                            }
                        }
                    }
                    lblHuidigeTitel.Content = titel;
                    lblHuidigeArtist.Content = artist;
                }
                // letterkleur aanpassen wanneer selectie veranderd is
                if (item.IsSelected == false)
                {
                    item.Foreground = Brushes.Black;
                }
            }
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            player.URL = System.IO.Path.Combine(musicFolder, bestandslocatie);
            player.controls.play();
        }
        // liedje pauzeren
        private void PauseSong()
        {
            player.controls.pause();
        }
        // liedje hervatten
        private void ResumeSong()
        {
            player.controls.play();
        }
        // afspelen stoppen
        private void StopSong()
        {
            player.controls.stop();
        }
        // volume wijzigen
        private void ChangeVolume(int volume)
        {
            player.settings.volume = volume;
        }
        // geluid muten
        private void Mute()
        {
            player.settings.mute = true;
        }
        // geluid unmuten
        private void UnMute()
        {
            player.settings.mute = false;
        }
        // volgorde veranderen
        private void MoveItem(int move)
        {
            // nieuwe index bepalen
            int newIndex = lbxAfspeellijst.SelectedIndex + move;
            // liedje opslaan in object
            object liedje = lbxAfspeellijst.SelectedItem;
            // origineel liedje verwijderen
            lbxAfspeellijst.Items.Remove(liedje);
            // huidig object op nieuwe index plaatsen
            lbxAfspeellijst.Items.Insert(newIndex, liedje);
        }
        // kleuren aanpassen
        private void UpdateSkin(int skin)
        {
            if (skin == 0)
            {
                lblHuidigeArtist.Background = Brushes.Beige;
                lblHuidigeTitel.Background = Brushes.Beige;
                lblVolume.Background = Brushes.Beige;
                lbxAfspeellijst.Background = Brushes.Beige;
                btnAdd.Background = Brushes.Beige;
                btnMoveDown.Background = Brushes.Beige;
                btnMoveUp.Background = Brushes.Beige;
                btnMute.Background = Brushes.Beige;
                btnNext.Background = Brushes.Beige;
                btnPauze.Background = Brushes.Beige;
                btnPlay.Background = Brushes.Beige;
                btnPrevious.Background = Brushes.Beige;
                btnRemove.Background = Brushes.Beige;
                btnStop.Background = Brushes.Beige;
                cbxSkin.Background = Brushes.Beige;
                Background = Brushes.Bisque;
            }
            else if (skin == 1)
            {
                lblHuidigeArtist.Background = Brushes.DarkGray;
                lblHuidigeTitel.Background = Brushes.DarkGray;
                lblVolume.Background = Brushes.DarkGray;
                lbxAfspeellijst.Background = Brushes.DarkGray;
                btnAdd.Background = Brushes.LightBlue;
                btnMoveDown.Background = Brushes.LightBlue;
                btnMoveUp.Background = Brushes.LightBlue;
                btnMute.Background = Brushes.LightBlue;
                btnNext.Background = Brushes.LightBlue;
                btnPauze.Background = Brushes.LightBlue;
                btnPlay.Background = Brushes.LightBlue;
                btnPrevious.Background = Brushes.LightBlue;
                btnRemove.Background = Brushes.LightBlue;
                btnStop.Background = Brushes.LightBlue;
                cbxSkin.Background = Brushes.LightBlue;
                Background = Brushes.CadetBlue;
            }
            else if (skin == 2)
            {
                lblHuidigeArtist.Background = Brushes.White;
                lblHuidigeTitel.Background = Brushes.White;
                lblVolume.Background = Brushes.White;
                lbxAfspeellijst.Background = Brushes.White;
                btnAdd.Background = Brushes.LightGray;
                btnMoveDown.Background = Brushes.LightGray;
                btnMoveUp.Background = Brushes.LightGray;
                btnMute.Background = Brushes.LightGray;
                btnNext.Background = Brushes.LightGray;
                btnPauze.Background = Brushes.LightGray;
                btnPlay.Background = Brushes.LightGray;
                btnPrevious.Background = Brushes.LightGray;
                btnRemove.Background = Brushes.LightGray;
                btnStop.Background = Brushes.LightGray;
                cbxSkin.Background = Brushes.LightGray;
                Background = Brushes.White;
            }
        }

    }
}
