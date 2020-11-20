using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabelen aanmaken
            int n1 = 1, n2 = 1, nextFibonacci;
            // aantal getallen opvragen
            Console.Write("Hoeveel Fibonacci getallen wil je afdrukken: ");
            int aantalFibonacci = Convert.ToInt32(Console.ReadLine());
            // fibonacci lijst aanmaken en eerste 2 keer 1 schrijven, de rest wordt via loop toegevoegd
            List <int> fibonacci = new List <int> (aantalFibonacci) { 1, 1 };
            // fibonacci lijst vergroten + opvullen
            for (int i = 2; i < aantalFibonacci; i++)
            {
                nextFibonacci = n1 + n2;
                n1 = n2;
                n2 = nextFibonacci;
                fibonacci.Add(nextFibonacci); 
            }
            // lijst printen
            Console.Write($"Eerste {aantalFibonacci} Fibonacci getallen: ");
            foreach (object o in fibonacci)
            {
                Console.Write(o + " ");
            }
            Console.ReadLine();
        }
    }
}
