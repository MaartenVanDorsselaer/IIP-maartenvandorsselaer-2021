using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaalBedrag = 500;
            string keuze;
            Console.WriteLine("Bankautomaat");
            Console.WriteLine("============");
            Console.WriteLine();

            do
            {
                Console.WriteLine(@"a. afhaling
b. storting
c. stoppen");
                Console.Write("Je keuze: ");
                keuze = Console.ReadLine();
                Console.WriteLine();

                if (keuze == "a")
                {
                    Console.Write("Welk bedrag wil je afhalen: ");
                    int bedrag = Convert.ToInt32(Console.ReadLine());
                    totaalBedrag -= bedrag;
                    Console.WriteLine($"Afhaling ok - het nieuwe saldo is {totaalBedrag}");
                    Console.WriteLine();
                }
                else if (keuze == "b")
                {
                    Console.Write("Welk bedrag wil je storten: ");
                    int bedrag = Convert.ToInt32(Console.ReadLine());
                    totaalBedrag += bedrag;
                    Console.WriteLine($"Storting ok - het nieuwe saldo is {totaalBedrag}");
                    Console.WriteLine();
                }
                else if (keuze == "c")
                {
                    Console.WriteLine("Bedankt en tot ziens.");
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze");
                    Console.WriteLine();

                }
            } while (keuze != "c");
            Console.ReadLine();
        }
    }
}
