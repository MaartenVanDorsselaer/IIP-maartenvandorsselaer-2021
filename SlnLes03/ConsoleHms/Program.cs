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
            int totaal = Convert.ToInt32(totaalSeconden);

            // uur, minuten, seconden berekenen
            int uur = totaal / 3600;
            int rest = totaal % 3600;
            int minuten = rest / 60;
            int seconden = rest % 60;

            // antwoord weergeven
            Console.WriteLine("Omgezet in hms formaat: {0} : {1} : {2}", uur, minuten, seconden);
            Console.ReadLine();
        }
    }
}
