using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGGD
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            int getal2; 
            Console.WriteLine("BEREKEN GROOTST GEMENE DELER");
            Console.WriteLine("============================");

            Console.Write("Getal 1: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToInt32(Console.ReadLine());

            while (getal1 != getal2)
            {
                if (getal1 > getal2)
                {
                    getal1 -= getal2;
                }
                else
                {
                    getal2 -= getal1;
                }
            }

            Console.WriteLine($"De grootste gemene deler is: {getal1}");
            Console.ReadLine();
        }
    }
}
