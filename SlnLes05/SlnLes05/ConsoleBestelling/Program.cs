using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    class Program
    {
        static void Main(string[] args)
        {
            // hoofding weergeven
            Console.WriteLine();
            Console.WriteLine("PIZZA BESTELLING");
            Console.WriteLine("================");
            Console.WriteLine();

            // keuzes weergeven
            Console.WriteLine(@"Kies je pizza:
a) Margarita 8 euro
b) Funghi 10 euro
c) Diabolo 11 euro");

            // keuze pizza inlezen en in variabele steken
            Console.Write(">> Wat is je keuze? ");
            string pizza = Console.ReadLine().ToLower();
            Console.WriteLine();

            // keuze grootte inlezen en in variabele steken
            Console.WriteLine(@"Kies de grootte:
a) 15cm (klein; - 20%
b) 20 cm (normaal)
c) 25 cm (groot + 20%)");
            Console.Write(">> Wat is je keuze? ");
            string grootte = Console.ReadLine();
            Console.WriteLine();

            // keuze qua bezorging
            Console.Write("Thuis bezorgen (3 euro extra)? Ja/Nee");
            string bezorging = Console.ReadLine().ToLower();
            Console.WriteLine();

            // gepaste prijs weergeven
            switch (pizza)
            {
                case "a":
                    switch (grootte)
                    {
                        case "a":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Margarita klein, voor 9,4 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Margarita klein, voor 6,4 euro"); break;
                            };break;
                        case "b":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Margarita normaal, voor 11 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Margarita normaal, voor 8 euro"); break;
                            }; break;
                        case "c":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Margarita groot, voor 12,6 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Margarita groot, voor 9,6 euro"); break;
                            }; break;
                    }; break;
                case "b":
                    switch (grootte)
                    {
                        case "a":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Funghi klein, voor 11 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Funghi klein, voor 8 euro"); break;
                            }; break;
                        case "b":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Funghi normaal, voor 13 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Funghi normaal, voor 10 euro"); break;
                            }; break;
                        case "c":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Funghi groot, voor 15 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Funghi groot, voor 12 euro"); break;
                            }; break;
                    }; break;
                case "c":
                    switch (grootte)
                    {
                        case "a":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Diabolo klein, voor 11,8 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Diabolo klein, voor 8,8 euro"); break;
                            }; break;
                        case "b":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Diabolo normaal, voor 14 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Diabolo normaal, voor 11 euro"); break;
                            }; break;
                        case "c":
                            switch (bezorging)
                            {
                                case "ja": Console.WriteLine("Jouw bestelling: 1 pizza Diabolo groot, voor 16,2 euro, thuis bezorgd"); break;
                                case "nee": Console.WriteLine("Jouw bestelling: 1 pizza Diabolo groot, voor 13,2 euro"); break;
                            }; break;
                    }; break;
            }
            Console.ReadLine();
        }
    }
}
