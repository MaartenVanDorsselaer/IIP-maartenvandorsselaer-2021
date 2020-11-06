using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnderBoven
{
    class Program
    {
        static void Main(string[] args)
        {
            // onder en bovengrens opvragen en in een variabele steken
            Console.Write("Geef een ondergrens: ");
            int ondergrens = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een bovengrens: ");
            int bovengrens= Convert.ToInt32(Console.ReadLine());

            while (bovengrens < ondergrens || bovengrens == ondergrens)
            {
                Console.Write("Bovengrens mag niet kleiner of gelijk zijn aan ondergrens. Geef een bovengrens: ");
                bovengrens = Convert.ToInt32(Console.ReadLine());
            }
            if (ondergrens < 0)
            {
                Console.Write("Ondergrens mag niet lager zijn dan 0. Geef een ondergrens: ");
                ondergrens = Convert.ToInt32(Console.ReadLine());
            }
            else if(bovengrens > 100)
            {
                Console.Write("Bovengrens mag niet hoger zijn dan 100. Geef een bovengrens: ");
                bovengrens = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Bereik: van {ondergrens} tot {bovengrens} ");
            Console.Read();

        }
    }
}
