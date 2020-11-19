using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string scheiding = ", ";
            string laatste = " en ";
            int[] scores = new int[10];
            Random rnd = new Random();
            for( int i = 0; i< scores.Length; i++)
            {
                scores[i] = rnd.Next(0, 20);
            }
            int gemiddelde = BepaalGemiddelde(scores);
            int grootste = BepaalGrootste(scores);
            int kleinste = BepaalKleinste(scores);

            Console.Write("Scores test: ");
            PrintScores(scores, scheiding, laatste);
            Console.WriteLine();
            List<int> scoresConverted = new List<int>();
            for (int i = 0; i < scores.Length; i++)
            {
                scoresConverted.Add(scores[i]);
            }
            int positieGrootste = scoresConverted.ToList().IndexOf(grootste);
            int positieKleinste = scoresConverted.ToList().IndexOf(kleinste);

            Console.WriteLine($"De gemiddelde score van de test was: {gemiddelde} (positie {positieGrootste})");
            Console.WriteLine($"De slechtste score van de test was: {kleinste} (positie {positieKleinste})");
            Console.WriteLine($"De hoogste score van de test was: {grootste}");
            Console.ReadLine();
        }
        public static int BepaalGemiddelde(int [] scores)
        {
            int gemiddelde=0;
            for(int i = 0; i<scores.Length; i++)
            {
                gemiddelde += scores[i];
            }
            gemiddelde = gemiddelde / scores.Length;
            return gemiddelde;
        }
        public static int BepaalGrootste(int [] scores)
        {
            int grootste = scores[0];
            for (int i = 0; i< scores.Length; i++)
            {
                if (scores[i] > grootste)
                grootste = scores[i];
            }
            return grootste;
        }
        public static int BepaalKleinste(int[] scores)
        {
            int kleinste = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < kleinste)
                    kleinste = scores[i];
            }
            return kleinste;
        }

        public static void PrintScores(int[] scores, string scheiding, string laatste)
        {
            string puntenlijst = "";
            for(int i = 0; i < scores.Length-1; i++)
            {
                puntenlijst += scores[i] + scheiding;
            }
            Console.WriteLine($"{puntenlijst} {laatste} {scores[6]}");
        }
    }
}
