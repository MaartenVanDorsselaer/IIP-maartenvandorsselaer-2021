using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakter
{
    class Program
    {
        static void Main(string[] args)
        {
            // letter opvragen
            Console.Write("Geef een kleine letter: ");

            // letter in een string zetten
            string letter = Console.ReadLine();

            // string in een int steken end it weergeven ---- geeft hier telkens een "exception not handled" bericht
            double number = Convert.ToInt32(letter);
            Console.WriteLine("Het nummer is " + number);

            // letter omzetten in hoofdletter en dit weergeven
            // string ucLetter = letter.ToUpper();
            Console.WriteLine("De hoofdletter is " + letter.ToUpper());

            // vorige letter printen
            double previousNumber = Convert.ToInt32(letter) - 1;
            string vorigeLetter = Convert.ToString(previousNumber);
            Console.WriteLine("De vorige letter is " + vorigeLetter);

            // volgende letter printen
            double nextNumber = Convert.ToInt32(letter) + 1;
            string volgendeLetter = Convert.ToString(nextNumber);
            Console.WriteLine("De volgende letter is " + volgendeLetter);

            // ervoor zorgen dat de console niet meteen afsluit
            Console.ReadLine();
        }
    }
}
