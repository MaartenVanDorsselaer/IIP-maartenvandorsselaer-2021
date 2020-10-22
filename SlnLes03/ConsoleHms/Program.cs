using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHms
{
    class Program
    {
        static void Main(string[] args)
        {
            // vraag het aantal seconden
            Console.Write("Geef het aantal seconden: ");

            // lees de seconden in en zet ze om in een getal
            string totaalSeconden = Console.ReadLine();
            int seconden = Convert.ToInt32(totaalSeconden);

            // uur, minuten, seconden berekenen
            int uur = seconden / 60;
            int minuten = seconden % 60;
            int rest = seconden % uur % minuten;

            // antwoord weergeven
            Console.WriteLine("Omgezet in hms formaat: {0} : {1} : {2}", uur, minuten, rest);
            Console.ReadLine();
        }
    }
}
