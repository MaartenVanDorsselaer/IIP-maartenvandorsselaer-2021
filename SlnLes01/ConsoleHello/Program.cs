using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hoe heet je? ");
            string name = Console.ReadLine();
            Console.Write("Aangename kennismaking, ");
            Console.WriteLine(name);
            Console.WriteLine("druk op een toets om verder te gaan...");
            Console.ReadKey();
        }
    }
}
