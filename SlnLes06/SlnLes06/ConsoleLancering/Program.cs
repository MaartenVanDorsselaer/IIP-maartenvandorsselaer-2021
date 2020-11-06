using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalSeconden;
            Console.Write("Hoeveel seconden tot lancering? ");
            aantalSeconden = Convert.ToInt32(Console.ReadLine());

            for (int seconden = aantalSeconden; seconden > 0; seconden--)
            {
                Console.WriteLine($"{seconden}..");
            }
            Console.WriteLine("Lift off!");
            Console.ReadLine();
        }
    }
}
