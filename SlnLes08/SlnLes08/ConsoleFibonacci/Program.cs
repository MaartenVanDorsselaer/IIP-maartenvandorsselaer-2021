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
            int n1 = 1, n2 = 1, nextFibonacci;
            Console.Write("Hoeveel Fibonacci getallen wil je afdrukken: ");
            int aantalFibonacci = Convert.ToInt32(Console.ReadLine());
            List <int> fibonacci = new List <int> (aantalFibonacci) { 1, 1 };
            for (int i = 2; i < aantalFibonacci; i++)
            {
                nextFibonacci = n1 + n2;
                n1 = n2;
                n2 = nextFibonacci;
                fibonacci.Add(nextFibonacci); 
            }
            Console.Write($"Eerste {aantalFibonacci} Fibonacci getallen: ");
            foreach (object o in fibonacci)
            {
                Console.Write(o + " ");
            }
            Console.ReadLine();
        }
    }
}
