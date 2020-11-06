using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    class Program
    {
        static void Main(string[] args)
        {
            int asci;
            char teken;
            string geheimSchrift = "";
            // tekst opvragen en in variabele steken
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();
            int tekens = tekst.Length;

            Console.WriteLine($"Deze tekst bevat {tekens} tekens");
            for (int i= 0; i<tekens; i++)
            {
                asci = Convert.ToInt32(tekst.ElementAt(i));
                if (asci != 32)
                {
                    asci++;
                    teken = Convert.ToChar(asci);     
                }
                else
                {
                    teken = Convert.ToChar(asci);
                    
                }
                geheimSchrift += teken;
            }

            Console.WriteLine($"In geheim schrift: {geheimSchrift}");

            Console.ReadLine();

        }
    }
}
