using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int getal = rnd.Next(1, 10);
            int aantalPogingen = 1;
            int poging;
            Console.WriteLine("Raad een getal tussen 1 en 10");
            do
            {
                Console.Write($"Poging {aantalPogingen}: ");
                poging = Convert.ToInt32(Console.ReadLine());
                aantalPogingen++;
            } while (aantalPogingen < 4 && getal != poging);
            if (aantalPogingen <= 3 && getal == poging)
            {
                Console.WriteLine("Geraden!");
            }
            else
            {
                Console.WriteLine("Volgende keer beter");
            }

            Console.ReadLine();
            
        }
    }
}
