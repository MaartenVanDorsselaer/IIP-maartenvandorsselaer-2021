using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaswoordenSorteren
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            string[] paswoorden = new string[7];
            paswoorden[0] = "klepketoe";
            paswoorden[1] = "test";
            paswoorden[2] = "Azerty123";
            paswoorden[3] = "rogier@work";
            paswoorden[4] = "paswoorden";
            paswoorden[5] = "MisterNasty12";
            paswoorden[6] = "pwnz0red";
            List<string> wachtwoordOk = new List<string>();
            List<string> wachtwoordNietOk = new List<string>();

            for (int i = 0; i < 7; i++)
            {
                if (paswoorden[i].Contains("@"))
                {
                    wachtwoordNietOk.Add(paswoorden[i]);
                }
                else if (paswoorden[i].Contains("paswoord"))
                {
                    wachtwoordNietOk.Add(paswoorden[i]);
                }
                else if (paswoorden[i].Length <= 8)
                {
                    wachtwoordNietOk.Add(paswoorden[i]);
                }
                else
                {
                    wachtwoordOk.Add(paswoorden[i]);
                }
            }
            Console.Write("Passwoorden: ");
            foreach (object password in paswoorden)
            {
                Console.Write($"{n}. " + password + Environment.NewLine);
                n++;
            }
            Console.Write("OK: ");
            foreach (object welOk in wachtwoordOk)
            {
                Console.Write(welOk + ", ");
            }
            Console.WriteLine();

            Console.Write("Niet OK: ");
            foreach (object nietOk in wachtwoordNietOk)
            {
                Console.Write(nietOk + ", ");
            }
            Console.ReadLine();
        }
    }
}
