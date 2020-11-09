using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTemperatuur
{
    class Program
    {
        // celsius omzetten naar fahrenheit
        private static double CelsiusToFahrenheit(double graden)
        {
            double omzetting = graden*1.8 + 32;
            return omzetting;
        }
        // fahrenheit omzetten naar celsius
        private static double FahrenheitToCelsius(double graden)
        {
            double omzetting = (graden-32) / 1.8;
            return omzetting;
        }
        // celsius omzetten naar kelvin
        private static double CelsiusToKelvin(double graden)
        {
            double omzetting = graden+273.15;
            return omzetting;
        }
        // kelvin omzetten naar celsius
        private static double KelvinToCelsius(double graden)
        {
            double omzetting = graden-273.15;
            return omzetting;
        }
        static void Main(string[] args)
        {
            // variabelen aanmaken
            double omzetting;
            double graden;
            string keuze;
            // banner
            Console.WriteLine("TEMPERATUURCONVERSIE");
            Console.WriteLine("====================");
            
            do
            {
                // menu weergeven
                Console.WriteLine(@"a. Celsius naar Fahrenheit
b. Fahrenheit naar Celsius
c. Celsius naar Kelvin
d. Kelvin naar Celsius
x. Afsluiten" + Environment.NewLine);
                Console.Write("Maak je keuze: ");
                keuze = Console.ReadLine();
                // juiste methode aanspreken per keuze + antwoord weergeven
                if (keuze == "a")
                {
                    Console.Write("Celsius: ");
                    graden = Convert.ToDouble(Console.ReadLine());
                    omzetting = CelsiusToFahrenheit(graden);
                    Console.WriteLine($"Fahrenheit: {omzetting}");
                }
                else if (keuze == "b")
                {
                    Console.Write("Fahrenheit: ");
                    graden = Convert.ToDouble(Console.ReadLine());
                    omzetting = FahrenheitToCelsius(graden);
                    Console.WriteLine($"Celsius: {omzetting}");
                }
                else if (keuze == "c")
                {
                    Console.Write("Celsius: ");
                    graden = Convert.ToDouble(Console.ReadLine());
                    omzetting = CelsiusToKelvin(graden);
                    Console.WriteLine($"Kelvin: {omzetting}");
                }
                else if (keuze == "d")
                {
                    Console.Write("Kelvin: ");
                    graden = Convert.ToDouble(Console.ReadLine());
                    omzetting = KelvinToCelsius(graden);
                    Console.WriteLine($"Celsius: {omzetting}");
                }
                Console.ReadLine();
                Console.Clear();
            } while (keuze != "x");
        }
    }
}
