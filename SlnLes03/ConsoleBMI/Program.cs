using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // heading printen
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            // lengte vragen
            Console.Write("Lengte (in cm): ");

            // lengte inlezen en in string steken
            string antwoord1 = Console.ReadLine();

            // string omzetten in een double om straks in de berekening te kunnen gebruiken
            double lengte = Convert.ToDouble(antwoord1)/100;

            // gewicht opvragen
            Console.Write("Gewicht (in kg): ");

            // gewicht in string steken
            string antwoord2 = Console.ReadLine();

            // string omzetten in double om mee te rekenen
            double gewicht = Convert.ToDouble(antwoord2);

            // bmi berekenen en afronden op 1 cijfer na de komma
            double bmi = Math.Round(gewicht / (lengte * lengte), 1);
            Console.Write("Je BMI bedraagt: " + bmi);
            Console.ReadKey();
        }
    }
}
