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
            string antwoord;
            int volume;
            int mute = 1;

            Console.Write("Bestand afspelen: ");

            // banner printen
            Console.WriteLine("MEDIAPLAYER");
            Console.WriteLine("===========");

            WindowsMediaPlayer player = new WindowsMediaPlayer();
            // bestandslocatie opvragen
            Console.Write("Titel: ");
            string bestandslocatie = Console.ReadLine() + ".mp3";
            play++;

            // liedje uit bestandslocatie halen
            // werkt als je enkel de titel van het liedje ingeeft, want de app gaat automatisch in de "muziek" library zoeken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            player.URL = System.IO.Path.Combine(musicFolder, bestandslocatie);

            // menu opstellen + functies  overeenkomstig aan menu opties instellen
            do
            {
                Console.WriteLine(@"a. Pauze/Play
b. Wijzig volume
c. Volume dempen/dempen opheffen
d. Liedje afspelen
e. Stoppen met het afspelen van het huidige liedje
f. Sluit de applicatie af");
                Console.Write("Jouw keuze: ");
                antwoord = Console.ReadLine();
                if (antwoord == "a")
                {
                    if (play == 0)
                    {

                        player.controls.play();
                        play++;
                    }
                    else
                    {
                        player.controls.pause();
                        play--;
                    }
                    Console.Clear();
                }
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
                            player.settings.volume = volume;
                            Console.Clear();
                        }
                    } while (volume < 1 || volume > 100);
                }
                else if (antwoord == "c") {
                    if (mute == 1)
                    {
                        player.settings.mute = true;
                        mute--;
                    }
                    else
                    {
                        player.settings.mute = false;
                        mute++;
                    }
                    Console.Clear();
                }
                else if (antwoord == "d")
                {
                    Console.Write("Titel: ");
                    bestandslocatie = Console.ReadLine() + ".mp3";
                    musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                    player.URL = System.IO.Path.Combine(musicFolder, bestandslocatie);
                    Console.Clear();
                }
                else if (antwoord == "e")
                {
                    player.controls.stop();
                    Console.Clear();
                }
                else if (antwoord == "f")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Onjuiste input");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (antwoord != "f");
        }
    }               
}
