using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabele aanmaken
            string grade;
            double herrekendExamen;
            // banner weergeven
            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("=====================");
            Console.WriteLine();

            // cijfers opvragen en in variabele steken
            Console.Write("Geef het cijfer dagelijks werk (op 20): ");
            double dagelijksWerk = Convert.ToDouble (Console.ReadLine());
            Console.Write("Geef het cijfer op het project (op 20): ");
            double project = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het examen (op 20): ");
            double examen = Convert.ToDouble(Console.ReadLine());

            // lege lijn printen
            Console.WriteLine();

            // punten herrekenen
            dagelijksWerk = dagelijksWerk * 0.3; /*telt mee voor 30%*/
            project = project * 0.2; /*telt mee voor 20%*/
            herrekendExamen = examen * 0.5; /* telt mee voor 50%*/
            double totaal = Math.Round(project + dagelijksWerk + herrekendExamen, 1) * 5;

            // grade toekennen
            if (examen < 8)
            {
                totaal = Math.Min(examen, totaal) *  5;
            }

            if (totaal < 50)
            {
                grade = "Onvoldoende";
            }

            else if (totaal < 67.5)
            {
                grade = "Voldoende";
            }

            else if (totaal < 75)
            {
                grade = "Onderscheiding";
            }

            else if (totaal < 82.5)
            {
                grade = "Grote onderscheiding";
            }

            else
            {
                grade = "Grootste onderscheiding";
            }

            // eindcijfer weergeven
            Console.WriteLine($"Je eindcijfer is {totaal}%");
            Console.WriteLine();

            // grade weergeven
            Console.WriteLine($"--> {grade}");
            Console.ReadLine();
        }
    }
}
