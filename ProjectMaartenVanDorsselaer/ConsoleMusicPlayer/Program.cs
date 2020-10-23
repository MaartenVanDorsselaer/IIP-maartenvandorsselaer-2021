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
            Console.Write("Bestand afspelen: ");

            // banner printen
            Console.WriteLine("MEDIAPLAYER");
            Console.WriteLine("===========");

            WindowsMediaPlayer player = new WindowsMediaPlayer();
            // bestandslocatie opvragen
            Console.Write("Bestandslocatie: ");
            string bestandslocatie = Console.ReadLine() + ".mp3";

            // liedje uit bestandslocatie halen en dit afspelen
            // werkt als je enkel de titel van het liedje ingeeft, want de app gaat automatisch in de "muziek" library zoeken
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            player.URL = System.IO.Path.Combine(musicFolder, bestandslocatie);
            player.controls.play();

            Console.ReadLine();
            
        }
    }
}
