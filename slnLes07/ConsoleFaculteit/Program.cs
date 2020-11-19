using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    class Program
    {
        static private int VraagPositiefGetal()
        {
            // getal opvragen
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;
        }

        static private int Faculteit (int n)
        {
            // variabele aanmaken om terug te kunnen geven aan main
            int faculteit = n;
            // faculteit berekenen
            for (int i=1; i<n; i++)
            {
                int nieuwGetal = n - i;
                faculteit *= nieuwGetal;
            }
            return faculteit;
        }
        static void Main(string[] args)
        {
            // header
            Console.WriteLine("FACULTEIT BEREKENEN" + Environment.NewLine);
            // getal opvragen
            int getal = VraagPositiefGetal();
            // getal meegeven aan faculteit om dan faculteit te berekenen
            int totaalfaculteit = Faculteit(getal);
            // resultaat weergeven
            Console.WriteLine($" De faculteit is {totaalfaculteit}");
            Console.ReadLine();

        }
    }
}
