using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int som = 0;
            do
            {
                Console.Write("Voer een getal in (q om te stoppen) ");
                getal = Convert.ToInt32(Console.ReadLine());
                som += getal;
            } while (Console.ReadLine() != "q");

            Console.WriteLine($"De som is: {som}");
            Console.ReadLine();
        }
    }
}
