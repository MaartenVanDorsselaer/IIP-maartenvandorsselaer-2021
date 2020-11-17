using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace ConsoleMusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabelen aanmaken
            int play = 0;
            int nummer = 0;
            string antwoord, keuze;
            int volume;
            int mute = 1;
            List<string> afspeellijst = new List<String>();
            string bestandslocatie = "";
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            // menu opstellen + functies  overeenkomstig aan menu opties instellen
            do
            {
                // banner printen
                Console.Write("Bestand afspelen: ");
                Console.WriteLine("MEDIAPLAYER");
                Console.WriteLine("=============================");

                if (nummer != 0)
                {
                    // manier van artist en titel uit bestand halen opgezocht
                    string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                    WMPLib.IWMPMedia song = player.newMedia($"{musicFolder} {bestandslocatie}");
                    string artist = song.getItemInfo("Atist");
                    string titel = song.getItemInfo("Title");
                    // artist en titel op verschillende lijnen weergeven
                    Console.WriteLine($"Artist: {artist} " + Environment.NewLine + $"Titel: {titel}");
                }
                // menu
                Console.WriteLine(@"a. Play/Pauze
b. Wijzig volume
c. Volume dempen/dempen opheffen
d. Beheer afspeellijst
e. Stoppen met het afspelen van het huidige liedje
f. Sluit de applicatie af");
                Console.Write("Jouw keuze: ");
                antwoord = Console.ReadLine();
                // liedje afspelen/pauzeren/hervatten
                if (antwoord == "a")
                {
                    if (afspeellijst.Count == 0)
                    {
                        Console.WriteLine("De afspeellijst is nog leeg");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (afspeellijst.Count == 1)
                    {
                        bestandslocatie = afspeellijst[0] + ".mp3";
                        nummer = 1;
                        PlaySong(bestandslocatie, player);
                    }
                    else
                    {
                        if (play == 0)
                        {
                            // bestandslocatie opvragen
                            Console.Write("Nummer van het liedje in de afspeellijst: ");
                            nummer = Convert.ToInt32(Console.ReadLine());
                            bestandslocatie = afspeellijst[nummer - 1] + ".mp3";
                            PlaySong(bestandslocatie, player);
                            play++;
                        }
                        else if (play == 1)
                        {
                            PauseSong(player);
                            play++;
                        }
                        else
                        {
                            ResumeSong(player);
                            play--;
                        }
                    }
                    Console.Clear();
                }
                // volume instellen
                else if (antwoord == "b")
                {
                    do
                    {
                        Console.Write("Geef een volume in tussen 1 en 100: ");
                        volume = Convert.ToInt32(Console.ReadLine());
                        if (volume < 1 || volume > 100)
                        {
                            Console.WriteLine("Ongeldig volume");
                        }
                        else
                        {
                            ChangeVolume(volume, player);
                            Console.Clear();
                        }
                    } while (volume < 1 || volume > 100);
                }
                // geluid (un)muten
                else if (antwoord == "c")
                {
                    MuteSong(mute, player);
                    if (mute == 1)
                    {
                        mute--;
                    }
                    else
                    {
                        mute++;
                    }
                    Console.Clear();
                }
                // afspeellijst beheren
                else if (antwoord == "d")
                {
                    Console.Clear();
                    Console.Write(@"a. Overzicht van afspeellijst
b. Liedje aan afspeellijst toevoegen
c. Liedje uit afspeellijst verwijderen
d. 2 liedjes van plaats verwisselen in de afspeellijst
e. Speel liedje af
f. Vorig liedje
g. Volgend liedje
h. Terug

Jouw keuze: ");
                    keuze = Console.ReadLine();
                    // overzicht van de afspeellijst weergeven
                    if (keuze == "a")
                    {
                        if (afspeellijst.Count == 0)
                        {
                            Console.WriteLine("Er zijn nog geen liedjes toegevoegd aan de afspeellijst");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Afspeellijst: ");
                            int i = 1;
                            foreach (string liedje in afspeellijst)
                            {
                                // huidig liedje in andere kleur tonen
                                if (i == nummer)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                Console.WriteLine($"{i} {liedje}");
                                i++;
                                // tekstkleur van de console resetten
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.ReadLine();
                        }
                        Console.Clear();
                    }
                    // liedje aan afspeellijst toevoegen
                    else if (keuze == "b")
                    {
                        Console.Write("Titel:");
                        string titel = Console.ReadLine();
                        AddSong(titel, afspeellijst);
                        Console.Clear();
                    }
                    // liedje uit afspeellijst verwijderen
                    else if (keuze == "c")
                    {
                        Console.Write("Titel van het te verwijderen liedje:");
                        string titel = Console.ReadLine();
                        RemoveSong(titel, afspeellijst);
                        Console.Clear();
                    }
                    // 2 liedjes van plaats verwisselen in afspeellijst
                    else if (keuze == "d")
                    {
                        Console.Write("Nummer van het eerste liedje:");
                        int eersteLiedje = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nummer van het tweede liedje:");
                        int tweedeLiedje = Convert.ToInt32(Console.ReadLine());
                        SwapSongs(eersteLiedje, tweedeLiedje, afspeellijst);
                        Console.Clear();
                    }
                    // speel liedje af
                    else if (keuze == "e")
                    {
                        if (play == 0)
                        {
                            // bestandslocatie opvragen
                            Console.Write("Nummer van het liedje in de afspeellijst: ");
                            nummer = Convert.ToInt32(Console.ReadLine());
                            bestandslocatie = afspeellijst[nummer - 1] + ".mp3";
                            PlaySong(bestandslocatie, player);
                            play++;
                        }
                        else if (play == 1)
                        {
                            PauseSong(player);
                            play++;
                        }
                        else
                        {
                            ResumeSong(player);
                            play--;
                        }
                        Console.Clear();
                    }
                    // vorig liedje
                    else if (keuze == "f")
                    {
                        // als nummer = 0 wordt er op dit moment geen liedje afgespeeld, als nummer == 1, wordt het eerste liedje afgespeeld
                        if (nummer <= 1)
                        {
                            Console.WriteLine("Kan vorig liedje niet afspelen. ");
                            Console.ReadLine();
                        }
                        else
                        {
                            bestandslocatie = afspeellijst[nummer - 2] + ".mp3";
                            nummer--;
                            PlaySong(bestandslocatie, player);
                        }
                        Console.Clear();
                    }
                    // volgend liedje
                    else if (keuze == "g")
                    {
                        // als nummer = afspeellijst.count, wordt op dit moment het laatste liedje afgespeeld
                        if (nummer == afspeellijst.Count)
                        {
                            Console.WriteLine("Kan volgend liedje niet afspelen. ");
                            Console.ReadLine();
                        }
                        else
                        {
                            bestandslocatie = afspeellijst[nummer] + ".mp3";
                            nummer++;
                            PlaySong(bestandslocatie, player);
                        }
                        Console.Clear();
                    }
                    // terug
                    else if (keuze == "h")
                    {
                        break;
                    }
                }
                // liedje stoppen
                else if (antwoord == "e")
                {
                    StopSong(player);
                    play = 0;
                    Console.Clear();
                }
                // console sluiten
                else if (antwoord == "f")
                {
                    break;
                }
                // foutmelding
                else
                {
                    Console.WriteLine("Onjuiste input");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (antwoord != "f");
        }
        // liedje afspelen
        public static void PlaySong(string bestandslocatie, WindowsMediaPlayer player)
        {
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            player.URL = System.IO.Path.Combine(musicFolder, bestandslocatie);
            player.controls.play();
        }
        // liedje pauzeren
        public static void PauseSong(WindowsMediaPlayer player)
        {
            player.controls.pause();
        }
        // liedje hervatten
        public static void ResumeSong(WindowsMediaPlayer player)
        {
            player.controls.play();
        }
        // volume veranderen
        public static void ChangeVolume(int volume, WindowsMediaPlayer player)
        {
            player.settings.volume = volume;
        }
        // liedje (un)muten
        public static void MuteSong(int mute, WindowsMediaPlayer player)
        {
            if (mute == 1)
            {
                player.settings.mute = true;
            }
            else
            {
                player.settings.mute = false;
            }
        }
        // liedje toevoegen aan afspeellijst
        public static List<String> AddSong(string titel, List<String> afspeellijst)
        {
            afspeellijst.Add($"{titel}");
            return afspeellijst;
        }
        // liedje verwijderen uit afspeellijst
        public static List<String> RemoveSong(string titel, List<String> afspeellijst)
        {
            afspeellijst.Remove($"{titel}");
            return afspeellijst;
        }
        // 2 liedjes van plaats verwisselen
        public static List<String> SwapSongs(int eersteLiedje, int tweedeLiedje, List<String> afspeellijst)
        {
            string temp = afspeellijst[eersteLiedje - 1];
            afspeellijst[eersteLiedje - 1] = afspeellijst[tweedeLiedje - 1];
            afspeellijst[tweedeLiedje - 1] = temp;
            return afspeellijst;
        }
        // liedje stoppen
        public static void StopSong(WindowsMediaPlayer player)
        {
            player.controls.stop();
        }
    }
}
