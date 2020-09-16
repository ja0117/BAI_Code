using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_integerArray60
{
    class Program
    {
        static void Main(string[] args)
        {
            Oefening2();
        }
        public void Oefening1()
        {
            const int AANTAL = 60;
            const int MAX = 100;
            int[] getallen = new int[AANTAL];
            Random random = new Random();

            for (int i = 0; i < AANTAL; i++)
            {
                getallen[i] = random.Next(MAX);
            }

            int GrootsteIndex = 0;
            // Get Biggest index 
            for (int i = 1; i < AANTAL; i++)
            {
                if (getallen[i] > getallen[GrootsteIndex])
                {
                    GrootsteIndex = i;
                }
            }
            Console.WriteLine($"Het grootste getal is {getallen[GrootsteIndex]} en staat op plek {GrootsteIndex}");
            foreach (int getal in getallen)
            {
                Console.WriteLine($"Random Getal: {getal}");
            }
            Console.ReadLine();
        }

        public static void Oefening2() {
            const int AANTAL = 10;
            const int MAX = 60;
            int[] getallen = new int[AANTAL];
            Random random = new Random();

            for (int i = 0; i < AANTAL; i++)
            {
                getallen[i] = random.Next(MAX);
            }

            int kleinste, kleinsteAantal;
            int eenNaKleinste, eenNaKleinsteAantal;

            kleinsteAantal = eenNaKleinsteAantal = 0;
            kleinste = eenNaKleinste = MAX;

            // Get Index with smallest number and second to smallest number  n
            foreach (int getal in getallen)
            {
                if (getal < kleinste)
                {
                    eenNaKleinste = kleinste;
                    kleinste = getal;
                }
                else if (getal > kleinste && getal < eenNaKleinste)
                {
                    eenNaKleinste = getal;
                }
            }
            Console.WriteLine($"Het kleinste getal {kleinste} ({kleinsteAantal} x)");
            Console.WriteLine($"Het op 1 na kleinste getal is {eenNaKleinste} ({kleinsteAantal} x)");


            foreach (int getal in getallen)
            {
                Console.WriteLine($"Random Getal: {getal}");
            }
            Console.ReadLine();
        }

    }
}
