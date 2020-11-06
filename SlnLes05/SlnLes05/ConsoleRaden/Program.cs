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
            // getal inlezen en in variabele stoppen
            Console.Write("Raad een getal tussen 1 en 10: ");
            int gok = Convert.ToInt32(Console.ReadLine());

            // random getal genereren
            Random rnd = new Random();
            int randomGetal = rnd.Next(1, 10);

            // gok gaan vergelijken met het random getal en gepast reageren
            if (gok == randomGetal)
            {
                Console.WriteLine("Proficiat, je hebt het getal geraden");
            }
            else if(gok < randomGetal)
            {
                Console.WriteLine("Je gok was te laag");
            }
            else
            {
                Console.WriteLine("Je gok was te hoog");
            }

            Console.ReadLine();
        }
    }
}
