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
            string letter = Console.ReadLine().ToLower();

            // string in een int steken en dit weergeven ---- geeft hier telkens een "exception not handled" bericht
            int number = Convert.ToInt32(letter);
            Console.WriteLine("Het nummer is " + number);

            // letter omzetten in hoofdletter en dit weergeven
            Console.WriteLine("De hoofdletter is " + letter.ToUpper());

            // vorige letter printen ---- geeft hier telkens een "exception not handled" bericht
            int previousNumber = Convert.ToInt32(letter) - 1;
            string vorigeLetter = Convert.ToString(previousNumber);
            Console.WriteLine("De vorige letter is " + vorigeLetter);

            // volgende letter printen ---- geeft hier telkens een "exception not handled" bericht
            int nextNumber = Convert.ToInt32(letter) + 1;
            string volgendeLetter = Convert.ToString(nextNumber);
            Console.WriteLine("De volgende letter is " + volgendeLetter);

            // ervoor zorgen dat de console niet meteen afsluit
            Console.ReadLine();
        }
    }
}
