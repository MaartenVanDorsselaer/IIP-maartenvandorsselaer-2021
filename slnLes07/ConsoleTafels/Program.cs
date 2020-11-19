using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    class Program
    {
        static private int VraagPositiefGetal()
        {
            // getal opvragen
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;
        }

        static private string DrukTafel(int getal, int lengte)
        {
            // maaltafel genereren
            string tafel="";
            for (int i = 1; i <= lengte; i++)
            {
                int vermenigvuldiging = getal * i;
                tafel += $"{getal} x {i} = {vermenigvuldiging}";
                tafel += Environment.NewLine;
            }
            // maaltafen sturen naar de main
            return tafel;
        }

        static void Main(string[] args)
        {
            // getal en lengte opvragen via methode om vervolgens mee te geven aan een volgende methode
            int basisGetal = VraagPositiefGetal();
            int lengte = VraagPositiefGetal();
            // maaltafel laten genereren
            string tafel = DrukTafel(basisGetal, lengte);
            // tafel weergeven in de console
            Console.WriteLine(tafel);
            Console.ReadLine();
        }
    }
}
