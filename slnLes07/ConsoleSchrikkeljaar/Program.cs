using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSchrikkeljaar
{
    class Program
    {
        static private string Schrikkeljaar(int jaartal)
        {
            // variabele om antwoord in op te slaan
            string antwoord="";
            // controleren of het een schrikkeljaar is of niet
            if (jaartal % 4 == 0)
            {
                if (jaartal % 100 == 0)
                {
                    if (jaartal % 400 == 0)
                    {
                        antwoord += "een";
                    }
                    else
                    {
                        antwoord += "géén";
                    }
                }
                else
                {
                    antwoord += "een";
                }
            }
            // antwoord naar main sturen
            return antwoord;
        }
        static void Main(string[] args)
        {
            // variabele
            int jaartal;
            // header
            Console.WriteLine("SCHRIKKELJAAR");
            Console.WriteLine("=============");
            do
            {
                // jaartal inlezen, in een variabele steken, doorsturen naar methode en met antwoord van methode de output bepalen
                Console.Write("Geef een jaartal: ");
                jaartal = Convert.ToInt32(Console.ReadLine());
                string antwoord = Schrikkeljaar(jaartal);
                Console.WriteLine($"Het jaartal {jaartal} is {antwoord} schrikkeljaar");

            }
            // stopconditie
            while (jaartal >0);

        }
    }
}
